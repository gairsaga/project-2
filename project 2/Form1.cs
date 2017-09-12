//form1.cs
// CS-1181
// Sagar Gaire
// 9/12/2017
// Anil Mandal
// From this assingnment we can learn the calculation process of revenue and it also act as a simple calculator
//wow:when calculation is performed the answer which will be displayed get color change


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2
{
    public partial class frmSeating : Form
    {
        public frmSeating()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblClass_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //for closing the form
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //for clearing TextBoxes when Clicked

            ClassA: txt1.Text = "";
            ClassB: txt2.Text = "";
            Classc: txt3.Text = "";
            lblRev1.Text = "";
            lblRev2.Text = "";
            lblRev3.Text = "";
            lblRevTotal.Text = "";
            


        }

        private void btnCalulateRevenge_Click(object sender, EventArgs e)
        {
            //Calculating value of Revenue
            double classA;
            double classB;
            double classC;
            double total;
            classA = double.Parse(txt1.Text);
            classB= double.Parse(txt2.Text);
            classC= double.Parse(txt3.Text);
            //Calculate revenue generated on each class
            lblRev1.Text = (classA * 15.5).ToString("c");
            lblRev1.ForeColor = Color.Green;
            lblRev2.Text = (classB * 12.60).ToString("c");
            lblRev2.ForeColor = Color.Red;
            lblRev3.Text = (classC * 9.30).ToString("c");
            lblRev3.ForeColor = Color.LawnGreen;
            //calulating total Revenue of each class
            total = (classA*15.5)+(classB*12.60)+(classC*9.30);
            lblRevTotal.Text = total.ToString("c");
            lblRevTotal.ForeColor = Color.Pink;
            //assigining resultant value 

        }
    }
}
