namespace Activity11
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
            this.RollDice = new System.Windows.Forms.Button();
            this.Dice1Sides = new System.Windows.Forms.TextBox();
            this.Dice2Sides = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RollDice
            // 
            this.RollDice.Location = new System.Drawing.Point(99, 53);
            this.RollDice.Name = "RollDice";
            this.RollDice.Size = new System.Drawing.Size(75, 23);
            this.RollDice.TabIndex = 0;
            this.RollDice.Text = "Roll Dice";
            this.RollDice.UseVisualStyleBackColor = true;
            this.RollDice.Click += new System.EventHandler(this.RollDice_Click);
            // 
            // Dice1Sides
            // 
            this.Dice1Sides.Location = new System.Drawing.Point(180, 55);
            this.Dice1Sides.Name = "Dice1Sides";
            this.Dice1Sides.Size = new System.Drawing.Size(50, 20);
            this.Dice1Sides.TabIndex = 1;
            // 
            // Dice2Sides
            // 
            this.Dice2Sides.Location = new System.Drawing.Point(236, 55);
            this.Dice2Sides.Name = "Dice2Sides";
            this.Dice2Sides.Size = new System.Drawing.Size(50, 20);
            this.Dice2Sides.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 164);
            this.Controls.Add(this.Dice2Sides);
            this.Controls.Add(this.Dice1Sides);
            this.Controls.Add(this.RollDice);
            this.Name = "Form1";
            this.Text = "Dice Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RollDice;
        private System.Windows.Forms.TextBox Dice1Sides;
        private System.Windows.Forms.TextBox Dice2Sides;
    }
}

