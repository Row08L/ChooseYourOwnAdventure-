using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace ChooseYourOwnAdventure__
{
    public partial class Form1 : Form
    {
        int page = 1;
        string newInventoryItem = "";
        Random randGen = new Random();
        int hideChance = 0;
        string[] items = { "Gun", "T̶̗͝H̷̩̑Ě̸͖ ̶̹́Ĉ̶͙U̷̬͑B̷͔͒Ë̸̡", "Explosive" };
        bool gunHave = false;
        bool THECUBEHave = false;
        bool explosiveHave = false;
        int chanceItemGet = 0;
        int timeUsed = 0;
        int timeDeath = 0;
        bool escapedOnce = false;
        int angerChance = 0;
        int anger = 0;
        int impatiance = 0;
        bool tired = false;
        bool completed = false;


        public Form1()
        {
            InitializeComponent();
            SoundPlayer sound = new SoundPlayer(Properties.Resources.silentExploit);
            sound.Play();
            choiceReset();
            outputLabel.Text = "You awaken in a dark place and hear an engine start. What do you do?";
            choiceButton1.Text = "Look around for something";
            choiceButton2.Text = "Attempt to escape";
            timeDeath = randGen.Next(6, 10)
            page = 1;
        }

        private void choiceButton1_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.silentExploit);
            if (page == 1)
            {
                page = 2;
                timeUsed = timeUsed + 1;
                chanceItemGet = randGen.Next(1, 11);
                if (chanceItemGet >= 8)
                {
                    chanceItemGet = randGen.Next(0, 4);
                    newInventoryItem = (items[chanceItemGet]);
                    if (newInventoryItem == "Gun")
                    {
                        gunHave = true;
                        items[0] = "";
                    }
                    if (newInventoryItem == "T̶̗͝H̷̩̑Ě̸͖ ̶̹́Ĉ̶͙U̷̬͑B̷͔͒Ë̸̡")
                    {
                        THECUBEHave = true;
                        items[1] = "";
                    }
                    if (newInventoryItem == "Explosive")
                    {
                        explosiveHave = true;
                        items[2] = "";
                    }
                    if (newInventoryItem == "")
                    {
                        page = 2002;
                    }
                }
                else
                {
                    page = 2002;
                }
                intermitentPages();
            }
            else if (page == 3)
            {
                page = 2;
                timeUsed = timeUsed + 1;
                chanceItemGet = randGen.Next(1, 11);
                if (chanceItemGet >= 8)
                {
                    chanceItemGet = randGen.Next(0, 3);
                    newInventoryItem = (items[chanceItemGet]);
                    if (newInventoryItem == "Gun")
                    {
                        gunHave = true;
                        items[0] = "nul";
                    }
                    if (newInventoryItem == "T̶̗͝H̷̩̑Ě̸͖ ̶̹́Ĉ̶͙U̷̬͑B̷͔͒Ë̸̡")
                    {
                        THECUBEHave = true;
                        items[1] = "nul";
                    }
                    if (newInventoryItem == "Explosive")
                    {
                        explosiveHave = true;
                        items[2] = "nul";
                    }
                    if (newInventoryItem == "nul")
                    {
                        page = 2002;
                    }
                }
                else
                {
                    page = 2002;
                }
                intermitentPages();
            }
            else if (page == 5)
            {
                page = 7;
                intermitentPages();
            }
            else if (page == 9)
            {
                Application.Restart();
            }
            else if (page == 11)
            {
                page = 12;
                intermitentPages();
            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 15)
            {
                Application.Restart();
            }
            else if (page == 18)
            {
                page = 19;
                intermitentPages();
            }
            else if (page == 23)
            {
                page = 24;
                intermitentPages();
            }
            else if (page == 26)
            {
                page = 27;
                intermitentPages();
            }
            else if (page == 30)
            {
                page = 31;
                intermitentPages();
            }
            else if (page == 33)
            {
                page = 72;
            }
            else if (page == 35)
            {
                page = 36;
            }
            else if (page == 36)
            {
                page = 36;
            }
            else if (page == 38)
            {
                page = 72;
            }
            else if (page == 46)
            {
                page = 54;
                intermitentPages();
            }
            else if (page == 52)
            {
                Application.Restart();
            }
            else if (page == 53)
            {
                Application.Restart();
            }
            else if (page == 55)
            {
                page = 58;
            }
            else if (page == 57)
            {
                page = 58;
            }
            else if (page == 62)
            {
                Application.Restart();
            }
            else if (page == 71)
            {
                page = 1;
                newInventoryItem = "";
                Random randGen = new Random();
                hideChance = 0;
                string[] items = { "Gun", "T̶̗͝H̷̩̑Ě̸͖ ̶̹́Ĉ̶͙U̷̬͑B̷͔͒Ë̸̡", "Explosive" };
                gunHave = false;
                THECUBEHave = false;
                explosiveHave = false;
                chanceItemGet = 0;
                timeUsed = 0;
                timeDeath = 0;
                escapedOnce = false;
                angerChance = 0;
                anger = 0;
                impatiance = 0;
                tired = false;
                completed = false;
                choiceButton1.Visible = true;
                choiceButton2.Visible = true;
                choiceButton3.Visible = true;
                choiceButton4.Visible = true;
                outputLabel.Height = 191;
                endingBox.Height = 27;
                endingBox.Width = 83;
                endingBox.Image = Properties.Resources.white;
                timeDeath = randGen.Next(6, 9);

            }
            else if (page == 72)
            {
                page = 74;
                intermitentPages();
            }
            else if (page == 73)
            {
                Application.Restart();
            }
            else if (page == 404)
            {
                Application.Restart();
            }


            switch (page)
            {
                case 1:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "You awaken in a dark place and hear an engine start. What do you do?";
                    choiceButton1.Text = "Look around for something";
                    choiceButton2.Text = "Attempt to escape";
                    if (escapedOnce == true)
                    {
                        choiceButton3.Text = "Talk";
                    }
                    break;

                case 3:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "You are still in the dark and moving. What do you do?";
                    choiceButton1.Text = "Look around for something";
                    choiceButton2.Text = "Attempt to escape";
                    if (escapedOnce == true)
                    {
                        choiceButton3.Text = "Talk";
                    }
                    break;
                case 11:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "The SUV is now speeding up even more. What do you do?";
                    choiceButton1.Text = "Run";
                    if (gunHave == true)
                    {
                        choiceButton2.Text = "Shoot at the van";
                    }
                    break;
                case 15:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "You decide you to run into the inaccurate gun fire, dying instantly to a bullet in the head. Do you want to play again?";
                    choiceButton1.Text = "Yes";
                    choiceButton2.Text = "No";
                    break;
                case 23:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "You feel your self drifting off to sleep again. What do you do?";
                    choiceButton1.Text = "Resist";
                    choiceButton2.Text = "Sleep";
                    break;
                case 26:
                    sound.Play();
                    choiceReset();
                    tired = true;
                    outputLabel.Text = "You wake up sometime later, no longer hearing the hum of an engine. What do you do?";
                    choiceButton1.Text = "Look around";
                    choiceButton2.Text = "Attempt another escape";
                    break;
                case 30:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "He says \"Hello Mr. Demetry, you know why you're here today, correct? What do you say?\"";
                    choiceButton1.Text = "No";
                    choiceButton2.Text = "Yes";
                    break;
                case 33:
                    sound.Play();
                    choiceReset();
                    timeUsed = timeUsed + 1;
                    outputLabel.Text = "The man then abruptly stands up and briskly walks out of the room. What do you do?";
                    choiceButton1.Text = "Attempt another escape";
                    break;
                case 36:
                    sound.Play();
                    choiceReset();
                    impatiance++;

                    if ( impatiance < 3)
                    {
                        outputLabel.Text = "You stay seated blankly staring at a wall. The man stays there looking impatient? What do you do?";
                        choiceButton1.Text = "Stay";
                        choiceButton2.Text = "Follow";
                        if (gunHave == true)
                        {
                            choiceButton3.Text = "Shoot him";
                        }
                    }
                    else
                    {
                        timeUsed = timeUsed + 1;
                        outputLabel.Text = "You stay seated blankly staring at a wall. The man stays there looking impatient?";
                        Refresh();
                        Thread.Sleep(2000);
                        outputLabel.Text = "The man sighs and leaves angrily rambling about something. What do you do?";
                        choiceButton1.Text = "Attempt another escape";
                        page = 38;
                    }
                    break;
                case 55:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "The thing is starting undulate and wriggle. What do you do?";
                    choiceButton1.Text = "Tell the people to shut down the machine";
                    choiceButton2.Text = "Wait for more to happen";
                    choiceButton3.Text = "Fight it";
                    break;
                case 58:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "You yell to the other people to shut it down. You seem to be an authority on the subject so people quickly rush to shut it down";
                    timeUsed = timeUsed + 999;
                    break;
                case 72:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "You look around quickly and see a door and a vent. What do you do?";
                    choiceButton1.Text = "Use the vent";
                    choiceButton2.Text = "Bang on the door";
                    if (explosiveHave == true)
                    {
                        choiceButton3.Text = "Use explosives";
                    }
                    break;
                case 77:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "You crawl towards it";
                    timeUsed = timeUsed + 999;
                    break;
            }
            if (timeUsed >= timeDeath)
            {
                choiceButton1.Visible = false;
                choiceButton2.Visible = false;
                choiceButton3.Visible = false;
                choiceButton4.Visible = false;
                endingBox.Height = (451);
                endingBox.Width = (818);
                outputLabel.Height = 390;
                outputLabel.Parent = endingBox;
                Refresh();
                endingBox.Image = Properties.Resources.static_white;
                outputLabel.ForeColor = Color.White;
                Thread.Sleep(2000);
                outputLabel.Text = "Your vision goes white and you don't have any senses. As you lose consciousness you feel disappointed";
                Refresh();
                Thread.Sleep(2000);
                outputLabel.Height = 240;
                outputLabel.Text = "Ending \"There's No Time To Explain\" Achieved. Play again?";
                choiceButton1.Text = "Yes";
                choiceButton2.Text = "No";
                page = 404;
                choiceButton1.Parent = endingBox;
                choiceButton2.Parent = endingBox;
                choiceButton1.Visible = true;
                choiceButton2.Visible = true;
                Refresh();
            }
        }

        private void choiceButton2_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.silentExploit);
            if (page == 1)
            {
                page = 4;
                intermitentPages();
            }
            else if (page == 3)
            {
                page = 4;
                intermitentPages();
            }
            else if (page == 5)
            {
                page = 6;
                intermitentPages();
            }
            else if (page == 9)
            {
                Application.Exit();
            }
            else if (page == 11)
            {
                if (gunHave == true)
                {
                    page = 14;
                }
            }
            else if (page == 14)
            {
                page = 16;
                intermitentPages();
            }
            else if (page == 15)
            {
                Application.Exit();
            }
            else if (page == 18)
            {
                page = 20;
                intermitentPages();
            }
            else if (page == 23)
            {
                page = 25;
                intermitentPages();
            }
            else if (page == 26)
            {
                page = 72;
            }
            else if (page == 30)
            {
                page = 34;
                intermitentPages();
            }
            else if (page == 35)
            {
                page = 41;
                intermitentPages();
            }
            else if (page == 46)
            {
                page = 53;
            }
            else if (page == 52)
            {
                Application.Exit();

            }
            else if (page == 53)
            {
                Application.Exit();

            }
            else if (page == 55)
            {
                page = 56;
                intermitentPages();
            }
            else if (page == 57)
            {
                page = 56;
                intermitentPages();
            }
            else if (page == 62)
            {
                Application.Exit();
            }
            else if (page == 71)
            {
                Application.Exit();
            }
            else if (page == 72)
            {
                page = 78;
                intermitentPages();
            }
            else if (page == 73)
            {
                Application.Exit();
            }
            else if (page == 404)
            {
                Application.Exit();
            }
            switch (page)
            {
                case 1:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "You awaken in a dark place and hear an engine start. What do you do?";
                    choiceButton1.Text = "Look around for something";
                    choiceButton2.Text = "Attempt to escape";
                    if (escapedOnce == true)
                    {
                        choiceButton3.Text = "Talk";
                    }
                    break;
                case 5:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "You fall out on to a highway. What you now know is a black SUV speeding away from you. What do you do?";
                    choiceButton1.Text = "Look for help";
                    choiceButton2.Text = "Find out who you are";
                    choiceButton3.Text = "Hide";
                    break;
                case 11:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "The SUV is now speeding up even more. What do you do?";
                    choiceButton1.Text = "Run";
                    if (gunHave == true)
                    {
                        choiceButton2.Text = "Shoot at the van";
                    }
                    break;
                case 14:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "You shoot at the van, emptying your mag and they start to return fire but it's highly inaccurate. What do you do?";
                    choiceButton1.Text = "Move";
                    choiceButton2.Text = "Stand still";
                    break;
                case 23:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "You feel your self drifting off to sleep again. What do you do?";
                    choiceButton1.Text = "Resist";
                    choiceButton2.Text = "Sleep";
                    break;
                case 26:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "You wake up sometime later, no longer hearing the hum of an engine. What do you do?";
                    choiceButton1.Text = "Look around";
                    choiceButton2.Text = "Attempt another escape";
                    break;
                case 35:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "He then stands up quickly walks out the door and beckons you. What do you do?";
                    choiceButton1.Text = "Stay";
                    choiceButton2.Text = "Follow";
                    if (gunHave == true)
                    {
                        choiceButton3.Text = "Shoot him";
                    }
                    break;
                case 46:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "Something n̴̤̥͆̒ō̸͇͖̿t̶̨̪̐̅ ̶̼̭̈̄o̶̠͖̐̒f̷̳̼̐̎ ̸͇̠̕͠ṯ̴̣͑͆h̵͖̖̄̓ĩ̴̟͂ͅs̸̹̘̊̈́ ̸̟͕́̇ẃ̶̻̪̈́o̵̡̡͌̓r̶̼̱̉͆l̴͈̮̽̋d̷͍̱̂̕ starts forming in the ring. What do you do?";
                    choiceButton1.Text = "Inspect it";
                    choiceButton2.Text = "Run!";
                    if (THECUBEHave == true)
                    {
                        choiceButton3.Text = "Offer T̶̗͝H̷̩̑Ě̸͖ ̶̹́Ĉ̶͙U̷̬͑B̷͔͒Ë̸̡";
                    }
                    break;
                case 53:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "You turn around and run as fast as you can but you trip on one of the uncountable pipes tumbling and eventually falling into what looks like a coolant moat. You die. Play again?";
                    choiceButton1.Text = "Yes";
                    choiceButton2.Text = "No";
                    break;
                case 57:
                    sound.Play();
                    choiceReset();
                    timeUsed = timeUsed + 1;
                    outputLabel.Text = "The ṭ̷̦̍̆h̶̛͇̭͊i̶̹̜͆͒ň̷̫͔͛g̵͖̻̔̒ countinues to pulsate. What do you do?";
                    choiceButton1.Text = "Tell the people to shut down the machine";
                    choiceButton2.Text = "Wait for more to happen";
                    choiceButton3.Text = "Fight it";
                    break;
                case 72:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "You look around quickly and see a door and a vent. What do you do?";
                    choiceButton1.Text = "Use the vent";
                    choiceButton2.Text = "Bang on the door";
                    if (explosiveHave == true)
                    {
                        choiceButton3.Text = "Use explosives";
                    }
                    break;
                case 78:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "You are restrained but you pass out from the force";
                    timeUsed = timeUsed + 999;
                    break;

            }
            if (timeUsed >= timeDeath)
            {
                choiceButton1.Visible = false;
                choiceButton2.Visible = false;
                choiceButton3.Visible = false;
                choiceButton4.Visible = false;
                endingBox.Height = (451);
                endingBox.Width = (818);
                outputLabel.Height = 390;
                outputLabel.Parent = endingBox;
                Refresh();
                endingBox.Image = Properties.Resources.static_white;
                outputLabel.ForeColor = Color.White;
                Thread.Sleep(2000);
                sound.Play();
                outputLabel.Text = "Your vision goes white and you don't have any senses. As you lose consciousness you feel disappointed";
                Refresh();
                Thread.Sleep(2000);
                outputLabel.Height = 240;
                sound.Play();
                outputLabel.Text = "Ending \"There's No Time To Explain\" Achieved. Play again?";
                choiceButton1.Text = "Yes";
                choiceButton2.Text = "No";
                page = 404;
                choiceButton1.Parent = endingBox;
                choiceButton2.Parent = endingBox;
                choiceButton1.Visible = true;
                choiceButton2.Visible = true;
                Refresh();
            }


        }

        private void choiceButton3_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.silentExploit);
            if (page == 5)
            {
                hideChance = randGen.Next (1, 101);
                if (hideChance == 1)
                {
                    page = 9;
                }
                else 
                {
                    page = 8;
                }
                intermitentPages();
            }
            else if (page == 1 && escapedOnce == true)
            {
                angerChance = randGen.Next(1, 101);
                if (angerChance > anger)
                {
                    page = 18;
                }
                else
                {
                    page = 17;
                    intermitentPages();
                }
            }
            else if (page == 18)
            {
                page = 21;
                intermitentPages();
            }
            else if (page == 30)
            {
                page = 21;
                intermitentPages();
            }
            else if (page == 35)
            {
                if (gunHave == true)
                {
                    page = 39;
                    intermitentPages();
                }
            }
            else if (page == 46)
            {
                if (THECUBEHave == true)
                {
                    page = 47;
                    intermitentPages();
                }
            }
            else if (page == 55)
            {
                if (tired == true)
                {
                    page = 59;
                    intermitentPages();
                }
                else
                {
                    page = 63;
                    intermitentPages();
                }
            }
            else if (page == 57)
            {
                if (tired == true)
                {
                    page = 59;
                    intermitentPages();
                }
                else
                {
                    page = 63;
                    intermitentPages();
                }
            }
            else if (page == 72)
            {
                if (explosiveHave == true)
                {
                    page = 73;
                }
            }
            switch (page)
            {
                case 3:
                    choiceReset();
                    sound.Play();
                    outputLabel.Text = "You are still in the dark and moving. What do you do?";
                    choiceButton1.Text = "Look around for something";
                    choiceButton2.Text = "Attempt to escape";
                    break;
                case 9:
                    choiceReset();
                    sound.Play();
                    outputLabel.Text = "You dive from the surprisingly empty highway into a large pile of garbage, successfully hiding your self";
                    Refresh();
                    Thread.Sleep(5000);
                    sound.Play();
                    outputLabel.Text = "You escaped? You won? Play again?";
                    choiceButton1.Text = "Yes";
                    choiceButton2.Text = "No";
                    Refresh();
                    break;
                case 11:
                    choiceReset();
                    sound.Play();
                    outputLabel.Text = "The SUV is now speeding up even more. What do you do?";
                    choiceButton1.Text = "Run";
                    if (gunHave == true)
                    {
                        choiceButton2.Text = "Shoot at the van";
                    }
                    break;
                case 18:
                    choiceReset();
                    sound.Play();
                    outputLabel.Text = "You try to talk to the drivers and they respond! what do you ask?";
                    choiceButton1.Text = "Where are we?";
                    choiceButton2.Text = "Why are you doing this?";
                    choiceButton3.Text = "Who are you?";
                    choiceButton4.Text = "Where are we going?";
                    break;
                case 23:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "You feel your self drifting off to sleep again. What do you do?";
                    choiceButton1.Text = "Resist";
                    choiceButton2.Text = "Sleep";
                    break;
                case 52:
                    sound.Play();
                    choiceReset();
                    outputLabel.Text = "Ending \"Ṭ̵̀h̸͚͛ĕ̶͕ ̴̘̽L̸̜̆o̵̠̔s̸̤̅t̷̞͠\" achieved. Play again?";
                    choiceButton1.Text = "Yes";
                    choiceButton2.Text = "No";
                    choiceButton1.Parent = endingBox;
                    choiceButton2.Parent = endingBox;
                    outputLabel.Height = 318;
                    break;
                case 62:
                    choiceReset();
                    sound.Play();
                    outputLabel.Text = "Your fate is worse than death. Play Again?";
                    choiceButton1.Text = "Yes";
                    choiceButton2.Text = "No";
                    break;
                case 71:
                    choiceReset();
                    sound.Play();
                    completed = true;
                    outputLabel.ForeColor = Color.White;
                    endingBox.Image = Properties.Resources.nothing;
                    outputLabel.Height = 240;
                    Thread.Sleep(2000);
                    outputLabel.Text = "Ending \"Ascension\" achieved. Play again?";
                    choiceButton1.Text = "Yes";
                    choiceButton2.Text = "No";
                    choiceButton1.Parent = endingBox;
                    choiceButton2.Parent = endingBox;
                    choiceButton1.Visible = true;
                    choiceButton2.Visible = true;
                    Refresh();
                    break;
                case 73:
                    choiceReset();
                    sound.Play();
                    outputLabel.Text = "You plant c4 on the door and step away. The explosion kills you instantly due to the small room. Play again?";
                    choiceButton1.Text = "Yes";
                    choiceButton2.Text = "No";
                    break;
            }
            if (timeUsed >= timeDeath)
            {
                choiceButton1.Visible = false;
                choiceButton2.Visible = false;
                choiceButton3.Visible = false;
                choiceButton4.Visible = false;
                endingBox.Height = (451);
                endingBox.Width = (818);
                outputLabel.Height = 390;
                outputLabel.Parent = endingBox;
                Refresh();
                endingBox.Image = Properties.Resources.static_white;
                outputLabel.ForeColor = Color.White;
                Thread.Sleep(2000);
                sound.Play();
                outputLabel.Text = "Your vision goes white and you don't have any senses. As you lose consciousness you feel disappointed";
                Refresh();
                Thread.Sleep(2000);
                outputLabel.Height = 240;
                sound.Play();
                outputLabel.Text = "Ending \"There's No Time To Explain\" Achieved. Play again?";
                choiceButton1.Text = "Yes";
                choiceButton2.Text = "No";
                page = 404;
                choiceButton1.Parent = endingBox;
                choiceButton2.Parent = endingBox;
                choiceButton1.Visible = true;
                choiceButton2.Visible = true;
                Refresh();
            }
        }

        private void choiceButton4_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.silentExploit);
            if (page == 18)
            {
                page = 22;
                intermitentPages();
            }
            switch (page)
            {
                case 23:
                    sound.Play();
                    outputLabel.Text = "You feel your self drifting off to sleep again. What do you do?";
                    choiceButton1.Text = "Resist";
                    choiceButton2.Text = "Sleep";
                    break;
            }
            if (timeUsed >= timeDeath)
            {
                choiceButton1.Visible = false;
                choiceButton2.Visible = false;
                choiceButton3.Visible = false;
                choiceButton4.Visible = false;
                endingBox.Height = (451);
                endingBox.Width = (818);
                outputLabel.Height = 390;
                outputLabel.Parent = endingBox;
                Refresh();
                endingBox.Image = Properties.Resources.static_white;
                outputLabel.ForeColor = Color.White;
                Refresh();
                Thread.Sleep(2000);
                outputLabel.Text = "Your vision goes white and you don't have any senses. As you lose consciousness you feel disappointed";
                Refresh();
                Thread.Sleep(2000);
                outputLabel.Height = 240;
                outputLabel.Text = "Ending \"There's No Time To Explain\" Achieved. Play again?";
                choiceButton1.Text = "Yes";
                choiceButton2.Text = "No";
                page = 404;
                choiceButton1.Parent = endingBox;
                choiceButton2.Parent = endingBox;
                choiceButton1.Visible = true;
                choiceButton2.Visible = true;
                Refresh();
            }
        }

        void intermitentPages()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.silentExploit);
            choiceButton1.Text = "";
            choiceButton2.Text = "";
            choiceButton3.Text = "";
            choiceButton4.Text = "";
            if (page == 2)
            {
                sound.Play();
                outputLabel.Text = "You look around and get an item that feels like a " + newInventoryItem + "?";
                Refresh();
                Thread.Sleep(2000);
                page = 3;
            }
            else if (page == 2002)
            {
                sound.Play();
                outputLabel.Text = "You look around and don't find anything.";
                Refresh();
                Thread.Sleep(2000);
                page = 3;
            }
            else if (page == 4)
            {
                sound.Play();
                outputLabel.Text = "You knock on what feels like a wall. It gives.";
                Refresh();
                Thread.Sleep(2000);
                page = 5;
            }
            else if (page == 6)
            {
                sound.Play();
                outputLabel.Text = "You look at yourself and see a sharp dressed man.";
                Refresh();
                Thread.Sleep(2000);
                page = 10;
            }
            else if (page == 7)
            {
                sound.Play();
                outputLabel.Text = "You stand there and look around for people. There is literally nothing, no people, no buildings, just a sea of trash.";
                Refresh();
                Thread.Sleep(2000);
                page = 10;
            }
            else if (page == 8)
            {
                sound.Play();
                outputLabel.Text = "You attempt to dive to the side, but you just flail on to the ground.";
                Refresh();
                Thread.Sleep(2000);
                page = 10;
            }
            if (page == 10)
            {
                sound.Play();
                outputLabel.Text = "The SUV in the distance does a sick drift and turns around towards you.";
                Refresh();
                Thread.Sleep(2000);
                page = 11;
            }
            else if (page == 12)
            {
                sound.Play();
                outputLabel.Text = "You try to outrun the SUV? Sadly the SUV is faster than you and catches up";
                Refresh();
                Thread.Sleep(2000);
                page = 13;
            }
            else if (page == 16)
            {
                sound.Play();
                outputLabel.Text = "You stand there as the van gets closer to you and slides to a stop";
                Refresh();
                Thread.Sleep(2000);
                page = 13;
            }
            if (page == 13)
            {
                sound.Play();
                outputLabel.Text = "A man in black gets out of the SUV and shoots you with a syringe. Everything fades to black";
                Refresh();
                Thread.Sleep(2000);
                page = 1;
                timeUsed = timeUsed + 3;
                escapedOnce = true;
            }
            else if (page == 17)
            {
                sound.Play();
                outputLabel.Text = "There is no response.";
                timeUsed = timeUsed + 1;
                Refresh();
                Thread.Sleep(2000);
                page = 23;
            }
            else if (page == 19)
            {
                sound.Play();
                outputLabel.Text = "Through the wall you hear \"The great sea highway, where else would we be ? \"";
                Refresh();
                Thread.Sleep(2000);
                page = 23;
            }
            else if (page == 20)
            {
                sound.Play();
                outputLabel.Text = "Through the wall you hear \"I would like to know that to.We only do deliveries\"";
                Refresh();
                Thread.Sleep(2000);
                page = 23;
            }
            else if (page == 21)
            {
                sound.Play();
                outputLabel.Text = "Through the wall you hear \"We do deliveries\"";
                Refresh();
                Thread.Sleep(2000);
                page = 23;
            }
            else if (page == 22)
            {
                sound.Play();
                outputLabel.Text = "Through the wall you hear \"These's only one place we would be going\"";
                Refresh();
                Thread.Sleep(2000);
                page = 23;
            }
            else if (page == 24)
            {
                sound.Play();
                outputLabel.Text = "You try to resist for a  what feels like half an hour, draining your energy. You drift off to sleep in dismay";
                Refresh();
                Thread.Sleep(2000);
                page = 26;
            }
            else if (page == 25)
            {
                sound.Play();
                outputLabel.Text = "You choose to accept it and drift off to sleep";
                Refresh();
                Thread.Sleep(2000);
                page = 26;
            }
            else if (page == 27)
            {
                sound.Play();
                outputLabel.Text = "You look around and see hard concrete walls and a metal door on the other side of the room";
                Refresh();
                Thread.Sleep(2000);
                page = 28;
            }
            if (page == 28)
            {
                sound.Play();
                outputLabel.Text = "You are in a metal chair, unrestrained and there is a clean wooden table in front of you.";
                Refresh();
                Thread.Sleep(2000);
                page = 29;
            }
            if (page == 29)
            {
                sound.Play();
                outputLabel.Text = "You don't have time to react but a man in a lab coat enters the room and sits down across from you";
                Refresh();
                Thread.Sleep(2000);
                page = 30;
            }
            else if (page == 31)
            {
                sound.Play();
                outputLabel.Text = "Really? You don't? It's the entire reason you're here. You've been studying this for most of your life";
                Refresh();
                Thread.Sleep(2000);
                page = 32;
            }
            if (page == 32)
            {
                sound.Play();
                outputLabel.Text = "He then mutters \"I guess the implants really got to him *sigh * he is really useless isn't he\"";
                Refresh();
                Thread.Sleep(2000);
                page = 33;  
            }
            else if (page == 34)
            {
                sound.Play();
                outputLabel.Text = "The man says \"Great, lets go then, time is of the essence\"";
                Refresh();
                Thread.Sleep(2000);
                page = 35;
            }
            else if (page == 39)
            {
                sound.Play();
                outputLabel.Text = "You pull out your firearm and shoot the man and he falls to the ground crying for help";
                Refresh();
                Thread.Sleep(2000);
                page = 40;
            }
            if (page == 40)
            {
                sound.Play();
                outputLabel.Text = "You hear cold foot steps running down the hall way  and then two heavily armoured men rush into the room and quickly knock you out, your consciousness fades";
                Refresh();
                Thread.Sleep(2000);
                timeUsed = timeUsed + 999;
            }
            else if (page == 41)
            {
                sound.Play();
                outputLabel.Text = "You follow the man out the door and down a hallway.You walk into a huge room filled with tubes all going towards an odd machine";
                Refresh();
                Thread.Sleep(2000);
                page = 42;
            }
            if (page == 42)
            {
                sound.Play();
                outputLabel.Text = "The air is buzzing with electricity and the area around the machine is filled with activity";
                Refresh();
                Thread.Sleep(2000);
                page = 43;
            }
            if (page == 43)
            {
                sound.Play();
                outputLabel.Text = "The man leads you to what looks like the front of the machine through the bustling activity of the scientists";
                Refresh();
                Thread.Sleep(2000);
                page = 44;
            }
            if (page == 44)
            {
                sound.Play();
                outputLabel.Text = "The man then says to another man \"He's here, start it up, we're running out of time\"";
                Refresh();
                Thread.Sleep(2000);
                page = 45;
            }
            if (page == 45)
            {
                sound.Play();
                outputLabel.Text = "A large ring on the machine starts spinning rapidly as other people step away, arcs of blue electricity sparking from the ring";
                Refresh();
                Thread.Sleep(2000);
                page = 46;
            }
            else if (page == 47)
            {
                sound.Play();
                outputLabel.Text = "You pull a black featureless cube out of your pocket to the dismay of others and offer it with two hands to what's in front of you";
                Refresh();
                Thread.Sleep(2000);
                page = 48;
                endingBox.Height = (451);
                endingBox.Width = (818);
                outputLabel.Height = 390;
                endingBox.Image = Properties.Resources.Glitch;
                outputLabel.Parent = endingBox;
                outputLabel.ForeColor = Color.White;
                Refresh();
            }
            if (page == 48)
            {
                sound.Play();
                outputLabel.Text = "T̶̗͝H̷̩̑Ě̸͖ ̶̹́Ĉ̶͙U̷̬͑B̷͔͒Ë̸̡ floats from your hands and into the thing";
                Refresh();
                Thread.Sleep(2000);
                page = 49;
            }
            if (page == 49)
            {
                sound.Play();
                outputLabel.Text = "The room you're in seems to corrupt as this happens but no one seems to notice except you";
                Refresh();
                Thread.Sleep(2000);
                page = 50;
            }
            if (page == 50)
            {
                sound.Play();
                outputLabel.Text = "Your vision turns to black except the electric blue arcs still in front of you";
                Refresh();
                Thread.Sleep(2000);
                page = 51;
            }
            if (page == 51)
            {
                sound.Play();
                outputLabel.Text = "W̸̢̧̧̡̢͓̰̬͔̦͖̳̣̖̳͍̥̠̖̘̺̫͉͍̩̪̘͈͔̰̙̪͔̣͖͈̞̙̮͖̲̜̭̹͔̤̼͖͓̼̤͔̝̫͇̦̝̞̺͖͔͔̘͔̤̪͓͔͇͍̿̅̇̋́̈́̑̈́͜͠ͅE̴̡̡̢̡̢̢̧̡̡̨͚̺͈̟̦̗̫̘̝̥͚̟͔̗͈̰̰͎̳̘̩͖͓̣̦͍̳̞͍̩̜̹͎̼̟͇͖̯͇̤̪̙̥̖̺͉̗̩̳̠̞̳̼̹̣̞̩̘̞̩͚̘̬̺̭̳̙͍̥͔̞̜͕͔̜̥̬̿̈̈́͑͋̀͋̀̓͆̒̐͑͋̀̔̓́̍̈́̀̄͜͠͝ͅ ̵̡̡̡̛̛̝̫̱̦̣̱͇̖̝̝̙̦̙͇̫͇͇̫̏́̓͐̍̎͂̆̐̓̄̔̄̽̃̓͆̄̋̉̈̒͒́̽̈́́̿̃̒̈́̓͐͂͋̍̉́̏͂͑̌̈́̈͐͂͛̽̂̀̒̄̅̿͒̈́̏̀̐͘̕͘̕͘͝͝͠͝ͅͅĄ̷̧̢̡̡̡̧̛̗̥͔̺̯̬̰̟̲̙̤̣̘̝͔̣̮̥̱̻̪̯͕̜̻̖̝̙̤͚̘̝͕̪̝̲̳̱̞̬͔̞͕̮̖̤̼͎̗̬͕͖̦̄̒́̽̂̋̋͐̉̂̌̉̓͆̄̎̐̂̈́̓͒̑͊͌͆̀͐̈̿̅̿̎̊̃̅̓̃̏̏̇̎̎̃̆̈́͂̋̓͒̏̋̚̕͘͜͝͠͠Ḉ̷͚͕̮̥̪͎̟͎̺̙̹̝͎͚̤̪̩̰̠̺̟̭̹͓̹͎̘̩͕̐́̍̇̉̎̓̆̽̀̄͒͐̏̓̊̊̇̔̇͗̾̆̓̍͐̈́̐̏̓̕̕͝͝͝ͅĊ̷̢̨̡̼̦̯͓͍̙͇͍̤͔̣̣̤͈̝͈̭͚͈̤̘̠͉̩̞̗̩̰͚̬̭̟̟͇̭͇͉͓̼͚͕̹̝̹̞̟̼̬͉̦͈͓̰̱̖̝̞̪̖̞̫̬̳̤͔͔͒͜ͅͅͅE̶̢̨̛̛͚͉͈̖̠͍͖̲̟̼̲̗̬̯͉͓͎͒̑̊̊̂̈̇̇͊͊̃̾̆̂̅̍̐͋̉̽̏̊̀́̈́̇̑͊̄͐͌̈́͐͌̚̕̚͘͠͝͠͠P̸̧̨̢̛͉̣̺̻̗͇͔̤̥͎̗̝͖̙̘̜̺̺̻̬̥̗̫̮͉͓̤̟͈̤̥͔̲̼̫͔̻͙̟͔͉̘̗̟̥̩̣̳̭̅͒̐̇͊̽̾̊̋͒̆̌͆̽͒́̋̃̌͆͆̏͂̃̓̽̀̔̀̀̑͊͗̂̊͆͛̅̾̈́̍͗̓͐͗̓̏͒̏͆́̂̔̄̂̈́͋͆̌̓̀̀̃͑̀̊̀̃̊̇̀͆̽͋̀͌̓́̈̽̒̚̕̕̕̕͜͠͝͝͝͠͝ͅͅͅŢ̶̡̡̡̢̧̡̨̧̛̛̰̥̙̺͓̤͉͈̹͖̼̫̞̦̦͇̣̫̝͔̯͓͓̝̫̘̤̯̣̱̟̲̠͚̱̖̖͖͙̣̙̜͓̲̩̣͕̟̖̣͙̯̜̳̫̬̭͎̻̯͖͉̞̤̟̮̖̠̾̈́̇͒̐͌̊̒͛͋̓͑͗̌̌̌̽̇̅͗͌͐̑́͂͗͐̾̾̍͌̽͑͗͌̂͒̽͊̽̉̈̈͆̑̔̍̀̑͗̑̉̉̀͋͗̊͋̀̽̿̔̋̐͂̄͌͌̑́̂̀̉̌͑̄̅́̈̅̊͂̉͌̍̉̽̅̕̚̕̕̚͜͜͝͝͝͝ͅͅͅ ̵̢͖̟̻͚̥̗̟̞͕͍̘̥͖̮̯̜̤͕̽͒̌̒̒̒̃̊̈́̔͗͒̑̋̂͊̃̔̐́͋͂̓̈̅̀̈͊̓̑̉͆̏̍̐̒̀̚̚͘͘͝͠͝͠͝͝T̵̢̡̧̛̛̹͓̘͎̼͍̰̘̣̞̘̼͉͈̼͕̲̱̯͙̙̠̙̤͉̰̩̬̫͚̰̘̗̫̥̺̺̣̖̤͈̦̻̩͖͓̳̫̣͗̈̉͒̈͌̽̆̈́͐͐̓͑͋͆̆̓̍̋͊̊̒͋̈́̀̀́̄̿͂̐͋̈́̌̂̊̌͂͒̅̍̎̓͌̂̏͝ͅͅͅḦ̶̡̧̢̧̛̛̜̭̣̰͕̜̳̠̙͎̞̟̬̘̩̭̝̙̮͈̩̪̟͇͎͓̻̟͕̣͍̣̟̙̘̙̘͕̟̘̠͔̗̬̟̹͖͉̲̰͓̤̣̺̭̳͉̻̺͕̠͖̫̙͕͗̐̐̄̀̇̿̑̋̑̅̀̉̈͋̒͛̉͋͆̈͒̏̄͂̈́̏̓̀̿̑̈́̚̚͘͜ͅͅĮ̴̨̧̧̧̡̛̖̰͇̩͚̭̣̪͚̬̫̞̮͇̖̣̫͖̞̪̳̙̣̝̗̗̗̝̟͍͈̣́͐͗̂́̋͊̆́̌̈͛̈̀̾̌̽̏́͆̍͒̅͐̈̌̑͐͋̓͛̄̋̈́̾͘̚̚͠͝͠͠͝ͅͅŚ̷̡̡̡̧̢̢̛̞̰̖̼̼̠̟̭̻̳̼̫̱̭̺͚̭̜̬̪̫̻̞͚̱̲̺̥͚̪̣̦͉̫̼͚̠̯͍͙̱͈̳̳͇̣̗̠̳̺̱͙̮̽͒̀̇͗̚ͅͅ ̶̢̛̜̞͎͍͔̟̦͍̙͆̆̌̑̇̂͌́̒̀̔̎̒͗̈́̿̄̈́͑̏̒̋̑̏̋͒̑̏͑͑́̎͆̀̒̉̔̀́͛̐̍͊́̂̇̓̒͌̈͆̂̏̀̄͐͐̈́̾̈̈́́̂̄̄͗̑̊̎͂̾͋͌̽̒̑̋̀͆͐̿̓̽͂̈̕̚̚͘̕̚͘̚͠͠͠͝͠͝Ȍ̵̧̨̧̢̡̢̥͔͖͇̫͍͈̟̣͇͓̹̗͓̜͍̮̼̙͈͇̜͙̣̬͈͎̗͙͖͓͚̼͎̤̙̻͎͙͉͒̈́̉̅͑̈̐̀̍͂͐͑̌́͐͒̒͒͆͛̎̇͂͂̈̾̓̅̐͐̐̿̓̽͋͂̾͊͗̈͠F̸̧̨̢̡̢̛̹̻̖͙̻͕̠̥̺̰̯̟̰͓͍̪͓̞̥̹̺̦̞͈̟̘͌̐̐̐̎͊͌̎͛̉̽̌̈́̈́̽̈́̋̀̍̿̈́͐͒͗͘͜͝͠F̸̡̡̧̧̧̡̡̧̡̛̛͔͚̜̻̞̥̲̗̯̝͍̣͕͚̩̯̭̩͇̞͍̩̼͚̤̭͖͇̹͖͓̤̖͙̫̼̮̯̰̬̹̰̫̩̱̱͕͎̘͎̘̥̣̩̰̜̫̻̠͇͓͈̼̝̽͋͋͆̏͗̓̄́̇̉́̃̉̄͊͂̍͗̐̔̄̏́͂̌̆̈́͋́̈͊̈͒́̇̈́̑͌̕̕̕͜͜͜͝͝ͅĘ̶̨̨̢̡̢̡̢̡̛̛̼̮̙͉̳͉̮͎̼͉͍͍̞̟̳̟̹͉̬̞̱͎̰͚̙͍̬͓̘̭̮͎̰̺͖̩̝͎̣̪̝̙͙̘̗͙̩̪̭̖̳͖͙̠͕͇̙͉̩̦̩̼͎̩̬̦͎̫̟͕̩͍́̓̀̓͋̈́̀̾̓́̆̅̃̀͗̒̋̄̀͆͒̂̅̉́̈́́̈͛̓̉̏̿͋͊̍̈́͐̌́̃̽̊͗̒͂͆͋̉̈́̈́́͂̽̅͐̍̎͆̒͆̆̅́͐͗͛͘͘̕̕͜͜͝͠͝͝͝͝ͅͅŘ̸̡̧̧̡̛̛̛̛̻̥̻̭̣̖̭͙͍̖̝̟̮̯̱͎͙͕͎͈̣͈͔̰̯͈̼̲̪̠̤̰̹̝̘̼̩͇͕̹̣̳̯̠͉̳̖̯̱̤̺̹̟̼̝̻̲͓̺̝̬̝̮͔̩͉̼͖͍̹̞͇̙̼̬̝̗̰̻͔̰̝̳͎̯̍̉̾̄̊̌͋͒̐̈́̈́̿̑͌̍͂͛̒͒̏̾̈̋̏̇̈́̈̾́͑͋͑̍͑̒̐͆́͑͊̓̿̾́̎̋̅̊̉͗̊́́̀͌̎̾͒̒̽̋̍̔̉̓̕͘͘͝͝͝͠ͅͅͅǏ̶̡̢̡̢̢̨̨̨̡̡̨̢̛̮͙͓̭̩͈̭͖͚̭̳͔̹̰̼͎̗̱̠̯͔̼̖̻̦̹͚̖̼̮̩̝̥̼̮̳̤̺͇͔͖̘̻̱͖̦̖̺͇͚͇̻̠̬̝̝̠̖̯͙̱͙̜̠̩̯͉̳̭͓̩̞͓̯̮̾̓̓̀͊̐͛̒̏̆̋̾̆̓̓̎͋̈́̚̚͜͠N̵̡̨͇̟͍̭̲̘͓̦͎̱̰͕͔̖͕̜̮̰͍̰̤͔͔̞̪̥̞̗͙̤͇͎̖̣͓̙͖̦̪̯̠̣̲̤̼̥͖̰̖̼̣̜̱̟͕̟̹̣̖̗̮̼͉̞̻̥̹͈̺̫͙̱̝̲̠̱͍̒͛̀̊̌͗̀̆̓̾̽̐̀͑̈͑̾̎̆͒̌̈́̄̎̈́̔̔͛́̀̍̂̏͆̄͊̊̏͗̋̊̽̂̓̐̉̈́̏̒͐͆̂̚̕͘͘͜͠͠ͅG̸̢̧̡̢̛̝̼̟̮̥̼̮̳͉̯̼̼͕̦̳̩̣͈̜̘̘̗̤͉͎̟̱͖͔͇̹̙͎͉̟͔͕͍͓͙̞̝̙͍͋͛͊̾͂̀̈́͌͒͆͗́̈́͌̓̎̈́͗̽͂̇͗͌̈́̀͗̍̈́͑̈́̎̔͋͋͐̈́́̌͘̚͜͜͜͜͜͠͝͝ͅ";
                Refresh();
                Thread.Sleep(2000);
                page = 52;
            }
            else if (page == 54)
            {
                sound.Play();
                outputLabel.Text = "You look at the thing closer and it's colorless, light seems to be absorbed by it. This contrasts with the galexy blue and twinkling stars that are its backdrop";
                Refresh();
                Thread.Sleep(2000);
                page = 55;
            }
            else if (page == 56)
            {
                sound.Play();
                outputLabel.Text = "You wait for more to happen to get a bigger picture";
                Refresh();
                Thread.Sleep(2000);
                page = 57;
            }
            else if (page == 59)
            {
                sound.Play();
                outputLabel.Text = "You tiredly go in to grapple with it like a man would";
                Refresh();
                Thread.Sleep(2000);
                page = 60;
            }
            if (page == 60)
            {
                sound.Play();
                outputLabel.Text = "When you go to touch it you feel it start to absorb you, shivering as it does so.";
                Refresh();
                Thread.Sleep(2000);
                page = 61;
            }
            if (page == 60)
            {
                sound.Play();
                outputLabel.Text = "When you go to touch it you feel it start to absorb you, shivering as it does so.";
                Refresh();
                Thread.Sleep(2000);
                page = 61;
            }
            if (page == 61)
            {
                sound.Play();
                outputLabel.Text = "You yell and scream but no one reacts as you body is pulled through.";
                Refresh();
                Thread.Sleep(2000);
                page = 62;
            }
            else if (page == 63)
            {
                sound.Play();
                choiceButton1.Visible = false;
                choiceButton2.Visible = false;
                choiceButton3.Visible = false;
                choiceButton4.Visible = false;
                endingBox.Height = (451);
                endingBox.Width = (818);
                endingBox.Image = Properties.Resources.white;
                outputLabel.Parent = endingBox;
                outputLabel.Text = "You yell for some one to deal with the thing as you now remember what I̴̡͓̩͛͘͠T̵̢͚̪͆̀̕ is";
                Refresh();
                Thread.Sleep(2000);
                page = 64;
            }
            if (page == 64)
            {
                sound.Play();
                outputLabel.Text = "A team of armoured men rush towards the portal, pushing people out of their way";
                Refresh();
                Thread.Sleep(2000);
                page = 65;
            }
            if (page == 65)
            {
                sound.Play();
                outputLabel.Text = "They quickly set up some sort of complex launcher system and them one of the men signals";
                Refresh();
                Thread.Sleep(2000);
                page = 66;
            }
            if (page == 66)
            {
                sound.Play();
                outputLabel.Text = "A blinding flash of white and neon purple assails your eyes and you can't hear anything";
                Refresh();
                Thread.Sleep(2000);
                page = 67;
            }
            if (page == 67)
            {
                sound.Play();
                outputLabel.Text = "As your vision comes back you don't see the thing in the portal any more. You're instantly relieved and everyone else seems the same way";
                Refresh();
                Thread.Sleep(2000);
                page = 68;
            }
            if (page == 68)
            {
                sound.Play();
                outputLabel.Text = "You feel like your soul is being sucked out of your body and you can see yourself from a 3rd person view";
                Refresh();
                Thread.Sleep(2000);
                page = 69;
            }
            if (page == 69)
            {
                sound.Play();
                outputLabel.Text = "\"Your\" body starts to celebrate with the other people seeming to have a mind of its own";
                Refresh();
                Thread.Sleep(2000);
                page = 70;
            }
            if (page == 70)
            {
                sound.Play();
                outputLabel.Text = "You feel like your work is done here. Your vision turns to nothing";
                Refresh();
                Thread.Sleep(2000);
                page = 71;
            }
            else if (page == 74)
            {
                sound.Play();
                outputLabel.Text = "You go to the vent which seems to be dislodged and crawl in";
                Refresh();
                Thread.Sleep(2000);
                page = 75;
            }
            if (page == 75)
            {
                sound.Play();
                outputLabel.Text = "As you crawl away you hear someone enter the room behind you and they sound surprised";
                Refresh();
                Thread.Sleep(2000);
                page = 76;
            }
            if (page == 76)
            {
                sound.Play();
                outputLabel.Text = "You continue to crawl through the vents until you see some sort of light out of another vent";
                Refresh();
                Thread.Sleep(2000);
                page = 77;
            }
            else if (page == 78)
            {
                sound.Play();
                outputLabel.Text = "You go up to the door and start to bang on it";
                Refresh();
                Thread.Sleep(2000);
                page = 79;
            }
            if (page == 79)
            {
                sound.Play();
                outputLabel.Text = "Someone tries to open the door but you're still banging on the door";
                Refresh();
                Thread.Sleep(2000);
                page = 80;
            }
            if (page == 80)
            {
                sound.Play();
                outputLabel.Text = "You hear someone call for back up and then you are pushed to the ground by the door as two armoured men rush in";
                Refresh();
                Thread.Sleep(2000);
                page = 81;
            }
        }
        void choiceReset()
        {
            choiceButton1.Text = "";
            choiceButton2.Text = "";
            choiceButton3.Text = "";
            choiceButton4.Text = "";
        }
    }

}
