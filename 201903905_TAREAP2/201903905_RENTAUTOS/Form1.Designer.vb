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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PagoTotal = New System.Windows.Forms.ListBox()
        Me.PagoParcial = New System.Windows.Forms.ListBox()
        Me.Días = New System.Windows.Forms.ListBox()
        Me.Marca = New System.Windows.Forms.ListBox()
        Me.Placa = New System.Windows.Forms.ListBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.LimpiarVectores = New System.Windows.Forms.Button()
        Me.LimpiarEntradas = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.NavajoWhite
        Me.TextBox1.Location = New System.Drawing.Point(8, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.NavajoWhite
        Me.TextBox2.Location = New System.Drawing.Point(129, 41)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.NavajoWhite
        Me.TextBox3.Location = New System.Drawing.Point(129, 92)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 23)
        Me.TextBox3.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.NavajoWhite
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Honda", "Mercedes Benz", "Toyota", "Mazda"})
        Me.ComboBox1.Location = New System.Drawing.Point(8, 92)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 23)
        Me.ComboBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NIT:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Placa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Marca:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Dás a Alquilar:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 146)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 128)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Pago:"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.NavajoWhite
        Me.TextBox6.Location = New System.Drawing.Point(99, 89)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 23)
        Me.TextBox6.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.NavajoWhite
        Me.TextBox5.Location = New System.Drawing.Point(99, 60)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 23)
        Me.TextBox5.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Porcentaje:"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.NavajoWhite
        Me.TextBox4.Location = New System.Drawing.Point(99, 31)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 23)
        Me.TextBox4.TabIndex = 2
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.NavajoWhite
        Me.CheckBox2.Location = New System.Drawing.Point(8, 64)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(60, 19)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Tarjeta"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.NavajoWhite
        Me.CheckBox1.Location = New System.Drawing.Point(8, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(68, 19)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Efectivo"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PagoTotal)
        Me.GroupBox3.Controls.Add(Me.PagoParcial)
        Me.GroupBox3.Controls.Add(Me.Días)
        Me.GroupBox3.Controls.Add(Me.Marca)
        Me.GroupBox3.Controls.Add(Me.Placa)
        Me.GroupBox3.Location = New System.Drawing.Point(263, 177)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(484, 162)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales"
        '
        'PagoTotal
        '
        Me.PagoTotal.BackColor = System.Drawing.Color.NavajoWhite
        Me.PagoTotal.FormattingEnabled = True
        Me.PagoTotal.ItemHeight = 15
        Me.PagoTotal.Location = New System.Drawing.Point(362, 20)
        Me.PagoTotal.Name = "PagoTotal"
        Me.PagoTotal.Size = New System.Drawing.Size(83, 124)
        Me.PagoTotal.TabIndex = 4
        '
        'PagoParcial
        '
        Me.PagoParcial.BackColor = System.Drawing.Color.NavajoWhite
        Me.PagoParcial.FormattingEnabled = True
        Me.PagoParcial.ItemHeight = 15
        Me.PagoParcial.Location = New System.Drawing.Point(273, 22)
        Me.PagoParcial.Name = "PagoParcial"
        Me.PagoParcial.Size = New System.Drawing.Size(83, 124)
        Me.PagoParcial.TabIndex = 3
        '
        'Días
        '
        Me.Días.BackColor = System.Drawing.Color.NavajoWhite
        Me.Días.FormattingEnabled = True
        Me.Días.ItemHeight = 15
        Me.Días.Location = New System.Drawing.Point(184, 21)
        Me.Días.Name = "Días"
        Me.Días.Size = New System.Drawing.Size(83, 124)
        Me.Días.TabIndex = 2
        '
        'Marca
        '
        Me.Marca.BackColor = System.Drawing.Color.NavajoWhite
        Me.Marca.FormattingEnabled = True
        Me.Marca.ItemHeight = 15
        Me.Marca.Location = New System.Drawing.Point(95, 22)
        Me.Marca.Name = "Marca"
        Me.Marca.Size = New System.Drawing.Size(83, 124)
        Me.Marca.TabIndex = 1
        '
        'Placa
        '
        Me.Placa.BackColor = System.Drawing.Color.NavajoWhite
        Me.Placa.FormattingEnabled = True
        Me.Placa.ItemHeight = 15
        Me.Placa.Location = New System.Drawing.Point(6, 22)
        Me.Placa.Name = "Placa"
        Me.Placa.Size = New System.Drawing.Size(83, 124)
        Me.Placa.TabIndex = 0
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.Color.Goldenrod
        Me.Calcular.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Calcular.Location = New System.Drawing.Point(359, 58)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 11
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'LimpiarVectores
        '
        Me.LimpiarVectores.BackColor = System.Drawing.Color.Goldenrod
        Me.LimpiarVectores.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LimpiarVectores.Location = New System.Drawing.Point(476, 58)
        Me.LimpiarVectores.Name = "LimpiarVectores"
        Me.LimpiarVectores.Size = New System.Drawing.Size(120, 23)
        Me.LimpiarVectores.TabIndex = 12
        Me.LimpiarVectores.Text = "Limpiar Vectores"
        Me.LimpiarVectores.UseVisualStyleBackColor = False
        '
        'LimpiarEntradas
        '
        Me.LimpiarEntradas.BackColor = System.Drawing.Color.Goldenrod
        Me.LimpiarEntradas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LimpiarEntradas.Location = New System.Drawing.Point(476, 103)
        Me.LimpiarEntradas.Name = "LimpiarEntradas"
        Me.LimpiarEntradas.Size = New System.Drawing.Size(120, 23)
        Me.LimpiarEntradas.TabIndex = 13
        Me.LimpiarEntradas.Text = "Limpiar Entradas"
        Me.LimpiarEntradas.UseVisualStyleBackColor = False
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.Goldenrod
        Me.Salir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Salir.Location = New System.Drawing.Point(359, 103)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 14
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.LimpiarEntradas)
        Me.Controls.Add(Me.LimpiarVectores)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PagoTotal As ListBox
    Friend WithEvents PagoParcial As ListBox
    Friend WithEvents Días As ListBox
    Friend WithEvents Marca As ListBox
    Friend WithEvents Placa As ListBox
    Friend WithEvents Calcular As Button
    Friend WithEvents LimpiarVectores As Button
    Friend WithEvents LimpiarEntradas As Button
    Friend WithEvents Salir As Button
End Class
