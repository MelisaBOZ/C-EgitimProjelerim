namespace Form_Struct
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
            this.btnSealedClassCagir = new System.Windows.Forms.Button();
            this.btnStruct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSealedClassCagir
            // 
            this.btnSealedClassCagir.Location = new System.Drawing.Point(267, 72);
            this.btnSealedClassCagir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSealedClassCagir.Name = "btnSealedClassCagir";
            this.btnSealedClassCagir.Size = new System.Drawing.Size(176, 84);
            this.btnSealedClassCagir.TabIndex = 3;
            this.btnSealedClassCagir.Text = "SEALED Class\'ı Çağırma...";
            this.btnSealedClassCagir.UseVisualStyleBackColor = true;
            this.btnSealedClassCagir.Click += new System.EventHandler(this.btnSealedClassCagir_Click);
            // 
            // btnStruct
            // 
            this.btnStruct.Location = new System.Drawing.Point(27, 72);
            this.btnStruct.Margin = new System.Windows.Forms.Padding(2);
            this.btnStruct.Name = "btnStruct";
            this.btnStruct.Size = new System.Drawing.Size(175, 84);
            this.btnStruct.TabIndex = 2;
            this.btnStruct.Text = "STRUCT Yapısı ile...";
            this.btnStruct.UseVisualStyleBackColor = true;
            this.btnStruct.Click += new System.EventHandler(this.btnStruct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 218);
            this.Controls.Add(this.btnSealedClassCagir);
            this.Controls.Add(this.btnStruct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSealedClassCagir;
        private System.Windows.Forms.Button btnStruct;
    }
}

