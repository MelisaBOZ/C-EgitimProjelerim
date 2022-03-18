namespace Form_TransitionalForm
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
            this.MainMenu_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenu_btn
            // 
            this.MainMenu_btn.Location = new System.Drawing.Point(163, 95);
            this.MainMenu_btn.Name = "MainMenu_btn";
            this.MainMenu_btn.Size = new System.Drawing.Size(206, 119);
            this.MainMenu_btn.TabIndex = 0;
            this.MainMenu_btn.Text = "main menu";
            this.MainMenu_btn.UseVisualStyleBackColor = true;
            this.MainMenu_btn.Click += new System.EventHandler(this.MainMenu_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 346);
            this.Controls.Add(this.MainMenu_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainMenu_btn;
    }
}

