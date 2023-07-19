using MongoDB.Driver.Core.Configuration;
using System.Collections;
using System.Net.Http;


namespace simplecalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            obj = new CalculatorController();
 //"calculator", "calculatorresult");
        }
        int num1;
        int num2;
        int result;
        string option;
        private CalculatorController obj;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + '1';
        }


        private void btn3_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + '3';

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + '4';

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + '5';

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + '7';

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + '8';

        }

        private void btn3_Click_1(object sender, EventArgs e)
        {


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + '2';

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + '0';

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtdisplay.Text);
            txtdisplay.Text = txtdisplay.Text + option;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdisplay.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtdisplay.Text.Substring(txtdisplay.Text.IndexOf(option) + 1));


            if (option == ("+"))
                result = num1 + num2;

            if (option == ("-"))
                result = num1 - num2;

            if (option == ("*"))
                result = num1 * num2;

            if (option == ("/"))
                result = num1 / num2;

            txtdisplay.Text = result.ToString();

            obj.Post(num1, num2, option, result);
            // Databasehandler = new Databasehandler("mongodb://locolhost:27017", " calculatorDB", "calculatorActions");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + '6';

        }

        private void btndividion_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtdisplay.Text);
            txtdisplay.Text = txtdisplay.Text + option;

        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtdisplay.Text);
            txtdisplay.Text = txtdisplay.Text + option;
        }

        private void btn3_Click_2(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + '3';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + '9';
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtdisplay.Text);
            txtdisplay.Text = txtdisplay.Text + option;
        }
    }
}