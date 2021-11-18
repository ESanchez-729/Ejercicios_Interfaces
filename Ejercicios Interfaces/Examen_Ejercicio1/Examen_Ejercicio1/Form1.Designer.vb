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
        Me.TB_Fuentes = New System.Windows.Forms.TrackBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CB_Fuentes = New System.Windows.Forms.ComboBox()
        Me.Lbl_Fuentes = New System.Windows.Forms.Label()
        Me.Btn_colores = New System.Windows.Forms.Button()
        Me.Rbtn_fuente = New System.Windows.Forms.RadioButton()
        Me.Rbtn_fondo = New System.Windows.Forms.RadioButton()
        Me.GB_colores = New System.Windows.Forms.GroupBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GB_opciones = New System.Windows.Forms.GroupBox()
        CType(Me.TB_Fuentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_colores.SuspendLayout()
        Me.GB_opciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'TB_Fuentes
        '
        Me.TB_Fuentes.Location = New System.Drawing.Point(29, 46)
        Me.TB_Fuentes.Maximum = 50
        Me.TB_Fuentes.Minimum = 8
        Me.TB_Fuentes.Name = "TB_Fuentes"
        Me.TB_Fuentes.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TB_Fuentes.Size = New System.Drawing.Size(45, 383)
        Me.TB_Fuentes.TabIndex = 0
        Me.TB_Fuentes.Value = 8
        '
        'CB_Fuentes
        '
        Me.CB_Fuentes.FormattingEnabled = True
        Me.CB_Fuentes.Location = New System.Drawing.Point(81, 434)
        Me.CB_Fuentes.Name = "CB_Fuentes"
        Me.CB_Fuentes.Size = New System.Drawing.Size(273, 21)
        Me.CB_Fuentes.TabIndex = 1
        '
        'Lbl_Fuentes
        '
        Me.Lbl_Fuentes.AutoSize = True
        Me.Lbl_Fuentes.Location = New System.Drawing.Point(106, 211)
        Me.Lbl_Fuentes.Name = "Lbl_Fuentes"
        Me.Lbl_Fuentes.Size = New System.Drawing.Size(27, 13)
        Me.Lbl_Fuentes.TabIndex = 2
        Me.Lbl_Fuentes.Text = "hola"
        '
        'Btn_colores
        '
        Me.Btn_colores.Location = New System.Drawing.Point(477, 57)
        Me.Btn_colores.Name = "Btn_colores"
        Me.Btn_colores.Size = New System.Drawing.Size(179, 23)
        Me.Btn_colores.TabIndex = 3
        Me.Btn_colores.Text = "Cambiar colores"
        Me.Btn_colores.UseVisualStyleBackColor = True
        '
        'Rbtn_fuente
        '
        Me.Rbtn_fuente.AutoSize = True
        Me.Rbtn_fuente.Checked = True
        Me.Rbtn_fuente.Location = New System.Drawing.Point(26, 24)
        Me.Rbtn_fuente.Name = "Rbtn_fuente"
        Me.Rbtn_fuente.Size = New System.Drawing.Size(58, 17)
        Me.Rbtn_fuente.TabIndex = 4
        Me.Rbtn_fuente.TabStop = True
        Me.Rbtn_fuente.Text = "Fuente"
        Me.Rbtn_fuente.UseVisualStyleBackColor = True
        '
        'Rbtn_fondo
        '
        Me.Rbtn_fondo.AutoSize = True
        Me.Rbtn_fondo.Location = New System.Drawing.Point(26, 47)
        Me.Rbtn_fondo.Name = "Rbtn_fondo"
        Me.Rbtn_fondo.Size = New System.Drawing.Size(55, 17)
        Me.Rbtn_fondo.TabIndex = 5
        Me.Rbtn_fondo.TabStop = True
        Me.Rbtn_fondo.Text = "Fondo"
        Me.Rbtn_fondo.UseVisualStyleBackColor = True
        '
        'GB_colores
        '
        Me.GB_colores.Controls.Add(Me.Panel7)
        Me.GB_colores.Controls.Add(Me.Panel6)
        Me.GB_colores.Controls.Add(Me.Panel8)
        Me.GB_colores.Controls.Add(Me.Panel5)
        Me.GB_colores.Controls.Add(Me.Panel9)
        Me.GB_colores.Controls.Add(Me.Panel4)
        Me.GB_colores.Controls.Add(Me.Panel10)
        Me.GB_colores.Controls.Add(Me.Panel3)
        Me.GB_colores.Controls.Add(Me.Panel11)
        Me.GB_colores.Controls.Add(Me.Panel2)
        Me.GB_colores.Controls.Add(Me.Panel12)
        Me.GB_colores.Controls.Add(Me.Panel1)
        Me.GB_colores.Location = New System.Drawing.Point(456, 121)
        Me.GB_colores.Name = "GB_colores"
        Me.GB_colores.Size = New System.Drawing.Size(395, 343)
        Me.GB_colores.TabIndex = 6
        Me.GB_colores.TabStop = False
        Me.GB_colores.Text = "Colores"
        '
        'Panel7
        '
        Me.Panel7.Location = New System.Drawing.Point(271, 259)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(99, 57)
        Me.Panel7.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(271, 106)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(99, 57)
        Me.Panel6.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.Location = New System.Drawing.Point(148, 259)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(99, 57)
        Me.Panel8.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(148, 106)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(99, 57)
        Me.Panel5.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.Location = New System.Drawing.Point(21, 259)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(99, 57)
        Me.Panel9.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(21, 106)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(99, 57)
        Me.Panel4.TabIndex = 1
        '
        'Panel10
        '
        Me.Panel10.Location = New System.Drawing.Point(271, 181)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(99, 57)
        Me.Panel10.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(271, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(99, 57)
        Me.Panel3.TabIndex = 1
        '
        'Panel11
        '
        Me.Panel11.Location = New System.Drawing.Point(148, 181)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(99, 57)
        Me.Panel11.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(148, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(99, 57)
        Me.Panel2.TabIndex = 1
        '
        'Panel12
        '
        Me.Panel12.Location = New System.Drawing.Point(21, 181)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(99, 57)
        Me.Panel12.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(21, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(99, 57)
        Me.Panel1.TabIndex = 0
        '
        'GB_opciones
        '
        Me.GB_opciones.Controls.Add(Me.Rbtn_fuente)
        Me.GB_opciones.Controls.Add(Me.Rbtn_fondo)
        Me.GB_opciones.Location = New System.Drawing.Point(710, 36)
        Me.GB_opciones.Name = "GB_opciones"
        Me.GB_opciones.Size = New System.Drawing.Size(141, 77)
        Me.GB_opciones.TabIndex = 7
        Me.GB_opciones.TabStop = False
        Me.GB_opciones.Text = "Opciones"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 518)
        Me.Controls.Add(Me.GB_opciones)
        Me.Controls.Add(Me.GB_colores)
        Me.Controls.Add(Me.Btn_colores)
        Me.Controls.Add(Me.Lbl_Fuentes)
        Me.Controls.Add(Me.CB_Fuentes)
        Me.Controls.Add(Me.TB_Fuentes)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TB_Fuentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_colores.ResumeLayout(False)
        Me.GB_opciones.ResumeLayout(False)
        Me.GB_opciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_Fuentes As TrackBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CB_Fuentes As ComboBox
    Friend WithEvents Lbl_Fuentes As Label
    Friend WithEvents Btn_colores As Button
    Friend WithEvents Rbtn_fuente As RadioButton
    Friend WithEvents Rbtn_fondo As RadioButton
    Friend WithEvents GB_colores As GroupBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GB_opciones As GroupBox
End Class
