using CalcBMI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BMI_exercise
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MetricPage : Page
    {
        private SolidColorBrush errorBrush = new SolidColorBrush(Windows.UI.Colors.Red);
        private Brush correctBrush = null;
        private double height;
        private double weight;

        public MetricPage()
        {
            this.InitializeComponent();
            if (correctBrush == null)
                correctBrush = txtHeight.Foreground;
        }

        private void btnCalcWH_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isValid())
                {
                    //Demo using method of static object
                    string category;
                    lblBMIValue.Text = "Body Mass Index: " + StaticBMI.bmiValue(height, weight, SysOfUnits.Metric, out category).ToString("n2");
                    lblBMIClassification.Text = "Category: " + category;
                }
            }
            catch (ArgumentOutOfRangeException ax)
            {
                MainPage.ShowMessage("Calculation Error", ax.ParamName);
            }
            catch (Exception ex)
            {
                MainPage.ShowMessage("Calculation Error", ex.Message);
            }
        }



        private bool isValid()
        {
            bool validData = true;
            string errMessage = "Please fix the following errors:" + Environment.NewLine;
            if (String.IsNullOrEmpty(txtHeight.Text))
            {
                txtHeight.Foreground = correctBrush;
                validData = false;
                errMessage += "-No height entered" + Environment.NewLine;
            }
            else if (!double.TryParse(txtHeight.Text, out height))
            {
                txtHeight.Foreground = errorBrush;
                validData = false;
                errMessage += "-Invalid Height" + Environment.NewLine;
            }
            else if (height <= 0)
            {
                txtHeight.Foreground = errorBrush;
                validData = false;
                errMessage += "-Height must be greater then zero" + Environment.NewLine;
            }
            else
            {
                txtHeight.Foreground = correctBrush;
            }
            //Check Weight
            if (String.IsNullOrEmpty(txtWeight.Text))
            {
                txtHeight.Foreground = correctBrush;
                validData = false;
                errMessage += "-No weight entered" + Environment.NewLine;
            }
            else if (!double.TryParse(txtWeight.Text, out weight))
            {
                txtWeight.Foreground = errorBrush;
                validData = false;
                errMessage += "-Invalid Weight" + Environment.NewLine;
            }
            else if (weight <= 0)
            {
                txtWeight.Foreground = errorBrush;
                validData = false;
                errMessage += "-Weight must be greater then zero" + Environment.NewLine;
            }
            else
            {
                txtWeight.Foreground = correctBrush;
            }
            if (!validData)
                MainPage.ShowMessage("Invalid Data", errMessage);
            return validData;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lblBMIClassification.Text = "";
            lblBMIValue.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtHeight.Foreground = correctBrush;
            txtWeight.Foreground = correctBrush;
        }
    }
}
