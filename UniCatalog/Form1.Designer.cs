namespace UniCatalog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tb_password = new TextBox();
            tb_username = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            btnAd = new Button();
            btnProf = new Button();
            btnSt = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(820, 167);
            label1.Name = "label1";
            label1.Size = new Size(258, 55);
            label1.TabIndex = 0;
            label1.Text = "UniCatalog";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tb_password);
            panel1.Controls.Add(tb_username);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Bookman Old Style", 16.2F);
            panel1.Location = new Point(703, 225);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 416);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(177, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 144);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // tb_password
            // 
            tb_password.Font = new Font("Bookman Old Style", 16.2F);
            tb_password.Location = new Point(177, 243);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(265, 39);
            tb_password.TabIndex = 4;
            // 
            // tb_username
            // 
            tb_username.Font = new Font("Bookman Old Style", 16.2F);
            tb_username.Location = new Point(177, 187);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(267, 39);
            tb_username.TabIndex = 3;
            tb_username.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(175, 320);
            button1.Name = "button1";
            button1.Size = new Size(115, 38);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 16.2F);
            label3.Location = new Point(26, 243);
            label3.Name = "label3";
            label3.Size = new Size(145, 33);
            label3.TabIndex = 1;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 16.2F);
            label2.Location = new Point(19, 187);
            label2.Name = "label2";
            label2.Size = new Size(152, 33);
            label2.TabIndex = 0;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // btnAd
            // 
            btnAd.Font = new Font("Bookman Old Style", 36F, FontStyle.Bold | FontStyle.Italic);
            btnAd.ForeColor = Color.Red;
            btnAd.Location = new Point(300, 506);
            btnAd.Name = "btnAd";
            btnAd.Size = new Size(324, 77);
            btnAd.TabIndex = 4;
            btnAd.Text = "ADMIN";
            btnAd.UseVisualStyleBackColor = true;
            btnAd.Visible = false;
            btnAd.Click += button4_Click;
            // 
            // btnProf
            // 
            btnProf.Font = new Font("Bookman Old Style", 36F, FontStyle.Bold | FontStyle.Italic);
            btnProf.ForeColor = Color.Red;
            btnProf.Location = new Point(265, 365);
            btnProf.Name = "btnProf";
            btnProf.Size = new Size(393, 80);
            btnProf.TabIndex = 3;
            btnProf.Text = "PROFESOR";
            btnProf.UseVisualStyleBackColor = true;
            btnProf.Visible = false;
            btnProf.Click += btnProf_Click;
            // 
            // btnSt
            // 
            btnSt.Font = new Font("Bookman Old Style", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSt.ForeColor = Color.Red;
            btnSt.Location = new Point(278, 225);
            btnSt.Name = "btnSt";
            btnSt.Size = new Size(370, 72);
            btnSt.TabIndex = 2;
            btnSt.Text = "STUDENT";
            btnSt.UseVisualStyleBackColor = true;
            btnSt.Visible = false;
            btnSt.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1463, 704);
            Controls.Add(btnAd);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnProf);
            Controls.Add(btnSt);
            Name = "Form1";
            Text = "UniCatalog";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox tb_password;
        private TextBox tb_username;
        private Button button1;
        private Label label3;
        private Label label2;
        private Button btnSt;
        private Button btnProf;
        private Button btnAd;
    }
}
