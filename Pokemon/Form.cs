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
        public float[] arrayPM = new float[19];
        public int atttype = 0;
        public int atttypemax = 0;
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
            label37.Text = "選擇屬性(單): ";
            button20.Enabled = true;
            button19.Enabled = false;
            btn_Remake();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            atttypemax = 2;
            label37.Text = "選擇屬性(雙): ";
            button20.Enabled = false;
            button19.Enabled = true;
            btn_Remake();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if(atttypemax == 1)
                label37.Text = "選擇屬性(單): ";
            else if(atttypemax == 2)
                label37.Text = "選擇屬性(雙): ";
            btn_Remake();
        }//重置

        private void button1_Click(object sender, EventArgs e)
        {
            if(atttype < atttypemax)
            {
                arrayPM[7] = arrayPM[7] * 2;
                arrayPM[14] = arrayPM[14] * 0;
                button1.Enabled = false;
                attr_cal(arrayPM, label2.Text);
            }
            
        }//一般

        private void button2_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[3] = arrayPM[3] * 2;
                arrayPM[9] = arrayPM[9] * 2;
                arrayPM[13] = arrayPM[13] * 2;
                arrayPM[2] = arrayPM[2] / 2;
                arrayPM[4] = arrayPM[4] / 2;
                arrayPM[6] = arrayPM[6] / 2;
                arrayPM[12] = arrayPM[12] / 2;
                arrayPM[17] = arrayPM[17] / 2;
                arrayPM[18] = arrayPM[18] / 2;
                button2.Enabled = false;
                attr_cal(arrayPM, label8.Text);
            }
        }//炎

        private void button3_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[4] = arrayPM[4] * 2;
                arrayPM[5] = arrayPM[5] * 2;
                arrayPM[2] = arrayPM[2] / 2;
                arrayPM[3] = arrayPM[3] / 2;
                arrayPM[6] = arrayPM[6] / 2;
                arrayPM[17] = arrayPM[17] / 2;
                button3.Enabled = false;
                attr_cal(arrayPM, label14.Text);
            }
        }//水

        private void button4_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[2] = arrayPM[2] * 2;
                arrayPM[6] = arrayPM[6] * 2;
                arrayPM[8] = arrayPM[8] * 2;
                arrayPM[10] = arrayPM[10] * 2;
                arrayPM[12] = arrayPM[12] * 2;
                arrayPM[3] = arrayPM[3] / 2;
                arrayPM[4] = arrayPM[4] / 2;
                arrayPM[5] = arrayPM[5] / 2;
                arrayPM[9] = arrayPM[9] / 2;
                button4.Enabled = false;
                attr_cal(arrayPM, label20.Text);
            }
        }//草

        private void button5_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[9] = arrayPM[9] * 2;
                arrayPM[5] = arrayPM[5] / 2;
                arrayPM[10] = arrayPM[10] / 2;
                arrayPM[18] = arrayPM[18] / 2;
                button5.Enabled = false;
                attr_cal(arrayPM, label26.Text);
            }
        }//雷

        private void button6_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[2] = arrayPM[2] * 2;
                arrayPM[7] = arrayPM[7] * 2;
                arrayPM[13] = arrayPM[13] * 2;
                arrayPM[17] = arrayPM[17] * 2;
                arrayPM[6] = arrayPM[6] / 2;
                button6.Enabled = false;
                attr_cal(arrayPM, label32.Text);
            }
        }//冰

        private void button7_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[10] = arrayPM[10] * 2;
                arrayPM[11] = arrayPM[11] * 2;
                arrayPM[18] = arrayPM[18] * 2;
                arrayPM[12] = arrayPM[12] / 2;
                arrayPM[13] = arrayPM[13] / 2;
                arrayPM[16] = arrayPM[16] / 2;
                button7.Enabled = false;
                attr_cal(arrayPM, label4.Text);
            }
        }//格鬥

        private void button8_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[9] = arrayPM[9] * 2;
                arrayPM[11] = arrayPM[11] * 2;
                arrayPM[4] = arrayPM[4] / 2;
                arrayPM[7] = arrayPM[7] / 2;
                arrayPM[8] = arrayPM[8] / 2;
                arrayPM[12] = arrayPM[12] / 2;
                arrayPM[18] = arrayPM[18] / 2;
                button8.Enabled = false;
                attr_cal(arrayPM, label10.Text);
            }
        }//毒

        private void button9_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[3] = arrayPM[3] * 2;
                arrayPM[4] = arrayPM[4] * 2;
                arrayPM[6] = arrayPM[6] * 2;
                arrayPM[8] = arrayPM[8] / 2;
                arrayPM[5] = arrayPM[5] * 0;
                button9.Enabled = false;
                attr_cal(arrayPM, label16.Text);
            }
        }//地面

        private void button10_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[5] = arrayPM[5] * 2;
                arrayPM[6] = arrayPM[6] * 2;
                arrayPM[13] = arrayPM[13] * 2;
                arrayPM[4] = arrayPM[4] / 2;
                arrayPM[7] = arrayPM[7] / 2;
                arrayPM[12] = arrayPM[12] / 2;
                arrayPM[9] = arrayPM[9] * 0;
                button10.Enabled = false;
                attr_cal(arrayPM, label22.Text);
            }
        }//飛行

        private void button11_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[12] = arrayPM[12] * 2;
                arrayPM[14] = arrayPM[14] * 2;
                arrayPM[16] = arrayPM[16] * 2;
                arrayPM[7] = arrayPM[7] / 2;
                arrayPM[11] = arrayPM[11] / 2;
                button11.Enabled = false;
                attr_cal(arrayPM, label28.Text);
            }
        }//超能

        private void button12_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[2] = arrayPM[2] * 2;
                arrayPM[10] = arrayPM[10] * 2;
                arrayPM[13] = arrayPM[13] * 2;
                arrayPM[4] = arrayPM[4] / 2;
                arrayPM[7] = arrayPM[7] / 2;
                arrayPM[9] = arrayPM[9] / 2;
                button12.Enabled = false;
                attr_cal(arrayPM, label34.Text);
            }
        }//蟲

        private void button13_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[3] = arrayPM[3] * 2;
                arrayPM[4] = arrayPM[4] * 2;
                arrayPM[7] = arrayPM[7] * 2;
                arrayPM[9] = arrayPM[9] * 2;
                arrayPM[17] = arrayPM[17] * 2;
                arrayPM[1] = arrayPM[1] / 2;
                arrayPM[2] = arrayPM[2] / 2;
                arrayPM[8] = arrayPM[8] / 2;
                arrayPM[10] = arrayPM[10] / 2;
                button13.Enabled = false;
                attr_cal(arrayPM, label6.Text);
            }
        }//岩石

        private void button14_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[14] = arrayPM[14] * 2;
                arrayPM[16] = arrayPM[16] * 2;
                arrayPM[9] = arrayPM[9] / 2;
                arrayPM[12] = arrayPM[12] / 2;
                arrayPM[1] = arrayPM[1] * 0;
                arrayPM[7] = arrayPM[7] * 0;
                button14.Enabled = false;
                attr_cal(arrayPM, label12.Text);
            }
        }//幽靈

        private void button15_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[6] = arrayPM[6] * 2;
                arrayPM[15] = arrayPM[15] * 2;
                arrayPM[18] = arrayPM[18] * 2;
                arrayPM[2] = arrayPM[2] / 2;
                arrayPM[3] = arrayPM[3] / 2;
                arrayPM[4] = arrayPM[4] / 2;
                arrayPM[5] = arrayPM[5] / 2;
                button15.Enabled = false;
                attr_cal(arrayPM, label18.Text);
            }
        }//龍

        private void button16_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[7] = arrayPM[7] * 2;
                arrayPM[12] = arrayPM[12] * 2;
                arrayPM[18] = arrayPM[18] * 2;
                arrayPM[14] = arrayPM[14] / 2;
                arrayPM[16] = arrayPM[16] / 2;
                arrayPM[11] = arrayPM[11] * 0;
                button16.Enabled = false;
                attr_cal(arrayPM, label24.Text);
            }
        }//惡

        private void button17_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[2] = arrayPM[2] * 2;
                arrayPM[7] = arrayPM[7] * 2;
                arrayPM[9] = arrayPM[9] * 2;
                arrayPM[1] = arrayPM[1] / 2;
                arrayPM[4] = arrayPM[4] / 2;
                arrayPM[6] = arrayPM[6] / 2;
                arrayPM[10] = arrayPM[10] / 2;
                arrayPM[11] = arrayPM[11] / 2;
                arrayPM[12] = arrayPM[12] / 2;
                arrayPM[13] = arrayPM[13] / 2;
                arrayPM[15] = arrayPM[15] / 2;
                arrayPM[17] = arrayPM[17] / 2;
                arrayPM[18] = arrayPM[18] / 2;
                arrayPM[8] = arrayPM[8] * 0;
                button17.Enabled = false;
                attr_cal(arrayPM, label30.Text);
            }
        }//鋼

        private void button18_Click(object sender, EventArgs e)
        {
            if (atttype < atttypemax)
            {
                arrayPM[8] = arrayPM[8] * 2;
                arrayPM[17] = arrayPM[17] * 2;
                arrayPM[7] = arrayPM[7] / 2;
                arrayPM[12] = arrayPM[12] / 2;
                arrayPM[16] = arrayPM[16] / 2;
                button18.Enabled = false;
                attr_cal(arrayPM, label36.Text);
            }
        }//妖精

        public void attr_cal(float[] array , string attr_name)
        {
            label1.Text = array[1].ToString();
            label3.Text = array[7].ToString();
            label5.Text = array[13].ToString();
            label7.Text = array[2].ToString();
            label9.Text = array[8].ToString();
            label11.Text = array[14].ToString();
            label13.Text = array[3].ToString();
            label15.Text = array[9].ToString();
            label17.Text = array[15].ToString();
            label19.Text = array[4].ToString();
            label21.Text = array[10].ToString();
            label23.Text = array[16].ToString();
            label25.Text = array[5].ToString();
            label27.Text = array[11].ToString();
            label29.Text = array[17].ToString();
            label31.Text = array[6].ToString();
            label33.Text = array[12].ToString();
            label35.Text = array[18].ToString();
            atttype++;
            label37.Text = label37.Text + attr_name.ToString() + "  ";
        }

        public void btn_Remake()
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

            for (int i = 1; i <= 18; i++)
            { arrayPM[i] = 1; }
        }

    }
}
