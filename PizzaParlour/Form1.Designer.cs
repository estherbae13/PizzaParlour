
namespace PizzaParlour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pizzaLabel = new System.Windows.Forms.Label();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.toppingsInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.toppingsOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pizzaLabel
            // 
            this.pizzaLabel.BackColor = System.Drawing.Color.IndianRed;
            this.pizzaLabel.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaLabel.ForeColor = System.Drawing.Color.White;
            this.pizzaLabel.Location = new System.Drawing.Point(0, 0);
            this.pizzaLabel.Name = "pizzaLabel";
            this.pizzaLabel.Size = new System.Drawing.Size(544, 91);
            this.pizzaLabel.TabIndex = 0;
            this.pizzaLabel.Text = "Pizza Parlour";
            this.pizzaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.toppingsLabel.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingsLabel.Location = new System.Drawing.Point(12, 146);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(257, 35);
            this.toppingsLabel.TabIndex = 1;
            this.toppingsLabel.Text = "Number of Toppings";
            // 
            // toppingsInput
            // 
            this.toppingsInput.Font = new System.Drawing.Font("Candara Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingsInput.Location = new System.Drawing.Point(288, 140);
            this.toppingsInput.Name = "toppingsInput";
            this.toppingsInput.Size = new System.Drawing.Size(243, 47);
            this.toppingsInput.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.White;
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(185, 247);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(157, 49);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // toppingsOutput
            // 
            this.toppingsOutput.BackColor = System.Drawing.Color.White;
            this.toppingsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toppingsOutput.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingsOutput.Location = new System.Drawing.Point(15, 334);
            this.toppingsOutput.Name = "toppingsOutput";
            this.toppingsOutput.Size = new System.Drawing.Size(510, 79);
            this.toppingsOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(543, 465);
            this.Controls.Add(this.toppingsOutput);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.toppingsInput);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.pizzaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza Parlour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pizzaLabel;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.TextBox toppingsInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label toppingsOutput;
    }
}

