<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPayment
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
        Me.FeeDataGrid = New System.Windows.Forms.DataGridView()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.PayButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CardPayButton = New System.Windows.Forms.Button()
        CType(Me.FeeDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FeeDataGrid
        '
        Me.FeeDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.FeeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FeeDataGrid.Location = New System.Drawing.Point(232, 83)
        Me.FeeDataGrid.Name = "FeeDataGrid"
        Me.FeeDataGrid.ReadOnly = True
        Me.FeeDataGrid.RowHeadersWidth = 51
        Me.FeeDataGrid.RowTemplate.Height = 29
        Me.FeeDataGrid.Size = New System.Drawing.Size(424, 188)
        Me.FeeDataGrid.TabIndex = 0
        '
        'OkButton
        '
        Me.OkButton.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.OkButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OkButton.Location = New System.Drawing.Point(178, 341)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(94, 39)
        Me.OkButton.TabIndex = 1
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = False
        '
        'PayButton
        '
        Me.PayButton.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.PayButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PayButton.Location = New System.Drawing.Point(325, 341)
        Me.PayButton.Name = "PayButton"
        Me.PayButton.Size = New System.Drawing.Size(94, 39)
        Me.PayButton.TabIndex = 2
        Me.PayButton.Text = "UPI"
        Me.PayButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(621, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 39)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CardPayButton
        '
        Me.CardPayButton.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CardPayButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CardPayButton.Location = New System.Drawing.Point(463, 341)
        Me.CardPayButton.Name = "CardPayButton"
        Me.CardPayButton.Size = New System.Drawing.Size(94, 39)
        Me.CardPayButton.TabIndex = 4
        Me.CardPayButton.Text = "Card"
        Me.CardPayButton.UseVisualStyleBackColor = False
        '
        'AdminPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._4thsemproject.My.Resources.Resources.beautiful_color_gradients_backgrounds_165_morning_salad4
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CardPayButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PayButton)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.FeeDataGrid)
        Me.Name = "AdminPayment"
        Me.Text = "AdminPayment"
        CType(Me.FeeDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FeeDataGrid As DataGridView
    Friend WithEvents OkButton As Button
    Friend WithEvents PayButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CardPayButton As Button
End Class
