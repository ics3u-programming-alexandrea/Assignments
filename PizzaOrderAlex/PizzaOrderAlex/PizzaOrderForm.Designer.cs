namespace PizzaOrderAlex
{
    partial class frmPizzaOrder
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
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblMLarge = new System.Windows.Forms.Label();
            this.lblLarge = new System.Windows.Forms.Label();
            this.lblSmall = new System.Windows.Forms.Label();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblXLarge = new System.Windows.Forms.Label();
            this.lblXXLarge = new System.Windows.Forms.Label();
            this.nudPizza = new System.Windows.Forms.NumericUpDown();
            this.lblToppings = new System.Windows.Forms.Label();
            this.nudToppings = new System.Windows.Forms.NumericUpDown();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblCSubtotal = new System.Windows.Forms.Label();
            this.lblHST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCHST = new System.Windows.Forms.Label();
            this.lblCTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbProvinces = new System.Windows.Forms.GroupBox();
            this.radAlberta = new System.Windows.Forms.RadioButton();
            this.radOntario = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).BeginInit();
            this.grbProvinces.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(38, 35);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(370, 24);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Select the size of Pizza you would like:";
            // 
            // lblMLarge
            // 
            this.lblMLarge.AutoSize = true;
            this.lblMLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMLarge.Location = new System.Drawing.Point(72, 138);
            this.lblMLarge.Name = "lblMLarge";
            this.lblMLarge.Size = new System.Drawing.Size(152, 20);
            this.lblMLarge.TabIndex = 1;
            this.lblMLarge.Text = "Medium Large = 3";
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLarge.Location = new System.Drawing.Point(71, 162);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(85, 20);
            this.lblLarge.TabIndex = 2;
            this.lblLarge.Text = "Large = 4";
            // 
            // lblSmall
            // 
            this.lblSmall.AutoSize = true;
            this.lblSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmall.Location = new System.Drawing.Point(72, 82);
            this.lblSmall.Name = "lblSmall";
            this.lblSmall.Size = new System.Drawing.Size(83, 20);
            this.lblSmall.TabIndex = 3;
            this.lblSmall.Text = "Small = 1";
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedium.Location = new System.Drawing.Point(72, 113);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(101, 20);
            this.lblMedium.TabIndex = 4;
            this.lblMedium.Text = "Medium = 2";
            // 
            // lblXLarge
            // 
            this.lblXLarge.AutoSize = true;
            this.lblXLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXLarge.Location = new System.Drawing.Point(72, 184);
            this.lblXLarge.Name = "lblXLarge";
            this.lblXLarge.Size = new System.Drawing.Size(132, 20);
            this.lblXLarge.TabIndex = 5;
            this.lblXLarge.Text = "Extra Large = 5";
            // 
            // lblXXLarge
            // 
            this.lblXXLarge.AutoSize = true;
            this.lblXXLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXXLarge.Location = new System.Drawing.Point(71, 207);
            this.lblXXLarge.Name = "lblXXLarge";
            this.lblXXLarge.Size = new System.Drawing.Size(179, 20);
            this.lblXXLarge.TabIndex = 6;
            this.lblXXLarge.Text = "Extra Extra Large = 6";
            // 
            // nudPizza
            // 
            this.nudPizza.Location = new System.Drawing.Point(551, 35);
            this.nudPizza.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudPizza.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPizza.Name = "nudPizza";
            this.nudPizza.Size = new System.Drawing.Size(100, 20);
            this.nudPizza.TabIndex = 7;
            this.nudPizza.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(30, 267);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(378, 20);
            this.lblToppings.TabIndex = 8;
            this.lblToppings.Text = "Select the Number of Toppings you would like:";
            // 
            // nudToppings
            // 
            this.nudToppings.Location = new System.Drawing.Point(551, 266);
            this.nudToppings.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudToppings.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudToppings.Name = "nudToppings";
            this.nudToppings.Size = new System.Drawing.Size(120, 20);
            this.nudToppings.TabIndex = 9;
            this.nudToppings.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(79, 352);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(87, 20);
            this.lblSubtotal.TabIndex = 10;
            this.lblSubtotal.Text = "Subtotal :";
            // 
            // lblCSubtotal
            // 
            this.lblCSubtotal.AutoSize = true;
            this.lblCSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSubtotal.Location = new System.Drawing.Point(224, 352);
            this.lblCSubtotal.Name = "lblCSubtotal";
            this.lblCSubtotal.Size = new System.Drawing.Size(57, 20);
            this.lblCSubtotal.TabIndex = 11;
            this.lblCSubtotal.Text = "label1";
            // 
            // lblHST
            // 
            this.lblHST.AutoSize = true;
            this.lblHST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHST.Location = new System.Drawing.Point(79, 395);
            this.lblHST.Name = "lblHST";
            this.lblHST.Size = new System.Drawing.Size(49, 20);
            this.lblHST.TabIndex = 12;
            this.lblHST.Text = "HST:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(79, 460);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total:";
            // 
            // lblCHST
            // 
            this.lblCHST.AutoSize = true;
            this.lblCHST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCHST.Location = new System.Drawing.Point(224, 395);
            this.lblCHST.Name = "lblCHST";
            this.lblCHST.Size = new System.Drawing.Size(57, 20);
            this.lblCHST.TabIndex = 16;
            this.lblCHST.Text = "label2";
            // 
            // lblCTotal
            // 
            this.lblCTotal.AutoSize = true;
            this.lblCTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTotal.Location = new System.Drawing.Point(224, 460);
            this.lblCTotal.Name = "lblCTotal";
            this.lblCTotal.Size = new System.Drawing.Size(57, 20);
            this.lblCTotal.TabIndex = 17;
            this.lblCTotal.Text = "label3";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(548, 371);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 31);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // grbProvinces
            // 
            this.grbProvinces.Controls.Add(this.radAlberta);
            this.grbProvinces.Controls.Add(this.radOntario);
            this.grbProvinces.Location = new System.Drawing.Point(724, 217);
            this.grbProvinces.Name = "grbProvinces";
            this.grbProvinces.Size = new System.Drawing.Size(135, 84);
            this.grbProvinces.TabIndex = 19;
            this.grbProvinces.TabStop = false;
            this.grbProvinces.Text = "Provinces";
            // 
            // radAlberta
            // 
            this.radAlberta.AutoSize = true;
            this.radAlberta.Location = new System.Drawing.Point(17, 53);
            this.radAlberta.Name = "radAlberta";
            this.radAlberta.Size = new System.Drawing.Size(58, 17);
            this.radAlberta.TabIndex = 1;
            this.radAlberta.Text = "Alberta";
            this.radAlberta.UseVisualStyleBackColor = true;
            // 
            // radOntario
            // 
            this.radOntario.AutoSize = true;
            this.radOntario.Checked = true;
            this.radOntario.Location = new System.Drawing.Point(17, 20);
            this.radOntario.Name = "radOntario";
            this.radOntario.Size = new System.Drawing.Size(59, 17);
            this.radOntario.TabIndex = 0;
            this.radOntario.TabStop = true;
            this.radOntario.Text = "Ontario";
            this.radOntario.UseVisualStyleBackColor = true;
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 561);
            this.Controls.Add(this.grbProvinces);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCTotal);
            this.Controls.Add(this.lblCHST);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblHST);
            this.Controls.Add(this.lblCSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.nudToppings);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.nudPizza);
            this.Controls.Add(this.lblXXLarge);
            this.Controls.Add(this.lblXLarge);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.lblSmall);
            this.Controls.Add(this.lblLarge);
            this.Controls.Add(this.lblMLarge);
            this.Controls.Add(this.lblSelect);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order by Alex";
            ((System.ComponentModel.ISupportInitialize)(this.nudPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).EndInit();
            this.grbProvinces.ResumeLayout(false);
            this.grbProvinces.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblMLarge;
        private System.Windows.Forms.Label lblLarge;
        private System.Windows.Forms.Label lblSmall;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblXLarge;
        private System.Windows.Forms.Label lblXXLarge;
        private System.Windows.Forms.NumericUpDown nudPizza;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.NumericUpDown nudToppings;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblCSubtotal;
        private System.Windows.Forms.Label lblHST;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCHST;
        private System.Windows.Forms.Label lblCTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbProvinces;
        private System.Windows.Forms.RadioButton radAlberta;
        private System.Windows.Forms.RadioButton radOntario;
    }
}

