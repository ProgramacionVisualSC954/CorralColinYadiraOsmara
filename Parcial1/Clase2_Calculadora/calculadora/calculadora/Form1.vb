Public Class Form1

    Dim numero1 As Double
    Dim operador As String
    Dim nuevaEntrada As Boolean = True
    Dim expresion As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Calculadora"
        Me.Size = New Size(360, 520)
        Me.BackColor = Color.FromArgb(255, 220, 230)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        ' Pantalla expresión (arriba pequeña)
        Dim txtExpr As New TextBox()
        txtExpr.Name = "txtExpr"
        txtExpr.Text = ""
        txtExpr.Font = New Font("Segoe UI", 11)
        txtExpr.TextAlign = HorizontalAlignment.Right
        txtExpr.BackColor = Color.FromArgb(255, 240, 245)
        txtExpr.ForeColor = Color.FromArgb(180, 100, 130)
        txtExpr.ReadOnly = True
        txtExpr.Size = New Size(320, 30)
        txtExpr.Location = New Point(15, 10)
        txtExpr.BorderStyle = BorderStyle.None
        Me.Controls.Add(txtExpr)

        ' Pantalla principal
        Dim txt As New TextBox()
        txt.Name = "txtPantalla"
        txt.Text = "0"
        txt.Font = New Font("Segoe UI", 28, FontStyle.Bold)
        txt.TextAlign = HorizontalAlignment.Right
        txt.BackColor = Color.FromArgb(255, 240, 245)
        txt.ForeColor = Color.FromArgb(180, 60, 100)
        txt.ReadOnly = True
        txt.Size = New Size(320, 55)
        txt.Location = New Point(15, 40)
        txt.BorderStyle = BorderStyle.None
        Me.Controls.Add(txt)

        ' Línea decorativa
        Dim linea As New Label()
        linea.Size = New Size(320, 2)
        linea.Location = New Point(15, 100)
        linea.BackColor = Color.FromArgb(255, 180, 200)
        Me.Controls.Add(linea)

        ' Botones: texto, columna, fila
        Dim botones(,) As String = {
            {"C", "0", "0"}, {"(", "1", "0"}, {")", "2", "0"}, {"←", "3", "0"},
            {"7", "0", "1"}, {"8", "1", "1"}, {"9", "2", "1"}, {"/", "3", "1"},
            {"4", "0", "2"}, {"5", "1", "2"}, {"6", "2", "2"}, {"*", "3", "2"},
            {"1", "0", "3"}, {"2", "1", "3"}, {"3", "2", "3"}, {"-", "3", "3"},
            {"0", "0", "4"}, {".", "1", "4"}, {"=", "2", "4"}, {"+", "3", "4"}
        }

        For i As Integer = 0 To botones.GetLength(0) - 1
            Dim btn As New Button()
            btn.Text = botones(i, 0)
            btn.Size = New Size(72, 72)
            btn.Location = New Point(15 + CInt(botones(i, 1)) * 80, 115 + CInt(botones(i, 2)) * 78)
            btn.Font = New Font("Segoe UI", 15, FontStyle.Bold)
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.Cursor = Cursors.Hand

            Select Case btn.Text
                Case "C"
                    btn.BackColor = Color.FromArgb(255, 150, 170)
                    btn.ForeColor = Color.White
                Case "←"
                    btn.BackColor = Color.FromArgb(255, 180, 195)
                    btn.ForeColor = Color.White
                Case "(", ")"
                    btn.BackColor = Color.FromArgb(245, 180, 210)
                    btn.ForeColor = Color.FromArgb(140, 50, 90)
                Case "+", "-", "*", "/"
                    btn.BackColor = Color.FromArgb(240, 150, 180)
                    btn.ForeColor = Color.White
                Case "="
                    btn.BackColor = Color.FromArgb(220, 90, 130)
                    btn.ForeColor = Color.White
                Case Else
                    btn.BackColor = Color.FromArgb(255, 210, 225)
                    btn.ForeColor = Color.FromArgb(150, 50, 90)
            End Select

            AddHandler btn.Click, AddressOf Boton_Click
            Me.Controls.Add(btn)
        Next
    End Sub

    Private Sub Boton_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim txt As TextBox = CType(Me.Controls("txtPantalla"), TextBox)
        Dim txtExpr As TextBox = CType(Me.Controls("txtExpr"), TextBox)

        Select Case btn.Text

            Case "0" To "9"
                If nuevaEntrada Then
                    expresion = btn.Text
                    nuevaEntrada = False
                Else
                    If txt.Text = "0" AndAlso expresion = "0" Then
                        expresion = btn.Text
                    Else
                        expresion &= btn.Text
                    End If
                End If
                txt.Text = expresion

            Case "."
                If Not expresion.Contains(".") Then
                    If expresion = "" OrElse nuevaEntrada Then
                        expresion = "0."
                        nuevaEntrada = False
                    Else
                        expresion &= "."
                    End If
                    txt.Text = expresion
                End If

            Case "(", ")"
                expresion &= btn.Text
                txt.Text = expresion
                nuevaEntrada = False

            Case "+", "-", "*", "/"
                If expresion <> "" Then
                    numero1 = 0
                    operador = btn.Text
                    expresion &= " " & btn.Text & " "
                    txt.Text = expresion
                    txtExpr.Text = expresion
                    nuevaEntrada = False
                End If

            Case "←"
                If expresion.Length > 0 Then
                    expresion = expresion.Substring(0, expresion.Length - 1)
                    If expresion = "" Then
                        txt.Text = "0"
                    Else
                        txt.Text = expresion
                    End If
                End If

            Case "="
                Try
                    ' Limpiar expresion para evaluarla
                    Dim exprLimpia As String = expresion.Replace(" ", "")
                    Dim resultado As Double = EvaluarExpresion(exprLimpia)
                    txtExpr.Text = expresion & " ="
                    txt.Text = resultado.ToString()
                    expresion = resultado.ToString()
                    nuevaEntrada = True
                Catch
                    txt.Text = "Error"
                    expresion = ""
                    nuevaEntrada = True
                End Try

            Case "C"
                txt.Text = "0"
                txtExpr.Text = ""
                expresion = ""
                numero1 = 0
                operador = ""
                nuevaEntrada = True

        End Select
    End Sub

    ' Evaluar expresión con paréntesis usando DataTable
    Private Function EvaluarExpresion(expr As String) As Double
        Dim dt As New System.Data.DataTable()
        Dim resultado = dt.Compute(expr, "")
        Return CDbl(resultado)
    End Function

End Class