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
        Me.LB_productos = New System.Windows.Forms.ListBox()
        Me.LB_productos_comprados = New System.Windows.Forms.ListBox()
        Me.Btn_productos = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox_productos = New System.Windows.Forms.TextBox()
        Me.TextBox_precio = New System.Windows.Forms.TextBox()
        Me.GB_opciones = New System.Windows.Forms.GroupBox()
        Me.Rbtn_ninguno = New System.Windows.Forms.RadioButton()
        Me.Panel_apps = New System.Windows.Forms.Panel()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GB_opciones.SuspendLayout()
        Me.Panel_apps.SuspendLayout()
        Me.SuspendLayout()
        '
        'LB_productos
        '
        Me.LB_productos.Enabled = False
        Me.LB_productos.FormattingEnabled = True
        Me.LB_productos.Location = New System.Drawing.Point(309, 34)
        Me.LB_productos.Name = "LB_productos"
        Me.LB_productos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.LB_productos.Size = New System.Drawing.Size(272, 433)
        Me.LB_productos.TabIndex = 0
        '
        'LB_productos_comprados
        '
        Me.LB_productos_comprados.Enabled = False
        Me.LB_productos_comprados.FormattingEnabled = True
        Me.LB_productos_comprados.Location = New System.Drawing.Point(641, 34)
        Me.LB_productos_comprados.Name = "LB_productos_comprados"
        Me.LB_productos_comprados.Size = New System.Drawing.Size(278, 433)
        Me.LB_productos_comprados.TabIndex = 1
        '
        'Btn_productos
        '
        Me.Btn_productos.Enabled = False
        Me.Btn_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_productos.Location = New System.Drawing.Point(601, 34)
        Me.Btn_productos.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_productos.Name = "Btn_productos"
        Me.Btn_productos.Size = New System.Drawing.Size(20, 433)
        Me.Btn_productos.TabIndex = 2
        Me.Btn_productos.Text = "Añadir elementos"
        Me.Btn_productos.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(641, 487)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(278, 33)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Total"
        '
        'TextBox_productos
        '
        Me.TextBox_productos.Enabled = False
        Me.TextBox_productos.Location = New System.Drawing.Point(309, 487)
        Me.TextBox_productos.Multiline = True
        Me.TextBox_productos.Name = "TextBox_productos"
        Me.TextBox_productos.Size = New System.Drawing.Size(172, 33)
        Me.TextBox_productos.TabIndex = 4
        '
        'TextBox_precio
        '
        Me.TextBox_precio.Enabled = False
        Me.TextBox_precio.Location = New System.Drawing.Point(505, 487)
        Me.TextBox_precio.Multiline = True
        Me.TextBox_precio.Name = "TextBox_precio"
        Me.TextBox_precio.Size = New System.Drawing.Size(75, 33)
        Me.TextBox_precio.TabIndex = 5
        '
        'GB_opciones
        '
        Me.GB_opciones.Controls.Add(Me.Rbtn_ninguno)
        Me.GB_opciones.Controls.Add(Me.Panel_apps)
        Me.GB_opciones.Controls.Add(Me.RadioButton1)
        Me.GB_opciones.Controls.Add(Me.RadioButton3)
        Me.GB_opciones.Controls.Add(Me.RadioButton2)
        Me.GB_opciones.Location = New System.Drawing.Point(59, 34)
        Me.GB_opciones.Name = "GB_opciones"
        Me.GB_opciones.Size = New System.Drawing.Size(193, 433)
        Me.GB_opciones.TabIndex = 6
        Me.GB_opciones.TabStop = False
        Me.GB_opciones.Text = "Características"
        '
        'Rbtn_ninguno
        '
        Me.Rbtn_ninguno.AutoSize = True
        Me.Rbtn_ninguno.Location = New System.Drawing.Point(42, 155)
        Me.Rbtn_ninguno.Name = "Rbtn_ninguno"
        Me.Rbtn_ninguno.Size = New System.Drawing.Size(65, 17)
        Me.Rbtn_ninguno.TabIndex = 3
        Me.Rbtn_ninguno.Text = "Ninguno"
        Me.Rbtn_ninguno.UseVisualStyleBackColor = True
        '
        'Panel_apps
        '
        Me.Panel_apps.Controls.Add(Me.CheckBox4)
        Me.Panel_apps.Controls.Add(Me.CheckBox3)
        Me.Panel_apps.Controls.Add(Me.CheckBox2)
        Me.Panel_apps.Controls.Add(Me.CheckBox1)
        Me.Panel_apps.Enabled = False
        Me.Panel_apps.Location = New System.Drawing.Point(7, 221)
        Me.Panel_apps.Name = "Panel_apps"
        Me.Panel_apps.Size = New System.Drawing.Size(177, 206)
        Me.Panel_apps.TabIndex = 1
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(35, 146)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(95, 17)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "Android Studio"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(35, 109)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(60, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Eclipse"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(35, 72)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(61, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "MySQL"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(35, 34)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Visual Studio"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(42, 43)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(84, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Windows 10"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(42, 118)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Caca"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(42, 79)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Ubuntu"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 571)
        Me.Controls.Add(Me.GB_opciones)
        Me.Controls.Add(Me.TextBox_precio)
        Me.Controls.Add(Me.TextBox_productos)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Btn_productos)
        Me.Controls.Add(Me.LB_productos_comprados)
        Me.Controls.Add(Me.LB_productos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GB_opciones.ResumeLayout(False)
        Me.GB_opciones.PerformLayout()
        Me.Panel_apps.ResumeLayout(False)
        Me.Panel_apps.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LB_productos As ListBox
    Friend WithEvents LB_productos_comprados As ListBox
    Friend WithEvents Btn_productos As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox_productos As TextBox
    Friend WithEvents TextBox_precio As TextBox
    Friend WithEvents GB_opciones As GroupBox
    Friend WithEvents Rbtn_ninguno As RadioButton
    Friend WithEvents Panel_apps As Panel
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
