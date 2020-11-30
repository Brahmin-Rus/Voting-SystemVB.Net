﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPanel))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.indicator = New System.Windows.Forms.Panel()
        Me.ButtonLogout = New System.Windows.Forms.Button()
        Me.ButtonAdmin = New System.Windows.Forms.Button()
        Me.ButtonParty = New System.Windows.Forms.Button()
        Me.ButtonCandidate = New System.Windows.Forms.Button()
        Me.ButtonVoter = New System.Windows.Forms.Button()
        Me.ButtonHome = New System.Windows.Forms.Button()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.ButtonClose = New Voting_SystemVB.FontAwesome()
        Me.ButtonMaximize = New Voting_SystemVB.FontAwesome()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TotalCandidates = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelFullname = New System.Windows.Forms.Label()
        Me.ChipElectionStatus = New Guna.UI2.WinForms.Guna2Chip()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TotalVoters = New System.Windows.Forms.TextBox()
        Me.Remaining = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ViewTotalCandidates = New System.Windows.Forms.Button()
        Me.ViewTotalParties = New System.Windows.Forms.Button()
        Me.President = New System.Windows.Forms.Label()
        Me.VicePresident = New System.Windows.Forms.Label()
        Me.Secretary = New System.Windows.Forms.Label()
        Me.Treasurer = New System.Windows.Forms.Label()
        Me.Auditor = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TotalCandidates.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.indicator)
        Me.Panel1.Controls.Add(Me.ButtonLogout)
        Me.Panel1.Controls.Add(Me.ButtonAdmin)
        Me.Panel1.Controls.Add(Me.ButtonParty)
        Me.Panel1.Controls.Add(Me.ButtonCandidate)
        Me.Panel1.Controls.Add(Me.ButtonVoter)
        Me.Panel1.Controls.Add(Me.ButtonHome)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 637)
        Me.Panel1.TabIndex = 0
        '
        'indicator
        '
        Me.indicator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.indicator.Location = New System.Drawing.Point(0, 67)
        Me.indicator.Name = "indicator"
        Me.indicator.Size = New System.Drawing.Size(10, 47)
        Me.indicator.TabIndex = 4
        '
        'ButtonLogout
        '
        Me.ButtonLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLogout.FlatAppearance.BorderSize = 0
        Me.ButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogout.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogout.ForeColor = System.Drawing.Color.White
        Me.ButtonLogout.Image = Global.Voting_SystemVB.My.Resources.Resources.logout
        Me.ButtonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLogout.Location = New System.Drawing.Point(11, 332)
        Me.ButtonLogout.Name = "ButtonLogout"
        Me.ButtonLogout.Size = New System.Drawing.Size(205, 47)
        Me.ButtonLogout.TabIndex = 3
        Me.ButtonLogout.Text = "Logout"
        Me.ButtonLogout.UseVisualStyleBackColor = True
        '
        'ButtonAdmin
        '
        Me.ButtonAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAdmin.FlatAppearance.BorderSize = 0
        Me.ButtonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdmin.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdmin.ForeColor = System.Drawing.Color.White
        Me.ButtonAdmin.Image = Global.Voting_SystemVB.My.Resources.Resources.settings
        Me.ButtonAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAdmin.Location = New System.Drawing.Point(11, 279)
        Me.ButtonAdmin.Name = "ButtonAdmin"
        Me.ButtonAdmin.Size = New System.Drawing.Size(205, 47)
        Me.ButtonAdmin.TabIndex = 3
        Me.ButtonAdmin.Text = "Update Account"
        Me.ButtonAdmin.UseVisualStyleBackColor = True
        '
        'ButtonParty
        '
        Me.ButtonParty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonParty.FlatAppearance.BorderSize = 0
        Me.ButtonParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonParty.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonParty.ForeColor = System.Drawing.Color.White
        Me.ButtonParty.Image = Global.Voting_SystemVB.My.Resources.Resources.party
        Me.ButtonParty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonParty.Location = New System.Drawing.Point(11, 226)
        Me.ButtonParty.Name = "ButtonParty"
        Me.ButtonParty.Size = New System.Drawing.Size(205, 47)
        Me.ButtonParty.TabIndex = 3
        Me.ButtonParty.Text = "Party"
        Me.ButtonParty.UseVisualStyleBackColor = True
        '
        'ButtonCandidate
        '
        Me.ButtonCandidate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCandidate.FlatAppearance.BorderSize = 0
        Me.ButtonCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCandidate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCandidate.ForeColor = System.Drawing.Color.White
        Me.ButtonCandidate.Image = Global.Voting_SystemVB.My.Resources.Resources.candidate
        Me.ButtonCandidate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCandidate.Location = New System.Drawing.Point(11, 173)
        Me.ButtonCandidate.Name = "ButtonCandidate"
        Me.ButtonCandidate.Size = New System.Drawing.Size(205, 47)
        Me.ButtonCandidate.TabIndex = 3
        Me.ButtonCandidate.Text = "Candidates"
        Me.ButtonCandidate.UseVisualStyleBackColor = True
        '
        'ButtonVoter
        '
        Me.ButtonVoter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonVoter.FlatAppearance.BorderSize = 0
        Me.ButtonVoter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVoter.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVoter.ForeColor = System.Drawing.Color.White
        Me.ButtonVoter.Image = Global.Voting_SystemVB.My.Resources.Resources.voter
        Me.ButtonVoter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonVoter.Location = New System.Drawing.Point(11, 120)
        Me.ButtonVoter.Name = "ButtonVoter"
        Me.ButtonVoter.Size = New System.Drawing.Size(205, 47)
        Me.ButtonVoter.TabIndex = 3
        Me.ButtonVoter.Text = "Voters"
        Me.ButtonVoter.UseVisualStyleBackColor = True
        '
        'ButtonHome
        '
        Me.ButtonHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHome.FlatAppearance.BorderSize = 0
        Me.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHome.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHome.ForeColor = System.Drawing.Color.White
        Me.ButtonHome.Image = CType(resources.GetObject("ButtonHome.Image"), System.Drawing.Image)
        Me.ButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonHome.Location = New System.Drawing.Point(11, 67)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(205, 47)
        Me.ButtonHome.TabIndex = 3
        Me.ButtonHome.Text = "Home"
        Me.ButtonHome.UseVisualStyleBackColor = True
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.ButtonClose)
        Me.PanelHeader.Controls.Add(Me.ButtonMaximize)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(219, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(913, 20)
        Me.PanelHeader.TabIndex = 1
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.AutoSize = True
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonClose.HoverColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ButtonClose.Location = New System.Drawing.Point(889, 2)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(91, 17)
        Me.ButtonClose.TabIndex = 5
        Me.ButtonClose.Text = "window-close"
        '
        'ButtonMaximize
        '
        Me.ButtonMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMaximize.AutoSize = True
        Me.ButtonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMaximize.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonMaximize.HoverColor = System.Drawing.Color.Empty
        Me.ButtonMaximize.Location = New System.Drawing.Point(868, 2)
        Me.ButtonMaximize.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonMaximize.Name = "ButtonMaximize"
        Me.ButtonMaximize.Size = New System.Drawing.Size(115, 17)
        Me.ButtonMaximize.TabIndex = 5
        Me.ButtonMaximize.Text = "window-maximize"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(58, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(117, 135)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(30, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Admin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Panel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(181, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(492, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Supreme Student Council Election-System"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalCandidates
        '
        Me.TotalCandidates.Controls.Add(Me.ViewTotalParties)
        Me.TotalCandidates.Controls.Add(Me.ViewTotalCandidates)
        Me.TotalCandidates.Controls.Add(Me.GroupBox1)
        Me.TotalCandidates.Controls.Add(Me.Remaining)
        Me.TotalCandidates.Controls.Add(Me.TotalVoters)
        Me.TotalCandidates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalCandidates.Location = New System.Drawing.Point(219, 156)
        Me.TotalCandidates.Name = "TotalCandidates"
        Me.TotalCandidates.Size = New System.Drawing.Size(913, 481)
        Me.TotalCandidates.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(182, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Election Status: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(182, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 22)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Logged in as:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelFullname
        '
        Me.LabelFullname.AutoSize = True
        Me.LabelFullname.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.LabelFullname.ForeColor = System.Drawing.Color.Black
        Me.LabelFullname.Location = New System.Drawing.Point(316, 41)
        Me.LabelFullname.Name = "LabelFullname"
        Me.LabelFullname.Size = New System.Drawing.Size(133, 22)
        Me.LabelFullname.TabIndex = 1
        Me.LabelFullname.Text = "User Fullname"
        Me.LabelFullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChipElectionStatus
        '
        Me.ChipElectionStatus.BorderRadius = 5
        Me.ChipElectionStatus.FillColor = System.Drawing.Color.Green
        Me.ChipElectionStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChipElectionStatus.ForeColor = System.Drawing.Color.White
        Me.ChipElectionStatus.Location = New System.Drawing.Point(328, 73)
        Me.ChipElectionStatus.Name = "ChipElectionStatus"
        Me.ChipElectionStatus.ShadowDecoration.Parent = Me.ChipElectionStatus
        Me.ChipElectionStatus.Size = New System.Drawing.Size(83, 17)
        Me.ChipElectionStatus.TabIndex = 4
        Me.ChipElectionStatus.Text = "Not Started"
        Me.ChipElectionStatus.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ChipElectionStatus)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.LabelFullname)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(219, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(913, 136)
        Me.Panel2.TabIndex = 5
        '
        'TotalVoters
        '
        Me.TotalVoters.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalVoters.Location = New System.Drawing.Point(377, 435)
        Me.TotalVoters.Name = "TotalVoters"
        Me.TotalVoters.Size = New System.Drawing.Size(204, 23)
        Me.TotalVoters.TabIndex = 0
        Me.TotalVoters.Text = "Total Voters: 200"
        Me.TotalVoters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Remaining
        '
        Me.Remaining.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remaining.Location = New System.Drawing.Point(607, 435)
        Me.Remaining.Name = "Remaining"
        Me.Remaining.Size = New System.Drawing.Size(204, 23)
        Me.Remaining.TabIndex = 1
        Me.Remaining.Text = "Remaining Votes: 78"
        Me.Remaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Auditor)
        Me.GroupBox1.Controls.Add(Me.Treasurer)
        Me.GroupBox1.Controls.Add(Me.Secretary)
        Me.GroupBox1.Controls.Add(Me.VicePresident)
        Me.GroupBox1.Controls.Add(Me.President)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(186, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 366)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total Candidates"
        '
        'ViewTotalCandidates
        '
        Me.ViewTotalCandidates.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewTotalCandidates.Location = New System.Drawing.Point(58, 138)
        Me.ViewTotalCandidates.Name = "ViewTotalCandidates"
        Me.ViewTotalCandidates.Size = New System.Drawing.Size(102, 48)
        Me.ViewTotalCandidates.TabIndex = 3
        Me.ViewTotalCandidates.Text = "View Total Candidates"
        Me.ViewTotalCandidates.UseVisualStyleBackColor = True
        '
        'ViewTotalParties
        '
        Me.ViewTotalParties.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewTotalParties.Location = New System.Drawing.Point(58, 274)
        Me.ViewTotalParties.Name = "ViewTotalParties"
        Me.ViewTotalParties.Size = New System.Drawing.Size(102, 49)
        Me.ViewTotalParties.TabIndex = 4
        Me.ViewTotalParties.Text = "ViewTotal Parties"
        Me.ViewTotalParties.UseVisualStyleBackColor = True
        '
        'President
        '
        Me.President.AutoSize = True
        Me.President.Location = New System.Drawing.Point(55, 73)
        Me.President.Name = "President"
        Me.President.Size = New System.Drawing.Size(107, 21)
        Me.President.TabIndex = 0
        Me.President.Text = "President: 12"
        '
        'VicePresident
        '
        Me.VicePresident.AutoSize = True
        Me.VicePresident.Location = New System.Drawing.Point(55, 124)
        Me.VicePresident.Name = "VicePresident"
        Me.VicePresident.Size = New System.Drawing.Size(145, 21)
        Me.VicePresident.TabIndex = 1
        Me.VicePresident.Text = "Vice President: 12"
        '
        'Secretary
        '
        Me.Secretary.AutoSize = True
        Me.Secretary.Location = New System.Drawing.Point(55, 178)
        Me.Secretary.Name = "Secretary"
        Me.Secretary.Size = New System.Drawing.Size(101, 21)
        Me.Secretary.TabIndex = 2
        Me.Secretary.Text = "Secretary: 8"
        '
        'Treasurer
        '
        Me.Treasurer.AutoSize = True
        Me.Treasurer.Location = New System.Drawing.Point(55, 233)
        Me.Treasurer.Name = "Treasurer"
        Me.Treasurer.Size = New System.Drawing.Size(97, 21)
        Me.Treasurer.TabIndex = 3
        Me.Treasurer.Text = "Treasurer: 9"
        '
        'Auditor
        '
        Me.Auditor.AutoSize = True
        Me.Auditor.Location = New System.Drawing.Point(55, 290)
        Me.Auditor.Name = "Auditor"
        Me.Auditor.Size = New System.Drawing.Size(86, 21)
        Me.Auditor.TabIndex = 4
        Me.Auditor.Text = "Auditor: 7"
        '
        'AdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TotalCandidates)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdminPanel"
        Me.Size = New System.Drawing.Size(1132, 637)
        Me.Panel1.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TotalCandidates.ResumeLayout(False)
        Me.TotalCandidates.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents ButtonHome As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonParty As System.Windows.Forms.Button
    Friend WithEvents ButtonCandidate As System.Windows.Forms.Button
    Friend WithEvents ButtonVoter As System.Windows.Forms.Button
    Friend WithEvents ButtonAdmin As System.Windows.Forms.Button
    Friend WithEvents ButtonLogout As System.Windows.Forms.Button
    Friend WithEvents indicator As System.Windows.Forms.Panel
    Friend WithEvents TotalCandidates As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelFullname As System.Windows.Forms.Label
    Friend WithEvents ChipElectionStatus As Guna.UI2.WinForms.Guna2Chip
    Friend WithEvents ButtonClose As Voting_SystemVB.FontAwesome
    Friend WithEvents ButtonMaximize As Voting_SystemVB.FontAwesome
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Remaining As System.Windows.Forms.TextBox
    Friend WithEvents TotalVoters As System.Windows.Forms.TextBox
    Friend WithEvents ViewTotalCandidates As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ViewTotalParties As System.Windows.Forms.Button
    Friend WithEvents President As System.Windows.Forms.Label
    Friend WithEvents Treasurer As System.Windows.Forms.Label
    Friend WithEvents Secretary As System.Windows.Forms.Label
    Friend WithEvents VicePresident As System.Windows.Forms.Label
    Friend WithEvents Auditor As System.Windows.Forms.Label

End Class
