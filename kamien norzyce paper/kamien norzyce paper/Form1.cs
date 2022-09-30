using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kamien_norzyce_paper
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        string winner = "";
        string[] arr = { "rock.jpg", "scissors.jpg", "paper.jpg" };
        int p1wins = 0;
        int p2wins = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void restart(object sender, EventArgs e)
        {
            int rand1 = random.Next(1, 3);
            int rand2 = random.Next(1, 3);
            switch (rand1)
            {
                case 1:
                    label1.Text = "Rock";
                    pictureBox1.Image = Image.FromFile("rock.jpg");
                    break;
                case 2:
                    label1.Text = "Scissors";
                    pictureBox1.Image = Image.FromFile("scissors.jpg");
                    break;
                case 3:
                    label1.Text = "Paper";
                    pictureBox1.Image = Image.FromFile("paper.jpg");
                    break;
                default:
                    break;
            }

            switch (rand2)
            {
                case 1:
                    label2.Text = "Rock";
                    pictureBox2.Image = Image.FromFile("rock.jpg");
                    break;
                case 2:
                    label2.Text = "Scissors";
                    pictureBox2.Image = Image.FromFile("scissors.jpg");
                    break;
                case 3:
                    label2.Text = "Paper";
                    pictureBox2.Image = Image.FromFile("paper.jpg");
                    break;
                default:
                    break;
            }
            label3.Text = Check(rand1, rand2);
            label6.Text = p1wins.ToString();
            label7.Text = p2wins.ToString();
        }

        private string Check(int p1,int p2)
        {
            if (arr[p1] == arr[p2])
                winner = "Draw!";
            else if (arr[p1] == "rock.jpg" && arr[p2] == "scissors.jpg" ||
                arr[p1] == "scissors.jpg" && arr[p2] == "paper.jpg" ||
                arr[p1] == "paper.jpg" && arr[p2] == "rock.jpg"
                ) winner = "Player 1 won!";
            else
                winner = "Player 2 won!";

            if(winner == "Player 1 won!")
            {
                p1wins++;
            }
            else if(winner == "Player 2 won!")
            {
                p2wins++;
            }
            return winner;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
