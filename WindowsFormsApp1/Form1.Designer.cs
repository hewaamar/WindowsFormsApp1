
namespace WindowsFormsApp1
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
            this.hockeyButton = new System.Windows.Forms.Button();
            this.areaButton = new System.Windows.Forms.Button();
            this.carpetButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.outputLabelHockey = new System.Windows.Forms.Label();
            this.outputLabelArea = new System.Windows.Forms.Label();
            this.outputLabelCarpet = new System.Windows.Forms.Label();
            this.outputLabelBill = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hockeyButton
            // 
            this.hockeyButton.Location = new System.Drawing.Point(43, 32);
            this.hockeyButton.Name = "hockeyButton";
            this.hockeyButton.Size = new System.Drawing.Size(161, 64);
            this.hockeyButton.TabIndex = 0;
            this.hockeyButton.Text = "Hockey";
            this.hockeyButton.UseVisualStyleBackColor = true;
            this.hockeyButton.Click += new System.EventHandler(this.hockeyButton_Click);
            // 
            // areaButton
            // 
            this.areaButton.Location = new System.Drawing.Point(43, 135);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(161, 64);
            this.areaButton.TabIndex = 1;
            this.areaButton.Text = "Area";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // carpetButton
            // 
            this.carpetButton.Location = new System.Drawing.Point(42, 231);
            this.carpetButton.Name = "carpetButton";
            this.carpetButton.Size = new System.Drawing.Size(161, 64);
            this.carpetButton.TabIndex = 2;
            this.carpetButton.Text = "Carpet";
            this.carpetButton.UseVisualStyleBackColor = true;
            this.carpetButton.Click += new System.EventHandler(this.carpetButton_Click);
            // 
            // billButton
            // 
            this.billButton.Location = new System.Drawing.Point(43, 338);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(161, 64);
            this.billButton.TabIndex = 3;
            this.billButton.Text = "Bill";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // outputLabelHockey
            // 
            this.outputLabelHockey.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputLabelHockey.Location = new System.Drawing.Point(384, 54);
            this.outputLabelHockey.Name = "outputLabelHockey";
            this.outputLabelHockey.Size = new System.Drawing.Size(505, 370);
            this.outputLabelHockey.TabIndex = 4;
            this.outputLabelHockey.Click += new System.EventHandler(this.hockeyButton_Click);
            // 
            // outputLabelArea
            // 
            this.outputLabelArea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputLabelArea.Location = new System.Drawing.Point(384, 54);
            this.outputLabelArea.Name = "outputLabelArea";
            this.outputLabelArea.Size = new System.Drawing.Size(505, 370);
            this.outputLabelArea.TabIndex = 5;
            // 
            // outputLabelCarpet
            // 
            this.outputLabelCarpet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputLabelCarpet.Location = new System.Drawing.Point(384, 54);
            this.outputLabelCarpet.Name = "outputLabelCarpet";
            this.outputLabelCarpet.Size = new System.Drawing.Size(505, 370);
            this.outputLabelCarpet.TabIndex = 6;
            // 
            // outputLabelBill
            // 
            this.outputLabelBill.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputLabelBill.Location = new System.Drawing.Point(384, 54);
            this.outputLabelBill.Name = "outputLabelBill";
            this.outputLabelBill.Size = new System.Drawing.Size(505, 370);
            this.outputLabelBill.TabIndex = 7;
            this.outputLabelBill.Click += new System.EventHandler(this.billButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 490);
            this.Controls.Add(this.outputLabelBill);
            this.Controls.Add(this.outputLabelCarpet);
            this.Controls.Add(this.outputLabelArea);
            this.Controls.Add(this.outputLabelHockey);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.carpetButton);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.hockeyButton);
            this.Name = "Form1";
            this.Text = "Variables Practice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hockeyButton;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Button carpetButton;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.Label outputLabelHockey;
        private System.Windows.Forms.Label outputLabelArea;
        private System.Windows.Forms.Label outputLabelCarpet;
        private System.Windows.Forms.Label outputLabelBill;
    }
}

