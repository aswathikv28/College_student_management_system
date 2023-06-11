<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateCourse
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
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CourseYearTextBox = New System.Windows.Forms.TextBox()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CourseNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CourseIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.DepartmentTextBox.Location = New System.Drawing.Point(311, 225)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.PlaceholderText = "Department"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(125, 27)
        Me.DepartmentTextBox.TabIndex = 2
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.SeaShell
        Me.UpdateButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UpdateButton.Location = New System.Drawing.Point(158, 366)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(94, 39)
        Me.UpdateButton.TabIndex = 3
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(157, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Course Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(159, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(159, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Course Year"
        '
        'CourseYearTextBox
        '
        Me.CourseYearTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CourseYearTextBox.Location = New System.Drawing.Point(311, 301)
        Me.CourseYearTextBox.Name = "CourseYearTextBox"
        Me.CourseYearTextBox.PlaceholderText = "Course Year"
        Me.CourseYearTextBox.Size = New System.Drawing.Size(125, 27)
        Me.CourseYearTextBox.TabIndex = 8
        '
        'RemoveButton
        '
        Me.RemoveButton.BackColor = System.Drawing.Color.SeaShell
        Me.RemoveButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RemoveButton.Location = New System.Drawing.Point(497, 366)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(94, 39)
        Me.RemoveButton.TabIndex = 11
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaShell
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(327, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 39)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CourseNameComboBox
        '
        Me.CourseNameComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CourseNameComboBox.FormattingEnabled = True
        Me.CourseNameComboBox.Location = New System.Drawing.Point(311, 139)
        Me.CourseNameComboBox.Name = "CourseNameComboBox"
        Me.CourseNameComboBox.Size = New System.Drawing.Size(151, 28)
        Me.CourseNameComboBox.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(156, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Course ID"
        '
        'CourseIDComboBox
        '
        Me.CourseIDComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CourseIDComboBox.FormattingEnabled = True
        Me.CourseIDComboBox.Location = New System.Drawing.Point(311, 64)
        Me.CourseIDComboBox.Name = "CourseIDComboBox"
        Me.CourseIDComboBox.Size = New System.Drawing.Size(151, 28)
        Me.CourseIDComboBox.TabIndex = 15
        '
        'UpdateCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._4thsemproject.My.Resources.Resources.studn
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CourseIDComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CourseNameComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.CourseYearTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Name = "UpdateCourse"
        Me.Text = "UpdateCourse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CourseYearTextBox As TextBox
    Friend WithEvents RemoveButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CourseNameComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CourseIDComboBox As ComboBox
End Class
