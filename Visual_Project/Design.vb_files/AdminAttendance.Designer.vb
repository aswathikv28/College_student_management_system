<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminAttendance
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DepartmentListBox = New System.Windows.Forms.ListBox()
        Me.CourseYearListBox = New System.Windows.Forms.ListBox()
        Me.PresentDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OkButton
        '
        Me.OkButton.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.OkButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OkButton.Location = New System.Drawing.Point(112, 310)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(114, 38)
        Me.OkButton.TabIndex = 1
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(416, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DepartmentListBox
        '
        Me.DepartmentListBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DepartmentListBox.FormattingEnabled = True
        Me.DepartmentListBox.ItemHeight = 20
        Me.DepartmentListBox.Items.AddRange(New Object() {"BCA", "BBA", "BA"})
        Me.DepartmentListBox.Location = New System.Drawing.Point(352, 68)
        Me.DepartmentListBox.Name = "DepartmentListBox"
        Me.DepartmentListBox.Size = New System.Drawing.Size(150, 24)
        Me.DepartmentListBox.TabIndex = 4
        '
        'CourseYearListBox
        '
        Me.CourseYearListBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CourseYearListBox.FormattingEnabled = True
        Me.CourseYearListBox.ItemHeight = 20
        Me.CourseYearListBox.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CourseYearListBox.Location = New System.Drawing.Point(352, 144)
        Me.CourseYearListBox.Name = "CourseYearListBox"
        Me.CourseYearListBox.Size = New System.Drawing.Size(150, 24)
        Me.CourseYearListBox.TabIndex = 5
        '
        'PresentDatePicker
        '
        Me.PresentDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption
        Me.PresentDatePicker.Location = New System.Drawing.Point(352, 214)
        Me.PresentDatePicker.Name = "PresentDatePicker"
        Me.PresentDatePicker.Size = New System.Drawing.Size(159, 27)
        Me.PresentDatePicker.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(180, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "DEPARTMENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(178, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "COURSE YEAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(178, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "DATE"
        '
        'AdminAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImage = Global._4thsemproject.My.Resources.Resources.beautiful_color_gradients_backgrounds_165_morning_salad
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PresentDatePicker)
        Me.Controls.Add(Me.CourseYearListBox)
        Me.Controls.Add(Me.DepartmentListBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OkButton)
        Me.Name = "AdminAttendance"
        Me.Text = "AdminAttendance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OkButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DepartmentListBox As ListBox
    Friend WithEvents CourseYearListBox As ListBox
    Friend WithEvents PresentDatePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
