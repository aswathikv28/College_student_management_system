<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminProfile
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StudentIDComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentListBox = New System.Windows.Forms.ListBox()
        Me.CourseYearListBox = New System.Windows.Forms.ListBox()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OkButton
        '
        Me.OkButton.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.OkButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OkButton.Location = New System.Drawing.Point(198, 318)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(94, 42)
        Me.OkButton.TabIndex = 1
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(147, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "STUDENT ID"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(442, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 42)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'StudentIDComboBox
        '
        Me.StudentIDComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StudentIDComboBox.FormattingEnabled = True
        Me.StudentIDComboBox.Location = New System.Drawing.Point(306, 210)
        Me.StudentIDComboBox.Name = "StudentIDComboBox"
        Me.StudentIDComboBox.Size = New System.Drawing.Size(151, 28)
        Me.StudentIDComboBox.TabIndex = 5
        '
        'DepartmentListBox
        '
        Me.DepartmentListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DepartmentListBox.FormattingEnabled = True
        Me.DepartmentListBox.ItemHeight = 20
        Me.DepartmentListBox.Items.AddRange(New Object() {"BCA", "BBA", "BA"})
        Me.DepartmentListBox.Location = New System.Drawing.Point(307, 64)
        Me.DepartmentListBox.Name = "DepartmentListBox"
        Me.DepartmentListBox.Size = New System.Drawing.Size(150, 24)
        Me.DepartmentListBox.TabIndex = 6
        '
        'CourseYearListBox
        '
        Me.CourseYearListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CourseYearListBox.FormattingEnabled = True
        Me.CourseYearListBox.ItemHeight = 20
        Me.CourseYearListBox.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CourseYearListBox.Location = New System.Drawing.Point(306, 137)
        Me.CourseYearListBox.Name = "CourseYearListBox"
        Me.CourseYearListBox.Size = New System.Drawing.Size(150, 24)
        Me.CourseYearListBox.TabIndex = 7
        '
        'LoadButton
        '
        Me.LoadButton.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LoadButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LoadButton.Location = New System.Drawing.Point(469, 209)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(94, 29)
        Me.LoadButton.TabIndex = 8
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(147, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "DEPT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(147, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "COURSE YEAR"
        '
        'AdminProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._4thsemproject.My.Resources.Resources.beautiful_color_gradients_backgrounds_165_morning_salad6
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.CourseYearListBox)
        Me.Controls.Add(Me.DepartmentListBox)
        Me.Controls.Add(Me.StudentIDComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OkButton)
        Me.Name = "AdminProfile"
        Me.Text = "AdminProfile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OkButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents StudentIDComboBox As ComboBox
    Friend WithEvents DepartmentListBox As ListBox
    Friend WithEvents CourseYearListBox As ListBox
    Friend WithEvents LoadButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
