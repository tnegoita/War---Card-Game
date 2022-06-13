using ProicetIP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectIP
{

    public partial class Form1 : Form
    {
        List<Card> deck = new List<Card>()
        {
            new Card() { _value  = 2, _name = "2C" },
            new Card() { _value  = 2, _name = "2H" },
            new Card() { _value  = 2, _name = "2D" },
            new Card() { _value  = 2, _name = "2S" },
            new Card() { _value  = 3, _name = "3C" },
            new Card() { _value  = 3, _name = "3H" },
            new Card() { _value  = 3, _name = "3D" },
            new Card() { _value  = 3, _name = "3S" },
            new Card() { _value  = 4, _name = "4C" },
            new Card() { _value  = 4, _name = "4H" },
            new Card() { _value  = 4, _name = "4D" },
            new Card() { _value  = 4, _name = "4S" },
            new Card() { _value  = 5, _name = "5C" },
            new Card() { _value  = 5, _name = "5H" },
            new Card() { _value  = 5, _name = "5D" },
            new Card() { _value  = 5, _name = "5S" },
            new Card() { _value  = 6, _name = "6C" },
            new Card() { _value  = 6, _name = "6H" },
            new Card() { _value  = 6, _name = "6D" },
            new Card() { _value  = 6, _name = "6S" },
            new Card() { _value  = 7, _name = "7C" },
            new Card() { _value  = 7, _name = "7H" },
            new Card() { _value  = 7, _name = "7D" },
            new Card() { _value  = 7, _name = "7S" },
            new Card() { _value  = 8, _name = "8C" },
            new Card() { _value  = 8, _name = "8H" },
            new Card() { _value  = 8, _name = "8D" },
            new Card() { _value  = 8, _name = "8S" },
            new Card() { _value  = 9, _name = "9C" },
            new Card() { _value  = 9, _name = "9H" },
            new Card() { _value  = 9, _name = "9D" },
            new Card() { _value  = 9, _name = "9S" },
            new Card() { _value  = 10, _name = "10C" },
            new Card() { _value  = 10, _name = "10H" },
            new Card() { _value  = 10, _name = "10D" },
            new Card() { _value  = 10, _name = "10S" },
            new Card() { _value  = 11, _name = "JC" },
            new Card() { _value  = 11, _name = "JH" },
            new Card() { _value  = 11, _name = "JD" },
            new Card() { _value  = 11, _name = "JS" },
            new Card() { _value  = 12, _name = "QC" },
            new Card() { _value  = 12, _name = "QH" },
            new Card() { _value  = 12, _name = "QD" },
            new Card() { _value  = 12, _name = "QS" },
            new Card() { _value  = 13, _name = "KC" },
            new Card() { _value  = 13, _name = "KH" },
            new Card() { _value  = 13, _name = "KD" },
            new Card() { _value  = 13, _name = "KS" },
            new Card() { _value  = 14, _name = "AC" },
            new Card() { _value  = 14, _name = "AH" },
            new Card() { _value  = 14, _name = "AD" },
            new Card() { _value  = 14, _name = "AS" }
        };
        List<Card> computerDeck = new List<Card>();
        List<Card> playerDeck = new List<Card>();
        List<Card> auxDeck = new List<Card>();
        Random random = new Random((int)DateTime.Now.Ticks);
        
        public Form1()
        {
            InitializeComponent();
            Shuffle<Card>(deck);
            playerDeck.AddRange(deck.GetRange(0, 3));
            computerDeck.AddRange(deck.GetRange(25, 3));
            DisplayCardBack(playerDeckPictureBox);
            DisplayCardBack(computerDeckPictureBox);
            

        }


        
        private void startButton_Click(object sender, EventArgs e)
        {


            //Folosim doua obiecte de tip card pentru a stoca in ele prima carte din fiecare pachet
            Card playerCard = playerDeck[0];
            playerDeck.RemoveAt(0);
            Card computerCard = computerDeck[0];
            computerDeck.RemoveAt(0);
            DisplayCard(playerCardPictureBox, playerCard);
            DisplayCard(computerCardPictureBox, computerCard);
            /*Verificam daca mai sunt carti in ambele pachete si in caz ca nu mai sunt stergem cardback-urile.
              In caz ca jucatorul care ramane fara carti castiga runda, cardback-ul va reaparea.*/

            if (playerDeck.Count == 0)
            {
                ClearPicture(playerDeckPictureBox);
            }
            if (computerDeck.Count == 0)
            {
                ClearPicture(computerDeckPictureBox);
            }
            if (playerDeck.Count > 0)
            {
                DisplayCardBack(playerDeckPictureBox);
            }
            if (computerDeck.Count > 0)
            {
                DisplayCardBack(computerDeckPictureBox);
            }
            //Verificam care din cele doua carti este mai mare pentru
            if (playerCard._value > computerCard._value && computerDeck.Count == 0)
            {
                MessageBox.Show("ai castigat");
            }
            if (playerCard._value < computerCard._value && playerDeck.Count == 0)
            {
                MessageBox.Show("ai pierdut");
            }
            if (playerCard._value > computerCard._value && computerDeck.Count != 0)
            {
                playerDeck.Add(computerCard);
                playerDeck.Add(playerCard);

            }
            else
            {
                if (playerCard._value < computerCard._value && playerDeck.Count != 0)
                {
                    computerDeck.Add(computerCard);
                    computerDeck.Add(playerCard);

                }
                else
                {
                    if (playerCard._value == computerCard._value)
                    //
                    {
                        auxDeck.Add(playerDeck[0]);
                        auxDeck.Add(computerDeck[0]);
                        playerDeck.RemoveAt(0);
                        computerDeck.RemoveAt(0);
                        auxDeck.Add(playerDeck[0]);
                        auxDeck.Add(computerDeck[0]);
                        playerDeck.RemoveAt(0);
                        computerDeck.RemoveAt(0);

                        if (playerDeck[0]._value < computerDeck[0]._value)
                        {

                            computerDeck.AddRange(auxDeck);
                            computerDeck.Add(computerDeck[0]);
                            computerDeck.Add(playerDeck[0]);
                            computerDeck.Add(computerCard);
                            computerDeck.Add(playerCard);
                        }
                        else
                            if (playerDeck[0]._value >= computerDeck[0]._value)
                        {
                            playerDeck.AddRange(auxDeck);
                            playerDeck.Add(computerDeck[0]);
                            playerDeck.Add(playerDeck[0]);
                            playerDeck.Add(computerCard);
                            playerDeck.Add(playerCard);
                        }
                        auxDeck.Clear();
                    }
                }


            }
        }






        private void resetButton_Click(object sender, EventArgs e)
        {
            DisplayCardBack(computerDeckPictureBox);
            DisplayCardBack(playerDeckPictureBox);
            playerDeck.Clear();
            computerDeck.Clear();
        }
       
        private void DisplayCardBack(PictureBox pictureBox)
        {
            pictureBox.ImageLocation = "Resources/b1fv.png";
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }
        private void DisplayCard(PictureBox pictureBox, Card card)
        {
            pictureBox.ImageLocation = "Resources/" + card._name + ".png";
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }
        private void ClearPicture(PictureBox pictureBox)
        {
            pictureBox.ImageLocation = null;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }
        private int SelectRandomCard()
        {
            int randomCard;
            int randomCard2;
            randomCard = random.Next(0, playerDeck.Count);
            randomCard2 = random.Next(0, computerDeck.Count);
            return randomCard;
        }
        

        public void Shuffle<Card>(List<Card> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card _value = list[k];
                list[k] = list[n];
                list[n] = _value;
            }
        }

        private void TakeCards_Click(object sender, EventArgs e)
        {
            ClearPicture(playerCardPictureBox);
            ClearPicture(computerCardPictureBox);
        }

        private void computerDeckPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ajutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\tnego\\Downloads\\Proiect final IP\\Proiect final IP\\ProiectIP\\Help\\Manual de utilizare.chm");
        }

        private void computerCardPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void playerCardPictureBox_Click(object sender, EventArgs e)
        {

        }
    }

        
}
