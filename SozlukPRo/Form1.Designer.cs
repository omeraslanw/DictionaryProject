namespace SozlukPRo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtIng = new System.Windows.Forms.TextBox();
            this.txtTr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDogrulama = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureReturn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureReturn2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReturn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReturn2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIng
            // 
            this.txtIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIng.Location = new System.Drawing.Point(228, 133);
            this.txtIng.Name = "txtIng";
            this.txtIng.Size = new System.Drawing.Size(227, 48);
            this.txtIng.TabIndex = 2;
            this.txtIng.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIng_KeyDown);
            // 
            // txtTr
            // 
            this.txtTr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTr.Location = new System.Drawing.Point(228, 223);
            this.txtTr.Name = "txtTr";
            this.txtTr.Size = new System.Drawing.Size(227, 48);
            this.txtTr.TabIndex = 1;
            this.txtTr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTr_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "English:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turkish:";
            // 
            // lblDogrulama
            // 
            this.lblDogrulama.AutoSize = true;
            this.lblDogrulama.Location = new System.Drawing.Point(816, 124);
            this.lblDogrulama.Name = "lblDogrulama";
            this.lblDogrulama.Size = new System.Drawing.Size(79, 29);
            this.lblDogrulama.TabIndex = 4;
            this.lblDogrulama.Text = "label3";
            this.lblDogrulama.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(624, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 40);
            this.label5.TabIndex = 6;
            this.label5.Text = "Known Words:";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.BackColor = System.Drawing.Color.Transparent;
            this.lblSure.Font = new System.Drawing.Font("MV Boli", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSure.Location = new System.Drawing.Point(13, 11);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(110, 73);
            this.lblSure.TabIndex = 7;
            this.lblSure.Text = "90";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.Location = new System.Drawing.Point(881, 226);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(37, 40);
            this.lblKelime.TabIndex = 8;
            this.lblKelime.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureReturn
            // 
            this.pictureReturn.Image = ((System.Drawing.Image)(resources.GetObject("pictureReturn.Image")));
            this.pictureReturn.Location = new System.Drawing.Point(474, 133);
            this.pictureReturn.Name = "pictureReturn";
            this.pictureReturn.Size = new System.Drawing.Size(70, 48);
            this.pictureReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureReturn.TabIndex = 9;
            this.pictureReturn.TabStop = false;
            this.pictureReturn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(28, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 97);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(729, 67);
            this.label3.TabIndex = 0;
            this.label3.Text = "CATCH THE WORDS IF YOU CAN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblSure);
            this.panel2.Location = new System.Drawing.Point(796, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 97);
            this.panel2.TabIndex = 11;
            // 
            // pictureReturn2
            // 
            this.pictureReturn2.Image = ((System.Drawing.Image)(resources.GetObject("pictureReturn2.Image")));
            this.pictureReturn2.Location = new System.Drawing.Point(474, 223);
            this.pictureReturn2.Name = "pictureReturn2";
            this.pictureReturn2.Size = new System.Drawing.Size(70, 48);
            this.pictureReturn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureReturn2.TabIndex = 12;
            this.pictureReturn2.TabStop = false;
            this.pictureReturn2.Click += new System.EventHandler(this.pictureReturn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(957, 296);
            this.Controls.Add(this.pictureReturn2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureReturn);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDogrulama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTr);
            this.Controls.Add(this.txtIng);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catch The Words If You Can";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureReturn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReturn2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIng;
        private System.Windows.Forms.TextBox txtTr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDogrulama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureReturn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureReturn2;
    }
}

