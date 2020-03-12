using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    
    public partial class Form : System.Windows.Forms.Form
    {
        public static float[] arrayPM = new float[19];
        public static int atttype = 0;
        public static int atttypemax = 0;
        public Form()
        {
            InitializeComponent();
            for (int i = 1; i <= 18; i++)
            { arrayPM[i] = 1; }
            label1.Text = "1";
            label3.Text = "1";
            label5.Text = "1";
            label7.Text = "1";
            label9.Text = "1";
            label11.Text = "1";
            label13.Text = "1";
            label15.Text = "1";
            label17.Text = "1";
            label19.Text = "1";
            label21.Text = "1";
            label23.Text = "1";
            label25.Text = "1";
            label27.Text = "1";
            label29.Text = "1";
            label31.Text = "1";
            label33.Text = "1";
            label35.Text = arrayPM[18].ToString();
            atttype = 0;
            atttypemax = 1;
            label37.Text = "選擇屬性(單): ";
            button19.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            atttypemax = 1;
            atttype = 0;
            button19.Enabled = false;
            button20.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            label1.Text = "1";
            label3.Text = "1";
            label5.Text = "1";
            label7.Text = "1";
            label9.Text = "1";
            label11.Text = "1";
            label13.Text = "1";
            label15.Text = "1";
            label17.Text = "1";
            label19.Text = "1";
            label21.Text = "1";
            label23.Text = "1";
            label25.Text = "1";
            label27.Text = "1";
            label29.Text = "1";
            label31.Text = "1";
            label33.Text = "1";
            label35.Text = "1";
            label37.Text = "選擇屬性(單): ";
            for (int i = 1; i <= 18; i++)
            { arrayPM[i] = 1; }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            atttypemax = 2;
            atttype = 0;
            button19.Enabled = true;
            button20.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            label1.Text = "1";
            label3.Text = "1";
            label5.Text = "1";
            label7.Text = "1";
            label9.Text = "1";
            label11.Text = "1";
            label13.Text = "1";
            label15.Text = "1";
            label17.Text = "1";
            label19.Text = "1";
            label21.Text = "1";
            label23.Text = "1";
            label25.Text = "1";
            label27.Text = "1";
            label29.Text = "1";
            label31.Text = "1";
            label33.Text = "1";
            label35.Text = "1";
            label37.Text = "選擇屬性(雙): ";
            for (int i = 1; i <= 18; i++)
            { arrayPM[i] = 1; }
        }

        private void button_Click(object sender, EventArgs e)
        {
            atttype = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            label1.Text = "1";
            label3.Text = "1";
            label5.Text = "1";
            label7.Text = "1";
            label9.Text = "1";
            label11.Text = "1";
            label13.Text = "1";
            label15.Text = "1";
            label17.Text = "1";
            label19.Text = "1";
            label21.Text = "1";
            label23.Text = "1";
            label25.Text = "1";
            label27.Text = "1";
            label29.Text = "1";
            label31.Text = "1";
            label33.Text = "1";
            label35.Text = "1";
            if(atttypemax == 1)
                label37.Text = "選擇屬性(單): ";
            else if(atttypemax == 2)
                label37.Text = "選擇屬性(雙): ";


            for (int i = 1; i <= 18; i++)
            { arrayPM[i] = 1; }
        }//重置

        private void button1_Click(object sender, EventArgs e)
        {
            if(atttype < atttypemax)
            {
                arrayPM[7] = arrayPM[7] * 2;
                label3.Text = arrayPM[7].ToString();
                arrayPM[14] = arrayPM[14] * 0;
                label11.Text = arrayPM[14].ToString();
                button1.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label2.Text + "  ";
            }
            
        }//一般

        private void button2_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[3] = arrayPM[3] * 2;
                label7.Text = arrayPM[3].ToString();
                arrayPM[9] = arrayPM[9] * 2;
                label15.Text = arrayPM[9].ToString();
                arrayPM[13] = arrayPM[13] * 2;
                label5.Text = arrayPM[13].ToString();
                arrayPM[2] = arrayPM[2] / 2;
                label17.Text = arrayPM[2].ToString();
                arrayPM[4] = arrayPM[4] / 2;
                label19.Text = arrayPM[4].ToString();
                arrayPM[6] = arrayPM[6] / 2;
                label27.Text = arrayPM[6].ToString();
                arrayPM[12] = arrayPM[12] / 2;
                label33.Text = arrayPM[12].ToString();
                arrayPM[17] = arrayPM[17] / 2;
                label29.Text = arrayPM[17].ToString();
                arrayPM[18] = arrayPM[18] / 2;
                label35.Text = arrayPM[18].ToString();
                button2.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label8.Text + "  ";
            }
        }//炎

        private void button3_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[4] = arrayPM[4] * 2;
                label19.Text = arrayPM[4].ToString();
                arrayPM[5] = arrayPM[5] * 2;
                label25.Text = arrayPM[5].ToString();
                arrayPM[2] = arrayPM[2] / 2;
                label7.Text = arrayPM[2].ToString();
                arrayPM[3] = arrayPM[3] / 2;
                label13.Text = arrayPM[3].ToString();
                arrayPM[6] = arrayPM[6] / 2;
                label31.Text = arrayPM[6].ToString();
                arrayPM[17] = arrayPM[17] / 2;
                label29.Text = arrayPM[17].ToString();
                button3.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label14.Text + "  ";
            }
        }//水

        private void button4_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[2] = arrayPM[2] * 2;
                label7.Text = arrayPM[2].ToString();
                arrayPM[6] = arrayPM[6] * 2;
                label31.Text = arrayPM[6].ToString();
                arrayPM[8] = arrayPM[8] * 2;
                label9.Text = arrayPM[8].ToString();
                arrayPM[10] = arrayPM[10] * 2;
                label21.Text = arrayPM[10].ToString();
                arrayPM[12] = arrayPM[12] * 2;
                label33.Text = arrayPM[12].ToString();
                arrayPM[3] = arrayPM[3] / 2;
                label13.Text = arrayPM[3].ToString();
                arrayPM[4] = arrayPM[4] / 2;
                label19.Text = arrayPM[4].ToString();
                arrayPM[5] = arrayPM[5] / 2;
                label25.Text = arrayPM[5].ToString();
                arrayPM[9] = arrayPM[9] / 2;
                label15.Text = arrayPM[9].ToString();
                button4.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label20.Text + "  ";
            }
        }//草

        private void button5_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[9] = arrayPM[9] * 2;
                label5.Text = arrayPM[9].ToString();
                arrayPM[5] = arrayPM[5] / 2;
                label25.Text = arrayPM[5].ToString();
                arrayPM[10] = arrayPM[10] / 2;
                label21.Text = arrayPM[10].ToString();
                arrayPM[18] = arrayPM[18] / 2;
                label35.Text = arrayPM[18].ToString();
                button5.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label26.Text + "  ";
            }
        }//雷

        private void button6_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[2] = arrayPM[2] * 2;
                label7.Text = arrayPM[2].ToString();
                arrayPM[7] = arrayPM[7] * 2;
                label3.Text = arrayPM[7].ToString();
                arrayPM[13] = arrayPM[13] * 2;
                label5.Text = arrayPM[13].ToString();
                arrayPM[17] = arrayPM[17] * 2;
                label29.Text = arrayPM[17].ToString();
                arrayPM[6] = arrayPM[6] / 2;
                label31.Text = arrayPM[6].ToString();
                button6.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label32.Text + "  ";
            }
        }//冰

        private void button7_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[10] = arrayPM[10] * 2;
                label21.Text = arrayPM[10].ToString();
                arrayPM[11] = arrayPM[11] * 2;
                label27.Text = arrayPM[11].ToString();
                arrayPM[18] = arrayPM[18] * 2;
                label35.Text = arrayPM[18].ToString();
                arrayPM[12] = arrayPM[12] / 2;
                label33.Text = arrayPM[12].ToString();
                arrayPM[13] = arrayPM[13] / 2;
                label5.Text = arrayPM[13].ToString();
                arrayPM[16] = arrayPM[16] / 2;
                label23.Text = arrayPM[16].ToString();
                button7.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label4.Text + "  ";
            }
        }//格鬥

        private void button8_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[9] = arrayPM[9] * 2;
                label15.Text = arrayPM[9].ToString();
                arrayPM[11] = arrayPM[11] * 2;
                label27.Text = arrayPM[11].ToString();
                arrayPM[4] = arrayPM[4] / 2;
                label19.Text = arrayPM[4].ToString();
                arrayPM[7] = arrayPM[7] / 2;
                label3.Text = arrayPM[7].ToString();
                arrayPM[8] = arrayPM[8] / 2;
                label9.Text = arrayPM[8].ToString();
                arrayPM[12] = arrayPM[12] / 2;
                label23.Text = arrayPM[12].ToString();
                arrayPM[18] = arrayPM[18] / 2;
                label35.Text = arrayPM[18].ToString();
                button8.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label10.Text + "  ";
            }
        }//毒

        private void button9_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[3] = arrayPM[3] * 2;
                label13.Text = arrayPM[3].ToString();
                arrayPM[4] = arrayPM[4] * 2;
                label19.Text = arrayPM[4].ToString();
                arrayPM[6] = arrayPM[6] * 2;
                label31.Text = arrayPM[6].ToString();
                arrayPM[8] = arrayPM[8] / 2;
                label9.Text = arrayPM[8].ToString();
                arrayPM[5] = arrayPM[5] * 0;
                label25.Text = arrayPM[5].ToString();
                button9.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label16.Text + "  ";
            }
        }//地面

        private void button10_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[5] = arrayPM[5] * 2;
                label25.Text = arrayPM[5].ToString();
                arrayPM[6] = arrayPM[6] * 2;
                label31.Text = arrayPM[6].ToString();
                arrayPM[13] = arrayPM[13] * 2;
                label5.Text = arrayPM[13].ToString();
                arrayPM[4] = arrayPM[4] / 2;
                label19.Text = arrayPM[4].ToString();
                arrayPM[7] = arrayPM[7] / 2;
                label3.Text = arrayPM[7].ToString();
                arrayPM[12] = arrayPM[12] / 2;
                label33.Text = arrayPM[12].ToString();
                arrayPM[9] = arrayPM[9] * 0;
                label15.Text = arrayPM[9].ToString();
                button10.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label22.Text + "  ";
            }
        }//飛行

        private void button11_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[12] = arrayPM[12] * 2;
                label33.Text = arrayPM[12].ToString();
                arrayPM[14] = arrayPM[14] * 2;
                label11.Text = arrayPM[14].ToString();
                arrayPM[16] = arrayPM[16] * 2;
                label23.Text = arrayPM[16].ToString();
                arrayPM[7] = arrayPM[7] / 2;
                label3.Text = arrayPM[7].ToString();
                arrayPM[11] = arrayPM[11] / 2;
                label27.Text = arrayPM[11].ToString();
                button11.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label28.Text + "  ";
            }
        }//超能

        private void button12_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[2] = arrayPM[2] * 2;
                label7.Text = arrayPM[2].ToString();
                arrayPM[10] = arrayPM[10] * 2;
                label21.Text = arrayPM[10].ToString();
                arrayPM[13] = arrayPM[13] * 2;
                label5.Text = arrayPM[13].ToString();
                arrayPM[4] = arrayPM[4] / 2;
                label19.Text = arrayPM[4].ToString();
                arrayPM[7] = arrayPM[7] / 2;
                label3.Text = arrayPM[7].ToString();
                arrayPM[9] = arrayPM[9] / 2;
                label15.Text = arrayPM[9].ToString();
                button12.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label34.Text + "  ";
            }
        }//蟲

        private void button13_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[3] = arrayPM[3] * 2;
                label13.Text = arrayPM[3].ToString();
                arrayPM[4] = arrayPM[4] * 2;
                label19.Text = arrayPM[6].ToString();
                arrayPM[7] = arrayPM[7] * 2;
                label3.Text = arrayPM[7].ToString();
                arrayPM[9] = arrayPM[9] * 2;
                label15.Text = arrayPM[9].ToString();
                arrayPM[17] = arrayPM[17] * 2;
                label29.Text = arrayPM[17].ToString();
                arrayPM[1] = arrayPM[1] / 2;
                label1.Text = arrayPM[1].ToString();
                arrayPM[2] = arrayPM[2] / 2;
                label7.Text = arrayPM[2].ToString();
                arrayPM[8] = arrayPM[8] / 2;
                label9.Text = arrayPM[8].ToString();
                arrayPM[10] = arrayPM[10] / 2;
                label21.Text = arrayPM[10].ToString();
                button13.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label6.Text + "  ";
            }
        }//岩石

        private void button14_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[14] = arrayPM[14] * 2;
                label11.Text = arrayPM[14].ToString();
                arrayPM[16] = arrayPM[16] * 2;
                label23.Text = arrayPM[16].ToString();
                arrayPM[9] = arrayPM[9] / 2;
                label15.Text = arrayPM[9].ToString();
                arrayPM[12] = arrayPM[12] / 2;
                label33.Text = arrayPM[12].ToString();
                arrayPM[1] = arrayPM[1] * 0;
                label1.Text = arrayPM[1].ToString();
                arrayPM[7] = arrayPM[7] * 0;
                label3.Text = arrayPM[7].ToString();
                button14.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label12.Text + "  ";
            }
        }//幽靈

        private void button15_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[6] = arrayPM[6] * 2;
                label31.Text = arrayPM[6].ToString();
                arrayPM[15] = arrayPM[15] * 2;
                label17.Text = arrayPM[15].ToString();
                arrayPM[18] = arrayPM[18] * 2;
                label35.Text = arrayPM[18].ToString();
                arrayPM[2] = arrayPM[2] / 2;
                label7.Text = arrayPM[2].ToString();
                arrayPM[3] = arrayPM[3] / 2;
                label13.Text = arrayPM[3].ToString();
                arrayPM[4] = arrayPM[4] / 2;
                label19.Text = arrayPM[4].ToString();
                arrayPM[5] = arrayPM[5] / 2;
                label25.Text = arrayPM[5].ToString();
                button15.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label18.Text + "  ";
            }
        }//龍

        private void button16_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[7] = arrayPM[7] * 2;
                label3.Text = arrayPM[7].ToString();
                arrayPM[12] = arrayPM[12] * 2;
                label33.Text = arrayPM[12].ToString();
                arrayPM[18] = arrayPM[18] * 2;
                label35.Text = arrayPM[18].ToString();
                arrayPM[14] = arrayPM[14] / 2;
                label11.Text = arrayPM[14].ToString();
                arrayPM[16] = arrayPM[16] / 2;
                label23.Text = arrayPM[16].ToString();
                arrayPM[11] = arrayPM[11] * 0;
                label27.Text = arrayPM[11].ToString();
                button16.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label24.Text + "  ";
            }
        }//惡

        private void button17_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[2] = arrayPM[2] * 2;
                label7.Text = arrayPM[2].ToString();
                arrayPM[7] = arrayPM[7] * 2;
                label3.Text = arrayPM[7].ToString();
                arrayPM[9] = arrayPM[9] * 2;
                label15.Text = arrayPM[9].ToString();
                arrayPM[1] = arrayPM[1] / 2;
                label1.Text = arrayPM[1].ToString();
                arrayPM[4] = arrayPM[4] / 2;
                label19.Text = arrayPM[4].ToString();
                arrayPM[6] = arrayPM[6] / 2;
                label31.Text = arrayPM[6].ToString();
                arrayPM[10] = arrayPM[10] / 2;
                label21.Text = arrayPM[10].ToString();
                arrayPM[11] = arrayPM[11] / 2;
                label27.Text = arrayPM[11].ToString();
                arrayPM[12] = arrayPM[12] / 2;
                label33.Text = arrayPM[12].ToString();
                arrayPM[13] = arrayPM[13] / 2;
                label5.Text = arrayPM[13].ToString();
                arrayPM[15] = arrayPM[15] / 2;
                label17.Text = arrayPM[15].ToString();
                arrayPM[17] = arrayPM[17] / 2;
                label29.Text = arrayPM[17].ToString();
                arrayPM[18] = arrayPM[18] / 2;
                label35.Text = arrayPM[18].ToString();
                arrayPM[8] = arrayPM[8] * 0;
                label9.Text = arrayPM[8].ToString();
                button17.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label30.Text + "  ";
            }
        }//鋼

        private void button18_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[8] = arrayPM[8] * 2;
                label9.Text = arrayPM[8].ToString();
                arrayPM[17] = arrayPM[17] * 2;
                label29.Text = arrayPM[17].ToString();
                arrayPM[7] = arrayPM[7] / 2;
                label3.Text = arrayPM[7].ToString();
                arrayPM[12] = arrayPM[12] / 2;
                label33.Text = arrayPM[12].ToString();
                arrayPM[16] = arrayPM[16] / 2;
                label23.Text = arrayPM[16].ToString();
                button18.Enabled = false;
                atttype++;
                label37.Text = label37.Text + label36.Text + "  ";
            }
        }//妖精
    }
}
