Imports System
Imports System.Drawing
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports Microsoft.Win32
Imports System.Diagnostics

Namespace AntibanNewDesign
    Public Partial Class Login
        Inherits Form
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
        End Sub

        Private Sub panel1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
            'ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.FromArgb(12,17,25), ButtonBorderStyle.Solid);
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            'label2.Hide();
            Try
                Dim key = Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\WOW6432Node\LTANM404", True)
                Dim keysav = key.GetValue("data")
                textBox1.Text = keysav.ToString()
                Dim x = textBox1.Text.Length
                textBox1.SelectionStart = x
            Catch
                textBox1.SelectionStart = 0
            End Try

            textBox1.AutoSize = False
            textBox1.Size = New Size(268, 30)
            button1.TabStop = False
            button1.FlatStyle = FlatStyle.Flat
            button1.FlatAppearance.BorderSize = 0
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)
            client = New FireSharp.FirebaseClient(config)
        End Sub

        Private Sub label3_Click(ByVal sender As Object, ByVal e As EventArgs)
            Environment.Exit(0)
        End Sub

        Private Sub label4_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
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
        Private Sub pictureBox1_MouseDown_1(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                Call ReleaseCapture()
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
            End If
        End Sub
        Private Async Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim key = Registry.LocalMachine.CreateSubKey("SOFTWARE\WOW6432Node\WOW6432Node\LTANM404", True)
            key.SetValue("data", textBox1.Text.ToString())
            'try
            '{
            Dim response = Await client.GetTaskAsync("KeyInfo/" & textBox1.Text)
            Dim result As Data = response.ResultAs(Of Data)()
            Dim banstr As String = result.banned.ToString()
            Dim timestr As String = result.time.ToString()
            Dim usernamestr As String = result.username.ToString()
            Dim activestr As String = result.active.ToString()
            If Equals(banstr, "yes") Then
                MessageBox.Show("You will be banned for violating regulations. Contact administrator to unban key.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Equals(activestr, "yes") Then
                    If Equals(timestr, "life") Then
                        Hide()
                        Call New Main().Show()
                    Else
                        MessageBox.Show("Key suspended. That was a one time entry key." & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "You can ask admin for more test keys :)", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Await client.DeleteTaskAsync("KeyInfo/" & textBox1.Text)
                    End If
                Else
                    Hide()
                    Call New Main().Show()
                End If

            End If

            '}
            ' catch
            ' {
            ' MessageBox.Show("Network error or key does not exists", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ' }


        End Sub

        Private Sub label1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Process.Start("https://discord.gg/QqCgWqx")
        End Sub

        Private Async Sub label2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Process.Start("https://www.youtube.com/channel/UCJ-JWN4VYTtg1OwbyHwNxHg")
            Await Task.Delay(100)
            Process.Start("https://www.youtube.com/channel/UC2tk0_N2DzJQ_zCYXjFgJfw")


        End Sub
    End Class
End Namespace
