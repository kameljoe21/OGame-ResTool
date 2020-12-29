using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            mineDropdown.SelectedIndex = 0;
            buildingDropdown.SelectedIndex = 0;
            researchDropdown.SelectedIndex = 0;
        }

        int[,] mineValues = { {60,15,0}, {48,24,0}, {225,75,0}, { 75, 30,0 }, { 900, 360, 180 }, { 1000, 0, 0 }, { 1000, 500, 0 }, { 1000, 1000, 0 } };
        int[,] buildingValues = { { 400,120,200} , { 400,200,100}, { 200, 400, 200 },  { 20000,40000,0}, { 20000, 20000, 1000 }, { 1000000,500000,100000}, {0,50000,100000},
        { 200,0,50}, {20000,40000,20000 }, { 20000,40000,20000}, { 2000000,4000000,2000000} };
        int[,] researchValues = { { 0,800,400}, { 200,100,0}, { 1000,300,100}, { 0,4000,2000}, { 2000, 4000, 2000 }, {200,1000,200}, { 0,400,600}, { 4000,8000,4000}, { 240000,400000,160000},
        { 0,0,0}, { 400,0,600}, { 2000,4000,600}, { 10000,20000,6000}, { 800,200,0}, {200,600,0 }, { 1000,0,0} };

        private void button1_Click(object sender, EventArgs e)
        {
            #region init
            Int64 metal, crystal, deut, level, level2, multiplier;
            double metalConv, crystalConv, deutConv;
            double levelCostMultiplier = 2.0;
            String metalOriginal, crystalOriginal, deutOriginal, metalConversionOriginal, crystalConversionOriginal, deutConversionOriginal;
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

            metalConversionOriginal = metalConversion.Text;
            metalConversionOriginal = metalConversionOriginal.Replace(".", ",");
            metalConversionOriginal = metalConversionOriginal.Replace(" ", String.Empty);

            crystalConversionOriginal = crystalConversion.Text;
            crystalConversionOriginal = crystalConversionOriginal.Replace(".", ",");
            crystalConversionOriginal = crystalConversionOriginal.Replace(" ", String.Empty);

            deutConversionOriginal = deutConversion.Text;
            deutConversionOriginal = deutConversionOriginal.Replace(".", ",");
            deutConversionOriginal = deutConversionOriginal.Replace(" ", String.Empty);

            if (Int64.TryParse(metalOriginal, out metal)) {

            } else {
                metal = 0;
            }
            if (Int64.TryParse(crystalOriginal, out crystal)) {

            } else {
                crystal = 0;
            }
            if (Int64.TryParse(deutOriginal, out deut)) {
                
            } else {
                deut = 0;
            }
            if (double.TryParse(metalConversionOriginal, out metalConv)) {

            } else {
                metalConv = 1;
            }
            if (double.TryParse(crystalConversionOriginal, out crystalConv)) {

            } else {
                crystalConv = 1;
            }
            if (double.TryParse(deutConversionOriginal, out deutConv)) {

            } else {
                deutConv = 1;
            }

            if (Int64.TryParse(levelInput.Text, out level)) {

            } else {
                level = 1;
            }
            if (Int64.TryParse(levelInput2.Text, out level2))
            {

            }
            else
            {
                level2 = 1;
            }
            if (Int64.TryParse(multiplierInput.Text, out multiplier)) {

            } else {
                multiplier = 1;
            }

            Int64 selected = -1;
            Int64 metalCost, crystalCost, deutCost, metalShortfall, crystalShortfall, deutShortfall;
            Int64 baseMetal = 0, baseCrystal = 0, baseDeut = 0;
            Int64 baseMetal2 = 0, baseCrystal2 = 0, baseDeut2 = 0;
			#endregion

			#region logic
            // Mine
			if (radioButton1.Checked) {
                selected = mineDropdown.SelectedIndex;
                if (selected == 0 || selected == 2 || selected == 3) {
                    levelCostMultiplier = 1.5;
                }
                if (selected == 1) {
                    levelCostMultiplier = 1.6;
                }
                if (selected == 4) {
                    levelCostMultiplier = 1.8;
                }

                baseMetal = mineValues[selected, 0];
                baseCrystal = mineValues[selected, 1];
                baseDeut = mineValues[selected, 2];

            }
            
            // Building
            if (radioButton2.Checked) {
                selected = buildingDropdown.SelectedIndex;
                baseMetal = buildingValues[selected, 0];
                baseCrystal = buildingValues[selected, 1];
                baseDeut = buildingValues[selected, 2];

            }
            
            // Research
            if (radioButton3.Checked) {
                selected = researchDropdown.SelectedIndex;
                if (selected == 7) {
                    levelCostMultiplier = 1.75;
                }
                if (selected == 9) {
                    levelCostMultiplier = 3;
                }

                baseMetal = researchValues[selected, 0];
                baseCrystal = researchValues[selected, 1];
                baseDeut = researchValues[selected, 2];
            }
            
            if (!checkBox1.Checked || level >= level2)
            {
                if (radioButton3.Checked && selected == 7)
                {
                    baseMetal2 = Convert.ToInt64(Math.Round(baseMetal * Math.Pow(levelCostMultiplier, level - 1) / 100d, 0d) * 100d);
                    baseCrystal2 = Convert.ToInt64(Math.Round(baseCrystal * Math.Pow(levelCostMultiplier, level - 1) / 100d, 0d) * 100d);
                    baseDeut = Convert.ToInt64(Math.Round(baseDeut * Math.Pow(levelCostMultiplier, level - 1) / 100d, 0d) * 100d);
                }
                else
                {
                    baseMetal2 = Convert.ToInt64(Math.Floor(baseMetal * Math.Pow(levelCostMultiplier, level - 1)));
                    baseCrystal2 = Convert.ToInt64(Math.Floor(baseCrystal * Math.Pow(levelCostMultiplier, level - 1)));
                    baseDeut2 = Convert.ToInt64(Math.Floor(baseDeut * Math.Pow(levelCostMultiplier, level - 1)));
                }
            } else
            {
                for (long i = level; i <= level2; i++)
                {
                    if (radioButton3.Checked && selected == 7)
                    {
                        baseMetal2 += Convert.ToInt64(Math.Round(baseMetal * Math.Pow(levelCostMultiplier, i - 1) / 100d, 0d) * 100d);
                        baseCrystal2 += Convert.ToInt64(Math.Round(baseCrystal * Math.Pow(levelCostMultiplier, i - 1) / 100d, 0d) * 100d);
                        baseDeut2 += Convert.ToInt64(Math.Round(baseDeut * Math.Pow(levelCostMultiplier, level - 1) / 100d, 0d) * 100d);
                    }
                    else
                    {
                        baseMetal2 += Convert.ToInt64(Math.Floor(baseMetal * Math.Pow(levelCostMultiplier, i - 1)));
                        baseCrystal2 += Convert.ToInt64(Math.Floor(baseCrystal * Math.Pow(levelCostMultiplier, i - 1)));
                        baseDeut2 += Convert.ToInt64(Math.Floor(baseDeut * Math.Pow(levelCostMultiplier, i - 1)));
                    }
                }
            }

            metalShortfall = baseMetal2 * multiplier;
            crystalShortfall = baseCrystal2 * multiplier;
            deutShortfall = baseDeut2 * multiplier;

            metalShortfall -= metal;
            metalShortfall = Clamp(metalShortfall, 0, Int64.MaxValue);
            crystalShortfall -= crystal;
            crystalShortfall = Clamp(crystalShortfall, 0, Int64.MaxValue);
            deutShortfall -= deut;
            deutShortfall = Clamp(deutShortfall, 0, Int64.MaxValue);

            // metal
            if (radioButton4.Checked)
            {
                crystalCost = Convert.ToInt64(Math.Ceiling(crystalShortfall / (crystalConv / metalConv)));
                deutCost = Convert.ToInt64(Math.Ceiling(deutShortfall / (deutConv / metalConv)));

                metalCostResult.Text = "Crystal: " + crystalCost.ToString("N0");
                crystalCostResult.Text = "Deut: " + deutCost.ToString("N0");
                deutCostResult.Text = "Total: " + (deutCost + crystalCost).ToString("N0");

            }
            
            // crystal
            if (radioButton5.Checked)
            {
                metalCost = Convert.ToInt64(Math.Ceiling(metalShortfall / (metalConv / crystalConv)));
                deutCost = Convert.ToInt64(Math.Ceiling(deutShortfall / (deutConv / crystalConv)));

                metalCostResult.Text = "Metal: " + metalCost.ToString("N0");
                crystalCostResult.Text = "Deut: " + deutCost.ToString("N0");
                deutCostResult.Text = "Total: " + (metalCost + deutCost).ToString("N0");
            }
            
            // deut
            if (radioButton6.Checked)
            {
                metalCost = Convert.ToInt64(Math.Ceiling(metalShortfall / (metalConv / deutConv)));
                crystalCost = Convert.ToInt64(Math.Ceiling(crystalShortfall / (crystalConv / deutConv)));

                metalCostResult.Text = "Metal: " + metalCost.ToString("N0");
                crystalCostResult.Text = "Crystal: " + crystalCost.ToString("N0");
                deutCostResult.Text = "Full: " + (metalCost + crystalCost).ToString("N0");
            }
            #endregion

            #region output results
            metalCostShortfall.Text = "Metal: " + metalShortfall.ToString("N0");
            crystalCostShortfall.Text = "Crystal: " + crystalShortfall.ToString("N0");
            deutCostShortfall.Text = "Deut: " + deutShortfall.ToString("N0");

            // Info drop
          
            unitMetal.Text = "Metal: " + baseMetal2.ToString("N0");
            unitCrystal.Text = "Crystal: " + baseCrystal2.ToString("N0");
            unitDeut.Text = "Deut: " + baseDeut2.ToString("N0");

            totalMetal.Text = "Metal: " + (baseMetal2 * multiplier).ToString("N0");
            totalCrystal.Text = "Crystal:" + (baseCrystal2 * multiplier).ToString("N0");
            totalDeut.Text = "Deut: " + (baseDeut2 * multiplier).ToString("N0");
			#endregion

		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e) {
            metalConversion.ReadOnly = true;
            metalConversion.Text = "3";
            crystalConversion.ReadOnly = false;
            deutConversion.ReadOnly = false;
            traderCostLabel.Text = "Metal Cost";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e) {
            crystalConversion.ReadOnly = true;
            crystalConversion.Text = "2";
            metalConversion.ReadOnly = false;
            deutConversion.ReadOnly = false;
            traderCostLabel.Text = "Crystal Cost";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e) {
            deutConversion.ReadOnly = true;
            deutConversion.Text = "1";
            metalConversion.ReadOnly = false;
            crystalConversion.ReadOnly = false;
            traderCostLabel.Text = "Deut Cost";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                levelInput2.Enabled = true;
            } else
            {
                levelInput2.Enabled = false;
            }
        }
        private static Int64 Clamp(Int64 value, Int64 min, Int64 max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }
    }
}
