<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminCourse
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
        Me.OkButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DepartmentListBox = New System.Windows.Forms.ListBox()
        Me.CourseYearListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OkButton
        '
        Me.OkButton.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.OkButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OkButton.Location = New System.Drawing.Point(95, 292)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(94, 43)
        Me.OkButton.TabIndex = 1
        Me.OkButton.Text = "Ok"
        Me.OkButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.UpdateButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UpdateButton.Location = New System.Drawing.Point(332, 292)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(94, 43)
        Me.UpdateButton.TabIndex = 2
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(552, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 43)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DepartmentListBox
        '
        Me.DepartmentListBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DepartmentListBox.FormattingEnabled = True
        Me.DepartmentListBox.ItemHeight = 20
        Me.DepartmentListBox.Items.AddRange(New Object() {"BCA", "BBA", "BA"})
        Me.DepartmentListBox.Location = New System.Drawing.Point(384, 107)
        Me.DepartmentListBox.Name = "DepartmentListBox"
        Me.DepartmentListBox.Size = New System.Drawing.Size(150, 24)
        Me.DepartmentListBox.TabIndex = 7
        '
        'CourseYearListBox
        '
        Me.CourseYearListBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CourseYearListBox.FormattingEnabled = True
        Me.CourseYearListBox.ItemHeight = 20
        Me.CourseYearListBox.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CourseYearListBox.Location = New System.Drawing.Point(384, 190)
        Me.CourseYearListBox.Name = "CourseYearListBox"
        Me.CourseYearListBox.Size = New System.Drawing.Size(150, 24)
        Me.CourseYearListBox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(147, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "DEPARTMENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(145, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "COURSE YEAR"
        '
        'AdminCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.BackgroundImage = Global._4thsemproject.My.Resources.Resources.beautiful_color_gradients_backgrounds_165_morning_salad1
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CourseYearListBox)
        Me.Controls.Add(Me.DepartmentListBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.OkButton)
        Me.Name = "AdminCourse"
        Me.Text = "AdminCourse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OkButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DepartmentListBox As ListBox
    Friend WithEvents CourseYearListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
