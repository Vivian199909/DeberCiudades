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
        Me.txtDato1 = New System.Windows.Forms.TextBox()
        Me.txtDato2 = New System.Windows.Forms.TextBox()
        Me.txtDato3 = New System.Windows.Forms.TextBox()
        Me.txtMenor1 = New System.Windows.Forms.TextBox()
        Me.txtMenor2 = New System.Windows.Forms.TextBox()
        Me.txtMenor3 = New System.Windows.Forms.TextBox()
        Me.txtMayor1 = New System.Windows.Forms.TextBox()
        Me.txtMayor2 = New System.Windows.Forms.TextBox()
        Me.txtMayor3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuadar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDato1
        '
        Me.txtDato1.Location = New System.Drawing.Point(294, 62)
        Me.txtDato1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDato1.Name = "txtDato1"
        Me.txtDato1.Size = New System.Drawing.Size(148, 26)
        Me.txtDato1.TabIndex = 0
        '
        'txtDato2
        '
        Me.txtDato2.Location = New System.Drawing.Point(294, 102)
        Me.txtDato2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDato2.Name = "txtDato2"
        Me.txtDato2.Size = New System.Drawing.Size(148, 26)
        Me.txtDato2.TabIndex = 1
        '
        'txtDato3
        '
        Me.txtDato3.Location = New System.Drawing.Point(294, 142)
        Me.txtDato3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDato3.Name = "txtDato3"
        Me.txtDato3.Size = New System.Drawing.Size(148, 26)
        Me.txtDato3.TabIndex = 2
        '
        'txtMenor1
        '
        Me.txtMenor1.Enabled = False
        Me.txtMenor1.Location = New System.Drawing.Point(117, 62)
        Me.txtMenor1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMenor1.Name = "txtMenor1"
        Me.txtMenor1.Size = New System.Drawing.Size(148, 26)
        Me.txtMenor1.TabIndex = 3
        '
        'txtMenor2
        '
        Me.txtMenor2.Enabled = False
        Me.txtMenor2.Location = New System.Drawing.Point(117, 102)
        Me.txtMenor2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMenor2.Name = "txtMenor2"
        Me.txtMenor2.Size = New System.Drawing.Size(148, 26)
        Me.txtMenor2.TabIndex = 4
        '
        'txtMenor3
        '
        Me.txtMenor3.Enabled = False
        Me.txtMenor3.Location = New System.Drawing.Point(117, 142)
        Me.txtMenor3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMenor3.Name = "txtMenor3"
        Me.txtMenor3.Size = New System.Drawing.Size(148, 26)
        Me.txtMenor3.TabIndex = 5
        '
        'txtMayor1
        '
        Me.txtMayor1.Enabled = False
        Me.txtMayor1.Location = New System.Drawing.Point(474, 62)
        Me.txtMayor1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMayor1.Name = "txtMayor1"
        Me.txtMayor1.Size = New System.Drawing.Size(148, 26)
        Me.txtMayor1.TabIndex = 6
        '
        'txtMayor2
        '
        Me.txtMayor2.Enabled = False
        Me.txtMayor2.Location = New System.Drawing.Point(474, 102)
        Me.txtMayor2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMayor2.Name = "txtMayor2"
        Me.txtMayor2.Size = New System.Drawing.Size(148, 26)
        Me.txtMayor2.TabIndex = 7
        '
        'txtMayor3
        '
        Me.txtMayor3.Enabled = False
        Me.txtMayor3.Location = New System.Drawing.Point(474, 142)
        Me.txtMayor3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMayor3.Name = "txtMayor3"
        Me.txtMayor3.Size = New System.Drawing.Size(148, 26)
        Me.txtMayor3.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Menor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(511, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Mayor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(312, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Datos"
        '
        'btnGuadar
        '
        Me.btnGuadar.Location = New System.Drawing.Point(117, 200)
        Me.btnGuadar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuadar.Name = "btnGuadar"
        Me.btnGuadar.Size = New System.Drawing.Size(112, 35)
        Me.btnGuadar.TabIndex = 12
        Me.btnGuadar.Text = "GUARDAR"
        Me.btnGuadar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(252, 200)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(112, 35)
        Me.btnCalcular.TabIndex = 13
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(122, 280)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(500, 304)
        Me.ListBox1.TabIndex = 14
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(385, 200)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(112, 35)
        Me.btnImprimir.TabIndex = 15
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(515, 200)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(107, 35)
        Me.btnLimpiar.TabIndex = 16
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 678)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnGuadar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMayor3)
        Me.Controls.Add(Me.txtMayor2)
        Me.Controls.Add(Me.txtMayor1)
        Me.Controls.Add(Me.txtMenor3)
        Me.Controls.Add(Me.txtMenor2)
        Me.Controls.Add(Me.txtMenor1)
        Me.Controls.Add(Me.txtDato3)
        Me.Controls.Add(Me.txtDato2)
        Me.Controls.Add(Me.txtDato1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDato1 As TextBox
    Friend WithEvents txtDato2 As TextBox
    Friend WithEvents txtDato3 As TextBox
    Friend WithEvents txtMenor1 As TextBox
    Friend WithEvents txtMenor2 As TextBox
    Friend WithEvents txtMenor3 As TextBox
    Friend WithEvents txtMayor1 As TextBox
    Friend WithEvents txtMayor2 As TextBox
    Friend WithEvents txtMayor3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGuadar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnLimpiar As Button
End Class
