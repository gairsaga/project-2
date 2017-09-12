namespace project_2
{
    partial class frmSeating
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalulateRevenue = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTicketSold = new System.Windows.Forms.Label();
            this.lblNumberOfTickets = new System.Windows.Forms.Label();
            this.lblRevenueGenerated = new System.Windows.Forms.Label();
            this.lblClassA = new System.Windows.Forms.Label();
            this.lblClassB = new System.Windows.Forms.Label();
            this.lblClassC = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblClassB1 = new System.Windows.Forms.Label();
            this.lblClassC1 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblRev1 = new System.Windows.Forms.Label();
            this.lblRev2 = new System.Windows.Forms.Label();
            this.lblRev3 = new System.Windows.Forms.Label();
            this.lblRevTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalulateRevenue
            // 
            this.btnCalulateRevenue.Location = new System.Drawing.Point(3, 203);
            this.btnCalulateRevenue.Name = "btnCalulateRevenue";
            this.btnCalulateRevenue.Size = new System.Drawing.Size(71, 34);
            this.btnCalulateRevenue.TabIndex = 0;
            this.btnCalulateRevenue.Text = "Calculate\r\nRevenue\r\n";
            this.btnCalulateRevenue.UseVisualStyleBackColor = true;
            this.btnCalulateRevenue.Click += new System.EventHandler(this.btnCalulateRevenge_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(80, 199);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 43);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(181, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTicketSold
            // 
            this.lblTicketSold.AutoSize = true;
            this.lblTicketSold.Location = new System.Drawing.Point(0, 0);
            this.lblTicketSold.Name = "lblTicketSold";
            this.lblTicketSold.Size = new System.Drawing.Size(61, 13);
            this.lblTicketSold.TabIndex = 3;
            this.lblTicketSold.Text = "Ticket Sold";
            this.lblTicketSold.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumberOfTickets
            // 
            this.lblNumberOfTickets.AutoSize = true;
            this.lblNumberOfTickets.Location = new System.Drawing.Point(0, 28);
            this.lblNumberOfTickets.Name = "lblNumberOfTickets";
            this.lblNumberOfTickets.Size = new System.Drawing.Size(138, 26);
            this.lblNumberOfTickets.TabIndex = 4;
            this.lblNumberOfTickets.Text = "Enter the number of tickets\r\n sold for each class of seats";
            this.lblNumberOfTickets.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRevenueGenerated
            // 
            this.lblRevenueGenerated.AutoSize = true;
            this.lblRevenueGenerated.Location = new System.Drawing.Point(168, 9);
            this.lblRevenueGenerated.Name = "lblRevenueGenerated";
            this.lblRevenueGenerated.Size = new System.Drawing.Size(104, 13);
            this.lblRevenueGenerated.TabIndex = 5;
            this.lblRevenueGenerated.Text = "Revenue Generated";
            // 
            // lblClassA
            // 
            this.lblClassA.AutoSize = true;
            this.lblClassA.Location = new System.Drawing.Point(0, 64);
            this.lblClassA.Name = "lblClassA";
            this.lblClassA.Size = new System.Drawing.Size(42, 13);
            this.lblClassA.TabIndex = 6;
            this.lblClassA.Text = "Class A";
            // 
            // lblClassB
            // 
            this.lblClassB.AutoSize = true;
            this.lblClassB.Location = new System.Drawing.Point(0, 84);
            this.lblClassB.Name = "lblClassB";
            this.lblClassB.Size = new System.Drawing.Size(42, 13);
            this.lblClassB.TabIndex = 7;
            this.lblClassB.Text = "Class B";
            // 
            // lblClassC
            // 
            this.lblClassC.AutoSize = true;
            this.lblClassC.Location = new System.Drawing.Point(0, 109);
            this.lblClassC.Name = "lblClassC";
            this.lblClassC.Size = new System.Drawing.Size(42, 13);
            this.lblClassC.TabIndex = 8;
            this.lblClassC.Text = "Class C";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(141, 61);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(42, 13);
            this.lblClass.TabIndex = 9;
            this.lblClass.Text = "Class A";
            this.lblClass.Click += new System.EventHandler(this.lblClass_Click);
            // 
            // lblClassB1
            // 
            this.lblClassB1.AutoSize = true;
            this.lblClassB1.Location = new System.Drawing.Point(141, 84);
            this.lblClassB1.Name = "lblClassB1";
            this.lblClassB1.Size = new System.Drawing.Size(39, 13);
            this.lblClassB1.TabIndex = 10;
            this.lblClassB1.Text = "ClassB";
            // 
            // lblClassC1
            // 
            this.lblClassC1.AutoSize = true;
            this.lblClassC1.Location = new System.Drawing.Point(138, 111);
            this.lblClassC1.Name = "lblClassC1";
            this.lblClassC1.Size = new System.Drawing.Size(42, 13);
            this.lblClassC1.TabIndex = 11;
            this.lblClassC1.Text = "Class C";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(38, 84);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 12;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(38, 61);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 13;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(38, 108);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 14;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(132, 139);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total";
            // 
            // lblRev1
            // 
            this.lblRev1.AutoSize = true;
            this.lblRev1.Location = new System.Drawing.Point(199, 64);
            this.lblRev1.Name = "lblRev1";
            this.lblRev1.Size = new System.Drawing.Size(37, 13);
            this.lblRev1.TabIndex = 19;
            this.lblRev1.Text = "Rev A";
            // 
            // lblRev2
            // 
            this.lblRev2.AutoSize = true;
            this.lblRev2.Location = new System.Drawing.Point(186, 87);
            this.lblRev2.Name = "lblRev2";
            this.lblRev2.Size = new System.Drawing.Size(37, 13);
            this.lblRev2.TabIndex = 20;
            this.lblRev2.Text = "Rev B";
            // 
            // lblRev3
            // 
            this.lblRev3.AutoSize = true;
            this.lblRev3.Location = new System.Drawing.Point(186, 109);
            this.lblRev3.Name = "lblRev3";
            this.lblRev3.Size = new System.Drawing.Size(37, 13);
            this.lblRev3.TabIndex = 21;
            this.lblRev3.Text = "Rev C";
            // 
            // lblRevTotal
            // 
            this.lblRevTotal.AutoSize = true;
            this.lblRevTotal.Location = new System.Drawing.Point(190, 139);
            this.lblRevTotal.Name = "lblRevTotal";
            this.lblRevTotal.Size = new System.Drawing.Size(54, 13);
            this.lblRevTotal.TabIndex = 22;
            this.lblRevTotal.Text = "Rev Total";
            // 
            // frmSeating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblRevTotal);
            this.Controls.Add(this.lblRev3);
            this.Controls.Add(this.lblRev2);
            this.Controls.Add(this.lblRev1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lblClassC1);
            this.Controls.Add(this.lblClassB1);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblClassC);
            this.Controls.Add(this.lblClassB);
            this.Controls.Add(this.lblClassA);
            this.Controls.Add(this.lblRevenueGenerated);
            this.Controls.Add(this.lblNumberOfTickets);
            this.Controls.Add(this.lblTicketSold);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalulateRevenue);
            this.Name = "frmSeating";
            this.Text = "frmSeating";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalulateRevenue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTicketSold;
        private System.Windows.Forms.Label lblNumberOfTickets;
        private System.Windows.Forms.Label lblRevenueGenerated;
        private System.Windows.Forms.Label lblClassA;
        private System.Windows.Forms.Label lblClassB;
        private System.Windows.Forms.Label lblClassC;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblClassB1;
        private System.Windows.Forms.Label lblClassC1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRev1;
        private System.Windows.Forms.Label lblRev2;
        private System.Windows.Forms.Label lblRev3;
        private System.Windows.Forms.Label lblRevTotal;
    }
}

