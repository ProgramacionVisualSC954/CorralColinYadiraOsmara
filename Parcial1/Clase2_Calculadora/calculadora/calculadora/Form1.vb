Option Strict On

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Calculadora SC954"
        Me.Size = New Size(420, 620)
        Me.BackColor = Color.FromArgb(255, 220, 230)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle


        Dim lblNum1 As New Label()
        lblNum1.Text = "Número 1:"
        lblNum1.Font = New Font("Segoe UI", 10)
        lblNum1.ForeColor = Color.FromArgb(150, 50, 90)
        lblNum1.Location = New Point(20, 15)
        lblNum1.AutoSize = True
        Me.Controls.Add(lblNum1)

        Dim txt1 As New TextBox()
        txt1.Name = "txtNum1"
        txt1.Font = New Font("Segoe UI", 14)
        txt1.Size = New Size(370, 35)
        txt1.Location = New Point(20, 38)
        txt1.BackColor = Color.FromArgb(255, 240, 245)
        txt1.ForeColor = Color.FromArgb(150, 50, 90)
        Me.Controls.Add(txt1)

        ' Número 2
        Dim lblNum2 As New Label()
        lblNum2.Text = "Número 2:"
        lblNum2.Font = New Font("Segoe UI", 10)
        lblNum2.ForeColor = Color.FromArgb(150, 50, 90)
        lblNum2.Location = New Point(20, 80)
        lblNum2.AutoSize = True
        Me.Controls.Add(lblNum2)

        Dim txt2 As New TextBox()
        txt2.Name = "txtNum2"
        txt2.Font = New Font("Segoe UI", 14)
        txt2.Size = New Size(370, 35)
        txt2.Location = New Point(20, 103)
        txt2.BackColor = Color.FromArgb(255, 240, 245)
        txt2.ForeColor = Color.FromArgb(150, 50, 90)
        Me.Controls.Add(txt2)

        ' Resultado
        Dim lblRes As New Label()
        lblRes.Text = "Resultado:"
        lblRes.Font = New Font("Segoe UI", 10)
        lblRes.ForeColor = Color.FromArgb(150, 50, 90)
        lblRes.Location = New Point(20, 145)
        lblRes.AutoSize = True
        Me.Controls.Add(lblRes)

        Dim txtRes As New TextBox()
        txtRes.Name = "txtResultado"
        txtRes.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        txtRes.Size = New Size(370, 40)
        txtRes.Location = New Point(20, 168)
        txtRes.BackColor = Color.FromArgb(255, 240, 245)
        txtRes.ForeColor = Color.FromArgb(180, 60, 100)
        txtRes.ReadOnly = True
        Me.Controls.Add(txtRes)

        ' Línea decorativa
        Dim linea As New Label()
        linea.Size = New Size(370, 2)
        linea.Location = New Point(20, 218)
        linea.BackColor = Color.FromArgb(255, 180, 200)
        Me.Controls.Add(linea)

        ' ══════════════════════════════
        '  BOTONES DE OPERACIONES
        ' ══════════════════════════════
        Dim botones(,) As String = {
            {"+", "0", "0"}, {"-", "1", "0"}, {"*", "2", "0"}, {"/", "3", "0"},
            {"x²", "0", "1"}, {"√x", "1", "1"}, {"C", "2", "1"}, {"←", "3", "1"}
        }

        For i As Integer = 0 To botones.GetLength(0) - 1
            Dim btn As New Button()
            btn.Text = botones(i, 0)
            btn.Size = New Size(82, 65)
            btn.Location = New Point(20 + CInt(botones(i, 1)) * 92, 228 + CInt(botones(i, 2)) * 73)
            btn.Font = New Font("Segoe UI", 13, FontStyle.Bold)
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.Cursor = Cursors.Hand

            Select Case btn.Text
                Case "+", "-", "*", "/"
                    btn.BackColor = Color.FromArgb(240, 150, 180)
                    btn.ForeColor = Color.White
                Case "x²", "√x"
                    btn.BackColor = Color.FromArgb(245, 180, 210)
                    btn.ForeColor = Color.FromArgb(140, 50, 90)
                Case "C"
                    btn.BackColor = Color.FromArgb(255, 150, 170)
                    btn.ForeColor = Color.White
                Case "←"
                    btn.BackColor = Color.FromArgb(255, 180, 195)
                    btn.ForeColor = Color.White
            End Select

            AddHandler btn.Click, AddressOf Boton_Click
            Me.Controls.Add(btn)
        Next

        ' Botón IGUAL
        Dim btnIgual As New Button()
        btnIgual.Text = "="
        btnIgual.Name = "btnIgual"
        btnIgual.Size = New Size(370, 50)
        btnIgual.Location = New Point(20, 375)
        btnIgual.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        btnIgual.FlatStyle = FlatStyle.Flat
        btnIgual.FlatAppearance.BorderSize = 0
        btnIgual.BackColor = Color.FromArgb(220, 90, 130)
        btnIgual.ForeColor = Color.White
        btnIgual.Cursor = Cursors.Hand
        AddHandler btnIgual.Click, AddressOf Boton_Click
        Me.Controls.Add(btnIgual)


        '  SECCIÓN PARÉNTESIS

        Dim linea2 As New Label()
        linea2.Size = New Size(370, 2)
        linea2.Location = New Point(20, 435)
        linea2.BackColor = Color.FromArgb(255, 180, 200)
        Me.Controls.Add(linea2)

        Dim lblExpr As New Label()
        lblExpr.Text = "Expresión con paréntesis:"
        lblExpr.Font = New Font("Segoe UI", 10)
        lblExpr.ForeColor = Color.FromArgb(150, 50, 90)
        lblExpr.Location = New Point(20, 445)
        lblExpr.AutoSize = True
        Me.Controls.Add(lblExpr)

        Dim txtExpr As New TextBox()
        txtExpr.Name = "txtExpresion"
        txtExpr.Font = New Font("Segoe UI", 12)
        txtExpr.Size = New Size(270, 35)
        txtExpr.Location = New Point(20, 468)
        txtExpr.BackColor = Color.FromArgb(255, 240, 245)
        txtExpr.ForeColor = Color.FromArgb(150, 50, 90)
        txtExpr.Text = "(3 + 4) * 2"
        Me.Controls.Add(txtExpr)

        Dim btnExpr As New Button()
        btnExpr.Text = "Evaluar"
        btnExpr.Name = "btnEvaluar"
        btnExpr.Size = New Size(90, 35)
        btnExpr.Location = New Point(300, 468)
        btnExpr.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnExpr.FlatStyle = FlatStyle.Flat
        btnExpr.FlatAppearance.BorderSize = 0
        btnExpr.BackColor = Color.FromArgb(220, 90, 130)
        btnExpr.ForeColor = Color.White
        btnExpr.Cursor = Cursors.Hand
        AddHandler btnExpr.Click, AddressOf Boton_Click
        Me.Controls.Add(btnExpr)

        ' Configurar Tab y Enter
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf Form_KeyDown

    End Sub


    '  ENTER PARA CALCULAR

    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Dim btn As Button = CType(Me.Controls("btnIgual"), Button)
            btn.PerformClick()
        End If
    End Sub


    '  LÓGICA DE BOTONES

    Private operadorActual As String = ""

    Private Sub Boton_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim txt1 As TextBox = CType(Me.Controls("txtNum1"), TextBox)
        Dim txt2 As TextBox = CType(Me.Controls("txtNum2"), TextBox)
        Dim txtRes As TextBox = CType(Me.Controls("txtResultado"), TextBox)
        Dim txtExpr As TextBox = CType(Me.Controls("txtExpresion"), TextBox)

        Select Case btn.Text

            Case "+", "-", "*", "/"
                operadorActual = btn.Text

            Case "←"
                If txt1.Focused AndAlso txt1.Text.Length > 0 Then
                    txt1.Text = txt1.Text.Substring(0, txt1.Text.Length - 1)
                ElseIf txt2.Text.Length > 0 Then
                    txt2.Text = txt2.Text.Substring(0, txt2.Text.Length - 1)
                End If

            Case "C"
                txt1.Text = ""
                txt2.Text = ""
                txtRes.Text = ""
                operadorActual = ""
                txtExpr.Text = ""
                txt1.Focus()

            Case "x²"
                ' Validar campo 1
                Dim n As Decimal
                If txt1.Text.Trim() = "" Then
                    MessageBox.Show("El campo Número 1 no puede estar vacío", "Campo vacío",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txt1.Focus()
                    Return
                End If
                If Not Decimal.TryParse(txt1.Text, n) Then
                    MessageBox.Show("El valor ingresado no es un número válido", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt1.Focus()
                    Return
                End If
                Try
                    Dim resultado As Decimal = n * n
                    txtRes.Text = FormatearResultado(resultado)
                Catch ex As OverflowException
                    MessageBox.Show("El resultado está fuera del rango permitido", "Desbordamiento",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Case "√x"
                ' Validar campo 1
                Dim n As Decimal
                If txt1.Text.Trim() = "" Then
                    MessageBox.Show("El campo Número 1 no puede estar vacío", "Campo vacío",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txt1.Focus()
                    Return
                End If
                If Not Decimal.TryParse(txt1.Text, n) Then
                    MessageBox.Show("El valor ingresado no es un número válido", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt1.Focus()
                    Return
                End If
                If n < 0 Then
                    MessageBox.Show("La raíz cuadrada de un número negativo no es real", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                Dim raiz As Double = Math.Sqrt(CDbl(n))
                If Double.IsNaN(raiz) Then
                    MessageBox.Show("La raíz cuadrada de un número negativo no es real", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                txtRes.Text = FormatearResultado(CDec(raiz))

            Case "=", "Evaluar"

                If btn.Text = "Evaluar" Then
                    ' ── Evaluar expresión con paréntesis ──
                    Dim expr As String = txtExpr.Text.Trim()
                    If expr = "" Then
                        MessageBox.Show("El campo Número 1 no puede estar vacío", "Campo vacío",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtExpr.Focus()
                        Return
                    End If

                    ' Validar paréntesis balanceados
                    Dim abre As Integer = 0
                    Dim cierra As Integer = 0
                    For Each c As Char In expr
                        If c = "("c Then abre += 1
                        If c = ")"c Then cierra += 1
                    Next
                    If abre <> cierra Then
                        MessageBox.Show("La expresión contiene paréntesis no balanceados", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    Try
                        Dim dt As New System.Data.DataTable()
                        Dim res = dt.Compute(expr, "")
                        txtRes.Text = FormatearResultado(CDec(res))
                    Catch
                        MessageBox.Show("La expresión contiene un error o es inválida", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                Else
                    ' ── Operación normal ──
                    If operadorActual = "" Then
                        MessageBox.Show("Selecciona una operación primero", "Aviso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    ' Validar campos vacíos
                    If txt1.Text.Trim() = "" Then
                        MessageBox.Show("El campo Número 1 no puede estar vacío", "Campo vacío",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txt1.Focus()
                        Return
                    End If
                    If txt2.Text.Trim() = "" Then
                        MessageBox.Show("El campo Número 2 no puede estar vacío", "Campo vacío",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txt2.Focus()
                        Return
                    End If

                    ' Validar que sean números
                    Dim n1 As Decimal
                    Dim n2 As Decimal
                    If Not Decimal.TryParse(txt1.Text, n1) Then
                        MessageBox.Show("El valor ingresado no es un número válido", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txt1.Focus()
                        Return
                    End If
                    If Not Decimal.TryParse(txt2.Text, n2) Then
                        MessageBox.Show("El valor ingresado no es un número válido", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txt2.Focus()
                        Return
                    End If

                    Try
                        Dim resultado As Decimal
                        Select Case operadorActual
                            Case "+"
                                resultado = n1 + n2
                            Case "-"
                                resultado = n1 - n2
                            Case "*"
                                resultado = n1 * n2
                            Case "/"
                                If n2 = 0 Then
                                    MessageBox.Show("No se puede dividir entre cero", "Error",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Return
                                End If
                                resultado = n1 / n2
                        End Select
                        txtRes.Text = FormatearResultado(resultado)
                    Catch ex As OverflowException
                        MessageBox.Show("El resultado está fuera del rango permitido", "Desbordamiento",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

        End Select
    End Sub


    '  FORMATO DEL RESULTADO

    Private Function FormatearResultado(valor As Decimal) As String
        If valor = Math.Truncate(valor) Then
            Return valor.ToString("N0")   ' Sin decimales si es entero exacto
        Else
            Return valor.ToString("N2")   ' Dos decimales si tiene fracción
        End If
    End Function

End Class