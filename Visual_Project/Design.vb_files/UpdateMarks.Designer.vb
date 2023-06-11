<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateMarks
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
        Me.MarksTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StudentIDComboBox = New System.Windows.Forms.ComboBox()
        Me.CourseIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'MarksTextBox
        '
        Me.MarksTextBox.Location = New System.Drawing.Point(402, 231)
        Me.MarksTextBox.Name = "MarksTextBox"
        Me.MarksTextBox.PlaceholderText = "Marks"
        Me.MarksTextBox.Size = New System.Drawing.Size(125, 27)
        Me.MarksTextBox.TabIndex = 2
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.SeaShell
        Me.UpdateButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UpdateButton.Location = New System.Drawing.Point(142, 338)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(94, 38)
        Me.UpdateButton.TabIndex = 3
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'RemoveButton
        '
        Me.RemoveButton.BackColor = System.Drawing.Color.SeaShell
        Me.RemoveButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RemoveButton.Location = New System.Drawing.Point(557, 338)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(94, 35)
        Me.RemoveButton.TabIndex = 4
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(232, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "STUDENT ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(232, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "COURSE NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(232, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "MARKS"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaShell
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(359, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 35)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'StudentIDComboBox
        '
        Me.StudentIDComboBox.FormattingEnabled = True
        Me.StudentIDComboBox.Location = New System.Drawing.Point(402, 90)
        Me.StudentIDComboBox.Name = "StudentIDComboBox"
        Me.StudentIDComboBox.Size = New System.Drawing.Size(151, 28)
        Me.StudentIDComboBox.TabIndex = 13
        '
        'CourseIDComboBox
        '
        Me.CourseIDComboBox.FormattingEnabled = True
        Me.CourseIDComboBox.Location = New System.Drawing.Point(402, 165)
        Me.CourseIDComboBox.Name = "CourseIDComboBox"
        Me.CourseIDComboBox.Size = New System.Drawing.Size(151, 28)
        Me.CourseIDComboBox.TabIndex = 14
        '
        'UpdateMarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._4thsemproject.My.Resources.Resources.studn
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CourseIDComboBox)
        Me.Controls.Add(Me.StudentIDComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.MarksTextBox)
        Me.Name = "UpdateMarks"
        Me.Text = "UpdateMarks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MarksTextBox As TextBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents RemoveButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents StudentIDComboBox As ComboBox
    Friend WithEvents CourseIDComboBox As ComboBox
End Class
