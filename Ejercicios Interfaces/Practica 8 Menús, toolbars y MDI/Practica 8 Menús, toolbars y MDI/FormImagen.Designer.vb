<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImagen
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CMS_options2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BorrarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarDesdePortapapelesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMS_options2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ContextMenuStrip = Me.CMS_options2
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(799, 449)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CMS_options2
        '
        Me.CMS_options2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarTodoToolStripMenuItem, Me.InsertarDesdePortapapelesToolStripMenuItem})
        Me.CMS_options2.Name = "CMS_options2"
        Me.CMS_options2.Size = New System.Drawing.Size(219, 48)
        '
        'BorrarTodoToolStripMenuItem
        '
        Me.BorrarTodoToolStripMenuItem.Name = "BorrarTodoToolStripMenuItem"
        Me.BorrarTodoToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.BorrarTodoToolStripMenuItem.Text = "Borrar todo"
        '
        'InsertarDesdePortapapelesToolStripMenuItem
        '
        Me.InsertarDesdePortapapelesToolStripMenuItem.Name = "InsertarDesdePortapapelesToolStripMenuItem"
        Me.InsertarDesdePortapapelesToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.InsertarDesdePortapapelesToolStripMenuItem.Text = "Insertar desde portapapeles"
        '
        'FormImagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 310)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormImagen"
        Me.Text = "Formulario hijo para imagen BMP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMS_options2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CMS_options2 As ContextMenuStrip
    Friend WithEvents BorrarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertarDesdePortapapelesToolStripMenuItem As ToolStripMenuItem
End Class
