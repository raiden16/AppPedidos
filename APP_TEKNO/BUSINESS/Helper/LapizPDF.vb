Option Explicit On
Option Strict On
Imports System.IO
Imports PdfSharp
Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.IO
Imports PdfSharp.Drawing
Imports PdfSharp.Drawing.Layout
Imports System.Drawing

Public Class LapizPDF
    Private mGrafico As XGraphics

    Public Property Grafico() As XGraphics
        Get
            Return mGrafico
        End Get
        Set(ByVal Value As XGraphics)
            mGrafico = Value
        End Set
    End Property

    Public Sub New(ByVal objGrafico As XGraphics)
        mGrafico = objGrafico
    End Sub

    Public Sub CuadroRedondo(ByVal PosX As Integer, ByVal PosY As Integer, ByVal Ancho As Integer, ByVal Alto As Integer, ByVal Grosor As Integer, Optional ByVal Sombra As Boolean = False)
        Dim Cuadro As XRect = New XRect(PosX, PosY, Ancho, Alto)
        Dim Lapiz As XPen = New XPen(XColor.FromArgb(0, 0, 0), Grosor)
        Dim Elipse As XSize
        Elipse.Height = 10
        Elipse.Width = 10
        If Sombra = True Then
            mGrafico.DrawRoundedRectangle(Lapiz, XBrushes.White, Cuadro, Elipse)
        Else
            mGrafico.DrawRoundedRectangle(Lapiz, Cuadro, Elipse)
        End If
    End Sub

    Public Sub CuadroRecto(ByVal PosX As Integer, ByVal PosY As Integer, ByVal Ancho As Integer, ByVal Alto As Integer, ByVal Grosor As Integer, Optional ByVal Sombra As Boolean = False)
        Dim Cuadro As XRect = New XRect(PosX, PosY, Ancho, Alto)
        Dim Lapiz As XPen = New XPen(XColor.FromArgb(0, 0, 0), Grosor)
        If Sombra = True Then
            mGrafico.DrawRectangle(Lapiz, XBrushes.White, Cuadro)
        Else
            mGrafico.DrawRectangle(Lapiz, Cuadro)
        End If
    End Sub

    Public Sub LineaH(ByVal PosX1 As Integer, ByVal PosY1 As Integer, ByVal Ancho As Integer, ByVal Grosor As Integer)
        Dim Lapiz As XPen = New XPen(XColor.FromArgb(0, 0, 0), Grosor)
        Dim Punto1 As New Point(PosX1, PosY1)
        Dim Punto2 As New Point(PosX1 + Ancho, PosY1)
        mGrafico.DrawLine(Lapiz, Punto1, Punto2)
    End Sub

    Public Sub LineaV(ByVal PosX1 As Integer, ByVal PosY1 As Integer, ByVal Alto As Integer, ByVal Grosor As Integer)
        Dim Lapiz As XPen = New XPen(XColor.FromArgb(0, 0, 0), Grosor)
        Dim Punto1 As New Point(PosX1, PosY1)
        Dim Punto2 As New Point(PosX1, PosY1 + Alto - 20)
        mGrafico.DrawLine(Lapiz, Punto1, Punto2)
    End Sub

    Public Sub Texto(ByVal lsTexto As String, ByVal Fuente As XFont, ByVal brush As XBrush, ByVal PosX As Integer, ByVal PosY As Integer)
        mGrafico.DrawString(lsTexto, Fuente, brush, PosX, PosY)
    End Sub

    Public Sub Imagen(ByVal Imagen As XImage, ByVal PosX As Integer, ByVal PosY As Integer, ByVal Ancho As Integer, ByVal Alto As Integer)
        mGrafico.DrawImage(Imagen, PosX, PosY, Ancho, Alto)
    End Sub

    Public Sub TextoFormateado(ByVal lsTexto As String, ByVal Fuente As XFont, ByVal brush As XBrush, ByVal PosX As Integer, ByVal PosY As Integer, ByVal Ancho As Integer, ByVal Alto As Integer, ByVal Alinear As Integer)
        Dim Formateador As XTextFormatter       ' Objeto para formatear texto  
        Dim Rect As New XRect(PosX, PosY, Ancho, Alto)
        Formateador = New XTextFormatter(Grafico)
        Formateador.Alignment = CType(Alinear, XParagraphAlignment)
        Formateador.DrawString(lsTexto, Fuente, brush, Rect)
    End Sub
End Class