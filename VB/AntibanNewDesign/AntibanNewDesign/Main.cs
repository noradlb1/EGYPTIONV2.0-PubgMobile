using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using WMPLib;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using AntibanNewDesign.Properties;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.Win32;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Reflection;
using SHDocVw;
using System.Security.AccessControl;
using System.Security.Principal;

namespace AntibanNewDesign
{
    public partial class Main : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
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
        public Main()
        {
            InitializeComponent();
            this.player.URL = "RS.mp3";
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
        Data result0;
        private async void banchecks()
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\WOW6432Node\LTANM404", true);
                var keysav = key.GetValue("data");
                var response0 = client.Get("KeyInfo/" + keysav.ToString());
                result0 = response0.ResultAs<Data>();
                OnKeyLTX();
                label4.Text = "Hi! " + result0.username;
                if (result0.time.ToString() == "life")
                {
                    label5.Text = "LifeTime Access";
                    label5.ForeColor = Color.Red; ;
                }
                else
                {
                    label5.Text = "One Time Access (Test key)";
                }


                while (true)
                {
                    await Task.Delay(6000);
                    var response = await client.GetTaskAsync("KeyInfo/" + keysav.ToString());
                    Data result = response.ResultAs<Data>();

                    if (result.banned.ToString() == "yes")
                    {
                        this.Hide();
                        try
                        {
                            taskend("AndroidEmulator");
                            
                        }
                        catch { }
                        MessageBox.Show("Data has changed and you have been disconnected!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                this.Close();
            }
            catch
            {
                this.Hide();
                try
                {
                    taskend("AndroidEmulator");
                    
                }
                catch { }
                MessageBox.Show("Connection Failure! Program terminated.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-2);
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/SvNr8JpGBy");
            Process.Start("https://discord.gg/am2mB7tpe5");
            MessageBox.Show("welcome to EGYPT ANTIBAN V2.0 DEAR USERS PLZ WATCH TUTORIAL BEFORE USING");
            File.Delete(@"C:\Windows\System32\drivers\etc\hosts");
            ProcessStartInfo IGT = new ProcessStartInfo();
            IGT.FileName = "cmd.exe";
            IGT.WindowStyle = ProcessWindowStyle.Hidden;
            IGT.Verb = "runas";
            IGT.Arguments = "/c sc stop QMEmulatorService";
            Process.Start(IGT);
            File.Delete(@"C:\Windows\System32\drivers\etc\hosts");
            ProcessStartInfo IGT2 = new ProcessStartInfo();
            IGT2.FileName = "cmd.exe";
            IGT2.WindowStyle = ProcessWindowStyle.Hidden;
            IGT2.Verb = "runas";
            IGT2.Arguments = "/c sc config QMEmulatorService start= disabled";
            Process.Start(IGT2);
            cmd("netsh advfirewall reset");
            cmd("netsh advfirewall firewall add rule name=update_error protocol=ANY dir=out remoteip=123.151.71.34 action=block enable=yes");
            cmd("netsh advfirewall firewall add rule name=update_error protocol=ANY dir=in remoteip=123.151.71.34 action=block enable=yes");
            cmd("netsh advfirewall firewall add rule name=update_error protocol=ANY dir=out remoteip=203.205.239.243 action=block enable=yes");
            cmd("netsh advfirewall fireswwall add rule name=update_error protocol=ANY dir=in remoteip=203.205.239.243 action=block enable=yes");
            File.Delete(@"C:\Windows\System32\drivers\etc\hosts");
            File.CreateText(@"C:\Windows\System32\drivers\etc\hosts").Close();
            try
            {
                DirectoryInfo di = new DirectoryInfo(Path.GetTempPath());
                foreach (FileInfo file in di.GetFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch { }
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch { }
                }
            }
            catch { }
            ///
            try
            {
                ////Deleting prefetch files
                DirectoryInfo di2 = new DirectoryInfo(Environment.ExpandEnvironmentVariables(@"%windir%\Prefetch"));
                foreach (FileInfo file2 in di2.GetFiles())
                {
                    try
                    {
                        file2.Delete();
                    }
                    catch { }
                }
                foreach (DirectoryInfo dir2 in di2.GetDirectories())
                {
                    try
                    {
                        dir2.Delete(true);
                    }
                    catch { }
                }
            }
            catch { }
            ///
            try
            {
                ///Deleting temp files
                DirectoryInfo di3 = new DirectoryInfo(Environment.ExpandEnvironmentVariables(@"%windir%\temp"));
                foreach (FileInfo file3 in di3.GetFiles())
                {
                    try
                    {
                        file3.Delete();
                    }
                    catch { }
                }
                foreach (DirectoryInfo dir3 in di3.GetDirectories())
                {
                    try
                    {
                        dir3.Delete(true);
                    }
                    catch { }
                }
            }
            catch { }
            try
            {
                DirectoryInfo di4 = new DirectoryInfo(Environment.ExpandEnvironmentVariables(@"%userprofile%\AppData\Roaming\Tencent"));
                foreach (FileInfo file4 in di4.GetFiles())
                {
                    try
                    {
                        file4.Delete();
                    }
                    catch { }
                }
                foreach (DirectoryInfo dir4 in di4.GetDirectories())
                {
                    try
                    {
                        dir4.Delete(true);
                    }
                    catch { }
                }
            }
            catch { }

            client = new FireSharp.FirebaseClient(config);


            banchecks();
        }
        bool x = true;
        FileSystemAccessRule fsr = new FileSystemAccessRule("Authenticated Users", FileSystemRights.FullControl, AccessControlType.Deny);
        FileSecurity fSecurity = File.GetAccessControl(@"C:\Windows\System32\drivers\etc\hosts");
        private async void protection()
        {
            var filename = @"C:\Windows\System32\drivers\etc\hosts";
            fSecurity.AddAccessRule(fsr);
            File.SetAccessControl(filename, fSecurity);

            while (x)
            {
                await Task.Delay(50);
                ShellWindows _shellWindows = new ShellWindows();
                string processType;

                foreach (InternetExplorer ie in _shellWindows)
                {
                    //this parses the name of the process
                    processType = Path.GetFileNameWithoutExtension(ie.FullName).ToLower();

                    //this could also be used for IE windows with processType of "iexplore"
                    if (processType.Equals("explorer") && ie.LocationURL.Contains(@"C:/Windows/System32/drivers"))
                    {
                        ie.Quit();
                        this.Hide();
                        MessageBox.Show(this, "Access violation!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();

                    }
                }
            }


        }
        private async void coreprotection()

        {
            while (x)
            {
                await Task.Delay(50);
                ShellWindows _shellWindows = new ShellWindows();
                string processType;

                foreach (InternetExplorer ie in _shellWindows)
                {
                    processType = Path.GetFileNameWithoutExtension(ie.FullName).ToLower();
                    if (processType.Equals("explorer") && ie.LocationURL.Contains(@"C:/Windows/System32/drivers/etc"))
                    {
                        ie.Quit();
                        this.Hide();
                        MessageBox.Show(this, "Access violation!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
        }
        private void OnKeyLTX()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\WOW6432Node\LTANM404", true);
            var keysav = key.GetValue("data");
            var data = new Data
            {
                username = result0.username,
                time = result0.time,
                banned = "no",
                active = "yes"
            };
            SetResponse response = client.Set("KeyInfo/" + keysav.ToString(), data);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Tencent\MobileGamePC\UI");
                var path = key.GetValue("InstallPath");
                RegistryKey k = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\WOW6432Node\Tencent\MobileGamePC\UI", true);
                k.SetValue("AppXLTX", "LTXOP");
                
            }
            catch
            {
                MessageBox.Show("Process blocked due to interference of another service");
            }
        }

        static void taskend(string AppName)
        {
            foreach (var process in Process.GetProcessesByName(AppName))
            {
                try
                {
                    process.Kill();
                }
                catch
                { }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            protection();
            coreprotection();
            try
            {
                var filename = @"C:\Windows\System32\drivers\etc\hosts";
                fSecurity.RemoveAccessRule(fsr);
                File.SetAccessControl(filename, fSecurity);
                File.Delete(@"C:\Windows\System32\drivers\etc\hosts");
                
                
                
                
                fSecurity.RemoveAccessRule(fsr);
                File.SetAccessControl(filename, fSecurity);
               
                
                //process start
                RegistryKey k = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\WOW6432Node\Tencent\MobileGamePC\UI", true);
                k.SetValue("AppXLTX", "LTXOP");
                
            }
            catch
            {
                MessageBox.Show("Process blocked due to interference of another service");
            }
        }

        private void extracthost(string rsrname)
        {
            Assembly assembly = Assembly.GetCallingAssembly();
            using (Stream s = assembly.GetManifestResourceStream("AntibanNewDesign.files." + rsrname))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(Path.GetTempPath() + rsrname, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
                w.Write(r.ReadBytes((int)s.Length));
        }



        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var filename = @"C:\Windows\System32\drivers\etc\hosts";
                fSecurity.RemoveAccessRule(fsr);
                File.SetAccessControl(filename, fSecurity);
                taskend("AndroidEmulator");
                File.Delete(@"C:\Windows\System32\drivers\etc\hosts");
                
                
                
                
                Environment.Exit(0);
            }
            catch
            {
                Environment.Exit(0);
            }
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var filename = @"C:\Windows\System32\drivers\etc\hosts";
                fSecurity.RemoveAccessRule(fsr);
                File.SetAccessControl(filename, fSecurity);
                taskend("AndroidEmulator");
               
                
    
                
                Environment.Exit(0);
            }
            catch
            {
                Environment.Exit(0);
            }
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Tencent\MobileGamePC\UI");
            var path = key.GetValue("InstallPath");
            Process.Start(path + @"\AndroidEmulator.exe");
        }
        static void cmd(string command)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Verb = "runas";
            process.Start();
            process.StandardInput.WriteLine(command);
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            process.Close();
        }

        private void Guna2Button6_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("STARTTING");
            Console.Beep();
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.Verb = "runas";
            ps.Arguments = "/c adb start server";
            Process.Start(ps);

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.Verb = "runas";
            psi.Arguments = "/c adb connect";
            Process.Start(psi);

            ProcessStartInfo qweas = new ProcessStartInfo();
            qweas.FileName = "cmd.exe";
            qweas.WindowStyle = ProcessWindowStyle.Hidden;
            qweas.Verb = "runas";
            qweas.Arguments = "/c adb -s emulator-5554 shell am start -n com.rekoo.pubgm/com.epicgames.ue4.SplashActivity";
            Process.Start(qweas);
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            string x = guna2Button3.Text.ToString();
            if (x == "Turn OFF Antiban")
            {
                var answer = MessageBox.Show("Are you sure you want to turn off antiban?\n\nIt can give 10 years ban if memory was changed or 3 months ban in lobby due to modded UI.\n\nTurn off only if you are stuck in 'Checking for updates...' screen or due login error.\n\n After updating or logging in, instantly close game as soon as you see loading screen just before entering lobby.\n\n Failing to do the above will lead to 3 months ban due to modded UI detection.\n\nPress OK to turn off or Cancel to abort.", "NOTICE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (answer.ToString() == "OK")
                {
                    var filename = @"C:\Windows\System32\drivers\etc\hosts";
                    fSecurity.RemoveAccessRule(fsr);
                    File.SetAccessControl(filename, fSecurity);
                    try
                    {
                        File.Delete(@"C:\Windows\System32\drivers\etc\hosts");
                        //File.Delete(Path.GetTempPath() + "original.txt");
                        //extracthost("original.txt");
                        //File.Copy(Path.GetTempPath() + "original.txt", @"C:\Windows\System32\drivers\etc\hosts");
                        //File.Delete(Path.GetTempPath() + "original.txt");
                        guna2Button3.Text = "Antiban OFF (Auto only)";
                        guna2Button3.BackColor = Color.FromArgb(112, 128, 144);
                    }
                    catch
                    {
                        MessageBox.Show("Process blocked due to some other application's interference.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void Guna2Button8_Click(object sender, EventArgs e)
        {
            File.WriteAllBytes("C:\\Windows\\System32\\drivers\\etc\\hosts", Resources.hosts);
        }

        private void Guna2ControlBox1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.Verb = "runas";
            ps.Arguments = "/c taskkill /F /IM tp3helper.dat";
            Process.Start(ps);

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.Verb = "runas";
            psi.Arguments = "/c TaskKill /F /IM androidemulator.exe";
            Process.Start(psi);

            ProcessStartInfo psi4 = new ProcessStartInfo();
            psi4.FileName = "cmd.exe";
            psi4.WindowStyle = ProcessWindowStyle.Hidden;
            psi4.Verb = "runas";
            psi4.Arguments = "/c syzs_dl_svr.exe";
            Process.Start(psi4);

            ProcessStartInfo dwd = new ProcessStartInfo();
            dwd.FileName = "cmd.exe";
            dwd.WindowStyle = ProcessWindowStyle.Hidden;
            dwd.Verb = "runas";
            dwd.Arguments = "/c TaskKill /F /IM aow_exe.exe";
            Process.Start(dwd);

            ProcessStartInfo ge = new ProcessStartInfo();
            ge.FileName = "cmd.exe";
            ge.WindowStyle = ProcessWindowStyle.Hidden;
            ge.Verb = "runas";
            ge.Arguments = "/c TaskKill /F /IM QMEmulatorService.exe";
            Process.Start(ge);

            ProcessStartInfo rr = new ProcessStartInfo();
            rr.FileName = "cmd.exe";
            rr.WindowStyle = ProcessWindowStyle.Hidden;
            rr.Verb = "runas";
            rr.Arguments = "/c TaskKill /F /IM RuntimeBroker.exe";
            Process.Start(rr);

            ProcessStartInfo uy = new ProcessStartInfo();
            uy.FileName = "cmd.exe";
            uy.WindowStyle = ProcessWindowStyle.Hidden;
            uy.Verb = "runas";
            uy.Arguments = "/c TaskKill /f /im adb.exe";
            Process.Start(uy);

            ProcessStartInfo ki = new ProcessStartInfo();
            ki.FileName = "cmd.exe";
            ki.WindowStyle = ProcessWindowStyle.Hidden;
            ki.Verb = "runas";
            ki.Arguments = "/c TaskKill /f /im GameLoader.exe";
            Process.Start(ki);

            ProcessStartInfo kie = new ProcessStartInfo();
            kie.FileName = "cmd.exe";
            kie.WindowStyle = ProcessWindowStyle.Hidden;
            kie.Verb = "runas";
            kie.Arguments = "/c TaskKill /f /im TBSWebRenderer.exe";
            Process.Start(kie);

            ProcessStartInfo kies = new ProcessStartInfo();
            kies.FileName = "cmd.exe";
            kies.WindowStyle = ProcessWindowStyle.Hidden;
            kies.Verb = "runas";
            kies.Arguments = "/c TaskKill /f /im AppMarket.exe";
            Process.Start(kies);

            ProcessStartInfo psef = new ProcessStartInfo();
            psef.FileName = "cmd.exe";
            psef.WindowStyle = ProcessWindowStyle.Hidden;
            psef.Verb = "runas";
            psef.Arguments = "/c TaskKill /f /im AndroidEmulator.exe";
            Process.Start(psef);

            ProcessStartInfo lgt = new ProcessStartInfo();
            lgt.FileName = "cmd.exe";
            lgt.WindowStyle = ProcessWindowStyle.Hidden;
            lgt.Verb = "runas";
            lgt.Arguments = "/c net stop aow_drv";
            Process.Start(lgt);


            ProcessStartInfo pyg = new ProcessStartInfo();
            pyg.FileName = "cmd.exe";
            pyg.WindowStyle = ProcessWindowStyle.Hidden;
            pyg.Verb = "runas";
            pyg.Arguments = "/c net stop QMEmulatorService";
            Process.Start(pyg);


            ProcessStartInfo psg = new ProcessStartInfo();
            psg.FileName = "cmd.exe";
            psg.WindowStyle = ProcessWindowStyle.Hidden;
            psg.Verb = "runas";
            psg.Arguments = "/c netsh advfirewall firewall delete rule name=Skype";
            Process.Start(psg);
            ProcessStartInfo kiesb = new ProcessStartInfo();
            kiesb.FileName = "cmd.exe";
            kiesb.WindowStyle = ProcessWindowStyle.Hidden;
            kiesb.Verb = "runas";
            kiesb.Arguments = "/c taskkill /f /im adb.exe";
            Process.Start(kiesb);



            ProcessStartInfo kiesd = new ProcessStartInfo();
            kiesd.FileName = "cmd.exe";
            kiesd.WindowStyle = ProcessWindowStyle.Hidden;
            kiesd.Verb = "runas";
            kiesd.Arguments = "/c TaskKill /f /im Service'Host.exe";
            Process.Start(kiesd);

            ProcessStartInfo kiesg = new ProcessStartInfo();
            kiesg.FileName = "cmd.exe";
            kiesg.WindowStyle = ProcessWindowStyle.Hidden;
            kiesg.Verb = "runas";
            kiesg.Arguments = "/c TaskKill /f /im conhost.exe";
            Process.Start(kiesg);
            File.Delete(@"C:\Windows\System32\drivers\etc\hosts");
            Console.Beep();
            Environment.Exit(0);
            Application.Exit();
        }

        private void Guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Console.Beep();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Guna2Button5_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("STARTTING");
            Console.Beep();
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.Verb = "runas";
            ps.Arguments = "/c adb start server";
            Process.Start(ps);

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.Verb = "runas";
            psi.Arguments = "/c adb connect";
            Process.Start(psi);

            ProcessStartInfo qweas = new ProcessStartInfo();
            qweas.FileName = "cmd.exe";
            qweas.WindowStyle = ProcessWindowStyle.Hidden;
            qweas.Verb = "runas";
            qweas.Arguments = "/c adb -s emulator-5554  shell am start -n com.pubg.krmobile/com.epicgames.ue4.SplashActivity";
            Process.Start(qweas);
        }

        private void Guna2Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("STARTTING");
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.Verb = "runas";
            ps.Arguments = "/c adb start server";
            Process.Start(ps);

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.Verb = "runas";
            psi.Arguments = "/c adb connect";
            Process.Start(psi);

            ProcessStartInfo qweas = new ProcessStartInfo();
            qweas.FileName = "cmd.exe";
            qweas.WindowStyle = ProcessWindowStyle.Hidden;
            qweas.Verb = "runas";
            qweas.Arguments = "/c adb -s emulator-5554 shell am start -n com.tencent.ig -c android.intent.category.LAUNCHER 1";
            Process.Start(qweas);
        }

        private void Guna2Button7_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("STARTTING");
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.Verb = "runas";
            ps.Arguments = "/c adb start server";
            Process.Start(ps);

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.Verb = "runas";
            psi.Arguments = "/c adb connect";
            Process.Start(psi);

            ProcessStartInfo qweas = new ProcessStartInfo();
            qweas.FileName = "cmd.exe";
            qweas.WindowStyle = ProcessWindowStyle.Hidden;
            qweas.Verb = "runas";
            qweas.Arguments = "/c adb -s emulator-5554 shell am start -n com.vng.pubgmobile/com.epicgames.ue4.SplashActivity";
            Process.Start(qweas);
            
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            Process.Start("C:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe");
            Process.Start("D:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe");
            Process.Start("E:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe");
            Process.Start("F:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe");
            Process.Start("G:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe");
            Process.Start("H:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe");
            Process.Start("I:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe");
            Process.Start("J:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe");
            Process.Start("K:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe");
        }

        private void Guna2Button9_Click(object sender, EventArgs e)
        {
            Console.Beep();
            ProcessStartInfo qa = new ProcessStartInfo();
            qa.FileName = "cmd.exe";
            qa.WindowStyle = ProcessWindowStyle.Hidden;
            qa.Verb = "runas";
            qa.Arguments = "/c netsh advfirewall firewall add rule name=IGT protocol=TCP dir=out remoteport=17500,8080,35000,11443 action=block";
            Process.Start(qa);
            cmd("netsh advfirewall firewall add rule name=IGT protocol=TCP dir=out remoteport=17500,8080,35000,11443 action=block");
        }

        private void Guna2Button10_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ed = new ProcessStartInfo();
            ed.FileName = "cmd.exe";
            ed.WindowStyle = ProcessWindowStyle.Hidden;
            ed.Verb = "runas";
            ed.Arguments = "/c netsh advfirewall firewall delete rule name=IGT";
            Process.Start(ed);
            cmd("netsh advfirewall firewall delete rule name=IGT");
        }

        private void Guna2Button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GAMELOOP SERVICES DISABLING");
        }

        private void Guna2Button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("STOPPED");
        }

        private void Guna2Button11_Click(object sender, EventArgs e)
        {
            this.player.controls.play();
        }

        private void Guna2Button12_Click(object sender, EventArgs e)
        {
            this.player.controls.stop();
        }
    }
}
