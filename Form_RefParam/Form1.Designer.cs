namespace Form_RefParam
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
            this.txtMailAdresleri = new System.Windows.Forms.TextBox();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.btnOutUc = new System.Windows.Forms.Button();
            this.btnOutIki = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMailAdresleri
            // 
            this.txtMailAdresleri.Location = new System.Drawing.Point(10, 148);
            this.txtMailAdresleri.Margin = new System.Windows.Forms.Padding(2);
            this.txtMailAdresleri.Multiline = true;
            this.txtMailAdresleri.Name = "txtMailAdresleri";
            this.txtMailAdresleri.Size = new System.Drawing.Size(222, 46);
            this.txtMailAdresleri.TabIndex = 27;
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(10, 196);
            this.btnRef.Margin = new System.Windows.Forms.Padding(2);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(221, 26);
            this.btnRef.TabIndex = 26;
            this.btnRef.Text = "REF ANAHTAR KELİMESİ";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnParams
            // 
            this.btnParams.Location = new System.Drawing.Point(10, 118);
            this.btnParams.Margin = new System.Windows.Forms.Padding(2);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(221, 26);
            this.btnParams.TabIndex = 25;
            this.btnParams.Text = "PARAMS ANAHTAR KELİMESİ";
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // btnOutUc
            // 
            this.btnOutUc.Location = new System.Drawing.Point(10, 88);
            this.btnOutUc.Margin = new System.Windows.Forms.Padding(2);
            this.btnOutUc.Name = "btnOutUc";
            this.btnOutUc.Size = new System.Drawing.Size(221, 26);
            this.btnOutUc.TabIndex = 24;
            this.btnOutUc.Text = "OUT ANAHTAR KELİMESİ (ÖRNEK ÜÇ)";
            this.btnOutUc.UseVisualStyleBackColor = true;
            this.btnOutUc.Click += new System.EventHandler(this.btnOutUc_Click);
            // 
            // btnOutIki
            // 
            this.btnOutIki.Location = new System.Drawing.Point(10, 58);
            this.btnOutIki.Margin = new System.Windows.Forms.Padding(2);
            this.btnOutIki.Name = "btnOutIki";
            this.btnOutIki.Size = new System.Drawing.Size(221, 26);
            this.btnOutIki.TabIndex = 23;
            this.btnOutIki.Text = "OUT ANAHTAR KELİMESİ (ÖRNEK İKİ)";
            this.btnOutIki.UseVisualStyleBackColor = true;
            this.btnOutIki.Click += new System.EventHandler(this.btnOutIki_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(235, 28);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(107, 186);
            this.listBox1.TabIndex = 22;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(11, 28);
            this.btnOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(221, 26);
            this.btnOut.TabIndex = 21;
            this.btnOut.Text = "OUT ANAHTAR KELİMESİ";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 248);
            this.Controls.Add(this.txtMailAdresleri);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnParams);
            this.Controls.Add(this.btnOutUc);
            this.Controls.Add(this.btnOutIki);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMailAdresleri;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnParams;
        private System.Windows.Forms.Button btnOutUc;
        private System.Windows.Forms.Button btnOutIki;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOut;
    }
}

