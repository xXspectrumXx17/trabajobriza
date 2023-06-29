<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        ComboBox6 = New ComboBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(171, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 0
        Label1.Text = "Empleados"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 15)
        Label2.TabIndex = 1
        Label2.Text = "Codigo de empleado"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(76, 197)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 2
        Label3.Text = "Nombre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(16, 237)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 15)
        Label4.TabIndex = 3
        Label4.Text = "Numero de telefono"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(76, 271)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 15)
        Label5.TabIndex = 4
        Label5.Text = "Turno"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(76, 305)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 15)
        Label6.TabIndex = 5
        Label6.Text = "Sueldo"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(330, 93)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 15)
        Label7.TabIndex = 6
        Label7.Text = "Buscador"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 47)
        Label8.Name = "Label8"
        Label8.Size = New Size(38, 15)
        Label8.TabIndex = 7
        Label8.Text = "Fecha"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 77)
        Label9.Name = "Label9"
        Label9.Size = New Size(33, 15)
        Label9.TabIndex = 8
        Label9.Text = "Hora"
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Location = New Point(292, 111)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(121, 23)
        ComboBox6.TabIndex = 14
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(136, 146)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(136, 189)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 16
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(136, 229)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 17
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(136, 263)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 18
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(136, 297)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 19
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(320, 154)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 20
        Button1.Text = "Buscar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(76, 347)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 23)
        Button2.TabIndex = 21
        Button2.Text = "Agregar empleado"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(276, 229)
        Button3.Name = "Button3"
        Button3.Size = New Size(152, 42)
        Button3.TabIndex = 22
        Button3.Text = "Regresar a la pagina principal"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Empleados
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(460, 438)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox6)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Empleados"
        Text = "Empleados"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
