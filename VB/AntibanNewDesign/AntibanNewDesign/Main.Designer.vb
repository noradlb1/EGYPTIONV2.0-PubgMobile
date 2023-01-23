Imports System

Namespace AntibanNewDesign
    Partial Class Main
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Main))
            label4 = New Windows.Forms.Label()
            label5 = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button7 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button8 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button9 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button10 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button11 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button12 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button13 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button14 = New Guna.UI2.WinForms.Guna2Button()
            guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
            guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
            guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
            label1 = New Windows.Forms.Label()
            CType(guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.BackColor = Drawing.Color.FromArgb(0, 0, 0, 0)
            label4.Font = New Drawing.Font("Microsoft Sans Serif", 10.0F)
            label4.ForeColor = Drawing.Color.White
            label4.Location = New Drawing.Point(321, 9)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(132, 17)
            label4.TabIndex = 13
            label4.Text = "RETRIEVING DATA"
            AddHandler label4.MouseDown, New Windows.Forms.MouseEventHandler(AddressOf label5_MouseDown)
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.BackColor = Drawing.Color.FromArgb(0, 0, 0, 0)
            label5.Font = New Drawing.Font("Microsoft Sans Serif", 10.0F)
            label5.ForeColor = Drawing.Color.Red
            label5.Location = New Drawing.Point(658, 20)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(132, 17)
            label5.TabIndex = 14
            label5.Text = "RETRIEVING DATA"
            AddHandler label5.Click, New EventHandler(AddressOf label5_Click)
            AddHandler label5.MouseDown, New Windows.Forms.MouseEventHandler(AddressOf label5_MouseDown)
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.BackColor = Drawing.Color.FromArgb(0, 0, 0, 0)
            label2.Font = New Drawing.Font("Microsoft Sans Serif", 10.0F)
            label2.ForeColor = Drawing.Color.White
            label2.Location = New Drawing.Point(783, 20)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(0, 17)
            label2.TabIndex = 15
            AddHandler label2.MouseDown, New Windows.Forms.MouseEventHandler(AddressOf label5_MouseDown)
            ' 
            ' guna2Button1
            ' 
            guna2Button1.BackColor = Drawing.Color.Transparent
            guna2Button1.CheckedState.Parent = guna2Button1
            guna2Button1.CustomImages.Parent = guna2Button1
            guna2Button1.FillColor = Drawing.Color.Transparent
            guna2Button1.Font = New Drawing.Font("Segoe UI", 9.0F)
            guna2Button1.ForeColor = Drawing.Color.White
            guna2Button1.HoverState.Parent = guna2Button1
            guna2Button1.Location = New Drawing.Point(76, 63)
            guna2Button1.Name = "guna2Button1"
            guna2Button1.ShadowDecoration.Parent = guna2Button1
            guna2Button1.Size = New Drawing.Size(134, 28)
            guna2Button1.TabIndex = 16
            AddHandler guna2Button1.Click, New EventHandler(AddressOf Guna2Button1_Click)
            ' 
            ' guna2Button2
            ' 
            guna2Button2.BackColor = Drawing.Color.Transparent
            guna2Button2.CheckedState.Parent = guna2Button2
            guna2Button2.CustomImages.Parent = guna2Button2
            guna2Button2.FillColor = Drawing.Color.Transparent
            guna2Button2.Font = New Drawing.Font("Segoe UI", 9.0F)
            guna2Button2.ForeColor = Drawing.Color.White
            guna2Button2.HoverState.Parent = guna2Button2
            guna2Button2.Location = New Drawing.Point(74, 211)
            guna2Button2.Name = "guna2Button2"
            guna2Button2.ShadowDecoration.Parent = guna2Button2
            guna2Button2.Size = New Drawing.Size(134, 30)
            guna2Button2.TabIndex = 17
            AddHandler guna2Button2.Click, New EventHandler(AddressOf Guna2Button2_Click)
            ' 
            ' guna2Button3
            ' 
            guna2Button3.BackColor = Drawing.Color.Transparent
            guna2Button3.CheckedState.Parent = guna2Button3
            guna2Button3.CustomImages.Parent = guna2Button3
            guna2Button3.FillColor = Drawing.Color.Transparent
            guna2Button3.Font = New Drawing.Font("Segoe UI", 9.0F)
            guna2Button3.ForeColor = Drawing.Color.White
            guna2Button3.HoverState.Parent = guna2Button3
            guna2Button3.Location = New Drawing.Point(315, 37)
            guna2Button3.Name = "guna2Button3"
            guna2Button3.ShadowDecoration.Parent = guna2Button3
            guna2Button3.Size = New Drawing.Size(138, 33)
            guna2Button3.TabIndex = 18
            AddHandler guna2Button3.Click, New EventHandler(AddressOf Guna2Button3_Click)
            ' 
            ' guna2Button4
            ' 
            guna2Button4.BackColor = Drawing.Color.Transparent
            guna2Button4.CheckedState.Parent = guna2Button4
            guna2Button4.CustomImages.Parent = guna2Button4
            guna2Button4.FillColor = Drawing.Color.Transparent
            guna2Button4.Font = New Drawing.Font("Segoe UI", 9.0F)
            guna2Button4.ForeColor = Drawing.Color.White
            guna2Button4.HoverState.Parent = guna2Button4
            guna2Button4.Location = New Drawing.Point(40, 115)
            guna2Button4.Name = "guna2Button4"
            guna2Button4.ShadowDecoration.Parent = guna2Button4
            guna2Button4.Size = New Drawing.Size(75, 25)
            guna2Button4.TabIndex = 19
            AddHandler guna2Button4.Click, New EventHandler(AddressOf Guna2Button4_Click)
            ' 
            ' guna2Button5
            ' 
            guna2Button5.BackColor = Drawing.Color.Transparent
            guna2Button5.CheckedState.Parent = guna2Button5
            guna2Button5.CustomImages.Parent = guna2Button5
            guna2Button5.FillColor = Drawing.Color.Transparent
            guna2Button5.Font = New Drawing.Font("Segoe UI", 9.0F)
            guna2Button5.ForeColor = Drawing.Color.White
            guna2Button5.HoverState.Parent = guna2Button5
            guna2Button5.Location = New Drawing.Point(174, 115)
            guna2Button5.Name = "guna2Button5"
            guna2Button5.ShadowDecoration.Parent = guna2Button5
            guna2Button5.Size = New Drawing.Size(75, 25)
            guna2Button5.TabIndex = 20
            AddHandler guna2Button5.Click, New EventHandler(AddressOf Guna2Button5_Click)
            ' 
            ' guna2Button6
            ' 
            guna2Button6.BackColor = Drawing.Color.Transparent
            guna2Button6.CheckedState.Parent = guna2Button6
            guna2Button6.CustomImages.Parent = guna2Button6
            guna2Button6.FillColor = Drawing.Color.Transparent
            guna2Button6.Font = New Drawing.Font("Segoe UI", 9.0F)
            guna2Button6.ForeColor = Drawing.Color.White
            guna2Button6.HoverState.Parent = guna2Button6
            guna2Button6.Location = New Drawing.Point(40, 160)
            guna2Button6.Name = "guna2Button6"
            guna2Button6.ShadowDecoration.Parent = guna2Button6
            guna2Button6.Size = New Drawing.Size(75, 25)
            guna2Button6.TabIndex = 21
            AddHandler guna2Button6.Click, New EventHandler(AddressOf Guna2Button6_Click)
            ' 
            ' guna2Button7
            ' 
            guna2Button7.BackColor = Drawing.Color.Transparent
            guna2Button7.CheckedState.Parent = guna2Button7
            guna2Button7.CustomImages.Parent = guna2Button7
            guna2Button7.FillColor = Drawing.Color.Transparent
            guna2Button7.Font = New Drawing.Font("Segoe UI", 9.0F)
            guna2Button7.ForeColor = Drawing.Color.White
            guna2Button7.HoverState.Parent = guna2Button7
            guna2Button7.Location = New Drawing.Point(162, 160)
            guna2Button7.Name = "guna2Button7"
            guna2Button7.ShadowDecoration.Parent = guna2Button7
            guna2Button7.Size = New Drawing.Size(87, 25)
            guna2Button7.TabIndex = 22
            AddHandler guna2Button7.Click, New EventHandler(AddressOf Guna2Button7_Click)
            ' 
            ' guna2Button8
            ' 
            guna2Button8.BackColor = Drawing.Color.Transparent
            guna2Button8.CheckedState.Parent = guna2Button8
            guna2Button8.CustomImages.Parent = guna2Button8
            guna2Button8.FillColor = Drawing.Color.Transparent
            guna2Button8.Font = New Drawing.Font("Segoe UI", 9.0F)
            guna2Button8.ForeColor = Drawing.Color.White
            guna2Button8.HoverState.Parent = guna2Button8
            guna2Button8.Location = New Drawing.Point(341, 138)
            guna2Button8.Name = "guna2Button8"
            guna2Button8.ShadowDecoration.Parent = guna2Button8
            guna2Button8.Size = New Drawing.Size(87, 20)
            guna2Button8.TabIndex = 23
            AddHandler guna2Button8.Click, New EventHandler(AddressOf Guna2Button8_Click)
            ' 
            ' guna2Button9
            ' 
            guna2Button9.BackColor = Drawing.Color.Transparent
            guna2Button9.CheckedState.Parent = guna2Button9
            guna2Button9.CustomImages.Parent = guna2Button9
            guna2Button9.FillColor = Drawing.Color.Transparent
            guna2Button9.Font = New Drawing.Font("Segoe UI", 9.0F)
            guna2Button9.ForeColor = Drawing.Color.White
            guna2Button9.HoverState.Parent = guna2Button9
            guna2Button9.Location = New Drawing.Point(341, 179)
            guna2Button9.Name = "guna2Button9"
            guna2Button9.ShadowDecoration.Parent = guna2Button9
            guna2Button9.Size = New Drawing.Size(87, 20)
            guna2Button9.TabIndex = 24
            AddHandler guna2Button9.Click, New EventHandler(AddressOf Guna2Button9_Click)
            ' 
            ' guna2Button10
            ' 
            guna2Button10.BackColor = Drawing.Color.Transparent
            guna2Button10.CheckedState.Parent = guna2Button10
            guna2Button10.CustomImages.Parent = guna2Button10
            guna2Button10.FillColor = Drawing.Color.Transparent
            guna2Button10.Font = New Drawing.Font("Segoe UI", 9.0F)
            guna2Button10.ForeColor = Drawing.Color.White
            guna2Button10.HoverState.Parent = guna2Button10
            guna2Button10.Location = New Drawing.Point(341, 219)
            guna2Button10.Name = "guna2Button10"
            guna2Button10.ShadowDecoration.Parent = guna2Button10
            guna2Button10.Size = New Drawing.Size(87, 20)
            guna2Button10.TabIndex = 25
            AddHandler guna2Button10.Click, New EventHandler(AddressOf Guna2Button10_Click)
            ' 
            ' guna2Button11
            ' 
            guna2Button11.BackColor = Drawing.Color.Transparent
            guna2Button11.CheckedState.Parent = guna2Button11
            guna2Button11.CustomImages.Parent = guna2Button11
            guna2Button11.FillColor = Drawing.Color.Transparent
            guna2Button11.Font = New Drawing.Font("Segoe UI", 9.0F)
            guna2Button11.ForeColor = Drawing.Color.White
            guna2Button11.HoverState.Parent = guna2Button11
            guna2Button11.Location = New Drawing.Point(542, 117)
            guna2Button11.Name = "guna2Button11"
            guna2Button11.ShadowDecoration.Parent = guna2Button11
            guna2Button11.Size = New Drawing.Size(87, 20)
            guna2Button11.TabIndex = 26
            AddHandler guna2Button11.Click, New EventHandler(AddressOf Guna2Button11_Click)
            ' 
            ' guna2Button12
            ' 
            guna2Button12.BackColor = Drawing.Color.Transparent
            guna2Button12.CheckedState.Parent = guna2Button12
            guna2Button12.CustomImages.Parent = guna2Button12
            guna2Button12.FillColor = Drawing.Color.Transparent
            guna2Button12.Font = New Drawing.Font("Segoe UI", 9.0F)
            guna2Button12.ForeColor = Drawing.Color.White
            guna2Button12.HoverState.Parent = guna2Button12
            guna2Button12.Location = New Drawing.Point(542, 165)
            guna2Button12.Name = "guna2Button12"
            guna2Button12.ShadowDecoration.Parent = guna2Button12
            guna2Button12.Size = New Drawing.Size(87, 20)
            guna2Button12.TabIndex = 27
            AddHandler guna2Button12.Click, New EventHandler(AddressOf Guna2Button12_Click)
            ' 
            ' guna2Button13
            ' 
            guna2Button13.BackColor = Drawing.Color.Transparent
            guna2Button13.CheckedState.Parent = guna2Button13
            guna2Button13.CustomImages.Parent = guna2Button13
            guna2Button13.FillColor = Drawing.Color.Transparent
            guna2Button13.Font = New Drawing.Font("Segoe UI", 9.0F)
            guna2Button13.ForeColor = Drawing.Color.White
            guna2Button13.HoverState.Parent = guna2Button13
            guna2Button13.Location = New Drawing.Point(533, 223)
            guna2Button13.Name = "guna2Button13"
            guna2Button13.ShadowDecoration.Parent = guna2Button13
            guna2Button13.Size = New Drawing.Size(106, 20)
            guna2Button13.TabIndex = 28
            AddHandler guna2Button13.Click, New EventHandler(AddressOf Guna2Button13_Click)
            ' 
            ' guna2Button14
            ' 
            guna2Button14.BackColor = Drawing.Color.Transparent
            guna2Button14.CheckedState.Parent = guna2Button14
            guna2Button14.CustomImages.Parent = guna2Button14
            guna2Button14.FillColor = Drawing.Color.Transparent
            guna2Button14.Font = New Drawing.Font("Segoe UI", 9.0F)
            guna2Button14.ForeColor = Drawing.Color.White
            guna2Button14.HoverState.Parent = guna2Button14
            guna2Button14.Location = New Drawing.Point(697, 223)
            guna2Button14.Name = "guna2Button14"
            guna2Button14.ShadowDecoration.Parent = guna2Button14
            guna2Button14.Size = New Drawing.Size(132, 20)
            guna2Button14.TabIndex = 29
            AddHandler guna2Button14.Click, New EventHandler(AddressOf Guna2Button14_Click)
            ' 
            ' guna2PictureBox1
            ' 
            guna2PictureBox1.Image = CType(resources.GetObject("guna2PictureBox1.Image"), Drawing.Image)
            guna2PictureBox1.Location = New Drawing.Point(693, 63)
            guna2PictureBox1.Name = "guna2PictureBox1"
            guna2PictureBox1.ShadowDecoration.Parent = guna2PictureBox1
            guna2PictureBox1.Size = New Drawing.Size(136, 129)
            guna2PictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.StretchImage
            guna2PictureBox1.TabIndex = 30
            guna2PictureBox1.TabStop = False
            ' 
            ' guna2ControlBox1
            ' 
            guna2ControlBox1.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
            guna2ControlBox1.BackColor = Drawing.Color.Transparent
            guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
            guna2ControlBox1.FillColor = Drawing.Color.Transparent
            guna2ControlBox1.HoverState.Parent = guna2ControlBox1
            guna2ControlBox1.IconColor = Drawing.Color.Red
            guna2ControlBox1.Location = New Drawing.Point(661, 274)
            guna2ControlBox1.Name = "guna2ControlBox1"
            guna2ControlBox1.ShadowDecoration.Parent = guna2ControlBox1
            guna2ControlBox1.Size = New Drawing.Size(27, 23)
            guna2ControlBox1.TabIndex = 31
            AddHandler guna2ControlBox1.Click, New EventHandler(AddressOf Guna2ControlBox1_Click)
            ' 
            ' guna2ControlBox2
            ' 
            guna2ControlBox2.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
            guna2ControlBox2.BackColor = Drawing.Color.Transparent
            guna2ControlBox2.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
            guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
            guna2ControlBox2.FillColor = Drawing.Color.Transparent
            guna2ControlBox2.HoverState.Parent = guna2ControlBox2
            guna2ControlBox2.IconColor = Drawing.Color.Red
            guna2ControlBox2.Location = New Drawing.Point(174, 274)
            guna2ControlBox2.Name = "guna2ControlBox2"
            guna2ControlBox2.ShadowDecoration.Parent = guna2ControlBox2
            guna2ControlBox2.Size = New Drawing.Size(27, 23)
            guna2ControlBox2.TabIndex = 32
            AddHandler guna2ControlBox2.Click, New EventHandler(AddressOf Guna2ControlBox2_Click)
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.BackColor = Drawing.Color.Transparent
            label1.ForeColor = Drawing.Color.Coral
            label1.Location = New Drawing.Point(37, 259)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(153, 13)
            label1.TabIndex = 33
            label1.Text = "DEV:𝓘𝓖𝓣 𝓢𝓐𝓐𝓲𝓵❤️MR.eslam"
            ' 
            ' Main
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.Lime
            BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Drawing.Image)
            ClientSize = New Drawing.Size(865, 308)
            Controls.Add(label1)
            Controls.Add(guna2ControlBox2)
            Controls.Add(guna2ControlBox1)
            Controls.Add(guna2PictureBox1)
            Controls.Add(guna2Button14)
            Controls.Add(guna2Button13)
            Controls.Add(guna2Button12)
            Controls.Add(guna2Button11)
            Controls.Add(guna2Button10)
            Controls.Add(guna2Button9)
            Controls.Add(guna2Button8)
            Controls.Add(guna2Button7)
            Controls.Add(guna2Button6)
            Controls.Add(guna2Button5)
            Controls.Add(guna2Button4)
            Controls.Add(guna2Button3)
            Controls.Add(guna2Button2)
            Controls.Add(guna2Button1)
            Controls.Add(label2)
            Controls.Add(label5)
            Controls.Add(label4)
            FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            Name = "Main"
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "EGYPT ANTIBAN V2.0"
            TransparencyKey = Drawing.Color.Lime
            AddHandler FormClosing, New Windows.Forms.FormClosingEventHandler(AddressOf Main_FormClosing)
            AddHandler FormClosed, New Windows.Forms.FormClosedEventHandler(AddressOf Main_FormClosed)
            AddHandler Load, New EventHandler(AddressOf Main_Load)
            AddHandler MouseDown, New Windows.Forms.MouseEventHandler(AddressOf Main_MouseDown)
            CType(guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region
        Private label4 As Windows.Forms.Label
        Private label5 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private guna2Button1 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button2 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button3 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button4 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button5 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button6 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button7 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button8 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button9 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button10 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button11 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button12 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button13 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button14 As Guna.UI2.WinForms.Guna2Button
        Private guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
        Private guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
        Private guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
        Private label1 As Windows.Forms.Label
    End Class
End Namespace
