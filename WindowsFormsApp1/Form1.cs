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

        }


        private void hockeyButton_Click(object sender, EventArgs e)
        {
            // declare player name
            string playerName = "Wayne Gretzky";

            // declare player number
            double playerNumber = 99;


            // make hockey label visible only
            outputLabelHockey.Visible = true;
            outputLabelArea.Visible = false;
            outputLabelCarpet.Visible = false;
            outputLabelBill.Visible = false;



            // display player name and number
            outputLabelHockey.Text = $" {playerName} is number {playerNumber}";
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            // declare radius
            double radius = 15;

            // declare pi
            double pi = 3.14;

            // declare area
            double area = pi * radius * radius;

            // edit visibility
            outputLabelArea.Visible = true;
            outputLabelCarpet.Visible = false;
            outputLabelHockey.Visible = false;
            outputLabelBill.Visible = false;

            //display area
            outputLabelArea.Text += $"\n\n The area of the circle with a radius of {radius} cm is {area} cm^2";
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            // declare length
            double length = 8.5;

            // declare width
            double width = 6;

            // declare cost per metre
            double costPerMetre = 19.95;

            // declare area
            double area = length * width;

            // declare total cost
            double totalCost = area * costPerMetre;

            // make carpet label visible
            outputLabelCarpet.Visible = true;

            // edit visibility
            outputLabelCarpet.Visible = true;
            outputLabelHockey.Visible = false;
            outputLabelArea.Visible = false;
            outputLabelBill.Visible = false;



            // display the area of the room with dimensions
            outputLabelCarpet.Text = $"The area of a room with dimensions {length} m x {width} m is {area} m^2";

            // display cost per square metre
            outputLabelCarpet.Text = $"\n The cost to carpet this area at {costPerMetre} per square metre is ${totalCost}";
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            // declare shirt price
            double shirtPrice= 12.49;

            // declare tax
            double tax = 0.13;

            // declare tax amount
            double taxAmount = shirtPrice * tax;

            //declare total
            double total = shirtPrice * tax + shirtPrice;

            // declare tendered
            double tendered = 20.00;

            // declare change
            double change = tendered - total;

            // edit visibility
            outputLabelBill.Visible = true;
            outputLabelArea.Visible = false;
            outputLabelCarpet.Visible = false;
            outputLabelHockey.Visible = false;
           

            // display "Bill of Sale Title"
            outputLabelBill.Text = "Bill of Sale";

            // display shirt price
            outputLabelBill.Text += $"\n\n Shirt: {shirtPrice}";

            // display tax and total
            outputLabelBill.Text += $"\n\n Tax: {taxAmount} \n Total: {total}";


            // display tendered and change
            outputLabelBill.Text += $"\n\n Tendered: {tendered} \n Change: {change}";


           





        }
    }
}
