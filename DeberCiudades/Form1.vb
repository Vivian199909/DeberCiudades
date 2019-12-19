Public Class Form1
    Dim lista As New List(Of String)
    'declaramos la variable lista'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuadar.Click
        lista.Add("Provincia: " & txtDato1.Text)
        lista.Add("Ciudad: " & txtDato2.Text)
        lista.Add("Población: " & txtDato3.Text)
        lista.Add("-------------------------------------")
        'imprime dentro de la lista'
        txtMenor1.Text = txtDato1.Text

        txtMayor1.Text = txtDato1.Text
        txtMenor2.Text = txtDato2.Text
        txtMayor2.Text = txtDato2.Text
        txtMenor3.Text = txtDato3.Text
        txtMayor3.Text = txtDato3.Text
        txtDato1.Text = ""
        txtDato2.Text = ""
        txtDato3.Text = ""


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim nuevo As Integer = Int(txtDato3.Text)
        Dim menor As Integer = Int(txtMenor3.Text)
        Dim mayor As Integer = Int(txtMayor3.Text)
        'declaramos las variables'
        Dim calcular As Class1 = New Class1
        Dim I As Integer = calcular.Cal(nuevo, menor, mayor)
        lista.Add("Provincia: " & txtDato1.Text)
        lista.Add("Ciudad: " & txtDato2.Text)
        lista.Add("Población: " & txtDato3.Text)
        lista.Add("-------------------------------------")
        If I = 1 Then
            txtMenor1.Text = txtDato1.Text
            txtMenor2.Text = txtDato2.Text
            txtMenor3.Text = txtDato3.Text
            txtDato1.Text = ""
            txtDato2.Text = ""
            txtDato3.Text = ""
        ElseIf I = 2 Then
            txtMayor1.Text = txtDato1.Text
            txtMayor2.Text = txtDato2.Text
            txtMayor3.Text = txtDato3.Text
            txtDato1.Text = ""
            txtDato2.Text = ""
            txtDato3.Text = ""
        ElseIf I = 3 Then
            txtMenor1.Text = txtMenor1.Text & ", " & txtDato1.Text
            txtMenor2.Text = txtMenor2.Text & ", " & txtDato2.Text
            txtMenor3.Text = txtDato3.Text
        ElseIf I = 4 Then
            txtMayor1.Text = txtMayor1.Text & ", " & txtDato1.Text
            txtMayor2.Text = txtMayor2.Text & ", " & txtDato2.Text
            txtMayor3.Text = txtDato3.Text
        Else
            txtDato1.Text = ""
            txtDato2.Text = ""
            txtDato3.Text = ""
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        For Each item As String In lista
            Me.ListBox1.Items.Add(item)
        Next item
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtMenor1.Text = ""

        txtMayor1.Text = ""
        txtMenor2.Text = ""
        txtMayor2.Text = ""
        txtMenor3.Text = ""
        txtMayor3.Text = ""

        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex())


    End Sub
End Class
