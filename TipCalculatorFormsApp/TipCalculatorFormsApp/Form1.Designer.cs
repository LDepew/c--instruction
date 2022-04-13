namespace TipCalculatorFormsApp
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
            this.TipCalculator = new System.Windows.Forms.Label();
            this.CostOfMealTxt = new System.Windows.Forms.Label();
            this.CostOfMealInput = new System.Windows.Forms.TextBox();
            this.fifteenpercent = new System.Windows.Forms.Label();
            this.tipamountfifteen = new System.Windows.Forms.Label();
            this.totalamountfifteen = new System.Windows.Forms.Label();
            this.twentypercent = new System.Windows.Forms.Label();
            this.tipamounttwenty = new System.Windows.Forms.Label();
            this.totalamounttwenty = new System.Windows.Forms.Label();
            this.twentyfivepercent = new System.Windows.Forms.Label();
            this.tipamounttwentyfive = new System.Windows.Forms.Label();
            this.totalamounttwentyfive = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TipCalculator
            // 
            this.TipCalculator.AutoSize = true;
            this.TipCalculator.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TipCalculator.Location = new System.Drawing.Point(12, 9);
            this.TipCalculator.Name = "TipCalculator";
            this.TipCalculator.Size = new System.Drawing.Size(173, 32);
            this.TipCalculator.TabIndex = 0;
            this.TipCalculator.Text = "Tip Calculator";
            // 
            // CostOfMealTxt
            // 
            this.CostOfMealTxt.AutoSize = true;
            this.CostOfMealTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CostOfMealTxt.Location = new System.Drawing.Point(19, 64);
            this.CostOfMealTxt.Name = "CostOfMealTxt";
            this.CostOfMealTxt.Size = new System.Drawing.Size(100, 21);
            this.CostOfMealTxt.TabIndex = 1;
            this.CostOfMealTxt.Text = "Cost of meal:";
            // 
            // CostOfMealInput
            // 
            this.CostOfMealInput.Location = new System.Drawing.Point(125, 66);
            this.CostOfMealInput.Name = "CostOfMealInput";
            this.CostOfMealInput.Size = new System.Drawing.Size(174, 23);
            this.CostOfMealInput.TabIndex = 2;
            this.CostOfMealInput.TextChanged += new System.EventHandler(this.CostOfMealInput_TextChanged);
            // 
            // fifteenpercent
            // 
            this.fifteenpercent.AutoSize = true;
            this.fifteenpercent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fifteenpercent.Location = new System.Drawing.Point(19, 126);
            this.fifteenpercent.Name = "fifteenpercent";
            this.fifteenpercent.Size = new System.Drawing.Size(42, 21);
            this.fifteenpercent.TabIndex = 3;
            this.fifteenpercent.Text = "15%";
            // 
            // tipamountfifteen
            // 
            this.tipamountfifteen.AutoSize = true;
            this.tipamountfifteen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipamountfifteen.Location = new System.Drawing.Point(23, 160);
            this.tipamountfifteen.Name = "tipamountfifteen";
            this.tipamountfifteen.Size = new System.Drawing.Size(92, 21);
            this.tipamountfifteen.TabIndex = 4;
            this.tipamountfifteen.Text = "Tip amount:";
            // 
            // totalamountfifteen
            // 
            this.totalamountfifteen.AutoSize = true;
            this.totalamountfifteen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalamountfifteen.Location = new System.Drawing.Point(23, 200);
            this.totalamountfifteen.Name = "totalamountfifteen";
            this.totalamountfifteen.Size = new System.Drawing.Size(103, 21);
            this.totalamountfifteen.TabIndex = 5;
            this.totalamountfifteen.Text = "Total amount:";
            // 
            // twentypercent
            // 
            this.twentypercent.AutoSize = true;
            this.twentypercent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.twentypercent.Location = new System.Drawing.Point(23, 274);
            this.twentypercent.Name = "twentypercent";
            this.twentypercent.Size = new System.Drawing.Size(42, 21);
            this.twentypercent.TabIndex = 6;
            this.twentypercent.Text = "20%";
            this.twentypercent.Click += new System.EventHandler(this.twentypercent_Click);
            // 
            // tipamounttwenty
            // 
            this.tipamounttwenty.AutoSize = true;
            this.tipamounttwenty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipamounttwenty.Location = new System.Drawing.Point(23, 311);
            this.tipamounttwenty.Name = "tipamounttwenty";
            this.tipamounttwenty.Size = new System.Drawing.Size(92, 21);
            this.tipamounttwenty.TabIndex = 7;
            this.tipamounttwenty.Text = "Tip amount:";
            // 
            // totalamounttwenty
            // 
            this.totalamounttwenty.AutoSize = true;
            this.totalamounttwenty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalamounttwenty.Location = new System.Drawing.Point(23, 348);
            this.totalamounttwenty.Name = "totalamounttwenty";
            this.totalamounttwenty.Size = new System.Drawing.Size(103, 21);
            this.totalamounttwenty.TabIndex = 8;
            this.totalamounttwenty.Text = "Total amount:";
            // 
            // twentyfivepercent
            // 
            this.twentyfivepercent.AutoSize = true;
            this.twentyfivepercent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.twentyfivepercent.Location = new System.Drawing.Point(26, 427);
            this.twentyfivepercent.Name = "twentyfivepercent";
            this.twentyfivepercent.Size = new System.Drawing.Size(42, 21);
            this.twentyfivepercent.TabIndex = 9;
            this.twentyfivepercent.Text = "25%";
            // 
            // tipamounttwentyfive
            // 
            this.tipamounttwentyfive.AutoSize = true;
            this.tipamounttwentyfive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipamounttwentyfive.Location = new System.Drawing.Point(26, 469);
            this.tipamounttwentyfive.Name = "tipamounttwentyfive";
            this.tipamounttwentyfive.Size = new System.Drawing.Size(92, 21);
            this.tipamounttwentyfive.TabIndex = 10;
            this.tipamounttwentyfive.Text = "Tip amount:";
            // 
            // totalamounttwentyfive
            // 
            this.totalamounttwentyfive.AutoSize = true;
            this.totalamounttwentyfive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalamounttwentyfive.Location = new System.Drawing.Point(28, 513);
            this.totalamounttwentyfive.Name = "totalamounttwentyfive";
            this.totalamounttwentyfive.Size = new System.Drawing.Size(103, 21);
            this.totalamounttwentyfive.TabIndex = 11;
            this.totalamounttwentyfive.Text = "Total amount:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(305, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 646);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalamounttwentyfive);
            this.Controls.Add(this.tipamounttwentyfive);
            this.Controls.Add(this.twentyfivepercent);
            this.Controls.Add(this.totalamounttwenty);
            this.Controls.Add(this.tipamounttwenty);
            this.Controls.Add(this.twentypercent);
            this.Controls.Add(this.totalamountfifteen);
            this.Controls.Add(this.tipamountfifteen);
            this.Controls.Add(this.fifteenpercent);
            this.Controls.Add(this.CostOfMealInput);
            this.Controls.Add(this.CostOfMealTxt);
            this.Controls.Add(this.TipCalculator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TipCalculator;
        private System.Windows.Forms.Label CostOfMealTxt;
        private System.Windows.Forms.TextBox CostOfMealInput;
        private System.Windows.Forms.Label fifteenpercent;
        private System.Windows.Forms.Label tipamountfifteen;
        private System.Windows.Forms.Label totalamountfifteen;
        private System.Windows.Forms.Label twentypercent;
        private System.Windows.Forms.Label tipamounttwenty;
        private System.Windows.Forms.Label totalamounttwenty;
        private System.Windows.Forms.Label twentyfivepercent;
        private System.Windows.Forms.Label tipamounttwentyfive;
        private System.Windows.Forms.Label totalamounttwentyfive;
        private System.Windows.Forms.Button button1;
    }
}
