using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcBMI
{
    public class BMICalc
    {
        private double _bmi;
        private string _category;

        public BMICalc(double height, double weight, SysOfUnits u)
        {
            if (height < 0 || weight < 0)
            {
                throw new ArgumentOutOfRangeException("Neither height nor weight can be negative.");
            }
            else
            {
                _bmi = weight / Math.Pow(height, 2);
                if (u == SysOfUnits.Imperial)
                    _bmi *= 703;
            }
        }

        public double bmi
        {
            get { return Math.Round(_bmi, 2); }
        }

        public string category
        {
            get
            {
                if (_bmi < 15)
                {
                    _category = "Very severely underweight.";
                }
                else if (_bmi <= 16)
                {
                    _category = "Severely underweight.";
                }
                else if (_bmi <= 18.5)
                {
                    _category = "Underweight.";
                }
                else if (_bmi <= 25)
                {
                    _category = "Normal.";
                }
                else if (_bmi <= 30)
                {
                    _category = "Overweight.";
                }
                else if (_bmi <= 35)
                {
                    _category = "Obese Class I (Moderately obese).";
                }
                else if (_bmi <= 40)
                {
                    _category = "Obese Class II (Severely obese).";
                }
                else
                {
                    _category = "Obese Class III (Very Severely obese).";
                }
                return _category;
            }
        }

    }
}
