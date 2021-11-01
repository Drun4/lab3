
namespace lab4
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
            this.sizeOfVeselBox = new System.Windows.Forms.TextBox();
            this.percentOfAlchBox = new System.Windows.Forms.TextBox();
            this.amountOfVeselsBox = new System.Windows.Forms.TextBox();
            this.valueOfPureAlchBox = new System.Windows.Forms.TextBox();
            this.valueOfDrinksBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sizeOfVeselBox
            // 
            this.sizeOfVeselBox.Location = new System.Drawing.Point(131, 98);
            this.sizeOfVeselBox.Name = "sizeOfVeselBox";
            this.sizeOfVeselBox.Size = new System.Drawing.Size(100, 22);
            this.sizeOfVeselBox.TabIndex = 0;
            // 
            // percentOfAlchBox
            // 
            this.percentOfAlchBox.Location = new System.Drawing.Point(131, 160);
            this.percentOfAlchBox.Name = "percentOfAlchBox";
            this.percentOfAlchBox.Size = new System.Drawing.Size(100, 22);
            this.percentOfAlchBox.TabIndex = 1;
            // 
            // amountOfVeselsBox
            // 
            this.amountOfVeselsBox.Location = new System.Drawing.Point(131, 225);
            this.amountOfVeselsBox.Name = "amountOfVeselsBox";
            this.amountOfVeselsBox.Size = new System.Drawing.Size(100, 22);
            this.amountOfVeselsBox.TabIndex = 2;
            // 
            // valueOfPureAlchBox
            // 
            this.valueOfPureAlchBox.Location = new System.Drawing.Point(642, 160);
            this.valueOfPureAlchBox.Name = "valueOfPureAlchBox";
            this.valueOfPureAlchBox.Size = new System.Drawing.Size(100, 22);
            this.valueOfPureAlchBox.TabIndex = 3;
            // 
            // valueOfDrinksBox
            // 
            this.valueOfDrinksBox.Location = new System.Drawing.Point(474, 160);
            this.valueOfDrinksBox.Name = "valueOfDrinksBox";
            this.valueOfDrinksBox.Size = new System.Drawing.Size(100, 22);
            this.valueOfDrinksBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(487, 246);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(667, 246);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.valueOfDrinksBox);
            this.Controls.Add(this.valueOfPureAlchBox);
            this.Controls.Add(this.amountOfVeselsBox);
            this.Controls.Add(this.percentOfAlchBox);
            this.Controls.Add(this.sizeOfVeselBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sizeOfVeselBox;
        private System.Windows.Forms.TextBox percentOfAlchBox;
        private System.Windows.Forms.TextBox amountOfVeselsBox;
        private System.Windows.Forms.TextBox valueOfPureAlchBox;
        private System.Windows.Forms.TextBox valueOfDrinksBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
    }
}

