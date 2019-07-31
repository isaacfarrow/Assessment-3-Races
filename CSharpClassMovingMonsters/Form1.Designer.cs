namespace CSharpClassMovingMonsters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBets = new System.Windows.Forms.Button();
            this.lblMaxBet = new System.Windows.Forms.Label();
            this.rbHoward = new System.Windows.Forms.RadioButton();
            this.rbJohn = new System.Windows.Forms.RadioButton();
            this.rbSusan = new System.Windows.Forms.RadioButton();
            this.udBet = new System.Windows.Forms.NumericUpDown();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.udMonkey = new System.Windows.Forms.NumericUpDown();
            this.lblBets = new System.Windows.Forms.Label();
            this.lblMonkey = new System.Windows.Forms.Label();
            this.txtHoward = new System.Windows.Forms.TextBox();
            this.txtJohn = new System.Windows.Forms.TextBox();
            this.txtSusan = new System.Windows.Forms.TextBox();
            this.lblHCash = new System.Windows.Forms.Label();
            this.lblJCash = new System.Windows.Forms.Label();
            this.lblSCash = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMonkey)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(423, 312);
            this.btnStart.Margin = new System.Windows.Forms.Padding(1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 44);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(423, 358);
            this.btnReset.Margin = new System.Windows.Forms.Padding(1);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 44);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset The Monkeys";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnBets
            // 
            this.btnBets.Location = new System.Drawing.Point(592, 391);
            this.btnBets.Margin = new System.Windows.Forms.Padding(1);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(164, 31);
            this.btnBets.TabIndex = 6;
            this.btnBets.Text = "Bet";
            this.btnBets.UseVisualStyleBackColor = true;
            this.btnBets.Click += new System.EventHandler(this.BtnBets_Click);
            // 
            // lblMaxBet
            // 
            this.lblMaxBet.AutoSize = true;
            this.lblMaxBet.Location = new System.Drawing.Point(7, 316);
            this.lblMaxBet.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMaxBet.Name = "lblMaxBet";
            this.lblMaxBet.Size = new System.Drawing.Size(35, 13);
            this.lblMaxBet.TabIndex = 7;
            this.lblMaxBet.Text = "label1";
            // 
            // rbHoward
            // 
            this.rbHoward.AutoSize = true;
            this.rbHoward.Location = new System.Drawing.Point(11, 344);
            this.rbHoward.Margin = new System.Windows.Forms.Padding(2);
            this.rbHoward.Name = "rbHoward";
            this.rbHoward.Size = new System.Drawing.Size(62, 17);
            this.rbHoward.TabIndex = 8;
            this.rbHoward.TabStop = true;
            this.rbHoward.Text = "Howard";
            this.rbHoward.UseVisualStyleBackColor = true;
            this.rbHoward.CheckedChanged += new System.EventHandler(this.AllRB_CheckedChanged);
            // 
            // rbJohn
            // 
            this.rbJohn.AutoSize = true;
            this.rbJohn.Location = new System.Drawing.Point(11, 395);
            this.rbJohn.Margin = new System.Windows.Forms.Padding(2);
            this.rbJohn.Name = "rbJohn";
            this.rbJohn.Size = new System.Drawing.Size(48, 17);
            this.rbJohn.TabIndex = 9;
            this.rbJohn.TabStop = true;
            this.rbJohn.Text = "John";
            this.rbJohn.UseVisualStyleBackColor = true;
            this.rbJohn.CheckedChanged += new System.EventHandler(this.AllRB_CheckedChanged);
            // 
            // rbSusan
            // 
            this.rbSusan.AutoSize = true;
            this.rbSusan.Location = new System.Drawing.Point(11, 370);
            this.rbSusan.Margin = new System.Windows.Forms.Padding(2);
            this.rbSusan.Name = "rbSusan";
            this.rbSusan.Size = new System.Drawing.Size(55, 17);
            this.rbSusan.TabIndex = 10;
            this.rbSusan.TabStop = true;
            this.rbSusan.Text = "Susan";
            this.rbSusan.UseVisualStyleBackColor = true;
            this.rbSusan.CheckedChanged += new System.EventHandler(this.AllRB_CheckedChanged);
            // 
            // udBet
            // 
            this.udBet.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udBet.Location = new System.Drawing.Point(676, 334);
            this.udBet.Margin = new System.Windows.Forms.Padding(2);
            this.udBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udBet.Name = "udBet";
            this.udBet.Size = new System.Drawing.Size(80, 20);
            this.udBet.TabIndex = 12;
            this.udBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Transparent;
            this.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb4.Location = new System.Drawing.Point(10, 237);
            this.pb4.Margin = new System.Windows.Forms.Padding(1);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(59, 70);
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Transparent;
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb3.Location = new System.Drawing.Point(10, 83);
            this.pb3.Margin = new System.Windows.Forms.Padding(1);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(59, 70);
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2.Location = new System.Drawing.Point(10, 157);
            this.pb2.Margin = new System.Windows.Forms.Padding(1);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(59, 70);
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Location = new System.Drawing.Point(10, 8);
            this.pb1.Margin = new System.Windows.Forms.Padding(1);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(59, 70);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // udMonkey
            // 
            this.udMonkey.Location = new System.Drawing.Point(676, 358);
            this.udMonkey.Margin = new System.Windows.Forms.Padding(2);
            this.udMonkey.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.udMonkey.Name = "udMonkey";
            this.udMonkey.Size = new System.Drawing.Size(80, 20);
            this.udMonkey.TabIndex = 14;
            // 
            // lblBets
            // 
            this.lblBets.AutoSize = true;
            this.lblBets.Location = new System.Drawing.Point(618, 336);
            this.lblBets.Name = "lblBets";
            this.lblBets.Size = new System.Drawing.Size(53, 13);
            this.lblBets.TabIndex = 15;
            this.lblBets.Text = "Bet        $";
            // 
            // lblMonkey
            // 
            this.lblMonkey.AutoSize = true;
            this.lblMonkey.Location = new System.Drawing.Point(589, 360);
            this.lblMonkey.Name = "lblMonkey";
            this.lblMonkey.Size = new System.Drawing.Size(82, 13);
            this.lblMonkey.TabIndex = 16;
            this.lblMonkey.Text = "Bet on Monkey:";
            // 
            // txtHoward
            // 
            this.txtHoward.Location = new System.Drawing.Point(137, 343);
            this.txtHoward.Name = "txtHoward";
            this.txtHoward.Size = new System.Drawing.Size(261, 20);
            this.txtHoward.TabIndex = 17;
            // 
            // txtJohn
            // 
            this.txtJohn.Location = new System.Drawing.Point(137, 394);
            this.txtJohn.Name = "txtJohn";
            this.txtJohn.Size = new System.Drawing.Size(261, 20);
            this.txtJohn.TabIndex = 18;
            // 
            // txtSusan
            // 
            this.txtSusan.Location = new System.Drawing.Point(137, 369);
            this.txtSusan.Name = "txtSusan";
            this.txtSusan.Size = new System.Drawing.Size(261, 20);
            this.txtSusan.TabIndex = 19;
            // 
            // lblHCash
            // 
            this.lblHCash.AutoSize = true;
            this.lblHCash.Location = new System.Drawing.Point(78, 346);
            this.lblHCash.Name = "lblHCash";
            this.lblHCash.Size = new System.Drawing.Size(35, 13);
            this.lblHCash.TabIndex = 20;
            this.lblHCash.Text = "label1";
            // 
            // lblJCash
            // 
            this.lblJCash.AutoSize = true;
            this.lblJCash.Location = new System.Drawing.Point(78, 397);
            this.lblJCash.Name = "lblJCash";
            this.lblJCash.Size = new System.Drawing.Size(35, 13);
            this.lblJCash.TabIndex = 21;
            this.lblJCash.Text = "label1";
            // 
            // lblSCash
            // 
            this.lblSCash.AutoSize = true;
            this.lblSCash.Location = new System.Drawing.Point(78, 372);
            this.lblSCash.Name = "lblSCash";
            this.lblSCash.Size = new System.Drawing.Size(35, 13);
            this.lblSCash.TabIndex = 22;
            this.lblSCash.Text = "label1";
            //            this.lblSCash.Click += new System.EventHandler(this.LblSCash_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 44);
            this.button1.TabIndex = 23;
            this.button1.Text = "Reset The Punters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSCash);
            this.Controls.Add(this.lblJCash);
            this.Controls.Add(this.lblHCash);
            this.Controls.Add(this.txtSusan);
            this.Controls.Add(this.txtJohn);
            this.Controls.Add(this.txtHoward);
            this.Controls.Add(this.lblMonkey);
            this.Controls.Add(this.lblBets);
            this.Controls.Add(this.udMonkey);
            this.Controls.Add(this.udBet);
            this.Controls.Add(this.rbSusan);
            this.Controls.Add(this.rbJohn);
            this.Controls.Add(this.rbHoward);
            this.Controls.Add(this.lblMaxBet);
            this.Controls.Add(this.btnBets);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.udBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMonkey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBets;
        private System.Windows.Forms.Label lblMaxBet;
        private System.Windows.Forms.RadioButton rbHoward;
        private System.Windows.Forms.RadioButton rbJohn;
        private System.Windows.Forms.RadioButton rbSusan;
        private System.Windows.Forms.NumericUpDown udBet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown udMonkey;
        private System.Windows.Forms.Label lblBets;
        private System.Windows.Forms.Label lblMonkey;
        private System.Windows.Forms.TextBox txtHoward;
        private System.Windows.Forms.TextBox txtJohn;
        private System.Windows.Forms.TextBox txtSusan;
        private System.Windows.Forms.Label lblHCash;
        private System.Windows.Forms.Label lblJCash;
        private System.Windows.Forms.Label lblSCash;
        private System.Windows.Forms.Button button1;
    }
}

