<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CVV = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ValBt = New System.Windows.Forms.Button()
        Me.CardNo = New System.Windows.Forms.TextBox()
        Me.ExDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Credit Card Number"
        '
        'CVV
        '
        Me.CVV.Location = New System.Drawing.Point(224, 54)
        Me.CVV.Name = "CVV"
        Me.CVV.Size = New System.Drawing.Size(36, 20)
        Me.CVV.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CVV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Expire date"
        '
        'ValBt
        '
        Me.ValBt.BackColor = System.Drawing.Color.PowderBlue
        Me.ValBt.Location = New System.Drawing.Point(91, 143)
        Me.ValBt.Name = "ValBt"
        Me.ValBt.Size = New System.Drawing.Size(156, 66)
        Me.ValBt.TabIndex = 7
        Me.ValBt.Text = "Click to validate"
        Me.ValBt.UseVisualStyleBackColor = False
        '
        'CardNo
        '
        Me.CardNo.Location = New System.Drawing.Point(73, 54)
        Me.CardNo.MaxLength = 14141
        Me.CardNo.Name = "CardNo"
        Me.CardNo.Size = New System.Drawing.Size(114, 20)
        Me.CardNo.TabIndex = 8
        '
        'ExDate
        '
        Me.ExDate.Location = New System.Drawing.Point(73, 105)
        Me.ExDate.Name = "ExDate"
        Me.ExDate.Size = New System.Drawing.Size(155, 20)
        Me.ExDate.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(336, 259)
        Me.Controls.Add(Me.CardNo)
        Me.Controls.Add(Me.ValBt)
        Me.Controls.Add(Me.ExDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CVV)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Credit Card Validator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents CVV As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ValBt As Button
    Friend WithEvents CardNo As TextBox
    Friend WithEvents ExDate As DateTimePicker
End Class
