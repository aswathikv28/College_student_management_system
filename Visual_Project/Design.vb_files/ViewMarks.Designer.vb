﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewMarks
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
        Me.MarksDataGrid = New System.Windows.Forms.DataGridView()
        Me.OkButton = New System.Windows.Forms.Button()
        CType(Me.MarksDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MarksDataGrid
        '
        Me.MarksDataGrid.BackgroundColor = System.Drawing.Color.Linen
        Me.MarksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MarksDataGrid.Location = New System.Drawing.Point(236, 99)
        Me.MarksDataGrid.Name = "MarksDataGrid"
        Me.MarksDataGrid.RowHeadersWidth = 51
        Me.MarksDataGrid.Size = New System.Drawing.Size(300, 188)
        Me.MarksDataGrid.TabIndex = 0
        '
        'OkButton
        '
        Me.OkButton.BackColor = System.Drawing.Color.SeaShell
        Me.OkButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OkButton.Location = New System.Drawing.Point(326, 341)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(94, 35)
        Me.OkButton.TabIndex = 1
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = False
        '
        'ViewMarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._4thsemproject.My.Resources.Resources.studn
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.MarksDataGrid)
        Me.Name = "ViewMarks"
        Me.Text = "ViewMarks"
        CType(Me.MarksDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MarksDataGrid As DataGridView
    Friend WithEvents OkButton As Button
End Class
