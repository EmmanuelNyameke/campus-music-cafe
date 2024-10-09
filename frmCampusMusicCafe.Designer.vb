<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCampusMusicCafe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        picCafePicture = New PictureBox()
        lblPhrase = New Label()
        btnView = New Button()
        btnStart = New Button()
        btnDetails = New Button()
        btnExit = New Button()
        lblDate = New Label()
        lblStart = New Label()
        lblDetails = New Label()
        CType(picCafePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picCafePicture
        ' 
        picCafePicture.Location = New Point(244, 12)
        picCafePicture.Name = "picCafePicture"
        picCafePicture.Size = New Size(312, 207)
        picCafePicture.TabIndex = 0
        picCafePicture.TabStop = False
        ' 
        ' lblPhrase
        ' 
        lblPhrase.AutoSize = True
        lblPhrase.Location = New Point(308, 263)
        lblPhrase.Name = "lblPhrase"
        lblPhrase.Size = New Size(185, 15)
        lblPhrase.TabIndex = 1
        lblPhrase.Text = "All College Students are Welcome"
        ' 
        ' btnView
        ' 
        btnView.Location = New Point(121, 313)
        btnView.Name = "btnView"
        btnView.Size = New Size(123, 23)
        btnView.TabIndex = 2
        btnView.Text = "View Date"
        btnView.UseVisualStyleBackColor = True
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(337, 313)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(123, 23)
        btnStart.TabIndex = 3
        btnStart.Text = "Start Location"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnDetails
        ' 
        btnDetails.Location = New Point(556, 313)
        btnDetails.Name = "btnDetails"
        btnDetails.Size = New Size(123, 23)
        btnDetails.TabIndex = 4
        btnDetails.Text = "Details"
        btnDetails.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(350, 413)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(100, 25)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit Window"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(75, 360)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(98, 15)
        lblDate.TabIndex = 6
        lblDate.Text = "October, 30 2018."
        ' 
        ' lblStart
        ' 
        lblStart.AutoSize = True
        lblStart.Location = New Point(292, 360)
        lblStart.Name = "lblStart"
        lblStart.Size = New Size(108, 30)
        lblStart.TabIndex = 7
        lblStart.Text = "Open 'Mic'" & vbCrLf & "Start Time: 8:00pm." & vbCrLf
        ' 
        ' lblDetails
        ' 
        lblDetails.AutoSize = True
        lblDetails.Location = New Point(519, 360)
        lblDetails.Name = "lblDetails"
        lblDetails.Size = New Size(207, 30)
        lblDetails.TabIndex = 8
        lblDetails.Text = "For more information, View the " & vbCrLf & "Campus Music Cafe's Facebook page."
        ' 
        ' frmCampusMusicCafe
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblDetails)
        Controls.Add(lblStart)
        Controls.Add(lblDate)
        Controls.Add(btnExit)
        Controls.Add(btnDetails)
        Controls.Add(btnStart)
        Controls.Add(btnView)
        Controls.Add(lblPhrase)
        Controls.Add(picCafePicture)
        Name = "frmCampusMusicCafe"
        Text = "Campus Music Cafe Open Mic Night"
        CType(picCafePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picCafePicture As PictureBox
    Friend WithEvents lblPhrase As Label
    Friend WithEvents btnView As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnDetails As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents lblDetails As Label

End Class
