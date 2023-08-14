
namespace Project
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
            this.components = new System.ComponentModel.Container();
            this.Resim = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsayac = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.listBoxNarinciye = new System.Windows.Forms.ListBox();
            this.lblPure = new System.Windows.Forms.Label();
            this.lblVitA = new System.Windows.Forms.Label();
            this.lblVitC = new System.Windows.Forms.Label();
            this.btnNarinciye = new System.Windows.Forms.Button();
            this.btnKati = new System.Windows.Forms.Button();
            this.listBoxKati = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblToplamPure = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplamA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplamC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).BeginInit();
            this.SuspendLayout();
            // 
            // Resim
            // 
            this.Resim.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Resim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Resim.Location = new System.Drawing.Point(13, 13);
            this.Resim.Name = "Resim";
            this.Resim.Size = new System.Drawing.Size(201, 170);
            this.Resim.TabIndex = 0;
            this.Resim.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kalan Süre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsayac
            // 
            this.lblsayac.BackColor = System.Drawing.Color.Gainsboro;
            this.lblsayac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsayac.Font = new System.Drawing.Font("Segoe UI Semibold", 24.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsayac.Location = new System.Drawing.Point(13, 343);
            this.lblsayac.Name = "lblsayac";
            this.lblsayac.Size = new System.Drawing.Size(202, 65);
            this.lblsayac.TabIndex = 2;
            this.lblsayac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(13, 189);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(202, 106);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Başla";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // listBoxNarinciye
            // 
            this.listBoxNarinciye.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxNarinciye.FormattingEnabled = true;
            this.listBoxNarinciye.ItemHeight = 23;
            this.listBoxNarinciye.Location = new System.Drawing.Point(221, 13);
            this.listBoxNarinciye.Name = "listBoxNarinciye";
            this.listBoxNarinciye.Size = new System.Drawing.Size(198, 211);
            this.listBoxNarinciye.TabIndex = 10;
            // 
            // lblPure
            // 
            this.lblPure.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblPure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPure.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPure.ForeColor = System.Drawing.Color.White;
            this.lblPure.Location = new System.Drawing.Point(425, 47);
            this.lblPure.Name = "lblPure";
            this.lblPure.Size = new System.Drawing.Size(222, 45);
            this.lblPure.TabIndex = 13;
            this.lblPure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVitA
            // 
            this.lblVitA.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblVitA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVitA.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVitA.ForeColor = System.Drawing.Color.White;
            this.lblVitA.Location = new System.Drawing.Point(425, 135);
            this.lblVitA.Name = "lblVitA";
            this.lblVitA.Size = new System.Drawing.Size(222, 45);
            this.lblVitA.TabIndex = 12;
            this.lblVitA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVitC
            // 
            this.lblVitC.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblVitC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVitC.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVitC.ForeColor = System.Drawing.Color.White;
            this.lblVitC.Location = new System.Drawing.Point(425, 224);
            this.lblVitC.Name = "lblVitC";
            this.lblVitC.Size = new System.Drawing.Size(222, 45);
            this.lblVitC.TabIndex = 11;
            this.lblVitC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNarinciye
            // 
            this.btnNarinciye.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNarinciye.Location = new System.Drawing.Point(221, 228);
            this.btnNarinciye.Name = "btnNarinciye";
            this.btnNarinciye.Size = new System.Drawing.Size(198, 42);
            this.btnNarinciye.TabIndex = 14;
            this.btnNarinciye.Text = "Sıkılabilen Meyve";
            this.btnNarinciye.UseVisualStyleBackColor = true;
            this.btnNarinciye.Click += new System.EventHandler(this.btnNarinciye_Click);
            // 
            // btnKati
            // 
            this.btnKati.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKati.Location = new System.Drawing.Point(221, 498);
            this.btnKati.Name = "btnKati";
            this.btnKati.Size = new System.Drawing.Size(198, 42);
            this.btnKati.TabIndex = 16;
            this.btnKati.Text = "Katı Meyve";
            this.btnKati.UseVisualStyleBackColor = true;
            this.btnKati.Click += new System.EventHandler(this.btnKati_Click);
            // 
            // listBoxKati
            // 
            this.listBoxKati.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxKati.FormattingEnabled = true;
            this.listBoxKati.ItemHeight = 23;
            this.listBoxKati.Location = new System.Drawing.Point(221, 284);
            this.listBoxKati.Name = "listBoxKati";
            this.listBoxKati.Size = new System.Drawing.Size(198, 211);
            this.listBoxKati.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblToplamPure
            // 
            this.lblToplamPure.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblToplamPure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblToplamPure.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamPure.ForeColor = System.Drawing.Color.White;
            this.lblToplamPure.Location = new System.Drawing.Point(425, 328);
            this.lblToplamPure.Name = "lblToplamPure";
            this.lblToplamPure.Size = new System.Drawing.Size(222, 43);
            this.lblToplamPure.TabIndex = 9;
            this.lblToplamPure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(425, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sıvı (GR)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToplamA
            // 
            this.lblToplamA.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblToplamA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblToplamA.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamA.ForeColor = System.Drawing.Color.White;
            this.lblToplamA.Location = new System.Drawing.Point(425, 414);
            this.lblToplamA.Name = "lblToplamA";
            this.lblToplamA.Size = new System.Drawing.Size(222, 40);
            this.lblToplamA.TabIndex = 8;
            this.lblToplamA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(425, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 34);
            this.label3.TabIndex = 18;
            this.label3.Text = "Toplam Vitamin A";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToplamC
            // 
            this.lblToplamC.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblToplamC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblToplamC.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamC.ForeColor = System.Drawing.Color.White;
            this.lblToplamC.Location = new System.Drawing.Point(425, 498);
            this.lblToplamC.Name = "lblToplamC";
            this.lblToplamC.Size = new System.Drawing.Size(222, 42);
            this.lblToplamC.TabIndex = 7;
            this.lblToplamC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SeaGreen;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(425, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 34);
            this.label4.TabIndex = 19;
            this.label4.Text = "Toplam Vitamin C";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SeaGreen;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(425, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 34);
            this.label5.TabIndex = 20;
            this.label5.Text = "Toplam Sıvı (GR)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SeaGreen;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(425, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 34);
            this.label6.TabIndex = 21;
            this.label6.Text = "Vitamin A";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SeaGreen;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(425, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 34);
            this.label7.TabIndex = 22;
            this.label7.Text = "Vitamin C";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 126);
            this.label8.TabIndex = 23;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 552);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblToplamC);
            this.Controls.Add(this.lblsayac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKati);
            this.Controls.Add(this.lblToplamA);
            this.Controls.Add(this.listBoxKati);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNarinciye);
            this.Controls.Add(this.lblToplamPure);
            this.Controls.Add(this.lblPure);
            this.Controls.Add(this.lblVitA);
            this.Controls.Add(this.lblVitC);
            this.Controls.Add(this.listBoxNarinciye);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Vitamin Deposu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Resim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsayac;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listBoxNarinciye;
        private System.Windows.Forms.Label lblPure;
        private System.Windows.Forms.Label lblVitA;
        private System.Windows.Forms.Label lblVitC;
        private System.Windows.Forms.Button btnNarinciye;
        private System.Windows.Forms.Button btnKati;
        private System.Windows.Forms.ListBox listBoxKati;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblToplamPure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplamA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplamC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

