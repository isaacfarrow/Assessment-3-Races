using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpClassMovingMonsters.Business;
using CSharpClassMovingMonsters.Business.AllPunters;

namespace CSharpClassMovingMonsters
{
    public partial class Form1 : Form
    {
        //Create my monsters
        Monster[] monster = new Monster[4];
        Punter[] myPunter;

        Punter CurrentPunter = new Howard();

        //Which monster wins
        private int MonsterWinner;

        //    ToolTip toolTip1 = new ToolTip();



        public Form1()
        {
            this.TopMost = true;
            myPunter = new Punter[3];
            InitializeComponent();
            LoadMonsters();
            LoadPunters();



        }

        #region Load The Monsters and Punters
        private void LoadMonsters()
        {
            //Make and instance of our monster
            monster[0] = new Monster { Length = 0, myPB = pb1, Name = "Bob" };
            monster[0].myPB.BackgroundImage = Resource1.Shane;

            monster[1] = new Monster { Length = 0, myPB = pb2, Name = "Larry" };
            monster[1].myPB.BackgroundImage = Resource1.Larry;

            monster[2] = new Monster { Length = 0, myPB = pb3, Name = "Mike" };
            monster[2].myPB.BackgroundImage = Resource1.Mike;

            monster[3] = new Monster { Length = 0, myPB = pb4, Name = "Scruffy" };
            monster[3].myPB.BackgroundImage = Resource1.Scruffy;

        }



        private void LoadPunters()

        {

            lblHCash.Text = " has $" + CurrentPunter.Cash.ToString();
            lblJCash.Text = " has $" + CurrentPunter.Cash.ToString();
            lblSCash.Text = " has $" + CurrentPunter.Cash.ToString();
            lblMaxBet.Text = " Opening maximum Bet is " + CurrentPunter.Cash.ToString();
            for (int i = 0; i < 3; i++)
            {
                myPunter[i] = Factory.GetAPunter(i);
                myPunter[i].LabelWinner = lblMaxBet;

            }
            udBet.Maximum = (decimal)CurrentPunter.Cash;
        }
        #endregion

        private void RunRace()
        {
            bool end = false;
            //Create a random number generator
            Random myRand = new Random();
            Random myRandStop = new Random();

            //while we haven't reached the end then keep on looping

            while (end != true) // while the end is not true
            {
                for (int i = 0; i < 4; i++)
                {
                    monster[i].myPB.Left += myRand.Next(1, 7);

                    // 50% of the time it takes 8 off the left which makes it go back
                    if (myRandStop.Next(1, 3) == 2)
                    {
                        monster[i].myPB.Left -= 4;
                    }

                    Application.DoEvents();

                    //if the monster reaches the end of the form minus the width of the picturebox, then stop
                    if (monster[i].myPB.Left > Form1.ActiveForm.Width - monster[i].myPB.Width - 40)
                    {
                        end = true; // loop until end =true
                        this.Text = monster[i].Name + " The Monster has won!!";

                        //This is the monster that won the race
                        MonsterWinner = i;
                    }
                }
            }

            WinnerPunter();

        }

        private void WinnerPunter()
        {

            //updates cash if they won or lost
            for (int i = 0; i < 3; i++)
            {
                if (myPunter[i].Cash == 0)
                {
                    myPunter[i].Bet = 0;

                }

                if (MonsterWinner == myPunter[i].Monster)
                {
                    myPunter[i].Cash += myPunter[i].Bet;

                }

                else
                {
                    myPunter[i].Cash -= myPunter[i].Bet;
                }


                //checks the punters have money left, visually updates it, disables radio buttons if no money left
                switch (myPunter[i].PunterName)
                {
                    //instantiate that punter
                    case "Howard":
                        lblHCash.Text = " has $" + myPunter[0].Cash.ToString();
                        if (myPunter[0].Cash <= 0)
                        {
                            txtHoward.Text = "You have no Money Left";
                            rbHoward.Enabled = false;
                        }

                        else if (myPunter[0].Cash > 0)
                        {
                            txtHoward.Text = "Howard has " + myPunter[0].Cash.ToString() + " left.";

                        }

                        break;

                    case "Susan":
                        lblSCash.Text = " has $" + myPunter[1].Cash.ToString();
                        if (myPunter[1].Cash <= 0)
                        {
                            txtSusan.Text = "You have no Money Left";
                            rbSusan.Enabled = false;
                        }

                        else if (myPunter[1].Cash > 0)
                        {
                            txtSusan.Text = "Susan has " + myPunter[1].Cash.ToString() + " left.";
                        }

                        break;

                    case "John":
                        lblJCash.Text = " has $" + myPunter[2].Cash.ToString();
                        if (myPunter[2].Cash <= 0)
                        {
                            txtJohn.Text = "You have no Money Left";
                            rbJohn.Enabled = false;

                        }
                        else if (myPunter[2].Cash > 0)
                        {
                            txtJohn.Text = "John has " + myPunter[2].Cash.ToString() + " left.";
                        }



                        break;



                }

            }

            //checks to see if anyone has money left, if no one does GAME OVER
            if (myPunter[0].Cash <= 0 && myPunter[1].Cash <= 0 && myPunter[2].Cash <= 0)
            {
                MessageBox.Show("GAME OVER, ALL PUNTERS ARE BROKE!!");
            }


        }

        //starts the race
        private void BtnStart_Click(object sender, EventArgs e)
        {
            RunRace();
        }

        // resets the monkeys
        private void BtnReset_Click(object sender, EventArgs e)
        {
            udBet.Maximum = (decimal)CurrentPunter.Cash;
            txtHoward.Clear();
            txtSusan.Clear();
            txtJohn.Clear();
            this.Text = "";
            for (int i = 0; i < 4; i++)
            {
                monster[i].myPB.Left = 10;
            }
        }


        //checks which punter is selected
        private void AllRB_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton fakeRB = new RadioButton();
            fakeRB = (RadioButton)sender;

            if (fakeRB.Checked == true)
            {


                //look for the name of the person we have clicked on 
                switch (fakeRB.Text)
                {
                    //instantiate that punter
                    case "Howard":

                        CurrentPunter = myPunter[0];
                        break;

                    case "Susan":

                        CurrentPunter = myPunter[1];
                        break;

                    case "John":

                        CurrentPunter = myPunter[2];
                        break;
                }
                udBet.Maximum = (decimal)CurrentPunter.Cash;
            }
        }

        //Takes in who the punter bet on an how much $ bet
        private void BtnBets_Click(object sender, EventArgs e)

        {

            CurrentPunter.Bet = (float)udBet.Value;
            //  lblBettorName.Text += CurrentPunter.PunterName + " Bets " + CurrentPunter.Bet + "\r\n";

            //CurrentPunter.PunterName + " is the current Punter and bet $" + CurrentPunter.Bet;
            //  udBet.Maximum = (decimal)CurrentPunter.Cash;
            CurrentPunter.Monster = (int)udMonkey.Value;

            switch (CurrentPunter.PunterName)
            {
                case "Howard":

                    txtHoward.Text = "Howard bet " + CurrentPunter.Bet + " on " + monster[CurrentPunter.Monster].Name;

                    break;

                case "Susan":

                    txtSusan.Text = "Susan bet " + CurrentPunter.Bet + " on " + monster[CurrentPunter.Monster].Name;
                    break;

                case "John":

                    txtJohn.Text = "John bet " + CurrentPunter.Bet + " on " + monster[CurrentPunter.Monster].Name;
                    break;
                default:
                    break;
            }


        }


        //Resets the game
        private void Button1_Click(object sender, EventArgs e)
        {

            this.Close();

        }




        //    private void RbHoward_MouseHover(object sender, EventArgs e)
        //   {
        //    ToolTip.SetToolTip(rbHoward, "Compare files in the same folder");
        //    }


    }
}
