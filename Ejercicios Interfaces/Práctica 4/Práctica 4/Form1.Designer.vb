<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ListBox_color = New System.Windows.Forms.ListBox()
        Me.TextBox_color = New System.Windows.Forms.TextBox()
        Me.Btn_color = New System.Windows.Forms.Button()
        Me.Btn_marca = New System.Windows.Forms.Button()
        Me.TextBox_marca = New System.Windows.Forms.TextBox()
        Me.ListBox_marcas = New System.Windows.Forms.ListBox()
        Me.Btn_modelo = New System.Windows.Forms.Button()
        Me.TextBox_modelo = New System.Windows.Forms.TextBox()
        Me.ListBox_modelo = New System.Windows.Forms.ListBox()
        Me.Btn_color2 = New System.Windows.Forms.Button()
        Me.Btn_marca2 = New System.Windows.Forms.Button()
        Me.Btn_modelo2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox_color
        '
        Me.ListBox_color.FormattingEnabled = True
        Me.ListBox_color.ItemHeight = 15
        Me.ListBox_color.Location = New System.Drawing.Point(174, 123)
        Me.ListBox_color.Name = "ListBox_color"
        Me.ListBox_color.Size = New System.Drawing.Size(120, 94)
        Me.ListBox_color.TabIndex = 0
        '
        'TextBox_color
        '
        Me.TextBox_color.Location = New System.Drawing.Point(174, 238)
        Me.TextBox_color.Name = "TextBox_color"
        Me.TextBox_color.Size = New System.Drawing.Size(120, 23)
        Me.TextBox_color.TabIndex = 1
        '
        'Btn_color
        '
        Me.Btn_color.Location = New System.Drawing.Point(174, 282)
        Me.Btn_color.Name = "Btn_color"
        Me.Btn_color.Size = New System.Drawing.Size(120, 23)
        Me.Btn_color.TabIndex = 2
        Me.Btn_color.Text = "Añadir color"
        Me.Btn_color.UseVisualStyleBackColor = True
        '
        'Btn_marca
        '
        Me.Btn_marca.Location = New System.Drawing.Point(336, 282)
        Me.Btn_marca.Name = "Btn_marca"
        Me.Btn_marca.Size = New System.Drawing.Size(120, 23)
        Me.Btn_marca.TabIndex = 5
        Me.Btn_marca.Text = "Añadir marca"
        Me.Btn_marca.UseVisualStyleBackColor = True
        '
        'TextBox_marca
        '
        Me.TextBox_marca.Location = New System.Drawing.Point(336, 238)
        Me.TextBox_marca.Name = "TextBox_marca"
        Me.TextBox_marca.Size = New System.Drawing.Size(120, 23)
        Me.TextBox_marca.TabIndex = 4
        '
        'ListBox_marcas
        '
        Me.ListBox_marcas.FormattingEnabled = True
        Me.ListBox_marcas.ItemHeight = 15
        Me.ListBox_marcas.Location = New System.Drawing.Point(336, 123)
        Me.ListBox_marcas.Name = "ListBox_marcas"
        Me.ListBox_marcas.Size = New System.Drawing.Size(120, 94)
        Me.ListBox_marcas.TabIndex = 3
        '
        'Btn_modelo
        '
        Me.Btn_modelo.Location = New System.Drawing.Point(499, 282)
        Me.Btn_modelo.Name = "Btn_modelo"
        Me.Btn_modelo.Size = New System.Drawing.Size(120, 23)
        Me.Btn_modelo.TabIndex = 8
        Me.Btn_modelo.Text = "Añadir modelo"
        Me.Btn_modelo.UseVisualStyleBackColor = True
        '
        'TextBox_modelo
        '
        Me.TextBox_modelo.Location = New System.Drawing.Point(499, 238)
        Me.TextBox_modelo.Name = "TextBox_modelo"
        Me.TextBox_modelo.Size = New System.Drawing.Size(120, 23)
        Me.TextBox_modelo.TabIndex = 7
        '
        'ListBox_modelo
        '
        Me.ListBox_modelo.FormattingEnabled = True
        Me.ListBox_modelo.ItemHeight = 15
        Me.ListBox_modelo.Location = New System.Drawing.Point(499, 123)
        Me.ListBox_modelo.Name = "ListBox_modelo"
        Me.ListBox_modelo.Size = New System.Drawing.Size(120, 94)
        Me.ListBox_modelo.TabIndex = 6
        '
        'Btn_color2
        '
        Me.Btn_color2.Location = New System.Drawing.Point(174, 311)
        Me.Btn_color2.Name = "Btn_color2"
        Me.Btn_color2.Size = New System.Drawing.Size(120, 23)
        Me.Btn_color2.TabIndex = 9
        Me.Btn_color2.Text = "Eliminar color"
        Me.Btn_color2.UseVisualStyleBackColor = True
        '
        'Btn_marca2
        '
        Me.Btn_marca2.Location = New System.Drawing.Point(336, 311)
        Me.Btn_marca2.Name = "Btn_marca2"
        Me.Btn_marca2.Size = New System.Drawing.Size(120, 23)
        Me.Btn_marca2.TabIndex = 10
        Me.Btn_marca2.Text = "Eliminar marca"
        Me.Btn_marca2.UseVisualStyleBackColor = True
        '
        'Btn_modelo2
        '
        Me.Btn_modelo2.Location = New System.Drawing.Point(499, 311)
        Me.Btn_modelo2.Name = "Btn_modelo2"
        Me.Btn_modelo2.Size = New System.Drawing.Size(120, 23)
        Me.Btn_modelo2.TabIndex = 11
        Me.Btn_modelo2.Text = "Eliminar modelo"
        Me.Btn_modelo2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_modelo2)
        Me.Controls.Add(Me.Btn_marca2)
        Me.Controls.Add(Me.Btn_color2)
        Me.Controls.Add(Me.Btn_modelo)
        Me.Controls.Add(Me.TextBox_modelo)
        Me.Controls.Add(Me.ListBox_modelo)
        Me.Controls.Add(Me.Btn_marca)
        Me.Controls.Add(Me.TextBox_marca)
        Me.Controls.Add(Me.ListBox_marcas)
        Me.Controls.Add(Me.Btn_color)
        Me.Controls.Add(Me.TextBox_color)
        Me.Controls.Add(Me.ListBox_color)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox_color As ListBox
    Friend WithEvents TextBox_color As TextBox
    Friend WithEvents Btn_color As Button
    Friend WithEvents Btn_marca As Button
    Friend WithEvents TextBox_marca As TextBox
    Friend WithEvents ListBox_marcas As ListBox
    Friend WithEvents Btn_modelo As Button
    Friend WithEvents TextBox_modelo As TextBox
    Friend WithEvents ListBox_modelo As ListBox
    Friend WithEvents Btn_color2 As Button
    Friend WithEvents Btn_marca2 As Button
    Friend WithEvents Btn_modelo2 As Button
End Class
