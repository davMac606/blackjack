﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace blackjack
{
    public partial class Tela : Form
    {
        private void enemyCardDef(int value, PictureBox pictureBox)
        {
            switch (value)
            {
                case 1:
                    pictureBox.Image = Image.FromFile(imgpath + "ace of spades.png");
                    break;
                case 2:
                    pictureBox.Image = Image.FromFile(imgpath + "2 of spades.png");
                    break;
                case 3:
                    pictureBox.Image = Image.FromFile(imgpath + "3 of spades.png");
                    break;
                case 4:
                    pictureBox.Image = Image.FromFile(imgpath + "4 of spades.png");
                    break;
                case 5:
                    pictureBox.Image = Image.FromFile(imgpath + "5 of spades.png");
                    break;
                case 6:
                    pictureBox.Image = Image.FromFile(imgpath + "6 of spades.png");
                    break;
                case 7:
                    pictureBox.Image = Image.FromFile(imgpath + "7 of spades.png");
                    break;
                case 8:
                    pictureBox.Image = Image.FromFile(imgpath + "8 of spades.png");
                    break;
                case 9:
                    pictureBox.Image = Image.FromFile(imgpath + "9 of spades.png");
                    break;
                case 10:
                    pictureBox.Image = Image.FromFile(imgpath + "10 of spades.png");
                    break;
                case 11:
                    pictureBox.Image = Image.FromFile(imgpath + "ace of spades.png");
                    break;
            }
        }
        private void cardDef(int value, PictureBox pictureBox)
        {
            switch (value)
            {
                case 1:
                    pictureBox.Image = Image.FromFile(imgpath + "ace of spades.png");
                    break;
                case 2:
                    pictureBox.Image = Image.FromFile(imgpath + "2 of spades.png");
                    break;
                case 3:
                    pictureBox.Image = Image.FromFile(imgpath + "3 of spades.png");
                    break;
                case 4:
                    pictureBox.Image = Image.FromFile(imgpath + "4 of spades.png");
                    break;
                case 5:
                    pictureBox.Image = Image.FromFile(imgpath + "5 of spades.png");
                    break;
                case 6:
                    pictureBox.Image = Image.FromFile(imgpath + "6 of spades.png");
                    break;
                case 7:
                    pictureBox.Image = Image.FromFile(imgpath + "7 of spades.png");
                    break;
                case 8:
                    pictureBox.Image = Image.FromFile(imgpath + "8 of spades.png");
                    break;
                case 9:
                    pictureBox.Image = Image.FromFile(imgpath + "9 of spades.png");
                    break;
                case 10:
                    pictureBox.Image = Image.FromFile(imgpath + "10 of spades.png");
                    break;
                case 11:
                    pictureBox.Image = Image.FromFile(imgpath + "ace of spades.png");
                    break;
                    
            }
        }
        int[] cartas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int score;
        int scoreEnemy;
        int upperCards;
        int lowerCards;
        string imgpath = "C:/Users/User/source/repos/blackjack/blackjack/images/";
        Random random = new Random();
        public Tela()
        {
            InitializeComponent();
        }

        private void Tela_Load(object sender, EventArgs e)
        {
          
            int cartaini = cartas[random.Next(0, cartas.Length)];
            pbCard2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
            if ( score > 10 && cartaini == 1)
            {
                cartaini = 11;
            }
            cardDef(cartaini, pbCard);
            score = score + cartaini;
            lblScore.Text = score.ToString();
            int cartaini2 = cartas[random.Next(0, cartas.Length)];
            if (score >=10 && cartaini2 == 1)
            {
                cartaini2 = 11;
            }
            cardDef(cartaini2, pbCard2);
            score = score + cartaini2;
            lblScore.Text = score.ToString();
        }
        public void hit()
        {
            pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
            foreach (Control card in pnlCards.Controls)
            {
                if (card.Location.Y == 360)
                {
                    upperCards++;
                }
                else
                {
                    lowerCards++;
                }
            }
            int x = upperCards * 80;
            int y = 360;
            int carta = cartas[random.Next(0, cartas.Length)];
            if (score > 10 && carta == 1)
            {
                carta = 11;
            }

            PictureBox pbNewCard = new PictureBox();
            pbNewCard.Location = new Point(x, y);
            pbNewCard.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNewCard.Width = 69;
            pbNewCard.Height = 105;

            cardDef(carta, pbNewCard);

            score = score + carta;
            lblScore.Text = "Pontuação:" + score.ToString();
            pnlCards.Controls.Add(pbNewCard);
            
            if (score > 21)               
            {
                MessageBox.Show("Você perdeu!");
                Application.Exit();
            }
        }
        public int enemyStartingCards()
        {
            int cartaE = cartas[random.Next(0, cartas.Length)];
            pbCard3.SizeMode = PictureBoxSizeMode.StretchImage;
            if (score > 10 && cartaE == 1)
            {
                cartaE = 11;
            }
            enemyCardDef(cartaE, pbCard3);
            scoreEnemy += cartaE;
            int cartaE2 = cartas[random.Next(0, cartas.Length)];
            pbCard4.SizeMode = PictureBoxSizeMode.StretchImage;
            if (score > 10 && cartaE2 == 1)
            {
                cartaE2 = 11;
            }
            enemyCardDef(cartaE2, pbCard4);
            scoreEnemy += cartaE2;
            return scoreEnemy;
        }
        public void enemyturn()
        {
            enemyStartingCards();
            foreach (Control card in pnlCards.Controls)
            {
                if (card.Location.Y == 360)
                {
                    upperCards++;
                } else
                {
                    lowerCards++;
                }
            }
            int x = upperCards * 80;
            int y = 0;
            int cartaE3 = cartas[random.Next(0, cartas.Length)];
            if (score > 10 && cartaE3 == 1)
            {
                cartaE3 = 11;
            }
            PictureBox pbNewCardE = new PictureBox();
            pbNewCardE.Location = new Point(x, y);
            pbNewCardE.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNewCardE.Width = 69;
            pbNewCardE.Height = 105;

            
            enemyCardDef(cartaE3, pbNewCardE);
            scoreEnemy += cartaE3;
            lblScoreE.Text = "Pontuação:" + scoreEnemy.ToString();

        }
        private void btnHit_Click(object sender, EventArgs e)
        {
            hit();
            if (score == 21)
            {
                MessageBox.Show("Você ganhou!");
                Application.Exit();
            } else if (score > 21){
                MessageBox.Show("Você perdeu!");
                Application.Exit();
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            enemyturn();
            while (scoreEnemy < 21)
            {
                int choice = random.Next(0, 2);
                if (choice == 1)
                {
                    enemyturn();
                }
            }
            if (scoreEnemy > score && scoreEnemy <= 21)
            {
                MessageBox.Show("Você perdeu!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Você ganhou!");
                Application.Exit();
            }   
            
        }

        private void pbCard_Click(object sender, EventArgs e)
        {

        }
    }
}