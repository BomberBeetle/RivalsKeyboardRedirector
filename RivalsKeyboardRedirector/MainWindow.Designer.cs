namespace RivalsKeyboardRedirector
{
    partial class MainWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelCurrentKb = new System.Windows.Forms.Label();
            this.vJoyBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox_LSUP = new System.Windows.Forms.TextBox();
            this.inputBox_LSRIGHT = new System.Windows.Forms.TextBox();
            this.inputBox_LSLEFT = new System.Windows.Forms.TextBox();
            this.inputBox_LSDOWN = new System.Windows.Forms.TextBox();
            this.inputBox_RSDOWN = new System.Windows.Forms.TextBox();
            this.inputBox_RSLEFT = new System.Windows.Forms.TextBox();
            this.inputBox_RSRIGHT = new System.Windows.Forms.TextBox();
            this.inputBox_RSUP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputBox_DDOWN = new System.Windows.Forms.TextBox();
            this.inputBox_DLEFT = new System.Windows.Forms.TextBox();
            this.inputBox_DRIGHT = new System.Windows.Forms.TextBox();
            this.inputBox_DUP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputBox_LSMOD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputBox_A = new System.Windows.Forms.TextBox();
            this.inputBox_B = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputBox_X = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputBox_Y = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LSAutorunBox = new System.Windows.Forms.CheckBox();
            this.inputBox_R = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.inputBox_L = new System.Windows.Forms.TextBox();
            this.labelfuckyou = new System.Windows.Forms.Label();
            this.inputBox_START = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.inputBox_Z = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Detect Keyboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCurrentKb
            // 
            this.labelCurrentKb.AutoSize = true;
            this.labelCurrentKb.ForeColor = System.Drawing.Color.White;
            this.labelCurrentKb.Location = new System.Drawing.Point(12, 23);
            this.labelCurrentKb.Name = "labelCurrentKb";
            this.labelCurrentKb.Size = new System.Drawing.Size(121, 13);
            this.labelCurrentKb.TabIndex = 1;
            this.labelCurrentKb.Text = "Current Keyboard: None";
            // 
            // vJoyBox
            // 
            this.vJoyBox.AutoSize = true;
            this.vJoyBox.ForeColor = System.Drawing.Color.White;
            this.vJoyBox.Location = new System.Drawing.Point(15, 48);
            this.vJoyBox.Name = "vJoyBox";
            this.vJoyBox.Size = new System.Drawing.Size(223, 17);
            this.vJoyBox.TabIndex = 2;
            this.vJoyBox.Text = "Enable vJoy Redirecting for this Keyboard";
            this.vJoyBox.UseVisualStyleBackColor = true;
            this.vJoyBox.CheckedChanged += new System.EventHandler(this.vJoyBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Left Stick";
            // 
            // inputBox_LSUP
            // 
            this.inputBox_LSUP.Location = new System.Drawing.Point(101, 105);
            this.inputBox_LSUP.Name = "inputBox_LSUP";
            this.inputBox_LSUP.ReadOnly = true;
            this.inputBox_LSUP.Size = new System.Drawing.Size(20, 20);
            this.inputBox_LSUP.TabIndex = 4;
            this.inputBox_LSUP.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // inputBox_LSRIGHT
            // 
            this.inputBox_LSRIGHT.Location = new System.Drawing.Point(127, 129);
            this.inputBox_LSRIGHT.Name = "inputBox_LSRIGHT";
            this.inputBox_LSRIGHT.ReadOnly = true;
            this.inputBox_LSRIGHT.Size = new System.Drawing.Size(20, 20);
            this.inputBox_LSRIGHT.TabIndex = 5;
            this.inputBox_LSRIGHT.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // inputBox_LSLEFT
            // 
            this.inputBox_LSLEFT.Location = new System.Drawing.Point(77, 130);
            this.inputBox_LSLEFT.Name = "inputBox_LSLEFT";
            this.inputBox_LSLEFT.ReadOnly = true;
            this.inputBox_LSLEFT.Size = new System.Drawing.Size(20, 20);
            this.inputBox_LSLEFT.TabIndex = 6;
            this.inputBox_LSLEFT.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // inputBox_LSDOWN
            // 
            this.inputBox_LSDOWN.Location = new System.Drawing.Point(101, 156);
            this.inputBox_LSDOWN.Name = "inputBox_LSDOWN";
            this.inputBox_LSDOWN.ReadOnly = true;
            this.inputBox_LSDOWN.Size = new System.Drawing.Size(20, 20);
            this.inputBox_LSDOWN.TabIndex = 7;
            this.inputBox_LSDOWN.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // inputBox_RSDOWN
            // 
            this.inputBox_RSDOWN.Location = new System.Drawing.Point(101, 264);
            this.inputBox_RSDOWN.Name = "inputBox_RSDOWN";
            this.inputBox_RSDOWN.ReadOnly = true;
            this.inputBox_RSDOWN.Size = new System.Drawing.Size(20, 20);
            this.inputBox_RSDOWN.TabIndex = 12;
            this.inputBox_RSDOWN.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // inputBox_RSLEFT
            // 
            this.inputBox_RSLEFT.Location = new System.Drawing.Point(77, 238);
            this.inputBox_RSLEFT.Name = "inputBox_RSLEFT";
            this.inputBox_RSLEFT.ReadOnly = true;
            this.inputBox_RSLEFT.Size = new System.Drawing.Size(20, 20);
            this.inputBox_RSLEFT.TabIndex = 11;
            this.inputBox_RSLEFT.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // inputBox_RSRIGHT
            // 
            this.inputBox_RSRIGHT.Location = new System.Drawing.Point(127, 237);
            this.inputBox_RSRIGHT.Name = "inputBox_RSRIGHT";
            this.inputBox_RSRIGHT.ReadOnly = true;
            this.inputBox_RSRIGHT.Size = new System.Drawing.Size(20, 20);
            this.inputBox_RSRIGHT.TabIndex = 10;
            this.inputBox_RSRIGHT.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // inputBox_RSUP
            // 
            this.inputBox_RSUP.Location = new System.Drawing.Point(101, 213);
            this.inputBox_RSUP.Name = "inputBox_RSUP";
            this.inputBox_RSUP.ReadOnly = true;
            this.inputBox_RSUP.Size = new System.Drawing.Size(20, 20);
            this.inputBox_RSUP.TabIndex = 9;
            this.inputBox_RSUP.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "C - Stick";
            // 
            // inputBox_DDOWN
            // 
            this.inputBox_DDOWN.Location = new System.Drawing.Point(473, 105);
            this.inputBox_DDOWN.Name = "inputBox_DDOWN";
            this.inputBox_DDOWN.ReadOnly = true;
            this.inputBox_DDOWN.Size = new System.Drawing.Size(20, 20);
            this.inputBox_DDOWN.TabIndex = 17;
            this.inputBox_DDOWN.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // inputBox_DLEFT
            // 
            this.inputBox_DLEFT.Location = new System.Drawing.Point(77, 344);
            this.inputBox_DLEFT.Name = "inputBox_DLEFT";
            this.inputBox_DLEFT.ReadOnly = true;
            this.inputBox_DLEFT.Size = new System.Drawing.Size(20, 20);
            this.inputBox_DLEFT.TabIndex = 16;
            this.inputBox_DLEFT.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // inputBox_DRIGHT
            // 
            this.inputBox_DRIGHT.Location = new System.Drawing.Point(127, 343);
            this.inputBox_DRIGHT.Name = "inputBox_DRIGHT";
            this.inputBox_DRIGHT.ReadOnly = true;
            this.inputBox_DRIGHT.Size = new System.Drawing.Size(20, 20);
            this.inputBox_DRIGHT.TabIndex = 15;
            this.inputBox_DRIGHT.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // inputBox_DUP
            // 
            this.inputBox_DUP.Location = new System.Drawing.Point(101, 319);
            this.inputBox_DUP.Name = "inputBox_DUP";
            this.inputBox_DUP.ReadOnly = true;
            this.inputBox_DUP.Size = new System.Drawing.Size(20, 20);
            this.inputBox_DUP.TabIndex = 14;
            this.inputBox_DUP.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "D-Pad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(162, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "LS Modifier:";
            // 
            // inputBox_LSMOD
            // 
            this.inputBox_LSMOD.Location = new System.Drawing.Point(231, 130);
            this.inputBox_LSMOD.Name = "inputBox_LSMOD";
            this.inputBox_LSMOD.ReadOnly = true;
            this.inputBox_LSMOD.Size = new System.Drawing.Size(20, 20);
            this.inputBox_LSMOD.TabIndex = 19;
            this.inputBox_LSMOD.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(447, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "A: ";
            // 
            // inputBox_A
            // 
            this.inputBox_A.Location = new System.Drawing.Point(473, 134);
            this.inputBox_A.Name = "inputBox_A";
            this.inputBox_A.ReadOnly = true;
            this.inputBox_A.Size = new System.Drawing.Size(20, 20);
            this.inputBox_A.TabIndex = 23;
            this.inputBox_A.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // inputBox_B
            // 
            this.inputBox_B.Location = new System.Drawing.Point(473, 169);
            this.inputBox_B.Name = "inputBox_B";
            this.inputBox_B.ReadOnly = true;
            this.inputBox_B.Size = new System.Drawing.Size(20, 20);
            this.inputBox_B.TabIndex = 25;
            this.inputBox_B.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(447, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "B: ";
            // 
            // inputBox_X
            // 
            this.inputBox_X.Location = new System.Drawing.Point(473, 204);
            this.inputBox_X.Name = "inputBox_X";
            this.inputBox_X.ReadOnly = true;
            this.inputBox_X.Size = new System.Drawing.Size(20, 20);
            this.inputBox_X.TabIndex = 27;
            this.inputBox_X.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(447, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "X: ";
            // 
            // inputBox_Y
            // 
            this.inputBox_Y.Location = new System.Drawing.Point(473, 238);
            this.inputBox_Y.Name = "inputBox_Y";
            this.inputBox_Y.ReadOnly = true;
            this.inputBox_Y.Size = new System.Drawing.Size(20, 20);
            this.inputBox_Y.TabIndex = 29;
            this.inputBox_Y.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(447, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Y: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 425);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 38;
            // 
            // LSAutorunBox
            // 
            this.LSAutorunBox.AutoSize = true;
            this.LSAutorunBox.ForeColor = System.Drawing.Color.White;
            this.LSAutorunBox.Location = new System.Drawing.Point(257, 133);
            this.LSAutorunBox.Name = "LSAutorunBox";
            this.LSAutorunBox.Size = new System.Drawing.Size(71, 17);
            this.LSAutorunBox.TabIndex = 39;
            this.LSAutorunBox.Text = "Auto-Run";
            this.LSAutorunBox.UseVisualStyleBackColor = true;
            this.LSAutorunBox.CheckedChanged += new System.EventHandler(this.LSAutorunBox_CheckedChanged);
            // 
            // inputBox_R
            // 
            this.inputBox_R.Location = new System.Drawing.Point(473, 308);
            this.inputBox_R.Name = "inputBox_R";
            this.inputBox_R.ReadOnly = true;
            this.inputBox_R.Size = new System.Drawing.Size(20, 20);
            this.inputBox_R.TabIndex = 46;
            this.inputBox_R.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(447, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "R: ";
            // 
            // inputBox_L
            // 
            this.inputBox_L.Location = new System.Drawing.Point(473, 274);
            this.inputBox_L.Name = "inputBox_L";
            this.inputBox_L.ReadOnly = true;
            this.inputBox_L.Size = new System.Drawing.Size(20, 20);
            this.inputBox_L.TabIndex = 44;
            this.inputBox_L.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // labelfuckyou
            // 
            this.labelfuckyou.AutoSize = true;
            this.labelfuckyou.ForeColor = System.Drawing.Color.White;
            this.labelfuckyou.Location = new System.Drawing.Point(447, 277);
            this.labelfuckyou.Name = "labelfuckyou";
            this.labelfuckyou.Size = new System.Drawing.Size(19, 13);
            this.labelfuckyou.TabIndex = 43;
            this.labelfuckyou.Text = "L: ";
            // 
            // inputBox_START
            // 
            this.inputBox_START.Location = new System.Drawing.Point(473, 377);
            this.inputBox_START.Name = "inputBox_START";
            this.inputBox_START.ReadOnly = true;
            this.inputBox_START.Size = new System.Drawing.Size(20, 20);
            this.inputBox_START.TabIndex = 50;
            this.inputBox_START.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(419, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "START: ";
            // 
            // inputBox_Z
            // 
            this.inputBox_Z.Location = new System.Drawing.Point(473, 343);
            this.inputBox_Z.Name = "inputBox_Z";
            this.inputBox_Z.ReadOnly = true;
            this.inputBox_Z.Size = new System.Drawing.Size(20, 20);
            this.inputBox_Z.TabIndex = 48;
            this.inputBox_Z.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(447, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Z: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(428, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "VIEW:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 384);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(360, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "Note: D-Pad Down does not exist due to it being used as the VIEW button.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.inputBox_START);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.inputBox_Z);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.inputBox_R);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.inputBox_L);
            this.Controls.Add(this.labelfuckyou);
            this.Controls.Add(this.LSAutorunBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.inputBox_Y);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.inputBox_X);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inputBox_B);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputBox_A);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputBox_LSMOD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputBox_DDOWN);
            this.Controls.Add(this.inputBox_DLEFT);
            this.Controls.Add(this.inputBox_DRIGHT);
            this.Controls.Add(this.inputBox_DUP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputBox_RSDOWN);
            this.Controls.Add(this.inputBox_RSLEFT);
            this.Controls.Add(this.inputBox_RSRIGHT);
            this.Controls.Add(this.inputBox_RSUP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputBox_LSDOWN);
            this.Controls.Add(this.inputBox_LSLEFT);
            this.Controls.Add(this.inputBox_LSRIGHT);
            this.Controls.Add(this.inputBox_LSUP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vJoyBox);
            this.Controls.Add(this.labelCurrentKb);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "RoA Keyboard Redirector v0.1 - Alpha Build";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCurrentKb;
        private System.Windows.Forms.CheckBox vJoyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox_LSUP;
        private System.Windows.Forms.TextBox inputBox_LSRIGHT;
        private System.Windows.Forms.TextBox inputBox_LSLEFT;
        private System.Windows.Forms.TextBox inputBox_LSDOWN;
        private System.Windows.Forms.TextBox inputBox_RSDOWN;
        private System.Windows.Forms.TextBox inputBox_RSLEFT;
        private System.Windows.Forms.TextBox inputBox_RSRIGHT;
        private System.Windows.Forms.TextBox inputBox_RSUP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputBox_DDOWN;
        private System.Windows.Forms.TextBox inputBox_DLEFT;
        private System.Windows.Forms.TextBox inputBox_DRIGHT;
        private System.Windows.Forms.TextBox inputBox_DUP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputBox_LSMOD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputBox_A;
        private System.Windows.Forms.TextBox inputBox_B;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputBox_X;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputBox_Y;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox LSAutorunBox;
        private System.Windows.Forms.TextBox inputBox_R;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inputBox_L;
        private System.Windows.Forms.Label labelfuckyou;
        private System.Windows.Forms.TextBox inputBox_START;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox inputBox_Z;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
    }
}

