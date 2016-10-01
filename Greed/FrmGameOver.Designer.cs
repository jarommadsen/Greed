namespace Greed
{
    partial class FrmGameOver
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
            this.LblPlayAgain = new System.Windows.Forms.Label();
            this.BtnPlayAgainYes = new System.Windows.Forms.Button();
            this.BtnPlayAgainNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblPlayAgain
            // 
            this.LblPlayAgain.AutoSize = true;
            this.LblPlayAgain.Location = new System.Drawing.Point(109, 102);
            this.LblPlayAgain.Name = "LblPlayAgain";
            this.LblPlayAgain.Size = new System.Drawing.Size(62, 13);
            this.LblPlayAgain.TabIndex = 0;
            this.LblPlayAgain.Text = "Play again?";
            // 
            // BtnPlayAgainYes
            // 
            this.BtnPlayAgainYes.Location = new System.Drawing.Point(62, 128);
            this.BtnPlayAgainYes.Name = "BtnPlayAgainYes";
            this.BtnPlayAgainYes.Size = new System.Drawing.Size(75, 23);
            this.BtnPlayAgainYes.TabIndex = 1;
            this.BtnPlayAgainYes.Text = "Yes";
            this.BtnPlayAgainYes.UseVisualStyleBackColor = true;
            // 
            // BtnPlayAgainNo
            // 
            this.BtnPlayAgainNo.Location = new System.Drawing.Point(143, 128);
            this.BtnPlayAgainNo.Name = "BtnPlayAgainNo";
            this.BtnPlayAgainNo.Size = new System.Drawing.Size(75, 23);
            this.BtnPlayAgainNo.TabIndex = 1;
            this.BtnPlayAgainNo.Text = "No";
            this.BtnPlayAgainNo.UseVisualStyleBackColor = true;
            // 
            // FrmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnPlayAgainNo);
            this.Controls.Add(this.BtnPlayAgainYes);
            this.Controls.Add(this.LblPlayAgain);
            this.Name = "FrmGameOver";
            this.Text = "FrmGameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPlayAgain;
        private System.Windows.Forms.Button BtnPlayAgainYes;
        private System.Windows.Forms.Button BtnPlayAgainNo;
    }
}