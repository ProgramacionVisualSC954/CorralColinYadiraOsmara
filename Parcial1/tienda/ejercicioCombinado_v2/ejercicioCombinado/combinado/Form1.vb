Public Class Form1

    ' =============================================
    '  EJERCICIO 2 – Carrito de compras (listas)
    ' =============================================
    Dim productos As New List(Of String)()
    Dim precios As New List(Of Decimal)()

    ' =============================================
    '  EJERCICIO 3 – Inventario (arrays fijos)
    ' =============================================
    Dim nombresInv(9) As String
    Dim preciosInv(9) As Decimal

    ' --------------------------------------------------
    '  CARGA INICIAL
    ' --------------------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Llenar inventario del ejercicio 3
        nombresInv(0) = "Laptop Dell Inspiron"
        preciosInv(0) = 12500D

        nombresInv(1) = "Mouse Logitech M185"
        preciosInv(1) = 250D

        nombresInv(2) = "Teclado Redragon K552"
        preciosInv(2) = 850D

        nombresInv(3) = "Monitor Samsung 24"
        preciosInv(3) = 3200D

        nombresInv(4) = "Disco SSD Kingston 480GB"
        preciosInv(4) = 700D

        nombresInv(5) = "Memoria USB Kingston 64GB"
        preciosInv(5) = 180D

        nombresInv(6) = "Laptop HP Pavilion"
        preciosInv(6) = 14500D

        nombresInv(7) = "Audifonos Sony WH-CH520"
        preciosInv(7) = 950D

        nombresInv(8) = "Impresora Epson L3250"
        preciosInv(8) = 4200D

        nombresInv(9) = "Tablet Samsung Galaxy Tab A9"
        preciosInv(9) = 3800D

    End Sub

    ' =============================================
    '  EJERCICIO 1 – Clasificador de productos
    ' =============================================

    Private Sub btnClasificar_Click(sender As Object, e As EventArgs) Handles btnClasificar.Click

        Dim precio As Decimal
        Dim categoria As String
        Dim iva As Decimal
        Dim precioFinal As Decimal

        If Not Decimal.TryParse(txtPrecio.Text, precio) OrElse precio <= 0 Then
            MessageBox.Show("Ingrese un precio válido mayor que cero.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrecio.Focus()
            txtPrecio.SelectAll()
            Exit Sub
        End If

        If precio < 500 Then
            categoria = "Económico"
        ElseIf precio <= 2000 Then
            categoria = "Estándar"
        Else
            categoria = "Premium"
        End If

        iva = precio * 0.16D
        precioFinal = precio + iva

        lblCategoria.Text = categoria
        lblIva.Text = iva.ToString("C")
        lblPrecioFinal.Text = precioFinal.ToString("C")

    End Sub

    Private Sub btnLimpiar1_Click(sender As Object, e As EventArgs) Handles btnLimpiar1.Click

        txtNombre.Clear()
        txtPrecio.Clear()
        lblCategoria.Text = ""
        lblIva.Text = ""
        lblPrecioFinal.Text = ""
        txtNombre.Focus()

    End Sub

    ' =============================================
    '  EJERCICIO 2 – Carrito de compras
    ' =============================================

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim nombre As String
        Dim precio As Decimal

        nombre = txtNombreProducto.Text.Trim()

        If nombre = "" Then
            MessageBox.Show("Ingrese el nombre del producto.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombreProducto.Focus()
            Exit Sub
        End If

        If Not Decimal.TryParse(txtPrecioProducto.Text, precio) OrElse precio <= 0 Then
            MessageBox.Show("Ingrese un precio válido mayor que cero.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrecioProducto.Focus()
            txtPrecioProducto.SelectAll()
            Exit Sub
        End If

        productos.Add(nombre)
        precios.Add(precio)
        lstProductos.Items.Add(nombre & " - " & precio.ToString("C"))
        CalcularTotales()

        txtNombreProducto.Clear()
        txtPrecioProducto.Clear()
        txtNombreProducto.Focus()

    End Sub

    Private Sub CalcularTotales()

        Dim subtotal As Decimal = 0
        For Each p As Decimal In precios
            subtotal += p
        Next

        Dim descuento As Decimal = 0
        If productos.Count >= 3 Then
            descuento = subtotal * 0.05D
        End If

        Dim subtotalConDescuento As Decimal = subtotal - descuento
        Dim iva As Decimal = subtotalConDescuento * 0.16D
        Dim total As Decimal = subtotalConDescuento + iva

        lblSubtotal.Text = subtotalConDescuento.ToString("C")
        lblIva2.Text = iva.ToString("C")
        lblTotal.Text = total.ToString("C")

    End Sub

    Private Sub btnGenerarTicket_Click(sender As Object, e As EventArgs) Handles btnGenerarTicket.Click

        If productos.Count = 0 Then
            MessageBox.Show("No hay productos agregados.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim ticket As String = ""
        Dim subtotal As Decimal = 0

        ticket &= "===== TICKET DE COMPRA =====" & vbCrLf & vbCrLf

        Dim indice As Integer = 1
        For Each producto As String In productos
            Dim precio As Decimal = precios(indice - 1)
            ticket &= indice & ". " & producto & " - " & precio.ToString("C") & vbCrLf
            subtotal += precio
            indice += 1
        Next

        Dim descuento As Decimal = 0
        If productos.Count >= 3 Then
            descuento = subtotal * 0.05D
        End If

        Dim subtotalConDescuento As Decimal = subtotal - descuento
        Dim iva As Decimal = subtotalConDescuento * 0.16D
        Dim total As Decimal = subtotalConDescuento + iva

        ticket &= vbCrLf
        ticket &= "Subtotal: " & subtotal.ToString("C") & vbCrLf
        If descuento > 0 Then
            ticket &= "Descuento (5%): -" & descuento.ToString("C") & vbCrLf
        End If
        ticket &= "IVA (16%): " & iva.ToString("C") & vbCrLf
        ticket &= "Total: " & total.ToString("C") & vbCrLf

        MessageBox.Show(ticket, "Ticket de Compra",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnLimpiar2_Click(sender As Object, e As EventArgs) Handles btnLimpiar2.Click

        productos.Clear()
        precios.Clear()
        lstProductos.Items.Clear()
        txtNombreProducto.Clear()
        txtPrecioProducto.Clear()
        lblSubtotal.Text = "$0.00"
        lblIva2.Text = "$0.00"
        lblTotal.Text = "$0.00"
        txtNombreProducto.Focus()

    End Sub

    ' =============================================
    '  EJERCICIO 3 – Búsqueda en inventario
    ' =============================================

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim busqueda As String
        Dim encontrado As Boolean = False

        busqueda = txtBusqueda1.Text.Trim().ToLower()

        If busqueda = "" Then
            MessageBox.Show("Ingrese un producto para buscar.")
            txtBusqueda1.Focus()
            Exit Sub
        End If

        For i As Integer = 0 To nombresInv.Length - 1
            If nombresInv(i).ToLower() = busqueda Then
                lblResultado.Text =
                    "Producto encontrado" & vbCrLf &
                    "Posición: " & i & vbCrLf &
                    "Nombre: " & nombresInv(i) & vbCrLf &
                    "Precio: " & preciosInv(i).ToString("C")
                encontrado = True
                Exit For
            End If
        Next

        If Not encontrado Then
            lblResultado.Text =
                "El producto """ & txtBusqueda1.Text &
                """ no existe en el inventario."
        End If

    End Sub

End Class
