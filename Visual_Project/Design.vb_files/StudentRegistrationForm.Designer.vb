<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentRegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentRegistrationForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FirstName = New System.Windows.Forms.Label()
        Me.LastName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.StudentID = New System.Windows.Forms.Label()
        Me.Dept = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.ConfirmPassword = New System.Windows.Forms.Label()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDept = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DOBPicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.CourseYearListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(542, 471)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.BackColor = System.Drawing.Color.Transparent
        Me.FirstName.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.FirstName.Location = New System.Drawing.Point(299, 129)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(119, 26)
        Me.FirstName.TabIndex = 1
        Me.FirstName.Text = "First Name"
        '
        'LastName
        '
        Me.LastName.AutoSize = True
        Me.LastName.BackColor = System.Drawing.Color.Transparent
        Me.LastName.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.LastName.Location = New System.Drawing.Point(299, 232)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(116, 26)
        Me.LastName.TabIndex = 2
        Me.LastName.Text = "Last Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(428, 132)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(125, 27)
        Me.txtFirstName.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(428, 228)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(125, 27)
        Me.txtLastName.TabIndex = 4
        '
        'StudentID
        '
        Me.StudentID.AutoSize = True
        Me.StudentID.BackColor = System.Drawing.Color.Transparent
        Me.StudentID.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.StudentID.Location = New System.Drawing.Point(290, 330)
        Me.StudentID.Name = "StudentID"
        Me.StudentID.Size = New System.Drawing.Size(116, 26)
        Me.StudentID.TabIndex = 5
        Me.StudentID.Text = "Student ID"
        '
        'Dept
        '
        Me.Dept.AutoSize = True
        Me.Dept.BackColor = System.Drawing.Color.Transparent
        Me.Dept.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Dept.Location = New System.Drawing.Point(941, 136)
        Me.Dept.Name = "Dept"
        Me.Dept.Size = New System.Drawing.Size(124, 26)
        Me.Dept.TabIndex = 6
        Me.Dept.Text = "Department"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.BackColor = System.Drawing.Color.Transparent
        Me.Password.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Password.Location = New System.Drawing.Point(941, 231)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(104, 26)
        Me.Password.TabIndex = 7
        Me.Password.Text = "Password"
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.AutoSize = True
        Me.ConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.ConfirmPassword.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ConfirmPassword.Location = New System.Drawing.Point(941, 332)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.Size = New System.Drawing.Size(190, 26)
        Me.ConfirmPassword.TabIndex = 8
        Me.ConfirmPassword.Text = "Confirm Password"
        '
        'txtStudentId
        '
        Me.txtStudentId.Location = New System.Drawing.Point(428, 330)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(125, 27)
        Me.txtStudentId.TabIndex = 9
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(1137, 229)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(125, 27)
        Me.txtPassword.TabIndex = 11
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(1137, 332)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(125, 27)
        Me.txtConfirmPassword.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(903, 471)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 44)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(598, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 45)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "REGISTRATION FORM"
        '
        'txtDept
        '
        Me.txtDept.FormattingEnabled = True
        Me.txtDept.ItemHeight = 20
        Me.txtDept.Items.AddRange(New Object() {"BCA", "BBA", "BA"})
        Me.txtDept.Location = New System.Drawing.Point(1137, 138)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(125, 24)
        Me.txtDept.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(613, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 26)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Course Year"
        '
        'DOBPicker
        '
        Me.DOBPicker.Location = New System.Drawing.Point(757, 225)
        Me.DOBPicker.Name = "DOBPicker"
        Me.DOBPicker.Size = New System.Drawing.Size(115, 27)
        Me.DOBPicker.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(613, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 26)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Date of birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(613, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 26)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "E-mail"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(757, 326)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(125, 27)
        Me.EmailTextBox.TabIndex = 21
        '
        'CourseYearListBox
        '
        Me.CourseYearListBox.FormattingEnabled = True
        Me.CourseYearListBox.ItemHeight = 20
        Me.CourseYearListBox.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CourseYearListBox.Location = New System.Drawing.Point(757, 129)
        Me.CourseYearListBox.Name = "CourseYearListBox"
        Me.CourseYearListBox.Size = New System.Drawing.Size(115, 24)
        Me.CourseYearListBox.TabIndex = 22
        '
        'StudentRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1585, 645)
        Me.Controls.Add(Me.CourseYearListBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DOBPicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtStudentId)
        Me.Controls.Add(Me.ConfirmPassword)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Dept)
        Me.Controls.Add(Me.StudentID)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Name = "StudentRegistrationForm"
        Me.Text = "StudentRegistrationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents FirstName As Label
    Friend WithEvents LastName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents StudentID As Label
    Friend WithEvents Dept As Label
    Friend WithEvents Password As Label
    Friend WithEvents ConfirmPassword As Label
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDept As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DOBPicker As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents CourseYearListBox As ListBox
End Class
