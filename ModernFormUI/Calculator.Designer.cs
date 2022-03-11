namespace ModernFormUI
{
    partial class Calculator
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.SubBtn = new System.Windows.Forms.Button();
            this.MultBtn = new System.Windows.Forms.Button();
            this.DivBtn = new System.Windows.Forms.Button();
            this.panelCalculator = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.SecondValue = new System.Windows.Forms.TextBox();
            this.FirstValue = new System.Windows.Forms.TextBox();
            this.panelCalculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddBtn.Location = new System.Drawing.Point(43, 329);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(112, 49);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SubBtn
            // 
            this.SubBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubBtn.Location = new System.Drawing.Point(161, 329);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(112, 49);
            this.SubBtn.TabIndex = 0;
            this.SubBtn.Text = "Substract";
            this.SubBtn.UseVisualStyleBackColor = true;
            this.SubBtn.Click += new System.EventHandler(this.SubBtn_Click);
            // 
            // MultBtn
            // 
            this.MultBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MultBtn.Location = new System.Drawing.Point(279, 329);
            this.MultBtn.Name = "MultBtn";
            this.MultBtn.Size = new System.Drawing.Size(112, 49);
            this.MultBtn.TabIndex = 0;
            this.MultBtn.Text = "Multiply";
            this.MultBtn.UseVisualStyleBackColor = true;
            this.MultBtn.Click += new System.EventHandler(this.MultBtn_Click);
            // 
            // DivBtn
            // 
            this.DivBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DivBtn.Location = new System.Drawing.Point(397, 329);
            this.DivBtn.Name = "DivBtn";
            this.DivBtn.Size = new System.Drawing.Size(112, 49);
            this.DivBtn.TabIndex = 0;
            this.DivBtn.Text = "Divide";
            this.DivBtn.UseVisualStyleBackColor = true;
            this.DivBtn.Click += new System.EventHandler(this.DivBtn_Click);
            // 
            // panelCalculator
            // 
            this.panelCalculator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCalculator.BackColor = System.Drawing.Color.DimGray;
            this.panelCalculator.Controls.Add(this.lblResult);
            this.panelCalculator.Controls.Add(this.SecondValue);
            this.panelCalculator.Controls.Add(this.FirstValue);
            this.panelCalculator.Location = new System.Drawing.Point(12, 12);
            this.panelCalculator.Name = "panelCalculator";
            this.panelCalculator.Size = new System.Drawing.Size(540, 311);
            this.panelCalculator.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(31, 136);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 35);
            this.lblResult.TabIndex = 1;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondValue
            // 
            this.SecondValue.Location = new System.Drawing.Point(267, 274);
            this.SecondValue.Name = "SecondValue";
            this.SecondValue.Size = new System.Drawing.Size(230, 23);
            this.SecondValue.TabIndex = 0;
            this.SecondValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FirstValue
            // 
            this.FirstValue.Location = new System.Drawing.Point(31, 274);
            this.FirstValue.Name = "FirstValue";
            this.FirstValue.Size = new System.Drawing.Size(230, 23);
            this.FirstValue.TabIndex = 0;
            this.FirstValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(564, 395);
            this.Controls.Add(this.panelCalculator);
            this.Controls.Add(this.DivBtn);
            this.Controls.Add(this.MultBtn);
            this.Controls.Add(this.SubBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.panelCalculator.ResumeLayout(false);
            this.panelCalculator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SubBtn;
        private System.Windows.Forms.Button MultBtn;
        private System.Windows.Forms.Button DivBtn;
        private System.Windows.Forms.Panel panelCalculator;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox SecondValue;
        private System.Windows.Forms.TextBox FirstValue;
    }
}