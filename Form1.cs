using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominguez_Resort_Form
{
    public partial class DominguezResort : Form
    {
        public DominguezResort()
        {
            InitializeComponent();
        }

        private const double StandardQueen = 284;
        private const double AtriumQueen = 325;
        private const double StandardKing = 290;
        private const double AtriumKing = 350;
        private const double Parking = 12.75;
        private const double Tax = .15;
        private const double ResortFee = 15;

        double RoomTot = 0.00;
        double RoomTax = 0.00;
        double DayParking = 0.00;
        double ResortFeeTot = 0.00;
        double Total = 0.00;

        int tempRoomSize = 6;
        int tempRoomWithAdult = 5;

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoomNumBar_Scroll(object sender, EventArgs e)
        {
            tempRoomSize = RoomNumBar.Value * 6;

            tempRoomWithAdult = tempRoomSize - (int)AdultsUpDown.Value;

            RoomNumLabel.Text = "Number of Rooms: " + RoomNumBar.Value;
            if (AdultsUpDown.Value < RoomNumBar.Value)
            {
                AdultsUpDown.Value = RoomNumBar.Value;
            }

            if (ChildrenUpDown.Value > tempRoomWithAdult)
            {
                if(tempRoomWithAdult > 0)
                {
                    ChildrenUpDown.Value = tempRoomWithAdult;
                }
                else if(tempRoomWithAdult < 0)
                {
                    ChildrenUpDown.Value = 0;
                }
            }

            if(AdultsUpDown.Value > tempRoomSize)
            {
                AdultsUpDown.Value = tempRoomSize;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            NameBox.Text = "";
            RoomNumLabel.Text = "Number of Rooms: 1";
            AdultsNumLabel.Text = "Number of Adults:";
            NumChildrenLabel.Text = "Number of Children:";
            KingButton.Checked = false;
            QueenButton.Checked = true;
            AtriumViewButton.Checked = false;
            StandViewButton.Checked = true;
            ParkingCheckBox.Checked = false;
            CardPayBox.Text = "";
            CardPayBox.Mask = "0000-0000-0000-0000";
            RoomCharge.Text = "$0.00";
            TaxTotal.Text = "$0.00";
            ParkingTotal.Text = "$0.00";
            ResortFeeTotal.Text = "$0.00";
            GrandTotal.Text = "$0.00";
        }
        
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (StandViewButton.Checked == true && KingButton.Checked == true)
            {
                RoomTot = StandardKing * (double)RoomNumBar.Value;
            }
            else if (AtriumViewButton.Checked == true && KingButton.Checked == true)
            {
                RoomTot = AtriumKing * (double)RoomNumBar.Value;
            }
            else if (StandViewButton.Checked == true && QueenButton.Checked == true)
            {
                RoomTot = StandardQueen * (double)RoomNumBar.Value;
            }
            else if (AtriumViewButton.Checked == true && QueenButton.Checked == true)
            {
                RoomTot = AtriumQueen * (double)RoomNumBar.Value;
            }

            RoomCharge.Text = RoomTot.ToString("c");
            RoomTax = RoomTot * Tax;
            TaxTotal.Text = RoomTax.ToString("c");


            if (ParkingCheckBox.Checked == true)
            {
                DayParking = Parking * (double)NumNightUpDown.Value;
                ParkingTotal.Text = DayParking.ToString("c");
            }
            else if (ParkingCheckBox.Checked == false)
            {
                DayParking = 0;
                ParkingTotal.Text = DayParking.ToString("c");
            }

            ResortFeeTot = ResortFee * (double)NumNightUpDown.Value * RoomNumBar.Value;
            ResortFeeTotal.Text = ResortFeeTot.ToString("c");

            Total = RoomTot + RoomTax + DayParking + ResortFeeTot;
            GrandTotal.Text = Total.ToString("c");
        }

        private void AdultsUpDown_ValueChanged(object sender, EventArgs e)
        {
            tempRoomSize = RoomNumBar.Value * 6;
            tempRoomWithAdult = tempRoomSize - (int)AdultsUpDown.Value;

            if(AdultsUpDown.Value < RoomNumBar.Value)
            {
                AdultsUpDown.Value = RoomNumBar.Value;
                
            }
            if (AdultsUpDown.Value > tempRoomSize && AdultsUpDown.Value > RoomNumBar.Value)
            {
                AdultsUpDown.Value = tempRoomSize;
                
            }

            if(ChildrenUpDown.Value > 0 && ChildrenUpDown.Value > tempRoomWithAdult)
            {
                ChildrenUpDown.Value = tempRoomWithAdult;
            }  

        }

        private void ChildrenUpDown_ValueChanged(object sender, EventArgs e)
        {
            tempRoomSize = RoomNumBar.Value * 6;
            tempRoomWithAdult = tempRoomSize - (int)AdultsUpDown.Value;

            if (ChildrenUpDown.Value > tempRoomWithAdult && tempRoomWithAdult > 0)
            {
                ChildrenUpDown.Value = tempRoomWithAdult;
            }
            else if (tempRoomWithAdult == 0)
            {
                ChildrenUpDown.Value = 0;
            }
        }

        private void CardPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CardPicker.Text == "Visa")
            {
                CardPayBox.Mask = "4000-0000-0000-0000";
            }
            else if (CardPicker.Text == "Mastercard")
            {
                CardPayBox.Mask = "5000-0000-0000-0000";
            }
            else if (CardPicker.Text == "Discover")
            {
                CardPayBox.Mask = "6000-0000-0000-0000";
            }
            else if (CardPicker.Text == "American Express")
            {
                CardPayBox.Mask = "3000-0000000-00000";
            }
        }
    }
}