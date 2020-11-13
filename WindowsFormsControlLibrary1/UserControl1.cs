using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {


        #region StateMachine

        public enum StateMachine
        {
            Idle, Left, Middle, Right
        }

        private StateMachine myStateMachine = StateMachine.Idle;

        public StateMachine MyStateMachine
        {
            get { return myStateMachine; }
            set { myStateMachine = value; }
        }

        #endregion

        #region Max et Min
        private int maxValue = 60;

        /// <summary>
        ///  Get et Set de maxValue
        /// </summary>
        public int MaxValue
        {
            get { 
                return maxValue; 
            }
            set { 
                maxValue = value; 
                this.Invalidate(); 
            }
        }

        private int minValue = 40;

        /// <summary>
        ///  Get et Set de maxValue
        /// </summary>
        public int MinValue
        {
            get
            {
                return minValue;
            }
            set
            {
                minValue = value;
                this.Invalidate();
            }
        }

        #endregion


        private void UserControl1_Load(object sender, EventArgs e)
        {
            minValue = 40;
            maxValue = 60;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            g.FillRectangle(Brushes.Green, minValue, 0, maxValue - minValue, this.Height);
        }

        private void UserControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                switch (myStateMachine)
                {
                    case StateMachine.Idle:
                        // impossible
                        break;
                    case StateMachine.Left:

                        if (checkValidity(e.X))
                        {
                            MinValue -= mouseposX - e.X;
                            mouseposX = e.X;
                        }
                        break;
                    case StateMachine.Middle:
                        //Compute the delta middle
                        if (checkValidity(e.X))
                        {
                            MinValue -= mouseposX - e.X;
                            MaxValue -= mouseposX - e.X;
                            mouseposX = e.X;
                        }
                        break;
                    case StateMachine.Right:
                        if (checkValidity(e.X))
                        {
                            MaxValue -= mouseposX - e.X;
                            mouseposX = e.X;
                        }
                        break;
                    default:
                        break;
                }
                this.Invalidate();
            }
        }
        private bool checkValidity(int x)
        {
            int newMin;
            int newMax;

            newMin = mouseposX - x;
            newMax = MaxValue - mouseposX - x;

            if (newMin < 0)
            {
                return false;
            }
            if (newMax > this.Width)
            {
                return false;
            }
            return true;
        }

        int mouseposX;
        private void UserControl1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseposX = e.X;
            //get the closest border
            int mindist = int.MaxValue;
            int tempDist = Math.Abs(mouseposX - minValue);
            if (tempDist < mindist)
            {
                MyStateMachine = StateMachine.Left;
                mindist = tempDist;
            }

            tempDist = Math.Abs(mouseposX - MaxValue);
            if (tempDist < mindist)
            {
                MyStateMachine = StateMachine.Right;
                mindist = tempDist;
            }

            int mindle_pos = minValue + (MaxValue - MinValue) / 2;
            tempDist = Math.Abs(mouseposX - mindle_pos);
            if (tempDist < mindist)
            {
                MyStateMachine = StateMachine.Middle;
                mindist = tempDist;
            }
        }

        private void UserControl1_MouseUp(object sender, MouseEventArgs e)
        {
            myStateMachine = StateMachine.Idle;
        }

        
    }
}
