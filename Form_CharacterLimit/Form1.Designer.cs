namespace Form_CharacterLimit
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
            this.textnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Characters_Number_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textnumber
            // 
            this.textnumber.Location = new System.Drawing.Point(65, 35);
            this.textnumber.Multiline = true;
            this.textnumber.Name = "textnumber";
            this.textnumber.Size = new System.Drawing.Size(410, 104);
            this.textnumber.TabIndex = 0;
            this.textnumber.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of characters";
            // 
            // Characters_Number_lbl
            // 
            this.Characters_Number_lbl.AutoSize = true;
            this.Characters_Number_lbl.Location = new System.Drawing.Point(279, 168);
            this.Characters_Number_lbl.Name = "Characters_Number_lbl";
            this.Characters_Number_lbl.Size = new System.Drawing.Size(0, 13);
            this.Characters_Number_lbl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 270);
            this.Controls.Add(this.Characters_Number_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textnumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Characters_Number_lbl;
    }
}

