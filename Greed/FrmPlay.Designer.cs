namespace Greed
{
    partial class FrmPlay
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
            this.TLPnlDiceInHand = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDie1 = new System.Windows.Forms.Button();
            this.BtnDie2 = new System.Windows.Forms.Button();
            this.BtnDie3 = new System.Windows.Forms.Button();
            this.BtnDie4 = new System.Windows.Forms.Button();
            this.BtnDie6 = new System.Windows.Forms.Button();
            this.BtnDie7 = new System.Windows.Forms.Button();
            this.BtnDie5 = new System.Windows.Forms.Button();
            this.TxtTurnPoints = new System.Windows.Forms.TextBox();
            this.TxtBankedPoints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBank = new System.Windows.Forms.Button();
            this.BtnRoll = new System.Windows.Forms.Button();
            this.TLPnlDiceAside = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDie9 = new System.Windows.Forms.Button();
            this.BtnDie10 = new System.Windows.Forms.Button();
            this.BtnDie11 = new System.Windows.Forms.Button();
            this.BtnDie13 = new System.Windows.Forms.Button();
            this.BtnDie14 = new System.Windows.Forms.Button();
            this.BtnDie8 = new System.Windows.Forms.Button();
            this.BtnDie12 = new System.Windows.Forms.Button();
            this.TxtThreshold = new System.Windows.Forms.Label();
            this.TxtCurrentPlayer = new System.Windows.Forms.Label();
            this.ScoreListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TLPnlDiceInHand.SuspendLayout();
            this.TLPnlDiceAside.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPnlDiceInHand
            // 
            this.TLPnlDiceInHand.ColumnCount = 7;
            this.TLPnlDiceInHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPnlDiceInHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPnlDiceInHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPnlDiceInHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPnlDiceInHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPnlDiceInHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPnlDiceInHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPnlDiceInHand.Controls.Add(this.BtnDie1, 0, 0);
            this.TLPnlDiceInHand.Controls.Add(this.BtnDie2, 1, 0);
            this.TLPnlDiceInHand.Controls.Add(this.BtnDie3, 2, 0);
            this.TLPnlDiceInHand.Controls.Add(this.BtnDie4, 3, 0);
            this.TLPnlDiceInHand.Controls.Add(this.BtnDie6, 5, 0);
            this.TLPnlDiceInHand.Controls.Add(this.BtnDie7, 6, 0);
            this.TLPnlDiceInHand.Controls.Add(this.BtnDie5, 4, 0);
            this.TLPnlDiceInHand.Location = new System.Drawing.Point(16, 88);
            this.TLPnlDiceInHand.Name = "TLPnlDiceInHand";
            this.TLPnlDiceInHand.RowCount = 1;
            this.TLPnlDiceInHand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPnlDiceInHand.Size = new System.Drawing.Size(490, 70);
            this.TLPnlDiceInHand.TabIndex = 0;
            // 
            // BtnDie1
            // 
            this.BtnDie1.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDie1.Location = new System.Drawing.Point(3, 3);
            this.BtnDie1.Name = "BtnDie1";
            this.BtnDie1.Size = new System.Drawing.Size(63, 64);
            this.BtnDie1.TabIndex = 0;
            this.BtnDie1.Text = "X";
            this.BtnDie1.UseVisualStyleBackColor = true;
            this.BtnDie1.Click += new System.EventHandler(this.HandBtnDie_Click);
            // 
            // BtnDie2
            // 
            this.BtnDie2.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDie2.Location = new System.Drawing.Point(72, 3);
            this.BtnDie2.Name = "BtnDie2";
            this.BtnDie2.Size = new System.Drawing.Size(63, 64);
            this.BtnDie2.TabIndex = 0;
            this.BtnDie2.Text = "X";
            this.BtnDie2.UseVisualStyleBackColor = true;
            this.BtnDie2.Click += new System.EventHandler(this.HandBtnDie_Click);
            // 
            // BtnDie3
            // 
            this.BtnDie3.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDie3.Location = new System.Drawing.Point(141, 3);
            this.BtnDie3.Name = "BtnDie3";
            this.BtnDie3.Size = new System.Drawing.Size(63, 64);
            this.BtnDie3.TabIndex = 0;
            this.BtnDie3.Text = "X";
            this.BtnDie3.UseVisualStyleBackColor = true;
            this.BtnDie3.Click += new System.EventHandler(this.HandBtnDie_Click);
            // 
            // BtnDie4
            // 
            this.BtnDie4.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDie4.Location = new System.Drawing.Point(210, 3);
            this.BtnDie4.Name = "BtnDie4";
            this.BtnDie4.Size = new System.Drawing.Size(63, 64);
            this.BtnDie4.TabIndex = 0;
            this.BtnDie4.Text = "X";
            this.BtnDie4.UseVisualStyleBackColor = true;
            this.BtnDie4.Click += new System.EventHandler(this.HandBtnDie_Click);
            // 
            // BtnDie6
            // 
            this.BtnDie6.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDie6.Location = new System.Drawing.Point(348, 3);
            this.BtnDie6.Name = "BtnDie6";
            this.BtnDie6.Size = new System.Drawing.Size(63, 64);
            this.BtnDie6.TabIndex = 0;
            this.BtnDie6.Text = "X";
            this.BtnDie6.UseVisualStyleBackColor = true;
            this.BtnDie6.Click += new System.EventHandler(this.HandBtnDie_Click);
            // 
            // BtnDie7
            // 
            this.BtnDie7.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDie7.Location = new System.Drawing.Point(417, 3);
            this.BtnDie7.Name = "BtnDie7";
            this.BtnDie7.Size = new System.Drawing.Size(63, 64);
            this.BtnDie7.TabIndex = 0;
            this.BtnDie7.Text = "X";
            this.BtnDie7.UseVisualStyleBackColor = true;
            this.BtnDie7.Click += new System.EventHandler(this.HandBtnDie_Click);
            // 
            // BtnDie5
            // 
            this.BtnDie5.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDie5.Location = new System.Drawing.Point(279, 3);
            this.BtnDie5.Name = "BtnDie5";
            this.BtnDie5.Size = new System.Drawing.Size(63, 64);
            this.BtnDie5.TabIndex = 0;
            this.BtnDie5.Text = "X";
            this.BtnDie5.UseVisualStyleBackColor = true;
            this.BtnDie5.Click += new System.EventHandler(this.HandBtnDie_Click);
            // 
            // TxtTurnPoints
            // 
            this.TxtTurnPoints.Font = new System.Drawing.Font("Arial Black", 16F);
            this.TxtTurnPoints.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtTurnPoints.Location = new System.Drawing.Point(295, 164);
            this.TxtTurnPoints.Name = "TxtTurnPoints";
            this.TxtTurnPoints.ReadOnly = true;
            this.TxtTurnPoints.Size = new System.Drawing.Size(89, 38);
            this.TxtTurnPoints.TabIndex = 1;
            this.TxtTurnPoints.TabStop = false;
            this.TxtTurnPoints.Text = "XXXXX";
            this.TxtTurnPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtBankedPoints
            // 
            this.TxtBankedPoints.Font = new System.Drawing.Font("Arial Black", 16F);
            this.TxtBankedPoints.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtBankedPoints.Location = new System.Drawing.Point(417, 164);
            this.TxtBankedPoints.Name = "TxtBankedPoints";
            this.TxtBankedPoints.ReadOnly = true;
            this.TxtBankedPoints.Size = new System.Drawing.Size(89, 38);
            this.TxtBankedPoints.TabIndex = 1;
            this.TxtBankedPoints.TabStop = false;
            this.TxtBankedPoints.Text = "XXXXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = ">>";
            // 
            // BtnBank
            // 
            this.BtnBank.Location = new System.Drawing.Point(295, 209);
            this.BtnBank.Name = "BtnBank";
            this.BtnBank.Size = new System.Drawing.Size(211, 39);
            this.BtnBank.TabIndex = 3;
            this.BtnBank.Text = "BANK (End Turn)";
            this.BtnBank.UseVisualStyleBackColor = true;
            this.BtnBank.Click += new System.EventHandler(this.BtnBank_Click);
            // 
            // BtnRoll
            // 
            this.BtnRoll.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoll.Location = new System.Drawing.Point(34, 164);
            this.BtnRoll.Name = "BtnRoll";
            this.BtnRoll.Size = new System.Drawing.Size(240, 84);
            this.BtnRoll.TabIndex = 3;
            this.BtnRoll.Text = "ROLL";
            this.BtnRoll.UseVisualStyleBackColor = true;
            this.BtnRoll.Click += new System.EventHandler(this.BtnRoll_Click);
            // 
            // TLPnlDiceAside
            // 
            this.TLPnlDiceAside.ColumnCount = 7;
            this.TLPnlDiceAside.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPnlDiceAside.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPnlDiceAside.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPnlDiceAside.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPnlDiceAside.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPnlDiceAside.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPnlDiceAside.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPnlDiceAside.Controls.Add(this.BtnDie9, 1, 0);
            this.TLPnlDiceAside.Controls.Add(this.BtnDie10, 2, 0);
            this.TLPnlDiceAside.Controls.Add(this.BtnDie11, 3, 0);
            this.TLPnlDiceAside.Controls.Add(this.BtnDie13, 5, 0);
            this.TLPnlDiceAside.Controls.Add(this.BtnDie14, 6, 0);
            this.TLPnlDiceAside.Controls.Add(this.BtnDie8, 0, 0);
            this.TLPnlDiceAside.Controls.Add(this.BtnDie12, 4, 0);
            this.TLPnlDiceAside.Location = new System.Drawing.Point(16, 254);
            this.TLPnlDiceAside.Name = "TLPnlDiceAside";
            this.TLPnlDiceAside.RowCount = 1;
            this.TLPnlDiceAside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPnlDiceAside.Size = new System.Drawing.Size(490, 70);
            this.TLPnlDiceAside.TabIndex = 4;
            // 
            // BtnDie9
            // 
            this.BtnDie9.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDie9.Location = new System.Drawing.Point(72, 3);
            this.BtnDie9.Name = "BtnDie9";
            this.BtnDie9.Size = new System.Drawing.Size(63, 64);
            this.BtnDie9.TabIndex = 0;
            this.BtnDie9.Text = "X";
            this.BtnDie9.UseVisualStyleBackColor = true;
            this.BtnDie9.Click += new System.EventHandler(this.AsideBtnDie_Click);
            // 
            // BtnDie10
            // 
            this.BtnDie10.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDie10.Location = new System.Drawing.Point(141, 3);
            this.BtnDie10.Name = "BtnDie10";
            this.BtnDie10.Size = new System.Drawing.Size(63, 64);
            this.BtnDie10.TabIndex = 0;
            this.BtnDie10.Text = "X";
            this.BtnDie10.UseVisualStyleBackColor = true;
            this.BtnDie10.Click += new System.EventHandler(this.AsideBtnDie_Click);
            // 
            // BtnDie11
            // 
            this.BtnDie11.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDie11.Location = new System.Drawing.Point(210, 3);
            this.BtnDie11.Name = "BtnDie11";
            this.BtnDie11.Size = new System.Drawing.Size(63, 64);
            this.BtnDie11.TabIndex = 0;
            this.BtnDie11.Text = "X";
            this.BtnDie11.UseVisualStyleBackColor = true;
            this.BtnDie11.Click += new System.EventHandler(this.AsideBtnDie_Click);
            // 
            // BtnDie13
            // 
            this.BtnDie13.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDie13.Location = new System.Drawing.Point(348, 3);
            this.BtnDie13.Name = "BtnDie13";
            this.BtnDie13.Size = new System.Drawing.Size(63, 64);
            this.BtnDie13.TabIndex = 0;
            this.BtnDie13.Text = "X";
            this.BtnDie13.UseVisualStyleBackColor = true;
            this.BtnDie13.Click += new System.EventHandler(this.AsideBtnDie_Click);
            // 
            // BtnDie14
            // 
            this.BtnDie14.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDie14.Location = new System.Drawing.Point(417, 3);
            this.BtnDie14.Name = "BtnDie14";
            this.BtnDie14.Size = new System.Drawing.Size(63, 64);
            this.BtnDie14.TabIndex = 0;
            this.BtnDie14.Text = "X";
            this.BtnDie14.UseVisualStyleBackColor = true;
            this.BtnDie14.Click += new System.EventHandler(this.AsideBtnDie_Click);
            // 
            // BtnDie8
            // 
            this.BtnDie8.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDie8.Location = new System.Drawing.Point(3, 3);
            this.BtnDie8.Name = "BtnDie8";
            this.BtnDie8.Size = new System.Drawing.Size(63, 64);
            this.BtnDie8.TabIndex = 0;
            this.BtnDie8.Text = "X";
            this.BtnDie8.UseVisualStyleBackColor = true;
            this.BtnDie8.Click += new System.EventHandler(this.AsideBtnDie_Click);
            // 
            // BtnDie12
            // 
            this.BtnDie12.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDie12.Location = new System.Drawing.Point(279, 3);
            this.BtnDie12.Name = "BtnDie12";
            this.BtnDie12.Size = new System.Drawing.Size(63, 64);
            this.BtnDie12.TabIndex = 0;
            this.BtnDie12.Text = "X";
            this.BtnDie12.UseVisualStyleBackColor = true;
            this.BtnDie12.Click += new System.EventHandler(this.AsideBtnDie_Click);
            // 
            // TxtThreshold
            // 
            this.TxtThreshold.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtThreshold.ForeColor = System.Drawing.Color.Red;
            this.TxtThreshold.Location = new System.Drawing.Point(88, 73);
            this.TxtThreshold.Name = "TxtThreshold";
            this.TxtThreshold.Size = new System.Drawing.Size(339, 15);
            this.TxtThreshold.TabIndex = 5;
            this.TxtThreshold.Text = "LAST TURN!!";
            this.TxtThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCurrentPlayer
            // 
            this.TxtCurrentPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCurrentPlayer.Location = new System.Drawing.Point(0, 0);
            this.TxtCurrentPlayer.Name = "TxtCurrentPlayer";
            this.TxtCurrentPlayer.Size = new System.Drawing.Size(795, 31);
            this.TxtCurrentPlayer.TabIndex = 6;
            this.TxtCurrentPlayer.Text = "Current Player";
            this.TxtCurrentPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreListView
            // 
            this.ScoreListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ScoreListView.Location = new System.Drawing.Point(512, 35);
            this.ScoreListView.Name = "ScoreListView";
            this.ScoreListView.Size = new System.Drawing.Size(271, 289);
            this.ScoreListView.TabIndex = 7;
            this.ScoreListView.UseCompatibleStateImageBehavior = false;
            // 
            // FrmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 340);
            this.Controls.Add(this.ScoreListView);
            this.Controls.Add(this.TxtCurrentPlayer);
            this.Controls.Add(this.TxtThreshold);
            this.Controls.Add(this.TLPnlDiceAside);
            this.Controls.Add(this.BtnRoll);
            this.Controls.Add(this.BtnBank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBankedPoints);
            this.Controls.Add(this.TxtTurnPoints);
            this.Controls.Add(this.TLPnlDiceInHand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPlay";
            this.Text = "Greed";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPlay_FormClosed);
            this.TLPnlDiceInHand.ResumeLayout(false);
            this.TLPnlDiceAside.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPnlDiceInHand;
        private System.Windows.Forms.Button BtnDie1;
        private System.Windows.Forms.Button BtnDie2;
        private System.Windows.Forms.Button BtnDie3;
        private System.Windows.Forms.Button BtnDie4;
        private System.Windows.Forms.Button BtnDie5;
        private System.Windows.Forms.Button BtnDie6;
        private System.Windows.Forms.Button BtnDie7;
        private System.Windows.Forms.TextBox TxtTurnPoints;
        private System.Windows.Forms.TextBox TxtBankedPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBank;
        private System.Windows.Forms.Button BtnRoll;
        private System.Windows.Forms.TableLayoutPanel TLPnlDiceAside;
        private System.Windows.Forms.Button BtnDie9;
        private System.Windows.Forms.Button BtnDie10;
        private System.Windows.Forms.Button BtnDie11;
        private System.Windows.Forms.Button BtnDie12;
        private System.Windows.Forms.Button BtnDie13;
        private System.Windows.Forms.Button BtnDie14;
        private System.Windows.Forms.Button BtnDie8;
        private System.Windows.Forms.Label TxtThreshold;
        private System.Windows.Forms.Label TxtCurrentPlayer;
        private System.Windows.Forms.ListView ScoreListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}