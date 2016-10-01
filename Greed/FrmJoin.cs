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
            TxtNameJoin.Text = string.Empty;
        }
    }
}
