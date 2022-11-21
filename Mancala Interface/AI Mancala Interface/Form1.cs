using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Drawing.Drawing2D;
//for process class
using System.Diagnostics;
namespace AI_Mancala_Interface
{
    
    public partial class Form1 : Form
    {

        public Button[] board = new Button[14];
        List<int> defaultList = new List<int>();
        string logString;
        int totalTurns = 0;
        bool player1IsAI = false;
        bool player2IsAI = false;
        bool isPlayer1Turn = true;
     
        int timeToWaitForAI = 5;
        string player1AIPath;
        string player2AIPath;
        double sleepAfterAITurnTime = 0.5;
       
        public Form1()
        { 

        
            InitializeComponent();
            FillBoardButtonArray();
            int[] defaultArray = { 4, 4, 4, 4, 4, 4, 0, 4, 4, 4, 4, 4, 4, 0 };

            //clear the list incase a reset was pressed
            defaultList.Clear();
            //cin text

            for (int i = 0; i < defaultArray.Length; i++)
            {
                defaultList.Add(defaultArray[i]);
            }

            writeIntArrayToBoard(defaultList);
            Player1ChooseAIButton.Enabled = false;
            Player2ChooseAIButton.Enabled = false;
            ResetButton.Enabled = false;
            ShowLogButton.Enabled = false;


        }
     
        private void FillBoardButtonArray()
        {
            //this is done to keep track of all pit locations
            board[0] = BoardIndex0;
            board[1] = BoardIndex1;
            board[2] = BoardIndex2;
            board[3] = BoardIndex3;
            board[4] = BoardIndex4;
            board[5] = BoardIndex5;
            board[6] = BoardIndex6;
            board[7] = BoardIndex7;
            board[8] = BoardIndex8;
            board[9] = BoardIndex9;
            board[10] = BoardIndex10;
            board[11] = BoardIndex11;
            board[12] = BoardIndex12;
            board[13] = BoardIndex13;
    

      
            for (int i = 0; i < 14; i++)
            {
                board[i].Enabled = false;
            }

        }

        public void writeIntArrayToBoard(List<int> boardVals)
        {
           
            for (int i = 0; i < boardVals.Count; i++)
            {
                board[i].Text = boardVals[i].ToString();
            
            }
            Application.DoEvents();
            
        }

        public void SetCurrentPlayerPictureBox(bool player1Turn)
        {
            if (player1Turn)
            {
                //player 1 red
         
                CurrentPlayerPictureBox.BackColor = Color.FromArgb(205, 92, 92);
            }
            else
            {
                //player 2 blue
            
                CurrentPlayerPictureBox.BackColor = Color.FromArgb(135, 206, 250);
            }

        }


        private void MancalaRulesLabel_Click(object sender, EventArgs e)
        {
            //this one is not used
        }

        private void Player1ChooseAIButton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "exe files (*.exe)|*.exe";
            if (file.ShowDialog() == DialogResult.OK)
            {
                Console.Write("Player 1 AI path: " + file.FileName +"\n");
                string temp = file.FileName.Substring(file.FileName.LastIndexOf("\\")+1);
                Player1AILabel.Text = "Selected AI: \n" + temp;

                player1AIPath = file.FileName;


            }
        }

        private void Player2ChooseAIButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "exe files (*.exe)|*.exe";
            if (file.ShowDialog() == DialogResult.OK)
            {
                Console.Write("Player 2 AI path: " + file.FileName +"\n");
                string temp = file.FileName.Substring(file.FileName.LastIndexOf("\\")+1);

                Player2AILabel.Text = "Selected AI: \n" + temp;
                player2AIPath = file.FileName;


            }
        }

        private void startGame()
        {
            Player1ChooseAIButton.Enabled = false;
            Player2ChooseAIButton.Enabled = false;
            Player1HumanRadio.Enabled = false;
            Player2HumanRadio.Enabled = false;
            Player1AIRadio.Enabled = false;
            Player2AIRadio.Enabled = false;
            logString = "Mancala Log File\n\n";

            //just a case for if the reset button is pressed since 1st player always goes first
            if (CurrentPlayerPictureBox.BackColor == Color.FromArgb(135, 206, 250))
            {
                isPlayer1Turn = !isPlayer1Turn;
                SetCurrentPlayerPictureBox(isPlayer1Turn);
            }

          
            SetCurrentPlayerPictureBox(isPlayer1Turn);
            int[] defaultArray = { 4, 4, 4, 4, 4, 4, 0, 4, 4, 4, 4, 4, 4, 0 };
            int numStones = 4;
            numStones = (int)stonesNumericUpDown.Value;
            for (int i = 0; i < 14; i++)
            {
                if (i % 7 == 6)
                {
                    defaultArray[i] = 0;
                }
                else
                {
                    defaultArray[i] = numStones;
                }

            }
            defaultList.Clear();
            logString += "Initial Board: ";
            for (int i = 0; i < defaultArray.Length; i++)
            {
                defaultList.Add(defaultArray[i]);
                logString += defaultArray[i].ToString();
                if (i != defaultArray.Length - 1)
                {
                    logString += ", ";
                }
            

            }
            logString += "\n\n";
            writeIntArrayToBoard(defaultList);
           
            StartButton.Enabled = false;
            ResetButton.Enabled = true;

            if (Player1HumanRadio.Checked)
            {
                player1IsAI = false;
            }
            if (Player1AIRadio.Checked)
            {
                player1IsAI = true;
          
            }
            if (Player2HumanRadio.Checked)
            {
                player2IsAI = false;
            }
            if (Player2AIRadio.Checked)
            {
                player2IsAI = true;
                if (Player1AIRadio.Checked)
                {
                    player1IsAI = true;
                    
                }
            }


            for (int i = 0; i < 14; i++)
            {
                if (i < 6 && defaultList[i] != 0)
                {
                    board[i].Enabled = true;
                }

            }
            timeToWaitForAI = (int)AIWaitNumericSetter.Value;
            writeBoardFile(isPlayer1Turn);
            if (fileCheck() == true)
            {
                return;
            }
            sleepAfterAITurnTime = (double)PauseTimerSetter.Value;
            if (player1IsAI)
            {
                Thread.Sleep((int)(1000 * sleepAfterAITurnTime));
                makeInitialAIMove();
            }
        }

        private void resetGame()
        {
            label2.Text = "Player 1's (Red) Turn";
            Player1AILabel.Text = "Selected AI: None";
            Player2AILabel.Text = "Selected AI: None";
            player1AIPath = null;
            player2AIPath = null;
            Player1HumanRadio.Checked = true;
            Player2HumanRadio.Checked = true;
            Player1HumanRadio.Enabled = true;
            Player2HumanRadio.Enabled = true;
            //just a case for if the reset button is pressed since 1st player always goes first
            if (CurrentPlayerPictureBox.BackColor == Color.FromArgb(135, 206, 250))
            {
                isPlayer1Turn = !isPlayer1Turn;
                SetCurrentPlayerPictureBox(isPlayer1Turn);
            }

            int[] defaultArray = { 4, 4, 4, 4, 4, 4, 0, 4, 4, 4, 4, 4, 4, 0 };
            //clear the list incase a reset was pressed
            defaultList.Clear();
            for (int i = 0; i < defaultArray.Length; i++)
            {
                defaultList.Add(defaultArray[i]);
            }
            writeIntArrayToBoard(defaultList);
            SetCurrentPlayerPictureBox(isPlayer1Turn);
            disableBoard();
            StartButton.Enabled = true;
            ResetButton.Enabled = false;
            ShowLogButton.Enabled = false;
            logString = "Mancala Log File\n\n";
            
            totalTurns = 0;
                
                //gets if the players are AI, and the AI timout value
            if (Player1HumanRadio.Checked)
            {
                player1IsAI = false;
                Player1ChooseAIButton.Enabled = false;
            }
            if (Player1AIRadio.Checked)
            {
                player1IsAI = true;
            }
            if (Player2HumanRadio.Checked)
            {
                player2IsAI = false;
                Player2ChooseAIButton.Enabled = false;
            }
            if (Player2AIRadio.Checked)
            {
                player2IsAI = true;
            }

            timeToWaitForAI = (int)AIWaitNumericSetter.Value;
            writeBoardFile(isPlayer1Turn);
            if (fileCheck() == true)
            {
                return;
            }
            sleepAfterAITurnTime = (double)PauseTimerSetter.Value;
            if (player1IsAI)
            {
                Thread.Sleep((int)(1000 * sleepAfterAITurnTime));
                makeInitialAIMove();
            }
            Player1ChooseAIButton.Enabled = true;
            Player2ChooseAIButton.Enabled = true;
            Player1HumanRadio.Enabled = true;
            Player2HumanRadio.Enabled = true;
            Player1AIRadio.Enabled = true;
            Player2AIRadio.Enabled = true;
        }


        private bool player1Turn()
        {

            if (CurrentPlayerPictureBox.BackColor == Color.FromArgb(205, 92, 92))
                return true;
            else
                return false; ;

        }
        private bool checkSide(bool playerTurn)
        {
            if(playerTurn)
            {
                return true;
            }else
            {
                return false;
            }
            
        }

        private void makeMove(int index)
        {
          
            ShowLogButton.Enabled = true;
            int adjacentPots = 0;
            //default adjacentVal is 100 which is going to create a huge invalid mod value for the board meaning by default it wont have an effect
            int adjacentVal = 100;
     
            //basically going to use this line with the goal pot condition in an else if statement
            isPlayer1Turn = !isPlayer1Turn;
            SetCurrentPlayerPictureBox(isPlayer1Turn);


            //sets goal pot based on the color of the pixel box.
            int goal = player1Turn() == true ? 2 * 7 - 1 : 1 * 7 - 1;

     
            int pot = defaultList[index];
            int travelTo = index + pot;
            defaultList[index] = 0;


          
            int end = travelTo + 1;
            int start = index + 1;
            //the whole for loop which deals with all of the mancala cases dependent on the entered in index.
            for (int i = start; i < end; i++)
            {
                if (i < 13)
                {
                    if (pot == 1 && defaultList[i] == 0 && i % 7 != 6)
                    {
                        bool firstPlayerTurn = isPlayer1Turn ? true : false;
         
                        if(!(firstPlayerTurn == true && i < 6) && !(firstPlayerTurn == false && i > 5))
                        { 
                            adjacentVal = i % 7;
                            if (checkIfAdjacentEmpty(adjacentVal))
                            {
                                if (isPlayer1Turn)
                                {
                                    label2.Text = "Player 1's (Red) Turn";
                                }
                                else
                                {
                                    label2.Text = "Player 2's (Blue) Turn";
                                }
                                defaultList[i]++;
                                pot--;
                                adjacentPots += takePots(adjacentVal);
                                break;
                            }
                        }
                    }
                }
                //case of ending in goal pot will break out of loop
                if (pot == 1 && i == goal)
                {


                    string anotherTurn = goal == 6 ? "Player 1 (Red) goes Again!" : "Player 2 (Blue) goes Again!";
                    label2.Text = anotherTurn;
                    isPlayer1Turn = !isPlayer1Turn;
                    SetCurrentPlayerPictureBox(isPlayer1Turn);
                    defaultList[i]++;
                    pot--;
                    break;
                }
                //passing in player turn to make sure move starts on legal space
                if (legalMove(i, goal, player1Turn()))
                {
                    if (i > defaultList.Count - 1)
                    {

                        //reset;
                        defaultList[0]++;
                        start = 0;
                        //it will increment at the end of the loop so it actually will be 0 when the for loop runs again.
                        i = 0;

                        end = pot--;
                    }
                    else
                    {

                        defaultList[i]++;
                        pot--;
                    }
                    if (isPlayer1Turn)
                    {
                        label2.Text = "Player 1's (Red) Turn";
                    }
                    else
                    {
                        label2.Text = "Player 2's (Blue) Turn";
                    }
                }
                
            }

            defaultList[goal] += adjacentPots;
            totalTurns++;
            writeIntArrayToBoard(defaultList);
            saveString(totalTurns);
            int playerOneNum = 0;
            int playerTwoNum = 0;
            for (int i = 0; i < defaultList.Count; i++)
            {
                if (defaultList[i] == 0 && i > 6)
                {
                    playerOneNum++;
                } else if (defaultList[i] == 0 && i < 13)
                {
                    playerTwoNum++;
                }
            }
            if (!(player1IsAI && player2IsAI))
            {
                //disables buttons on certain turns so opponents buttons cannot be clicked.(also 0s)
                swapTurns();
            }

                //hopefully works to start AI
            writeBoardFile(isPlayer1Turn);

         
            if (isPlayer1Turn && player1IsAI && !checkIfGameIsOver())
            {
                Process player1AIProcess = Process.Start(player1AIPath);
                if(!player1AIProcess.WaitForExit(1000 * timeToWaitForAI))
                {
                   
                    MessageBox.Show("Player 1 AI (Red) Timedout");
                    disableBoard();
                }
                else
                {
                    int AIMove = readMove();
                    Thread.Sleep((int)(1000*sleepAfterAITurnTime));
                    makeMove(AIMove);
                }
            }

            if(!isPlayer1Turn && player2IsAI && !checkIfGameIsOver())
            {
            
                Process player2AIProcess = Process.Start(player2AIPath);
                if (!player2AIProcess.WaitForExit(1000 * timeToWaitForAI))
                {
            
                 
                    MessageBox.Show("Player 2 AI (Blue) Timedout");
                    disableBoard();
                }
                else
                {
                    int AIMove = readMove();

                    Thread.Sleep((int)(1000 * sleepAfterAITurnTime));
                    makeMove(AIMove);
                }
            }


            //checks if the game is done after each turn.
            gameIsDone(playerOneNum, playerTwoNum);

            

        }

        public bool checkIfAdjacentEmpty(int adjacent)
        {
            int total = 0;
            for(int i = 0; i < defaultList.Count; i++)
            {
                if(i % 7 == adjacent)
                {
         
                    total += defaultList[i];

                }
            }

            if(total == 0)
            {
                return false;
            }
            return true;
        }
        public int takePots(int adjacentVal)
        {
            int adjacentPots = 0;
            for (int i = 0; i < defaultList.Count; i++)
            {
                //will have to change this due to how the board is set up
                if (adjacentVal == i % 7)
                {
                    //adds adjacent vals to a variable throughout the board(even their own)
                    adjacentPots += defaultList[i];
                    //clear the other ones
                    defaultList[i] = 0;
                }

            }
 
            return adjacentPots;
        }
        public void swapTurns()
        {
            if (player1Turn())
            {
                for (int i = 0; i < 14; i++)
                {
                    board[i].Enabled = i < 6 && defaultList[i] != 0 ? true : false;

                }
            }
            else
            {
                for (int i = 0; i < 14; i++)
                {
                    board[i].Enabled = i > 6 && i < 13 && defaultList[i] != 0 ? true : false;

                }
            }
        }

        public bool checkIfGameIsOver()
        {
            int playerOneStones = 0;
            int playerTwoStones = 0;
            for(int i = 0; i < defaultList.Count; i++)
            {
                
                if(i < 6)
                {
                    playerOneStones += defaultList[i];
                }
                if(i > 6 && i < 13)
                {
                    playerTwoStones += defaultList[i];
                }

        
            }
            if(playerOneStones == 0 || playerTwoStones == 0)
            {
                return true;
            }else
            {
                return false;
            }
   
        }
        public void gameIsDone(int player2, int player1)
        {
            
            //basically has the counter if either side is full of zeros determining game end state. If so it will show a message box and disable the board.
            if (player1 == 6 || player2 == 6)
            {
         
             
                int extraPlayer1Stones = 0;
                int extraPlayer2Stones = 0;
                if (player1 != 6)
                {
                    for(int i = 0; i<defaultList.Count; i++)
                    {
                        if(i < 6)
                        {
                    
                            extraPlayer1Stones += defaultList[i];
                            defaultList[i] = 0;
                        }
                    }
                    defaultList[6] += extraPlayer1Stones;
                }

                if (player2 != 6)
                {
                    for (int i = 0; i < defaultList.Count; i++)
                    {
                        if (i > 6 && i < 13)
                        {
                           
                            extraPlayer2Stones += defaultList[i];
                            defaultList[i] = 0;
                        }
                    }
                    defaultList[13] += extraPlayer2Stones;
                }
                
                writeIntArrayToBoard(defaultList);
                if (defaultList[6] > defaultList[13])
                {
                    MessageBox.Show("Player 1 wins!");
                    disableBoard();
                    Player1HumanRadio.Checked = true;
                    Player2HumanRadio.Checked = true;
                    writeOut(defaultList[6], defaultList[13]);
                }
                else if ((defaultList[6] < defaultList[13]))
                {
                    MessageBox.Show("Player 2 wins!");
                    disableBoard();
                    Player1HumanRadio.Checked = true;
                    Player2HumanRadio.Checked = true;
                    writeOut(defaultList[6], defaultList[13]);
                }
                else
                {
                    MessageBox.Show("Draw!");
                    disableBoard();
                    writeOut(defaultList[6], defaultList[13]);
                }
            }
        }
        public void disableBoard()
        {
            for (int i = 0; i < 14; i++)
            {

                board[i].Enabled = false;

            }
        }

      
        bool legalMove(int curIndex, int goal, bool playerOne)
        {
            if (!(curIndex % 7 == 6) || goal == curIndex)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            startGame();
           
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            
            resetGame();
     
        }

        private void BoardIndex0_Click(object sender, EventArgs e)
        {
            makeMove(0);
        }

        private void BoardIndex1_Click(object sender, EventArgs e)
        {
            makeMove(1);
        }

        private void BoardIndex2_Click(object sender, EventArgs e)
        {
            makeMove(2);
        }

        private void BoardIndex3_Click(object sender, EventArgs e)
        {
            makeMove(3);
        }

        private void BoardIndex4_Click(object sender, EventArgs e)
        {
            makeMove(4);
        }

        private void BoardIndex5_Click(object sender, EventArgs e)
        {
            makeMove(5);
        }

        private void BoardIndex6_Click(object sender, EventArgs e)
        {
            // Player 2 Goal
            //makeMove(6);
        }

        private void BoardIndex7_Click(object sender, EventArgs e)
        {
            makeMove(7);
        }

        private void BoardIndex8_Click(object sender, EventArgs e)
        {
            makeMove(8);
        }

        private void BoardIndex9_Click(object sender, EventArgs e)
        {
            makeMove(9);
        }

        private void BoardIndex10_Click(object sender, EventArgs e)
        {
            makeMove(10);
        }

        private void BoardIndex11_Click(object sender, EventArgs e)
        {
            makeMove(11);
        }

        private void BoardIndex12_Click(object sender, EventArgs e)
        {
            makeMove(12);
        }

        private void BoardIndex13_Click(object sender, EventArgs e)
        {
            // player 1's goal
            //makeMove(13);
        }
        private void saveString(int turns)
        {
            bool playerTurn = true;
            playerTurn = isPlayer1Turn ? true : false;
            if(playerTurn == false)
            {
                logString += "Player 1:  ";
            }else
            {
                logString += "Player 2:  ";
            }
            for (int i = 0; i < defaultList.Count; i++)
            {
                logString += defaultList[i].ToString();
              
                logString += ", ";
                
            }
            logString += String.Format("{0,30}", "Turn: " + turns);
            logString += "\n";

        }
        public void writeOut(int playerOneScore, int playerTwoScore)
        {
            var curDir = Directory.GetCurrentDirectory();
            //will implement this later, just makes it so that it is not hard coded
         
            //turn forward slash into back slash
            String file = curDir + "\\Log.txt";
 
            using (StreamWriter write = new StreamWriter(file))
            {
                        
                        write.Write(logString);
                        write.Write("player 1 score: " + defaultList[6]);
                        write.Write("\nplayer 2 score: " + defaultList[13]);
            }

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Player1HumanRadio_CheckedChanged(object sender, EventArgs e)
        {
            Player1ChooseAIButton.Enabled = false;
        }

        private void Player2HumanRadio_CheckedChanged(object sender, EventArgs e)
        {
            Player2ChooseAIButton.Enabled = false;
        }

        private void Player1AIRadio_CheckedChanged(object sender, EventArgs e)
        {
            Player1ChooseAIButton.Enabled = true;

        }

        private void Player2AIRadio_CheckedChanged(object sender, EventArgs e)
        {
            Player2ChooseAIButton.Enabled = true;
      
        }

        private void ShowLogButton_Click(object sender, EventArgs e)
        {

            
            Form2 f2 = new Form2(logString);
            f2.ShowDialog();


        }

        private void writeBoardFile(bool isFirstPlayer)
        {
            string boardString;
            if (isFirstPlayer)
            {
                boardString = "1:";
            }
            else
            {
                boardString = "2:";
            }
             

            for(int i = 0; i < 14; i++)
            {
                boardString = boardString + defaultList[i].ToString() + ",";
            }
            Console.Write(boardString +" \n");

            File.WriteAllText("board.txt", boardString);
        }

        public int readMove()
        {
            int move = 0;
            string moveContents = "";
            StreamReader moveReader = new StreamReader("move.txt");
            moveContents = moveReader.ReadToEnd();

            move = Int32.Parse(moveContents);
            Console.Write("Read move as: " + move + " \n");
            moveReader.Close();
            return move;

        }
        public bool fileCheck()
        {
            
            bool Logan = false;
            if (!File.Exists(player1AIPath) && player1IsAI)
            {
                MessageBox.Show("Player 1's AI file Does not exist, or no AI was chosen for player(s)");
                Player1HumanRadio.Checked = true;
                Logan = true;
               
            }
            if (!File.Exists(player2AIPath) && player2IsAI)
            {
                MessageBox.Show("Player 2's AI file Does not exist, or no AI was chosen for player(s)");
                Player2HumanRadio.Checked = true;
                Logan = true;
            }
            return Logan;
            
        }

        public void makeInitialAIMove()
        {
            Process player1AIProcess = Process.Start(player1AIPath);
            if (!player1AIProcess.WaitForExit(1000 * timeToWaitForAI))
            {
                MessageBox.Show("Player 1 AI (Red) Timedout");
                disableBoard();
            }
            else
            {
                int AIMove = readMove();
                Thread.Sleep((int)(1000 * sleepAfterAITurnTime));
                makeMove(AIMove);
            }
        }

        private void PauseTimerSetter_ValueChanged(object sender, EventArgs e)
        {
            sleepAfterAITurnTime = (double)PauseTimerSetter.Value;
        }

        private void AIWaitNumericSetter_ValueChanged(object sender, EventArgs e)
        {
            timeToWaitForAI = (int)AIWaitNumericSetter.Value;
        }

        private void StonesNumericUpdown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RulesTextbox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Player1AILabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
    }

}
