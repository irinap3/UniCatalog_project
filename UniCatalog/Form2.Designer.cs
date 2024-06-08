namespace UniCatalog
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            detaliiStudentToolStripMenuItem = new ToolStripMenuItem();
            noteToolStripMenuItem = new ToolStripMenuItem();
            taxeToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            pDetails = new Panel();
            lGrupa = new Label();
            lFacultate = new Label();
            lInitTata = new Label();
            lDataInsc = new Label();
            lPren = new Label();
            lNume = new Label();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            lProgrStudii = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            pDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(94, 386);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 328);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { detaliiStudentToolStripMenuItem, noteToolStripMenuItem, taxeToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1413, 173);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // detaliiStudentToolStripMenuItem
            // 
            detaliiStudentToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            detaliiStudentToolStripMenuItem.Image = (Image)resources.GetObject("detaliiStudentToolStripMenuItem.Image");
            detaliiStudentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            detaliiStudentToolStripMenuItem.Name = "detaliiStudentToolStripMenuItem";
            detaliiStudentToolStripMenuItem.Padding = new Padding(9, 6, 9, 6);
            detaliiStudentToolStripMenuItem.Size = new Size(178, 169);
            detaliiStudentToolStripMenuItem.Text = "Detalii student";
            detaliiStudentToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage;
            detaliiStudentToolStripMenuItem.Click += detaliiStudentToolStripMenuItem_Click;
            // 
            // noteToolStripMenuItem
            // 
            noteToolStripMenuItem.Image = (Image)resources.GetObject("noteToolStripMenuItem.Image");
            noteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            noteToolStripMenuItem.Size = new Size(142, 169);
            noteToolStripMenuItem.Text = "Note";
            noteToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage;
            noteToolStripMenuItem.Click += noteToolStripMenuItem_Click;
            // 
            // taxeToolStripMenuItem
            // 
            taxeToolStripMenuItem.Image = (Image)resources.GetObject("taxeToolStripMenuItem.Image");
            taxeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            taxeToolStripMenuItem.Name = "taxeToolStripMenuItem";
            taxeToolStripMenuItem.Size = new Size(142, 169);
            taxeToolStripMenuItem.Text = "Taxe";
            taxeToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage;
            taxeToolStripMenuItem.Click += taxeToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Image = (Image)resources.GetObject("logOutToolStripMenuItem.Image");
            logOutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(142, 169);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage;
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // pDetails
            // 
            pDetails.BackColor = Color.Transparent;
            pDetails.Controls.Add(lProgrStudii);
            pDetails.Controls.Add(label4);
            pDetails.Controls.Add(lGrupa);
            pDetails.Controls.Add(lFacultate);
            pDetails.Controls.Add(lInitTata);
            pDetails.Controls.Add(lDataInsc);
            pDetails.Controls.Add(lPren);
            pDetails.Controls.Add(lNume);
            pDetails.Controls.Add(label9);
            pDetails.Controls.Add(label7);
            pDetails.Controls.Add(label5);
            pDetails.Controls.Add(label3);
            pDetails.Controls.Add(label2);
            pDetails.Controls.Add(label1);
            pDetails.Location = new Point(582, 317);
            pDetails.Name = "pDetails";
            pDetails.Size = new Size(676, 599);
            pDetails.TabIndex = 2;
            pDetails.Visible = false;
            pDetails.Paint += pDetails_Paint;
            // 
            // lGrupa
            // 
            lGrupa.AutoSize = true;
            lGrupa.Font = new Font("Times New Roman", 22.2F);
            lGrupa.Location = new Point(255, 491);
            lGrupa.Name = "lGrupa";
            lGrupa.Size = new Size(124, 42);
            lGrupa.TabIndex = 11;
            lGrupa.Text = "label12";
            // 
            // lFacultate
            // 
            lFacultate.AutoSize = true;
            lFacultate.Font = new Font("Times New Roman", 22.2F);
            lFacultate.Location = new Point(274, 355);
            lFacultate.Name = "lFacultate";
            lFacultate.Size = new Size(123, 42);
            lFacultate.TabIndex = 10;
            lFacultate.Text = "label11";
            // 
            // lInitTata
            // 
            lInitTata.AutoSize = true;
            lInitTata.Font = new Font("Times New Roman", 22.2F);
            lInitTata.Location = new Point(345, 286);
            lInitTata.Name = "lInitTata";
            lInitTata.Size = new Size(124, 42);
            lInitTata.TabIndex = 9;
            lInitTata.Text = "label10";
            // 
            // lDataInsc
            // 
            lDataInsc.AutoSize = true;
            lDataInsc.Font = new Font("Times New Roman", 22.2F);
            lDataInsc.Location = new Point(345, 214);
            lDataInsc.Name = "lDataInsc";
            lDataInsc.Size = new Size(105, 42);
            lDataInsc.TabIndex = 8;
            lDataInsc.Text = "label9";
            // 
            // lPren
            // 
            lPren.AutoSize = true;
            lPren.Font = new Font("Times New Roman", 22.2F);
            lPren.Location = new Point(246, 137);
            lPren.Name = "lPren";
            lPren.Size = new Size(105, 42);
            lPren.TabIndex = 7;
            lPren.Text = "label8";
            // 
            // lNume
            // 
            lNume.AutoSize = true;
            lNume.Font = new Font("Times New Roman", 22.2F);
            lNume.Location = new Point(246, 56);
            lNume.Name = "lNume";
            lNume.Size = new Size(105, 42);
            lNume.TabIndex = 6;
            lNume.Text = "label7";
            lNume.Click += lNume_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(52, 488);
            label9.Name = "label9";
            label9.Size = new Size(132, 45);
            label9.TabIndex = 5;
            label9.Text = "Grupa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(52, 420);
            label7.Name = "label7";
            label7.Size = new Size(327, 45);
            label7.TabIndex = 4;
            label7.Text = "Program de studii";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(52, 352);
            label5.Name = "label5";
            label5.Size = new Size(179, 45);
            label5.TabIndex = 3;
            label5.Text = "Facultate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 214);
            label3.Name = "label3";
            label3.Size = new Size(265, 45);
            label3.TabIndex = 2;
            label3.Text = "Data înscrierii";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 137);
            label2.Name = "label2";
            label2.Size = new Size(174, 45);
            label2.TabIndex = 1;
            label2.Text = "Prenume";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 56);
            label1.Name = "label1";
            label1.Size = new Size(122, 45);
            label1.TabIndex = 0;
            label1.Text = "Nume";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(52, 286);
            label4.Name = "label4";
            label4.Size = new Size(262, 45);
            label4.TabIndex = 12;
            label4.Text = "Inițiala tatălui";
            label4.Click += label7_Click;
            // 
            // lProgrStudii
            // 
            lProgrStudii.AutoSize = true;
            lProgrStudii.Font = new Font("Times New Roman", 22.2F);
            lProgrStudii.Location = new Point(398, 423);
            lProgrStudii.Name = "lProgrStudii";
            lProgrStudii.Size = new Size(124, 42);
            lProgrStudii.TabIndex = 13;
            lProgrStudii.Text = "label12";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1413, 943);
            Controls.Add(pDetails);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Name = "Form2";
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pDetails.ResumeLayout(false);
            pDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem detaliiStudentToolStripMenuItem;
        private ToolStripMenuItem noteToolStripMenuItem;
        private ToolStripMenuItem taxeToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Panel pDetails;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label lGrupa;
        private Label lFacultate;
        private Label lInitTata;
        private Label lDataInsc;
        private Label lPren;
        private Label lNume;
        private Label label4;
        private Label lProgrStudii;
    }
}