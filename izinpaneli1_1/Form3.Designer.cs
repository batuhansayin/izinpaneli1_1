namespace izinpaneli1_1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBelgeGor = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnReddet = new System.Windows.Forms.Button();
            this.dgvMesajlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesajlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(954, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.BackgroundImage = global::izinpaneli1_1.Properties.Resources.Wallpaper;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnBelgeGor);
            this.panel1.Controls.Add(this.btnOnayla);
            this.panel1.Controls.Add(this.btnReddet);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 199);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::izinpaneli1_1.Properties.Resources.icons8_close_window_48;
            this.pictureBox1.Location = new System.Drawing.Point(893, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBelgeGor
            // 
            this.btnBelgeGor.BackColor = System.Drawing.Color.Transparent;
            this.btnBelgeGor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBelgeGor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBelgeGor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBelgeGor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBelgeGor.Image = global::izinpaneli1_1.Properties.Resources.icons8_search_50__1_;
            this.btnBelgeGor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBelgeGor.Location = new System.Drawing.Point(648, 61);
            this.btnBelgeGor.Name = "btnBelgeGor";
            this.btnBelgeGor.Size = new System.Drawing.Size(223, 63);
            this.btnBelgeGor.TabIndex = 3;
            this.btnBelgeGor.Text = "   Belge/Rapor Görüntüle";
            this.btnBelgeGor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBelgeGor.UseVisualStyleBackColor = false;
            this.btnBelgeGor.Click += new System.EventHandler(this.btnBelgeGor_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOnayla.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnayla.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnayla.ForeColor = System.Drawing.SystemColors.Info;
            this.btnOnayla.Image = global::izinpaneli1_1.Properties.Resources.icons8_done_48;
            this.btnOnayla.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnOnayla.Location = new System.Drawing.Point(72, 61);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(223, 63);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "ONAYLA    ";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnReddet
            // 
            this.btnReddet.BackColor = System.Drawing.Color.DarkRed;
            this.btnReddet.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnReddet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReddet.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReddet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReddet.Image = global::izinpaneli1_1.Properties.Resources.icons8_multiply_48;
            this.btnReddet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReddet.Location = new System.Drawing.Point(316, 61);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(223, 63);
            this.btnReddet.TabIndex = 2;
            this.btnReddet.Text = "REDDET    ";
            this.btnReddet.UseVisualStyleBackColor = false;
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // dgvMesajlar
            // 
            this.dgvMesajlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMesajlar.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvMesajlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesajlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMesajlar.Location = new System.Drawing.Point(0, 399);
            this.dgvMesajlar.Name = "dgvMesajlar";
            this.dgvMesajlar.Size = new System.Drawing.Size(954, 226);
            this.dgvMesajlar.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 625);
            this.Controls.Add(this.dgvMesajlar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesajlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnReddet;
        private System.Windows.Forms.Button btnBelgeGor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvMesajlar;
    }
}