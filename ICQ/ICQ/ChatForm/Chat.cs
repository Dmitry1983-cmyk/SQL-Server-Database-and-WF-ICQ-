using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICQ.ChatForm
{
    public partial class Chat : Form
    {
       public Form1 f = new Form1();
        public int count_contacts;

        public Chat()
        {
            InitializeComponent();
            Num_Phone_Button();
        }
        public string tmp_path;

        public void Checked_Contacts(object sender, EventArgs e)
        {
            var radio = (RadioButton)sender;
            if (radio.Checked)
            {
                txt_Chat.Clear();
                lab_NickName_Contact.Text = radio.Text;
                //
                //Создание Файла Истории с названием никнейма-контактата
                string path_File = $"G:\\Проекты\\ICQ\\ICQ\\bin\\Debug\\{lab_NickName_User.Text}\\History\\{lab_NickName_Contact.Text}.txt";
                using (FileStream fstream = new FileStream(path_File, FileMode.OpenOrCreate))
                {
                    // преобразуем строку в байты
                    byte[] array = System.Text.Encoding.Default.GetBytes(txt_Chat.Text);
                    // запись массива байтов в файл
                    fstream.Write(array, 0, array.Length);
                }
                tmp_path = path_File;
                //

                //Создание Папки с Именем Собеседника
                string path_Folder = $"G:\\Проекты\\ICQ\\ICQ\\bin\\Debug\\{lab_NickName_Contact.Text}";
                if (!Directory.Exists(path_Folder))
                {
                    Directory.CreateDirectory(path_Folder);
                }
                //Создание Папки History с каталоге Собеседника
                string path_Folder_History = $"G:\\Проекты\\ICQ\\ICQ\\bin\\Debug\\{lab_NickName_Contact.Text}\\History";
                if (!Directory.Exists(path_Folder_History))
                {
                    Directory.CreateDirectory(path_Folder_History);
                }
                //запихиваем фотку в picturebox_contct
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = (@"Data Source=DMITRY-ПК;Initial Catalog=ICQ_DB;User=Dmitry-ПК\Dmitry;Integrated Security=SSPI;");//дом
                connection.Open();
                string chek_data = $"select * from User_Data join LoginPassword on User_data.Id=LoginPassword.Id join Photo_table on LoginPassword.Id=Photo_table.Id where ([NickName]='{radio.Text}')";
                SqlCommand command = new SqlCommand(chek_data, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    byte[] img = (byte[])(reader[11]);
                    pictureBox_Contact.SizeMode = PictureBoxSizeMode.StretchImage;
                    if (img == null)
                        pictureBox_Contact.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox_Contact.Image = Image.FromStream(ms);
                    }
                }
                connection.Close();
                //
            }
            //загрузка истории
            txt_Chat.Clear();
            string history_file= $"G:\\Проекты\\ICQ\\ICQ\\bin\\Debug\\{lab_NickName_User.Text}\\History\\{lab_NickName_Contact.Text}.txt";
            using (FileStream fstream = File.OpenRead(history_file))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                txt_Chat.Text = textFromFile;
            }
            //
        }

        private void btn_Send_Msg_Click(object sender, EventArgs e)
        {
            if (txt_Dialog.Text!="")
            {
                txt_Chat.Text += $"{lab_NickName_User.Text+" "+"("+DateTime.Now.ToShortTimeString()+")"}{Environment.NewLine}{txt_Dialog.Text}{Environment.NewLine}{Environment.NewLine}";

                using (FileStream fstream = new FileStream(tmp_path, FileMode.OpenOrCreate))
                {
                    // преобразуем строку в байты
                    byte[] array = System.Text.Encoding.Default.GetBytes(txt_Chat.Text);
                    // запись массива байтов в файл
                    fstream.Write(array, 0, array.Length);
                }
                //Создание Файла Истории с названием никнейма-контактата собеседника
                string path_File_vizavi = $"G:\\Проекты\\ICQ\\ICQ\\bin\\Debug\\{lab_NickName_Contact.Text}\\History\\{lab_NickName_User.Text}.txt";
                using (FileStream fstream = new FileStream(path_File_vizavi, FileMode.OpenOrCreate))
                {
                    // преобразуем строку в байты
                    byte[] array = System.Text.Encoding.Default.GetBytes(txt_Chat.Text);
                    // запись массива байтов в файл
                    fstream.Write(array, 0, array.Length);
                }
                /////////////////////..............................................................
                txt_Dialog.Clear();
            }
        }

        private void Count_Contacts_in_DB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = (@"Data Source=DMITRY-ПК;Initial Catalog=ICQ_DB;User=Dmitry-ПК\Dmitry;Integrated Security=SSPI;");
            conn.Open();
            string count_field = $"select count(Id) from User_Data ";
            SqlCommand com_out_contact = new SqlCommand(count_field, conn);
            count_contacts = Convert.ToInt32(com_out_contact.ExecuteScalar());//количество строк из БД
        }
        private void Num_Phone_Button ()
        {
            Button[] num_but = new Button[9];
            int startX = 6;
            int startY = 99;

            const int SIZE = 20;

            for (int i = 0; i < 3; i++)
            {
                startX = 10;
                for (int j = 1; j <= 3; j++)
                {
                    num_but[i] = new Button();
                    num_but[i].Text = (j + i * 3).ToString();
                    num_but[i].Size = new Size(SIZE, SIZE);
                    num_but[i].Location = new Point(startX, startY);
                    num_but[i].BackColor = Color.YellowGreen;
                    num_but[i].Click += Num_Phone_Button_Click;
                    groupBox_Phone.Controls.Add(num_but[i]);

                    startX += (SIZE + (SIZE / 3));
                }
                startY += (SIZE + (SIZE / 3));
            }
            Button btn_num_ph_Number_0 = new Button();
            btn_num_ph_Number_0.Size = new Size(20,20);
            btn_num_ph_Number_0.Text = "0";
            btn_num_ph_Number_0.Location = new Point(88,151);
            btn_num_ph_Number_0.Click += Num_Phone_Button_Click;
            btn_num_ph_Number_0.BackColor = Color.YellowGreen;
            groupBox_Phone.Controls.Add(btn_num_ph_Number_0);
        }

        private void Num_Phone_Button_Click(object sender, EventArgs e)
        {
            var num = (Button)sender;
            txt_Num_Phone_Find.Text += num.Text;
        }
        private void Txt_txt_Num_Phone_Find_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8) //ch 8  это аскикод Backspace
            {
                e.Handled = true;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Num_Phone_Find.Clear();
        }

        private void btn_Call_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не доделано");
        }

        private void btn_Scape_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не доделано");
        }

        private void Send_Msg_to_Phone(object sender, EventArgs e)
        {
            MessageBox.Show("Не доделано");
            //try
            //{
            //    WebClient client = new WebClient();
            //    //сюда запихнуьб API
            //    Stream s = client.OpenRead(string.Format("https://platform.clickatell.com/messages/http/send?apiKey=LRGJloINQHimkq0FdElx_w==&to=1234567890&content=Test+message+text",txt_Num_Phone_Find.Text,txt_Msg.Text));
            //    StreamReader reader = new StreamReader(s);
            //    string result = reader.ReadToEnd();
            //    MessageBox.Show(result,"Сообщение ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    txt_Msg.Clear();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
