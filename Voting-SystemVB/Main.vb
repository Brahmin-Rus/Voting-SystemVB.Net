﻿
Imports System.Windows.Forms

Public Class Main
    Inherits Form

    Public Shared Instance As Main

    Public Sub New()

        FormBorderStyle = Windows.Forms.FormBorderStyle.None

        ' Add any initialization after the InitializeComponent() call.
        Instance = Me

        LoadControl(VoterLogin.GetInstance())
    End Sub

    Public Shared Sub LoadControl(Child As UserControl)
        Instance.Controls.Clear()
        Instance.Size = Child.Size
        Child.Location = New Point(0, 0)
        Instance.Controls.Add(Child)
        Instance.CenterToScreen()
    End Sub




End Class
