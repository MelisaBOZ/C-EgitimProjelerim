namespace Form_Loops
{
    partial class DoWhile
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
            this.btnDoWhileIki = new System.Windows.Forms.Button();
            this.btnWhileIki = new System.Windows.Forms.Button();
            this.value_Lb = new System.Windows.Forms.ListBox();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.NextPage_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoWhileIki
            // 
            this.btnDoWhileIki.Location = new System.Drawing.Point(154, 156);
            this.btnDoWhileIki.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoWhileIki.Name = "btnDoWhileIki";
            this.btnDoWhileIki.Size = new System.Drawing.Size(143, 26);
            this.btnDoWhileIki.TabIndex = 19;
            this.btnDoWhileIki.Text = "DOWHILE - 2";
            this.btnDoWhileIki.UseVisualStyleBackColor = true;
            this.btnDoWhileIki.Click += new System.EventHandler(this.btnDoWhileIki_Click);
            // 
            // btnWhileIki
            // 
            this.btnWhileIki.Location = new System.Drawing.Point(154, 126);
            this.btnWhileIki.Margin = new System.Windows.Forms.Padding(2);
            this.btnWhileIki.Name = "btnWhileIki";
            this.btnWhileIki.Size = new System.Drawing.Size(143, 26);
            this.btnWhileIki.TabIndex = 18;
            this.btnWhileIki.Text = "WHİLE - 2";
            this.btnWhileIki.UseVisualStyleBackColor = true;
            this.btnWhileIki.Click += new System.EventHandler(this.btnWhileIki_Click);
            // 
            // value_Lb
            // 
            this.value_Lb.FormattingEnabled = true;
            this.value_Lb.Location = new System.Drawing.Point(300, 66);
            this.value_Lb.Margin = new System.Windows.Forms.Padding(2);
            this.value_Lb.Name = "value_Lb";
            this.value_Lb.Size = new System.Drawing.Size(123, 173);
            this.value_Lb.TabIndex = 17;
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(154, 96);
            this.btnDoWhile.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(143, 26);
            this.btnDoWhile.TabIndex = 16;
            this.btnDoWhile.Text = "DOWHILE";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(154, 66);
            this.btnWhile.Margin = new System.Windows.Forms.Padding(2);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(143, 26);
            this.btnWhile.TabIndex = 15;
            this.btnWhile.Text = "WHİLE";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // NextPage_btn
            // 
            this.NextPage_btn.Location = new System.Drawing.Point(444, 215);
            this.NextPage_btn.Name = "NextPage_btn";
            this.NextPage_btn.Size = new System.Drawing.Size(107, 42);
            this.NextPage_btn.TabIndex = 20;
            this.NextPage_btn.Text = "NEXT PAGE";
            this.NextPage_btn.UseVisualStyleBackColor = true;
            this.NextPage_btn.Click += new System.EventHandler(this.NextPage_btn_Click);
            // 
            // DoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 304);
            this.Controls.Add(this.NextPage_btn);
            this.Controls.Add(this.btnDoWhileIki);
            this.Controls.Add(this.btnWhileIki);
            this.Controls.Add(this.value_Lb);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Name = "DoWhile";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoWhileIki;
        private System.Windows.Forms.Button btnWhileIki;
        private System.Windows.Forms.ListBox value_Lb;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button NextPage_btn;
    }
}

