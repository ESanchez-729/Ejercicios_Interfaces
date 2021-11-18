<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTexto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.CMS_options = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSM_borrarTexto = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_insertarTexto = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS_options.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.ContextMenuStrip = Me.CMS_options
        Me.RichTextBox1.Location = New System.Drawing.Point(1, -1)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(799, 451)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'CMS_options
        '
        Me.CMS_options.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_borrarTexto, Me.TSM_insertarTexto})
        Me.CMS_options.Name = "CMS_options"
        Me.CMS_options.Size = New System.Drawing.Size(219, 70)
        '
        'TSM_borrarTexto
        '
        Me.TSM_borrarTexto.Name = "TSM_borrarTexto"
        Me.TSM_borrarTexto.Size = New System.Drawing.Size(218, 22)
        Me.TSM_borrarTexto.Text = "Borrar todo"
        '
        'TSM_insertarTexto
        '
        Me.TSM_insertarTexto.Name = "TSM_insertarTexto"
        Me.TSM_insertarTexto.Size = New System.Drawing.Size(218, 22)
        Me.TSM_insertarTexto.Text = "Insertar desde portapapeles"
        '
        'FormTexto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 308)
        Me.ContextMenuStrip = Me.CMS_options
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "FormTexto"
        Me.Text = "Formulario hijo para texto RTF"
        Me.CMS_options.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents CMS_options As ContextMenuStrip
    Friend WithEvents TSM_borrarTexto As ToolStripMenuItem
    Friend WithEvents TSM_insertarTexto As ToolStripMenuItem
End Class
