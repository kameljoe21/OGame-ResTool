namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentMetal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currentCrystal = new System.Windows.Forms.TextBox();
            this.currentDeut = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.buildingDropdown = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.multiplierInput5 = new System.Windows.Forms.TextBox();
            this.multiplierInput4 = new System.Windows.Forms.TextBox();
            this.multiplierInput3 = new System.Windows.Forms.TextBox();
            this.multiplierInput2 = new System.Windows.Forms.TextBox();
            this.levelInputTarget = new System.Windows.Forms.TextBox();
            this.levelInput4 = new System.Windows.Forms.TextBox();
            this.levelInput5 = new System.Windows.Forms.TextBox();
            this.levelInput3 = new System.Windows.Forms.TextBox();
            this.levelInput2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.multiplierInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.levelInput = new System.Windows.Forms.TextBox();
            this.mineDropdown = new System.Windows.Forms.ComboBox();
            this.researchDropdown = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.traderCostLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.metalCostResult = new System.Windows.Forms.Label();
            this.crystalCostResult = new System.Windows.Forms.Label();
            this.metalCostShortfall = new System.Windows.Forms.Label();
            this.crystalCostShortfall = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.deutCostShortfall = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.unitDeut = new System.Windows.Forms.Label();
            this.unitCrystal = new System.Windows.Forms.Label();
            this.unitMetal = new System.Windows.Forms.Label();
            this.totalDeut = new System.Windows.Forms.Label();
            this.totalCrystal = new System.Windows.Forms.Label();
            this.totalMetal = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.deutCostResult = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.numMetalConversion = new System.Windows.Forms.NumericUpDown();
            this.numCrystalConversion = new System.Windows.Forms.NumericUpDown();
            this.numDeuteriumConversion = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.keepDeut = new System.Windows.Forms.TextBox();
            this.keepCrystal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.keepMetal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMetalConversion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrystalConversion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeuteriumConversion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 646);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = " Hykage Horcon kameljoe21  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Metal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crystal";
            // 
            // currentMetal
            // 
            this.currentMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMetal.Location = new System.Drawing.Point(95, 32);
            this.currentMetal.Name = "currentMetal";
            this.currentMetal.Size = new System.Drawing.Size(187, 31);
            this.currentMetal.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Deut";
            // 
            // currentCrystal
            // 
            this.currentCrystal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCrystal.Location = new System.Drawing.Point(95, 69);
            this.currentCrystal.Name = "currentCrystal";
            this.currentCrystal.Size = new System.Drawing.Size(187, 31);
            this.currentCrystal.TabIndex = 2;
            // 
            // currentDeut
            // 
            this.currentDeut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDeut.Location = new System.Drawing.Point(95, 106);
            this.currentDeut.Name = "currentDeut";
            this.currentDeut.Size = new System.Drawing.Size(187, 31);
            this.currentDeut.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 29);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mine";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(0, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 29);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Building";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(0, 113);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(122, 29);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "Research";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // buildingDropdown
            // 
            this.buildingDropdown.FormattingEnabled = true;
            this.buildingDropdown.Items.AddRange(new object[] {
            "Robotics Factory",
            "Shipyard",
            "Research Lab",
            "Alliance Depot",
            "Missile Silo",
            "Nanite Factory",
            "Terraformer",
            "Space Dock",
            "Lunar Base",
            "Sensor Phalanx",
            "Jump Gate"});
            this.buildingDropdown.Location = new System.Drawing.Point(128, 70);
            this.buildingDropdown.MaxDropDownItems = 25;
            this.buildingDropdown.Name = "buildingDropdown";
            this.buildingDropdown.Size = new System.Drawing.Size(292, 33);
            this.buildingDropdown.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.multiplierInput5);
            this.groupBox1.Controls.Add(this.multiplierInput4);
            this.groupBox1.Controls.Add(this.multiplierInput3);
            this.groupBox1.Controls.Add(this.multiplierInput2);
            this.groupBox1.Controls.Add(this.levelInputTarget);
            this.groupBox1.Controls.Add(this.levelInput4);
            this.groupBox1.Controls.Add(this.levelInput5);
            this.groupBox1.Controls.Add(this.levelInput3);
            this.groupBox1.Controls.Add(this.levelInput2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.multiplierInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.levelInput);
            this.groupBox1.Controls.Add(this.mineDropdown);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.buildingDropdown);
            this.groupBox1.Controls.Add(this.researchDropdown);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 160);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What to build";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(602, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 25);
            this.label15.TabIndex = 27;
            this.label15.Text = "Target";
            // 
            // multiplierInput5
            // 
            this.multiplierInput5.Enabled = false;
            this.multiplierInput5.Location = new System.Drawing.Point(813, 58);
            this.multiplierInput5.Name = "multiplierInput5";
            this.multiplierInput5.Size = new System.Drawing.Size(65, 31);
            this.multiplierInput5.TabIndex = 26;
            // 
            // multiplierInput4
            // 
            this.multiplierInput4.Enabled = false;
            this.multiplierInput4.Location = new System.Drawing.Point(742, 58);
            this.multiplierInput4.Name = "multiplierInput4";
            this.multiplierInput4.Size = new System.Drawing.Size(65, 31);
            this.multiplierInput4.TabIndex = 25;
            // 
            // multiplierInput3
            // 
            this.multiplierInput3.Enabled = false;
            this.multiplierInput3.Location = new System.Drawing.Point(671, 58);
            this.multiplierInput3.Name = "multiplierInput3";
            this.multiplierInput3.Size = new System.Drawing.Size(65, 31);
            this.multiplierInput3.TabIndex = 24;
            // 
            // multiplierInput2
            // 
            this.multiplierInput2.Enabled = false;
            this.multiplierInput2.Location = new System.Drawing.Point(600, 58);
            this.multiplierInput2.Name = "multiplierInput2";
            this.multiplierInput2.Size = new System.Drawing.Size(65, 31);
            this.multiplierInput2.TabIndex = 23;
            // 
            // levelInputTarget
            // 
            this.levelInputTarget.Location = new System.Drawing.Point(682, 101);
            this.levelInputTarget.Name = "levelInputTarget";
            this.levelInputTarget.Size = new System.Drawing.Size(65, 31);
            this.levelInputTarget.TabIndex = 22;
            // 
            // levelInput4
            // 
            this.levelInput4.Enabled = false;
            this.levelInput4.Location = new System.Drawing.Point(742, 21);
            this.levelInput4.Name = "levelInput4";
            this.levelInput4.Size = new System.Drawing.Size(65, 31);
            this.levelInput4.TabIndex = 21;
            // 
            // levelInput5
            // 
            this.levelInput5.Enabled = false;
            this.levelInput5.Location = new System.Drawing.Point(813, 21);
            this.levelInput5.Name = "levelInput5";
            this.levelInput5.Size = new System.Drawing.Size(65, 31);
            this.levelInput5.TabIndex = 20;
            // 
            // levelInput3
            // 
            this.levelInput3.Enabled = false;
            this.levelInput3.Location = new System.Drawing.Point(671, 21);
            this.levelInput3.Name = "levelInput3";
            this.levelInput3.Size = new System.Drawing.Size(65, 31);
            this.levelInput3.TabIndex = 19;
            // 
            // levelInput2
            // 
            this.levelInput2.Enabled = false;
            this.levelInput2.Location = new System.Drawing.Point(600, 21);
            this.levelInput2.Name = "levelInput2";
            this.levelInput2.Size = new System.Drawing.Size(65, 31);
            this.levelInput2.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(436, 99);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 29);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Single/Range";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(426, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Multiplier";
            // 
            // multiplierInput
            // 
            this.multiplierInput.Location = new System.Drawing.Point(529, 58);
            this.multiplierInput.Name = "multiplierInput";
            this.multiplierInput.Size = new System.Drawing.Size(65, 31);
            this.multiplierInput.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Level";
            // 
            // levelInput
            // 
            this.levelInput.Enabled = false;
            this.levelInput.Location = new System.Drawing.Point(529, 21);
            this.levelInput.Name = "levelInput";
            this.levelInput.Size = new System.Drawing.Size(65, 31);
            this.levelInput.TabIndex = 12;
            // 
            // mineDropdown
            // 
            this.mineDropdown.FormattingEnabled = true;
            this.mineDropdown.Items.AddRange(new object[] {
            "Metal Mine",
            "Crystal Mine",
            "Deuterium Synthesizer",
            "Solar Plant",
            "Fusion Reactor",
            "Metal Storage",
            "Crystal Storage",
            "Deuterium Tank"});
            this.mineDropdown.Location = new System.Drawing.Point(128, 31);
            this.mineDropdown.MaxDropDownItems = 25;
            this.mineDropdown.Name = "mineDropdown";
            this.mineDropdown.Size = new System.Drawing.Size(292, 33);
            this.mineDropdown.TabIndex = 9;
            // 
            // researchDropdown
            // 
            this.researchDropdown.FormattingEnabled = true;
            this.researchDropdown.Items.AddRange(new object[] {
            "Energy Technology",
            "Laser Technology",
            "Ion Technology",
            "Hyperspace Technology",
            "Plasma Technology",
            "Espionage Technology",
            "Computer Technology",
            "Astrophysics",
            "Intergalactic Research Network",
            "Graviton Technology",
            "Combustion Drive",
            "Impulse Drive",
            "Hyperspace Drive",
            "Weapons Technology",
            "Shielding Technology",
            "Armor Technology"});
            this.researchDropdown.Location = new System.Drawing.Point(128, 109);
            this.researchDropdown.MaxDropDownItems = 25;
            this.researchDropdown.Name = "researchDropdown";
            this.researchDropdown.Size = new System.Drawing.Size(292, 33);
            this.researchDropdown.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Current Resources";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Conversion";
            // 
            // traderCostLabel
            // 
            this.traderCostLabel.AutoSize = true;
            this.traderCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traderCostLabel.Location = new System.Drawing.Point(443, 496);
            this.traderCostLabel.Name = "traderCostLabel";
            this.traderCostLabel.Size = new System.Drawing.Size(107, 25);
            this.traderCostLabel.TabIndex = 16;
            this.traderCostLabel.Text = "Deut Cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Shortfall / Leftover";
            // 
            // metalCostResult
            // 
            this.metalCostResult.AutoSize = true;
            this.metalCostResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metalCostResult.Location = new System.Drawing.Point(443, 521);
            this.metalCostResult.Name = "metalCostResult";
            this.metalCostResult.Size = new System.Drawing.Size(0, 25);
            this.metalCostResult.TabIndex = 18;
            // 
            // crystalCostResult
            // 
            this.crystalCostResult.AutoSize = true;
            this.crystalCostResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crystalCostResult.Location = new System.Drawing.Point(443, 546);
            this.crystalCostResult.Name = "crystalCostResult";
            this.crystalCostResult.Size = new System.Drawing.Size(0, 25);
            this.crystalCostResult.TabIndex = 19;
            // 
            // metalCostShortfall
            // 
            this.metalCostShortfall.AutoSize = true;
            this.metalCostShortfall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metalCostShortfall.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metalCostShortfall.Location = new System.Drawing.Point(12, 521);
            this.metalCostShortfall.Name = "metalCostShortfall";
            this.metalCostShortfall.Size = new System.Drawing.Size(65, 25);
            this.metalCostShortfall.TabIndex = 20;
            this.metalCostShortfall.Text = "Metal";
            // 
            // crystalCostShortfall
            // 
            this.crystalCostShortfall.AutoSize = true;
            this.crystalCostShortfall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crystalCostShortfall.Location = new System.Drawing.Point(12, 546);
            this.crystalCostShortfall.Name = "crystalCostShortfall";
            this.crystalCostShortfall.Size = new System.Drawing.Size(79, 25);
            this.crystalCostShortfall.TabIndex = 21;
            this.crystalCostShortfall.Text = "Crystal";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(856, 639);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Run the numbers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deutCostShortfall
            // 
            this.deutCostShortfall.AutoSize = true;
            this.deutCostShortfall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deutCostShortfall.Location = new System.Drawing.Point(12, 571);
            this.deutCostShortfall.Name = "deutCostShortfall";
            this.deutCostShortfall.Size = new System.Drawing.Size(57, 25);
            this.deutCostShortfall.TabIndex = 23;
            this.deutCostShortfall.Text = "Deut";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Unit cost";
            // 
            // unitDeut
            // 
            this.unitDeut.AutoSize = true;
            this.unitDeut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitDeut.Location = new System.Drawing.Point(12, 434);
            this.unitDeut.Name = "unitDeut";
            this.unitDeut.Size = new System.Drawing.Size(57, 25);
            this.unitDeut.TabIndex = 30;
            this.unitDeut.Text = "Deut";
            // 
            // unitCrystal
            // 
            this.unitCrystal.AutoSize = true;
            this.unitCrystal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitCrystal.Location = new System.Drawing.Point(12, 409);
            this.unitCrystal.Name = "unitCrystal";
            this.unitCrystal.Size = new System.Drawing.Size(79, 25);
            this.unitCrystal.TabIndex = 29;
            this.unitCrystal.Text = "Crystal";
            // 
            // unitMetal
            // 
            this.unitMetal.AutoSize = true;
            this.unitMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitMetal.Location = new System.Drawing.Point(12, 384);
            this.unitMetal.Name = "unitMetal";
            this.unitMetal.Size = new System.Drawing.Size(65, 25);
            this.unitMetal.TabIndex = 28;
            this.unitMetal.Text = "Metal";
            // 
            // totalDeut
            // 
            this.totalDeut.AutoSize = true;
            this.totalDeut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDeut.Location = new System.Drawing.Point(443, 434);
            this.totalDeut.Name = "totalDeut";
            this.totalDeut.Size = new System.Drawing.Size(57, 25);
            this.totalDeut.TabIndex = 37;
            this.totalDeut.Text = "Deut";
            // 
            // totalCrystal
            // 
            this.totalCrystal.AutoSize = true;
            this.totalCrystal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCrystal.Location = new System.Drawing.Point(443, 409);
            this.totalCrystal.Name = "totalCrystal";
            this.totalCrystal.Size = new System.Drawing.Size(79, 25);
            this.totalCrystal.TabIndex = 36;
            this.totalCrystal.Text = "Crystal";
            // 
            // totalMetal
            // 
            this.totalMetal.AutoSize = true;
            this.totalMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMetal.Location = new System.Drawing.Point(443, 384);
            this.totalMetal.Name = "totalMetal";
            this.totalMetal.Size = new System.Drawing.Size(65, 25);
            this.totalMetal.TabIndex = 35;
            this.totalMetal.Text = "Metal";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(444, 346);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 25);
            this.label21.TabIndex = 31;
            this.label21.Text = "Total cost";
            // 
            // deutCostResult
            // 
            this.deutCostResult.AutoSize = true;
            this.deutCostResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deutCostResult.Location = new System.Drawing.Point(443, 571);
            this.deutCostResult.Name = "deutCostResult";
            this.deutCostResult.Size = new System.Drawing.Size(72, 25);
            this.deutCostResult.TabIndex = 38;
            this.deutCostResult.Text = "Total: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(415, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 125);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convert From:";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 94);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(75, 29);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Deut";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 57);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(97, 29);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.Text = "Crystal";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 23);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(83, 29);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.Text = "Metal";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // numMetalConversion
            // 
            this.numMetalConversion.DecimalPlaces = 2;
            this.numMetalConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMetalConversion.Location = new System.Drawing.Point(293, 32);
            this.numMetalConversion.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMetalConversion.Name = "numMetalConversion";
            this.numMetalConversion.Size = new System.Drawing.Size(75, 31);
            this.numMetalConversion.TabIndex = 41;
            this.numMetalConversion.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numCrystalConversion
            // 
            this.numCrystalConversion.DecimalPlaces = 2;
            this.numCrystalConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCrystalConversion.Location = new System.Drawing.Point(293, 69);
            this.numCrystalConversion.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCrystalConversion.Name = "numCrystalConversion";
            this.numCrystalConversion.Size = new System.Drawing.Size(75, 31);
            this.numCrystalConversion.TabIndex = 42;
            this.numCrystalConversion.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numDeuteriumConversion
            // 
            this.numDeuteriumConversion.DecimalPlaces = 2;
            this.numDeuteriumConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDeuteriumConversion.Location = new System.Drawing.Point(293, 106);
            this.numDeuteriumConversion.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDeuteriumConversion.Name = "numDeuteriumConversion";
            this.numDeuteriumConversion.Size = new System.Drawing.Size(75, 31);
            this.numDeuteriumConversion.TabIndex = 43;
            this.numDeuteriumConversion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(674, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 50;
            this.label8.Text = "Keep on Hand";
            // 
            // keepDeut
            // 
            this.keepDeut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keepDeut.Location = new System.Drawing.Point(679, 106);
            this.keepDeut.Name = "keepDeut";
            this.keepDeut.Size = new System.Drawing.Size(187, 31);
            this.keepDeut.TabIndex = 48;
            // 
            // keepCrystal
            // 
            this.keepCrystal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keepCrystal.Location = new System.Drawing.Point(679, 69);
            this.keepCrystal.Name = "keepCrystal";
            this.keepCrystal.Size = new System.Drawing.Size(187, 31);
            this.keepCrystal.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(596, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 25);
            this.label12.TabIndex = 49;
            this.label12.Text = "Deut";
            // 
            // keepMetal
            // 
            this.keepMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keepMetal.Location = new System.Drawing.Point(679, 32);
            this.keepMetal.Name = "keepMetal";
            this.keepMetal.Size = new System.Drawing.Size(187, 31);
            this.keepMetal.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(596, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 25);
            this.label13.TabIndex = 47;
            this.label13.Text = "Crystal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(596, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 25);
            this.label14.TabIndex = 45;
            this.label14.Text = "Metal";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1045, 680);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.keepDeut);
            this.Controls.Add(this.keepCrystal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.keepMetal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numDeuteriumConversion);
            this.Controls.Add(this.numCrystalConversion);
            this.Controls.Add(this.numMetalConversion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.deutCostResult);
            this.Controls.Add(this.totalDeut);
            this.Controls.Add(this.totalCrystal);
            this.Controls.Add(this.totalMetal);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.unitDeut);
            this.Controls.Add(this.unitCrystal);
            this.Controls.Add(this.unitMetal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.deutCostShortfall);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crystalCostShortfall);
            this.Controls.Add(this.metalCostShortfall);
            this.Controls.Add(this.crystalCostResult);
            this.Controls.Add(this.metalCostResult);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.traderCostLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.currentDeut);
            this.Controls.Add(this.currentCrystal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.currentMetal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ogame Resource Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMetalConversion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrystalConversion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeuteriumConversion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currentMetal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currentCrystal;
        private System.Windows.Forms.TextBox currentDeut;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox buildingDropdown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox mineDropdown;
        private System.Windows.Forms.ComboBox researchDropdown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox levelInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label traderCostLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label metalCostResult;
        private System.Windows.Forms.Label crystalCostResult;
        private System.Windows.Forms.Label metalCostShortfall;
        private System.Windows.Forms.Label crystalCostShortfall;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox multiplierInput;
        private System.Windows.Forms.Label deutCostShortfall;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label unitDeut;
        private System.Windows.Forms.Label unitCrystal;
        private System.Windows.Forms.Label unitMetal;
        private System.Windows.Forms.Label totalDeut;
        private System.Windows.Forms.Label totalCrystal;
        private System.Windows.Forms.Label totalMetal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label deutCostResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox levelInput2;
        private System.Windows.Forms.NumericUpDown numMetalConversion;
        private System.Windows.Forms.NumericUpDown numCrystalConversion;
        private System.Windows.Forms.NumericUpDown numDeuteriumConversion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox keepDeut;
        private System.Windows.Forms.TextBox keepCrystal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox keepMetal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox multiplierInput5;
        private System.Windows.Forms.TextBox multiplierInput4;
        private System.Windows.Forms.TextBox multiplierInput3;
        private System.Windows.Forms.TextBox multiplierInput2;
        private System.Windows.Forms.TextBox levelInputTarget;
        private System.Windows.Forms.TextBox levelInput4;
        private System.Windows.Forms.TextBox levelInput5;
        private System.Windows.Forms.TextBox levelInput3;
    }
}

