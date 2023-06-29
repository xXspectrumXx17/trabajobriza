<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Corte_de_caja
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(167, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 0
        Label1.Text = "Corte de caja"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(87, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 15)
        Label2.TabIndex = 1
        Label2.Text = "Codigo de producto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(87, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 2
        Label3.Text = "Fecha de corte"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(87, 204)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 3
        Label4.Text = "Existencia"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(87, 246)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 15)
        Label5.TabIndex = 4
        Label5.Text = "Total de compra"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(87, 284)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 15)
        Label6.TabIndex = 5
        Label6.Text = "Total de venta"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 48)
        Label8.Name = "Label8"
        Label8.Size = New Size(33, 15)
        Label8.TabIndex = 7
        Label8.Text = "Hora"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 88)
        Label9.Name = "Label9"
        Label9.Size = New Size(38, 15)
        Label9.TabIndex = 8
        Label9.Text = "Fecha"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(87, 312)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 15)
        Label7.TabIndex = 6
        Label7.Text = "Gran total"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(207, 114)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(187, 160)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(187, 196)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(187, 243)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(187, 275)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 13
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(187, 304)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(367, 114)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 15
        Button1.Text = "Corte"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(337, 204)
        Button2.Name = "Button2"
        Button2.Size = New Size(152, 42)
        Button2.TabIndex = 16
        Button2.Text = "Regresar a la pagina principal"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Corte_de_caja
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(501, 356)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Corte_de_caja"
        Text = "Corte_de_caja"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
