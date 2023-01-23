using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Runtime.InteropServices;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.Win32;
using System.Diagnostics;

namespace AntibanNewDesign
{
    public partial class Login : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "qtkL8PYaPBgTwdGx5HokbZcuQ2XH9Gjs0Yu6rE7p",
            BasePath = "https://igt-antibann.firebaseio.com/"
        };
        IFirebaseClient client;


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.FromArgb(12,17,25), ButtonBorderStyle.Solid);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label2.Hide();
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\WOW6432Node\LTANM404", true);
                var keysav = key.GetValue("data");
                textBox1.Text = keysav.ToString();
                int x = textBox1.Text.Length;
                textBox1.SelectionStart = x;
            }
            catch
            { 
                textBox1.SelectionStart = 0;
            }
            
            textBox1.AutoSize = false;
            textBox1.Size = new Size(268,30);
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            client = new FireSharp.FirebaseClient(config);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }
        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\WOW6432Node\WOW6432Node\LTANM404",true);
            key.SetValue("data", textBox1.Text.ToString());
            //try
            //{
                var response = await client.GetTaskAsync("KeyInfo/" + textBox1.Text);
                Data result = response.ResultAs<Data>();
                string banstr = result.banned.ToString();
                string timestr = result.time.ToString();
                string usernamestr = result.username.ToString();
                string activestr = result.active.ToString();
                if(banstr == "yes")
                {
                    MessageBox.Show("You will be banned for violating regulations. Contact administrator to unban key.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (activestr == "yes")
                    {
                        if (timestr == "life")
                        {
                            this.Hide();
                            new Main().Show();
                        }
                        else
                        {
                            MessageBox.Show("Key suspended. That was a one time entry key.\n\nYou can ask admin for more test keys :)", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            await client.DeleteTaskAsync("KeyInfo/" + textBox1.Text);
                        }
                    }
                    else
                    {
                        this.Hide();
                        new Main().Show();
                    }

                }
                
            //}
           /* catch
            {
                MessageBox.Show("Network error or key does not exists", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/


        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/QqCgWqx");
        }

        private async void label2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCJ-JWN4VYTtg1OwbyHwNxHg");
            await Task.Delay(100);
            Process.Start("https://www.youtube.com/channel/UC2tk0_N2DzJQ_zCYXjFgJfw");
            
            
        }
    }
}
