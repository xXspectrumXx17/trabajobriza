Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New MySqlConnection
        Try
            conexion.ConnectionString = "server = localhost;user=root;Password=;database=supermarkethdz"
            conexion.Open()
            MsgBox("conectado")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "SMHDZJUANP" And TextBox2.Text = "JuanPablo" Then
            Timer1.Start()
            Timer2.Interval = 100

        ElseIf TextBox1.Text = "SMHDZNAYELI" And TextBox2.Text = "Nayeli" Then
            Timer1.Start()
            Timer2.Interval = 100

        ElseIf TextBox1.Text = "SMHDZMARTHA" And TextBox2.Text = "Martha" Then
            Timer1.Start()
            Timer2.Interval = 100

        ElseIf TextBox1.Text = "SMHDZOMAR" And TextBox2.Text = "Omar" Then
            Timer1.Start()
            Timer2.Interval = 100

        ElseIf TextBox1.Text = "SMHDZOLGA" And TextBox2.Text = "Olga" Then
            Timer1.Start()
            Timer2.Interval = 100

        ElseIf TextBox1.Text = "SMHDZMARIA" And TextBox2.Text = "Maria" Then
            Timer1.Start()
            Timer2.Interval = 100

        ElseIf TextBox1.Text = "SMHDZKARLA" And TextBox2.Text = "Karla" Then
            Timer1.Start()
            Timer2.Interval = 100

        ElseIf TextBox1.Text = "SMHDZFRANC" And TextBox2.Text = "Francisco" Then
            Timer1.Start()
            Timer2.Interval = 100

        ElseIf TextBox1.Text = "SMHDZALDO" And TextBox2.Text = "Aldo" Then
            Timer1.Start()
            Timer2.Interval = 100

        ElseIf TextBox1.Text = "SMHDZCRIST" And TextBox2.Text = "Crsitian" Then
            Timer1.Start()
            Timer2.Interval = 100

        ElseIf TextBox1.Text = "SMHDZARON" And TextBox2.Text = "Aron" Then
            Timer1.Start()
            Timer2.Interval = 100

        ElseIf TextBox1.Text = "SMHDZPEDRO" And TextBox2.Text = "Pedro" Then
            Timer1.Start()
            Timer2.Interval = 100

        ElseIf TextBox1.Text = "SMHDZCARLOS" And TextBox2.Text = "Carlos" Then
            Timer1.Start()
            Timer2.Interval = 100



        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        Label4.Text = ProgressBar1.Value
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form2.Show()
            Me.Hide()
            MsgBox("Bienvenido Juan Pablo")

        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form2.Show()
            Me.Hide()
            MsgBox("Bienvenido Nayeli")
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form2.Show()
            Me.Hide()
            MsgBox("Bienvenido Martha")
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form2.Show()
            Me.Hide()
            MsgBox("Bienvenido Omar")
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form2.Show()
            Me.Hide()
            MsgBox("Bienvenido Olga")
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form2.Show()
            Me.Hide()
            MsgBox("Bienvenido Maria")
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form2.Show()
            Me.Hide()
            MsgBox("Bienvenido Karla")
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form2.Show()
            Me.Hide()
            MsgBox("Bienvenido Francis")
        ElseIf ProgressBar1.Value = 100 Then
            Timer2.Stop()
            Form2.Show()
            Me.Hide()
            MsgBox("Bienvenido Aldo")
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form2.Show()
            Me.Hide()
            MsgBox("Bienvenido Cristian")
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form2.Show()
            Me.Hide()
            MsgBox("Bienvenido Aron")
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form2.Show()
            Me.Hide()
            MsgBox("Bienvenido Pedro")
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form2.Show()
            Me.Hide()
            MsgBox("Bienvenido Carlos")







        End If
    End Sub
End Class
