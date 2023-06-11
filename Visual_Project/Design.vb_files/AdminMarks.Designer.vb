<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMarks
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
        Me.OkButton.Location = New System.Drawing.Point(151, 290)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(94, 40)
        Me.OkButton.TabIndex = 2
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.UpdateButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UpdateButton.Location = New System.Drawing.Point(359, 290)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(94, 40)
        Me.UpdateButton.TabIndex = 3
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(555, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DepartmentListBox
        '
        Me.DepartmentListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DepartmentListBox.FormattingEnabled = True
        Me.DepartmentListBox.ItemHeight = 20
        Me.DepartmentListBox.Items.AddRange(New Object() {"BCA", "BBA", "BA"})
        Me.DepartmentListBox.Location = New System.Drawing.Point(359, 72)
        Me.DepartmentListBox.Name = "DepartmentListBox"
        Me.DepartmentListBox.Size = New System.Drawing.Size(150, 24)
        Me.DepartmentListBox.TabIndex = 5
        '
        'CourseYearListBox
        '
        Me.CourseYearListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CourseYearListBox.FormattingEnabled = True
        Me.CourseYearListBox.ItemHeight = 20
        Me.CourseYearListBox.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CourseYearListBox.Location = New System.Drawing.Point(359, 171)
        Me.CourseYearListBox.Name = "CourseYearListBox"
        Me.CourseYearListBox.Size = New System.Drawing.Size(150, 24)
        Me.CourseYearListBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(190, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "DEPARTMENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(186, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "COURSE YEAR"
        '
        'AdminMarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._4thsemproject.My.Resources.Resources.beautiful_color_gradients_backgrounds_165_morning_salad3
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CourseYearListBox)
        Me.Controls.Add(Me.DepartmentListBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.OkButton)
        Me.Name = "AdminMarks"
        Me.Text = "AdminMarks"
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
