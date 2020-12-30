using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            loadSettings();
        }

        int[,] mineValues = { { 60, 15, 0 }, { 48, 24, 0 }, { 225, 75, 0 }, { 75, 30, 0 }, { 900, 360, 180 }, { 1000, 0, 0 }, { 1000, 500, 0 }, { 1000, 1000, 0 } };
        int[,] buildingValues = { { 400,120,200} , { 400,200,100}, { 200, 400, 200 },  { 20000,40000,0}, { 20000, 20000, 1000 }, { 1000000,500000,100000}, {0,50000,100000},
        { 200,0,50}, {20000,40000,20000 }, { 20000,40000,20000}, { 2000000,4000000,2000000} };
        int[,] researchValues = { { 0,800,400}, { 200,100,0}, { 1000,300,100}, { 0,4000,2000}, { 2000, 4000, 2000 }, {200,1000,200}, { 0,400,600}, { 4000,8000,4000}, { 240000,400000,160000},
        { 0,0,0}, { 400,0,600}, { 2000,4000,600}, { 10000,20000,6000}, { 800,200,0}, {200,600,0 }, { 1000,0,0} };

        private void button1_Click(object sender, EventArgs e)
        {
            saveSettings();
            Int64 metal, crystal, deut, levelTarget, metalk, crystalk, deutk, tempInt;
            List<Int64> level = new List<long>();
            List<Int64> multiplier = new List<long>();
            //double metalConv, crystalConv, deutConv;
            double levelCostMultiplier = 2.0;
            String metalOriginal, crystalOriginal, deutOriginal /*,metalConversionOriginal, crystalConversionOriginal, deutConversionOriginal*/;
            String metalKeep, crystalKeep, deutKeep;
            metalOriginal = currentMetal.Text;
            metalOriginal = metalOriginal.Replace(".", String.Empty);
            metalOriginal = metalOriginal.Replace(",", String.Empty);
            metalOriginal = metalOriginal.Replace(" ", String.Empty);

            crystalOriginal = currentCrystal.Text;
            crystalOriginal = crystalOriginal.Replace(".", String.Empty);
            crystalOriginal = crystalOriginal.Replace(",", String.Empty);
            crystalOriginal = crystalOriginal.Replace(" ", String.Empty);

            deutOriginal = currentDeut.Text;
            deutOriginal = deutOriginal.Replace(".", String.Empty);
            deutOriginal = deutOriginal.Replace(",", String.Empty);
            deutOriginal = deutOriginal.Replace(" ", String.Empty);

            metalKeep = keepMetal.Text;
            metalKeep = metalKeep.Replace(".", String.Empty);
            metalKeep = metalKeep.Replace(",", String.Empty);
            metalKeep = metalKeep.Replace(" ", String.Empty);

            crystalKeep = keepCrystal.Text;
            crystalKeep = metalOriginal.Replace(".", String.Empty);
            crystalKeep = metalOriginal.Replace(",", String.Empty);
            crystalKeep = metalOriginal.Replace(" ", String.Empty);

            deutKeep = keepDeut.Text;
            deutKeep = deutKeep.Replace(".", String.Empty);
            deutKeep = deutKeep.Replace(",", String.Empty);
            deutKeep = deutKeep.Replace(" ", String.Empty);

            //metalConversionOriginal = metalConversion.Text;
            //metalConversionOriginal = metalConversionOriginal.Replace(".", ",");
            //metalConversionOriginal = metalConversionOriginal.Replace(" ", String.Empty);

            //crystalConversionOriginal = crystalConversion.Text;
            //crystalConversionOriginal = crystalConversionOriginal.Replace(".", ",");
            //crystalConversionOriginal = crystalConversionOriginal.Replace(" ", String.Empty);

            //deutConversionOriginal = deutConversion.Text;
            //deutConversionOriginal = deutConversionOriginal.Replace(".", ",");
            //deutConversionOriginal = deutConversionOriginal.Replace(" ", String.Empty);

            if (Int64.TryParse(metalOriginal, out metal))
            {

            }
            else
            {
                metal = 0;
            }
            if (Int64.TryParse(crystalOriginal, out crystal))
            {

            }
            else
            {
                crystal = 0;
            }
            if (Int64.TryParse(deutOriginal, out deut))
            {

            }
            else
            {
                deut = 0;
            }
            if (Int64.TryParse(metalKeep, out metalk))
            {

            }
            else
            {
                metalk = 0;
            }
            if (Int64.TryParse(crystalKeep, out crystalk))
            {

            }
            else
            {
                crystalk = 0;
            }
            if (Int64.TryParse(deutKeep, out deutk))
            {

            }
            else
            {
                deutk = 0;
            }
            metal -= metalk;
            crystal -= crystalk;
            deut -= deutk;


            //if (double.TryParse(metalConversionOriginal, out metalConv)) {

            //} else {
            //    metalConv = 1;
            //}
            //if (double.TryParse(crystalConversionOriginal, out crystalConv)) {

            //} else {
            //    crystalConv = 1;
            //}
            //if (double.TryParse(deutConversionOriginal, out deutConv)) {

            //} else {
            //    deutConv = 1;
            //}

            if (Int64.TryParse(levelInputTarget.Text, out levelTarget))
            {

            }
            else
            {
                levelTarget = 1;
            }

            if (Int64.TryParse(levelInput.Text, out tempInt))
            {
                level.Add(tempInt);
            }
            else
            {
                level.Add(levelTarget);
            }
            if (Int64.TryParse(levelInput2.Text, out tempInt))
            {
                level.Add(tempInt);
            }
            else
            {
                level.Add(levelTarget);
            }
            if (Int64.TryParse(levelInput3.Text, out tempInt))
            {
                level.Add(tempInt);
            }
            else
            {
                level.Add(levelTarget);
            }
            if (Int64.TryParse(levelInput4.Text, out tempInt))
            {
                level.Add(tempInt);
            }
            else
            {
                level.Add(levelTarget);
            }
            if (Int64.TryParse(levelInput5.Text, out tempInt))
            {
                level.Add(tempInt);
            }
            else
            {
                level.Add(levelTarget);
            }
            if (Int64.TryParse(multiplierInput.Text, out tempInt))
            {
                multiplier.Add(tempInt);
            }
            else
            {
                multiplier.Add(1);
            }
            if (Int64.TryParse(multiplierInput2.Text, out tempInt))
            {
                multiplier.Add(tempInt);
            }
            else
            {
                multiplier.Add(1);
            }
            if (Int64.TryParse(multiplierInput3.Text, out tempInt))
            {
                multiplier.Add(tempInt);
            }
            else
            {
                multiplier.Add(1);
            }
            if (Int64.TryParse(multiplierInput4.Text, out tempInt))
            {
                multiplier.Add(tempInt);
            }
            else
            {
                multiplier.Add(1);
            }
            if (Int64.TryParse(multiplierInput5.Text, out tempInt))
            {
                multiplier.Add(tempInt);
            }
            else
            {
                multiplier.Add(1);
            }
            Int64 selected = -1;
            Int64 metalCost, crystalCost, deutCost, metalShortfall, crystalShortfall, deutShortfall;
            Int64 baseMetal = 0, baseCrystal = 0, baseDeut = 0;
            Int64 baseMetal2 = 0, baseCrystal2 = 0, baseDeut2 = 0;
            if (radioButton1.Checked)
            {
                selected = mineDropdown.SelectedIndex;
                if (selected == 0 || selected == 2 || selected == 3)
                {
                    levelCostMultiplier = 1.5;
                }
                if (selected == 1)
                {
                    levelCostMultiplier = 1.6;
                }
                if (selected == 4)
                {
                    levelCostMultiplier = 1.8;
                }

                baseMetal = mineValues[selected, 0];
                baseCrystal = mineValues[selected, 1];
                baseDeut = mineValues[selected, 2];

            }
            else if (radioButton2.Checked)
            {
                selected = buildingDropdown.SelectedIndex;
                baseMetal = buildingValues[selected, 0];
                baseCrystal = buildingValues[selected, 1];
                baseDeut = buildingValues[selected, 2];

            }
            else if (radioButton3.Checked)
            {
                selected = researchDropdown.SelectedIndex;
                if (selected == 7)
                {
                    levelCostMultiplier = 1.75;
                }
                if (selected == 9)
                {
                    levelCostMultiplier = 3;
                }

                baseMetal = researchValues[selected, 0];
                baseCrystal = researchValues[selected, 1];
                baseDeut = researchValues[selected, 2];
            }
            metalShortfall = 0;
            crystalShortfall = 0;
            deutShortfall = 0;

            if (checkBox1.Checked)
            {
                for (int a = 0; a < level.Count; a++)
                {
                    Int64 baseMetalTemp = 0;
                    Int64 baseCrystalTemp = 0;
                    Int64 baseDeutTemp = 0;

                    for (long i = level[a]; i <= levelTarget; i++)
                    {
                        if (radioButton3.Checked && selected == 7)
                        {
                            baseMetalTemp += Convert.ToInt64(Math.Round(baseMetal * Math.Pow(levelCostMultiplier, i - 1) / 100d, 0d) * 100d);
                            baseCrystalTemp += Convert.ToInt64(Math.Round(baseCrystal * Math.Pow(levelCostMultiplier, i - 1) / 100d, 0d) * 100d);
                            baseDeutTemp += Convert.ToInt64(Math.Round(baseDeut * Math.Pow(levelCostMultiplier, i - 1) / 100d, 0d) * 100d);
                        }
                        else
                        {
                            baseMetalTemp += Convert.ToInt64(Math.Floor(baseMetal * Math.Pow(levelCostMultiplier, i - 1)));
                            baseCrystalTemp += Convert.ToInt64(Math.Floor(baseCrystal * Math.Pow(levelCostMultiplier, i - 1)));
                            baseDeutTemp += Convert.ToInt64(Math.Floor(baseDeut * Math.Pow(levelCostMultiplier, i - 1)));
                        }
                    }
                    baseMetal2 += baseMetalTemp * multiplier[a];
                    baseCrystal2 += baseCrystalTemp * multiplier[a];
                    baseDeut2 += baseDeutTemp * multiplier[a];

                }

                metalShortfall = baseMetal2;
                crystalShortfall = baseCrystal2;
                deutShortfall = baseDeut2;
            } else
            {
                if (radioButton3.Checked && selected == 7)
                {
                    baseMetal2 = Convert.ToInt64(Math.Round(baseMetal * Math.Pow(levelCostMultiplier, levelTarget - 1) / 100d, 0d) * 100d);
                    baseCrystal2 = Convert.ToInt64(Math.Round(baseCrystal * Math.Pow(levelCostMultiplier, levelTarget - 1) / 100d, 0d) * 100d);
                    baseDeut2 = Convert.ToInt64(Math.Round(baseDeut * Math.Pow(levelCostMultiplier, levelTarget - 1) / 100d, 0d) * 100d);
                }
                else
                {
                    baseMetal2 = Convert.ToInt64(Math.Floor(baseMetal * Math.Pow(levelCostMultiplier, levelTarget - 1)));
                    baseCrystal2 = Convert.ToInt64(Math.Floor(baseCrystal * Math.Pow(levelCostMultiplier, levelTarget - 1)));
                    baseDeut2 = Convert.ToInt64(Math.Floor(baseDeut * Math.Pow(levelCostMultiplier, levelTarget - 1)));
                }

                metalShortfall = baseMetal2 * multiplier[0];
                crystalShortfall = baseCrystal2 * multiplier[0];
                deutShortfall = baseDeut2 * multiplier[0];
            }




            metalShortfall -= metal;
            crystalShortfall -= crystal;
            deutShortfall -= deut;

            if (radioButton4.Checked)
            {
                crystalCost = Math.Max(Convert.ToInt64(Math.Ceiling(crystalShortfall / (numCrystalConversion.Value / numMetalConversion.Value))), 0);
                deutCost = Math.Max(Convert.ToInt64(Math.Ceiling(deutShortfall / (numDeuteriumConversion.Value / numMetalConversion.Value))), 0);

                metalCostResult.Text = "Crystal: " + crystalCost.ToString("N0");
                crystalCostResult.Text = "Deut: " + deutCost.ToString("N0");
                deutCostResult.Text = "Total: " + (deutCost + crystalCost).ToString("N0");

            }
            else if (radioButton5.Checked)
            {
                metalCost = Math.Max(Convert.ToInt64(Math.Ceiling(metalShortfall / (numMetalConversion.Value / numCrystalConversion.Value))), 0);
                deutCost = Math.Max(Convert.ToInt64(Math.Ceiling(deutShortfall / (numDeuteriumConversion.Value / numCrystalConversion.Value))), 0);

                metalCostResult.Text = "Metal: " + metalCost.ToString("N0");
                crystalCostResult.Text = "Deut: " + deutCost.ToString("N0");
                deutCostResult.Text = "Total: " + (metalCost + deutCost).ToString("N0");
            }
            else if (radioButton6.Checked)
            {
                metalCost = Math.Max(Convert.ToInt64(Math.Ceiling(metalShortfall / (numMetalConversion.Value / numDeuteriumConversion.Value))), 0);
                crystalCost = Math.Max(Convert.ToInt64(Math.Ceiling(crystalShortfall / (numCrystalConversion.Value / numDeuteriumConversion.Value))), 0);

                metalCostResult.Text = "Metal: " + metalCost.ToString("N0");
                crystalCostResult.Text = "Crystal: " + crystalCost.ToString("N0");
                deutCostResult.Text = "Full: " + (metalCost + crystalCost).ToString("N0");
            }

            if (metalShortfall > 0)
            {
                metalCostShortfall.Text = "Metal: " + metalShortfall.ToString("N0");
                metalCostShortfall.ForeColor = Color.Red;
            } else
            {
                metalCostShortfall.ForeColor = Color.Green;
                metalCostShortfall.Text = "Metal: " + Math.Abs(metalShortfall).ToString("N0");
            }

            if (crystalShortfall > 0)
            {
                crystalCostShortfall.ForeColor = Color.Red;
                crystalCostShortfall.Text = "Crystal: " + crystalShortfall.ToString("N0");
            } else
            {
                crystalCostShortfall.ForeColor = Color.Green;
                crystalCostShortfall.Text = "Crystal: " + Math.Abs(crystalShortfall).ToString("N0");
            }
            

            if (deutShortfall > 0)
            {
                deutCostShortfall.ForeColor = Color.Red;
                deutCostShortfall.Text = "Deut: " + deutShortfall.ToString("N0");
            }
            else
            {
                deutCostShortfall.ForeColor = Color.Green;
                deutCostShortfall.Text = "Deut: " + Math.Abs(deutShortfall).ToString("N0");
            }
            


            // Info drop
            unitMetal.Text = "Metal: " + baseMetal2.ToString("N0");
            unitCrystal.Text = "Crystal: " + baseCrystal2.ToString("N0");
            unitDeut.Text = "Deut: " + baseDeut2.ToString("N0");


            if (checkBox1.Checked)
            {
                totalMetal.Text = "Metal: " + (baseMetal2).ToString("N0");
                totalCrystal.Text = "Crystal: " + (baseCrystal2).ToString("N0");
                totalDeut.Text = "Deut: " + (baseDeut2).ToString("N0");
            } else
            {
                totalMetal.Text = "Metal: " + (baseMetal2 * multiplier[0]).ToString("N0");
                totalCrystal.Text = "Crystal: " + (baseCrystal2 * multiplier[0]).ToString("N0");
                totalDeut.Text = "Deut: " + (baseDeut2 * multiplier[0]).ToString("N0");
            }




        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            numMetalConversion.ReadOnly = true;
            numMetalConversion.Value = 3;
            numCrystalConversion.ReadOnly = false;
            numDeuteriumConversion.ReadOnly = false;
            traderCostLabel.Text = "Metal Cost";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            numCrystalConversion.ReadOnly = true;
            numCrystalConversion.Value = 2;
            numMetalConversion.ReadOnly = false;
            numDeuteriumConversion.ReadOnly = false;
            traderCostLabel.Text = "Crystal Cost";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            numDeuteriumConversion.ReadOnly = true;
            numDeuteriumConversion.Value = 1;
            numMetalConversion.ReadOnly = false;
            numCrystalConversion.ReadOnly = false;
            traderCostLabel.Text = "Deut Cost";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                levelInput.Enabled = true;
                levelInput2.Enabled = true;
                levelInput3.Enabled = true;
                levelInput4.Enabled = true;
                levelInput5.Enabled = true;
                multiplierInput2.Enabled = true;
                multiplierInput3.Enabled = true;
                multiplierInput4.Enabled = true;
                multiplierInput5.Enabled = true;
            }
            else
            {
                levelInput.Enabled = false;
                levelInput2.Enabled = false;
                levelInput3.Enabled = false;
                levelInput4.Enabled = false;
                levelInput5.Enabled = false;
                multiplierInput2.Enabled = false;
                multiplierInput3.Enabled = false;
                multiplierInput4.Enabled = false;
                multiplierInput5.Enabled = false;
            }
        }

        private void saveSettings()
        {
            Properties.Settings.Default.currentMetal = currentMetal.Text;
            Properties.Settings.Default.currentCrystal = currentCrystal.Text;
            Properties.Settings.Default.currentDeut = currentDeut.Text;
            Properties.Settings.Default.keepMetal = keepMetal.Text;
            Properties.Settings.Default.keepCrystal = keepCrystal.Text;
            Properties.Settings.Default.keepDeut = keepDeut.Text;
            Properties.Settings.Default.convertMetal = numMetalConversion.Text;
            Properties.Settings.Default.convertCrystal = numCrystalConversion.Text;
            Properties.Settings.Default.convertDeut = numDeuteriumConversion.Text;

            if (radioButton4.Checked)
            {
                Properties.Settings.Default.convertCheck = "Metal";
            }
            if (radioButton5.Checked)
            {
                Properties.Settings.Default.convertCheck = "Crystal";
            }
            if (radioButton6.Checked)
            {
                Properties.Settings.Default.convertCheck = "Deut";
            }

            
            if (radioButton1.Checked)
            {
                Properties.Settings.Default.whatBuildCheck = "Mine";
            }

            if (radioButton2.Checked)
            {
                Properties.Settings.Default.whatBuildCheck = "Building";
            }

            if (radioButton3.Checked)
            {
                Properties.Settings.Default.whatBuildCheck = "Research";
            }

            Properties.Settings.Default.mineSelect = mineDropdown.SelectedIndex;
            Properties.Settings.Default.buildingSelect = buildingDropdown.SelectedIndex;
            Properties.Settings.Default.researchSelect = researchDropdown.SelectedIndex;
            Properties.Settings.Default.level = levelInput.Text;
            Properties.Settings.Default.multiplier = multiplierInput.Text;
            Properties.Settings.Default.singlerange = checkBox1.Checked;
            Properties.Settings.Default.level2 = levelInput2.Text;
            Properties.Settings.Default.level3 = levelInput3.Text;
            Properties.Settings.Default.level4 = levelInput4.Text;
            Properties.Settings.Default.level5 = levelInput5.Text;
            Properties.Settings.Default.multiplier2 = multiplierInput2.Text;
            Properties.Settings.Default.multiplier3 = multiplierInput3.Text;
            Properties.Settings.Default.multiplier4 = multiplierInput4.Text;
            Properties.Settings.Default.multiplier5 = multiplierInput5.Text;
            Properties.Settings.Default.levelTarget = levelInputTarget.Text;

            Properties.Settings.Default.Save();
        }

        private void loadSettings()
        {
            currentMetal.Text = Properties.Settings.Default.currentMetal;
            currentCrystal.Text = Properties.Settings.Default.currentCrystal;
            currentDeut.Text = Properties.Settings.Default.currentDeut;
            keepMetal.Text = Properties.Settings.Default.keepMetal;
            keepCrystal.Text = Properties.Settings.Default.keepCrystal;
            keepDeut.Text = Properties.Settings.Default.keepDeut;
            numMetalConversion.Text = Properties.Settings.Default.convertMetal;
            numCrystalConversion.Text = Properties.Settings.Default.convertCrystal;
            numDeuteriumConversion.Text = Properties.Settings.Default.convertDeut;

            if (Properties.Settings.Default.convertCheck == "Metal")
            {
                radioButton4.Checked = true;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
            }
            if (Properties.Settings.Default.convertCheck == "Crystal")
            {
                radioButton4.Checked = false;
                radioButton5.Checked = true;
                radioButton6.Checked = false;
            }
            if (Properties.Settings.Default.convertCheck == "Deut")
            {
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = true;
            }

            if (Properties.Settings.Default.whatBuildCheck == "Mine")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
            if (Properties.Settings.Default.whatBuildCheck == "Building")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
                radioButton3.Checked = false;
            }
            if (Properties.Settings.Default.whatBuildCheck == "Research")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = true;
            }

            mineDropdown.SelectedIndex = Properties.Settings.Default.mineSelect;
            buildingDropdown.SelectedIndex = Properties.Settings.Default.buildingSelect;
            researchDropdown.SelectedIndex = Properties.Settings.Default.researchSelect;
            levelInput.Text = Properties.Settings.Default.level;
            multiplierInput.Text = Properties.Settings.Default.multiplier;
            checkBox1.Checked = Properties.Settings.Default.singlerange;
            levelInput2.Text = Properties.Settings.Default.level2;
            levelInput3.Text = Properties.Settings.Default.level3;
            levelInput4.Text = Properties.Settings.Default.level4;
            levelInput5.Text = Properties.Settings.Default.level5;
            multiplierInput2.Text = Properties.Settings.Default.multiplier2;
            multiplierInput3.Text = Properties.Settings.Default.multiplier3;
            multiplierInput4.Text = Properties.Settings.Default.multiplier4;
            multiplierInput5.Text = Properties.Settings.Default.multiplier5;
            levelInputTarget.Text = Properties.Settings.Default.levelTarget;
        }
    }
}
