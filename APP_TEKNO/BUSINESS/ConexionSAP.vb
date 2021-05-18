Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports APP_TEKNO.MethodHana

Public Class ConexionSAP

    Dim company As SAPbobsCOM.Company = New SAPbobsCOM.Company()


    Public sErrMsg As String
    Public lErrCode As Integer
    Public lRetCode As Integer

    ' Public

    Public Function ConectarSBO() As String
        Try
            Dim lRetCode, ErrorCode As Long
            Dim ErrorMessage As String = ""


            company.LicenseServer = My.Settings.Licencia
            company.UserName = My.Settings.UsuarioSAP
            company.Password = My.Settings.PasswordSAP
            company.Server = My.Settings.ServidorHANA
            company.CompanyDB = My.Settings.Empresa
            company.DbPassword = My.Settings.PasswordHANA
            company.DbUserName = My.Settings.UsuarioHANA
            company.UseTrusted = False
            company.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_HANADB
            lRetCode = company.Connect()

            If lRetCode <> 0 Then
                Try
                    Dim errMsg = company.GetLastErrorDescription()
                    Dim ErrNo = company.GetLastErrorCode()
                    company.GetLastError(ErrorCode, ErrorMessage)
                    ConectarSBO = "Desconectado"
                Catch ex As Exception
                    ConectarSBO = "Desconectado"
                End Try

                ConectarSBO = "Desconectado"

            Else
                ConectarSBO = "Conectado"
            End If
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
        End Try

    End Function

    Dim Prov As String



    Public Function GenerarPedido(ByVal dt As DataGridView) As String
        Dim OPedido
        Dim creado = False
        Dim NPedido As String = ""
        Dim obj As New MethodHana()
        Prov = dt.Rows(0).Cells(2).Value
        Try
            Dim conexion = ConectarSBO()
            If (conexion = "Conectado") Then


                OPedido = company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oPurchaseOrders)
                NPedido = dt.Rows(0).Cells(1).Value
                OPedido.CardCode = dt.Rows(0).Cells(2).Value
                OPedido.DocCurrency = obj.GetMonedaLista(dt.Rows(0).Cells(3).Value)
                'Pedido.OwnerCode = My.Settings.NumPropietario
                If (dt.Rows(0).Cells("proyecto").Value) Then
                    OPedido.UserFields.Fields.Item("U_proyecto").Value = "1"
                    OPedido.UserFields.Fields.Item("U_referencia").Value = dt.Rows(0).Cells("referencia").Value
                Else
                    OPedido.UserFields.Fields.Item("U_proyecto").Value = "2"
                End If
                OPedido.DocDate = DateTime.Now
                OPedido.DocDueDate = DateTime.Now


                For Each row As DataGridViewRow In dt.Rows
                    If (row.Cells(0).Value) Then

                        If (NPedido <> row.Cells(1).Value) Then
                            lErrCode = OPedido.Add()
                            If (lErrCode <> 0) Then
                                Dim errMsg = company.GetLastErrorDescription()
                                Dim ErrNo = company.GetLastErrorCode()
                                creado = False
                                MsgBox("Ocurrio un error " & company.GetLastErrorDescription)
                            Else

                                'company.Disconnect()

                                creado = True

                                Dim stDocEntry As String
                                company.GetNewObjectCode(stDocEntry)
                                Reporte(stDocEntry.ToString(), Prov)
                                '  MsgBox("Pedido Generado con exito")
                            End If

                            OPedido = company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oPurchaseOrders)
                            NPedido = row.Cells(1).Value
                            OPedido.CardCode = dt.Rows(0).Cells(2).Value
                            OPedido.DocCurrency = obj.GetMonedaLista(dt.Rows(0).Cells(3).Value)
                            'Pedido.OwnerCode = My.Settings.NumPropietario
                            OPedido.DocDate = DateTime.Now
                            OPedido.DocDueDate = DateTime.Now

                            OPedido.Comments = row.Cells("comentarios").Value + " W" + DatePart("ww", Now).ToString("00")
                            If (row.Cells("proyecto").Value) Then
                                OPedido.UserFields.Fields.Item("U_proyecto").Value = "1"
                                OPedido.UserFields.Fields.Item("U_referencia").Value = row.Cells("referencia").Value
                            Else
                                OPedido.UserFields.Fields.Item("U_proyecto").Value = "2"
                            End If

                        End If
                        OPedido.Comments = row.Cells("comentarios").Value + " W" + DatePart("ww", Now).ToString("00")
                        If (row.Cells("proyecto").Value) Then
                            OPedido.UserFields.Fields.Item("U_proyecto").Value = "1"
                            OPedido.UserFields.Fields.Item("U_referencia").Value = row.Cells("referencia").Value
                        Else
                            OPedido.UserFields.Fields.Item("U_proyecto").Value = "2"
                        End If
                        OPedido.Lines.ItemCode = row.Cells(3).Value

                        OPedido.Lines.Quantity = (row.Cells(5).Value * obj.GetCanrtidadPorPaquete(row.Cells(3).Value))
                        OPedido.Lines.UserFields.Fields.Item("U_Pallets").Value = row.Cells(5).Value
                        OPedido.Lines.Price = obj.GetPrecioLista(row.Cells(3).Value) '  row.Cells("Precio").Value
                        OPedido.Lines.Currency = obj.GetMonedaLista(row.Cells(3).Value)
                        OPedido.Lines.BaseLine = "0"
                        OPedido.Lines.Add()

                        NPedido = row.Cells(1).Value
                    End If
                Next

                lErrCode = OPedido.Add()
                If (lErrCode <> 0) Then
                    Dim errMsg = company.GetLastErrorDescription()
                    Dim ErrNo = company.GetLastErrorCode()
                    creado = False
                    MsgBox("Ocurrio un error " & company.GetLastErrorDescription)
                Else
                    Dim stDocEntry As String
                    company.GetNewObjectCode(stDocEntry)

                    Reporte(stDocEntry.ToString(), Prov)
                    company.Disconnect()
                    creado = True
                    '  MsgBox("Pedido Generado con exito")

                End If
            End If

        Catch ex As Exception
            creado = False
            MsgBox("Error Generar Pedido: " + ex.Message)
        End Try

        Return creado
    End Function


    Public Function Reporte(ByVal DocEntry As String, ByVal CardCode As String) As Boolean
        Try
            Dim ocInforme As New ReportDocument
            Dim fileName As String
            Dim obj As New MethodHana()
            Dim DocNum As Integer
            ocInforme.Load(Application.StartupPath & "\Pedido_de_Compra_.rpt")

            For Each var As Table In ocInforme.Database.Tables
                Dim boTableLogOnInfo As TableLogOnInfo = var.LogOnInfo
                boTableLogOnInfo.ConnectionInfo.ServerName = My.Settings.ServidorHANA
                boTableLogOnInfo.ConnectionInfo.UserID = My.Settings.UsuarioHANA
                boTableLogOnInfo.ConnectionInfo.Password = My.Settings.PasswordHANA
                boTableLogOnInfo.ConnectionInfo.DatabaseName = My.Settings.Empresa
                var.ApplyLogOnInfo(boTableLogOnInfo)
            Next
            ocInforme.SetParameterValue("DocKey@", DocEntry) '
            ocInforme.SetDatabaseLogon(My.Settings.UsuarioHANA, My.Settings.PasswordHANA, My.Settings.ServidorHANA, My.Settings.Empresa)
            DocNum = obj.GetDocNumPedido(DocEntry)
            fileName = ExportToPDF(ocInforme, DocNum.ToString() + ".pdf")

            Return True
        Catch ex As Exception
            MsgBox("Error de impresión: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function ExportToPDF(rpt As ReportDocument, NombreArchivo As String) As String
        Dim vFileName As String = Nothing
        Dim diskOpts As New DiskFileDestinationOptions()

        Try
            rpt.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
            rpt.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat

            'Este es la ruta donde se guardara tu archivo.
            vFileName = "c:\Reporte\Temp\" & NombreArchivo
            If File.Exists(vFileName) Then
                File.Delete(vFileName)
            End If
            diskOpts.DiskFileName = vFileName
            rpt.ExportOptions.DestinationOptions = diskOpts
            rpt.Export()
        Catch ex As Exception
            Throw ex
        End Try

        Return vFileName
    End Function

End Class
