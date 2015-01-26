namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.btnProveIt = new System.Windows.Forms.Button();
            this.lbDisplay = new System.Windows.Forms.ListBox();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProveIt
            // 
            this.btnProveIt.Location = new System.Drawing.Point(16, 300);
            this.btnProveIt.Margin = new System.Windows.Forms.Padding(4);
            this.btnProveIt.Name = "btnProveIt";
            this.btnProveIt.Size = new System.Drawing.Size(347, 28);
            this.btnProveIt.TabIndex = 0;
            this.btnProveIt.Text = "Prove It!";
            this.btnProveIt.UseVisualStyleBackColor = true;
            this.btnProveIt.Click += new System.EventHandler(this.btnProveIt_Click);
            // 
            // lbDisplay
            // 
            this.lbDisplay.FormattingEnabled = true;
            this.lbDisplay.ItemHeight = 16;
            this.lbDisplay.Location = new System.Drawing.Point(16, 15);
            this.lbDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(345, 244);
            this.lbDisplay.TabIndex = 2;
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(17, 268);
            this.txtIterations.Margin = new System.Windows.Forms.Padding(4);
            this.txtIterations.MaxLength = 20;
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(344, 22);
            this.txtIterations.TabIndex = 3;
            this.txtIterations.Text = "10000";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 338);
            this.Controls.Add(this.txtIterations);
            this.Controls.Add(this.lbDisplay);
            this.Controls.Add(this.btnProveIt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Binary Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProveIt;
        private System.Windows.Forms.ListBox lbDisplay;
        private System.Windows.Forms.TextBox txtIterations;
    }
}

