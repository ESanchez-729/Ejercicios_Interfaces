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
        Me.Lbl_Saludo = New System.Windows.Forms.Label()
        Me.Cmb_box_fuentes = New System.Windows.Forms.ComboBox()
        Me.Tb_tamFuente = New System.Windows.Forms.TrackBar()
        Me.GroupBox_estilos = New System.Windows.Forms.GroupBox()
        Me.Panel_Opciones = New System.Windows.Forms.Panel()
        Me.Chk_box_tachada = New System.Windows.Forms.CheckBox()
        Me.Chk_box_subrayada = New System.Windows.Forms.CheckBox()
        Me.Chk_box_inclinada = New System.Windows.Forms.CheckBox()
        Me.Chk_box_negrita = New System.Windows.Forms.CheckBox()
        Me.Chk_box_normal = New System.Windows.Forms.CheckBox()
        CType(Me.Tb_tamFuente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_estilos.SuspendLayout()
        Me.Panel_Opciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Saludo
        '
        Me.Lbl_Saludo.AutoSize = True
        Me.Lbl_Saludo.Location = New System.Drawing.Point(387, 105)
        Me.Lbl_Saludo.Name = "Lbl_Saludo"
        Me.Lbl_Saludo.Size = New System.Drawing.Size(32, 15)
        Me.Lbl_Saludo.TabIndex = 0
        Me.Lbl_Saludo.Text = "Hola"
        '
        'Cmb_box_fuentes
        '
        Me.Cmb_box_fuentes.FormattingEnabled = True
        Me.Cmb_box_fuentes.Location = New System.Drawing.Point(332, 238)
        Me.Cmb_box_fuentes.Name = "Cmb_box_fuentes"
        Me.Cmb_box_fuentes.Size = New System.Drawing.Size(200, 23)
        Me.Cmb_box_fuentes.TabIndex = 1
        '
        'Tb_tamFuente
        '
        Me.Tb_tamFuente.Location = New System.Drawing.Point(332, 175)
        Me.Tb_tamFuente.Maximum = 50
        Me.Tb_tamFuente.Minimum = 8
        Me.Tb_tamFuente.Name = "Tb_tamFuente"
        Me.Tb_tamFuente.Size = New System.Drawing.Size(200, 45)
        Me.Tb_tamFuente.TabIndex = 2
        Me.Tb_tamFuente.Value = 8
        '
        'GroupBox_estilos
        '
        Me.GroupBox_estilos.Controls.Add(Me.Panel_Opciones)
        Me.GroupBox_estilos.Controls.Add(Me.Chk_box_normal)
        Me.GroupBox_estilos.Location = New System.Drawing.Point(121, 105)
        Me.GroupBox_estilos.Name = "GroupBox_estilos"
        Me.GroupBox_estilos.Size = New System.Drawing.Size(158, 156)
        Me.GroupBox_estilos.TabIndex = 3
        Me.GroupBox_estilos.TabStop = False
        Me.GroupBox_estilos.Text = "Estilos"
        '
        'Panel_Opciones
        '
        Me.Panel_Opciones.Controls.Add(Me.Chk_box_tachada)
        Me.Panel_Opciones.Controls.Add(Me.Chk_box_subrayada)
        Me.Panel_Opciones.Controls.Add(Me.Chk_box_inclinada)
        Me.Panel_Opciones.Controls.Add(Me.Chk_box_negrita)
        Me.Panel_Opciones.Location = New System.Drawing.Point(7, 48)
        Me.Panel_Opciones.Name = "Panel_Opciones"
        Me.Panel_Opciones.Size = New System.Drawing.Size(122, 102)
        Me.Panel_Opciones.TabIndex = 1
        '
        'Chk_box_tachada
        '
        Me.Chk_box_tachada.AutoSize = True
        Me.Chk_box_tachada.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point)
        Me.Chk_box_tachada.Location = New System.Drawing.Point(0, 82)
        Me.Chk_box_tachada.Name = "Chk_box_tachada"
        Me.Chk_box_tachada.Size = New System.Drawing.Size(69, 19)
        Me.Chk_box_tachada.TabIndex = 3
        Me.Chk_box_tachada.Text = "Tachada"
        Me.Chk_box_tachada.UseVisualStyleBackColor = True
        '
        'Chk_box_subrayada
        '
        Me.Chk_box_subrayada.AutoSize = True
        Me.Chk_box_subrayada.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Chk_box_subrayada.Location = New System.Drawing.Point(0, 57)
        Me.Chk_box_subrayada.Name = "Chk_box_subrayada"
        Me.Chk_box_subrayada.Size = New System.Drawing.Size(81, 19)
        Me.Chk_box_subrayada.TabIndex = 2
        Me.Chk_box_subrayada.Text = "Subrayada"
        Me.Chk_box_subrayada.UseVisualStyleBackColor = True
        '
        'Chk_box_inclinada
        '
        Me.Chk_box_inclinada.AutoSize = True
        Me.Chk_box_inclinada.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Chk_box_inclinada.Location = New System.Drawing.Point(0, 32)
        Me.Chk_box_inclinada.Name = "Chk_box_inclinada"
        Me.Chk_box_inclinada.Size = New System.Drawing.Size(75, 19)
        Me.Chk_box_inclinada.TabIndex = 1
        Me.Chk_box_inclinada.Text = "Inclinada"
        Me.Chk_box_inclinada.UseVisualStyleBackColor = True
        '
        'Chk_box_negrita
        '
        Me.Chk_box_negrita.AutoSize = True
        Me.Chk_box_negrita.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Chk_box_negrita.Location = New System.Drawing.Point(0, 7)
        Me.Chk_box_negrita.Name = "Chk_box_negrita"
        Me.Chk_box_negrita.Size = New System.Drawing.Size(68, 19)
        Me.Chk_box_negrita.TabIndex = 0
        Me.Chk_box_negrita.Text = "Negrita"
        Me.Chk_box_negrita.UseVisualStyleBackColor = True
        '
        'Chk_box_normal
        '
        Me.Chk_box_normal.AutoSize = True
        Me.Chk_box_normal.Checked = True
        Me.Chk_box_normal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_box_normal.Location = New System.Drawing.Point(6, 23)
        Me.Chk_box_normal.Name = "Chk_box_normal"
        Me.Chk_box_normal.Size = New System.Drawing.Size(66, 19)
        Me.Chk_box_normal.TabIndex = 0
        Me.Chk_box_normal.Text = "Normal"
        Me.Chk_box_normal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 366)
        Me.Controls.Add(Me.GroupBox_estilos)
        Me.Controls.Add(Me.Tb_tamFuente)
        Me.Controls.Add(Me.Cmb_box_fuentes)
        Me.Controls.Add(Me.Lbl_Saludo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Tb_tamFuente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_estilos.ResumeLayout(False)
        Me.GroupBox_estilos.PerformLayout()
        Me.Panel_Opciones.ResumeLayout(False)
        Me.Panel_Opciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Saludo As Label
    Friend WithEvents Cmb_box_fuentes As ComboBox
    Friend WithEvents Tb_tamFuente As TrackBar
    Friend WithEvents GroupBox_estilos As GroupBox
    Friend WithEvents Panel_Opciones As Panel
    Friend WithEvents Chk_box_tachada As CheckBox
    Friend WithEvents Chk_box_subrayada As CheckBox
    Friend WithEvents Chk_box_inclinada As CheckBox
    Friend WithEvents Chk_box_negrita As CheckBox
    Friend WithEvents Chk_box_normal As CheckBox
End Class
