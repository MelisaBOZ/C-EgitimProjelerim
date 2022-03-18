namespace Form_TernaryIf
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
            this.numbertextbox = new System.Windows.Forms.TextBox();
            this.abaolute_Value_btn = new System.Windows.Forms.Button();
            this.textlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numbertextbox
            // 
            this.numbertextbox.Location = new System.Drawing.Point(76, 57);
            this.numbertextbox.Name = "numbertextbox";
            this.numbertextbox.Size = new System.Drawing.Size(275, 20);
            this.numbertextbox.TabIndex = 0;
            // 
            // abaolute_Value_btn
            // 
            this.abaolute_Value_btn.Location = new System.Drawing.Point(116, 107);
            this.abaolute_Value_btn.Name = "abaolute_Value_btn";
            this.abaolute_Value_btn.Size = new System.Drawing.Size(185, 69);
            this.abaolute_Value_btn.TabIndex = 1;
            this.abaolute_Value_btn.Text = "ABSOLUTE VALUE";
            this.abaolute_Value_btn.UseVisualStyleBackColor = true;
            this.abaolute_Value_btn.Click += new System.EventHandler(this.abaolute_Value_btn_Click);
            // 
            // textlbl
            // 
            this.textlbl.AutoSize = true;
            this.textlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textlbl.Location = new System.Drawing.Point(112, 25);
            this.textlbl.Name = "textlbl";
            this.textlbl.Size = new System.Drawing.Size(190, 20);
            this.textlbl.TabIndex = 2;
            this.textlbl.Text = "Please enter a number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 201);
            this.Controls.Add(this.textlbl);
            this.Controls.Add(this.abaolute_Value_btn);
            this.Controls.Add(this.numbertextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numbertextbox;
        private System.Windows.Forms.Button abaolute_Value_btn;
        private System.Windows.Forms.Label textlbl;
    }
}

