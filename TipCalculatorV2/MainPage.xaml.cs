using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TipCalculatorV2
{
	public partial class MainPage : ContentPage
	{
		// Initialize variables
		string bill_txt = "";
		bool decimal_dot = false;
		public MainPage()
		{
			InitializeComponent();
		}

		//Validation function for decimal dot
		private bool ValidationDot()
		{
			if (decimal_dot == true)
			{
				int decimal_index = bill_txt.IndexOf(".");
				string len_decimal = bill_txt.Substring(decimal_index);
				if (len_decimal.Length > 3)
				{
					return false;
				}
			}
			return true;
		}

		//Update value of slider
		public void ShowPercentage()
		{

			TipLabel.Text = String.Format("{0}%",Math.Round(sliderPercentage.Value).ToString());
			
		}

		//Display slider percentage 
		private void sliderPercentage_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			ShowPercentage();
		}

		/// <summary>
		/// Buttons for tip calculator's keyboard
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
	
		private void Btn1_Clicked(object sender, EventArgs e)
		{

			bill_txt += "1";
			billAmount.Text = String.Format("${0}", bill_txt);
			
		}

		private void Btn2_Clicked(object sender, EventArgs e)
		{
			bill_txt += "2";
			billAmount.Text = String.Format("${0}", bill_txt);
			
		}

		private void Btn3_Clicked(object sender, EventArgs e)
		{
			bill_txt += "3";
			billAmount.Text = String.Format("${0}", bill_txt);
			

		}

		private void Btn4_Clicked(object sender, EventArgs e)
		{
			bill_txt += "4";
			billAmount.Text = String.Format("${0}", bill_txt);
			
		}

		private void Btn5_Clicked(object sender, EventArgs e)
		{
			bill_txt += "5";
			billAmount.Text = String.Format("${0}", bill_txt);
			
		}

		private void Btn6_Clicked(object sender, EventArgs e)
		{
			bill_txt += "6";
			billAmount.Text = String.Format("${0}", bill_txt);
			

		}

		private void Btn7_Clicked(object sender, EventArgs e)
		{
			bill_txt += "7";
			billAmount.Text = String.Format("${0}", bill_txt);
			
		}

		private void Btn8_Clicked(object sender, EventArgs e)
		{
			bill_txt += "8";
			billAmount.Text = String.Format("${0}", bill_txt);
			
		}

		private void Btn9_Clicked(object sender, EventArgs e)
		{
			bill_txt += "9";
			billAmount.Text = String.Format("${0}", bill_txt);
			
		}
		
		// Button for refresh screen
		private void Btn10_Clicked(object sender, EventArgs e)
		{
			Button clickbtn = (Button)sender;
			if (clickbtn.Text == "CE")
			{
				bill_txt = "";
				billAmount.Text = String.Format("$0", bill_txt);
				total_amt.Text = "$0";
				TipAmount.Text = "$0";
			}

		}

		private void Btn11_Clicked(object sender, EventArgs e)
		{

			Button clickbtn = (Button)sender;
			if (bill_txt != "")
			{
				if (clickbtn.Text == "00")
				{
					bill_txt += "0";
					billAmount.Text = String.Format("${0}", bill_txt);
					
				}

			}


		}

		// Button enter to calculate total amount tip 
		private void BtnEnter_Clicked(object sender, EventArgs e)
		{
			if (bill_txt != "")
			{
				double percentage = Math.Round(sliderPercentage.Value);
				double bill_amount = Convert.ToDouble(bill_txt);

				double tip_amt = (bill_amount * percentage) / 100;
				double formula_tip = bill_amount + tip_amt;

				total_amt.Text = String.Format("${0}", formula_tip.ToString());
				TipAmount.Text = String.Format("${0}", tip_amt.ToString());
			}
		}


		// Button to put a dot
		private void Btn12_Clicked(object sender, EventArgs e)
		{
			if (ValidationDot()) ;
			if (decimal_dot == false)
			{
				if (bill_txt == "")
				{
					bill_txt += ".";
					billAmount.Text = String.Format("$0{0}", bill_txt);
					

				}
				else
				{
					bill_txt += ".";
					billAmount.Text = String.Format("${0}", bill_txt);
					
				}
				decimal_dot = true;
			}

		}
	}
}
