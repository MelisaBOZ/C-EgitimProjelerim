namespace Form_ReferenceAndValueTypes
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
            this.btnValueType = new System.Windows.Forms.Button();
            this.btnReferenceType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValueType
            // 
            this.btnValueType.Location = new System.Drawing.Point(209, 37);
            this.btnValueType.Margin = new System.Windows.Forms.Padding(2);
            this.btnValueType.Name = "btnValueType";
            this.btnValueType.Size = new System.Drawing.Size(106, 125);
            this.btnValueType.TabIndex = 3;
            this.btnValueType.Text = "VALUE";
            this.btnValueType.UseVisualStyleBackColor = true;
            this.btnValueType.Click += new System.EventHandler(this.btnValueType_Click);
            // 
            // btnReferenceType
            // 
            this.btnReferenceType.Location = new System.Drawing.Point(31, 37);
            this.btnReferenceType.Margin = new System.Windows.Forms.Padding(2);
            this.btnReferenceType.Name = "btnReferenceType";
            this.btnReferenceType.Size = new System.Drawing.Size(106, 125);
            this.btnReferenceType.TabIndex = 2;
            this.btnReferenceType.Text = "REFERENCE";
            this.btnReferenceType.UseVisualStyleBackColor = true;
            this.btnReferenceType.Click += new System.EventHandler(this.btnReferenceType_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 200);
            this.Controls.Add(this.btnValueType);
            this.Controls.Add(this.btnReferenceType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValueType;
        private System.Windows.Forms.Button btnReferenceType;
    }
}

