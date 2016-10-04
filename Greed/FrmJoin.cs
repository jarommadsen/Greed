using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greed
{
    public partial class FrmJoin : Form
    {
        public FrmJoin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// BtnJoin click event.  Puts the string in the name txtbox into the joinedlistbox, if it isn't already in it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnJoin_Click(object sender, EventArgs e)
        {
            // player name
            string newPlayer = TxtNameJoin.Text;

            // check if it is a valid name
            if (string.IsNullOrWhiteSpace(newPlayer))
            {
                // empty name
                return;
            }

            // check if name has already been added
            if (LBxJoinedPlayerNames.FindStringExact(newPlayer) >= 0)
            {
                // player already in list
                return;
            }

            // add player to list and clear the textbox
            LBxJoinedPlayerNames.Items.Add(newPlayer);

            //Enable Start button if more than 2 players have been added
            if(LBxJoinedPlayerNames.Items.Count >= 2)
            {
                BtnStart.Enabled = true;
            }
            TxtNameJoin.Text = string.Empty;
        }
        /// <summary>
        /// Select all text when text box is clicked for easy renaming
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtNameJoin_Click(object sender, EventArgs e)
        {
            TxtNameJoin.SelectAll();
        }
        /// <summary>
        /// Disable Join button if no text has been entered and enable if there is text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtNameJoin_TextChanged(object sender, EventArgs e)
        {
            if(TxtNameJoin.Text == "")
            {
                BtnJoin.Enabled = false;
            }else
            {
                BtnJoin.Enabled = true;
            }
        }
        
        /// <summary>
        /// Disable Leave button if no player is selected and visa versa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LBxJoinedPlayerNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LBxJoinedPlayerNames.SelectedItem == null)
            {
                BtnLeave.Enabled = false;
            }else
            {
                BtnLeave.Enabled = true;
            }
        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {
            DeletePlayer();
        }

        private void DeletePlayer()
        {
            LBxJoinedPlayerNames.Items.Remove(LBxJoinedPlayerNames.SelectedItem);
            if (LBxJoinedPlayerNames.Items.Count < 2)
            {
                BtnStart.Enabled = false;
            }
        }

        private void LBxJoinedPlayerNames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeletePlayer();
            }
        }

        /// <summary>
        /// Creates new players and switches to play form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            foreach (object element in LBxJoinedPlayerNames.Items)
            {
                Control.AddPlayer(new Player(element.ToString()));
            }
            Hide();
            FrmPlay frm = new FrmPlay();
            frm.Show();
        }
    }
}
