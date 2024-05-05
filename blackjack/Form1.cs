using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace blackjack
{
    public partial class Tela : Form
    {
        private string GetImagePath(string imageName)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string projectRoot = Directory.GetParent(currentDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectRoot, "images", imageName);
            return imagePath;
        }
        private void cardDef(int value, PictureBox pictureBox)
        {
            switch (value)
            {
                
                case 1:
                    pictureBox.Image = Image.FromFile(GetImagePath("ace of spades.png"));
                    break;
                case 2:
                    pictureBox.Image = Image.FromFile(GetImagePath("2 of spades.png"));
                    break;
                case 3:
                    pictureBox.Image = Image.FromFile(GetImagePath("3 of spades.png"));
                    break;
                case 4:
                    pictureBox.Image = Image.FromFile(GetImagePath("4 of spades.png"));
                    break;
                case 5:
                    pictureBox.Image = Image.FromFile(GetImagePath("5 of spades.png"));
                    break;
                case 6:
                    pictureBox.Image = Image.FromFile(GetImagePath("6 of spades.png"));
                    break;
                case 7:
                    pictureBox.Image = Image.FromFile(GetImagePath("7 of spades.png"));
                    break;
                case 8:
                    pictureBox.Image = Image.FromFile(GetImagePath("8 of spades.png"));
                    break;
                case 9:
                    pictureBox.Image = Image.FromFile(GetImagePath("9 of spades.png"));
                    break;
                case 10:
                    pictureBox.Image = Image.FromFile(GetImagePath("10 of spades.png"));
                    break;
                case 11:
                    pictureBox.Image = Image.FromFile(GetImagePath("ace of spades.png"));
                    break;
                    
            }
        }
        int[] cartas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        int score;
        int scoreEnemy;
        Random random = new Random();
        public Tela()
        {
            InitializeComponent();
        }

        private void Tela_Load(object sender, EventArgs e)
        {
            pbDeck1.BringToFront();
            pbDeck2.SendToBack();
            pbDeck3.SendToBack();
            int cartaini = cartas[random.Next(0, cartas.Length)];
            pbCard2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
            lblScoreE.Text = "Score: "; 
            lblScore.Text = "Score: ";
            cardDef(cartaini, pbCard);
            score = score + cartaini;
            lblScore.Text = score.ToString();

            int cartaini2 = cartas[random.Next(0, cartas.Length)];

            if (score + cartaini2 > 21)
            {
                cartaini2 = 1;
            }
            
            cardDef(cartaini2, pbCard2);
            score = score + cartaini2;
            if (score == 21)
            {
                MessageBox.Show("Você ganhou!");
                Application.Exit();
            } else
            {

            }
            lblScore.Text = score.ToString();
        }

        public void hit()
        {
            pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
            int x = pnlCardsPl.Controls.Count * 80;
            int y = 48;
            int carta = cartas[random.Next(0, cartas.Length)];
            if (carta == 11 && score + carta > 21)
            {
                carta = 11;
            }
            PictureBox pbNewCard = new PictureBox();
            pbNewCard.Location = new Point(x, y);
            pbNewCard.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNewCard.Width = 69;
            pbNewCard.Height = 105;

            cardDef(carta, pbNewCard);

            score += carta;
            lblScore.Text = "Pontuação:" + score.ToString();
            pnlCardsPl.Controls.Add(pbNewCard);
            
            if (score > 21)               
            {
                MessageBox.Show("Você perdeu!");
                Application.Exit();
            }
        }
        public void enemyturn()
        {
            int cartaE = cartas[random.Next(0, cartas.Length)];
            pbCard3.SizeMode = PictureBoxSizeMode.StretchImage;
            if (score > 10 && cartaE == 1)
            {
                cartaE = 11;
            }   
            cardDef(cartaE, pbCard3);
            scoreEnemy += cartaE;
            lblScoreE.Text = "Pontuação:" + scoreEnemy.ToString();
            MessageBox.Show("Pontuação do inimigo: " + scoreEnemy);
            int cartaE2 = cartas[random.Next(0, cartas.Length)];
            pbCard4.SizeMode = PictureBoxSizeMode.StretchImage;
            if (score > 10 && cartaE2 == 1)
            {
                cartaE2 = 11;
            }
            cardDef(cartaE2, pbCard4);
            scoreEnemy += cartaE2;
            lblScoreE.Text = "Pontuação:" + scoreEnemy.ToString();
            MessageBox.Show("Pontuação do inimigo: " + scoreEnemy);
            int x = pnlCardsE.Controls.Count * 80;
            int y = 3;
            int cartaE3 = cartas[random.Next(0, cartas.Length)];
            if (score > 10 && cartaE3 == 1)
            {
                cartaE3 = 11;
            }

            PictureBox pbNewCardE = new PictureBox();
            pbNewCardE.Image = Image.FromFile(GetImagePath("back.png"));
            pbNewCardE.Location = new Point(x, y);
            pbNewCardE.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNewCardE.Width = 69;
            pbNewCardE.Height = 105;
            pnlCardsE.Controls.Add(pbNewCardE); 
            
            cardDef(cartaE3, pbNewCardE);
            scoreEnemy += cartaE3;
            lblScoreE.Text = "Pontuação:" + scoreEnemy.ToString();
            if (scoreEnemy < 21 && scoreEnemy > score)
            { 
                MessageBox.Show("Você perdeu!");
                Application.Exit();
            }
            else if (scoreEnemy == 21)
            {
                MessageBox.Show("Você perdeu!");
                Application.Exit();
            }
            else if (scoreEnemy > 21)
            {
                MessageBox.Show("Você ganhou!");
                Application.Exit();
            }   
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
            while (scoreEnemy < 21 && scoreEnemy < score)
            {
                enemyturn();
            }
            if (scoreEnemy == 21)
            {
                MessageBox.Show("Você perdeu!");
                Application.Exit();
            }
            else if (scoreEnemy > 21)
            {
                MessageBox.Show("Você ganhou!");
                Application.Exit();
            }
            else if (scoreEnemy > score)
            {
                MessageBox.Show("Você perdeu!");
                Application.Exit();
            } else if (scoreEnemy == score)
            {
                MessageBox.Show("Empate!");
                Application.Exit();
            }
        }

        private void pbCard_Click(object sender, EventArgs e)
        {

        }
    }
}
