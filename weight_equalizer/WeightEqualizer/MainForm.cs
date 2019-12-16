using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WeightEqualizer
{
    public partial class MainForm : Form
    {
        string userPath;
        bool weightData = false;
        string[] fileData;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            EnterForm enter = new EnterForm();
            userPath = enter.GetPath();
            nameTb.Text = File.ReadLines(userPath).First();
            nameTb.Icon = File.ReadLines(userPath).Skip(3).First() == "Male" ? Properties.Resources.male : Properties.Resources.female;
            yoTb.Text = File.ReadLines(userPath).Skip(2).First() + " y.o";

            try
            {
                File.ReadLines(userPath).Skip(4).First();
                weightData = true;
            }
            catch (System.InvalidOperationException)
            {
                weightData = false;
            }

            if (weightData)
            {
                fileData = File.ReadAllLines(userPath).Skip(4).ToArray();
                string date;
                string weight;
                int k;
                foreach (string s in fileData)
                {
                    k = s.IndexOf('$');
                    date = s.Substring(0, k);
                    weight = s.Substring(++k);
                    weightChart.Series["Series1"].Points.AddXY(DateTime.Parse(date), Convert.ToDouble(weight));
                }
            }
            if (weightChart.Series["Series1"].Points.Count > 0)
            {
                emptyChartLbl.Visible = false;
                GetCurrWeight();
                GetSubWeight();
            }
        }

        public void GetCurrWeight()
        {
            DataPoint pLast = weightChart.Series["Series1"].Points.Last();
            enterCurrWeightTb.Text = pLast.YValues[0].ToString();
        }

        public void GetSubWeight()
        {
            DataPoint pLast = weightChart.Series["Series1"].Points.Last();
            DataPoint pPrelast;
            if (weightChart.Series["Series1"].Points.Count > 1)
            {
                pPrelast = weightChart.Series["Series1"].Points.ElementAt(weightChart.Series["Series1"].Points.Count - 2);
                if ((pLast.YValues[0] - pPrelast.YValues[0]) > 0)
                {
                    subWeightTb.ForeColor = Color.Red;
                    subWeightTb.Text = (pLast.YValues[0] - pPrelast.YValues[0]).ToString("F1");
                }
                else if ((pLast.YValues[0] - pPrelast.YValues[0]) < 0)
                {
                    subWeightTb.ForeColor = Color.Green;
                    subWeightTb.Text = (pLast.YValues[0] - pPrelast.YValues[0]).ToString("F1");
                }
                else
                {
                    subWeightTb.ForeColor = Color.White;
                    subWeightTb.Text = (pLast.YValues[0] - pPrelast.YValues[0]).ToString("F1");
                }
            }
        }

        public void AddWeight()
        {
            weightChart.Series["Series1"].Points.AddXY(DateTime.Now, Convert.ToDouble(currWeightTb.Text));
            if (File.Exists(userPath))
            {
                using (var tw = new StreamWriter(userPath, true))
                {
                    tw.WriteLine(DateTime.Now + "$" + currWeightTb.Text);
                    tw.Close();
                }
            }
        }

        public void UpdWeight()
        {
            weightChart.Series["Series1"].Points.AddXY(DateTime.Now, Convert.ToDouble(currWeightTb.Text));
            weightChart.Update();
            weightChart.Series["Series1"].Points.RemoveAt(weightChart.Series["Series1"].Points.Count - 2);
            if (File.Exists(userPath))
            {
                string[] temp = System.IO.File.ReadAllLines(userPath);
                using (var tw = new StreamWriter(userPath, false))
                {
                    for (int i = 0; i < temp.Length - 1; i++)
                    {
                        tw.WriteLine(temp[i]);
                    }
                    tw.Close();
                }

                using (var tw = new StreamWriter(userPath, true))
                {
                    tw.WriteLine(DateTime.Now + "$" + currWeightTb.Text);
                    tw.Close();
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void currWeightTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataPoint pLast;
                if (weightChart.Series["Series1"].Points.Count > 0)
                {
                    if (weightChart.Series["Series1"].Points.Count > 0)
                    {
                        pLast = weightChart.Series["Series1"].Points.Last();
                        if (!DateTime.FromOADate(pLast.XValue).ToShortDateString().Equals(DateTime.Now.ToShortDateString()))
                        {
                            AddWeight();
                        }
                        else
                        {
                            if (MessageBox.Show("You have already added your weight index for today. " +
                                "Do you wish to update today's weight?", "Today's weigth",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                UpdWeight();
                            }
                            else
                            {
                                // user clicked no
                            }
                        }
                    }
                    else
                    {
                        AddWeight();
                    }
                }
                else
                {
                    emptyChartLbl.Visible = false;
                    AddWeight();
                }
                GetCurrWeight();
                GetSubWeight();
                currWeightTb.Text = "";
            }
            if (weightChart.Series["Series1"].Points.Count > 10)
            {
                weightChart.ChartAreas["ChartArea1"].AxisX.ScaleView.Position = weightChart.Series["Series1"].Points.Count - 10;
                weightChart.ChartAreas["ChartArea1"].AxisX.ScaleView.Size = 10;
            }
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You will be returned to login menu, continue?",
                "Back to login menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                var form1 = new EnterForm();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
            else
            {
                // user clicked no
            }
        }

        private void currWeightTb_ButtonClick(object sender, EventArgs e)
        {
            currWeightTb_KeyDown(sender, new KeyEventArgs(Keys.Enter));
        }
    }
}
