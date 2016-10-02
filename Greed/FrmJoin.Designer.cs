namespace Greed
{
    partial class FrmJoin
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
            this.LblWelcome = new System.Windows.Forms.Label();
            this.LblJoinInstructions = new System.Windows.Forms.Label();
            this.TxtNameJoin = new System.Windows.Forms.TextBox();
            this.BtnJoin = new System.Windows.Forms.Button();
            this.LBxJoinedPlayerNames = new System.Windows.Forms.ListBox();
            this.BtnLeave = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.Location = new System.Drawing.Point(80, 9);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(219, 26);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "Welcome to GREED!";
            // 
            // LblJoinInstructions
            // 
            this.LblJoinInstructions.AutoSize = true;
            this.LblJoinInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJoinInstructions.Location = new System.Drawing.Point(104, 54);
            this.LblJoinInstructions.Name = "LblJoinInstructions";
            this.LblJoinInstructions.Size = new System.Drawing.Size(172, 20);
            this.LblJoinInstructions.TabIndex = 1;
            this.LblJoinInstructions.Text = "Enter your name to join";
            // 
            // TxtNameJoin
            // 
            this.TxtNameJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNameJoin.Location = new System.Drawing.Point(85, 104);
            this.TxtNameJoin.Name = "TxtNameJoin";
            this.TxtNameJoin.Size = new System.Drawing.Size(100, 26);
            this.TxtNameJoin.TabIndex = 2;
            this.TxtNameJoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnJoin
            // 
            this.BtnJoin.Enabled = false;
            this.BtnJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJoin.Location = new System.Drawing.Point(202, 104);
            this.BtnJoin.Name = "BtnJoin";
            this.BtnJoin.Size = new System.Drawing.Size(97, 26);
            this.BtnJoin.TabIndex = 3;
            this.BtnJoin.Text = "Join";
            this.BtnJoin.UseVisualStyleBackColor = true;
            this.BtnJoin.Click += new System.EventHandler(this.BtnJoin_Click);
            // 
            // LBxJoinedPlayerNames
            // 
            this.LBxJoinedPlayerNames.FormattingEnabled = true;
            this.LBxJoinedPlayerNames.Location = new System.Drawing.Point(85, 136);
            this.LBxJoinedPlayerNames.Name = "LBxJoinedPlayerNames";
            this.LBxJoinedPlayerNames.Size = new System.Drawing.Size(100, 56);
            this.LBxJoinedPlayerNames.TabIndex = 4;
            // 
            // BtnLeave
            // 
            this.BtnLeave.Enabled = false;
            this.BtnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeave.Location = new System.Drawing.Point(202, 152);
            this.BtnLeave.Name = "BtnLeave";
            this.BtnLeave.Size = new System.Drawing.Size(97, 27);
            this.BtnLeave.TabIndex = 3;
            this.BtnLeave.Text = "Leave";
            this.BtnLeave.UseVisualStyleBackColor = true;
            // 
            // BtnStart
            // 
            this.BtnStart.Enabled = false;
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(85, 198);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(214, 44);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            // 
            // FrmJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 254);
            this.Controls.Add(this.LBxJoinedPlayerNames);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnLeave);
            this.Controls.Add(this.BtnJoin);
            this.Controls.Add(this.TxtNameJoin);
            this.Controls.Add(this.LblJoinInstructions);
            this.Controls.Add(this.LblWelcome);
            this.Name = "FrmJoin";
            this.Text = "Greed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Label LblJoinInstructions;
        public System.Windows.Forms.TextBox TxtNameJoin;
        public System.Windows.Forms.Button BtnJoin;
        public System.Windows.Forms.ListBox LBxJoinedPlayerNames;
        public System.Windows.Forms.Button BtnLeave;
        public System.Windows.Forms.Button BtnStart;
    }
}

