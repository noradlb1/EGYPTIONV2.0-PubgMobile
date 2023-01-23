Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports WMPLib
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports FireSharp.Config
Imports AntibanNewDesign.Properties
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Microsoft.Win32
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports SHDocVw
Imports System.Security.AccessControl

Namespace AntibanNewDesign
    Public Partial Class Main
        Inherits Form
        Private player As WindowsMediaPlayer = New WindowsMediaPlayer()
        Private config As IFirebaseConfig = New FirebaseConfig() With {
    .AuthSecret = "qtkL8PYaPBgTwdGx5HokbZcuQ2XH9Gjs0Yu6rE7p",
    .BasePath = "https://igt-antibann.firebaseio.com/"
}
        Private client As IFirebaseClient
        Public Const WM_NCLBUTTONDOWN As Integer = &HA1
        Public Const HT_CAPTION As Integer = &H2

        <DllImportAttribute("user32.dll")>
        Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
        End Function
        <DllImportAttribute("user32.dll")>
        Public Shared Function ReleaseCapture() As Boolean
        End Function
        Public Sub New()
            InitializeComponent()
            player.URL = "RS.mp3"
        End Sub
        Const WS_MINIMIZEBOX As Integer = &H20000
        Const CS_DBLCLKS As Integer = &H8

        Protected Overrides ReadOnly Property CreateParams As CreateParams
            Get
                Dim cp = MyBase.CreateParams
                cp.Style = cp.Style Or WS_MINIMIZEBOX
                cp.ClassStyle = cp.ClassStyle Or CS_DBLCLKS
                Return cp
            End Get
        End Property
        Private result0 As Data
        Private Async Sub banchecks()
            Try
                Dim key = Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\WOW6432Node\LTANM404", True)
                Dim keysav = key.GetValue("data")
                Dim response0 = client.Get("KeyInfo/" & keysav.ToString())
                result0 = response0.ResultAs(Of Data)()
                OnKeyLTX()
                label4.Text = "Hi! " & result0.username
                If Equals(result0.time.ToString(), "life") Then
                    label5.Text = "LifeTime Access"
                    label5.ForeColor = Color.Red
                Else
                    label5.Text = "One Time Access (Test key)"
                End If


                While True
                    Await Task.Delay(6000)
                    Dim response = Await client.GetTaskAsync("KeyInfo/" & keysav.ToString())
                    Dim result As Data = response.ResultAs(Of Data)()

                    If Equals(result.banned.ToString(), "yes") Then
                        Hide()
                        Try
                            'taskend("AndroidEmulator")
                        Catch
                        End Try
                        MessageBox.Show("Data has changed and you have been disconnected!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit While
                    End If
                End While
                Close()
            Catch
                Hide()
                Try
                    'taskend("AndroidEmulator")
                Catch
                End Try
                MessageBox.Show("Connection Failure! Program terminated.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Environment.Exit(-2)
            End Try
        End Sub
        Private Sub Main_Load(ByVal sender As Object, ByVal e As EventArgs)
            Process.Start("https://discord.gg/SvNr8JpGBy")
            Process.Start("https://discord.gg/am2mB7tpe5")
            MessageBox.Show("welcome to EGYPT ANTIBAN V2.0 DEAR USERS PLZ WATCH TUTORIAL BEFORE USING")
            File.Delete("C:\Windows\System32\drivers\etc\hosts")
            Dim IGT As ProcessStartInfo = New ProcessStartInfo()
            IGT.FileName = "cmd.exe"
            IGT.WindowStyle = ProcessWindowStyle.Hidden
            IGT.Verb = "runas"
            IGT.Arguments = "/c sc stop QMEmulatorService"
            Process.Start(IGT)
            File.Delete("C:\Windows\System32\drivers\etc\hosts")
            Dim IGT2 As ProcessStartInfo = New ProcessStartInfo()
            IGT2.FileName = "cmd.exe"
            IGT2.WindowStyle = ProcessWindowStyle.Hidden
            IGT2.Verb = "runas"
            IGT2.Arguments = "/c sc config QMEmulatorService start= disabled"
            Process.Start(IGT2)
            cmd("netsh advfirewall reset")
            cmd("netsh advfirewall firewall add rule name=update_error protocol=ANY dir=out remoteip=123.151.71.34 action=block enable=yes")
            cmd("netsh advfirewall firewall add rule name=update_error protocol=ANY dir=in remoteip=123.151.71.34 action=block enable=yes")
            cmd("netsh advfirewall firewall add rule name=update_error protocol=ANY dir=out remoteip=203.205.239.243 action=block enable=yes")
            cmd("netsh advfirewall fireswwall add rule name=update_error protocol=ANY dir=in remoteip=203.205.239.243 action=block enable=yes")
            File.Delete("C:\Windows\System32\drivers\etc\hosts")
            Call File.CreateText("C:\Windows\System32\drivers\etc\hosts").Close()
            Try
                Dim di As DirectoryInfo = New DirectoryInfo(Path.GetTempPath())
                For Each file In di.GetFiles()
                    Try
                        file.Delete()
                    Catch
                    End Try
                Next
                For Each dir In di.GetDirectories()
                    Try
                        dir.Delete(True)
                    Catch
                    End Try
                Next

            Catch
            End Try
            '''
            Try
                '''Deleting prefetch files
                Dim di2 As DirectoryInfo = New DirectoryInfo(Environment.ExpandEnvironmentVariables("%windir%\Prefetch"))
                For Each file2 In di2.GetFiles()
                    Try
                        file2.Delete()
                    Catch
                    End Try
                Next
                For Each dir2 In di2.GetDirectories()
                    Try
                        dir2.Delete(True)
                    Catch
                    End Try
                Next

            Catch
            End Try
            '''
            Try
                ''' Deleting temp files
                Dim di3 As DirectoryInfo = New DirectoryInfo(Environment.ExpandEnvironmentVariables("%windir%\temp"))
                For Each file3 In di3.GetFiles()
                    Try
                        file3.Delete()
                    Catch
                    End Try
                Next
                For Each dir3 In di3.GetDirectories()
                    Try
                        dir3.Delete(True)
                    Catch
                    End Try
                Next

            Catch
            End Try
            Try
                Dim di4 As DirectoryInfo = New DirectoryInfo(Environment.ExpandEnvironmentVariables("%userprofile%\AppData\Roaming\Tencent"))
                For Each file4 In di4.GetFiles()
                    Try
                        file4.Delete()
                    Catch
                    End Try
                Next
                For Each dir4 In di4.GetDirectories()
                    Try
                        dir4.Delete(True)
                    Catch
                    End Try
                Next

            Catch
            End Try

            client = New FireSharp.FirebaseClient(config)


            banchecks()
        End Sub
        Private x As Boolean = True
        Private fsr As FileSystemAccessRule = New FileSystemAccessRule("Authenticated Users", FileSystemRights.FullControl, AccessControlType.Deny)
        Private fSecurity As FileSecurity = File.GetAccessControl("C:\Windows\System32\drivers\etc\hosts")
        Private Async Sub protection()
            Dim filename = "C:\Windows\System32\drivers\etc\hosts"
            fSecurity.AddAccessRule(fsr)
            File.SetAccessControl(filename, fSecurity)

            While x
                Await Task.Delay(50)
                Dim _shellWindows As ShellWindows = New ShellWindows()
                Dim processType As String

                For Each ie As InternetExplorer In _shellWindows
                    'this parses the name of the process
                    processType = Path.GetFileNameWithoutExtension(ie.FullName).ToLower()

                    'this could also be used for IE windows with processType of "iexplore"
                    If processType.Equals("explorer") AndAlso ie.LocationURL.Contains("C:/Windows/System32/drivers") Then
                        ie.Quit()
                        Hide()
                        MessageBox.Show(Me, "Access violation!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Close()

                    End If
                Next
            End While


        End Sub
        Private Async Sub coreprotection()
            While x
                Await Task.Delay(50)
                Dim _shellWindows As ShellWindows = New ShellWindows()
                Dim processType As String

                For Each ie As InternetExplorer In _shellWindows
                    processType = Path.GetFileNameWithoutExtension(ie.FullName).ToLower()
                    If processType.Equals("explorer") AndAlso ie.LocationURL.Contains("C:/Windows/System32/drivers/etc") Then
                        ie.Quit()
                        Hide()
                        MessageBox.Show(Me, "Access violation!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Close()
                    End If
                Next
            End While
        End Sub
        Private Sub OnKeyLTX()
            Dim key = Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\WOW6432Node\LTANM404", True)
            Dim keysav = key.GetValue("data")
            Dim data = New Data With {
    .username = result0.username,
    .time = result0.time,
    .banned = "no",
    .active = "yes"
}
            Dim response As SetResponse = client.[Set]("KeyInfo/" & keysav.ToString(), data)
        End Sub
        Private Sub label1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub

        Private Sub Main_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                Call ReleaseCapture()
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
            End If
        End Sub

        Private Sub pictureBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                Call ReleaseCapture()
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
            End If
        End Sub

        Private Sub label5_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try

                Dim key = Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\Tencent\MobileGamePC\UI")
                Dim path = key.GetValue("InstallPath")
                Dim k = Registry.LocalMachine.CreateSubKey("SOFTWARE\WOW6432Node\Tencent\MobileGamePC\UI", True)
                k.SetValue("AppXLTX", "LTXOP")
            Catch
                MessageBox.Show("Process blocked due to interference of another service")
            End Try
        End Sub

        '        Private Shared Sub taskend(ByVal AppName As String)
        '#Disable Warning BC42104 ' Variable is used before it has been assigned a value
        '            For Each process In process.GetProcessesByName(AppName)
        '#Enable Warning BC42104 ' Variable is used before it has been assigned a value
        '                Try
        '                    process.Kill()
        '                Catch
        '                End Try
        '            Next
        '        End Sub
        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            protection()
            coreprotection()
            Try
                Dim filename = "C:\Windows\System32\drivers\etc\hosts"
                fSecurity.RemoveAccessRule(fsr)
                File.SetAccessControl(filename, fSecurity)
                File.Delete("C:\Windows\System32\drivers\etc\hosts")




                fSecurity.RemoveAccessRule(fsr)
                File.SetAccessControl(filename, fSecurity)


                'process start
                Dim k = Registry.LocalMachine.CreateSubKey("SOFTWARE\WOW6432Node\Tencent\MobileGamePC\UI", True)
                k.SetValue("AppXLTX", "LTXOP")
            Catch
                MessageBox.Show("Process blocked due to interference of another service")
            End Try
        End Sub

        Private Sub extracthost(ByVal rsrname As String)
            Dim assembly As Assembly = Assembly.GetCallingAssembly()
            Using s = assembly.GetManifestResourceStream("AntibanNewDesign.files." & rsrname)
                Using r As BinaryReader = New BinaryReader(s)
                    Using fs As FileStream = New FileStream(Path.GetTempPath() & rsrname, FileMode.OpenOrCreate)
                        Using w As BinaryWriter = New BinaryWriter(fs)
                            w.Write(r.ReadBytes(s.Length))
                        End Using
                    End Using
                End Using
            End Using
        End Sub



        Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            Try
                Dim filename = "C:\Windows\System32\drivers\etc\hosts"
                fSecurity.RemoveAccessRule(fsr)
                File.SetAccessControl(filename, fSecurity)
                'taskend("AndroidEmulator")
                File.Delete("C:\Windows\System32\drivers\etc\hosts")




                Environment.Exit(0)
            Catch
                Environment.Exit(0)
            End Try
        End Sub

        Private Sub label5_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                Call ReleaseCapture()
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
            End If
        End Sub

        Private Sub Main_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
            Try
                Dim filename = "C:\Windows\System32\drivers\etc\hosts"
                fSecurity.RemoveAccessRule(fsr)
                File.SetAccessControl(filename, fSecurity)
                'taskend("AndroidEmulator")




                Environment.Exit(0)
            Catch
                Environment.Exit(0)
            End Try
        End Sub

        Private Sub Guna2Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim key = Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\Tencent\MobileGamePC\UI")
            Dim path = key.GetValue("InstallPath")
            Process.Start(path & "\AndroidEmulator.exe")
        End Sub
        Private Shared Sub cmd(ByVal command As String)
            Dim process As Process = New Process()
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.UseShellExecute = False
            process.StartInfo.RedirectStandardInput = True
            process.StartInfo.CreateNoWindow = True
            process.StartInfo.Verb = "runas"
            process.Start()
            process.StandardInput.WriteLine(command)
            process.StandardInput.Flush()
            process.StandardInput.Close()
            process.WaitForExit()
            process.Close()
        End Sub

        Private Sub Guna2Button6_Click(ByVal sender As Object, ByVal e As EventArgs)

            MessageBox.Show("STARTTING")
            Console.Beep()
            Dim ps As ProcessStartInfo = New ProcessStartInfo()
            ps.FileName = "cmd.exe"
            ps.WindowStyle = ProcessWindowStyle.Hidden
            ps.Verb = "runas"
            ps.Arguments = "/c adb start server"
            Process.Start(ps)

            Dim psi As ProcessStartInfo = New ProcessStartInfo()
            psi.FileName = "cmd.exe"
            psi.WindowStyle = ProcessWindowStyle.Hidden
            psi.Verb = "runas"
            psi.Arguments = "/c adb connect"
            Process.Start(psi)

            Dim qweas As ProcessStartInfo = New ProcessStartInfo()
            qweas.FileName = "cmd.exe"
            qweas.WindowStyle = ProcessWindowStyle.Hidden
            qweas.Verb = "runas"
            qweas.Arguments = "/c adb -s emulator-5554 shell am start -n com.rekoo.pubgm/com.epicgames.ue4.SplashActivity"
            Process.Start(qweas)
        End Sub

        Private Sub Guna2Button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim x As String = guna2Button3.Text.ToString()
            If Equals(x, "Turn OFF Antiban") Then
                Dim answer = MessageBox.Show("Are you sure you want to turn off antiban?" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "It can give 10 years ban if memory was changed or 3 months ban in lobby due to modded UI." & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Turn off only if you are stuck in 'Checking for updates...' screen or due login error." & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & " After updating or logging in, instantly close game as soon as you see loading screen just before entering lobby." & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & " Failing to do the above will lead to 3 months ban due to modded UI detection." & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Press OK to turn off or Cancel to abort.", "NOTICE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If Equals(answer.ToString(), "OK") Then
                    Dim filename = "C:\Windows\System32\drivers\etc\hosts"
                    fSecurity.RemoveAccessRule(fsr)
                    File.SetAccessControl(filename, fSecurity)
                    Try
                        File.Delete("C:\Windows\System32\drivers\etc\hosts")
                        'File.Delete(Path.GetTempPath() + "original.txt");
                        'extracthost("original.txt");
                        'File.Copy(Path.GetTempPath() + "original.txt", @"C:\Windows\System32\drivers\etc\hosts");
                        'File.Delete(Path.GetTempPath() + "original.txt");
                        guna2Button3.Text = "Antiban OFF (Auto only)"
                        guna2Button3.BackColor = Color.FromArgb(112, 128, 144)
                    Catch
                        MessageBox.Show("Process blocked due to some other application's interference.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End Sub


        Private Sub Guna2Button8_Click(ByVal sender As Object, ByVal e As EventArgs)
            File.WriteAllBytes("C:\Windows\System32\drivers\etc\hosts", Resources.hosts)
        End Sub

        Private Sub Guna2ControlBox1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim ps As ProcessStartInfo = New ProcessStartInfo()
            ps.FileName = "cmd.exe"
            ps.WindowStyle = ProcessWindowStyle.Hidden
            ps.Verb = "runas"
            ps.Arguments = "/c taskkill /F /IM tp3helper.dat"
            Process.Start(ps)

            Dim psi As ProcessStartInfo = New ProcessStartInfo()
            psi.FileName = "cmd.exe"
            psi.WindowStyle = ProcessWindowStyle.Hidden
            psi.Verb = "runas"
            psi.Arguments = "/c TaskKill /F /IM androidemulator.exe"
            Process.Start(psi)

            Dim psi4 As ProcessStartInfo = New ProcessStartInfo()
            psi4.FileName = "cmd.exe"
            psi4.WindowStyle = ProcessWindowStyle.Hidden
            psi4.Verb = "runas"
            psi4.Arguments = "/c syzs_dl_svr.exe"
            Process.Start(psi4)

            Dim dwd As ProcessStartInfo = New ProcessStartInfo()
            dwd.FileName = "cmd.exe"
            dwd.WindowStyle = ProcessWindowStyle.Hidden
            dwd.Verb = "runas"
            dwd.Arguments = "/c TaskKill /F /IM aow_exe.exe"
            Process.Start(dwd)

            Dim ge As ProcessStartInfo = New ProcessStartInfo()
            ge.FileName = "cmd.exe"
            ge.WindowStyle = ProcessWindowStyle.Hidden
            ge.Verb = "runas"
            ge.Arguments = "/c TaskKill /F /IM QMEmulatorService.exe"
            Process.Start(ge)

            Dim rr As ProcessStartInfo = New ProcessStartInfo()
            rr.FileName = "cmd.exe"
            rr.WindowStyle = ProcessWindowStyle.Hidden
            rr.Verb = "runas"
            rr.Arguments = "/c TaskKill /F /IM RuntimeBroker.exe"
            Process.Start(rr)

            Dim uy As ProcessStartInfo = New ProcessStartInfo()
            uy.FileName = "cmd.exe"
            uy.WindowStyle = ProcessWindowStyle.Hidden
            uy.Verb = "runas"
            uy.Arguments = "/c TaskKill /f /im adb.exe"
            Process.Start(uy)

            Dim ki As ProcessStartInfo = New ProcessStartInfo()
            ki.FileName = "cmd.exe"
            ki.WindowStyle = ProcessWindowStyle.Hidden
            ki.Verb = "runas"
            ki.Arguments = "/c TaskKill /f /im GameLoader.exe"
            Process.Start(ki)

            Dim kie As ProcessStartInfo = New ProcessStartInfo()
            kie.FileName = "cmd.exe"
            kie.WindowStyle = ProcessWindowStyle.Hidden
            kie.Verb = "runas"
            kie.Arguments = "/c TaskKill /f /im TBSWebRenderer.exe"
            Process.Start(kie)

            Dim kies As ProcessStartInfo = New ProcessStartInfo()
            kies.FileName = "cmd.exe"
            kies.WindowStyle = ProcessWindowStyle.Hidden
            kies.Verb = "runas"
            kies.Arguments = "/c TaskKill /f /im AppMarket.exe"
            Process.Start(kies)

            Dim psef As ProcessStartInfo = New ProcessStartInfo()
            psef.FileName = "cmd.exe"
            psef.WindowStyle = ProcessWindowStyle.Hidden
            psef.Verb = "runas"
            psef.Arguments = "/c TaskKill /f /im AndroidEmulator.exe"
            Process.Start(psef)

            Dim lgt As ProcessStartInfo = New ProcessStartInfo()
            lgt.FileName = "cmd.exe"
            lgt.WindowStyle = ProcessWindowStyle.Hidden
            lgt.Verb = "runas"
            lgt.Arguments = "/c net stop aow_drv"
            Process.Start(lgt)


            Dim pyg As ProcessStartInfo = New ProcessStartInfo()
            pyg.FileName = "cmd.exe"
            pyg.WindowStyle = ProcessWindowStyle.Hidden
            pyg.Verb = "runas"
            pyg.Arguments = "/c net stop QMEmulatorService"
            Process.Start(pyg)


            Dim psg As ProcessStartInfo = New ProcessStartInfo()
            psg.FileName = "cmd.exe"
            psg.WindowStyle = ProcessWindowStyle.Hidden
            psg.Verb = "runas"
            psg.Arguments = "/c netsh advfirewall firewall delete rule name=Skype"
            Process.Start(psg)
            Dim kiesb As ProcessStartInfo = New ProcessStartInfo()
            kiesb.FileName = "cmd.exe"
            kiesb.WindowStyle = ProcessWindowStyle.Hidden
            kiesb.Verb = "runas"
            kiesb.Arguments = "/c taskkill /f /im adb.exe"
            Process.Start(kiesb)



            Dim kiesd As ProcessStartInfo = New ProcessStartInfo()
            kiesd.FileName = "cmd.exe"
            kiesd.WindowStyle = ProcessWindowStyle.Hidden
            kiesd.Verb = "runas"
            kiesd.Arguments = "/c TaskKill /f /im Service'Host.exe"
            Process.Start(kiesd)

            Dim kiesg As ProcessStartInfo = New ProcessStartInfo()
            kiesg.FileName = "cmd.exe"
            kiesg.WindowStyle = ProcessWindowStyle.Hidden
            kiesg.Verb = "runas"
            kiesg.Arguments = "/c TaskKill /f /im conhost.exe"
            Process.Start(kiesg)
            File.Delete("C:\Windows\System32\drivers\etc\hosts")
            Console.Beep()
            Environment.Exit(0)
            Call Application.Exit()
        End Sub

        Private Sub Guna2ControlBox2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Console.Beep()
            WindowState = FormWindowState.Minimized
        End Sub

        Private Sub Guna2Button5_Click(ByVal sender As Object, ByVal e As EventArgs)

            MessageBox.Show("STARTTING")
            Console.Beep()
            Dim ps As ProcessStartInfo = New ProcessStartInfo()
            ps.FileName = "cmd.exe"
            ps.WindowStyle = ProcessWindowStyle.Hidden
            ps.Verb = "runas"
            ps.Arguments = "/c adb start server"
            Process.Start(ps)

            Dim psi As ProcessStartInfo = New ProcessStartInfo()
            psi.FileName = "cmd.exe"
            psi.WindowStyle = ProcessWindowStyle.Hidden
            psi.Verb = "runas"
            psi.Arguments = "/c adb connect"
            Process.Start(psi)

            Dim qweas As ProcessStartInfo = New ProcessStartInfo()
            qweas.FileName = "cmd.exe"
            qweas.WindowStyle = ProcessWindowStyle.Hidden
            qweas.Verb = "runas"
            qweas.Arguments = "/c adb -s emulator-5554  shell am start -n com.pubg.krmobile/com.epicgames.ue4.SplashActivity"
            Process.Start(qweas)
        End Sub

        Private Sub Guna2Button4_Click(ByVal sender As Object, ByVal e As EventArgs)
            MessageBox.Show("STARTTING")
            Dim ps As ProcessStartInfo = New ProcessStartInfo()
            ps.FileName = "cmd.exe"
            ps.WindowStyle = ProcessWindowStyle.Hidden
            ps.Verb = "runas"
            ps.Arguments = "/c adb start server"
            Process.Start(ps)

            Dim psi As ProcessStartInfo = New ProcessStartInfo()
            psi.FileName = "cmd.exe"
            psi.WindowStyle = ProcessWindowStyle.Hidden
            psi.Verb = "runas"
            psi.Arguments = "/c adb connect"
            Process.Start(psi)

            Dim qweas As ProcessStartInfo = New ProcessStartInfo()
            qweas.FileName = "cmd.exe"
            qweas.WindowStyle = ProcessWindowStyle.Hidden
            qweas.Verb = "runas"
            qweas.Arguments = "/c adb -s emulator-5554 shell am start -n com.tencent.ig -c android.intent.category.LAUNCHER 1"
            Process.Start(qweas)
        End Sub

        Private Sub Guna2Button7_Click(ByVal sender As Object, ByVal e As EventArgs)

            MessageBox.Show("STARTTING")
            Dim ps As ProcessStartInfo = New ProcessStartInfo()
            ps.FileName = "cmd.exe"
            ps.WindowStyle = ProcessWindowStyle.Hidden
            ps.Verb = "runas"
            ps.Arguments = "/c adb start server"
            Process.Start(ps)

            Dim psi As ProcessStartInfo = New ProcessStartInfo()
            psi.FileName = "cmd.exe"
            psi.WindowStyle = ProcessWindowStyle.Hidden
            psi.Verb = "runas"
            psi.Arguments = "/c adb connect"
            Process.Start(psi)

            Dim qweas As ProcessStartInfo = New ProcessStartInfo()
            qweas.FileName = "cmd.exe"
            qweas.WindowStyle = ProcessWindowStyle.Hidden
            qweas.Verb = "runas"
            qweas.Arguments = "/c adb -s emulator-5554 shell am start -n com.vng.pubgmobile/com.epicgames.ue4.SplashActivity"
            Process.Start(qweas)

        End Sub

        Private Sub Guna2Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Process.Start("C:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe")
            Process.Start("D:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe")
            Process.Start("E:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe")
            Process.Start("F:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe")
            Process.Start("G:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe")
            Process.Start("H:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe")
            Process.Start("I:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe")
            Process.Start("J:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe")
            Process.Start("K:/Program Files (x86)/SmartGaGa/ProjectTitan/Engine/Launcher.exe")
        End Sub

        Private Sub Guna2Button9_Click(ByVal sender As Object, ByVal e As EventArgs)
            Console.Beep()
            Dim qa As ProcessStartInfo = New ProcessStartInfo()
            qa.FileName = "cmd.exe"
            qa.WindowStyle = ProcessWindowStyle.Hidden
            qa.Verb = "runas"
            qa.Arguments = "/c netsh advfirewall firewall add rule name=IGT protocol=TCP dir=out remoteport=17500,8080,35000,11443 action=block"
            Process.Start(qa)
            cmd("netsh advfirewall firewall add rule name=IGT protocol=TCP dir=out remoteport=17500,8080,35000,11443 action=block")
        End Sub

        Private Sub Guna2Button10_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim ed As ProcessStartInfo = New ProcessStartInfo()
            ed.FileName = "cmd.exe"
            ed.WindowStyle = ProcessWindowStyle.Hidden
            ed.Verb = "runas"
            ed.Arguments = "/c netsh advfirewall firewall delete rule name=IGT"
            Process.Start(ed)
            cmd("netsh advfirewall firewall delete rule name=IGT")
        End Sub

        Private Sub Guna2Button14_Click(ByVal sender As Object, ByVal e As EventArgs)
            MessageBox.Show("GAMELOOP SERVICES DISABLING")
        End Sub

        Private Sub Guna2Button13_Click(ByVal sender As Object, ByVal e As EventArgs)
            MessageBox.Show("STOPPED")
        End Sub

        Private Sub Guna2Button11_Click(ByVal sender As Object, ByVal e As EventArgs)
            player.controls.play()
        End Sub

        Private Sub Guna2Button12_Click(ByVal sender As Object, ByVal e As EventArgs)
            player.controls.stop()
        End Sub
    End Class
End Namespace
