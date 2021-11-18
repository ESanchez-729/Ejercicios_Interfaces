<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarHijosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_texto = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_imagen = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_cerrarActual = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_cerrarTodo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.exit_app = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanasHijosChildsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_info = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSB_texto = New System.Windows.Forms.ToolStripButton()
        Me.TSB_imagen = New System.Windows.Forms.ToolStripButton()
        Me.TSB_cerrar = New System.Windows.Forms.ToolStripButton()
        Me.TSB_info = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrincipalToolStripMenuItem, Me.VentanasHijosChildsToolStripMenuItem, Me.TSM_info})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.VentanasHijosChildsToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrincipalToolStripMenuItem
        '
        Me.PrincipalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarHijosToolStripMenuItem, Me.TSM_cerrarActual, Me.TSM_cerrarTodo, Me.ToolStripMenuItem1, Me.exit_app})
        Me.PrincipalToolStripMenuItem.Name = "PrincipalToolStripMenuItem"
        Me.PrincipalToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.PrincipalToolStripMenuItem.Text = "Principal"
        '
        'CargarHijosToolStripMenuItem
        '
        Me.CargarHijosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_texto, Me.TSM_imagen})
        Me.CargarHijosToolStripMenuItem.Name = "CargarHijosToolStripMenuItem"
        Me.CargarHijosToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.CargarHijosToolStripMenuItem.Text = "Cargar Hijos"
        '
        'TSM_texto
        '
        Me.TSM_texto.Image = CType(resources.GetObject("TSM_texto.Image"), System.Drawing.Image)
        Me.TSM_texto.Name = "TSM_texto"
        Me.TSM_texto.Size = New System.Drawing.Size(114, 22)
        Me.TSM_texto.Text = "Texto"
        '
        'TSM_imagen
        '
        Me.TSM_imagen.Image = CType(resources.GetObject("TSM_imagen.Image"), System.Drawing.Image)
        Me.TSM_imagen.Name = "TSM_imagen"
        Me.TSM_imagen.Size = New System.Drawing.Size(114, 22)
        Me.TSM_imagen.Text = "Imagen"
        '
        'TSM_cerrarActual
        '
        Me.TSM_cerrarActual.Name = "TSM_cerrarActual"
        Me.TSM_cerrarActual.Size = New System.Drawing.Size(205, 22)
        Me.TSM_cerrarActual.Text = "Cerrar ventana actual"
        '
        'TSM_cerrarTodo
        '
        Me.TSM_cerrarTodo.Name = "TSM_cerrarTodo"
        Me.TSM_cerrarTodo.Size = New System.Drawing.Size(205, 22)
        Me.TSM_cerrarTodo.Text = "Cerrar todas las ventanas"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(202, 6)
        '
        'exit_app
        '
        Me.exit_app.Name = "exit_app"
        Me.exit_app.Size = New System.Drawing.Size(205, 22)
        Me.exit_app.Text = "Salir de la aplicación"
        '
        'VentanasHijosChildsToolStripMenuItem
        '
        Me.VentanasHijosChildsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.VerticalToolStripMenuItem, Me.HorizontalToolStripMenuItem})
        Me.VentanasHijosChildsToolStripMenuItem.Name = "VentanasHijosChildsToolStripMenuItem"
        Me.VentanasHijosChildsToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.VentanasHijosChildsToolStripMenuItem.Text = "Ventanas Hijos (Childs)"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.CascadeToolStripMenuItem.Text = "Cascade"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.VerticalToolStripMenuItem.Text = "Vertical"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'TSM_info
        '
        Me.TSM_info.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TSM_info.Name = "TSM_info"
        Me.TSM_info.Size = New System.Drawing.Size(24, 20)
        Me.TSM_info.Text = "?"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSB_texto, Me.TSB_imagen, Me.TSB_cerrar, Me.TSB_info})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 27)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSB_texto
        '
        Me.TSB_texto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_texto.Image = CType(resources.GetObject("TSB_texto.Image"), System.Drawing.Image)
        Me.TSB_texto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_texto.Name = "TSB_texto"
        Me.TSB_texto.Size = New System.Drawing.Size(24, 24)
        Me.TSB_texto.Text = "Abrir texto"
        '
        'TSB_imagen
        '
        Me.TSB_imagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_imagen.Image = CType(resources.GetObject("TSB_imagen.Image"), System.Drawing.Image)
        Me.TSB_imagen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_imagen.Name = "TSB_imagen"
        Me.TSB_imagen.Size = New System.Drawing.Size(24, 24)
        Me.TSB_imagen.Text = "Abrir imagen"
        '
        'TSB_cerrar
        '
        Me.TSB_cerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_cerrar.Image = CType(resources.GetObject("TSB_cerrar.Image"), System.Drawing.Image)
        Me.TSB_cerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_cerrar.Name = "TSB_cerrar"
        Me.TSB_cerrar.Size = New System.Drawing.Size(24, 24)
        Me.TSB_cerrar.Text = "Cerrar ventanas"
        '
        'TSB_info
        '
        Me.TSB_info.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TSB_info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_info.Image = CType(resources.GetObject("TSB_info.Image"), System.Drawing.Image)
        Me.TSB_info.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_info.Name = "TSB_info"
        Me.TSB_info.Size = New System.Drawing.Size(24, 24)
        Me.TSB_info.Text = "Acerca de ..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Formulario MDI"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarHijosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSM_texto As ToolStripMenuItem
    Friend WithEvents TSM_imagen As ToolStripMenuItem
    Friend WithEvents TSM_cerrarActual As ToolStripMenuItem
    Friend WithEvents TSM_cerrarTodo As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents exit_app As ToolStripMenuItem
    Friend WithEvents VentanasHijosChildsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSM_info As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSB_texto As ToolStripButton
    Friend WithEvents TSB_imagen As ToolStripButton
    Friend WithEvents TSB_cerrar As ToolStripButton
    Friend WithEvents TSB_info As ToolStripButton
End Class
