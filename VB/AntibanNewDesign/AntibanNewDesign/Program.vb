﻿Imports System
Imports System.Windows.Forms

Namespace AntibanNewDesign
    Friend Module Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Private Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Main())
        End Sub
    End Module
End Namespace
