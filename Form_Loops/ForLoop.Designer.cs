﻿namespace Form_Loops
{
    partial class ForLoop
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
            this.btnOrnekYedi = new System.Windows.Forms.Button();
            this.btnOrnekAlti = new System.Windows.Forms.Button();
            this.btnOrnekBes = new System.Windows.Forms.Button();
            this.btnOrnekDort = new System.Windows.Forms.Button();
            this.btnOrnekUc = new System.Windows.Forms.Button();
            this.btnOrnekIki = new System.Windows.Forms.Button();
            this.btnOrnekBir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NextPage_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrnekYedi
            // 
            this.btnOrnekYedi.Location = new System.Drawing.Point(118, 236);
            this.btnOrnekYedi.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrnekYedi.Name = "btnOrnekYedi";
            this.btnOrnekYedi.Size = new System.Drawing.Size(168, 26);
            this.btnOrnekYedi.TabIndex = 31;
            this.btnOrnekYedi.Text = "Yılları ListBox\'a Ekle";
            this.btnOrnekYedi.UseVisualStyleBackColor = true;
            this.btnOrnekYedi.Click += new System.EventHandler(this.btnOrnekYedi_Click);
            // 
            // btnOrnekAlti
            // 
            this.btnOrnekAlti.Location = new System.Drawing.Point(118, 206);
            this.btnOrnekAlti.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrnekAlti.Name = "btnOrnekAlti";
            this.btnOrnekAlti.Size = new System.Drawing.Size(168, 26);
            this.btnOrnekAlti.TabIndex = 30;
            this.btnOrnekAlti.Text = "İşlem Yap";
            this.btnOrnekAlti.UseVisualStyleBackColor = true;
            this.btnOrnekAlti.Click += new System.EventHandler(this.btnOrnekAlti_Click);
            // 
            // btnOrnekBes
            // 
            this.btnOrnekBes.Location = new System.Drawing.Point(118, 176);
            this.btnOrnekBes.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrnekBes.Name = "btnOrnekBes";
            this.btnOrnekBes.Size = new System.Drawing.Size(168, 26);
            this.btnOrnekBes.TabIndex = 29;
            this.btnOrnekBes.Text = "1-100 Toplamı";
            this.btnOrnekBes.UseVisualStyleBackColor = true;
            this.btnOrnekBes.Click += new System.EventHandler(this.btnOrnekBes_Click);
            // 
            // btnOrnekDort
            // 
            this.btnOrnekDort.Location = new System.Drawing.Point(118, 146);
            this.btnOrnekDort.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrnekDort.Name = "btnOrnekDort";
            this.btnOrnekDort.Size = new System.Drawing.Size(168, 26);
            this.btnOrnekDort.TabIndex = 28;
            this.btnOrnekDort.Text = "A-Z\'ye Alfabe";
            this.btnOrnekDort.UseVisualStyleBackColor = true;
            this.btnOrnekDort.Click += new System.EventHandler(this.btnOrnekDort_Click);
            // 
            // btnOrnekUc
            // 
            this.btnOrnekUc.Location = new System.Drawing.Point(118, 116);
            this.btnOrnekUc.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrnekUc.Name = "btnOrnekUc";
            this.btnOrnekUc.Size = new System.Drawing.Size(168, 26);
            this.btnOrnekUc.TabIndex = 27;
            this.btnOrnekUc.Text = "1-1000 ÇİFT SAYILAR";
            this.btnOrnekUc.UseVisualStyleBackColor = true;
            this.btnOrnekUc.Click += new System.EventHandler(this.btnOrnekUc_Click);
            // 
            // btnOrnekIki
            // 
            this.btnOrnekIki.Location = new System.Drawing.Point(118, 86);
            this.btnOrnekIki.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrnekIki.Name = "btnOrnekIki";
            this.btnOrnekIki.Size = new System.Drawing.Size(168, 26);
            this.btnOrnekIki.TabIndex = 26;
            this.btnOrnekIki.Text = "1000-1";
            this.btnOrnekIki.UseVisualStyleBackColor = true;
            this.btnOrnekIki.Click += new System.EventHandler(this.btnOrnekIki_Click);
            // 
            // btnOrnekBir
            // 
            this.btnOrnekBir.Location = new System.Drawing.Point(118, 57);
            this.btnOrnekBir.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrnekBir.Name = "btnOrnekBir";
            this.btnOrnekBir.Size = new System.Drawing.Size(168, 26);
            this.btnOrnekBir.TabIndex = 25;
            this.btnOrnekBir.Text = "1-1000";
            this.btnOrnekBir.UseVisualStyleBackColor = true;
            this.btnOrnekBir.Click += new System.EventHandler(this.btnOrnekBir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(290, 57);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 199);
            this.listBox1.TabIndex = 24;
            // 
            // NextPage_btn
            // 
            this.NextPage_btn.Location = new System.Drawing.Point(460, 259);
            this.NextPage_btn.Name = "NextPage_btn";
            this.NextPage_btn.Size = new System.Drawing.Size(107, 42);
            this.NextPage_btn.TabIndex = 32;
            this.NextPage_btn.Text = "NEXT PAGE";
            this.NextPage_btn.UseVisualStyleBackColor = true;
            // 
            // ForLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 357);
            this.Controls.Add(this.NextPage_btn);
            this.Controls.Add(this.btnOrnekYedi);
            this.Controls.Add(this.btnOrnekAlti);
            this.Controls.Add(this.btnOrnekBes);
            this.Controls.Add(this.btnOrnekDort);
            this.Controls.Add(this.btnOrnekUc);
            this.Controls.Add(this.btnOrnekIki);
            this.Controls.Add(this.btnOrnekBir);
            this.Controls.Add(this.listBox1);
            this.Name = "ForLoop";
            this.Text = "ForLoop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrnekYedi;
        private System.Windows.Forms.Button btnOrnekAlti;
        private System.Windows.Forms.Button btnOrnekBes;
        private System.Windows.Forms.Button btnOrnekDort;
        private System.Windows.Forms.Button btnOrnekUc;
        private System.Windows.Forms.Button btnOrnekIki;
        private System.Windows.Forms.Button btnOrnekBir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button NextPage_btn;
    }
}