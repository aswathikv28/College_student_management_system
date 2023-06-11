<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewProfile
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
        Me.ProfileDataGrid = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        CType(Me.ProfileDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProfileDataGrid
        '
        Me.ProfileDataGrid.BackgroundColor = System.Drawing.Color.Linen
        Me.ProfileDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProfileDataGrid.Location = New System.Drawing.Point(12, 90)
        Me.ProfileDataGrid.Name = "ProfileDataGrid"
        Me.ProfileDataGrid.RowHeadersWidth = 51
        Me.ProfileDataGrid.RowTemplate.Height = 29
        Me.ProfileDataGrid.Size = New System.Drawing.Size(776, 269)
        Me.ProfileDataGrid.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaShell
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(221, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.SeaShell
        Me.UpdateButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UpdateButton.Location = New System.Drawing.Point(468, 389)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(94, 38)
        Me.UpdateButton.TabIndex = 2
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'ViewProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._4thsemproject.My.Resources.Resources.studn
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProfileDataGrid)
        Me.Name = "ViewProfile"
        Me.Text = "ViewProfile"
        CType(Me.ProfileDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProfileDataGrid As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents UpdateButton As Button
End Class
