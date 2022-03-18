namespace Form_SwitchCase
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
            this.Switch = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.txtIkinciGirisAlani = new System.Windows.Forms.TextBox();
            this.approve_btn = new System.Windows.Forms.Button();
            this.txtGirisAlani = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Switch
            // 
            this.Switch.Location = new System.Drawing.Point(91, 164);
            this.Switch.Margin = new System.Windows.Forms.Padding(2);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(164, 25);
            this.Switch.TabIndex = 19;
            this.Switch.Text = "SWITCH";
            this.Switch.UseVisualStyleBackColor = true;
            this.Switch.Click += new System.EventHandler(this.Switch_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(91, 135);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(164, 25);
            this.Login_btn.TabIndex = 18;
            this.Login_btn.Text = "LOGİN";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // txtIkinciGirisAlani
            // 
            this.txtIkinciGirisAlani.Location = new System.Drawing.Point(91, 67);
            this.txtIkinciGirisAlani.Margin = new System.Windows.Forms.Padding(2);
            this.txtIkinciGirisAlani.Name = "txtIkinciGirisAlani";
            this.txtIkinciGirisAlani.Size = new System.Drawing.Size(165, 20);
            this.txtIkinciGirisAlani.TabIndex = 17;
            // 
            // approve_btn
            // 
            this.approve_btn.Location = new System.Drawing.Point(91, 105);
            this.approve_btn.Margin = new System.Windows.Forms.Padding(2);
            this.approve_btn.Name = "approve_btn";
            this.approve_btn.Size = new System.Drawing.Size(164, 25);
            this.approve_btn.TabIndex = 16;
            this.approve_btn.Text = "APPROVE";
            this.approve_btn.UseVisualStyleBackColor = true;
            this.approve_btn.Click += new System.EventHandler(this.approve_btn_Click);
            // 
            // txtGirisAlani
            // 
            this.txtGirisAlani.Location = new System.Drawing.Point(91, 43);
            this.txtGirisAlani.Margin = new System.Windows.Forms.Padding(2);
            this.txtGirisAlani.Name = "txtGirisAlani";
            this.txtGirisAlani.Size = new System.Drawing.Size(165, 20);
            this.txtGirisAlani.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 215);
            this.Controls.Add(this.Switch);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.txtIkinciGirisAlani);
            this.Controls.Add(this.approve_btn);
            this.Controls.Add(this.txtGirisAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Switch;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox txtIkinciGirisAlani;
        private System.Windows.Forms.Button approve_btn;
        private System.Windows.Forms.TextBox txtGirisAlani;
    }
}

