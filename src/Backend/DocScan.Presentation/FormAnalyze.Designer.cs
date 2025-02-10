namespace DocScan.Presentation
{
    partial class FormAnalyze
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblResponse = new Label();
            panel2 = new Panel();
            btnSelectArchive = new Button();
            txtBoxArchive = new TextBox();
            txtBoxDescription = new TextBox();
            cbxTheme = new ComboBox();
            txtArchive = new Label();
            txtDescription = new Label();
            txtTheme = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtBoxResponse = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblResponse);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.LOGO_REDES;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(344, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblResponse
            // 
            lblResponse.AutoSize = true;
            lblResponse.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResponse.ForeColor = SystemColors.ButtonFace;
            lblResponse.Location = new Point(608, 63);
            lblResponse.Name = "lblResponse";
            lblResponse.Size = new Size(216, 25);
            lblResponse.TabIndex = 1;
            lblResponse.Text = "Resposta analisada:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSelectArchive);
            panel2.Controls.Add(txtBoxArchive);
            panel2.Controls.Add(txtBoxDescription);
            panel2.Controls.Add(cbxTheme);
            panel2.Controls.Add(txtArchive);
            panel2.Controls.Add(txtDescription);
            panel2.Controls.Add(txtTheme);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 468);
            panel2.TabIndex = 1;
            // 
            // btnSelectArchive
            // 
            btnSelectArchive.Cursor = Cursors.Hand;
            btnSelectArchive.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectArchive.Location = new Point(48, 386);
            btnSelectArchive.Name = "btnSelectArchive";
            btnSelectArchive.Size = new Size(133, 40);
            btnSelectArchive.TabIndex = 5;
            btnSelectArchive.Text = "Selecione um arquivo:";
            btnSelectArchive.UseVisualStyleBackColor = true;
            // 
            // txtBoxArchive
            // 
            txtBoxArchive.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxArchive.Location = new Point(48, 347);
            txtBoxArchive.Name = "txtBoxArchive";
            txtBoxArchive.Size = new Size(281, 23);
            txtBoxArchive.TabIndex = 4;
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            txtBoxDescription.Location = new Point(48, 125);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(281, 157);
            txtBoxDescription.TabIndex = 3;
            // 
            // cbxTheme
            // 
            cbxTheme.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxTheme.FormattingEnabled = true;
            cbxTheme.Location = new Point(128, 31);
            cbxTheme.Name = "cbxTheme";
            cbxTheme.Size = new Size(201, 29);
            cbxTheme.TabIndex = 2;
            // 
            // txtArchive
            // 
            txtArchive.AutoSize = true;
            txtArchive.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtArchive.ForeColor = SystemColors.ButtonFace;
            txtArchive.Location = new Point(48, 310);
            txtArchive.Name = "txtArchive";
            txtArchive.Size = new Size(216, 23);
            txtArchive.TabIndex = 1;
            txtArchive.Text = "Selecione um arquivo:";
            // 
            // txtDescription
            // 
            txtDescription.AutoSize = true;
            txtDescription.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.ForeColor = SystemColors.ButtonFace;
            txtDescription.Location = new Point(48, 94);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(108, 23);
            txtDescription.TabIndex = 1;
            txtDescription.Text = "Descrição:";
            // 
            // txtTheme
            // 
            txtTheme.AutoSize = true;
            txtTheme.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTheme.ForeColor = SystemColors.ButtonFace;
            txtTheme.Location = new Point(48, 29);
            txtTheme.Name = "txtTheme";
            txtTheme.Size = new Size(74, 25);
            txtTheme.TabIndex = 1;
            txtTheme.Text = "Tema:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.key_file;
            pictureBox4.Location = new Point(12, 306);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.machine_learning;
            pictureBox3.Location = new Point(12, 90);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.themes;
            pictureBox2.Location = new Point(12, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // txtBoxResponse
            // 
            txtBoxResponse.BackColor = SystemColors.ActiveCaptionText;
            txtBoxResponse.Dock = DockStyle.Fill;
            txtBoxResponse.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            txtBoxResponse.ForeColor = SystemColors.Info;
            txtBoxResponse.Location = new Point(344, 100);
            txtBoxResponse.Multiline = true;
            txtBoxResponse.Name = "txtBoxResponse";
            txtBoxResponse.ScrollBars = ScrollBars.Vertical;
            txtBoxResponse.Size = new Size(750, 468);
            txtBoxResponse.TabIndex = 2;
            // 
            // FormAnalyze
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1094, 568);
            Controls.Add(txtBoxResponse);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1110, 607);
            Name = "FormAnalyze";
            Text = "DocScan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtBoxResponse;
        private PictureBox pictureBox2;
        private Label txtTheme;
        private ComboBox cbxTheme;
        private Label txtDescription;
        private PictureBox pictureBox3;
        private TextBox txtBoxDescription;
        private Label txtArchive;
        private PictureBox pictureBox4;
        private TextBox txtBoxArchive;
        private Button btnSelectArchive;
        private PictureBox pictureBox1;
        private Label lblResponse;
    }
}