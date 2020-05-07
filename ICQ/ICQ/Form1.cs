using ICQ.ChatForm;
using ICQ.RegistrationForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICQ
{
    public partial class Form1 : Form
    {
        public string tmp_login;
        public string tmp_pass;
        public Form1()
        {
            InitializeComponent();
            txt_Pass.UseSystemPasswordChar = true;
        }

        private void CheckBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_Pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Pass.UseSystemPasswordChar = true;
            }
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            Chat chat = new Chat();
            if (txt_Login.Text!="")
            {
                if (txt_Pass.Text != "")
                {
                    tmp_login = txt_Login.Text;
                    tmp_pass = txt_Pass.Text;
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = (@"Data Source=DMITRY-ПК;Initial Catalog=ICQ_DB;User=Dmitry-ПК\Dmitry;Integrated Security=SSPI;");//дом
                    connection.Open();
                    string chek_data = $"select * from User_Data join LoginPassword on User_data.Id=LoginPassword.Id join Photo_table on LoginPassword.Id=Photo_table.Id where [Login]='{txt_Login.Text}' and [Password]='{txt_Pass.Text}'";
                    SqlCommand command = new SqlCommand(chek_data, connection);
                    //вносим все данные -хистори, потом открываем форму

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        chat.lab_PhoneNum_User.Text = reader[4].ToString();
                        chat.lab_NickName_User.Text = reader[3].ToString();
                        chat.lab_Mail_User.Text = reader[5].ToString();

                        byte[] img = (byte[])(reader[11]);
                        chat.pictureBox_User.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (img == null)
                            chat.pictureBox_User.Image = null;
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            chat.pictureBox_User.Image = Image.FromStream(ms);
                        }

                        //Create Folder with NickName User
                        string path_Folder = $"G:\\Проекты\\ICQ\\ICQ\\bin\\Debug\\{chat.lab_NickName_User.Text}";
                        if (!Directory.Exists(path_Folder))
                        {
                            Directory.CreateDirectory(path_Folder);
                        }
                        //Create Folder History with NickName User
                        string path_Folder_History = $"G:\\Проекты\\ICQ\\ICQ\\bin\\Debug\\{chat.lab_NickName_User.Text}\\History";
                        if (!Directory.Exists(path_Folder_History))
                        {
                            Directory.CreateDirectory(path_Folder_History);
                        }
                        //Create HelpFile(Login&Password User)
                        string path_File = $"G:\\Проекты\\ICQ\\ICQ\\bin\\Debug\\{chat.lab_NickName_User.Text}\\{chat.lab_NickName_User.Text} Login and Password.txt";
                        if (!File.Exists(path_File))
                        {
                            using (FileStream fs = File.Create(path_File))//create File
                            {
                                byte[] info = new UTF8Encoding(true).GetBytes($"Login User : {txt_Login.Text}{Environment.NewLine}Password User : {txt_Pass.Text}");
                                fs.Write(info, 0, info.Length);
                            }
                        }

                        connection.Close();

                        //
                        //занесли все контакты кроме себя
                        SqlConnection conn = new SqlConnection();
                        conn.ConnectionString = (@"Data Source=DMITRY-ПК;Initial Catalog=ICQ_DB;User=Dmitry-ПК\Dmitry;Integrated Security=SSPI;");
                        conn.Open();

                        string nick_name = $"select * from User_Data join LoginPassword on User_data.Id=LoginPassword.Id join Photo_table on LoginPassword.Id=Photo_table.Id where ([Login]<>'{tmp_login}')";
                        SqlCommand com_out_contact_from_DB = new SqlCommand(nick_name, conn);
                        SqlDataReader reader_contact = com_out_contact_from_DB.ExecuteReader();
                        DataTable table_contact = new DataTable();
                        table_contact.Load(reader_contact);
                        reader_contact.Close();
                        RadioButton[] rad = new RadioButton[table_contact.Rows.Count];
                        for (int i = 0; i < table_contact.Rows.Count; i++)
                        {
                            rad[i] = new RadioButton();
                            rad[i].Text = table_contact.Rows[i][3].ToString();
                            rad[i].Location = new Point(15, 10 + i * 20);
                            rad[i].CheckedChanged +=chat. Checked_Contacts;
                           chat. panel_Contacts.Controls.Add(rad[i]);

                        }
                        conn.Close();
                        //
                        chat.Show();
                        txt_Login.Clear();
                        txt_Pass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Не верный логин или пароль!");
                    }
                    txt_Login.Clear();
                    txt_Pass.Clear();
                }
                else {
                    MessageBox.Show("Введи пароль");
                }
            }
            else
            {
                MessageBox.Show("Введи логин");
            }
        }

        private void btn_Registration_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }
    }
}
