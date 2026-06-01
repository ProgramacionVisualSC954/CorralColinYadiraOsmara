<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        ' ── TabControl principal ──────────────────────────────────────────
        tabControl1 = New TabControl()
        tabEj1 = New TabPage()
        tabEj2 = New TabPage()
        tabEj3 = New TabPage()

        ' ── Ejercicio 1 – controles ──────────────────────────────────────
        lblNombre = New Label()
        txtNombre = New TextBox()
        lblPrecioEj1 = New Label()
        txtPrecio = New TextBox()
        btnClasificar = New Button()
        btnLimpiar1 = New Button()
        lblTextoCategoria = New Label()
        lblCategoria = New Label()
        lblTextoIva1 = New Label()
        lblIva = New Label()
        lblTextoPrecioFinal = New Label()
        lblPrecioFinal = New Label()

        ' ── Ejercicio 2 – controles ──────────────────────────────────────
        lblNombreProducto = New Label()
        txtNombreProducto = New TextBox()
        lblPrecioProducto = New Label()
        txtPrecioProducto = New TextBox()
        btnAgregar = New Button()
        lstProductos = New ListBox()
        lblTextoSubtotal = New Label()
        lblSubtotal = New Label()
        lblTextoIva2 = New Label()
        lblIva2 = New Label()
        lblTextoTotal = New Label()
        lblTotal = New Label()
        btnGenerarTicket = New Button()
        btnLimpiar2 = New Button()

        ' ── Ejercicio 3 – controles ──────────────────────────────────────
        lblBuscar = New Label()
        txtBusqueda1 = New TextBox()
        btnBuscar = New Button()
        lblResultado = New Label()

        ' ═════════════════════════════════════════════════════════════════
        tabControl1.SuspendLayout()
        tabEj1.SuspendLayout()
        tabEj2.SuspendLayout()
        tabEj3.SuspendLayout()
        SuspendLayout()

        ' ── TabControl ───────────────────────────────────────────────────
        tabControl1.Controls.Add(tabEj1)
        tabControl1.Controls.Add(tabEj2)
        tabControl1.Controls.Add(tabEj3)
        tabControl1.Dock = DockStyle.Fill
        tabControl1.Font = New System.Drawing.Font("Segoe UI", 10)
        tabControl1.Name = "tabControl1"
        tabControl1.SelectedIndex = 0
        tabControl1.TabIndex = 0

        ' ── Tab 1 ────────────────────────────────────────────────────────
        tabEj1.Name = "tabEj1"
        tabEj1.Padding = New Padding(20)
        tabEj1.Text = "Ejercicio 1 – Clasificador"
        tabEj1.UseVisualStyleBackColor = True

        lblNombre.AutoSize = True
        lblNombre.Location = New System.Drawing.Point(30, 30)
        lblNombre.Text = "Nombre del producto:"

        txtNombre.Location = New System.Drawing.Point(30, 60)
        txtNombre.Size = New System.Drawing.Size(600, 28)
        txtNombre.Name = "txtNombre"
        txtNombre.TabIndex = 0

        lblPrecioEj1.AutoSize = True
        lblPrecioEj1.Location = New System.Drawing.Point(30, 110)
        lblPrecioEj1.Text = "Precio:"

        txtPrecio.Location = New System.Drawing.Point(30, 140)
        txtPrecio.Size = New System.Drawing.Size(600, 28)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.TabIndex = 1

        btnClasificar.Location = New System.Drawing.Point(30, 200)
        btnClasificar.Size = New System.Drawing.Size(120, 35)
        btnClasificar.Text = "Clasificar"
        btnClasificar.Name = "btnClasificar"
        btnClasificar.TabIndex = 2
        btnClasificar.UseVisualStyleBackColor = True

        btnLimpiar1.Location = New System.Drawing.Point(170, 200)
        btnLimpiar1.Size = New System.Drawing.Size(120, 35)
        btnLimpiar1.Text = "Limpiar"
        btnLimpiar1.Name = "btnLimpiar1"
        btnLimpiar1.TabIndex = 3
        btnLimpiar1.UseVisualStyleBackColor = True

        lblTextoCategoria.AutoSize = True
        lblTextoCategoria.Location = New System.Drawing.Point(30, 270)
        lblTextoCategoria.Text = "Categoría:"

        lblCategoria.AutoSize = True
        lblCategoria.Location = New System.Drawing.Point(160, 270)
        lblCategoria.Name = "lblCategoria"
        lblCategoria.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)

        lblTextoIva1.AutoSize = True
        lblTextoIva1.Location = New System.Drawing.Point(30, 310)
        lblTextoIva1.Text = "IVA (16%):"

        lblIva.AutoSize = True
        lblIva.Location = New System.Drawing.Point(160, 310)
        lblIva.Name = "lblIva"

        lblTextoPrecioFinal.AutoSize = True
        lblTextoPrecioFinal.Location = New System.Drawing.Point(30, 350)
        lblTextoPrecioFinal.Text = "Precio Final:"

        lblPrecioFinal.AutoSize = True
        lblPrecioFinal.Location = New System.Drawing.Point(160, 350)
        lblPrecioFinal.Name = "lblPrecioFinal"
        lblPrecioFinal.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)

        tabEj1.Controls.Add(lblNombre)
        tabEj1.Controls.Add(txtNombre)
        tabEj1.Controls.Add(lblPrecioEj1)
        tabEj1.Controls.Add(txtPrecio)
        tabEj1.Controls.Add(btnClasificar)
        tabEj1.Controls.Add(btnLimpiar1)
        tabEj1.Controls.Add(lblTextoCategoria)
        tabEj1.Controls.Add(lblCategoria)
        tabEj1.Controls.Add(lblTextoIva1)
        tabEj1.Controls.Add(lblIva)
        tabEj1.Controls.Add(lblTextoPrecioFinal)
        tabEj1.Controls.Add(lblPrecioFinal)

        ' ── Tab 2 ────────────────────────────────────────────────────────
        tabEj2.Name = "tabEj2"
        tabEj2.Padding = New Padding(20)
        tabEj2.Text = "Ejercicio 2 – Carrito"
        tabEj2.UseVisualStyleBackColor = True

        lblNombreProducto.AutoSize = True
        lblNombreProducto.Location = New System.Drawing.Point(30, 25)
        lblNombreProducto.Text = "Nombre del Producto:"

        txtNombreProducto.Location = New System.Drawing.Point(30, 55)
        txtNombreProducto.Size = New System.Drawing.Size(600, 28)
        txtNombreProducto.Name = "txtNombreProducto"
        txtNombreProducto.TabIndex = 0

        lblPrecioProducto.AutoSize = True
        lblPrecioProducto.Location = New System.Drawing.Point(30, 105)
        lblPrecioProducto.Text = "Precio:"

        txtPrecioProducto.Location = New System.Drawing.Point(30, 135)
        txtPrecioProducto.Size = New System.Drawing.Size(600, 28)
        txtPrecioProducto.Name = "txtPrecioProducto"
        txtPrecioProducto.TabIndex = 1

        btnAgregar.Location = New System.Drawing.Point(30, 185)
        btnAgregar.Size = New System.Drawing.Size(120, 35)
        btnAgregar.Text = "Agregar"
        btnAgregar.Name = "btnAgregar"
        btnAgregar.TabIndex = 2
        btnAgregar.UseVisualStyleBackColor = True

        lstProductos.Location = New System.Drawing.Point(30, 240)
        lstProductos.Size = New System.Drawing.Size(600, 140)
        lstProductos.Name = "lstProductos"
        lstProductos.FormattingEnabled = True
        lstProductos.TabIndex = 3

        lblTextoSubtotal.AutoSize = True
        lblTextoSubtotal.Location = New System.Drawing.Point(30, 400)
        lblTextoSubtotal.Text = "Subtotal:"

        lblSubtotal.AutoSize = True
        lblSubtotal.Location = New System.Drawing.Point(160, 400)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Text = "$0.00"

        lblTextoIva2.AutoSize = True
        lblTextoIva2.Location = New System.Drawing.Point(30, 435)
        lblTextoIva2.Text = "IVA (16%):"

        lblIva2.AutoSize = True
        lblIva2.Location = New System.Drawing.Point(160, 435)
        lblIva2.Name = "lblIva2"
        lblIva2.Text = "$0.00"

        lblTextoTotal.AutoSize = True
        lblTextoTotal.Location = New System.Drawing.Point(30, 470)
        lblTextoTotal.Text = "Total:"

        lblTotal.AutoSize = True
        lblTotal.Location = New System.Drawing.Point(160, 470)
        lblTotal.Name = "lblTotal"
        lblTotal.Text = "$0.00"
        lblTotal.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)

        btnGenerarTicket.Location = New System.Drawing.Point(30, 520)
        btnGenerarTicket.Size = New System.Drawing.Size(160, 35)
        btnGenerarTicket.Text = "Generar Ticket"
        btnGenerarTicket.Name = "btnGenerarTicket"
        btnGenerarTicket.TabIndex = 4
        btnGenerarTicket.UseVisualStyleBackColor = True

        btnLimpiar2.Location = New System.Drawing.Point(210, 520)
        btnLimpiar2.Size = New System.Drawing.Size(120, 35)
        btnLimpiar2.Text = "Limpiar"
        btnLimpiar2.Name = "btnLimpiar2"
        btnLimpiar2.TabIndex = 5
        btnLimpiar2.UseVisualStyleBackColor = True

        tabEj2.Controls.Add(lblNombreProducto)
        tabEj2.Controls.Add(txtNombreProducto)
        tabEj2.Controls.Add(lblPrecioProducto)
        tabEj2.Controls.Add(txtPrecioProducto)
        tabEj2.Controls.Add(btnAgregar)
        tabEj2.Controls.Add(lstProductos)
        tabEj2.Controls.Add(lblTextoSubtotal)
        tabEj2.Controls.Add(lblSubtotal)
        tabEj2.Controls.Add(lblTextoIva2)
        tabEj2.Controls.Add(lblIva2)
        tabEj2.Controls.Add(lblTextoTotal)
        tabEj2.Controls.Add(lblTotal)
        tabEj2.Controls.Add(btnGenerarTicket)
        tabEj2.Controls.Add(btnLimpiar2)

        ' ── Tab 3 ────────────────────────────────────────────────────────
        tabEj3.Name = "tabEj3"
        tabEj3.Padding = New Padding(20)
        tabEj3.Text = "Ejercicio 3 – Inventario"
        tabEj3.UseVisualStyleBackColor = True

        lblBuscar.AutoSize = True
        lblBuscar.Location = New System.Drawing.Point(30, 40)
        lblBuscar.Text = "Nombre del producto a buscar:"

        txtBusqueda1.Location = New System.Drawing.Point(30, 75)
        txtBusqueda1.Size = New System.Drawing.Size(600, 28)
        txtBusqueda1.Name = "txtBusqueda1"
        txtBusqueda1.TabIndex = 0

        btnBuscar.Location = New System.Drawing.Point(30, 130)
        btnBuscar.Size = New System.Drawing.Size(120, 35)
        btnBuscar.Text = "Buscar"
        btnBuscar.Name = "btnBuscar"
        btnBuscar.TabIndex = 1
        btnBuscar.UseVisualStyleBackColor = True

        lblResultado.AutoSize = True
        lblResultado.Location = New System.Drawing.Point(30, 195)
        lblResultado.Name = "lblResultado"
        lblResultado.Text = "Resultado"

        tabEj3.Controls.Add(lblBuscar)
        tabEj3.Controls.Add(txtBusqueda1)
        tabEj3.Controls.Add(btnBuscar)
        tabEj3.Controls.Add(lblResultado)

        ' ── Formulario principal ─────────────────────────────────────────
        AutoScaleDimensions = New System.Drawing.SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(840, 680)
        Controls.Add(tabControl1)
        Font = New System.Drawing.Font("Segoe UI", 10)
        Name = "Form1"
        Text = "Ejercicios Combinados"
        tabControl1.ResumeLayout(False)
        tabEj1.ResumeLayout(False)
        tabEj1.PerformLayout()
        tabEj2.ResumeLayout(False)
        tabEj2.PerformLayout()
        tabEj3.ResumeLayout(False)
        tabEj3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    ' ── Declaraciones ────────────────────────────────────────────────────
    Friend WithEvents tabControl1 As TabControl
    Friend WithEvents tabEj1 As TabPage
    Friend WithEvents tabEj2 As TabPage
    Friend WithEvents tabEj3 As TabPage

    ' Ejercicio 1
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblPrecioEj1 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents btnClasificar As Button
    Friend WithEvents btnLimpiar1 As Button
    Friend WithEvents lblTextoCategoria As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblTextoIva1 As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents lblTextoPrecioFinal As Label
    Friend WithEvents lblPrecioFinal As Label

    ' Ejercicio 2
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents lblPrecioProducto As Label
    Friend WithEvents txtPrecioProducto As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lstProductos As ListBox
    Friend WithEvents lblTextoSubtotal As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTextoIva2 As Label
    Friend WithEvents lblIva2 As Label
    Friend WithEvents lblTextoTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnGenerarTicket As Button
    Friend WithEvents btnLimpiar2 As Button

    ' Ejercicio 3
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBusqueda1 As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblResultado As Label

End Class
