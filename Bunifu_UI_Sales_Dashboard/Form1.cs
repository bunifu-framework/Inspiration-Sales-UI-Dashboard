using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunifu_UI_Sales_Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataViz1_Load(object sender, EventArgs e)
        {

        }
        public void plotdata()
        {
            //creat a canvas and datapoints for the bunifu line
            var canvas = new Bunifu.DataViz.WinForms.Canvas();
            var datapoints = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);

            datapoints.addLabely("Jan", "2");
            datapoints.addLabely("Feb", "3");
            datapoints.addLabely("Mar", "4");
            datapoints.addLabely("Apr", "7");
            datapoints.addLabely("May", "6");
            datapoints.addLabely("Jun", "7");
            datapoints.addLabely("Jul", "8");
            datapoints.addLabely("Aug", "9");
            datapoints.addLabely("Sep", "9");
            datapoints.addLabely("Oct", "7");
            datapoints.addLabely("Nov", "5");
            datapoints.addLabely("Dec", "4");
            //second chart points
            var datapoints2 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);

            datapoints2.addLabely("Jan", "12");
            datapoints2.addLabely("Feb", "10");
            datapoints2.addLabely("Mar", "9");
            datapoints2.addLabely("Apr", "7");
            datapoints2.addLabely("May", "8");
            datapoints2.addLabely("Jun", "6");
            datapoints2.addLabely("Jul", "5");
            datapoints2.addLabely("Aug", "4.5");
            datapoints2.addLabely("Sep", "4");
            datapoints2.addLabely("Oct", "5");
            datapoints2.addLabely("Nov", "8");
            datapoints2.addLabely("Dec", "9");
            //add the datapoints to the canvas
            canvas.addData(datapoints);
            canvas.addData(datapoints2);
            //render the canvas
            bunifuDataViz1.Render(canvas);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            plotdata();
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //add different colors for the two line charts other than the default
            bunifuDataViz1.colorSet.Add(Color.FromArgb(36, 106, 179));
            bunifuDataViz1.colorSet.Add(Color.FromArgb(244, 248, 252));

            //we need to add the rows
            bunifuCustomDataGrid1.Rows.Add("Twitter", "Today", "December", "$7,000.00");
            bunifuCustomDataGrid1.Rows.Add("Shopify", "Yesterday", "November", "$3,000.00");
            bunifuCustomDataGrid1.Rows.Add("Dribble", "Wednesday", "October", "$7,000.00");
            bunifuCustomDataGrid1.Rows.Add("Facebook", "Tuesday", "September", "$7,000.00");
            bunifuCustomDataGrid1.Rows.Add("Adidas", "Monday", "August", "$300.00");

            //lets now style each cell in the columns to have different colors
            bunifuCustomDataGrid1.Rows[0].Cells[0].Style.ForeColor = Color.FromArgb(112, 162, 219);
            bunifuCustomDataGrid1.Rows[1].Cells[0].Style.ForeColor = Color.FromArgb(112, 162, 219);
            bunifuCustomDataGrid1.Rows[2].Cells[0].Style.ForeColor = Color.FromArgb(112, 162, 219);
            bunifuCustomDataGrid1.Rows[3].Cells[0].Style.ForeColor = Color.FromArgb(112, 162, 219);
            bunifuCustomDataGrid1.Rows[4].Cells[0].Style.ForeColor = Color.FromArgb(112, 162, 219);

            bunifuCustomDataGrid1.Rows[0].Cells[1].Style.ForeColor = Color.FromArgb(198, 205, 216);
            bunifuCustomDataGrid1.Rows[1].Cells[1].Style.ForeColor = Color.FromArgb(198, 205, 216);
            bunifuCustomDataGrid1.Rows[2].Cells[1].Style.ForeColor = Color.FromArgb(198, 205, 216);
            bunifuCustomDataGrid1.Rows[3].Cells[1].Style.ForeColor = Color.FromArgb(198, 205, 216);
            bunifuCustomDataGrid1.Rows[4].Cells[1].Style.ForeColor = Color.FromArgb(198, 205, 216);

            bunifuCustomDataGrid1.Rows[0].Cells[2].Style.ForeColor = Color.FromArgb(112, 162, 219);
            bunifuCustomDataGrid1.Rows[1].Cells[2].Style.ForeColor = Color.FromArgb(112, 162, 219);
            bunifuCustomDataGrid1.Rows[2].Cells[2].Style.ForeColor = Color.FromArgb(112, 162, 219);
            bunifuCustomDataGrid1.Rows[3].Cells[2].Style.ForeColor = Color.FromArgb(112, 162, 219);
            bunifuCustomDataGrid1.Rows[4].Cells[2].Style.ForeColor = Color.FromArgb(112, 162, 219);

            bunifuCustomDataGrid1.Rows[0].Cells[3].Style.ForeColor = Color.FromArgb(198, 205, 216);
            bunifuCustomDataGrid1.Rows[1].Cells[3].Style.ForeColor = Color.FromArgb(198, 205, 216);
            bunifuCustomDataGrid1.Rows[2].Cells[3].Style.ForeColor = Color.FromArgb(198, 205, 216);
            bunifuCustomDataGrid1.Rows[3].Cells[3].Style.ForeColor = Color.FromArgb(198, 205, 216);
            bunifuCustomDataGrid1.Rows[4].Cells[3].Style.ForeColor = Color.FromArgb(198, 205, 216);


            bunifuCustomDataGrid1.ClearSelection();

        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            //the indicator should move as the user navigates through 
            Bunifu.Framework.UI.BunifuFlatButton clicked = (Bunifu.Framework.UI.BunifuFlatButton)sender;

            // Set the location of the separator (horizontally) to be below the clicked label.
            bunifuSeparator1.Location = new Point(bunifuSeparator1.Location.X, ((Bunifu.Framework.UI.BunifuFlatButton)sender).Location.Y);

            //set height of separator to be equal to that of flatbutton
            bunifuSeparator1.Height = clicked.Height;

            ((Bunifu.Framework.UI.BunifuFlatButton)sender).BackColor = Color.FromArgb(57, 132, 210);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //the indicator should move as the user navigates through 
            Bunifu.Framework.UI.BunifuFlatButton clicked = (Bunifu.Framework.UI.BunifuFlatButton)sender;

            // Set the location of the separator (horizontally) to be below the clicked label.
            bunifuSeparator1.Location = new Point(bunifuSeparator1.Location.X, ((Bunifu.Framework.UI.BunifuFlatButton)sender).Location.Y);

            //set height of separator to be equal to that of flatbutton
            bunifuSeparator1.Height = clicked.Height;

            ((Bunifu.Framework.UI.BunifuFlatButton)sender).BackColor = Color.FromArgb(57, 132, 210);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            //the indicator should move as the user navigates through 
            Bunifu.Framework.UI.BunifuFlatButton clicked = (Bunifu.Framework.UI.BunifuFlatButton)sender;

            // Set the location of the separator (horizontally) to be below the clicked label.
            bunifuSeparator1.Location = new Point(bunifuSeparator1.Location.X, ((Bunifu.Framework.UI.BunifuFlatButton)sender).Location.Y);

            //set height of separator to be equal to that of flatbutton
            bunifuSeparator1.Height = clicked.Height;

            ((Bunifu.Framework.UI.BunifuFlatButton)sender).BackColor = Color.FromArgb(57, 132, 210);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            //the indicator should move as the user navigates through 
            Bunifu.Framework.UI.BunifuFlatButton clicked = (Bunifu.Framework.UI.BunifuFlatButton)sender;

            // Set the location of the separator (horizontally) to be below the clicked label.
            bunifuSeparator1.Location = new Point(bunifuSeparator1.Location.X, ((Bunifu.Framework.UI.BunifuFlatButton)sender).Location.Y);

            //set height of separator to be equal to that of flatbutton
            bunifuSeparator1.Height = clicked.Height;

            ((Bunifu.Framework.UI.BunifuFlatButton)sender).BackColor = Color.FromArgb(57, 132, 210);
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            //the indicator should move as the user navigates through 
            Bunifu.Framework.UI.BunifuFlatButton clicked = (Bunifu.Framework.UI.BunifuFlatButton)sender;

            // Set the location of the separator (horizontally) to be below the clicked label.
            bunifuSeparator1.Location = new Point(bunifuSeparator1.Location.X, ((Bunifu.Framework.UI.BunifuFlatButton)sender).Location.Y);

            //set height of separator to be equal to that of flatbutton
            bunifuSeparator1.Height = clicked.Height;

            ((Bunifu.Framework.UI.BunifuFlatButton)sender).BackColor = Color.FromArgb(57, 132, 210);

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            //the indicator should move as the user navigates through 
            Bunifu.Framework.UI.BunifuFlatButton clicked = (Bunifu.Framework.UI.BunifuFlatButton)sender;

            // Set the location of the separator (horizontally) to be below the clicked label.
            bunifuSeparator1.Location = new Point(bunifuSeparator1.Location.X, ((Bunifu.Framework.UI.BunifuFlatButton)sender).Location.Y);

            //set height of separator to be equal to that of flatbutton
            bunifuSeparator1.Height = clicked.Height;

            ((Bunifu.Framework.UI.BunifuFlatButton)sender).BackColor = Color.FromArgb(57, 132, 210);
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            //the indicator should move as the user navigates through 
            Bunifu.Framework.UI.BunifuFlatButton clicked = (Bunifu.Framework.UI.BunifuFlatButton)sender;

            // Set the location of the separator (horizontally) to be below the clicked label.
            bunifuSeparator1.Location = new Point(bunifuSeparator1.Location.X, ((Bunifu.Framework.UI.BunifuFlatButton)sender).Location.Y);

            //set height of separator to be equal to that of flatbutton
            bunifuSeparator1.Height = clicked.Height;

            ((Bunifu.Framework.UI.BunifuFlatButton)sender).BackColor = Color.FromArgb(57, 132, 210);

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //the indicator should move as the user navigates through 
            Bunifu.Framework.UI.BunifuFlatButton clicked = (Bunifu.Framework.UI.BunifuFlatButton)sender;

            // Set the location of the separator (horizontally) to be below the clicked label.
            bunifuSeparator1.Location = new Point(bunifuSeparator1.Location.X, ((Bunifu.Framework.UI.BunifuFlatButton)sender).Location.Y);

            //set height of separator to be equal to that of flatbutton
            bunifuSeparator1.Height = clicked.Height;

            ((Bunifu.Framework.UI.BunifuFlatButton)sender).BackColor = Color.FromArgb(57, 132, 210);

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            //the indicator should move as the user navigates through 
            Bunifu.Framework.UI.BunifuFlatButton clicked = (Bunifu.Framework.UI.BunifuFlatButton)sender;

            // Set the location of the separator (horizontally) to be below the clicked label.
            bunifuSeparator1.Location = new Point(bunifuSeparator1.Location.X, ((Bunifu.Framework.UI.BunifuFlatButton)sender).Location.Y);

            //set height of separator to be equal to that of flatbutton
            bunifuSeparator1.Height = clicked.Height;

            ((Bunifu.Framework.UI.BunifuFlatButton)sender).BackColor = Color.FromArgb(57, 132, 210);
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            //the indicator should move as the user navigates through 
            Bunifu.Framework.UI.BunifuFlatButton clicked = (Bunifu.Framework.UI.BunifuFlatButton)sender;

            // Set the location of the separator (horizontally) to be below the clicked label.
            bunifuSeparator1.Location = new Point(bunifuSeparator1.Location.X, ((Bunifu.Framework.UI.BunifuFlatButton)sender).Location.Y);

            //set height of separator to be equal to that of flatbutton
            bunifuSeparator1.Height = clicked.Height;

            ((Bunifu.Framework.UI.BunifuFlatButton)sender).BackColor = Color.FromArgb(57, 132, 210);
        }

        private void bunifuFlatButton7_Load(object sender, EventArgs e)
        {
            //the indicator should move as the user navigates through 
            Bunifu.Framework.UI.BunifuFlatButton clicked = (Bunifu.Framework.UI.BunifuFlatButton)sender;

            // Set the location of the separator (horizontally) to be below the clicked label.
            bunifuSeparator1.Location = new Point(bunifuSeparator1.Location.X, ((Bunifu.Framework.UI.BunifuFlatButton)sender).Location.Y);

            //set height of separator to be equal to that of flatbutton
            bunifuSeparator1.Height = clicked.Height;

            ((Bunifu.Framework.UI.BunifuFlatButton)sender).BackColor = Color.FromArgb(57, 132, 210);
        }
    }
}
