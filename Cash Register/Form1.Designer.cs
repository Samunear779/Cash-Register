namespace Cash_Register
{
    partial class Form1
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
            this.title = new System.Windows.Forms.Label();
            this.burger = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputB = new System.Windows.Forms.TextBox();
            this.inputF = new System.Windows.Forms.TextBox();
            this.inputW = new System.Windows.Forms.TextBox();
            this.inputD = new System.Windows.Forms.TextBox();
            this.print = new System.Windows.Forms.Button();
            this.newOrder = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.calculateTotals = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.Label();
            this.givenMoney = new System.Windows.Forms.TextBox();
            this.calculateChange = new System.Windows.Forms.Button();
            this.zeroLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(153, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(494, 76);
            this.title.TabIndex = 0;
            this.title.Text = "Magnificent Menu";
            // 
            // burger
            // 
            this.burger.AutoSize = true;
            this.burger.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burger.Location = new System.Drawing.Point(63, 117);
            this.burger.Name = "burger";
            this.burger.Size = new System.Drawing.Size(174, 33);
            this.burger.TabIndex = 1;
            this.burger.Text = "Burger..... 2.49";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fries........... 1.89";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wrap......... 2.99";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Drink...... 0.99";
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(243, 126);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(39, 20);
            this.inputB.TabIndex = 5;
            // 
            // inputF
            // 
            this.inputF.Location = new System.Drawing.Point(243, 159);
            this.inputF.Name = "inputF";
            this.inputF.Size = new System.Drawing.Size(39, 20);
            this.inputF.TabIndex = 6;
            // 
            // inputW
            // 
            this.inputW.Location = new System.Drawing.Point(243, 192);
            this.inputW.Name = "inputW";
            this.inputW.Size = new System.Drawing.Size(39, 20);
            this.inputW.TabIndex = 7;
            // 
            // inputD
            // 
            this.inputD.Location = new System.Drawing.Point(243, 228);
            this.inputD.Name = "inputD";
            this.inputD.Size = new System.Drawing.Size(39, 20);
            this.inputD.TabIndex = 8;
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(116, 413);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(98, 42);
            this.print.TabIndex = 10;
            this.print.Text = "Print Receipt";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // newOrder
            // 
            this.newOrder.Location = new System.Drawing.Point(220, 413);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(98, 42);
            this.newOrder.TabIndex = 11;
            this.newOrder.Text = "Place New Order";
            this.newOrder.UseVisualStyleBackColor = true;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(28, 276);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 22);
            this.outputLabel.TabIndex = 12;
            // 
            // calculateTotals
            // 
            this.calculateTotals.Location = new System.Drawing.Point(12, 365);
            this.calculateTotals.Name = "calculateTotals";
            this.calculateTotals.Size = new System.Drawing.Size(98, 42);
            this.calculateTotals.TabIndex = 13;
            this.calculateTotals.Text = "Calculate Totals ";
            this.calculateTotals.UseVisualStyleBackColor = true;
            this.calculateTotals.Click += new System.EventHandler(this.calculateTotals_Click);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money.Location = new System.Drawing.Point(120, 366);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(135, 38);
            this.money.TabIndex = 14;
            this.money.Text = "Tendered";
            // 
            // givenMoney
            // 
            this.givenMoney.Location = new System.Drawing.Point(261, 378);
            this.givenMoney.Name = "givenMoney";
            this.givenMoney.Size = new System.Drawing.Size(38, 20);
            this.givenMoney.TabIndex = 15;
            // 
            // calculateChange
            // 
            this.calculateChange.Location = new System.Drawing.Point(12, 413);
            this.calculateChange.Name = "calculateChange";
            this.calculateChange.Size = new System.Drawing.Size(97, 42);
            this.calculateChange.TabIndex = 16;
            this.calculateChange.Text = "Calculate Change ";
            this.calculateChange.UseVisualStyleBackColor = true;
            this.calculateChange.Click += new System.EventHandler(this.calculateChange_Click);
            // 
            // zeroLabel
            // 
            this.zeroLabel.AutoSize = true;
            this.zeroLabel.BackColor = System.Drawing.Color.Transparent;
            this.zeroLabel.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroLabel.Location = new System.Drawing.Point(27, 74);
            this.zeroLabel.Name = "zeroLabel";
            this.zeroLabel.Size = new System.Drawing.Size(461, 30);
            this.zeroLabel.TabIndex = 17;
            this.zeroLabel.Text = "Please enter a zero if you dont ant an item";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(749, 484);
            this.Controls.Add(this.zeroLabel);
            this.Controls.Add(this.calculateChange);
            this.Controls.Add(this.givenMoney);
            this.Controls.Add(this.money);
            this.Controls.Add(this.calculateTotals);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.print);
            this.Controls.Add(this.inputD);
            this.Controls.Add(this.inputW);
            this.Controls.Add(this.inputF);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.burger);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label burger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.TextBox inputF;
        private System.Windows.Forms.TextBox inputW;
        private System.Windows.Forms.TextBox inputD;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button calculateTotals;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.TextBox givenMoney;
        private System.Windows.Forms.Button calculateChange;
        private System.Windows.Forms.Label zeroLabel;
    }
}

