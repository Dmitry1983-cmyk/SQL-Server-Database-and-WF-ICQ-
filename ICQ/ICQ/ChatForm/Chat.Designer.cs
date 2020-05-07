using System;
using System.Windows.Forms;

namespace ICQ.ChatForm
{
    partial class Chat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.panel_Contacts = new System.Windows.Forms.Panel();
            this.panel_Choice_Contact = new System.Windows.Forms.Panel();
            this.lab_NickName_Contact = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_User = new System.Windows.Forms.PictureBox();
            this.lab_NickName_User = new System.Windows.Forms.Label();
            this.lab_Mail_User = new System.Windows.Forms.Label();
            this.lab_PhoneNum_User = new System.Windows.Forms.Label();
            this.pictureBox_Contact = new System.Windows.Forms.PictureBox();
            this.btn_Send_Msg = new System.Windows.Forms.Button();
            this.txt_Dialog = new System.Windows.Forms.TextBox();
            this.txt_Chat = new System.Windows.Forms.TextBox();
            this.groupBox_Title = new System.Windows.Forms.GroupBox();
            this.groupBox_Contacts = new System.Windows.Forms.GroupBox();
            this.groupBox_Phone = new System.Windows.Forms.GroupBox();
            this.btn_Send_Msg_to_Phone = new System.Windows.Forms.Button();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Scape = new System.Windows.Forms.Button();
            this.btn_Call = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_Num_Phone_Find = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel_Choice_Contact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Contact)).BeginInit();
            this.groupBox_Title.SuspendLayout();
            this.groupBox_Contacts.SuspendLayout();
            this.groupBox_Phone.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Contacts
            // 
            this.panel_Contacts.AutoScroll = true;
            this.panel_Contacts.BackColor = System.Drawing.Color.Ivory;
            this.panel_Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_Contacts.Location = new System.Drawing.Point(6, 25);
            this.panel_Contacts.Name = "panel_Contacts";
            this.panel_Contacts.Size = new System.Drawing.Size(257, 196);
            this.panel_Contacts.TabIndex = 0;
            // 
            // panel_Choice_Contact
            // 
            this.panel_Choice_Contact.BackColor = System.Drawing.Color.YellowGreen;
            this.panel_Choice_Contact.Controls.Add(this.lab_NickName_Contact);
            this.panel_Choice_Contact.Location = new System.Drawing.Point(6, 18);
            this.panel_Choice_Contact.Name = "panel_Choice_Contact";
            this.panel_Choice_Contact.Size = new System.Drawing.Size(390, 38);
            this.panel_Choice_Contact.TabIndex = 1;
            // 
            // lab_NickName_Contact
            // 
            this.lab_NickName_Contact.AutoSize = true;
            this.lab_NickName_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_NickName_Contact.Location = new System.Drawing.Point(3, 3);
            this.lab_NickName_Contact.Name = "lab_NickName_Contact";
            this.lab_NickName_Contact.Size = new System.Drawing.Size(80, 24);
            this.lab_NickName_Contact.TabIndex = 4;
            this.lab_NickName_Contact.Text = "контакт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(82, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "nickname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(82, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "e-mail :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "phone num :";
            // 
            // pictureBox_User
            // 
            this.pictureBox_User.Location = new System.Drawing.Point(6, 25);
            this.pictureBox_User.Name = "pictureBox_User";
            this.pictureBox_User.Size = new System.Drawing.Size(70, 81);
            this.pictureBox_User.TabIndex = 0;
            this.pictureBox_User.TabStop = false;
            // 
            // lab_NickName_User
            // 
            this.lab_NickName_User.AutoSize = true;
            this.lab_NickName_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_NickName_User.Location = new System.Drawing.Point(147, 74);
            this.lab_NickName_User.Name = "lab_NickName_User";
            this.lab_NickName_User.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab_NickName_User.Size = new System.Drawing.Size(35, 13);
            this.lab_NickName_User.TabIndex = 7;
            this.lab_NickName_User.Text = "label1";
            // 
            // lab_Mail_User
            // 
            this.lab_Mail_User.AutoSize = true;
            this.lab_Mail_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_Mail_User.Location = new System.Drawing.Point(128, 51);
            this.lab_Mail_User.Name = "lab_Mail_User";
            this.lab_Mail_User.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab_Mail_User.Size = new System.Drawing.Size(35, 13);
            this.lab_Mail_User.TabIndex = 6;
            this.lab_Mail_User.Text = "label1";
            // 
            // lab_PhoneNum_User
            // 
            this.lab_PhoneNum_User.AutoSize = true;
            this.lab_PhoneNum_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_PhoneNum_User.Location = new System.Drawing.Point(154, 25);
            this.lab_PhoneNum_User.Name = "lab_PhoneNum_User";
            this.lab_PhoneNum_User.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab_PhoneNum_User.Size = new System.Drawing.Size(35, 13);
            this.lab_PhoneNum_User.TabIndex = 5;
            this.lab_PhoneNum_User.Text = "label1";
            // 
            // pictureBox_Contact
            // 
            this.pictureBox_Contact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Contact.BackgroundImage")));
            this.pictureBox_Contact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Contact.Location = new System.Drawing.Point(702, 12);
            this.pictureBox_Contact.Name = "pictureBox_Contact";
            this.pictureBox_Contact.Size = new System.Drawing.Size(85, 106);
            this.pictureBox_Contact.TabIndex = 3;
            this.pictureBox_Contact.TabStop = false;
            // 
            // btn_Send_Msg
            // 
            this.btn_Send_Msg.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Send_Msg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Send_Msg.BackgroundImage")));
            this.btn_Send_Msg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Send_Msg.Location = new System.Drawing.Point(343, 19);
            this.btn_Send_Msg.Name = "btn_Send_Msg";
            this.btn_Send_Msg.Size = new System.Drawing.Size(60, 38);
            this.btn_Send_Msg.TabIndex = 1;
            this.btn_Send_Msg.UseVisualStyleBackColor = false;
            this.btn_Send_Msg.Click += new System.EventHandler(this.btn_Send_Msg_Click);
            // 
            // txt_Dialog
            // 
            this.txt_Dialog.BackColor = System.Drawing.Color.Ivory;
            this.txt_Dialog.Location = new System.Drawing.Point(6, 12);
            this.txt_Dialog.MaxLength = 200;
            this.txt_Dialog.Multiline = true;
            this.txt_Dialog.Name = "txt_Dialog";
            this.txt_Dialog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Dialog.Size = new System.Drawing.Size(332, 75);
            this.txt_Dialog.TabIndex = 0;
            // 
            // txt_Chat
            // 
            this.txt_Chat.BackColor = System.Drawing.Color.White;
            this.txt_Chat.Location = new System.Drawing.Point(6, 62);
            this.txt_Chat.Multiline = true;
            this.txt_Chat.Name = "txt_Chat";
            this.txt_Chat.ReadOnly = true;
            this.txt_Chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Chat.Size = new System.Drawing.Size(390, 316);
            this.txt_Chat.TabIndex = 3;
            this.txt_Chat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox_Title
            // 
            this.groupBox_Title.Controls.Add(this.label3);
            this.groupBox_Title.Controls.Add(this.pictureBox_User);
            this.groupBox_Title.Controls.Add(this.label2);
            this.groupBox_Title.Controls.Add(this.lab_Mail_User);
            this.groupBox_Title.Controls.Add(this.label1);
            this.groupBox_Title.Controls.Add(this.lab_PhoneNum_User);
            this.groupBox_Title.Controls.Add(this.lab_NickName_User);
            this.groupBox_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Title.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Title.Name = "groupBox_Title";
            this.groupBox_Title.Size = new System.Drawing.Size(269, 121);
            this.groupBox_Title.TabIndex = 4;
            this.groupBox_Title.TabStop = false;
            this.groupBox_Title.Text = "icq";
            // 
            // groupBox_Contacts
            // 
            this.groupBox_Contacts.Controls.Add(this.panel_Contacts);
            this.groupBox_Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Contacts.Location = new System.Drawing.Point(12, 139);
            this.groupBox_Contacts.Name = "groupBox_Contacts";
            this.groupBox_Contacts.Size = new System.Drawing.Size(269, 227);
            this.groupBox_Contacts.TabIndex = 5;
            this.groupBox_Contacts.TabStop = false;
            this.groupBox_Contacts.Text = "Контакты";
            // 
            // groupBox_Phone
            // 
            this.groupBox_Phone.Controls.Add(this.btn_Send_Msg_to_Phone);
            this.groupBox_Phone.Controls.Add(this.txt_Msg);
            this.groupBox_Phone.Controls.Add(this.label5);
            this.groupBox_Phone.Controls.Add(this.label4);
            this.groupBox_Phone.Controls.Add(this.btn_Scape);
            this.groupBox_Phone.Controls.Add(this.btn_Call);
            this.groupBox_Phone.Controls.Add(this.btn_Clear);
            this.groupBox_Phone.Controls.Add(this.txt_Num_Phone_Find);
            this.groupBox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Phone.Location = new System.Drawing.Point(12, 372);
            this.groupBox_Phone.Name = "groupBox_Phone";
            this.groupBox_Phone.Size = new System.Drawing.Size(257, 178);
            this.groupBox_Phone.TabIndex = 6;
            this.groupBox_Phone.TabStop = false;
            this.groupBox_Phone.Text = "Телефон";
            // 
            // btn_Send_Msg_to_Phone
            // 
            this.btn_Send_Msg_to_Phone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Send_Msg_to_Phone.BackgroundImage")));
            this.btn_Send_Msg_to_Phone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Send_Msg_to_Phone.Location = new System.Drawing.Point(138, 76);
            this.btn_Send_Msg_to_Phone.Name = "btn_Send_Msg_to_Phone";
            this.btn_Send_Msg_to_Phone.Size = new System.Drawing.Size(48, 42);
            this.btn_Send_Msg_to_Phone.TabIndex = 7;
            this.btn_Send_Msg_to_Phone.UseVisualStyleBackColor = true;
            this.btn_Send_Msg_to_Phone.Click += new System.EventHandler(this.Send_Msg_to_Phone);
            // 
            // txt_Msg
            // 
            this.txt_Msg.Location = new System.Drawing.Point(71, 49);
            this.txt_Msg.MaxLength = 15;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.Size = new System.Drawing.Size(180, 20);
            this.txt_Msg.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "СМС";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "телефон";
            // 
            // btn_Scape
            // 
            this.btn_Scape.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Scape.BackgroundImage")));
            this.btn_Scape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Scape.Location = new System.Drawing.Point(192, 130);
            this.btn_Scape.Name = "btn_Scape";
            this.btn_Scape.Size = new System.Drawing.Size(48, 42);
            this.btn_Scape.TabIndex = 3;
            this.btn_Scape.UseVisualStyleBackColor = true;
            this.btn_Scape.Click += new System.EventHandler(this.btn_Scape_Click);
            // 
            // btn_Call
            // 
            this.btn_Call.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Call.BackgroundImage")));
            this.btn_Call.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Call.Location = new System.Drawing.Point(138, 130);
            this.btn_Call.Name = "btn_Call";
            this.btn_Call.Size = new System.Drawing.Size(48, 42);
            this.btn_Call.TabIndex = 2;
            this.btn_Call.UseVisualStyleBackColor = true;
            this.btn_Call.Click += new System.EventHandler(this.btn_Call_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Clear.Location = new System.Drawing.Point(88, 99);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(37, 24);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "C";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_Num_Phone_Find
            // 
            this.txt_Num_Phone_Find.Location = new System.Drawing.Point(71, 19);
            this.txt_Num_Phone_Find.MaxLength = 15;
            this.txt_Num_Phone_Find.Name = "txt_Num_Phone_Find";
            this.txt_Num_Phone_Find.Size = new System.Drawing.Size(180, 20);
            this.txt_Num_Phone_Find.TabIndex = 0;
            this.txt_Num_Phone_Find.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_txt_Num_Phone_Find_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Dialog);
            this.groupBox1.Controls.Add(this.btn_Send_Msg);
            this.groupBox1.Location = new System.Drawing.Point(287, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel_Choice_Contact);
            this.groupBox2.Controls.Add(this.txt_Chat);
            this.groupBox2.Location = new System.Drawing.Point(294, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 384);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Чат";
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(799, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Phone);
            this.Controls.Add(this.pictureBox_Contact);
            this.Controls.Add(this.groupBox_Contacts);
            this.Controls.Add(this.groupBox_Title);
            this.MaximumSize = new System.Drawing.Size(815, 600);
            this.MinimumSize = new System.Drawing.Size(815, 545);
            this.Name = "Chat";
            this.Text = "Chat";
            this.panel_Choice_Contact.ResumeLayout(false);
            this.panel_Choice_Contact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Contact)).EndInit();
            this.groupBox_Title.ResumeLayout(false);
            this.groupBox_Title.PerformLayout();
            this.groupBox_Contacts.ResumeLayout(false);
            this.groupBox_Phone.ResumeLayout(false);
            this.groupBox_Phone.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        public System.Windows.Forms.Panel panel_Contacts;
        public System.Windows.Forms.Panel panel_Choice_Contact;
        public System.Windows.Forms.Button btn_Send_Msg;
        public System.Windows.Forms.TextBox txt_Dialog;
        public System.Windows.Forms.Label lab_NickName_Contact;
        public System.Windows.Forms.PictureBox pictureBox_Contact;
        public System.Windows.Forms.PictureBox pictureBox_User;
        public System.Windows.Forms.Label lab_NickName_User;
        public System.Windows.Forms.Label lab_Mail_User;
        public System.Windows.Forms.Label lab_PhoneNum_User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Chat;
        private System.Windows.Forms.GroupBox groupBox_Title;
        private System.Windows.Forms.GroupBox groupBox_Contacts;
        private System.Windows.Forms.GroupBox groupBox_Phone;
        public System.Windows.Forms.TextBox txt_Num_Phone_Find;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Button btn_Clear;
        private Button btn_Scape;
        private Button btn_Call;
        private Label label4;
        private Button btn_Send_Msg_to_Phone;
        private TextBox txt_Msg;
        private Label label5;
    }
}