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
    public partial class FrmPlay : Form
    {
        private const string EMPTY_SLOT_TXT = "";
        private const int START_THRESHOLD = 1000;
        private const int END_THRESHOLD = 10000;
        private const string FRMT_SCORE = "{0:n0}";

        Button[] _handBtns;
        Button[] _asideBtns;
        Button[] _allBtns;
        IDice[] _allBtnDice;
        List<IDice> _modifiedDice;
        int _winThreshold;
        bool _finalRound;
        Player _winner;
        bool _bust;
        int LB_Scores_PrevSel;

        public FrmPlay()
        {
            InitializeComponent();
            _finalRound = false;
            _winner = null;
            _winThreshold = END_THRESHOLD;
            _handBtns = new Button[7] { BtnDie1, BtnDie2, BtnDie3, BtnDie4, BtnDie5, BtnDie6, BtnDie7 };
            _asideBtns = new Button[7] { BtnDie8, BtnDie9, BtnDie10, BtnDie11, BtnDie12, BtnDie13, BtnDie14 };
            _allBtns = new Button[14];
            _allBtnDice = new IDice[14];
            for (int i = 0; i < 7; i++)
            {
                _allBtns[i] = _handBtns[i];
            }
            for (int i = 7; i < 14; i++)
            {
                _allBtns[i] = _asideBtns[i-7];
            }
            _modifiedDice = new List<IDice>();
            NextPlayer();
        }

        /// <summary>
        /// updates the form to display all the appropriate information
        /// </summary>
        private void UpdateView()
        {
            //Empty the buttons
            int i = 0;
            foreach (Button element in _allBtns)
            {
                element.Text = EMPTY_SLOT_TXT;
                _allBtnDice[i] = null;
                i++;
            }
            //Refill the buttons
            i = 0;
            foreach (IDice element in Control.DiceInHand)
            {
                _handBtns[i].Text = element.Face.ToString();
                _allBtnDice[i] = element;
                if (!_modifiedDice.Contains(element))
                {
                    _handBtns[i].Enabled = false;
                }
                else
                {
                    _handBtns[i].Enabled = true;
                }
                i++;
            }

            i = 0;
            foreach (IDice element in Control.DiceSetAside)
            {
                _asideBtns[i].Text = element.Face.ToString();
                _allBtnDice[i + 7] = element;
                if (!_modifiedDice.Contains(element))
                {
                    _asideBtns[i].Enabled = false;
                }
                else
                {
                    _asideBtns[i].Enabled = true;
                }
                i++;
            }
            //Enable/Disable the buttons
            foreach (Button element in _allBtns)
            {
                if (element.Text == EMPTY_SLOT_TXT)
                {
                    element.Enabled = false;
                }
            }
            //Enable/Disable Roll and Bank buttons
            BtnRoll.Enabled = false;
            BtnBank.Enabled = false;
            BtnBank.Text = "BANK(End Turn)";
            List<IDice> list = ModifiedSetAside();
            if (Control.DiceAreAllPoints(list))
            {
                if (list.Count > 0 && Control.DiceGroupHasPoints(Control.DiceSetAside))
                {
                    BtnRoll.Enabled = true;
                }
                int roundScore = Control.CurrentPlayer.TurnScore + Control.GetDicePoints(list);
                int score = Control.CurrentPlayer.BankedScore + roundScore;
                if ((roundScore > 0 && (!_finalRound && score >= START_THRESHOLD) || (_finalRound && score > _winThreshold)) || _bust)
                {
                    BtnBank.Enabled = true;
                    if (_bust)
                    {
                        BtnBank.Text = "BUST(End Turn)";
                        TxtThreshold.ForeColor = Color.Red;
                        if(_finalRound && score <= _winThreshold)
                        {
                            TxtThreshold.Text = "YOU'RE OUT!";
                        }else
                        {
                            TxtThreshold.Text = "BUST! No points gained this round.";
                        }
                    }
                }
            }

            //Update Scores
            //Turn Score
            int val = Control.CurrentPlayer.TurnScore + Control.GetDicePoints(list);
            if (_finalRound)
            {
                if (val > _winThreshold)
                {
                    TxtThreshold.ForeColor = Color.Black;
                    TxtThreshold.Text = "You are in the lead!";
                }
            }else
            {
                if(Control.CurrentPlayer.BankedScore < START_THRESHOLD && val >= START_THRESHOLD)
                {
                    TxtThreshold.Text = "Bank now to get in the game!";
                }
                if(val >= _winThreshold)
                {
                    TxtThreshold.Text = "Bank now to start the Final Round!";
                }
            }
            TxtTurnPoints.Text = val.ToString();
            //Banked Score
            TxtBankedPoints.Text = Control.CurrentPlayer.BankedScore.ToString();

        }

        //Returns the list of dice that are modified xand (exclusive and) set aside
        private List<IDice> ModifiedSetAside()
        {
            List<IDice> list = new List<IDice>();
            foreach (IDice element in Control.DiceSetAside)
            {
                if (_modifiedDice.Contains(element))
                {
                    list.Add(element);
                }
            }

            return list;
        }

        /// <summary>
        /// Click on a die in hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandBtnDie_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            IDice die;
            die = _allBtnDice[Array.IndexOf(_allBtns, button)];
            Control.SetAside(die);
            UpdateView();
        }
        /// <summary>
        /// Click on set aside button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AsideBtnDie_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            IDice die;
            die = _allBtnDice[Array.IndexOf(_allBtns, button)];
            Control.SetInHand(die);
            UpdateView();
        }

        private void FrmPlay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NextPlayer()
        {
            _bust = false;
            Control.NextPlayer();
            UpdateView();
            foreach(Button element in _handBtns)
            {
                element.Enabled = false;
            }
            BtnRoll.Enabled = true;

            //Update text
            //Update current player name
            TxtCurrentPlayer.Text = Control.CurrentPlayer.Name;

            //Update help line
            if (_finalRound) {
                TxtThreshold.ForeColor = Color.Red;
                TxtThreshold.Text = "LAST ROUND! Score to beat: " + _winThreshold;
            } else {
                if (Control.CurrentPlayer.BankedScore < START_THRESHOLD)
                {
                    TxtThreshold.ForeColor = Color.Blue;
                    TxtThreshold.Text = "Score at least " + string.Format(FRMT_SCORE,START_THRESHOLD) + " points to get in the game";
                }
                else
                {
                    TxtThreshold.ForeColor = Color.Black;
                    TxtThreshold.Text = "Score " + string.Format(FRMT_SCORE, _winThreshold) + " points to start Final Round";
                }
            }
            //Update Scorebox
            LB_Scores.Items.Clear();
            int i = 0;
            foreach(Player element in Control.Players)
            {
                LB_Scores.Items.Add(element.Name + ": " + string.Format(FRMT_SCORE, element.BankedScore));
                if(element == Control.CurrentPlayer)
                {
                    LB_Scores_PrevSel = i;
                    LB_Scores.SelectedIndex = i;
                }
                i++;
            }
        }

        /// <summary>
        /// ROLL Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRoll_Click(object sender, EventArgs e)
        {
            List<IDice> list = ModifiedSetAside();
            Control.CurrentPlayer.TurnScore += Control.GetDicePoints(list);

            _modifiedDice.Clear();

            //REROLL!!!
            if (Control.DiceInHand.Count == 0)
            {
                Control.TakeAllDiceInHand();
            }
            //Roll dice
            foreach(IDice element in Control.DiceInHand)
            {
                element.Roll();
            }
            //Add dice with points to modified list
            foreach(IDice element in Control.DiceInHand)
            {
                if (Control.DieHasWorth(element, Control.DiceInHand))
                {
                    _modifiedDice.Add(element);
                }
            }
            //Bust
            if(_modifiedDice.Count == 0)
            {
                Control.CurrentPlayer.TurnScore = 0;
                _bust = true;
            }
            BtnRoll.Enabled = false;
            UpdateView();
        }

        /// <summary>
        /// Bank
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBank_Click(object sender, EventArgs e)
        {
            List<IDice> list = ModifiedSetAside();
            Control.CurrentPlayer.TurnScore += Control.GetDicePoints(list);

            //Only bank points if beginning threshold has been reached
            if (Control.CurrentPlayer.BankedScore + Control.CurrentPlayer.TurnScore >= START_THRESHOLD)
            {
                Control.CurrentPlayer.BankedScore += Control.CurrentPlayer.TurnScore;
                System.Diagnostics.Debug.WriteLine(Control.CurrentPlayer.Name + " banked: "+Control.CurrentPlayer.TurnScore);
                System.Diagnostics.Debug.WriteLine(Control.CurrentPlayer.Name + ": " + Control.CurrentPlayer.BankedScore);
            }
            //Trigger final round if score crosses win threshold
            if((!_finalRound && Control.CurrentPlayer.BankedScore >= _winThreshold)||Control.CurrentPlayer.BankedScore>_winThreshold)
            {
                _finalRound = true;
                _winner = Control.CurrentPlayer;
                _winThreshold = Control.CurrentPlayer.BankedScore;
            }
            Control.CurrentPlayer.TurnScore = 0;
            if (_finalRound && _bust)
            {
                Control.RemovePlayer(Control.CurrentPlayer);
            }
            NextPlayer();

            //Winner?
            if (_finalRound && Control.CurrentPlayer == _winner)
            {
                Hide();
                FrmGameOver frm = new FrmGameOver(_winner);
                frm.Show();
            }
        }

        private void LB_Scores_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_Scores.SelectedIndex = LB_Scores_PrevSel;
        }
    }
}
