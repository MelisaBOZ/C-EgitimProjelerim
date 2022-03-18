namespace Form_IfElse
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
            this.login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName_Txb = new System.Windows.Forms.TextBox();
            this.Pasword_Txb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(216, 186);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(76, 36);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "LOGİN";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // UserName_Txb
            // 
            this.UserName_Txb.Location = new System.Drawing.Point(192, 58);
            this.UserName_Txb.Name = "UserName_Txb";
            this.UserName_Txb.Size = new System.Drawing.Size(100, 20);
            this.UserName_Txb.TabIndex = 3;
            // 
            // Pasword_Txb
            // 
            this.Pasword_Txb.Location = new System.Drawing.Point(192, 114);
            this.Pasword_Txb.Name = "Pasword_Txb";
            this.Pasword_Txb.Size = new System.Drawing.Size(100, 20);
            this.Pasword_Txb.TabIndex = 4;
            this.Pasword_Txb.TextChanged += new System.EventHandler(this.Pasword_Txb_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 259);
            this.Controls.Add(this.Pasword_Txb);
            this.Controls.Add(this.UserName_Txb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName_Txb;
        private System.Windows.Forms.TextBox Pasword_Txb;
    }
}

