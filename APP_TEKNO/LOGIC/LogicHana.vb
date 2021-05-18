
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports PdfSharp
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing

Public Class LogicHana
    Private maTamaño() As Integer
    Private miTamaño As Integer = 0
    Private miPaginas As Integer = 0
    Private miPaginaActual As Integer

    Public Function generar_pedido(ByVal dt As DataGridView, ByVal proveedor As String) As String
        Dim obj As New ConexionSAP()
        Dim result = "False"
        Try
            result = obj.GenerarPedido(dt)
        Catch ex As Exception
            result = "False"
            'MsgBox(ex.Message)
        End Try

        Return result
    End Function

    Private Sub lP_ImprimirDGV(ByRef dt As DataGridView, ByVal proveedor As String)
        Dim ldSaltoLinea As Double
        ' Crea el documento Pdf
        Dim rowa = dt.Rows.Count
        Dim Documento As PdfDocument = New PdfDocument
        ' Crea un objeto pagina
        Dim Pagina As PdfPage
        ' Añade una pagina vacia
        Pagina = Documento.AddPage
        Pagina.Size = PageSize.A4
        ' Crea un Objeto XGraphics
        Dim Grafico As XGraphics
        ' Asigna un Objeto XGraphics a la pagina
        Grafico = XGraphics.FromPdfPage(Pagina)
        ' Crea un Objeto LapizPDF
        Dim miBoli As New LapizPDF(Grafico)
        ' Crea la fuente
        Dim FuenteLinea As XFont = New XFont("Arial", 10, XFontStyle.Regular)
        Dim FuenteCabecera As XFont = New XFont("Arial", 12, XFontStyle.Bold)
        Dim FuenteTitulo As XFont = New XFont("Arial", 16, XFontStyle.Bold)
        ldSaltoLinea = FuenteLinea.GetHeight(Grafico)
        Dim Archivo As String = "C:\Users\admin\Desktop\DesCon\PRUEBA.pdf"
        Dim liLinea As Integer = 0
        Dim liAncho As Integer
        Dim liAlto As Integer
        Dim liAltomodulo As Integer = 50
        Dim liNumLineas As Integer
        Dim miPaginaActual As Integer = 0
        If miTamaño > 570 Then
            Pagina.Orientation = PageOrientation.Landscape
            liAncho = 820
            liAlto = 575
        Else
            Pagina.Orientation = PageOrientation.Portrait
            liAncho = 575
            liAlto = 820
        End If
        liNumLineas = CInt(((liAlto - (liAltomodulo * 3)) / CInt(ldSaltoLinea)) - 3)
        If dt.RowCount Mod liNumLineas = 0 Then
            miPaginas = dt.RowCount \ liNumLineas
        Else
            miPaginas = (dt.RowCount \ liNumLineas) + 1
        End If
        miPaginaActual += 1
        Dim miDgv As New DGVImpreso(Grafico, CInt(ldSaltoLinea), 30, 30, liAncho, liAlto, liAltomodulo, maTamaño)
        'IMPRIMIR LA CABECERA
        miDgv.Cabecera(dt, miBoli, FuenteCabecera, FuenteTitulo, "PEDIDO", proveedor)
        liLinea = 0

        'recorrer todo el datagrid
        For Each loFila As DataGridViewRow In dt.Rows
            If liLinea = liNumLineas Then
                miDgv.Pie(miBoli, FuenteCabecera, miPaginaActual, miPaginas)
                liLinea = 0
                ' Añade una pagina vacia
                Pagina = Documento.AddPage
                Pagina.Size = PageSize.A4
                If miTamaño > 570 Then
                    Pagina.Orientation = PageOrientation.Landscape
                Else
                    Pagina.Orientation = PageOrientation.Portrait
                End If
                ' Asigna un Objeto XGraphics a la pagina
                Grafico = XGraphics.FromPdfPage(Pagina)
                ' Asigna un Objeto LapizPDF al Grafico
                miBoli = New LapizPDF(Grafico)
                miDgv = New DGVImpreso(Grafico, CInt(ldSaltoLinea), 30, 30, liAncho, liAlto, liAltomodulo, maTamaño)
                miPaginaActual += 1
                'IMPRIMIR LA CABECERA
                miDgv.Cabecera(dt, miBoli, FuenteCabecera, FuenteTitulo, "PEDIDO", proveedor)
            End If
            'Imprimir Linea
            miDgv.Linea(loFila, miBoli, FuenteLinea)
            liLinea += 1
        Next
        '  miDgv.Pie(miBoli, FuenteCabecera, miPaginaActual, miPaginas)
        Try
            'si el archivo esta abierto da error, para que averiguen como saber si el archivo esta abierto y cerrarlo antes de grabar uno nuevo
            Documento.Save(Archivo)
            Process.Start(Archivo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "lP_Imprimir", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        End Try
    End Sub
    Public Function getArticulos(ByVal proveedor As String, ByVal fechaIni As String, ByVal FechaFin As String) As DataTable

        Dim tabla As DataTable
        Dim result As DataTable
        Try

            ''add
            Dim retVal = 0
            Dim fechaIn = Convert.ToDateTime(fechaIni)
            Dim FechaFi = Convert.ToDateTime(FechaFin)

            Dim tt = FechaFi - fechaIn
            Dim totalWeeks = tt.Days / 7
            Dim semanas = totalWeeks
            Dim numero As Double = semanas / 4.345
            Dim meses As Integer = Math.Round(numero)
            'Dim meses = Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Month, fechaIn, FechaFi) + 1
            ''add
            Dim obj As New MethodHana()

            tabla = obj.getArticulos(fechaIni, FechaFin, proveedor)
            'Dim qry = (From myDataRow In tabla.AsEnumerable() Where myDataRow.Field(Of String)("CardCode") = proveedor)

            'result = qry.CopyToDataTable()
            ''ECUACIONES
            Dim x As DBNull
            For Each r As DataRow In tabla.Rows
                If Not IsDBNull(r("Pedido")) Then
                    r("Pedido") = Math.Round(Double.Parse(r("Pedido").ToString()), 2, MidpointRounding.ToEven)
                Else
                    r("Pedido") = 0
                End If

                If Not IsDBNull(r("Actual")) Then
                    r("Actual") = Math.Round(Double.Parse(r("Actual")), 2, MidpointRounding.ToEven)
                Else
                    r("Actual") = 0
                End If

                r("Total") = Double.Parse(r("Actual")) + Double.Parse(r("Pedido"))

                Dim _sum = (From myDataRow In tabla.AsEnumerable() Where Not IsDBNull(myDataRow.Item("Estado")) AndAlso myDataRow.Field(Of String)("Estado") = r("Estado"))
                Dim sum = 0
                For Each r2 As DataRow In tabla.Rows
                    If Not IsDBNull(r2("ConsumoMensual")) Then
                        sum = sum + Convert.ToDouble(r2("ConsumoMensual"))
                    End If

                Next
                If IsDBNull(r("ConsumoMensual")) Then
                    r("ConsumoMensual") = 0
                Else
                    r("ConsumoMensual") = Math.Round((Convert.ToDouble(r("ConsumoMensual")) / meses), 2, MidpointRounding.ToEven)
                End If

                If Not IsDBNull(r("ConsumoMensual")) Then
                    r("Porcentaje") = (Double.Parse(r("ConsumoMensual")) / Double.Parse(sum)) * 100
                Else
                    r("Porcentaje") = (0 / Double.Parse(sum)) * 100
                End If
                If Not IsDBNull(r("ConsumoMensual")) Then
                    Dim MesesBod = Double.Parse(r("Total")) / Double.Parse(r("ConsumoMensual"))
                    If (MesesBod.ToString().Contains("NaN") Or MesesBod.ToString().Contains("∞")) Then
                        r("MesesBod") = 0
                    Else
                        r("MesesBod") = Math.Round(Double.Parse(MesesBod.ToString()), 2, MidpointRounding.ToEven)
                    End If
                Else
                    Dim MesesBod = Double.Parse(r("Total")) / Double.Parse(0)
                    If (MesesBod.ToString().Contains("NaN") Or MesesBod.ToString().Contains("∞")) Then
                        r("MesesBod") = 0
                    Else
                        r("MesesBod") = Math.Round(Double.Parse(MesesBod.ToString()), 2, MidpointRounding.ToEven)
                    End If
                End If
                Try

                    If IsDBNull(r("Custom0")) Then
                        r("Custom0") = 0
                    End If

                    r("MesesInv") = Math.Round((((Double.Parse(r("MesesBod")) * 4) - Double.Parse(r("Custom0"))) / 4), 2, MidpointRounding.ToEven)
                    ''(((Double.Parse(r("MesesBod")) * 4) - Double.Parse(r("Custom0"))) / semanas)

                    r("Custom1") = Math.Round((Double.Parse(r("Actual")) / Double.Parse(r("ConsumoMensual"))), 2, MidpointRounding.ToEven)
                    r("Custom2") = Math.Round((Double.Parse(r("Pedido")) / Double.Parse(r("ConsumoMensual"))), 2, MidpointRounding.ToEven)
                    r("Custom3") = Math.Round((Double.Parse(r("Custom1")) + Double.Parse(r("Custom2"))), 2, MidpointRounding.ToEven)

                    If (r("Custom1").ToString().Contains("NaN") Or r("Custom1").ToString().Contains("∞")) Then
                        r("Custom1") = 0
                    End If
                    If (r("Custom2").ToString().Contains("NaN") Or r("Custom2").ToString().Contains("∞")) Then
                        r("Custom2") = 0
                    End If
                    If (r("Custom3").ToString().Contains("NaN") Or r("Custom3").ToString().Contains("∞")) Then
                        r("Custom3") = 0
                    End If
                    If (r("MesesInv").ToString().Contains("NaN") Or r("MesesInv").ToString().Contains("∞")) Then
                        r("MesesInv") = 0
                    End If
                    If (r("Porcentaje").ToString().Contains("NaN") Or r("Porcentaje").ToString().Contains("∞")) Then
                        r("Porcentaje") = 0
                    End If

                    If Not IsDBNull(r("Precio")) Then
                        r("Precio") = r("Precio")
                    Else
                        r("Precio") = "0"
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


            Next

        Catch ex As System.Exception
            tabla = New DataTable()
        End Try
        Return tabla
    End Function

    Public Function getProveedor() As DataTable
        Dim tabla As DataTable
        Try
            Dim obj As New MethodHana()

            tabla = obj.getProveedor()
        Catch ex As System.Exception
            tabla = New DataTable()
        End Try
        Return tabla
    End Function
End Class
