namespace WinFormArenaGame
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnNewGame = new Button();
            tbKnight = new TextBox();
            tbAssassin = new TextBox();
            imgFight = new PictureBox();
            lbWinner = new Label();
            label1 = new Label();
            label2 = new Label();
            TbDio = new TextBox();
            TBDriver = new TextBox();
            KA = new RadioButton();
            AA = new RadioButton();
            DA = new RadioButton();
            DRA = new RadioButton();
            DRB = new RadioButton();
            DB = new RadioButton();
            AB = new RadioButton();
            KB = new RadioButton();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgFight).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(590, 29);
            btnNewGame.Margin = new Padding(3, 2, 3, 2);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(97, 22);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // tbKnight
            // 
            tbKnight.Location = new Point(3, 79);
            tbKnight.Margin = new Padding(3, 2, 3, 2);
            tbKnight.Multiline = true;
            tbKnight.Name = "tbKnight";
            tbKnight.Size = new Size(490, 132);
            tbKnight.TabIndex = 1;
            // 
            // tbAssassin
            // 
            tbAssassin.Location = new Point(797, 86);
            tbAssassin.Margin = new Padding(3, 2, 3, 2);
            tbAssassin.Multiline = true;
            tbAssassin.Name = "tbAssassin";
            tbAssassin.Size = new Size(490, 125);
            tbAssassin.TabIndex = 2;
            tbAssassin.TextChanged += tbAssassin_TextChanged;
            // 
            // imgFight
            // 
            imgFight.Enabled = false;
            imgFight.Image = (Image)resources.GetObject("imgFight.Image");
            imgFight.Location = new Point(556, 293);
            imgFight.Margin = new Padding(3, 2, 3, 2);
            imgFight.Name = "imgFight";
            imgFight.Size = new Size(180, 100);
            imgFight.TabIndex = 3;
            imgFight.TabStop = false;
            // 
            // lbWinner
            // 
            lbWinner.Location = new Point(568, 104);
            lbWinner.Name = "lbWinner";
            lbWinner.Size = new Size(150, 67);
            lbWinner.TabIndex = 4;
            lbWinner.Visible = false;
            lbWinner.Click += lbWinner_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(734, 131);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "HeroB:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(499, 131);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 6;
            label2.Text = "HeroA:";
            label2.Click += label2_Click;
            // 
            // TbDio
            // 
            TbDio.Location = new Point(797, 242);
            TbDio.Margin = new Padding(3, 2, 3, 2);
            TbDio.Multiline = true;
            TbDio.Name = "TbDio";
            TbDio.Size = new Size(490, 151);
            TbDio.TabIndex = 7;
            TbDio.TextChanged += TbDio_TextChanged;
            // 
            // TBDriver
            // 
            TBDriver.Location = new Point(3, 242);
            TBDriver.Margin = new Padding(3, 2, 3, 2);
            TBDriver.Multiline = true;
            TBDriver.Name = "TBDriver";
            TBDriver.Size = new Size(490, 151);
            TBDriver.TabIndex = 8;
            // 
            // KA
            // 
            KA.AutoSize = true;
            KA.Checked = true;
            KA.Location = new Point(20, 25);
            KA.Name = "KA";
            KA.Size = new Size(60, 19);
            KA.TabIndex = 9;
            KA.TabStop = true;
            KA.Text = "Knight";
            KA.UseVisualStyleBackColor = true;
            KA.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // AA
            // 
            AA.AutoSize = true;
            AA.Location = new Point(20, 50);
            AA.Name = "AA";
            AA.Size = new Size(69, 19);
            AA.TabIndex = 10;
            AA.Text = "Assassin";
            AA.UseVisualStyleBackColor = true;
            AA.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // DA
            // 
            DA.AutoSize = true;
            DA.Location = new Point(20, 75);
            DA.Name = "DA";
            DA.Size = new Size(43, 19);
            DA.TabIndex = 11;
            DA.Text = "Dio";
            DA.UseVisualStyleBackColor = true;
            // 
            // DRA
            // 
            DRA.AutoSize = true;
            DRA.Location = new Point(21, 100);
            DRA.Name = "DRA";
            DRA.Size = new Size(56, 19);
            DRA.TabIndex = 12;
            DRA.Text = "Driver";
            DRA.UseVisualStyleBackColor = true;
            // 
            // DRB
            // 
            DRB.AutoSize = true;
            DRB.Location = new Point(17, 97);
            DRB.Name = "DRB";
            DRB.Size = new Size(56, 19);
            DRB.TabIndex = 16;
            DRB.Text = "Driver";
            DRB.UseVisualStyleBackColor = true;
            // 
            // DB
            // 
            DB.AutoSize = true;
            DB.Location = new Point(16, 72);
            DB.Name = "DB";
            DB.Size = new Size(43, 19);
            DB.TabIndex = 15;
            DB.Text = "Dio";
            DB.UseVisualStyleBackColor = true;
            // 
            // AB
            // 
            AB.AutoSize = true;
            AB.Location = new Point(16, 47);
            AB.Name = "AB";
            AB.Size = new Size(69, 19);
            AB.TabIndex = 14;
            AB.Text = "Assassin";
            AB.UseVisualStyleBackColor = true;
            // 
            // KB
            // 
            KB.AutoSize = true;
            KB.Checked = true;
            KB.Location = new Point(16, 22);
            KB.Name = "KB";
            KB.Size = new Size(60, 19);
            KB.TabIndex = 13;
            KB.TabStop = true;
            KB.Text = "Knight";
            KB.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(510, 146);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 17;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(744, 146);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 18;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(538, 86);
            label3.Name = "label3";
            label3.Size = new Size(198, 15);
            label3.TabIndex = 19;
            label3.Text = "on -Firearm/Medieval weapons - off";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(KA);
            groupBox1.Controls.Add(AA);
            groupBox1.Controls.Add(DA);
            groupBox1.Controls.Add(DRA);
            groupBox1.Location = new Point(499, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(91, 122);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(KB);
            groupBox2.Controls.Add(AB);
            groupBox2.Controls.Add(DB);
            groupBox2.Controls.Add(DRB);
            groupBox2.Location = new Point(700, 166);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(91, 122);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 62);
            label4.Name = "label4";
            label4.Size = new Size(714, 15);
            label4.TabIndex = 22;
            label4.Text = "Only Knight and Assassin have a choise between basic weapon (sword,dagger) and revolver type Smith & Wesson Bodyguard Model 638";
            label4.Click += label4_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 445);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(TBDriver);
            Controls.Add(TbDio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbWinner);
            Controls.Add(imgFight);
            Controls.Add(tbAssassin);
            Controls.Add(tbKnight);
            Controls.Add(btnNewGame);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Arena Game";
            ((System.ComponentModel.ISupportInitialize)imgFight).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewGame;
        private TextBox tbKnight;
        private TextBox tbAssassin;
        private PictureBox imgFight;
        private Label lbWinner;
        private Label label1;
        private Label label2;
        private TextBox TbDio;
        private TextBox TBDriver;
        private RadioButton KA;
        private RadioButton AA;
        private RadioButton DA;
        private RadioButton DRA;
        private RadioButton DRB;
        private RadioButton DB;
        private RadioButton AB;
        private RadioButton KB;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label3;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
    }
}