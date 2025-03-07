using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб9._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        float RunTime(int x)
        {
            int S = 10;
            float time = (S / x) * 60;
            return time;
        }

        float SwimTime(int x)
        {
            int S = 1500;
            float time = S / x;
            return time;
        }
        float CycleTime(int x)
        {
            int S = 40;
            float time = (S / x) * 60;
            return time;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            helpProvider1.SetHelpString(textBox1, "Andrew is best swimmer");
            helpProvider1.SetHelpString(textBox3, "Andrew is best swimmer");
            helpProvider1.SetHelpString(textBox4, "Andrew is bbestetter swimmer");
            helpProvider1.SetHelpString(textBox7, "Egor is best runner");
            helpProvider1.SetHelpString(textBox8, "Egor is best runner");
            helpProvider1.SetHelpString(textBox9, "Egor is best runner");
            helpProvider1.SetHelpString(textBox2, "Michael is best cyclist");
            helpProvider1.SetHelpString(textBox5, "Michael is best cyclist");
            helpProvider1.SetHelpString(textBox6, "Michael is best cyclist");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (e is null)
                buttonTime.Enabled = false;
        }

        private void buttonTime_Click(object sender, EventArgs e)
        {
            int AS, AC, AR, ES, EC, ER, MS, MC, MR;
            float AT, ET, MT;

            if (textBox1.Text == "")
                textBox1.BackColor = Color.LightCoral;
             else if (textBox2.Text == "")
                textBox2.BackColor = Color.LightCoral;
            else if (textBox3.Text == "")
                textBox3.BackColor = Color.LightCoral;
            else if (textBox4.Text == "")
                textBox4.BackColor = Color.LightCoral;
            else if (textBox5.Text == "")
                textBox5.BackColor = Color.LightCoral;
            else if (textBox6.Text == "")
                textBox6.BackColor = Color.LightCoral;
            else if (textBox7.Text == "")
                textBox7.BackColor = Color.LightCoral;
            else if (textBox8.Text == "")
                textBox8.BackColor = Color.LightCoral;
            else if (textBox9.Text == "")
                textBox9.BackColor = Color.LightCoral;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("Введите скорость всех участников", "Неверный ввод",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            AS = int.Parse(textBox1.Text);
            AC = int.Parse(textBox2.Text);
            AR = int.Parse(textBox7.Text);

            ES = int.Parse(textBox3.Text);
            EC = int.Parse(textBox5.Text);
            ER = int.Parse(textBox8.Text);

            MS = int.Parse(textBox4.Text);
            MC = int.Parse(textBox6.Text);
            MR = int.Parse(textBox9.Text);

            if (AS <= ES || AS <= MS)
            {
                MessageBox.Show("Андрей плавает быстрее всех", "Неверный ввод",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (ER <= AR || ER <= MR)
            {
                MessageBox.Show("Егор бегает быстрее всех", "Неверный ввод",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MC <= AC || MC <= EC)
            {
                MessageBox.Show("Михаил бегает быстрее крутит педали", "Неверный ввод",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                AT = RunTime(AR) + SwimTime(AS) + CycleTime(AC);
                ET = RunTime(ER) + SwimTime(ES) + CycleTime(EC);
                MT = RunTime(MR) + SwimTime(MS) + CycleTime(MC);
                textBox10.Text = AT.ToString();
                textBox11.Text = ET.ToString();
                textBox12.Text = MT.ToString();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.White;
        }
        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.White;
        }
        private void textBox7_Enter(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.White;
        }
        private void textBox8_Enter(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.White;
        }
        private void textBox9_Enter(object sender, EventArgs e)
        {
            textBox9.BackColor = Color.White;
        }

        private void buttonChampion_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                MessageBox.Show("Рассчитайте время каждого участника", "Неверный ввод",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int A, E, M;
            A = int.Parse(textBox10.Text);
            E = int.Parse(textBox11.Text);
            M = int.Parse(textBox12.Text);

            if (A < E && A < M)
                textBox13.Text = "Андрей";
            else if (E < A && E < M)
                textBox13.Text = "Егор";
            else if (M < A && M < E)
                textBox13.Text = "Михаил";
        }
    }
}
