
namespace AI_Mancala_Interface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MancalaTableBoardLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BoardIndex0 = new System.Windows.Forms.Button();
            this.BoardIndex1 = new System.Windows.Forms.Button();
            this.BoardIndex2 = new System.Windows.Forms.Button();
            this.BoardIndex3 = new System.Windows.Forms.Button();
            this.BoardIndex4 = new System.Windows.Forms.Button();
            this.BoardIndex5 = new System.Windows.Forms.Button();
            this.BoardIndex13 = new System.Windows.Forms.Button();
            this.BoardIndex6 = new System.Windows.Forms.Button();
            this.BoardIndex7 = new System.Windows.Forms.Button();
            this.BoardIndex8 = new System.Windows.Forms.Button();
            this.BoardIndex9 = new System.Windows.Forms.Button();
            this.BoardIndex10 = new System.Windows.Forms.Button();
            this.BoardIndex11 = new System.Windows.Forms.Button();
            this.BoardIndex12 = new System.Windows.Forms.Button();
            this.Player1ControlChoice = new System.Windows.Forms.GroupBox();
            this.Player1AIRadio = new System.Windows.Forms.RadioButton();
            this.Player1HumanRadio = new System.Windows.Forms.RadioButton();
            this.Player1AILabel = new System.Windows.Forms.Label();
            this.Player2AILabel = new System.Windows.Forms.Label();
            this.Player2ChooseAIButton = new System.Windows.Forms.Button();
            this.Player2ControlChoice = new System.Windows.Forms.GroupBox();
            this.Player2AIRadio = new System.Windows.Forms.RadioButton();
            this.Player2HumanRadio = new System.Windows.Forms.RadioButton();
            this.Player1ChooseAIButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CurrentTurnLabel = new System.Windows.Forms.Label();
            this.CurrentPlayerPictureBox = new System.Windows.Forms.PictureBox();
            this.AIWaitNumericSetter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowLogButton = new System.Windows.Forms.Button();
            this.SetPauseLabel = new System.Windows.Forms.Label();
            this.PauseTimerSetter = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stonesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Player1ControlChoice.SuspendLayout();
            this.Player2ControlChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPlayerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIWaitNumericSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseTimerSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stonesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MancalaTableBoardLabel
            // 
            this.MancalaTableBoardLabel.AutoSize = true;
            this.MancalaTableBoardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MancalaTableBoardLabel.Location = new System.Drawing.Point(362, 46);
            this.MancalaTableBoardLabel.Name = "MancalaTableBoardLabel";
            this.MancalaTableBoardLabel.Size = new System.Drawing.Size(171, 26);
            this.MancalaTableBoardLabel.TabIndex = 0;
            this.MancalaTableBoardLabel.Text = "Mancala Board";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.pictureBox1.Location = new System.Drawing.Point(367, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 176);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BoardIndex0
            // 
            this.BoardIndex0.BackColor = System.Drawing.Color.IndianRed;
            this.BoardIndex0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoardIndex0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoardIndex0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardIndex0.Location = new System.Drawing.Point(435, 188);
            this.BoardIndex0.Name = "BoardIndex0";
            this.BoardIndex0.Size = new System.Drawing.Size(50, 50);
            this.BoardIndex0.TabIndex = 4;
            this.BoardIndex0.Text = "0";
            this.BoardIndex0.UseVisualStyleBackColor = false;
            this.BoardIndex0.Click += new System.EventHandler(this.BoardIndex0_Click);
            // 
            // BoardIndex1
            // 
            this.BoardIndex1.BackColor = System.Drawing.Color.IndianRed;
            this.BoardIndex1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoardIndex1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoardIndex1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardIndex1.Location = new System.Drawing.Point(491, 188);
            this.BoardIndex1.Name = "BoardIndex1";
            this.BoardIndex1.Size = new System.Drawing.Size(50, 50);
            this.BoardIndex1.TabIndex = 5;
            this.BoardIndex1.Text = "1";
            this.BoardIndex1.UseVisualStyleBackColor = false;
            this.BoardIndex1.Click += new System.EventHandler(this.BoardIndex1_Click);
            // 
            // BoardIndex2
            // 
            this.BoardIndex2.BackColor = System.Drawing.Color.IndianRed;
            this.BoardIndex2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoardIndex2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoardIndex2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardIndex2.Location = new System.Drawing.Point(547, 188);
            this.BoardIndex2.Name = "BoardIndex2";
            this.BoardIndex2.Size = new System.Drawing.Size(50, 50);
            this.BoardIndex2.TabIndex = 6;
            this.BoardIndex2.Text = "2";
            this.BoardIndex2.UseVisualStyleBackColor = false;
            this.BoardIndex2.Click += new System.EventHandler(this.BoardIndex2_Click);
            // 
            // BoardIndex3
            // 
            this.BoardIndex3.BackColor = System.Drawing.Color.IndianRed;
            this.BoardIndex3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoardIndex3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoardIndex3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardIndex3.Location = new System.Drawing.Point(603, 188);
            this.BoardIndex3.Name = "BoardIndex3";
            this.BoardIndex3.Size = new System.Drawing.Size(50, 50);
            this.BoardIndex3.TabIndex = 7;
            this.BoardIndex3.Text = "3";
            this.BoardIndex3.UseVisualStyleBackColor = false;
            this.BoardIndex3.Click += new System.EventHandler(this.BoardIndex3_Click);
            // 
            // BoardIndex4
            // 
            this.BoardIndex4.BackColor = System.Drawing.Color.IndianRed;
            this.BoardIndex4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoardIndex4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoardIndex4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardIndex4.Location = new System.Drawing.Point(659, 188);
            this.BoardIndex4.Name = "BoardIndex4";
            this.BoardIndex4.Size = new System.Drawing.Size(50, 50);
            this.BoardIndex4.TabIndex = 8;
            this.BoardIndex4.Text = "4";
            this.BoardIndex4.UseVisualStyleBackColor = false;
            this.BoardIndex4.Click += new System.EventHandler(this.BoardIndex4_Click);
            // 
            // BoardIndex5
            // 
            this.BoardIndex5.BackColor = System.Drawing.Color.IndianRed;
            this.BoardIndex5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoardIndex5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoardIndex5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardIndex5.Location = new System.Drawing.Point(715, 188);
            this.BoardIndex5.Name = "BoardIndex5";
            this.BoardIndex5.Size = new System.Drawing.Size(50, 50);
            this.BoardIndex5.TabIndex = 9;
            this.BoardIndex5.Text = "5";
            this.BoardIndex5.UseVisualStyleBackColor = false;
            this.BoardIndex5.Click += new System.EventHandler(this.BoardIndex5_Click);
            // 
            // BoardIndex13
            // 
            this.BoardIndex13.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BoardIndex13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoardIndex13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoardIndex13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardIndex13.Location = new System.Drawing.Point(379, 89);
            this.BoardIndex13.Name = "BoardIndex13";
            this.BoardIndex13.Size = new System.Drawing.Size(50, 150);
            this.BoardIndex13.TabIndex = 10;
            this.BoardIndex13.Text = "13";
            this.BoardIndex13.UseVisualStyleBackColor = false;
            this.BoardIndex13.Click += new System.EventHandler(this.BoardIndex13_Click);
            // 
            // BoardIndex6
            // 
            this.BoardIndex6.BackColor = System.Drawing.Color.IndianRed;
            this.BoardIndex6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoardIndex6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoardIndex6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardIndex6.Location = new System.Drawing.Point(771, 89);
            this.BoardIndex6.Name = "BoardIndex6";
            this.BoardIndex6.Size = new System.Drawing.Size(50, 150);
            this.BoardIndex6.TabIndex = 11;
            this.BoardIndex6.Text = "6";
            this.BoardIndex6.UseVisualStyleBackColor = false;
            this.BoardIndex6.Click += new System.EventHandler(this.BoardIndex6_Click);
            // 
            // BoardIndex7
            // 
            this.BoardIndex7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BoardIndex7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoardIndex7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoardIndex7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardIndex7.Location = new System.Drawing.Point(715, 88);
            this.BoardIndex7.Name = "BoardIndex7";
            this.BoardIndex7.Size = new System.Drawing.Size(50, 50);
            this.BoardIndex7.TabIndex = 17;
            this.BoardIndex7.Text = "7";
            this.BoardIndex7.UseVisualStyleBackColor = false;
            this.BoardIndex7.Click += new System.EventHandler(this.BoardIndex7_Click);
            // 
            // BoardIndex8
            // 
            this.BoardIndex8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BoardIndex8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoardIndex8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoardIndex8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardIndex8.Location = new System.Drawing.Point(659, 88);
            this.BoardIndex8.Name = "BoardIndex8";
            this.BoardIndex8.Size = new System.Drawing.Size(50, 50);
            this.BoardIndex8.TabIndex = 16;
            this.BoardIndex8.Text = "8";
            this.BoardIndex8.UseVisualStyleBackColor = false;
            this.BoardIndex8.Click += new System.EventHandler(this.BoardIndex8_Click);
            // 
            // BoardIndex9
            // 
            this.BoardIndex9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BoardIndex9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoardIndex9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoardIndex9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardIndex9.Location = new System.Drawing.Point(603, 88);
            this.BoardIndex9.Name = "BoardIndex9";
            this.BoardIndex9.Size = new System.Drawing.Size(50, 50);
            this.BoardIndex9.TabIndex = 15;
            this.BoardIndex9.Text = "9";
            this.BoardIndex9.UseVisualStyleBackColor = false;
            this.BoardIndex9.Click += new System.EventHandler(this.BoardIndex9_Click);
            // 
            // BoardIndex10
            // 
            this.BoardIndex10.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BoardIndex10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoardIndex10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoardIndex10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardIndex10.Location = new System.Drawing.Point(547, 88);
            this.BoardIndex10.Name = "BoardIndex10";
            this.BoardIndex10.Size = new System.Drawing.Size(50, 50);
            this.BoardIndex10.TabIndex = 14;
            this.BoardIndex10.Text = "10";
            this.BoardIndex10.UseVisualStyleBackColor = false;
            this.BoardIndex10.Click += new System.EventHandler(this.BoardIndex10_Click);
            // 
            // BoardIndex11
            // 
            this.BoardIndex11.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BoardIndex11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoardIndex11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoardIndex11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardIndex11.Location = new System.Drawing.Point(491, 88);
            this.BoardIndex11.Name = "BoardIndex11";
            this.BoardIndex11.Size = new System.Drawing.Size(50, 50);
            this.BoardIndex11.TabIndex = 13;
            this.BoardIndex11.Text = "11";
            this.BoardIndex11.UseVisualStyleBackColor = false;
            this.BoardIndex11.Click += new System.EventHandler(this.BoardIndex11_Click);
            // 
            // BoardIndex12
            // 
            this.BoardIndex12.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BoardIndex12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoardIndex12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoardIndex12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardIndex12.Location = new System.Drawing.Point(435, 88);
            this.BoardIndex12.Name = "BoardIndex12";
            this.BoardIndex12.Size = new System.Drawing.Size(50, 50);
            this.BoardIndex12.TabIndex = 12;
            this.BoardIndex12.Text = "12";
            this.BoardIndex12.UseVisualStyleBackColor = false;
            this.BoardIndex12.Click += new System.EventHandler(this.BoardIndex12_Click);
            // 
            // Player1ControlChoice
            // 
            this.Player1ControlChoice.BackColor = System.Drawing.SystemColors.Control;
            this.Player1ControlChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Player1ControlChoice.Controls.Add(this.Player1AIRadio);
            this.Player1ControlChoice.Controls.Add(this.Player1HumanRadio);
            this.Player1ControlChoice.Location = new System.Drawing.Point(12, 203);
            this.Player1ControlChoice.Name = "Player1ControlChoice";
            this.Player1ControlChoice.Size = new System.Drawing.Size(139, 73);
            this.Player1ControlChoice.TabIndex = 18;
            this.Player1ControlChoice.TabStop = false;
            this.Player1ControlChoice.Text = "Player 1 (Red)";
            // 
            // Player1AIRadio
            // 
            this.Player1AIRadio.AutoSize = true;
            this.Player1AIRadio.Location = new System.Drawing.Point(6, 42);
            this.Player1AIRadio.Name = "Player1AIRadio";
            this.Player1AIRadio.Size = new System.Drawing.Size(67, 17);
            this.Player1AIRadio.TabIndex = 1;
            this.Player1AIRadio.Text = "AI Player";
            this.Player1AIRadio.UseVisualStyleBackColor = true;
            this.Player1AIRadio.CheckedChanged += new System.EventHandler(this.Player1AIRadio_CheckedChanged);
            // 
            // Player1HumanRadio
            // 
            this.Player1HumanRadio.AutoSize = true;
            this.Player1HumanRadio.Checked = true;
            this.Player1HumanRadio.Location = new System.Drawing.Point(6, 19);
            this.Player1HumanRadio.Name = "Player1HumanRadio";
            this.Player1HumanRadio.Size = new System.Drawing.Size(91, 17);
            this.Player1HumanRadio.TabIndex = 0;
            this.Player1HumanRadio.TabStop = true;
            this.Player1HumanRadio.Text = "Human Player";
            this.Player1HumanRadio.UseVisualStyleBackColor = true;
            this.Player1HumanRadio.CheckedChanged += new System.EventHandler(this.Player1HumanRadio_CheckedChanged);
            // 
            // Player1AILabel
            // 
            this.Player1AILabel.AutoSize = true;
            this.Player1AILabel.Location = new System.Drawing.Point(15, 311);
            this.Player1AILabel.Name = "Player1AILabel";
            this.Player1AILabel.Size = new System.Drawing.Size(94, 13);
            this.Player1AILabel.TabIndex = 20;
            this.Player1AILabel.Text = "Selected AI: None";
            this.Player1AILabel.Click += new System.EventHandler(this.Player1AILabel_Click);
            // 
            // Player2AILabel
            // 
            this.Player2AILabel.AutoSize = true;
            this.Player2AILabel.Location = new System.Drawing.Point(15, 455);
            this.Player2AILabel.Name = "Player2AILabel";
            this.Player2AILabel.Size = new System.Drawing.Size(94, 13);
            this.Player2AILabel.TabIndex = 23;
            this.Player2AILabel.Text = "Selected AI: None";
            // 
            // Player2ChooseAIButton
            // 
            this.Player2ChooseAIButton.Enabled = false;
            this.Player2ChooseAIButton.Location = new System.Drawing.Point(12, 429);
            this.Player2ChooseAIButton.Name = "Player2ChooseAIButton";
            this.Player2ChooseAIButton.Size = new System.Drawing.Size(138, 23);
            this.Player2ChooseAIButton.TabIndex = 22;
            this.Player2ChooseAIButton.Text = "Choose AI Executable";
            this.Player2ChooseAIButton.UseVisualStyleBackColor = true;
            this.Player2ChooseAIButton.Click += new System.EventHandler(this.Player2ChooseAIButton_Click);
            // 
            // Player2ControlChoice
            // 
            this.Player2ControlChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Player2ControlChoice.Controls.Add(this.Player2AIRadio);
            this.Player2ControlChoice.Controls.Add(this.Player2HumanRadio);
            this.Player2ControlChoice.Location = new System.Drawing.Point(12, 350);
            this.Player2ControlChoice.Name = "Player2ControlChoice";
            this.Player2ControlChoice.Size = new System.Drawing.Size(139, 73);
            this.Player2ControlChoice.TabIndex = 21;
            this.Player2ControlChoice.TabStop = false;
            this.Player2ControlChoice.Text = "Player 2 (Blue)";
            // 
            // Player2AIRadio
            // 
            this.Player2AIRadio.AutoSize = true;
            this.Player2AIRadio.Location = new System.Drawing.Point(6, 42);
            this.Player2AIRadio.Name = "Player2AIRadio";
            this.Player2AIRadio.Size = new System.Drawing.Size(67, 17);
            this.Player2AIRadio.TabIndex = 1;
            this.Player2AIRadio.Text = "AI Player";
            this.Player2AIRadio.UseVisualStyleBackColor = true;
            this.Player2AIRadio.CheckedChanged += new System.EventHandler(this.Player2AIRadio_CheckedChanged);
            // 
            // Player2HumanRadio
            // 
            this.Player2HumanRadio.AutoSize = true;
            this.Player2HumanRadio.Checked = true;
            this.Player2HumanRadio.Location = new System.Drawing.Point(6, 19);
            this.Player2HumanRadio.Name = "Player2HumanRadio";
            this.Player2HumanRadio.Size = new System.Drawing.Size(91, 17);
            this.Player2HumanRadio.TabIndex = 0;
            this.Player2HumanRadio.TabStop = true;
            this.Player2HumanRadio.Text = "Human Player";
            this.Player2HumanRadio.UseVisualStyleBackColor = true;
            this.Player2HumanRadio.CheckedChanged += new System.EventHandler(this.Player2HumanRadio_CheckedChanged);
            // 
            // Player1ChooseAIButton
            // 
            this.Player1ChooseAIButton.Enabled = false;
            this.Player1ChooseAIButton.Location = new System.Drawing.Point(12, 282);
            this.Player1ChooseAIButton.Name = "Player1ChooseAIButton";
            this.Player1ChooseAIButton.Size = new System.Drawing.Size(138, 23);
            this.Player1ChooseAIButton.TabIndex = 24;
            this.Player1ChooseAIButton.Text = "Choose AI Executable";
            this.Player1ChooseAIButton.UseVisualStyleBackColor = true;
            this.Player1ChooseAIButton.Click += new System.EventHandler(this.Player1ChooseAIButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(18, 18);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 25;
            this.StartButton.Text = "Start Game";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(125, 18);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 26;
            this.ResetButton.Text = "Reset Game";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CurrentTurnLabel
            // 
            this.CurrentTurnLabel.AutoSize = true;
            this.CurrentTurnLabel.Location = new System.Drawing.Point(15, 117);
            this.CurrentTurnLabel.Name = "CurrentTurnLabel";
            this.CurrentTurnLabel.Size = new System.Drawing.Size(109, 13);
            this.CurrentTurnLabel.TabIndex = 27;
            this.CurrentTurnLabel.Text = "Current Players Turn: ";
            // 
            // CurrentPlayerPictureBox
            // 
            this.CurrentPlayerPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CurrentPlayerPictureBox.Location = new System.Drawing.Point(18, 133);
            this.CurrentPlayerPictureBox.Name = "CurrentPlayerPictureBox";
            this.CurrentPlayerPictureBox.Size = new System.Drawing.Size(182, 50);
            this.CurrentPlayerPictureBox.TabIndex = 28;
            this.CurrentPlayerPictureBox.TabStop = false;
            // 
            // AIWaitNumericSetter
            // 
            this.AIWaitNumericSetter.Location = new System.Drawing.Point(125, 91);
            this.AIWaitNumericSetter.Name = "AIWaitNumericSetter";
            this.AIWaitNumericSetter.Size = new System.Drawing.Size(74, 20);
            this.AIWaitNumericSetter.TabIndex = 29;
            this.AIWaitNumericSetter.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.AIWaitNumericSetter.ValueChanged += new System.EventHandler(this.AIWaitNumericSetter_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Set AI time Limit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(599, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Repeating Turns";
            // 
            // ShowLogButton
            // 
            this.ShowLogButton.Location = new System.Drawing.Point(188, 429);
            this.ShowLogButton.Name = "ShowLogButton";
            this.ShowLogButton.Size = new System.Drawing.Size(75, 23);
            this.ShowLogButton.TabIndex = 32;
            this.ShowLogButton.Text = "Show Log";
            this.ShowLogButton.UseVisualStyleBackColor = true;
            this.ShowLogButton.Click += new System.EventHandler(this.ShowLogButton_Click);
            // 
            // SetPauseLabel
            // 
            this.SetPauseLabel.AutoSize = true;
            this.SetPauseLabel.Location = new System.Drawing.Point(15, 56);
            this.SetPauseLabel.Name = "SetPauseLabel";
            this.SetPauseLabel.Size = new System.Drawing.Size(83, 26);
            this.SetPauseLabel.TabIndex = 34;
            this.SetPauseLabel.Text = "Set Pause after \r\nAI turn\r\n";
            // 
            // PauseTimerSetter
            // 
            this.PauseTimerSetter.DecimalPlaces = 2;
            this.PauseTimerSetter.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.PauseTimerSetter.Location = new System.Drawing.Point(125, 54);
            this.PauseTimerSetter.Name = "PauseTimerSetter";
            this.PauseTimerSetter.Size = new System.Drawing.Size(74, 20);
            this.PauseTimerSetter.TabIndex = 33;
            this.PauseTimerSetter.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.PauseTimerSetter.ValueChanged += new System.EventHandler(this.PauseTimerSetter_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Seconds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Seconds";
            // 
            // stonesNumericUpDown
            // 
            this.stonesNumericUpDown.Location = new System.Drawing.Point(713, 273);
            this.stonesNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stonesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stonesNumericUpDown.Name = "stonesNumericUpDown";
            this.stonesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.stonesNumericUpDown.TabIndex = 37;
            this.stonesNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.stonesNumericUpDown.ValueChanged += new System.EventHandler(this.StonesNumericUpdown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Number of Stones per Pit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Rules of Mancala";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stonesNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SetPauseLabel);
            this.Controls.Add(this.PauseTimerSetter);
            this.Controls.Add(this.ShowLogButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AIWaitNumericSetter);
            this.Controls.Add(this.CurrentPlayerPictureBox);
            this.Controls.Add(this.CurrentTurnLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Player1ChooseAIButton);
            this.Controls.Add(this.Player2AILabel);
            this.Controls.Add(this.Player2ChooseAIButton);
            this.Controls.Add(this.Player2ControlChoice);
            this.Controls.Add(this.Player1AILabel);
            this.Controls.Add(this.Player1ControlChoice);
            this.Controls.Add(this.BoardIndex7);
            this.Controls.Add(this.BoardIndex8);
            this.Controls.Add(this.BoardIndex9);
            this.Controls.Add(this.BoardIndex10);
            this.Controls.Add(this.BoardIndex11);
            this.Controls.Add(this.BoardIndex12);
            this.Controls.Add(this.BoardIndex6);
            this.Controls.Add(this.BoardIndex13);
            this.Controls.Add(this.BoardIndex5);
            this.Controls.Add(this.BoardIndex4);
            this.Controls.Add(this.BoardIndex3);
            this.Controls.Add(this.BoardIndex2);
            this.Controls.Add(this.BoardIndex1);
            this.Controls.Add(this.BoardIndex0);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MancalaTableBoardLabel);
            this.Name = "Form1";
            this.Text = "Mancala Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Player1ControlChoice.ResumeLayout(false);
            this.Player1ControlChoice.PerformLayout();
            this.Player2ControlChoice.ResumeLayout(false);
            this.Player2ControlChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPlayerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIWaitNumericSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseTimerSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stonesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MancalaTableBoardLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BoardIndex0;
        private System.Windows.Forms.Button BoardIndex1;
        private System.Windows.Forms.Button BoardIndex2;
        private System.Windows.Forms.Button BoardIndex3;
        private System.Windows.Forms.Button BoardIndex4;
        private System.Windows.Forms.Button BoardIndex5;
        private System.Windows.Forms.Button BoardIndex13;
        private System.Windows.Forms.Button BoardIndex6;
        private System.Windows.Forms.Button BoardIndex7;
        private System.Windows.Forms.Button BoardIndex8;
        private System.Windows.Forms.Button BoardIndex9;
        private System.Windows.Forms.Button BoardIndex10;
        private System.Windows.Forms.Button BoardIndex11;
        private System.Windows.Forms.Button BoardIndex12;
        private System.Windows.Forms.GroupBox Player1ControlChoice;
        private System.Windows.Forms.RadioButton Player1AIRadio;
        private System.Windows.Forms.RadioButton Player1HumanRadio;
        private System.Windows.Forms.Label Player1AILabel;
        private System.Windows.Forms.Label Player2AILabel;
        private System.Windows.Forms.Button Player2ChooseAIButton;
        private System.Windows.Forms.GroupBox Player2ControlChoice;
        private System.Windows.Forms.RadioButton Player2AIRadio;
        private System.Windows.Forms.RadioButton Player2HumanRadio;
        private System.Windows.Forms.Button Player1ChooseAIButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label CurrentTurnLabel;
        private System.Windows.Forms.PictureBox CurrentPlayerPictureBox;
        private System.Windows.Forms.NumericUpDown AIWaitNumericSetter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShowLogButton;
        private System.Windows.Forms.Label SetPauseLabel;
        private System.Windows.Forms.NumericUpDown PauseTimerSetter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown stonesNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

