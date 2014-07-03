using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProveIt_Click(object sender, EventArgs e)
        {
            lbDisplay.Items.Clear();
            BinaryInsert bi = new BinaryInsert();
            int iterations;
            try
            {
                iterations = System.Convert.ToInt32(txtIterations.Text);

                if (iterations <= 0)
                {
                    MessageBox.Show("Iterations must be a number greater than zero!");
                    return;
                }
                else if (iterations > 400000)
                {
                    MessageBox.Show("Please keep your iterations to 400,000 or lower.");
                }
            }
            catch
            {
                MessageBox.Show("Iterations must be a number!");
                return;
            }
            bi.Start(iterations);
            bi.StartValidate();
            DialogResult dr = MessageBox.Show("It took " + bi.timeElapsed.TotalSeconds
                + " seconds to insert " + bi.iterations
                + " values into an originally empty list."
                + Environment.NewLine
                + "Would you like to view the results?"
                + Environment.NewLine
                + "Large iteration values may take awhile to display.", "Show Results?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dr == DialogResult.Yes)
            {
                bi.EndValidate();
                int count = bi.list.Count;
                for (int i = 0; i < count; i++)
                {
                    lbDisplay.Items.Add(bi.list[i]);
                }
            }
            
        }
    }
}
