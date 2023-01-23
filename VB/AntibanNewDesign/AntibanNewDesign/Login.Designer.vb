Imports System

Namespace AntibanNewDesign
    Partial Class Login
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
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
            button1 = New Windows.Forms.Button()
            textBox1 = New Windows.Forms.TextBox()
            guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
            button2 = New Windows.Forms.Button()
            CType(guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' button1
            ' 
            button1.BackColor = Drawing.Color.Transparent
            button1.FlatAppearance.BorderSize = 0
            button1.FlatStyle = Windows.Forms.FlatStyle.Flat
            button1.Font = New Drawing.Font("Arial", 14.0F, Drawing.FontStyle.Bold)
            button1.ForeColor = Drawing.SystemColors.ControlLightLight
            button1.Location = New Drawing.Point(122, 372)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(210, 32)
            button1.TabIndex = 0
            button1.Text = "Login"
            button1.UseVisualStyleBackColor = False
            AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
            ' 
            ' textBox1
            ' 
            textBox1.BackColor = Drawing.Color.White
            textBox1.BorderStyle = Windows.Forms.BorderStyle.None
            textBox1.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F)
            textBox1.ForeColor = Drawing.Color.Black
            textBox1.Location = New Drawing.Point(100, 337)
            textBox1.Margin = New Windows.Forms.Padding(0)
            textBox1.Name = "textBox1"
            textBox1.Size = New Drawing.Size(273, 19)
            textBox1.TabIndex = 4
            ' 
            ' guna2PictureBox1
            ' 
            guna2PictureBox1.Image = CType(resources.GetObject("guna2PictureBox1.Image"), Drawing.Image)
            guna2PictureBox1.Location = New Drawing.Point(108, 90)
            guna2PictureBox1.Name = "guna2PictureBox1"
            guna2PictureBox1.ShadowDecoration.Parent = guna2PictureBox1
            guna2PictureBox1.Size = New Drawing.Size(256, 229)
            guna2PictureBox1.TabIndex = 5
            guna2PictureBox1.TabStop = False
            ' 
            ' button2
            ' 
            button2.BackColor = Drawing.Color.Transparent
            button2.BackgroundImage = CType(resources.GetObject("button2.BackgroundImage"), Drawing.Image)
            button2.BackgroundImageLayout = Windows.Forms.ImageLayout.Stretch
            button2.FlatAppearance.BorderSize = 0
            button2.FlatStyle = Windows.Forms.FlatStyle.Flat
            button2.Font = New Drawing.Font("Arial", 14.0F, Drawing.FontStyle.Bold)
            button2.ForeColor = Drawing.SystemColors.ControlLightLight
            button2.Location = New Drawing.Point(413, 48)
            button2.Name = "button2"
            button2.Size = New Drawing.Size(33, 19)
            button2.TabIndex = 6
            button2.UseVisualStyleBackColor = False
            ' 
            ' Login
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.Lime
            BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Drawing.Image)
            BackgroundImageLayout = Windows.Forms.ImageLayout.Stretch
            ClientSize = New Drawing.Size(472, 440)
            Controls.Add(button2)
            Controls.Add(guna2PictureBox1)
            Controls.Add(textBox1)
            Controls.Add(button1)
            DoubleBuffered = True
            FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            Name = "Login"
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "LOGIN EGYPT ANTIBAN"
            TransparencyKey = Drawing.Color.Lime
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            AddHandler MouseDown, New Windows.Forms.MouseEventHandler(AddressOf Form1_MouseDown)
            CType(guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private button1 As Windows.Forms.Button
        Private textBox1 As Windows.Forms.TextBox
        Private guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
        Private button2 As Windows.Forms.Button
    End Class
End Namespace
