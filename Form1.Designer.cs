namespace CS_BillingSystem_MySQL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel6 = new Panel();
            btnTotal = new Button();
            btnReceipt = new Button();
            btnPrint = new Button();
            btnReset = new Button();
            btnExit = new Button();
            panel5 = new Panel();
            lblTotalCost_num = new Label();
            lblTotalCost = new Label();
            lblTotalItems_num = new Label();
            lblTotalItems = new Label();
            panel4 = new Panel();
            btnDivide = new Button();
            btnEqual = new Button();
            btnDecimal = new Button();
            btn0 = new Button();
            btnMultiply = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnMinus = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnPlus = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnPlusMinus = new Button();
            btnC = new Button();
            btnCE = new Button();
            txtDisplayCalc = new TextBox();
            btnBackSpace = new Button();
            panel3 = new Panel();
            lblPrice = new Label();
            priceFrappe = new Label();
            priceLatte = new Label();
            priceEspresso = new Label();
            priceColdBrew = new Label();
            panel2 = new Panel();
            lblItems = new Label();
            lblFrappe = new Label();
            numFrappe = new NumericUpDown();
            lblLatte = new Label();
            numLatte = new NumericUpDown();
            lblEspresso = new Label();
            numEspresso = new NumericUpDown();
            lblColdBrew = new Label();
            numColdBrew = new NumericUpDown();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFrappe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLatte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEspresso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numColdBrew).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(36, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(1277, 633);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(21, 15);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1231, 584);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(panel6);
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1215, 530);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(btnTotal);
            panel6.Controls.Add(btnReceipt);
            panel6.Controls.Add(btnPrint);
            panel6.Controls.Add(btnReset);
            panel6.Controls.Add(btnExit);
            panel6.Location = new Point(6, 454);
            panel6.Name = "panel6";
            panel6.Size = new Size(775, 65);
            panel6.TabIndex = 4;
            // 
            // btnTotal
            // 
            btnTotal.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnTotal.Location = new Point(7, 3);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(145, 58);
            btnTotal.TabIndex = 28;
            btnTotal.Text = "Total";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // btnReceipt
            // 
            btnReceipt.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnReceipt.Location = new Point(158, 3);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(145, 58);
            btnReceipt.TabIndex = 27;
            btnReceipt.Text = "Receipt";
            btnReceipt.UseVisualStyleBackColor = true;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.Location = new Point(309, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(145, 58);
            btnPrint.TabIndex = 26;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(460, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(145, 58);
            btnReset.TabIndex = 25;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(611, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(145, 58);
            btnExit.TabIndex = 24;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(lblTotalCost_num);
            panel5.Controls.Add(lblTotalCost);
            panel5.Controls.Add(lblTotalItems_num);
            panel5.Controls.Add(lblTotalItems);
            panel5.Location = new Point(6, 383);
            panel5.Name = "panel5";
            panel5.Size = new Size(775, 65);
            panel5.TabIndex = 3;
            // 
            // lblTotalCost_num
            // 
            lblTotalCost_num.BackColor = Color.White;
            lblTotalCost_num.BorderStyle = BorderStyle.Fixed3D;
            lblTotalCost_num.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCost_num.Location = new Point(597, 7);
            lblTotalCost_num.Name = "lblTotalCost_num";
            lblTotalCost_num.Size = new Size(168, 54);
            lblTotalCost_num.TabIndex = 12;
            lblTotalCost_num.Text = "$0.00";
            lblTotalCost_num.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCost.Location = new Point(407, 9);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(184, 47);
            lblTotalCost.TabIndex = 11;
            lblTotalCost.Text = "Total Cost";
            // 
            // lblTotalItems_num
            // 
            lblTotalItems_num.BackColor = Color.White;
            lblTotalItems_num.BorderStyle = BorderStyle.Fixed3D;
            lblTotalItems_num.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalItems_num.Location = new Point(229, 7);
            lblTotalItems_num.Name = "lblTotalItems_num";
            lblTotalItems_num.Size = new Size(136, 54);
            lblTotalItems_num.TabIndex = 10;
            lblTotalItems_num.Text = "0";
            lblTotalItems_num.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalItems
            // 
            lblTotalItems.AutoSize = true;
            lblTotalItems.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalItems.Location = new Point(7, 9);
            lblTotalItems.Name = "lblTotalItems";
            lblTotalItems.Size = new Size(203, 47);
            lblTotalItems.TabIndex = 9;
            lblTotalItems.Text = "Total Items";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(btnDivide);
            panel4.Controls.Add(btnEqual);
            panel4.Controls.Add(btnDecimal);
            panel4.Controls.Add(btn0);
            panel4.Controls.Add(btnMultiply);
            panel4.Controls.Add(btn3);
            panel4.Controls.Add(btn2);
            panel4.Controls.Add(btn1);
            panel4.Controls.Add(btnMinus);
            panel4.Controls.Add(btn6);
            panel4.Controls.Add(btn5);
            panel4.Controls.Add(btn4);
            panel4.Controls.Add(btnPlus);
            panel4.Controls.Add(btn9);
            panel4.Controls.Add(btn8);
            panel4.Controls.Add(btn7);
            panel4.Controls.Add(btnPlusMinus);
            panel4.Controls.Add(btnC);
            panel4.Controls.Add(btnCE);
            panel4.Controls.Add(txtDisplayCalc);
            panel4.Controls.Add(btnBackSpace);
            panel4.Location = new Point(797, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(392, 514);
            panel4.TabIndex = 2;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.Location = new Point(291, 419);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(89, 81);
            btnDivide.TabIndex = 23;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += OperClick;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEqual.Location = new Point(196, 419);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(89, 81);
            btnEqual.TabIndex = 22;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecimal.Location = new Point(101, 419);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(89, 81);
            btnDecimal.TabIndex = 21;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += NumberClick;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(6, 419);
            btn0.Name = "btn0";
            btn0.Size = new Size(89, 81);
            btn0.TabIndex = 20;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += NumberClick;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiply.Location = new Point(291, 332);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(89, 81);
            btnMultiply.TabIndex = 19;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += OperClick;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(196, 332);
            btn3.Name = "btn3";
            btn3.Size = new Size(89, 81);
            btn3.TabIndex = 18;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberClick;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(101, 332);
            btn2.Name = "btn2";
            btn2.Size = new Size(89, 81);
            btn2.TabIndex = 17;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberClick;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(6, 332);
            btn1.Name = "btn1";
            btn1.Size = new Size(89, 81);
            btn1.TabIndex = 16;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberClick;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinus.Location = new Point(291, 245);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(89, 81);
            btnMinus.TabIndex = 15;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += OperClick;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(196, 245);
            btn6.Name = "btn6";
            btn6.Size = new Size(89, 81);
            btn6.TabIndex = 14;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberClick;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(101, 245);
            btn5.Name = "btn5";
            btn5.Size = new Size(89, 81);
            btn5.TabIndex = 13;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberClick;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(6, 245);
            btn4.Name = "btn4";
            btn4.Size = new Size(89, 81);
            btn4.TabIndex = 12;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberClick;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.Location = new Point(291, 158);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(89, 81);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += OperClick;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(196, 158);
            btn9.Name = "btn9";
            btn9.Size = new Size(89, 81);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberClick;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(101, 158);
            btn8.Name = "btn8";
            btn8.Size = new Size(89, 81);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberClick;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(6, 158);
            btn7.Name = "btn7";
            btn7.Size = new Size(89, 81);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberClick;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.Font = new Font("Wingdings", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlusMinus.Location = new Point(291, 71);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(89, 81);
            btnPlusMinus.TabIndex = 7;
            btnPlusMinus.Text = "±";
            btnPlusMinus.UseVisualStyleBackColor = true;
            btnPlusMinus.Click += btnPlusMinus_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnC.Location = new Point(196, 71);
            btnC.Name = "btnC";
            btnC.Size = new Size(89, 81);
            btnC.TabIndex = 6;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnCE
            // 
            btnCE.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCE.Location = new Point(101, 71);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(89, 81);
            btnCE.TabIndex = 5;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // txtDisplayCalc
            // 
            txtDisplayCalc.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            txtDisplayCalc.Location = new Point(3, 5);
            txtDisplayCalc.Multiline = true;
            txtDisplayCalc.Name = "txtDisplayCalc";
            txtDisplayCalc.Size = new Size(377, 62);
            txtDisplayCalc.TabIndex = 1;
            txtDisplayCalc.Text = "0";
            txtDisplayCalc.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBackSpace
            // 
            btnBackSpace.Font = new Font("Wingdings", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackSpace.Location = new Point(6, 71);
            btnBackSpace.Name = "btnBackSpace";
            btnBackSpace.Size = new Size(89, 81);
            btnBackSpace.TabIndex = 0;
            btnBackSpace.Text = "Õ";
            btnBackSpace.UseVisualStyleBackColor = true;
            btnBackSpace.Click += btnBackSpace_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lblPrice);
            panel3.Controls.Add(priceFrappe);
            panel3.Controls.Add(priceLatte);
            panel3.Controls.Add(priceEspresso);
            panel3.Controls.Add(priceColdBrew);
            panel3.Location = new Point(395, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 364);
            panel3.TabIndex = 1;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(141, 15);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(102, 47);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price";
            lblPrice.Click += label14_Click;
            // 
            // priceFrappe
            // 
            priceFrappe.BackColor = Color.White;
            priceFrappe.BorderStyle = BorderStyle.Fixed3D;
            priceFrappe.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            priceFrappe.Location = new Point(18, 284);
            priceFrappe.Name = "priceFrappe";
            priceFrappe.Size = new Size(349, 54);
            priceFrappe.TabIndex = 4;
            priceFrappe.Text = "$0.00";
            priceFrappe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // priceLatte
            // 
            priceLatte.BackColor = Color.White;
            priceLatte.BorderStyle = BorderStyle.Fixed3D;
            priceLatte.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            priceLatte.Location = new Point(18, 217);
            priceLatte.Name = "priceLatte";
            priceLatte.Size = new Size(349, 54);
            priceLatte.TabIndex = 3;
            priceLatte.Text = "$0.00";
            priceLatte.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // priceEspresso
            // 
            priceEspresso.BackColor = Color.White;
            priceEspresso.BorderStyle = BorderStyle.Fixed3D;
            priceEspresso.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            priceEspresso.Location = new Point(18, 148);
            priceEspresso.Name = "priceEspresso";
            priceEspresso.Size = new Size(349, 54);
            priceEspresso.TabIndex = 2;
            priceEspresso.Text = "$0.00";
            priceEspresso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // priceColdBrew
            // 
            priceColdBrew.BackColor = Color.White;
            priceColdBrew.BorderStyle = BorderStyle.Fixed3D;
            priceColdBrew.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            priceColdBrew.Location = new Point(18, 81);
            priceColdBrew.Name = "priceColdBrew";
            priceColdBrew.Size = new Size(349, 54);
            priceColdBrew.TabIndex = 1;
            priceColdBrew.Text = "$0.00";
            priceColdBrew.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblItems);
            panel2.Controls.Add(lblFrappe);
            panel2.Controls.Add(numFrappe);
            panel2.Controls.Add(lblLatte);
            panel2.Controls.Add(numLatte);
            panel2.Controls.Add(lblEspresso);
            panel2.Controls.Add(numEspresso);
            panel2.Controls.Add(lblColdBrew);
            panel2.Controls.Add(numColdBrew);
            panel2.Location = new Point(6, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(383, 364);
            panel2.TabIndex = 0;
            // 
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblItems.Location = new Point(143, 15);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(111, 47);
            lblItems.TabIndex = 8;
            lblItems.Text = "Items";
            lblItems.Click += label13_Click;
            // 
            // lblFrappe
            // 
            lblFrappe.AutoSize = true;
            lblFrappe.Font = new Font("Segoe UI Semibold", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblFrappe.Location = new Point(17, 284);
            lblFrappe.Name = "lblFrappe";
            lblFrappe.Size = new Size(130, 47);
            lblFrappe.TabIndex = 7;
            lblFrappe.Text = "Frappe";
            // 
            // numFrappe
            // 
            numFrappe.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            numFrappe.Location = new Point(245, 282);
            numFrappe.Name = "numFrappe";
            numFrappe.Size = new Size(110, 54);
            numFrappe.TabIndex = 6;
            numFrappe.TextAlign = HorizontalAlignment.Center;
            numFrappe.ValueChanged += numFrappe_ValueChanged;
            // 
            // lblLatte
            // 
            lblLatte.AutoSize = true;
            lblLatte.Font = new Font("Segoe UI Semibold", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblLatte.Location = new Point(17, 217);
            lblLatte.Name = "lblLatte";
            lblLatte.Size = new Size(100, 47);
            lblLatte.TabIndex = 5;
            lblLatte.Text = "Latte";
            // 
            // numLatte
            // 
            numLatte.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            numLatte.Location = new Point(245, 215);
            numLatte.Name = "numLatte";
            numLatte.Size = new Size(110, 54);
            numLatte.TabIndex = 4;
            numLatte.TextAlign = HorizontalAlignment.Center;
            numLatte.ValueChanged += numLatte_ValueChanged;
            // 
            // lblEspresso
            // 
            lblEspresso.AutoSize = true;
            lblEspresso.Font = new Font("Segoe UI Semibold", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblEspresso.Location = new Point(17, 148);
            lblEspresso.Name = "lblEspresso";
            lblEspresso.Size = new Size(157, 47);
            lblEspresso.TabIndex = 3;
            lblEspresso.Text = "Espresso";
            // 
            // numEspresso
            // 
            numEspresso.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            numEspresso.Location = new Point(245, 146);
            numEspresso.Name = "numEspresso";
            numEspresso.Size = new Size(110, 54);
            numEspresso.TabIndex = 2;
            numEspresso.TextAlign = HorizontalAlignment.Center;
            numEspresso.ValueChanged += numEspresso_ValueChanged;
            // 
            // lblColdBrew
            // 
            lblColdBrew.AutoSize = true;
            lblColdBrew.Font = new Font("Segoe UI Semibold", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblColdBrew.Location = new Point(17, 81);
            lblColdBrew.Name = "lblColdBrew";
            lblColdBrew.Size = new Size(182, 47);
            lblColdBrew.TabIndex = 1;
            lblColdBrew.Text = "Cold Brew";
            lblColdBrew.Click += label1_Click;
            // 
            // numColdBrew
            // 
            numColdBrew.Font = new Font("Segoe UI", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            numColdBrew.Location = new Point(245, 79);
            numColdBrew.Name = "numColdBrew";
            numColdBrew.Size = new Size(110, 54);
            numColdBrew.TabIndex = 0;
            numColdBrew.TextAlign = HorizontalAlignment.Center;
            numColdBrew.ValueChanged += numColdBrew_ValueChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Transparent;
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1215, 530);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Data Bills";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1166, 495);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 681);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numFrappe).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLatte).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEspresso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numColdBrew).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel2;
        private Label lblColdBrew;
        private NumericUpDown numColdBrew;
        private Panel panel4;
        private Panel panel3;
        private Label priceColdBrew;
        private Label lblFrappe;
        private NumericUpDown numFrappe;
        private Label lblLatte;
        private NumericUpDown numLatte;
        private Label lblEspresso;
        private NumericUpDown numEspresso;
        private Label priceFrappe;
        private Label priceLatte;
        private Label priceEspresso;
        private Label lblItems;
        private Label lblPrice;
        private TextBox txtDisplayCalc;
        private Button btnBackSpace;
        private Button btnMultiply;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnMinus;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnPlus;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnPlusMinus;
        private Button btnC;
        private Button btnCE;
        private Panel panel5;
        private Button btnDivide;
        private Button btnEqual;
        private Button btnDecimal;
        private Button btn0;
        private Panel panel6;
        private Button btnExit;
        private Button btnTotal;
        private Button btnReceipt;
        private Button btnPrint;
        private Button btnReset;
        private Label lblTotalCost_num;
        private Label lblTotalCost;
        private Label lblTotalItems_num;
        private Label lblTotalItems;
        private DataGridView dataGridView1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}