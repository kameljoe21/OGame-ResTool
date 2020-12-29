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
			this.levelInput2 = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.multiplierInput = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.levelInput = new System.Windows.Forms.TextBox();
			this.mineDropdown = new System.Windows.Forms.ComboBox();
			this.researchDropdown = new System.Windows.Forms.ComboBox();
			this.metalConversion = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.crystalConversion = new System.Windows.Forms.TextBox();
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
			this.deutConversion = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 621);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(799, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "Based on Hykage\'s Res Calc for Deut Conversion, in collaboration with kameljoe2 \r" +
    "\nTimendainum was here... YEET!";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(11, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Metal";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Crystal";
			// 
			// currentMetal
			// 
			this.currentMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentMetal.Location = new System.Drawing.Point(94, 40);
			this.currentMetal.Name = "currentMetal";
			this.currentMetal.Size = new System.Drawing.Size(187, 31);
			this.currentMetal.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(11, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 25);
			this.label4.TabIndex = 4;
			this.label4.Text = "Deut";
			// 
			// currentCrystal
			// 
			this.currentCrystal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentCrystal.Location = new System.Drawing.Point(94, 77);
			this.currentCrystal.Name = "currentCrystal";
			this.currentCrystal.Size = new System.Drawing.Size(187, 31);
			this.currentCrystal.TabIndex = 2;
			// 
			// currentDeut
			// 
			this.currentDeut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentDeut.Location = new System.Drawing.Point(94, 114);
			this.currentDeut.Name = "currentDeut";
			this.currentDeut.Size = new System.Drawing.Size(187, 31);
			this.currentDeut.TabIndex = 3;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(6, 35);
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
			this.radioButton2.Location = new System.Drawing.Point(6, 72);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(107, 29);
			this.radioButton2.TabIndex = 7;
			this.radioButton2.Text = "Building";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(6, 113);
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
			this.buildingDropdown.Location = new System.Drawing.Point(128, 73);
			this.buildingDropdown.MaxDropDownItems = 25;
			this.buildingDropdown.Name = "buildingDropdown";
			this.buildingDropdown.Size = new System.Drawing.Size(292, 33);
			this.buildingDropdown.TabIndex = 10;
			// 
			// groupBox1
			// 
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
			this.groupBox1.Location = new System.Drawing.Point(17, 193);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(771, 163);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "What to build";
			// 
			// levelInput2
			// 
			this.levelInput2.Enabled = false;
			this.levelInput2.Location = new System.Drawing.Point(647, 34);
			this.levelInput2.Name = "levelInput2";
			this.levelInput2.Size = new System.Drawing.Size(110, 31);
			this.levelInput2.TabIndex = 18;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(436, 112);
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
			this.label10.Location = new System.Drawing.Point(426, 77);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(99, 25);
			this.label10.TabIndex = 16;
			this.label10.Text = "Multiplier";
			// 
			// multiplierInput
			// 
			this.multiplierInput.Location = new System.Drawing.Point(531, 71);
			this.multiplierInput.Name = "multiplierInput";
			this.multiplierInput.Size = new System.Drawing.Size(110, 31);
			this.multiplierInput.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(426, 43);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 25);
			this.label5.TabIndex = 14;
			this.label5.Text = "Level";
			// 
			// levelInput
			// 
			this.levelInput.Location = new System.Drawing.Point(531, 34);
			this.levelInput.Name = "levelInput";
			this.levelInput.Size = new System.Drawing.Size(110, 31);
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
			this.mineDropdown.Location = new System.Drawing.Point(128, 34);
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
			this.researchDropdown.Location = new System.Drawing.Point(128, 112);
			this.researchDropdown.MaxDropDownItems = 25;
			this.researchDropdown.Name = "researchDropdown";
			this.researchDropdown.Size = new System.Drawing.Size(292, 33);
			this.researchDropdown.TabIndex = 11;
			// 
			// metalConversion
			// 
			this.metalConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.metalConversion.Location = new System.Drawing.Point(292, 40);
			this.metalConversion.Name = "metalConversion";
			this.metalConversion.Size = new System.Drawing.Size(60, 31);
			this.metalConversion.TabIndex = 4;
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
			// crystalConversion
			// 
			this.crystalConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.crystalConversion.Location = new System.Drawing.Point(292, 77);
			this.crystalConversion.Name = "crystalConversion";
			this.crystalConversion.Size = new System.Drawing.Size(60, 31);
			this.crystalConversion.TabIndex = 5;
			// 
			// traderCostLabel
			// 
			this.traderCostLabel.AutoSize = true;
			this.traderCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.traderCostLabel.Location = new System.Drawing.Point(443, 496);
			this.traderCostLabel.Name = "traderCostLabel";
			this.traderCostLabel.Size = new System.Drawing.Size(116, 25);
			this.traderCostLabel.TabIndex = 16;
			this.traderCostLabel.Text = "Deut Cost";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(12, 496);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 25);
			this.label9.TabIndex = 17;
			this.label9.Text = "Shortfall";
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
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(847, 621);
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
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(12, 359);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(105, 25);
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
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(443, 359);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(116, 25);
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
			this.radioButton6.Location = new System.Drawing.Point(5, 102);
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
			this.radioButton5.Location = new System.Drawing.Point(5, 65);
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
			this.radioButton4.Location = new System.Drawing.Point(5, 31);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(83, 29);
			this.radioButton4.TabIndex = 0;
			this.radioButton4.Text = "Metal";
			this.radioButton4.UseVisualStyleBackColor = true;
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// deutConversion
			// 
			this.deutConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deutConversion.Location = new System.Drawing.Point(292, 114);
			this.deutConversion.Name = "deutConversion";
			this.deutConversion.ReadOnly = true;
			this.deutConversion.Size = new System.Drawing.Size(60, 31);
			this.deutConversion.TabIndex = 40;
			this.deutConversion.Text = "1";
			// 
			// Form1
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1045, 680);
			this.Controls.Add(this.deutConversion);
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
			this.Controls.Add(this.crystalConversion);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.metalConversion);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.currentDeut);
			this.Controls.Add(this.currentCrystal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.currentMetal);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Horcon\'s Res Calc";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox metalConversion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox crystalConversion;
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
        private System.Windows.Forms.TextBox deutConversion;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox levelInput2;
    }
}

