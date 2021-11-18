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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Txt_box1 = New System.Windows.Forms.TextBox()
        Me.Txt_box2 = New System.Windows.Forms.TextBox()
        Me.Btn_limpiar1 = New System.Windows.Forms.Button()
        Me.Btn_limpiar2 = New System.Windows.Forms.Button()
        Me.Btn_mover1 = New System.Windows.Forms.Button()
        Me.Btn_mover2 = New System.Windows.Forms.Button()
        Me.Btn_mover4 = New System.Windows.Forms.Button()
        Me.Btn_mover3 = New System.Windows.Forms.Button()
        Me.Btn_limpiar3 = New System.Windows.Forms.Button()
        Me.Txt_box3 = New System.Windows.Forms.TextBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"Ford", "Bmw", "Audi", "Mercedes", "Citroen", "Opel", "Mazda"})
        Me.ListBox1.Location = New System.Drawing.Point(108, 143)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(120, 124)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.AllowDrop = True
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Items.AddRange(New Object() {"Tesla", "Bugatti", "Ferrari", "Porsche", "Aston Martin"})
        Me.ListBox2.Location = New System.Drawing.Point(340, 143)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox2.Size = New System.Drawing.Size(120, 124)
        Me.ListBox2.TabIndex = 1
        '
        'Txt_box1
        '
        Me.Txt_box1.Location = New System.Drawing.Point(108, 290)
        Me.Txt_box1.Name = "Txt_box1"
        Me.Txt_box1.Size = New System.Drawing.Size(120, 23)
        Me.Txt_box1.TabIndex = 2
        '
        'Txt_box2
        '
        Me.Txt_box2.Location = New System.Drawing.Point(340, 290)
        Me.Txt_box2.Name = "Txt_box2"
        Me.Txt_box2.Size = New System.Drawing.Size(120, 23)
        Me.Txt_box2.TabIndex = 3
        '
        'Btn_limpiar1
        '
        Me.Btn_limpiar1.Location = New System.Drawing.Point(108, 102)
        Me.Btn_limpiar1.Name = "Btn_limpiar1"
        Me.Btn_limpiar1.Size = New System.Drawing.Size(120, 23)
        Me.Btn_limpiar1.TabIndex = 4
        Me.Btn_limpiar1.Text = "Borrar lista"
        Me.Btn_limpiar1.UseVisualStyleBackColor = True
        '
        'Btn_limpiar2
        '
        Me.Btn_limpiar2.Location = New System.Drawing.Point(340, 102)
        Me.Btn_limpiar2.Name = "Btn_limpiar2"
        Me.Btn_limpiar2.Size = New System.Drawing.Size(120, 23)
        Me.Btn_limpiar2.TabIndex = 5
        Me.Btn_limpiar2.Text = "Borrar lista"
        Me.Btn_limpiar2.UseVisualStyleBackColor = True
        '
        'Btn_mover1
        '
        Me.Btn_mover1.Location = New System.Drawing.Point(261, 168)
        Me.Btn_mover1.Name = "Btn_mover1"
        Me.Btn_mover1.Size = New System.Drawing.Size(43, 23)
        Me.Btn_mover1.TabIndex = 6
        Me.Btn_mover1.Text = ">>"
        Me.Btn_mover1.UseVisualStyleBackColor = True
        '
        'Btn_mover2
        '
        Me.Btn_mover2.Location = New System.Drawing.Point(261, 220)
        Me.Btn_mover2.Name = "Btn_mover2"
        Me.Btn_mover2.Size = New System.Drawing.Size(43, 23)
        Me.Btn_mover2.TabIndex = 7
        Me.Btn_mover2.Text = "<<"
        Me.Btn_mover2.UseVisualStyleBackColor = True
        '
        'Btn_mover4
        '
        Me.Btn_mover4.Location = New System.Drawing.Point(490, 220)
        Me.Btn_mover4.Name = "Btn_mover4"
        Me.Btn_mover4.Size = New System.Drawing.Size(43, 23)
        Me.Btn_mover4.TabIndex = 12
        Me.Btn_mover4.Text = "<<"
        Me.Btn_mover4.UseVisualStyleBackColor = True
        '
        'Btn_mover3
        '
        Me.Btn_mover3.Location = New System.Drawing.Point(490, 168)
        Me.Btn_mover3.Name = "Btn_mover3"
        Me.Btn_mover3.Size = New System.Drawing.Size(43, 23)
        Me.Btn_mover3.TabIndex = 11
        Me.Btn_mover3.Text = ">>"
        Me.Btn_mover3.UseVisualStyleBackColor = True
        '
        'Btn_limpiar3
        '
        Me.Btn_limpiar3.Location = New System.Drawing.Point(561, 102)
        Me.Btn_limpiar3.Name = "Btn_limpiar3"
        Me.Btn_limpiar3.Size = New System.Drawing.Size(120, 23)
        Me.Btn_limpiar3.TabIndex = 10
        Me.Btn_limpiar3.Text = "Borrar lista"
        Me.Btn_limpiar3.UseVisualStyleBackColor = True
        '
        'Txt_box3
        '
        Me.Txt_box3.Location = New System.Drawing.Point(561, 290)
        Me.Txt_box3.Name = "Txt_box3"
        Me.Txt_box3.Size = New System.Drawing.Size(120, 23)
        Me.Txt_box3.TabIndex = 9
        '
        'ListBox3
        '
        Me.ListBox3.AllowDrop = True
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 15
        Me.ListBox3.Items.AddRange(New Object() {"Nissan", "Toyota", "Honda"})
        Me.ListBox3.Location = New System.Drawing.Point(561, 143)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox3.Size = New System.Drawing.Size(120, 124)
        Me.ListBox3.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_mover4)
        Me.Controls.Add(Me.Btn_mover3)
        Me.Controls.Add(Me.Btn_limpiar3)
        Me.Controls.Add(Me.Txt_box3)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.Btn_mover2)
        Me.Controls.Add(Me.Btn_mover1)
        Me.Controls.Add(Me.Btn_limpiar2)
        Me.Controls.Add(Me.Btn_limpiar1)
        Me.Controls.Add(Me.Txt_box2)
        Me.Controls.Add(Me.Txt_box1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Txt_box1 As TextBox
    Friend WithEvents Txt_box2 As TextBox
    Friend WithEvents Btn_limpiar1 As Button
    Friend WithEvents Btn_limpiar2 As Button
    Friend WithEvents Btn_mover1 As Button
    Friend WithEvents Btn_mover2 As Button
    Friend WithEvents Btn_mover4 As Button
    Friend WithEvents Btn_mover3 As Button
    Friend WithEvents Btn_limpiar3 As Button
    Friend WithEvents Txt_box3 As TextBox
    Friend WithEvents ListBox3 As ListBox
End Class
