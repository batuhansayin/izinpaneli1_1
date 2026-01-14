namespace izinpaneli1_1
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
        protected override void Dispose (bool disposing)
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblKarsilama = new System.Windows.Forms.Label();
            this.lblDosyaYolu = new System.Windows.Forms.Label();
            this.lblKalanIzin = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.btnDurum = new System.Windows.Forms.Button();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMesajGonder = new System.Windows.Forms.Button();
            this.txtYoneticiMesaj = new System.Windows.Forms.TextBox();
            this.lblSaat = new System.Windows.Forms.Label();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.lblKalanSure = new System.Windows.Forms.Label();
            this.timerSayac = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKarsilama
            // 
            this.lblKarsilama.AutoSize = true;
            this.lblKarsilama.BackColor = System.Drawing.Color.Transparent;
            this.lblKarsilama.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarsilama.ForeColor = System.Drawing.SystemColors.Window;
            this.lblKarsilama.Location = new System.Drawing.Point(152, 62);
            this.lblKarsilama.Name = "lblKarsilama";
            this.lblKarsilama.Size = new System.Drawing.Size(65, 25);
            this.lblKarsilama.TabIndex = 0;
            this.lblKarsilama.Text = "label1";
            // 
            // lblDosyaYolu
            // 
            this.lblDosyaYolu.AutoSize = true;
            this.lblDosyaYolu.BackColor = System.Drawing.Color.Transparent;
            this.lblDosyaYolu.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblDosyaYolu.Location = new System.Drawing.Point(41, 490);
            this.lblDosyaYolu.Name = "lblDosyaYolu";
            this.lblDosyaYolu.Size = new System.Drawing.Size(85, 13);
            this.lblDosyaYolu.TabIndex = 4;
            this.lblDosyaYolu.Text = "Dosya Seçilmedi";
            // 
            // lblKalanIzin
            // 
            this.lblKalanIzin.AutoSize = true;
            this.lblKalanIzin.BackColor = System.Drawing.Color.Transparent;
            this.lblKalanIzin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanIzin.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblKalanIzin.Location = new System.Drawing.Point(153, 97);
            this.lblKalanIzin.Name = "lblKalanIzin";
            this.lblKalanIzin.Size = new System.Drawing.Size(52, 21);
            this.lblKalanIzin.TabIndex = 1;
            this.lblKalanIzin.Text = "label2";
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGonder.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGonder.Image = global::izinpaneli1_1.Properties.Resources.icons8_add_administrator_48;
            this.btnGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGonder.Location = new System.Drawing.Point(40, 95);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(179, 80);
            this.btnGonder.TabIndex = 8;
            this.btnGonder.Text = "İZİN İSTE";
            this.btnGonder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.BackColor = System.Drawing.Color.Transparent;
            this.btnDosyaSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDosyaSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDosyaSec.FlatAppearance.BorderSize = 0;
            this.btnDosyaSec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDosyaSec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnDosyaSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDosyaSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDosyaSec.Image = global::izinpaneli1_1.Properties.Resources.BelgeRapor_Seç;
            this.btnDosyaSec.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDosyaSec.Location = new System.Drawing.Point(22, 506);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(169, 66);
            this.btnDosyaSec.TabIndex = 7;
            this.btnDosyaSec.TabStop = false;
            this.btnDosyaSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaSec.UseVisualStyleBackColor = false;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(187, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "İzin Bitiş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(187, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "İzin Başlangıç";
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.CalendarMonthBackground = System.Drawing.Color.MidnightBlue;
            this.dtBaslangic.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtBaslangic.Font = new System.Drawing.Font("Nirmala Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBaslangic.Location = new System.Drawing.Point(308, 227);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(305, 28);
            this.dtBaslangic.TabIndex = 5;
            // 
            // btnDurum
            // 
            this.btnDurum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDurum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDurum.FlatAppearance.BorderSize = 2;
            this.btnDurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurum.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurum.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDurum.Image = global::izinpaneli1_1.Properties.Resources.icons8_system_administrator_male_48;
            this.btnDurum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDurum.Location = new System.Drawing.Point(40, 208);
            this.btnDurum.Name = "btnDurum";
            this.btnDurum.Size = new System.Drawing.Size(179, 80);
            this.btnDurum.TabIndex = 9;
            this.btnDurum.Text = "İzin Durumlarımı Gör";
            this.btnDurum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDurum.UseVisualStyleBackColor = false;
            this.btnDurum.Click += new System.EventHandler(this.btnDurum_Click);
            // 
            // dtBitis
            // 
            this.dtBitis.Font = new System.Drawing.Font("Nirmala Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBitis.Location = new System.Drawing.Point(308, 269);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(305, 28);
            this.dtBitis.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::izinpaneli1_1.Properties.Resources._06eb2fb2_e55f_4da5_841f_34558aebacf1_removalai_preview;
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::izinpaneli1_1.Properties.Resources.icons8_close_window_48;
            this.pictureBox2.Location = new System.Drawing.Point(193, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnMesajGonder);
            this.panel1.Controls.Add(this.txtYoneticiMesaj);
            this.panel1.Controls.Add(this.lblSaat);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnGonder);
            this.panel1.Controls.Add(this.btnDurum);
            this.panel1.Location = new System.Drawing.Point(700, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 633);
            this.panel1.TabIndex = 12;
            // 
            // btnMesajGonder
            // 
            this.btnMesajGonder.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMesajGonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMesajGonder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesajGonder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMesajGonder.Location = new System.Drawing.Point(40, 507);
            this.btnMesajGonder.Name = "btnMesajGonder";
            this.btnMesajGonder.Size = new System.Drawing.Size(179, 29);
            this.btnMesajGonder.TabIndex = 15;
            this.btnMesajGonder.Text = "mesajı ilet";
            this.btnMesajGonder.UseVisualStyleBackColor = false;
            this.btnMesajGonder.Click += new System.EventHandler(this.btnMesajGonder_Click);
            // 
            // txtYoneticiMesaj
            // 
            this.txtYoneticiMesaj.Location = new System.Drawing.Point(40, 481);
            this.txtYoneticiMesaj.Name = "txtYoneticiMesaj";
            this.txtYoneticiMesaj.Size = new System.Drawing.Size(179, 20);
            this.txtYoneticiMesaj.TabIndex = 14;
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSaat.Location = new System.Drawing.Point(167, 577);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(75, 29);
            this.lblSaat.TabIndex = 13;
            this.lblSaat.Text = "00:00:00";
            // 
            // timerSaat
            // 
            this.timerSaat.Enabled = true;
            this.timerSaat.Interval = 1000;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // lblKalanSure
            // 
            this.lblKalanSure.AutoSize = true;
            this.lblKalanSure.BackColor = System.Drawing.Color.Transparent;
            this.lblKalanSure.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanSure.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblKalanSure.Location = new System.Drawing.Point(55, 160);
            this.lblKalanSure.Name = "lblKalanSure";
            this.lblKalanSure.Size = new System.Drawing.Size(71, 17);
            this.lblKalanSure.TabIndex = 13;
            this.lblKalanSure.Text = "kalan süre ";
            // 
            // timerSayac
            // 
            this.timerSayac.Interval = 1000;
            this.timerSayac.Tick += new System.EventHandler(this.timerSayac_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::izinpaneli1_1.Properties.Resources.Wallpaper1;
            this.ClientSize = new System.Drawing.Size(954, 631);
            this.Controls.Add(this.lblKalanSure);
            this.Controls.Add(this.btnDosyaSec);
            this.Controls.Add(this.lblDosyaYolu);
            this.Controls.Add(this.lblKalanIzin);
            this.Controls.Add(this.dtBaslangic);
            this.Controls.Add(this.lblKarsilama);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKarsilama;
        private System.Windows.Forms.Label lblDosyaYolu;
        private System.Windows.Forms.Label lblKalanIzin;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.Button btnDurum;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.Label lblKalanSure;
        private System.Windows.Forms.Timer timerSayac;
        private System.Windows.Forms.Button btnMesajGonder;
        private System.Windows.Forms.TextBox txtYoneticiMesaj;
    }
}