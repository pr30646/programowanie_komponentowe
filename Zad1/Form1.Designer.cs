namespace Zad1
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
			this.Wtyczki = new System.Windows.Forms.MenuStrip();
			this.Operacja = new System.Windows.Forms.ToolStripMenuItem();
			this.Result = new System.Windows.Forms.Button();
			this.operationTypeLabel = new System.Windows.Forms.Label();
			this.resultLabel = new System.Windows.Forms.Label();
			this.val1 = new System.Windows.Forms.TextBox();
			this.val2 = new System.Windows.Forms.TextBox();
			this.Wtyczki.SuspendLayout();
			this.SuspendLayout();
			// 
			// Wtyczki
			// 
			this.Wtyczki.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Operacja});
			this.Wtyczki.Location = new System.Drawing.Point(0, 0);
			this.Wtyczki.Name = "Wtyczki";
			this.Wtyczki.Size = new System.Drawing.Size(355, 24);
			this.Wtyczki.TabIndex = 3;
			this.Wtyczki.Text = "menuStrip1";
			// 
			// Operacja
			// 
			this.Operacja.Name = "Operacja";
			this.Operacja.Size = new System.Drawing.Size(116, 20);
			this.Operacja.Text = "Operacja z wtyczki";
			// 
			// Result
			// 
			this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Result.Location = new System.Drawing.Point(113, 141);
			this.Result.Name = "Result";
			this.Result.Size = new System.Drawing.Size(122, 37);
			this.Result.TabIndex = 4;
			this.Result.Text = "Oblicz";
			this.Result.UseVisualStyleBackColor = true;
			this.Result.Click += new System.EventHandler(this.Result_Click);
			// 
			// operationTypeLabel
			// 
			this.operationTypeLabel.AutoSize = true;
			this.operationTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.operationTypeLabel.Location = new System.Drawing.Point(109, 39);
			this.operationTypeLabel.Name = "operationTypeLabel";
			this.operationTypeLabel.Size = new System.Drawing.Size(126, 20);
			this.operationTypeLabel.TabIndex = 8;
			this.operationTypeLabel.Text = "OperationType";
			this.operationTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultLabel.Location = new System.Drawing.Point(141, 218);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(61, 20);
			this.resultLabel.TabIndex = 10;
			this.resultLabel.Text = "Result";
			this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// val1
			// 
			this.val1.Location = new System.Drawing.Point(73, 89);
			this.val1.Name = "val1";
			this.val1.Size = new System.Drawing.Size(100, 20);
			this.val1.TabIndex = 5;
			// 
			// val2
			// 
			this.val2.Location = new System.Drawing.Point(179, 89);
			this.val2.Name = "val2";
			this.val2.Size = new System.Drawing.Size(100, 20);
			this.val2.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(355, 286);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.operationTypeLabel);
			this.Controls.Add(this.val2);
			this.Controls.Add(this.val1);
			this.Controls.Add(this.Result);
			this.Controls.Add(this.Wtyczki);
			this.MainMenuStrip = this.Wtyczki;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Wtyczki.ResumeLayout(false);
			this.Wtyczki.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.MenuStrip Wtyczki;
		private System.Windows.Forms.ToolStripMenuItem Operacja;
		private System.Windows.Forms.Button Result;
		private System.Windows.Forms.Label operationTypeLabel;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.TextBox val1;
		private System.Windows.Forms.TextBox val2;
	}
}

