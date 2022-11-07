namespace Sayf_Viewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbView = new System.Windows.Forms.PictureBox();
            this.lblPathIndicator = new System.Windows.Forms.Label();
            this.txtPathIndicator = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblFrame = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtApple = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPlaybackSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBlack = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtYellow = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtPurple = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtCyan = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtBrown = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtOrange = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtWhite = new System.Windows.Forms.TextBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbView
            // 
            this.pbView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbView.Location = new System.Drawing.Point(12, 12);
            this.pbView.Name = "pbView";
            this.pbView.Size = new System.Drawing.Size(500, 500);
            this.pbView.TabIndex = 0;
            this.pbView.TabStop = false;
            // 
            // lblPathIndicator
            // 
            this.lblPathIndicator.AutoSize = true;
            this.lblPathIndicator.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathIndicator.ForeColor = System.Drawing.Color.White;
            this.lblPathIndicator.Location = new System.Drawing.Point(561, 55);
            this.lblPathIndicator.Name = "lblPathIndicator";
            this.lblPathIndicator.Size = new System.Drawing.Size(126, 18);
            this.lblPathIndicator.TabIndex = 1;
            this.lblPathIndicator.Text = "Path Indicator:";
            // 
            // txtPathIndicator
            // 
            this.txtPathIndicator.BackColor = System.Drawing.Color.Black;
            this.txtPathIndicator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPathIndicator.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathIndicator.ForeColor = System.Drawing.Color.White;
            this.txtPathIndicator.Location = new System.Drawing.Point(693, 54);
            this.txtPathIndicator.Name = "txtPathIndicator";
            this.txtPathIndicator.Size = new System.Drawing.Size(100, 19);
            this.txtPathIndicator.TabIndex = 2;
            this.txtPathIndicator.Text = "*";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(693, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 1);
            this.panel1.TabIndex = 3;
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(12, 517);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(50, 50);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(462, 518);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 50);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(631, 472);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(117, 40);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblFrame
            // 
            this.lblFrame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrame.ForeColor = System.Drawing.Color.White;
            this.lblFrame.Location = new System.Drawing.Point(631, 531);
            this.lblFrame.Name = "lblFrame";
            this.lblFrame.Size = new System.Drawing.Size(117, 23);
            this.lblFrame.TabIndex = 7;
            this.lblFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(693, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 1);
            this.panel2.TabIndex = 10;
            // 
            // txtApple
            // 
            this.txtApple.BackColor = System.Drawing.Color.Black;
            this.txtApple.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApple.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApple.ForeColor = System.Drawing.Color.White;
            this.txtApple.Location = new System.Drawing.Point(693, 88);
            this.txtApple.Name = "txtApple";
            this.txtApple.Size = new System.Drawing.Size(100, 19);
            this.txtApple.TabIndex = 9;
            this.txtApple.Text = "G";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(628, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Apple:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(693, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 1);
            this.panel3.TabIndex = 13;
            // 
            // txtPlaybackSpeed
            // 
            this.txtPlaybackSpeed.BackColor = System.Drawing.Color.Black;
            this.txtPlaybackSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlaybackSpeed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaybackSpeed.ForeColor = System.Drawing.Color.White;
            this.txtPlaybackSpeed.Location = new System.Drawing.Point(693, 119);
            this.txtPlaybackSpeed.Name = "txtPlaybackSpeed";
            this.txtPlaybackSpeed.Size = new System.Drawing.Size(100, 19);
            this.txtPlaybackSpeed.TabIndex = 12;
            this.txtPlaybackSpeed.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(546, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Playback Speed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(740, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(561, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Colour";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(564, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Black";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(564, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Green";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(564, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Blue";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(564, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Yellow";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(564, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Purple";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(564, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cyan";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(564, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Brown";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(564, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "Red";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(564, 371);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 18);
            this.label13.TabIndex = 24;
            this.label13.Text = "Orange";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(564, 392);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 18);
            this.label14.TabIndex = 25;
            this.label14.Text = "White";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(716, 219);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 1);
            this.panel4.TabIndex = 27;
            // 
            // txtBlack
            // 
            this.txtBlack.BackColor = System.Drawing.Color.Black;
            this.txtBlack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBlack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlack.ForeColor = System.Drawing.Color.White;
            this.txtBlack.Location = new System.Drawing.Point(716, 201);
            this.txtBlack.Name = "txtBlack";
            this.txtBlack.Size = new System.Drawing.Size(100, 16);
            this.txtBlack.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(716, 238);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 1);
            this.panel5.TabIndex = 29;
            // 
            // txtGreen
            // 
            this.txtGreen.BackColor = System.Drawing.Color.Black;
            this.txtGreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGreen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGreen.ForeColor = System.Drawing.Color.White;
            this.txtGreen.Location = new System.Drawing.Point(716, 220);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(100, 16);
            this.txtGreen.TabIndex = 28;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(716, 260);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 1);
            this.panel6.TabIndex = 31;
            // 
            // txtBlue
            // 
            this.txtBlue.BackColor = System.Drawing.Color.Black;
            this.txtBlue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBlue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlue.ForeColor = System.Drawing.Color.White;
            this.txtBlue.Location = new System.Drawing.Point(716, 242);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(100, 16);
            this.txtBlue.TabIndex = 30;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(716, 281);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 1);
            this.panel7.TabIndex = 33;
            // 
            // txtYellow
            // 
            this.txtYellow.BackColor = System.Drawing.Color.Black;
            this.txtYellow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYellow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYellow.ForeColor = System.Drawing.Color.White;
            this.txtYellow.Location = new System.Drawing.Point(716, 263);
            this.txtYellow.Name = "txtYellow";
            this.txtYellow.Size = new System.Drawing.Size(100, 16);
            this.txtYellow.TabIndex = 32;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(716, 302);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 1);
            this.panel8.TabIndex = 35;
            // 
            // txtPurple
            // 
            this.txtPurple.BackColor = System.Drawing.Color.Black;
            this.txtPurple.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPurple.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurple.ForeColor = System.Drawing.Color.White;
            this.txtPurple.Location = new System.Drawing.Point(716, 284);
            this.txtPurple.Name = "txtPurple";
            this.txtPurple.Size = new System.Drawing.Size(100, 16);
            this.txtPurple.TabIndex = 34;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(716, 324);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(100, 1);
            this.panel9.TabIndex = 37;
            // 
            // txtCyan
            // 
            this.txtCyan.BackColor = System.Drawing.Color.Black;
            this.txtCyan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCyan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCyan.ForeColor = System.Drawing.Color.White;
            this.txtCyan.Location = new System.Drawing.Point(716, 306);
            this.txtCyan.Name = "txtCyan";
            this.txtCyan.Size = new System.Drawing.Size(100, 16);
            this.txtCyan.TabIndex = 36;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(716, 345);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(100, 1);
            this.panel10.TabIndex = 39;
            // 
            // txtBrown
            // 
            this.txtBrown.BackColor = System.Drawing.Color.Black;
            this.txtBrown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrown.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrown.ForeColor = System.Drawing.Color.White;
            this.txtBrown.Location = new System.Drawing.Point(716, 327);
            this.txtBrown.Name = "txtBrown";
            this.txtBrown.Size = new System.Drawing.Size(100, 16);
            this.txtBrown.TabIndex = 38;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(716, 366);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(100, 1);
            this.panel11.TabIndex = 41;
            // 
            // txtRed
            // 
            this.txtRed.BackColor = System.Drawing.Color.Black;
            this.txtRed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRed.ForeColor = System.Drawing.Color.White;
            this.txtRed.Location = new System.Drawing.Point(716, 348);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(100, 16);
            this.txtRed.TabIndex = 40;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Location = new System.Drawing.Point(716, 388);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(100, 1);
            this.panel12.TabIndex = 43;
            // 
            // txtOrange
            // 
            this.txtOrange.BackColor = System.Drawing.Color.Black;
            this.txtOrange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrange.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrange.ForeColor = System.Drawing.Color.White;
            this.txtOrange.Location = new System.Drawing.Point(716, 370);
            this.txtOrange.Name = "txtOrange";
            this.txtOrange.Size = new System.Drawing.Size(100, 16);
            this.txtOrange.TabIndex = 42;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Location = new System.Drawing.Point(716, 409);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(100, 1);
            this.panel13.TabIndex = 45;
            // 
            // txtWhite
            // 
            this.txtWhite.BackColor = System.Drawing.Color.Black;
            this.txtWhite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWhite.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhite.ForeColor = System.Drawing.Color.White;
            this.txtWhite.Location = new System.Drawing.Point(716, 391);
            this.txtWhite.Name = "txtWhite";
            this.txtWhite.Size = new System.Drawing.Size(100, 16);
            this.txtWhite.TabIndex = 44;
            // 
            // trackBar
            // 
            this.trackBar.Enabled = false;
            this.trackBar.Location = new System.Drawing.Point(68, 523);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(388, 45);
            this.trackBar.TabIndex = 46;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(845, 579);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.txtWhite);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.txtOrange);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.txtBrown);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.txtCyan);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtPurple);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtYellow);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtBlack);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtPlaybackSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtApple);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFrame);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPathIndicator);
            this.Controls.Add(this.lblPathIndicator);
            this.Controls.Add(this.pbView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sayf Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbView;
        private System.Windows.Forms.Label lblPathIndicator;
        private System.Windows.Forms.TextBox txtPathIndicator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblFrame;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtApple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPlaybackSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBlack;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtYellow;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtPurple;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtCyan;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtBrown;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtOrange;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtWhite;
        private System.Windows.Forms.TrackBar trackBar;
    }
}

