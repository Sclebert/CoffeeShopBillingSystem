using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CS_BillingSystem_MySQL
{
    public partial class Form1 : Form
    {

        double firstNum, secondNum;
        string oper;

        int[] items = new int[5];
        double[] cost = new double[5];

        double coldBrew = 3.25;
        double espresso = 4.15;
        double latte = 4.75;
        double frappe = 3.75;

        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();

        DataTable sqlData = new DataTable();
        string sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader DtR;

        DataSet DS = new DataSet();

        String server = "local";
        String username = "root";
        String password = "123456";
        String database = "billsys";
        public Form1()
        {
            InitializeComponent();
        }

        private void UploadData()
        {
            sqlConn.ConnectionString = "server=localhost;uid=root;" + "pwd=SydneyQL2023?;database=billsys";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "SELECT * FROM billsys.billsys";

            DtR = sqlCmd.ExecuteReader();
            sqlData.Load(DtR);
            DtR.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlData;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UploadData();
        }

        private void NumberClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (txtDisplayCalc.Text == "0")
            {
                txtDisplayCalc.Text = "";
            }

            if (b.Text == "1")
            {
                txtDisplayCalc.Text += b.Text;
            }
            else if (b.Text == "2")
            {
                txtDisplayCalc.Text += b.Text;
            }
            else if (b.Text == "3")
            {
                txtDisplayCalc.Text += b.Text;
            }
            else if (b.Text == "4")
            {
                txtDisplayCalc.Text += b.Text;
            }
            else if (b.Text == "5")
            {
                txtDisplayCalc.Text += b.Text;
            }
            else if (b.Text == "6")
            {
                txtDisplayCalc.Text += b.Text;
            }
            else if (b.Text == "7")
            {
                txtDisplayCalc.Text += b.Text;
            }
            else if (b.Text == "8")
            {
                txtDisplayCalc.Text += b.Text;
            }
            else if (b.Text == "9")
            {
                txtDisplayCalc.Text += b.Text;
            }
            if (b.Text == ".")
            {
                if (!txtDisplayCalc.Text.Contains("."))
                {
                    txtDisplayCalc.Text = txtDisplayCalc.Text + b.Text;
                }
                else
                {
                    txtDisplayCalc.Text = txtDisplayCalc.Text;
                }
            }
        }

        private void OperClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstNum = double.Parse(txtDisplayCalc.Text);
            oper = b.Text;
            txtDisplayCalc.Clear();
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtDisplayCalc.Text.Length > 0)
            {
                txtDisplayCalc.Text = txtDisplayCalc.Text.Remove(txtDisplayCalc.Text.Length - 1, 1);
            }

            if (txtDisplayCalc.Text.Length == 0)
            {
                txtDisplayCalc.Text = "0";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplayCalc.Text = "0";

            string f, s;
            f = Convert.ToString(firstNum);
            s = Convert.ToString(secondNum);
            f = "";
            s = "";

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplayCalc.Text = "0";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(txtDisplayCalc.Text);
            txtDisplayCalc.Text = Convert.ToString(-1 * p);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNum = double.Parse(txtDisplayCalc.Text);

            switch (oper)
            {
                case "+":
                    txtDisplayCalc.Text = (firstNum + secondNum).ToString();
                    break;
                case "-":
                    txtDisplayCalc.Text = (firstNum - secondNum).ToString();
                    break;
                case "*":
                    txtDisplayCalc.Text = (firstNum * secondNum).ToString();
                    break;
                case "/":
                    txtDisplayCalc.Text = (firstNum / secondNum).ToString();
                    break;
                default:
                    break;

            }
        }

        private void numColdBrew_ValueChanged(object sender, EventArgs e)
        {
            int i = (int)numColdBrew.Value;
            priceColdBrew.Text = string.Format("{0:c2}", i * coldBrew);
        }

        private void numEspresso_ValueChanged(object sender, EventArgs e)
        {
            int i = (int)numEspresso.Value;
            priceEspresso.Text = string.Format("{0:c2}", i * espresso);
        }

        private void numLatte_ValueChanged(object sender, EventArgs e)
        {
            int i = (int)numLatte.Value;
            priceLatte.Text = string.Format("{0:c2}", i * latte);
        }

        private void numFrappe_ValueChanged(object sender, EventArgs e)
        {
            int i = (int)numFrappe.Value;
            priceFrappe.Text = string.Format("{0:C2}", i * frappe);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int totalitems = (int)numFrappe.Value + (int)numLatte.Value + (int)numEspresso.Value + (int)numColdBrew.Value;
            lblTotalItems_num.Text = totalitems.ToString();



            double totalprice = Convert.ToDouble(priceFrappe.Text.Substring(1)) + Convert.ToDouble(priceLatte.Text.Substring(1)) + Convert.ToDouble(priceEspresso.Text.Substring(1)) + Convert.ToDouble(priceColdBrew.Text.Substring(1));
            lblTotalCost_num.Text = string.Format("${0:0.00}", totalprice);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                numColdBrew.Value = 0;
                numEspresso.Value = 0;
                numLatte.Value = 0;
                numFrappe.Value = 0;
                lblTotalItems_num.Text = "0";
                lblTotalCost_num.Text = "$0.00";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            try
            {
                iExit = MessageBox.Show("Are you sure you want to exit?", "Billing System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //ignore this cell content click
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server=localhost;uid=root;" + "pwd=SydneyQL2023?;database=billsys";

            try
            {
                sqlConn.Open();
                sqlQuery = "INSERT INTO billsys.billsys(ColdBrew, " +
                    "Latte, Espresso, Frappe, ColdBrewCost, " +
                    "LatteCost, EspressoCost, FrappeCost)" +
                    "Values('" + numColdBrew.Value + "','" +
                    numLatte.Value + "','" + numEspresso.Value
                    + "','" + numFrappe.Value + "','" +
                    priceColdBrew.Text + "','" + priceLatte.Text
                    + "','" + priceEspresso.Text + "','" +
                    priceFrappe.Text + "')";

                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                DtR = sqlCmd.ExecuteReader();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlConn.Close();
            }

            UploadData();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView1.Height = height;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
