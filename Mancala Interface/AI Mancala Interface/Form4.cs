using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Mancala_Interface
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            richTextBox1.Text = "• Basic Rules:  \r\n";
            richTextBox1.Text += "\t   o Play always moves around the board in a counter-clockwise circle.\r\n\r\n";
            richTextBox1.Text += "\t         (ie.Player 1(bottom red row) moves to the right &Player 2(top blue row) moves to the left).\r\n\r\n";
            richTextBox1.Text += "\t   o The store(the big box) on the right belongs to Player 1 & the one on the Left belongs to Player 2.That is where you keep the seeds you win.\r\n";
            richTextBox1.Text += "\t   o The six pits of your player’s color are your pits, the number of seeds in each pit is shown on the button.\r\n\r\n";
            richTextBox1.Text += "\t         (Player 1’s pits are the small red buttons, and Player 2’s pits are the small blue buttons.)\r\n\r\n";
            richTextBox1.Text += "\t   o Click on your pit that you want to move, and the game will place 1 seed in each of the following pits except for the other player’s store.\r\n\r\n";
            richTextBox1.Text += "\t\t    Then Players alternate turns, unless otherwise specified in the next section.\r\n\r\n";
            richTextBox1.Text += "• Special Rules:\r\n\r\n";
            richTextBox1.Text += "\t   o   If the last seed placed lands in your store, then you get to take another turn.\r\n\r\n";
            richTextBox1.Text += "\t   o   If the last seed placed lands in an empty pit on your sit of the board, then you steal the other player’s seeds from that index on their side of the board, and \r\n\r\n";
            richTextBox1.Text += "\t\t     the one seed that caused the steal into your store, unless nothing was stolen.\r\n\r\n";
            richTextBox1.Text += "\t        (ie.If Player 1 landed in the pit closest to their store and it was empty, then they would steal from the pit closest to Player 2’s store, only if there are \r\n\r\n";
            richTextBox1.Text += "\t\t\t   any seeds in that pit.)\r\n\r\n";
            richTextBox1.Text += "• End of the Game:\r\n\r\n";
            richTextBox1.Text += "\t  o The game ends once either player can no longer make any moves(all their pits are empty, except their store).Then the other player with seeds still on the \r\n\r\n";
            richTextBox1.Text += "\t     board moves all their seeds to their store.\r\n\r\n";
            richTextBox1.Text += "\t  o The player with the most seeds in their store wins.\r\n\r\n";
       
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
