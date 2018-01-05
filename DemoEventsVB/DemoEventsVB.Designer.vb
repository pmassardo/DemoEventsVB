<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemoEventsVB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lblEventOutput = New System.Windows.Forms.Label()
        Me.lbEvent = New System.Windows.Forms.Label()
        Me.tbTextBoxDemonstrator = New System.Windows.Forms.TextBox()
        Me.lbLabelDemonstrator = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEventOutput
        '
        Me.lblEventOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEventOutput.Location = New System.Drawing.Point(5, 74)
        Me.lblEventOutput.Name = "lblEventOutput"
        Me.lblEventOutput.Size = New System.Drawing.Size(268, 185)
        Me.lblEventOutput.TabIndex = 4
        '
        'lbEvent
        '
        Me.lbEvent.Location = New System.Drawing.Point(3, 54)
        Me.lbEvent.Name = "lbEvent"
        Me.lbEvent.Size = New System.Drawing.Size(64, 20)
        Me.lbEvent.TabIndex = 3
        Me.lbEvent.Text = "Event Data:"
        '
        'tbTextBoxDemonstrator
        '
        Me.tbTextBoxDemonstrator.Location = New System.Drawing.Point(141, 2)
        Me.tbTextBoxDemonstrator.Name = "tbTextBoxDemonstrator"
        Me.tbTextBoxDemonstrator.Size = New System.Drawing.Size(80, 20)
        Me.tbTextBoxDemonstrator.TabIndex = 1
        '
        'lbLabelDemonstrator
        '
        Me.lbLabelDemonstrator.Location = New System.Drawing.Point(55, 5)
        Me.lbLabelDemonstrator.Name = "lbLabelDemonstrator"
        Me.lbLabelDemonstrator.Size = New System.Drawing.Size(80, 20)
        Me.lbLabelDemonstrator.TabIndex = 0
        Me.lbLabelDemonstrator.Text = "&Demonstrator"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(198, 264)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(117, 264)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(141, 28)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(82, 23)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'frmDemoEventsVB
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(277, 289)
        Me.Controls.Add(Me.lblEventOutput)
        Me.Controls.Add(Me.lbEvent)
        Me.Controls.Add(Me.tbTextBoxDemonstrator)
        Me.Controls.Add(Me.lbLabelDemonstrator)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.Name = "frmDemoEventsVB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB Events Demonstration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblEventOutput As Label
    Private WithEvents lbEvent As Label
    Private WithEvents tbTextBoxDemonstrator As TextBox
    Private WithEvents lbLabelDemonstrator As Label
    Private WithEvents btnExit As Button
    Private WithEvents btnReset As Button
    Private WithEvents btnEnter As Button
End Class
