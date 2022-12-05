<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblExamScore = New System.Windows.Forms.Label()
        Me.txtExamScore = New System.Windows.Forms.TextBox()
        Me.btnGrade = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblExamScore
        '
        Me.lblExamScore.AutoSize = True
        Me.lblExamScore.Location = New System.Drawing.Point(98, 92)
        Me.lblExamScore.Name = "lblExamScore"
        Me.lblExamScore.Size = New System.Drawing.Size(138, 13)
        Me.lblExamScore.TabIndex = 0
        Me.lblExamScore.Text = "Enter the examination score"
        '
        'txtExamScore
        '
        Me.txtExamScore.Location = New System.Drawing.Point(288, 87)
        Me.txtExamScore.Name = "txtExamScore"
        Me.txtExamScore.Size = New System.Drawing.Size(74, 20)
        Me.txtExamScore.TabIndex = 1
        '
        'btnGrade
        '
        Me.btnGrade.Location = New System.Drawing.Point(189, 184)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(119, 78)
        Me.btnGrade.TabIndex = 2
        Me.btnGrade.Text = "Get Grade"
        Me.btnGrade.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGrade)
        Me.Controls.Add(Me.txtExamScore)
        Me.Controls.Add(Me.lblExamScore)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblExamScore As Label
    Friend WithEvents txtExamScore As TextBox
    Friend WithEvents btnGrade As Button
End Class
