namespace Form_tryCatch
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
            this.firstnumbertb = new System.Windows.Forms.TextBox();
            this.lastnumbertb = new System.Windows.Forms.TextBox();
            this.conclusion_lbl = new System.Windows.Forms.Label();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstnumbertb
            // 
            this.firstnumbertb.Location = new System.Drawing.Point(124, 36);
            this.firstnumbertb.Name = "firstnumbertb";
            this.firstnumbertb.Size = new System.Drawing.Size(100, 20);
            this.firstnumbertb.TabIndex = 0;
            // 
            // lastnumbertb
            // 
            this.lastnumbertb.Location = new System.Drawing.Point(124, 62);
            this.lastnumbertb.Name = "lastnumbertb";
            this.lastnumbertb.Size = new System.Drawing.Size(100, 20);
            this.lastnumbertb.TabIndex = 1;
            // 
            // conclusion_lbl
            // 
            this.conclusion_lbl.AutoSize = true;
            this.conclusion_lbl.Location = new System.Drawing.Point(210, 106);
            this.conclusion_lbl.Name = "conclusion_lbl";
            this.conclusion_lbl.Size = new System.Drawing.Size(0, 13);
            this.conclusion_lbl.TabIndex = 2;
            // 
            // calculate_btn
            // 
            this.calculate_btn.Location = new System.Drawing.Point(306, 106);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(99, 52);
            this.calculate_btn.TabIndex = 3;
            this.calculate_btn.Text = "DIVIDE";
            this.calculate_btn.UseVisualStyleBackColor = true;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(121, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Conclusion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 189);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.conclusion_lbl);
            this.Controls.Add(this.lastnumbertb);
            this.Controls.Add(this.firstnumbertb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstnumbertb;
        private System.Windows.Forms.TextBox lastnumbertb;
        private System.Windows.Forms.Label conclusion_lbl;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

