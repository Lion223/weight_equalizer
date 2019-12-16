using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WeightEqualizer
{
    public partial class EnterForm : Form
    {
        bool signup = false;
        bool firstIteractionME = true;
        string appPath = Application.StartupPath;
        public static string finalPath;
        public EnterForm()
        {
            InitializeComponent();
        }

        private void Enter_Load(object sender, EventArgs e)
        {
            birthDt.Visible = false;
            genderCb.Visible = false;
            signinBtn.Location = new Point(62, 65);
            signupBtn.Location = new Point(91, 141);
            separator.Location = new Point(138, 141);
            exitLb.Location = new Point(150, 141);
            this.Size = new Size(284, 174);
            loginTb.ForeColor = Color.White;
        }

        public string GetPath()
        {
            if (finalPath != string.Empty && finalPath != "" && finalPath != null)
                return finalPath;
            else return null;
        }

        private void loginTb_MouseEnter(object sender, EventArgs e)
        {
            if (firstIteractionME)
            {
                loginTb.Text = "";
                firstIteractionME = false;
            }
            loginTb.ForeColor = Color.White;
        }

        private void signupBtn_MouseEnter(object sender, EventArgs e)
        {
            signupBtn.ForeColor = Color.Crimson;
        }

        private void signupBtn_MouseLeave(object sender, EventArgs e)
        {
            signupBtn.ForeColor = Color.White;
        }

        private void exitLb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitLb_MouseEnter(object sender, EventArgs e)
        {
            exitLb.ForeColor = Color.Crimson;
        }

        private void exitLb_MouseLeave(object sender, EventArgs e)
        {
            exitLb.ForeColor = Color.White;
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (!signup)
            {
                signup = true;
                signupBtn.Text = "Sign In";
                signinBtn.Text = "Sign Up";
                this.Size = new Size(284, 287);
                signinBtn.Location = new Point(62, 182);
                signupBtn.Location = new Point(91, 258);
                separator.Location = new Point(138, 258);
                exitLb.Location = new Point(150, 258);
                birthDt.Visible = true;
                genderCb.Visible = true;
                loginTb.ForeColor = Color.White;
            }
            else
            {
                signup = false;
                signupBtn.Text = "Sign Up";
                signinBtn.Text = "Sign In";
                this.Size = new Size(284, 174);
                signinBtn.Location = new Point(62, 65);
                signupBtn.Location = new Point(91, 141);
                separator.Location = new Point(138, 141);
                exitLb.Location = new Point(150, 141);
                birthDt.Visible = false;
                genderCb.Visible = false;
                loginTb.ForeColor = Color.White;
            }
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            string usersPath = appPath + @"\Users";
            string userPath = usersPath + @"\" + loginTb.Text + ".txt";
            if (!signup)
            {
                if (loginTb.Text != "Login" && loginTb.Text != "")
                {
                    if (File.Exists(userPath))
                    {
                        string birthLine = ((DateTime.Now -
                            DateTime.Parse(File.ReadLines(userPath).Skip(1).First())).Days / 365).ToString();
                        string ageLine = File.ReadLines(userPath).Skip(2).First();
                        if (!birthLine.Equals(ageLine))
                        {
                            Regex r = new Regex(ageLine);
                            string str = string.Empty;
                            using (System.IO.StreamReader reader = System.IO.File.OpenText(userPath))
                            {
                                str = reader.ReadToEnd();
                            }
                            str = r.Replace(str, birthLine, 1);

                            using (System.IO.StreamWriter file = new System.IO.StreamWriter(userPath))
                            {
                                file.Write(str);
                            }
                        }
                        finalPath = userPath;
                        this.Hide();
                        var form1 = new MainForm();
                        form1.Closed += (s, args) => this.Close();
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("This login is not registered");
                        signupBtn_Click(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Enter your login");
                }

            }
            else
            {
                if (loginTb.Text != "Login" && loginTb.Text != "" && birthDt.Value.ToShortDateString()
                    != DateTime.Now.ToShortDateString() && genderCb.SelectedIndex != -1)
                {
                    Directory.CreateDirectory(usersPath);
                    string userAge = ((DateTime.Now - birthDt.Value).Days / 365).ToString();
                    if (!File.Exists(userPath))
                    {
                        using (var tw = new StreamWriter(userPath, true))
                        {
                            tw.WriteLine(loginTb.Text);
                            tw.WriteLine(birthDt.Value.ToShortDateString());
                            tw.WriteLine(userAge);
                            tw.WriteLine(genderCb.SelectedItem);
                        }
                        MessageBox.Show("Registration is successful");
                        signupBtn_Click(this, new EventArgs());
                    }
                    else if (File.Exists(userPath))
                    {
                        MessageBox.Show("This login is not available");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong data");
                }

            }
        }

        private void loginTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signinBtn_Click(this, new EventArgs());
            }
        }
    }
}
