using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSys
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TurtleSystem tsys = new TurtleSystem(new Size(1024, 1024), 1024/2, 1023);

            //picResult.Image = tsys.Render();

            if (String.IsNullOrEmpty(txtTurtleTest.Text) || String.IsNullOrWhiteSpace(txtTurtleTest.Text))
            {
                string lsys = txtAxiom.Text;
                string repl = txtFRepl.Text;    //FF[--F+F+F][+F-F-F]
                for (int i = 0; i < numIterations.Value; ++i)
                {
                    lsys = lsys.Replace("F", repl);
                }
                //txtTurtleTest.Text = lsys;

                parseTextTest(tsys, lsys, (int)numLength.Value, (float)numAngle.Value);
            }
            else
                parseTextTest(tsys, txtTurtleTest.Text, (int)numLength.Value, (float)numAngle.Value);
        }

        private void parseTextTest(TurtleSystem tsys, string lsys, int length = 20, float angle = 90f)
        {
            foreach (char c in lsys)
            {
                switch (c)
                {
                    case 'F':
                        tsys.Move(length);
                        break;
                    case '+':
                        tsys.TurnLeft(angle);
                        break;
                    case '-':
                        tsys.TurnRight(angle);
                        break;
                    case '[':
                        tsys.SavePosition();
                        break;
                    case ']':
                        tsys.ReturnToPosition();
                        break;
                }
            }

            picResult.Image = tsys.Render();
        }
    }
}
