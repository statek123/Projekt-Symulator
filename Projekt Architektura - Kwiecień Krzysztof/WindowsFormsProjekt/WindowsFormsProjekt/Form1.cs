using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                AX_rozkaz.Text = textBox1.Text.ToString().ToUpper() + textBox8.Text.ToString().ToUpper();
            }
          

            if (textBox2.Text != "")
            {
                
                BX_rozkaz.Text = textBox2.Text.ToString().ToUpper() + textBox7.Text.ToString().ToUpper();
            }
            

            if (textBox3.Text != "")
            {
                CX_rozkaz.Text = textBox3.Text.ToString().ToUpper() + textBox6.Text.ToString().ToUpper();
            }

            if (textBox4.Text != "")
            {
                DX_rozkaz.Text = textBox4.Text.ToString().ToUpper() + textBox5.Text.ToString().ToUpper();
            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] hex = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            Random losowa = new Random();
            int start = losowa.Next(0, hex.Length);
            int start2 = losowa.Next(0, hex.Length);
            int start3 = losowa.Next(0, hex.Length);
            int start4 = losowa.Next(0, hex.Length);

            int start5 = losowa.Next(0, hex.Length);
            int start6 = losowa.Next(0, hex.Length);
            int start7 = losowa.Next(0, hex.Length);
            int start8 = losowa.Next(0, hex.Length);

            int start9 = losowa.Next(0, hex.Length);
            int start11 = losowa.Next(0, hex.Length);
            int start22 = losowa.Next(0, hex.Length);
            int start33 = losowa.Next(0, hex.Length);

            int start44 = losowa.Next(0, hex.Length);
            int start55 = losowa.Next(0, hex.Length);
            int start66 = losowa.Next(0, hex.Length);
            int start77 = losowa.Next(0, hex.Length);

            AX_rozkaz.Text = hex[start] + hex[start2] + hex[start3] + hex[start4];
            BX_rozkaz.Text = hex[start5] + hex[start6] + hex[start7] + hex[start8];
            CX_rozkaz.Text = hex[start9] + hex[start11] + hex[start22] + hex[start44];
            DX_rozkaz.Text = hex[start55] + hex[start66] + hex[start33] + hex[start77];


        }

        private void button1_Click(object sender, EventArgs e)
        {

            //================AX=================


            if (radioButton2.Checked && radioButton8.Checked)
            {
                BX_rozkaz.Text = AX_rozkaz.Text;
            }

            if (radioButton3.Checked && radioButton8.Checked)
            {
                CX_rozkaz.Text = AX_rozkaz.Text;
            }

            if (radioButton4.Checked && radioButton8.Checked)
            {
                DX_rozkaz.Text = AX_rozkaz.Text;
            }

            //==================BX=================

            if (radioButton1.Checked && radioButton7.Checked)
            {
                AX_rozkaz.Text = BX_rozkaz.Text;
            }

            if (radioButton3.Checked && radioButton7.Checked)
            {
                CX_rozkaz.Text = BX_rozkaz.Text;
            }

            if (radioButton4.Checked && radioButton7.Checked)
            {
                DX_rozkaz.Text = BX_rozkaz.Text;
            }

            //==================CX=================

            if (radioButton1.Checked && radioButton6.Checked)
            {
                AX_rozkaz.Text = CX_rozkaz.Text;
            }

            if (radioButton2.Checked && radioButton6.Checked)
            {
                BX_rozkaz.Text = CX_rozkaz.Text;
            }

            if (radioButton4.Checked && radioButton6.Checked)
            {
                DX_rozkaz.Text = CX_rozkaz.Text;
            }

            //==================DX=================

            if (radioButton1.Checked && radioButton5.Checked)
            {
                AX_rozkaz.Text = DX_rozkaz.Text;
            }

            if (radioButton2.Checked && radioButton5.Checked)
            {
                BX_rozkaz.Text = DX_rozkaz.Text;
            }

            if (radioButton3.Checked && radioButton5.Checked)
            {
                CX_rozkaz.Text = DX_rozkaz.Text;
            }




            //===================HIGH===================

            //===========AX===============
            var zmienna = " ";

            if (radioButton10.Checked && radioButton13.Checked)
            {
                AX_rozkaz.Text = textBox1.Text;
                zmienna = Convert.ToString(AX_rozkaz);
            }

            if (radioButton10.Checked && radioButton14.Checked)
            {
                BX_rozkaz.Text = textBox1.Text;
            }

            if (radioButton10.Checked && radioButton15.Checked)
            {
                CX_rozkaz.Text = textBox1.Text;
            }

            if (radioButton10.Checked && radioButton16.Checked)
            {
                DX_rozkaz.Text = textBox1.Text;
            }

            //================BX================

            if (radioButton9.Checked && radioButton13.Checked)
            {
                AX_rozkaz.Text = textBox2.Text;
                zmienna = Convert.ToString(AX_rozkaz);
            }

            if (radioButton9.Checked && radioButton14.Checked)
            {
                BX_rozkaz.Text = textBox2.Text;
            }

            if (radioButton9.Checked && radioButton15.Checked)
            {
                CX_rozkaz.Text = textBox2.Text;
            }

            if (radioButton9.Checked && radioButton16.Checked)
            {
                DX_rozkaz.Text = textBox2.Text;
            }

            //================CX================

            if (radioButton12.Checked && radioButton13.Checked)
            {
                AX_rozkaz.Text = textBox3.Text;
                zmienna = Convert.ToString(AX_rozkaz);
            }

            if (radioButton12.Checked && radioButton14.Checked)
            {
                BX_rozkaz.Text = textBox3.Text;
            }

            if (radioButton12.Checked && radioButton15.Checked)
            {
                CX_rozkaz.Text = textBox3.Text;
            }

            if (radioButton12.Checked && radioButton16.Checked)
            {
                DX_rozkaz.Text = textBox3.Text;
            }

            //================DX================

            if (radioButton11.Checked && radioButton13.Checked)
            {
                AX_rozkaz.Text = textBox4.Text;
                zmienna = Convert.ToString(AX_rozkaz);
            }

            if (radioButton11.Checked && radioButton14.Checked)
            {
                BX_rozkaz.Text = textBox4.Text;
            }

            if (radioButton11.Checked && radioButton15.Checked)
            {
                CX_rozkaz.Text = textBox4.Text;
            }

            if (radioButton11.Checked && radioButton16.Checked)
            {
                DX_rozkaz.Text = textBox4.Text;
            }







            //===================LOW===================

            //===========AX===============
            string zera = "00";

            if (radioButton18.Checked && radioButton21.Checked)
            {
                if (textBox1.Text != "")
                {
                    AX_rozkaz.Text = textBox1.Text.ToUpper() + textBox8.Text.ToUpper();
                }
                else
                {
                    AX_rozkaz.Text = zera + textBox8.Text.ToUpper();
                }
                
            }

            if (radioButton18.Checked && radioButton22.Checked)
            {
                if (textBox2.Text != "")
                {
                    BX_rozkaz.Text = textBox2.Text.ToUpper() + textBox8.Text.ToUpper();
                }
                else
                {
                    BX_rozkaz.Text = zera + textBox8.Text.ToUpper();
                }
            }

            if (radioButton18.Checked && radioButton23.Checked)
            {
                if (textBox3.Text != "")
                {
                    CX_rozkaz.Text = textBox3.Text.ToUpper() + textBox8.Text.ToUpper();
                }
                else
                {
                    CX_rozkaz.Text = zera + textBox8.Text.ToUpper();
                }
            }

            if (radioButton18.Checked && radioButton24.Checked)
            {
                if (textBox4.Text != "")
                {
                    DX_rozkaz.Text = textBox4.Text.ToUpper() + textBox8.Text.ToUpper();
                }
                else
                {
                    DX_rozkaz.Text = zera + textBox8.Text.ToUpper();
                }
            }




            //===========BX===============

            if (radioButton17.Checked && radioButton21.Checked)
            {
                if (textBox1.Text != "")
                {
                    AX_rozkaz.Text = textBox1.Text.ToUpper() + textBox7.Text.ToUpper();
                }
                else
                {
                    AX_rozkaz.Text = zera + textBox7.Text.ToUpper();
                }

            }

            if (radioButton17.Checked && radioButton22.Checked)
            {
                if (textBox2.Text != "")
                {
                    BX_rozkaz.Text = textBox2.Text.ToUpper() + textBox7.Text.ToUpper();
                }
                else
                {
                    BX_rozkaz.Text = zera + textBox7.Text.ToUpper();
                }
            }

            if (radioButton17.Checked && radioButton23.Checked)
            {
                if (textBox3.Text != "")
                {
                    CX_rozkaz.Text = textBox3.Text.ToUpper() + textBox7.Text.ToUpper();
                }
                else
                {
                    CX_rozkaz.Text = zera + textBox7.Text.ToUpper();
                }
            }

            if (radioButton17.Checked && radioButton24.Checked)
            {
                if (textBox4.Text != "")
                {
                    DX_rozkaz.Text = textBox4.Text.ToUpper() + textBox7.Text.ToUpper();
                }
                else
                {
                    DX_rozkaz.Text = zera + textBox7.Text.ToUpper();
                }
            }


            //===========CX===============

            if (radioButton20.Checked && radioButton21.Checked)
            {
                if (textBox1.Text != "")
                {
                    AX_rozkaz.Text = textBox1.Text.ToUpper() + textBox6.Text.ToUpper();
                }
                else
                {
                    AX_rozkaz.Text = zera + textBox6.Text.ToUpper();
                }

            }

            if (radioButton20.Checked && radioButton22.Checked)
            {
                if (textBox2.Text != "")
                {
                    BX_rozkaz.Text = textBox2.Text.ToUpper() + textBox6.Text.ToUpper();
                }
                else
                {
                    BX_rozkaz.Text = zera + textBox6.Text.ToUpper();
                }
            }

            if (radioButton20.Checked && radioButton23.Checked)
            {
                if (textBox3.Text != "")
                {
                    CX_rozkaz.Text = textBox3.Text.ToUpper() + textBox6.Text.ToUpper();
                }
                else
                {
                    CX_rozkaz.Text = zera + textBox6.Text.ToUpper();
                }
            }

            if (radioButton20.Checked && radioButton24.Checked)
            {
                if (textBox4.Text != "")
                {
                    DX_rozkaz.Text = textBox4.Text.ToUpper() + textBox6.Text.ToUpper();
                }
                else
                {
                    DX_rozkaz.Text = zera + textBox6.Text.ToUpper();
                }
            }


            //===========DX===============

            if (radioButton19.Checked && radioButton21.Checked)
            {
                if (textBox1.Text != "")
                {
                    AX_rozkaz.Text = textBox1.Text.ToUpper() + textBox5.Text.ToUpper();
                }
                else
                {
                    AX_rozkaz.Text = zera + textBox5.Text.ToUpper();
                }

            }

            if (radioButton19.Checked && radioButton22.Checked)
            {
                if (textBox2.Text != "")
                {
                    BX_rozkaz.Text = textBox2.Text.ToUpper() + textBox5.Text.ToUpper();
                }
                else
                {
                    BX_rozkaz.Text = zera + textBox5.Text.ToUpper();
                }
            }

            if (radioButton19.Checked && radioButton23.Checked)
            {
                if (textBox3.Text != "")
                {
                    CX_rozkaz.Text = textBox3.Text.ToUpper() + textBox5.Text.ToUpper();
                }
                else
                {
                    CX_rozkaz.Text = zera + textBox5.Text.ToUpper();
                }
            }

            if (radioButton19.Checked && radioButton24.Checked)
            {
                if (textBox4.Text != "")
                {
                    DX_rozkaz.Text = textBox4.Text.ToUpper() + textBox5.Text.ToUpper();
                }
                else
                {
                    DX_rozkaz.Text = zera + textBox5.Text.ToUpper();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {


            //================AX=================
            string zmiennaCzasowa = "";

            if (radioButton2.Checked && radioButton8.Checked)
            {
                zmiennaCzasowa = BX_rozkaz.Text;
                BX_rozkaz.Text = AX_rozkaz.Text;
                AX_rozkaz.Text = zmiennaCzasowa;
            }

            if (radioButton3.Checked && radioButton8.Checked)
            {
                zmiennaCzasowa = CX_rozkaz.Text;
                CX_rozkaz.Text = AX_rozkaz.Text;
                AX_rozkaz.Text = zmiennaCzasowa;
            }

            if (radioButton4.Checked && radioButton8.Checked)
            {
                zmiennaCzasowa = DX_rozkaz.Text;
                DX_rozkaz.Text = AX_rozkaz.Text;
                AX_rozkaz.Text = zmiennaCzasowa;
            }

            //==================BX=================

            if (radioButton1.Checked && radioButton7.Checked)
            {
                zmiennaCzasowa = AX_rozkaz.Text;
                AX_rozkaz.Text = BX_rozkaz.Text;
                BX_rozkaz.Text = zmiennaCzasowa;
            }

            if (radioButton3.Checked && radioButton7.Checked)
            {
                zmiennaCzasowa = CX_rozkaz.Text;
                CX_rozkaz.Text = BX_rozkaz.Text;
                BX_rozkaz.Text = zmiennaCzasowa;
            }

            if (radioButton4.Checked && radioButton7.Checked)
            {
                zmiennaCzasowa = DX_rozkaz.Text;
                DX_rozkaz.Text = BX_rozkaz.Text;
                BX_rozkaz.Text = zmiennaCzasowa;
            }

            //==================CX=================

            if (radioButton1.Checked && radioButton6.Checked)
            {
                zmiennaCzasowa = AX_rozkaz.Text;
                AX_rozkaz.Text = CX_rozkaz.Text;
                CX_rozkaz.Text = zmiennaCzasowa;
            }

            if (radioButton2.Checked && radioButton6.Checked)
            {
                zmiennaCzasowa = BX_rozkaz.Text;
                BX_rozkaz.Text = CX_rozkaz.Text;
                CX_rozkaz.Text = zmiennaCzasowa;
            }

            if (radioButton4.Checked && radioButton6.Checked)
            {
                zmiennaCzasowa = DX_rozkaz.Text;
                DX_rozkaz.Text = CX_rozkaz.Text;
                CX_rozkaz.Text = zmiennaCzasowa;
            }

            //==================DX=================

            if (radioButton1.Checked && radioButton5.Checked)
            {
                AX_rozkaz.Text = DX_rozkaz.Text;
            }

            if (radioButton2.Checked && radioButton5.Checked)
            {
                BX_rozkaz.Text = DX_rozkaz.Text;
            }

            if (radioButton3.Checked && radioButton5.Checked)
            {
                CX_rozkaz.Text = DX_rozkaz.Text;
            }


        }
    }
}
