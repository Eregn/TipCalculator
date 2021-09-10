using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO; 

namespace Mobile_Applications_Week04
{
	public partial class MainPage : ContentPage
	{

		string bill_txt, total_txt;
		string tiplabel;
		bool decimal_dot = false;

		public MainPage()
		{
			InitializeComponent();
		}

		private bool Validation()
		{
			if (decimal_dot == true)
			{
				int decimal_index = bill_txt.IndexOf(".");
				string len_decimal = bill_txt.Substring(decimal_index);
				if(len_decimal.Length > 3)
				{
					return false;
				}
			}
			return true;
		}
		
		private string ShowPercentage()
		{
			
			tiplabel = String.Format("{0}", sliderPercentage.Value.ToString());
			return tiplabel; 
		}

		private void sliderPercentage_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			ShowPercentage();
		}

		private void Btn1_Clicked(object sender, EventArgs e)
		{
			
			bill_txt += "1";
			Bill_Amount.Text = String.Format("Bill Amount: ${0}", bill_txt);
			total_amt.Text = String.Format("{0}", bill_txt);
		}

		private void Btn2_Clicked(object sender, EventArgs e)
		{
			bill_txt += "2";
			Bill_Amount.Text = String.Format("Bill Amount: ${0}", bill_txt);
			total_amt.Text = String.Format("{0}", bill_txt);
		}

		private void Btn3_Clicked(object sender, EventArgs e)
		{
			bill_txt += "3";
			Bill_Amount.Text = String.Format("Bill Amount: ${0}", bill_txt);
			total_amt.Text = String.Format("{0}", bill_txt);

		}

		private void Btn4_Clicked(object sender, EventArgs e)
		{
			bill_txt += "4";
			Bill_Amount.Text = String.Format("Bill Amount: ${0}", bill_txt);
			total_amt.Text = String.Format("{0}", bill_txt);
		}

		private void Btn5_Clicked(object sender, EventArgs e)
		{
			bill_txt += "5";
			Bill_Amount.Text = String.Format("Bill Amount: ${0}", bill_txt);
			total_amt.Text = String.Format("{0}", bill_txt);
		}

		private void Btn6_Clicked(object sender, EventArgs e)
		{
			bill_txt += "6";
			Bill_Amount.Text = String.Format("Bill Amount: ${0}", bill_txt);
			total_amt.Text = String.Format("{0}", bill_txt);

		}

		private void Btn7_Clicked(object sender, EventArgs e)
		{
			bill_txt += "7";
			Bill_Amount.Text = String.Format("Bill Amount: ${0}", bill_txt);
			total_amt.Text = String.Format("{0}", bill_txt);
		}

		private void Btn8_Clicked(object sender, EventArgs e)
		{
			bill_txt += "8";
			Bill_Amount.Text = String.Format("Bill Amount: ${0}", bill_txt);
			total_amt.Text = String.Format("{0}", bill_txt);
		}

		private void Btn9_Clicked(object sender, EventArgs e)
		{
			bill_txt += "9";
			Bill_Amount.Text = String.Format("Bill Amount: ${0}", bill_txt);
			total_amt.Text = String.Format("{0}", bill_txt);
		}

		private void Btn10_Clicked(object sender, EventArgs e)
		{
			Button clickbtn = (Button) sender;
			if (clickbtn.Text == "CE")
			{

				Bill_Amount.Text = "Bill Amount: ";
				total_amt.Text = "";
				
			}

		}

		private void Btn11_Clicked(object sender, EventArgs e)
		{

			Button clickbtn = (Button)sender;
			if(Bill_Amount.Text != "")
			{
				if (clickbtn.Text == "0")
				{
					bill_txt += "0";
					Bill_Amount.Text = String.Format("Bill Amount: ${0}", bill_txt);
					total_amt.Text = String.Format("{0}", bill_txt);
				}
			
			}
	
			
		}

		private void BtnEnter_Clicked(object sender, EventArgs e)
		{
			if (bill_txt != "")
			{
				double percentage = Math.Round(sliderPercentage.Value);
				double bill_amount = Convert.ToDouble(bill_txt);

				double tip_amt = (bill_amount * percentage) / 100;
				double formula_tip = bill_amount + tip_amt;

				total_amt.Text = String.Format("Bill Amount: ${0}", formula_tip.ToString());

			}	
		}

		

		private void Btn12_Clicked(object sender, EventArgs e)
		{
			if (Validation());
			if(decimal_dot == false)
			{
				if(bill_txt == "")
				{
					bill_txt += ".";
					Bill_Amount.Text = String.Format("Bill Amount: $0{0}", bill_txt);
					total_amt.Text = String.Format("{0}", bill_txt);
					
				}
				else
				{
					bill_txt += ".";
					Bill_Amount.Text = String.Format("Bill Amount: ${0}", bill_txt);
					total_amt.Text = String.Format("{0}", bill_txt);
				}
				decimal_dot = true;
			}
			
		}

	}
}
