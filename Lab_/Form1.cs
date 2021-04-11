using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           //this.WindowState = FormWindowState.Maximized;
        }
        int chek_otv_1 = 1;
        int chek_otv_2 = 1;
        int chek_otv_3 = 1;
        int chek_otv_4 = 1;
        int chek_otv_5 = 1;
        int chek_otv_6 = 1;
        int chek_otv_7 = 1;
        int chek_otv_8 = 1;
        int chek_otv_9 = 1;
        int chek_otv_10 = 1;

        int[] m = new int[] { 0, 75, 150, 225, 300, 375, 450, 525, 600, 675};

        int[] y = new int[10];
        int y1, y2, y3, y4, y5, y6, y7, y8, y9, y10;
        private void Form1_Load(object sender, EventArgs e)
        {
            var random = new Random();
            y = Enumerable.Range(0, 10).OrderBy(n => random.Next()).ToArray();
            y1 = m[y[0]];
            y2 = m[y[1]];
            y3 = m[y[2]];
            y4 = m[y[3]];
            y5 = m[y[4]];
            y6 = m[y[5]];
            y7 = m[y[6]];
            y8 = m[y[7]];
            y9 = m[y[8]];
            y10 = m[y[9]];
            po1.Location = new Point(670, y1);
            po2.Location = new Point(630, y2);
            po3.Location = new Point(670, y3);
            po4.Location = new Point(630, y4);
            po5.Location = new Point(670, y5);
            po6.Location = new Point(630, y6);
            po7.Location = new Point(670, y7);
            po8.Location = new Point(630, y8);
            po9.Location = new Point(670, y9);
            po10.Location = new Point(630, y10);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        void color()
        {
            v1.ForeColor = Color.Black;
            v2.ForeColor = Color.Black;
            v3.ForeColor = Color.Black;
            v4.ForeColor = Color.Black;
            v5.ForeColor = Color.Black;
            v6.ForeColor = Color.Black;
            v7.ForeColor = Color.Black;
            v8.ForeColor = Color.Black;
            v9.ForeColor = Color.Black;
            v10.ForeColor = Color.Black;

            o1.ForeColor = Color.Black;
            o2.ForeColor = Color.Black;
            o3.ForeColor = Color.Black;
            o4.ForeColor = Color.Black;
            o5.ForeColor = Color.Black;
            o6.ForeColor = Color.Black;
            o7.ForeColor = Color.Black;
            o8.ForeColor = Color.Black;
            o9.ForeColor = Color.Black;
            o10.ForeColor = Color.Black;
        }
        private void v1_Click(object sender, EventArgs e)
        {
            v1.BackColor = Color.Orange;
            v2.BackColor = Color.DarkOrange;
            v3.BackColor = Color.DarkOrange;
            v4.BackColor = Color.DarkOrange;
            v5.BackColor = Color.DarkOrange;
            v6.BackColor = Color.DarkOrange;
            v7.BackColor = Color.DarkOrange;
            v8.BackColor = Color.DarkOrange;
            v9.BackColor = Color.DarkOrange;
            v10.BackColor = Color.DarkOrange;
            color();
        }
        private void v2_Click(object sender, EventArgs e)
        {
            v1.BackColor = Color.DarkOrange;
            v2.BackColor = Color.Orange;
            v3.BackColor = Color.DarkOrange;
            v4.BackColor = Color.DarkOrange;
            v5.BackColor = Color.DarkOrange;
            v6.BackColor = Color.DarkOrange;
            v7.BackColor = Color.DarkOrange;
            v8.BackColor = Color.DarkOrange;
            v9.BackColor = Color.DarkOrange;
            v10.BackColor = Color.DarkOrange;
            color();
        }
        private void v3_Click(object sender, EventArgs e)
        {
            v1.BackColor = Color.DarkOrange;
            v2.BackColor = Color.DarkOrange;
            v3.BackColor = Color.Orange;
            v4.BackColor = Color.DarkOrange;
            v5.BackColor = Color.DarkOrange;
            v6.BackColor = Color.DarkOrange;
            v7.BackColor = Color.DarkOrange;
            v8.BackColor = Color.DarkOrange;
            v9.BackColor = Color.DarkOrange;
            v10.BackColor = Color.DarkOrange;
            color();
        }
        private void v4_Click(object sender, EventArgs e)
        {
            v1.BackColor = Color.DarkOrange;
            v2.BackColor = Color.DarkOrange;
            v3.BackColor = Color.DarkOrange;
            v4.BackColor = Color.Orange;
            v5.BackColor = Color.DarkOrange;
            v6.BackColor = Color.DarkOrange;
            v7.BackColor = Color.DarkOrange;
            v8.BackColor = Color.DarkOrange;
            v9.BackColor = Color.DarkOrange;
            v10.BackColor = Color.DarkOrange;
            color();
        }
        private void v5_Click(object sender, EventArgs e)
        {
            v1.BackColor = Color.DarkOrange;
            v2.BackColor = Color.DarkOrange;
            v3.BackColor = Color.DarkOrange;
            v4.BackColor = Color.DarkOrange;
            v5.BackColor = Color.Orange;
            v6.BackColor = Color.DarkOrange;
            v7.BackColor = Color.DarkOrange;
            v8.BackColor = Color.DarkOrange;
            v9.BackColor = Color.DarkOrange;
            v10.BackColor = Color.DarkOrange;
            color();
        }
        private void v6_Click(object sender, EventArgs e)
        {
            v1.BackColor = Color.DarkOrange;
            v2.BackColor = Color.DarkOrange;
            v3.BackColor = Color.DarkOrange;
            v4.BackColor = Color.DarkOrange;
            v5.BackColor = Color.DarkOrange;
            v6.BackColor = Color.Orange;
            v7.BackColor = Color.DarkOrange;
            v8.BackColor = Color.DarkOrange;
            v9.BackColor = Color.DarkOrange;
            v10.BackColor = Color.DarkOrange;
            color();
        }
        private void v7_Click(object sender, EventArgs e)
        {
            v1.BackColor = Color.DarkOrange;
            v2.BackColor = Color.DarkOrange;
            v3.BackColor = Color.DarkOrange;
            v4.BackColor = Color.DarkOrange;
            v5.BackColor = Color.DarkOrange;
            v6.BackColor = Color.DarkOrange;
            v7.BackColor = Color.Orange;
            v8.BackColor = Color.DarkOrange;
            v9.BackColor = Color.DarkOrange;
            v10.BackColor = Color.DarkOrange;
            color();
        }
        private void v8_Click(object sender, EventArgs e)
        {
            v1.BackColor = Color.DarkOrange;
            v2.BackColor = Color.DarkOrange;
            v3.BackColor = Color.DarkOrange;
            v4.BackColor = Color.DarkOrange;
            v5.BackColor = Color.DarkOrange;
            v6.BackColor = Color.DarkOrange;
            v7.BackColor = Color.DarkOrange;
            v8.BackColor = Color.Orange;
            v9.BackColor = Color.DarkOrange;
            v10.BackColor = Color.DarkOrange;
            color();
        }
        private void v9_Click(object sender, EventArgs e)
        {
            v1.BackColor = Color.DarkOrange;
            v2.BackColor = Color.DarkOrange;
            v3.BackColor = Color.DarkOrange;
            v4.BackColor = Color.DarkOrange;
            v5.BackColor = Color.DarkOrange;
            v6.BackColor = Color.DarkOrange;
            v7.BackColor = Color.DarkOrange;
            v8.BackColor = Color.DarkOrange;
            v9.BackColor = Color.Orange;
            v10.BackColor = Color.DarkOrange;
            color();
        }
        private void v10_Click(object sender, EventArgs e)
        {
            v1.BackColor = Color.DarkOrange;
            v2.BackColor = Color.DarkOrange;
            v3.BackColor = Color.DarkOrange;
            v4.BackColor = Color.DarkOrange;
            v5.BackColor = Color.DarkOrange;
            v6.BackColor = Color.DarkOrange;
            v7.BackColor = Color.DarkOrange;
            v8.BackColor = Color.DarkOrange;
            v9.BackColor = Color.DarkOrange;
            v10.BackColor = Color.Orange;
            color();
        }
        void rez()
        {
            if (po1.Location.X != 670 && po1.Location.Y != y1 &&
                po2.Location.X != 630 && po2.Location.Y != y2 &&
                po3.Location.X != 670 && po3.Location.Y != y3 &&
                po4.Location.X != 630 && po4.Location.Y != y4 &&
                po5.Location.X != 670 && po5.Location.Y != y5 &&
                po6.Location.X != 630 && po6.Location.Y != y6 &&
                po7.Location.X != 670 && po7.Location.Y != y7 &&
                po8.Location.X != 630 && po8.Location.Y != y8 &&
                po9.Location.X != 670 && po9.Location.Y != y9 &&
                po10.Location.X != 630 && po10.Location.Y != y10)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
                listBox1.Visible = false;
            }
        }


        void Sol(Panel p, Label lb, int otv, int xo, int yo, int xv, int yv)
        {
            if (lb.BackColor == Color.Orange)
            {
                if (otv % 2 == 0)
                {
                    p.Location = new Point(xv, yv);
                }
                if (otv % 2 != 0)
                {
                    p.Location = new Point(xo, yo);
                }
            }
            rez();
        }
        
        private void o1_Click(object sender, EventArgs e)
        {
            Sol(po1, v1, chek_otv_1, 150, 3, 670, y1);
            Sol(po1, v2, chek_otv_1, 170, 78, 670, y1);
            Sol(po1, v3, chek_otv_1, 150, 153, 670, y1);
            Sol(po1, v4, chek_otv_1, 170, 228, 670, y1);
            Sol(po1, v5, chek_otv_1, 150, 303, 670, y1);
            Sol(po1, v6, chek_otv_1, 170, 378, 670, y1);
            Sol(po1, v7, chek_otv_1, 150, 453, 670, y1);
            Sol(po1, v8, chek_otv_1, 170, 528, 670, y1);
            Sol(po1, v9, chek_otv_1, 150, 603, 670, y1);
            Sol(po1, v10, chek_otv_1, 170, 678, 670, y1);
            chek_otv_1++;
            color();
        }

        private void o2_Click(object sender, EventArgs e)
        {
            Sol(po2, v1, chek_otv_2, 150, 3, 630, y2);
            Sol(po2, v2, chek_otv_2, 170, 78, 630, y2);
            Sol(po2, v3, chek_otv_2, 150, 153, 630, y2);
            Sol(po2, v4, chek_otv_2, 170, 228, 630, y2);
            Sol(po2, v5, chek_otv_2, 150, 303, 630, y2);
            Sol(po2, v6, chek_otv_2, 170, 378, 630, y2);
            Sol(po2, v7, chek_otv_2, 150, 453, 630, y2);
            Sol(po2, v8, chek_otv_2, 170, 528, 630, y2);
            Sol(po2, v9, chek_otv_2, 150, 603, 630, y2);
            Sol(po2, v10, chek_otv_2, 170, 678, 630, y2);
            chek_otv_2++;
            color();
        }

        private void o3_Click(object sender, EventArgs e)
        {
            Sol(po3, v1, chek_otv_3, 150, 3, 670, y3);
            Sol(po3, v2, chek_otv_3, 170, 78, 670, y3);
            Sol(po3, v3, chek_otv_3, 150, 153, 670, y3);
            Sol(po3, v4, chek_otv_3, 170, 228, 670, y3);
            Sol(po3, v5, chek_otv_3, 150, 303, 670, y3);
            Sol(po3, v6, chek_otv_3, 170, 378, 670, y3);
            Sol(po3, v7, chek_otv_3, 150, 453, 670, y3);
            Sol(po3, v8, chek_otv_3, 170, 528, 670, y3);
            Sol(po3, v9, chek_otv_3, 150, 603, 670, y3);
            Sol(po3, v10, chek_otv_3, 170, 678, 670, y3);
            chek_otv_3++;
            color();
        }

        private void o4_Click(object sender, EventArgs e)
        {
            Sol(po4, v1, chek_otv_4, 150, 3, 630, y4);
            Sol(po4, v2, chek_otv_4, 170, 78, 630, y4);
            Sol(po4, v3, chek_otv_4, 150, 153, 630, y4);
            Sol(po4, v4, chek_otv_4, 170, 228, 630, y4);
            Sol(po4, v5, chek_otv_4, 150, 303, 630, y4);
            Sol(po4, v6, chek_otv_4, 170, 378, 630, y4);
            Sol(po4, v7, chek_otv_4, 150, 453, 630, y4);
            Sol(po4, v8, chek_otv_4, 170, 528, 630, y4);
            Sol(po4, v9, chek_otv_4, 150, 603, 630, y4);
            Sol(po4, v10, chek_otv_4, 170, 678, 630, y4);
            chek_otv_4++;
            color();
        }

        private void o5_Click(object sender, EventArgs e)
        {
            Sol(po5, v1, chek_otv_5, 150, 3, 670, y5);
            Sol(po5, v2, chek_otv_5, 170, 78, 670, y5);
            Sol(po5, v3, chek_otv_5, 150, 153, 670, y5);
            Sol(po5, v4, chek_otv_5, 170, 228, 670, y5);
            Sol(po5, v5, chek_otv_5, 150, 303, 670, y5);
            Sol(po5, v6, chek_otv_5, 170, 378, 670, y5);
            Sol(po5, v7, chek_otv_5, 150, 453, 670, y5);
            Sol(po5, v8, chek_otv_5, 170, 528, 670, y5);
            Sol(po5, v9, chek_otv_5, 150, 603, 670, y5);
            Sol(po5, v10, chek_otv_5, 170, 678, 670, y5);
            chek_otv_5++;
            color();
        }

        private void o6_Click(object sender, EventArgs e)
        {
            Sol(po6, v1, chek_otv_6, 150, 3, 630, y6);
            Sol(po6, v2, chek_otv_6, 170, 78, 630, y6);
            Sol(po6, v3, chek_otv_6, 150, 153, 630, y6);
            Sol(po6, v4, chek_otv_6, 170, 228, 630, y6);
            Sol(po6, v5, chek_otv_6, 150, 303, 630, y6);
            Sol(po6, v6, chek_otv_6, 170, 378, 630, y6);
            Sol(po6, v7, chek_otv_6, 150, 453, 630, y6);
            Sol(po6, v8, chek_otv_6, 170, 528, 630, y6);
            Sol(po6, v9, chek_otv_6, 150, 603, 630, y6);
            Sol(po6, v10, chek_otv_6, 170, 678, 630, y6);
            chek_otv_6++;
            color();
        }

        private void o7_Click(object sender, EventArgs e)
        {
            Sol(po7, v1, chek_otv_7, 150, 3, 670, y7);
            Sol(po7, v2, chek_otv_7, 170, 78, 670, y7);
            Sol(po7, v3, chek_otv_7, 150, 153, 670, y7);
            Sol(po7, v4, chek_otv_7, 170, 228, 670, y7);
            Sol(po7, v5, chek_otv_7, 150, 303, 670, y7);
            Sol(po7, v6, chek_otv_7, 170, 378, 670, y7);
            Sol(po7, v7, chek_otv_7, 150, 453, 670, y7);
            Sol(po7, v8, chek_otv_7, 170, 528, 670, y7);
            Sol(po7, v9, chek_otv_7, 150, 603, 670, y7);
            Sol(po7, v10, chek_otv_7, 170, 678, 670, y7);
            chek_otv_7++;
            color();
        }

        private void o8_Click(object sender, EventArgs e)
        {
            Sol(po8, v1, chek_otv_8, 150, 3, 630, y8);
            Sol(po8, v2, chek_otv_8, 170, 78, 630, y8);
            Sol(po8, v3, chek_otv_8, 150, 153, 630, y8);
            Sol(po8, v4, chek_otv_8, 170, 228, 630, y8);
            Sol(po8, v5, chek_otv_8, 150, 303, 630, y8);
            Sol(po8, v6, chek_otv_8, 170, 378, 630, y8);
            Sol(po8, v7, chek_otv_8, 150, 453, 630, y8);
            Sol(po8, v8, chek_otv_8, 170, 528, 630, y8);
            Sol(po8, v9, chek_otv_8, 150, 603, 630, y8);
            Sol(po8, v10, chek_otv_8, 170, 678, 630, y8);
            chek_otv_8++;
            color();
        }

        private void o9_Click(object sender, EventArgs e)
        {
            Sol(po9, v1, chek_otv_9, 150, 3, 670, y9);
            Sol(po9, v2, chek_otv_9, 170, 78, 670, y9);
            Sol(po9, v3, chek_otv_9, 150, 153, 670, y9);
            Sol(po9, v4, chek_otv_9, 170, 228, 670, y9);
            Sol(po9, v5, chek_otv_9, 150, 303, 670, y9);
            Sol(po9, v6, chek_otv_9, 170, 378, 670, y9);
            Sol(po9, v7, chek_otv_9, 150, 453, 670, y9);
            Sol(po9, v8, chek_otv_9, 170, 528, 670, y9);
            Sol(po9, v9, chek_otv_9, 150, 603, 670, y9);
            Sol(po9, v10, chek_otv_9, 170, 678, 670, y9);
            chek_otv_9++;
            color();
        }

        private void o10_Click(object sender, EventArgs e)
        {
            Sol(po10, v1, chek_otv_10, 150, 3, 630, y10);
            Sol(po10, v2, chek_otv_10, 170, 78, 630, y10);
            Sol(po10, v3, chek_otv_10, 150, 153, 630, y10);
            Sol(po10, v4, chek_otv_10, 170, 228, 630, y10);
            Sol(po10, v5, chek_otv_10, 150, 303, 630, y10);
            Sol(po10, v6, chek_otv_10, 170, 378, 630, y10);
            Sol(po10, v7, chek_otv_10, 150, 453, 630, y10);
            Sol(po10, v8, chek_otv_10, 170, 528, 630, y10);
            Sol(po10, v9, chek_otv_10, 150, 603, 630, y10);
            Sol(po10, v10, chek_otv_10, 170, 678, 630, y10);
            chek_otv_10++;
            color();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int flag = 0;
        private void label3_Click(object sender, EventArgs e)
        {
            if (pv1.Location.X == 31 && pv1.Location.Y == 0 &&
                po2.Location.X == 150 && po2.Location.Y == 3)
            {
                v1.ForeColor = Color.Green;
                o2.ForeColor = Color.Green;
                flag++;
            }
            if (pv2.Location.X == 51 && pv2.Location.Y == 75 &&
                po6.Location.X == 170 && po6.Location.Y == 78)
            {
                v2.ForeColor = Color.Green;
                o6.ForeColor = Color.Green;
                flag++;
            }
            if (pv3.Location.X == 31 && pv3.Location.Y == 150 &&
                    po1.Location.X == 150 && po1.Location.Y == 153)
            {
                v3.ForeColor = Color.Green;
                o1.ForeColor = Color.Green;
                flag++;
            }
            if (pv4.Location.X == 51 && pv4.Location.Y == 225 &&
                    po3.Location.X == 170 && po3.Location.Y == 228)
            {
                v4.ForeColor = Color.Green;
                o3.ForeColor = Color.Green;
                flag++;
            }
            if (pv5.Location.X == 31 && pv5.Location.Y == 300 &&
                     po4.Location.X == 150 && po4.Location.Y == 303)
            {
                v5.ForeColor = Color.Green;
                o4.ForeColor = Color.Green;
                flag++;
            }
            if (pv6.Location.X == 51 && pv6.Location.Y == 375 &&
                     po5.Location.X == 170 && po5.Location.Y == 378)
            {
                v6.ForeColor = Color.Green;
                o5.ForeColor = Color.Green;
                flag++;
            }
            if (pv7.Location.X == 31 && pv7.Location.Y == 450 &&
                      po8.Location.X == 150 && po8.Location.Y == 453)
            {
                v7.ForeColor = Color.Green;
                o8.ForeColor = Color.Green;
                flag++;
            }
            if (pv8.Location.X == 51 && pv8.Location.Y == 525 &&
                     po7.Location.X == 170 && po7.Location.Y == 528)
            {
                v8.ForeColor = Color.Green;
                o7.ForeColor = Color.Green;
                flag++;
            }
            if (pv9.Location.X == 31 && pv9.Location.Y == 600 &&
                     po10.Location.X == 150 && po10.Location.Y == 603)
            {
                v9.ForeColor = Color.Green;
                o10.ForeColor = Color.Green;
                flag++;
            }
            if (pv10.Location.X == 51 && pv10.Location.Y == 675 &&
                     po9.Location.X == 170 && po9.Location.Y == 678)
            {
                v10.ForeColor = Color.Green;
                o9.ForeColor = Color.Green;
                flag++;
            }
            listBox1.Visible = true;
            MessageBox.Show("Ваша оценка: " + flag, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            flag = 0;
        }

    }
}
