Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
'Imports System.Web.Mail
Imports System.IO
Imports System.Xml
Imports System.Linq
Imports System.Xml.Linq
Imports System.Net.Mail


Public Class EmailD
    Inherits System.Web.UI.Page
    Dim CON, Con1 As SqlConnection
    Dim objConn As SqlConnection
    Dim ADA As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, DR2, DR3 As SqlDataReader
    Dim DS As DataSet
    Dim DV As DataView
    Dim sinvno As String
    Dim LOD, body As String
    Dim dt1 As Date
    Dim drt2, drt3, Dtr1 As DataRow
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim SS, SS1 As String
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Dim CRI1, CRI2, CRI3 As String
    Dim str1, str2 As String
    Dim q, r, s As String
    Dim p, t As Double
    Dim InvFlag2 As String
    Dim count1, count As Integer
    Dim depno As String
    Dim depname As String
    Dim S1(10) As String
    Dim epfno As String
    Dim oStream As New MemoryStream
    Dim I1, I2 As Integer
    Dim Sitmno As String
    Dim TT1 As String
    Dim SRef As String
    'Dim SQty As Double
    Dim SVal As Integer
    Dim filename, path, filename1 As String
    Dim InvLink As String
    Dim InvEmail As String
    Dim InvEPwd As String

    Protected WithEvents BtnSubmit As System.Web.UI.WebControls.Button
    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
    Dim TT As String
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents LstCode As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstVat As System.Web.UI.WebControls.DropDownList

    Protected WithEvents LstFlag2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtPer As System.Web.UI.WebControls.TextBox

    Protected WithEvents ImgBt As System.Web.UI.WebControls.ImageButton

    Protected WithEvents LstTT As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Lstvat1 As System.Web.UI.WebControls.DropDownList


    Protected WithEvents txtEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents BttEmpNo As System.Web.UI.WebControls.Button
    Protected WithEvents TxtEpfNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtDepNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtCom As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtRefno As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtBillDt As System.Web.UI.WebControls.TextBox

    Protected WithEvents Label20 As System.Web.UI.WebControls.Label

    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer

    Protected WithEvents TxtCncy As System.Web.UI.WebControls.TextBox

    Protected WithEvents TxtJobNo As System.Web.UI.WebControls.TextBox

    Protected WithEvents TxtTerm As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtPol As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtNoPkg As System.Web.UI.WebControls.TextBox

    Protected WithEvents Label35 As System.Web.UI.WebControls.Label
    Protected WithEvents txtFcncy As System.Web.UI.WebControls.TextBox

    Protected WithEvents TxtCdty As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtRem As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtCon As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents TxtEta As System.Web.UI.WebControls.TextBox


    Protected WithEvents TxtPkgTyp As System.Web.UI.WebControls.TextBox

    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtSno As System.Web.UI.WebControls.TextBox

    Protected WithEvents TxtAdno As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtcncy1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtNoCntr1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtNoCntr2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtNoCntr3 As System.Web.UI.WebControls.TextBox

    Protected WithEvents Label27 As System.Web.UI.WebControls.Label

    Protected WithEvents Label29 As System.Web.UI.WebControls.Label

    Protected WithEvents Label30 As System.Web.UI.WebControls.Label

    Protected WithEvents Label33 As System.Web.UI.WebControls.Label

    Protected WithEvents Label39 As System.Web.UI.WebControls.Label

    Protected WithEvents Imagebutton9 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents LstConTyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtNqty As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtCntNo As System.Web.UI.WebControls.TextBox


    Protected WithEvents Txtfg1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtfg2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtfg3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtfg4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtfg6 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtfg5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtfg7 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtfg8 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtfg9 As System.Web.UI.WebControls.TextBox

    Protected WithEvents Label7 As System.Web.UI.WebControls.Label




    Protected WithEvents TxtDes1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtdes2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtdes3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtdes4 As System.Web.UI.WebControls.TextBox

    Protected strCountry As String



#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Protected WithEvents LstInvNo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Invoice As System.Web.UI.WebControls.Label


    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Put user code to initialize the page here

        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SIB; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
        CON.Open()

        'If Not IsPostBack Then
        t = t + 1

        'End If
        '        YY = Right(Trim(Year(Format(Date.Today))), 2)
        If Not IsPostBack Then

            If t = 1 Then
                SendHTMLMail()
                SendHTMLMail1()
                t = t + 1

            End If
        End If







    End Sub


    Public Sub SendHTMLMail()
        Dim reader As New StreamReader(Server.MapPath("~/HTMLPage1.htm"))
        Dim readFile As String = reader.ReadToEnd()
        Dim myString As String = ""

        Try



            SS = Format(Today(), "dd/MM/yyyy")


            CMD = New SqlCommand("SELECT * FROM Refno", CON)


            DR = CMD.ExecuteReader



            Dim Msg As New MailMessage()
            Dim fromMail As New MailAddress("insurance@samsoncorporates.com")



            Dim sSmtpServer As String = ""
            sSmtpServer = "smtp.dtechlk.com"
            Dim a As New SmtpClient()
            a.Host = sSmtpServer

            a.Credentials = New Net.NetworkCredential("insurance@samsoncorporates.com", "Xsw%wsx%7378##")
            a.Port = 587
            a.EnableSsl = True
            a.Host = "smtp.dtechlk.com"
            'a.Send(Msg)

            reader.Dispose()

            '------

            Dim htmlContent As New StringBuilder()

            ' Start HTML document
            htmlContent.AppendLine("<!DOCTYPE html>")
            htmlContent.AppendLine("<html lang='en'>")
            htmlContent.AppendLine("<head>")
            htmlContent.AppendLine("<meta charset='utf-8'>")
            htmlContent.AppendLine("<meta name='viewport' content='width=device-width, initial-scale=1.0'>")
            htmlContent.AppendLine("<title>SIB Pending List</title>")

            htmlContent.AppendLine("<style>")
            htmlContent.AppendLine("        body { background-color: #f0f0f0; font-family: Calibri, Calibri; }")

            htmlContent.AppendLine("        h1 { color: #007bff; text-align: left; margin: 0 0 20px 0; background: url('https://drive.google.com/uc? export=view&id=1JDrL53pr2cfExu5t3o4gZrmz-2scb182'); }")


            htmlContent.AppendLine("</style>")


            htmlContent.AppendLine("</head>")
            htmlContent.AppendLine("<body style='font-family: 'Calibri', sans-serif; font-size: 100%;'>")




            htmlContent.AppendLine("<header class='clearfix'>")
            htmlContent.AppendLine("<div id='logo'>")
            htmlContent.AppendLine("<img src='https://drive.google.com/uc? export=view&id=19ktNCRCa81CH2PhLXhne0J2pYpLfkRGs' alt='Your Image' />")
            htmlContent.AppendLine("</div>")

            htmlContent.AppendLine("<h1>SIB Pending List</h1>")

            htmlContent.AppendLine("</header>")

            htmlContent.AppendLine("<main>")


            htmlContent.AppendLine("<table border='1' style='width: 80%; border-collapse: collapse; text-align: left;'>")

            htmlContent.AppendLine("<tr>")


            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff; text-align: Center;'>Refernce No  </td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff; text-align: Center;'>Policy Date</td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff; text-align: Center;'>Policy No </td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff; text-align: Center;'>Debit No    </td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff; text-align: Center;'>Type  </td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff; text-align: Center;'>Vehicle No</td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff; text-align: Center;'>Customer </td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff; text-align: Center;'>Company  </td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff; text-align: Center;'>Premium </td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff; text-align: center;'>Days</td>")


            htmlContent.AppendLine("</tr>")



            Con1 = New SqlConnection
            Con1.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SIB; user id=sa;password=tstc@123")
            Con1.Open()

            ADA = New SqlDataAdapter("SELECT ID,Refno,PolDt,Customer,PolicyNo,DNNo,Company,TYPE,PREMIUM,VehicleNo from Refno where PaidY<>'Y' order by PolDt ", Con1)

            DS = New DataSet
            ADA.Fill(DS, "Refno")

            count1 = DS.Tables("Refno").Rows.Count

            Dim dys, P As Integer
            Dim Tot As Double
            If count1 <> 0 Then
                P = 1
                Tot = 0
                For Each Me.drt2 In DS.Tables("Refno").Rows


                    Try

                        Dim dateResult As DateTime = DateTime.Parse(drt2("PolDt"))

                        Try
                            dys = (Today() - dateResult).Days
                        Catch ex As Exception
                            dys = 100
                        End Try


                        If dys <= 360 And dys >= 0 Then
                            Try
                                'dataTable.Rows.Add(Trim(drt2("Refno")), Trim(drt2("PolDt")), Trim(drt2("PolicyNo")), Trim(drt2("DNNo")), Trim(drt2("TYPE")), Trim(drt2("Customer")), Trim(drt2("Company")), Format(drt2("PREMIUM"), "#,##0.00"), dys)
                                Tot = Tot + Val(Trim(drt2("PREMIUM")))

                                'If P = 1 Then


                                If dys >= 60 Then
                                    SS = Str(drt2("ID")) + Trim(drt2("Refno")) + Trim(drt2("PolDt")) + Trim(drt2("PolicyNo")) + Trim(drt2("DNNo")) + Trim(drt2("TYPE")) + Trim(drt2("Customer")) + Trim(drt2("Company")) + Trim(drt2("PREMIUM"))
                                    'SS = "*****" + Format(Val(Trim(drt2("PREMIUM"))), "##,###,###.00")
                                    SS = Format(Val(Trim(drt2("PREMIUM"))), "##,###,###.00")

                                    Try
                                        SS1 = Trim(drt2("VehicleNo"))
                                    Catch ex As Exception
                                        '    TxtSAdd.Text = ""
                                        SS1 = "NotAvailable"

                                    End Try

                                    htmlContent.AppendLine("<tr>")
                                    htmlContent.AppendLine("<td style='background-color: #C70039; color: #FDFEFE;'>" & Trim(drt2("Refno")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #C70039; color: #FDFEFE;'>" & Format(DateValue(drt2("PolDt")), "dd/MM/yyyy") & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #C70039; color: #FDFEFE;'>" & Trim(drt2("PolicyNo")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #C70039; color: #FDFEFE;'>" & Trim(drt2("DNNo")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #C70039; color: #FDFEFE;'>" & Trim(drt2("TYPE")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #C70039; color: #FDFEFE;'>" & SS1 & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #C70039; color: #FDFEFE;'>" & Trim(drt2("Customer")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #C70039; color: #FDFEFE;'>" & Trim(drt2("Company")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #C70039; color: #FDFEFE; text-align: right;'>" & SS & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #C70039; color: #FDFEFE; text-align: right;'>" & Val(dys) & "</td>")
                                    htmlContent.AppendLine("</tr>")
                                    P = 0
                                Else


                                    If dys >= 50 Then
                                        SS = Str(drt2("ID")) + Trim(drt2("Refno")) + Trim(drt2("PolDt")) + Trim(drt2("PolicyNo")) + Trim(drt2("DNNo")) + Trim(drt2("TYPE")) + Trim(drt2("Customer")) + Trim(drt2("Company")) + Trim(drt2("PREMIUM"))
                                        'SS = "*****" + Format(Val(Trim(drt2("PREMIUM"))), "##,###,###.00")
                                        SS = Format(Val(Trim(drt2("PREMIUM"))), "##,###,###.00")

                                        Try
                                            SS1 = Trim(drt2("VehicleNo"))
                                        Catch ex As Exception
                                            '    TxtSAdd.Text = ""
                                            SS1 = ""

                                        End Try

                                        htmlContent.AppendLine("<tr>")
                                        htmlContent.AppendLine("<td style='background-color: #FFC0CB; color: #17202A;'>" & Trim(drt2("Refno")) & "</td>")
                                        htmlContent.AppendLine("<td style='background-color: #FFC0CB; color: #17202A;'>" & Format(DateValue(drt2("PolDt")), "dd/MM/yyyy") & "</td>")
                                        htmlContent.AppendLine("<td style='background-color: #FFC0CB; color: #17202A;'>" & Trim(drt2("PolicyNo")) & "</td>")
                                        htmlContent.AppendLine("<td style='background-color: #FFC0CB; color: #17202A;'>" & Trim(drt2("DNNo")) & "</td>")
                                        htmlContent.AppendLine("<td style='background-color: #FFC0CB; color: #17202A;'>" & Trim(drt2("TYPE")) & "</td>")
                                        htmlContent.AppendLine("<td style='background-color: #FFC0CB; color: #17202A;'>" & SS1 & "</td>")
                                        htmlContent.AppendLine("<td style='background-color: #FFC0CB; color: #17202A;'>" & Trim(drt2("Customer")) & "</td>")
                                        htmlContent.AppendLine("<td style='background-color: #FFC0CB; color: #17202A;'>" & Trim(drt2("Company")) & "</td>")
                                        htmlContent.AppendLine("<td style='background-color: #FFC0CB; color: #17202A; text-align: right;'>" & SS & "</td>")
                                        htmlContent.AppendLine("<td style='background-color: #FFC0CB; color: #17202A; text-align: right;'>" & Val(dys) & "</td>")
                                        htmlContent.AppendLine("</tr>")
                                        P = 0
                                    Else
                                        If dys >= 40 Then

                                            SS = Str(drt2("ID")) + Trim(drt2("Refno")) + Trim(drt2("PolDt")) + Trim(drt2("PolicyNo")) + Trim(drt2("DNNo")) + Trim(drt2("TYPE")) + Trim(drt2("Customer")) + Trim(drt2("Company")) + Trim(drt2("PREMIUM"))
                                            'SS = "*****" + Format(Val(Trim(drt2("PREMIUM"))), "##,###,###.00")
                                            SS = Format(Val(Trim(drt2("PREMIUM"))), "##,###,###.00")
                                            Try
                                                SS1 = Trim(drt2("VehicleNo"))
                                            Catch ex As Exception
                                                '    TxtSAdd.Text = ""
                                                SS1 = ""

                                            End Try

                                            htmlContent.AppendLine("<tr>")
                                            htmlContent.AppendLine("<td style='background-color: #FFD700; color: #17202A;'>" & Trim(drt2("Refno")) & "</td>")
                                            htmlContent.AppendLine("<td style='background-color: #FFD700; color: #17202A;'>" & Format(DateValue(drt2("PolDt")), "dd/MM/yyyy") & "</td>")
                                            htmlContent.AppendLine("<td style='background-color: #FFD700; color: #17202A;'>" & Trim(drt2("PolicyNo")) & "</td>")
                                            htmlContent.AppendLine("<td style='background-color: #FFD700; color: #17202A;'>" & Trim(drt2("DNNo")) & "</td>")
                                            htmlContent.AppendLine("<td style='background-color: #FFD700; color: #17202A;'>" & Trim(drt2("TYPE")) & "</td>")
                                            htmlContent.AppendLine("<td style='background-color: #FFD700; color: #17202A;'>" & SS1 & "</td>")
                                            htmlContent.AppendLine("<td style='background-color: #FFD700; color: #17202A;'>" & Trim(drt2("Customer")) & "</td>")
                                            htmlContent.AppendLine("<td style='background-color: #FFD700; color: #17202A;'>" & Trim(drt2("Company")) & "</td>")
                                            htmlContent.AppendLine("<td style='background-color: #FFD700; color: #17202A; text-align: right;'>" & SS & "</td>")
                                            htmlContent.AppendLine("<td style='background-color: #FFD700; color: #17202A; text-align: right;'>" & Val(dys) & "</td>")
                                            htmlContent.AppendLine("</tr>")





                                        Else
                                            If P = 1 Then
                                                SS = Str(drt2("ID")) + Trim(drt2("Refno")) + Trim(drt2("PolDt")) + Trim(drt2("PolicyNo")) + Trim(drt2("DNNo")) + Trim(drt2("TYPE")) + Trim(drt2("Customer")) + Trim(drt2("Company")) + Trim(drt2("PREMIUM"))
                                                'SS = "*****" + Format(Val(Trim(drt2("PREMIUM"))), "##,###,###.00")
                                                SS = Format(Val(Trim(drt2("PREMIUM"))), "##,###,###.00")
                                                Try
                                                    SS1 = Trim(drt2("VehicleNo"))
                                                Catch ex As Exception
                                                    '    TxtSAdd.Text = ""
                                                    SS1 = ""
                                                End Try
                                                If Trim(SS1) <> "" Then
                                                    TT1 = SS1
                                                End If


                                                htmlContent.AppendLine("<tr>")
                                                htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Trim(drt2("Refno")) & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Format(DateValue(drt2("PolDt")), "dd/MM/yyyy") & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Trim(drt2("PolicyNo")) & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Trim(drt2("DNNo")) & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Trim(drt2("TYPE")) & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & SS1 & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Trim(drt2("Customer")) & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Trim(drt2("Company")) & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff; text-align: right;'>" & SS & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff; text-align: right;'>" & Val(dys) & "</td>")
                                                htmlContent.AppendLine("</tr>")
                                                P = 0
                                            Else
                                                SS = Str(drt2("ID")) + Trim(drt2("Refno")) + Trim(drt2("PolDt")) + Trim(drt2("PolicyNo")) + Trim(drt2("DNNo")) + Trim(drt2("TYPE")) + Trim(drt2("Customer")) + Trim(drt2("Company")) + Trim(drt2("PREMIUM"))
                                                'SS = "*****" + Format(Val(Trim(drt2("PREMIUM"))), "##,###,###.00")
                                                SS = Format(Val(Trim(drt2("PREMIUM"))), "##,###,###.00")
                                                Try
                                                    SS1 = Trim(drt2("VehicleNo"))
                                                Catch ex As Exception
                                                    '    TxtSAdd.Text = ""
                                                    SS1 = ""

                                                End Try
                                                If Trim(SS1) <> "" Then
                                                    TT1 = SS1
                                                End If



                                                htmlContent.AppendLine("<tr>")
                                                htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & Trim(drt2("Refno")) & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & Format(DateValue(drt2("PolDt")), "dd/MM/yyyy") & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & Trim(drt2("PolicyNo")) & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & Trim(drt2("DNNo")) & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & Trim(drt2("TYPE")) & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & SS1 & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & Trim(drt2("Customer")) & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & Trim(drt2("Company")) & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff; text-align: right;'>" & SS & "</td>")
                                                htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff; text-align: right;'>" & Val(dys) & "</td>")
                                                htmlContent.AppendLine("</tr>")
                                                P = 1
                                            End If

                                        End If
                                    End If


                                End If

                                ' dataTable.Rows.Add(Trim(drt2("Refno")), Trim(drt2("PolicyNo")))

                            Catch ex As Exception
                                dys = 100
                            End Try

                        End If


                    Catch ex As Exception
                        '    TxtSAdd.Text = ""
                        SS = "Error"

                    End Try


                Next
            Else
                ' Response.Redirect("InsuDept.aspx")

            End If

            htmlContent.AppendLine("<tr>")
            SS = Format(Tot, "#,###,###,###.00")
            'htmlContent.AppendLine("<td style='background-color: #ff0000; color: #ffffff; font-family: 'Calibri', sans-serif; font-size: 10px;'>Refno  </td>")
            Try
                SS1 = Trim(drt2("VehicleNo"))
            Catch ex As Exception
                SS1 = ""
            End Try

            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>  </td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'></td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'> </td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>    </td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>  </td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>  </td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>Grand Total</td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'></td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff; text-align: right;'>" & SS & "</td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff; text-align: right;'> </td>")


            htmlContent.AppendLine("</tr>")


            htmlContent.AppendLine("</table>")

            htmlContent.AppendLine("<table border='1' style='width: 80%; border-collapse: collapse; text-align: left;'>")

            ' htmlContent.AppendLine("<table border='1' style='font-family: 'Calibri', sans-serif; font-size: 10px; border-collapse: collapse; width: 100%;'>")


            ' htmlContent.AppendLine("<table border='1' style=font-family: 'Calibri', Calibri; font-size: 9px; border-collapse: collapse; width: 100%; text-align: left;>")

            ''   <table style="font-family: 'Arial', sans-serif; font-size: 16px; border-collapse: collapse; width: 100%;">
            htmlContent.AppendLine("<tr>")

            'htmlContent.AppendLine("<td style='background-color: #ff0000; color: #ffffff; font-family: 'Calibri', sans-serif; font-size: 10px;'>Refno  </td>")
            htmlContent.AppendLine("<td style='background-color: #C70039; color: #C70039;'>.................</td>")
            htmlContent.AppendLine("<td style='background-color: #FFFFFF; color: #0000ff;'>Without Payment. Policy Cancelled.</td>")
            htmlContent.AppendLine("<td style='background-color: #FFC0CB; color: #FFC0CB;'>.................</td>")
            htmlContent.AppendLine("<td style='background-color: #FFFFFF; color: #0000ff;'>Without pay in 50 days............</td>")
            htmlContent.AppendLine("<td style='background-color: #FFD700; color: #FFD700;'>.................</td>")
            htmlContent.AppendLine("<td style='background-color: #FFFFFF; color: #0000ff;'>Without pay in over 40-50 days....</td>")

            htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #ADDFFF;'>.................</td>")
            htmlContent.AppendLine("<td style='background-color: #FFFFFF; color: #0000ff;'>Without pay in below 40 days......</td>")



            htmlContent.AppendLine("</tr>")

            htmlContent.AppendLine("</table>")



            ' htmlContent.AppendLine("<img src='https://drive.google.com/uc? export=view&id=1JyW_BDA6TdmtiJy47rDnWYurGrEIfsOj' alt='Your Image' />")




            htmlContent.AppendLine("<div id='notices'>")
            htmlContent.AppendLine("<div>NOTICE:</div>")
            'htmlContent.AppendLine("<div class='notice'>A finance charge of 1.5% will be made on unpaid balances after 30 days.</div>")
            'htmlContent.AppendLine("</div>")






            '
            ' htmlContent.AppendLine("<h2>Sib Pending List</h2>")



            ' htmlContent.AppendLine("<img src='https://drive.google.com/uc? export=view&id=19ktNCRCa81CH2PhLXhne0J2pYpLfkRGs' alt='Your Image' />")















            '' Add a DataGrid
            'Dim dataTable As New DataTable()
            ''dataTable.Columns.Add("ID  ", GetType(Integer))
            'dataTable.Columns.Add("Refno          ", GetType(String))
            'dataTable.Columns.Add("PolicyDate", GetType(String))
            'dataTable.Columns.Add("PolicyNo       ", GetType(String))
            'dataTable.Columns.Add("DnNo     ", GetType(String))
            'dataTable.Columns.Add("Type     ", GetType(String))
            'dataTable.Columns.Add("Customer      ", GetType(String))
            'dataTable.Columns.Add("Company       ", GetType(String))
            'dataTable.Columns.Add("Premium", GetType(String))
            'dataTable.Columns.Add("Days", GetType(Integer))

            ' Add sample data

            ' dataTable.Rows.Add(2, "Jane")




            'Dim dataGrid As New DataGrid()
            ' dataGrid.DataSource = dataTable
            ' dataGrid.DataBind()




            'Dim dataGridHtml As New StringBuilder()
            'Dim htmlWriter As New HtmlTextWriter(New StringWriter(dataGridHtml))
            'dataGrid.RenderControl(htmlWriter)



            'htmlContent.AppendLine(dataGridHtml.ToString())


            htmlContent.AppendLine("</main>")

            htmlContent.AppendLine("<footer>")
            htmlContent.AppendLine("List was created on a computer system and is valid without the signature and seal.")
            htmlContent.AppendLine("</footer>")


            htmlContent.AppendLine("</body>")
            htmlContent.AppendLine("</html>")



            ' Convert StringBuilder to a string
            Dim finalHtml As String = htmlContent.ToString()

            ' Send email
            ''Dim smtpClient As New SmtpClient("your.smtp.server.com")
            ''Dim mailMessage As New MailMessage()

            ''mailMessage.From = New MailAddress("your@email.com")
            ''mailMessage.[To].Add("recipient@email.com")
            ''mailMessage.Subject = "Subject of the Email"
            ''mailMessage.Body = finalHtml
            ''mailMessage.IsBodyHtml = True

            ''smtpClient.Send(mailMessage)




            Dim Msg1 As New MailMessage()
            Dim fromMail1 As New MailAddress("insurance@samsoncorporates.com")
            ' Sender e-mail address.
            Msg1.From = fromMail1
            ' Recipient e-mail address.
            ' Msg.[To].Add(New MailAddress("nilushig@samsoncorporates.com"))
            Msg1.[To].Add(New MailAddress("palithan@samsoncorporates.com"))
            'Msg1.[To].Add(New MailAddress("palithan12@gmail.com"))
            ' Msg.[To].Add(New MailAddress("palithan@samsoncorporates.com;it@samsoncorporates.com;palithan@samsoncorporates.com"))

            ' Subject of e-mail
            Msg1.Subject = "New Sib System generated Document"
            Msg1.Body = finalHtml
            Msg1.IsBodyHtml = True


            sSmtpServer = "smtp.dtechlk.com"
            Dim a1 As New SmtpClient()
            a1.Host = sSmtpServer

            'a1.Credentials = New Net.NetworkCredential(Trim(TextBox10.Text), Trim(TextBox11.Text))
            a1.Credentials = New Net.NetworkCredential("insurance@samsoncorporates.com", "Xsw%wsx%7378##")
            a1.Port = 587
            a1.EnableSsl = True
            a1.Host = "smtp.dtechlk.com"
            a1.Send(Msg1)

            reader.Dispose()
            '-----
            Dim Msg2 As New MailMessage()
            ' Dim fromMail1 As New MailAddress("insurance@samsoncorporates.com")
            ' Sender e-mail address.
            Msg2.From = fromMail1
            ' Recipient e-mail address.
            ' Msg.[To].Add(New MailAddress("nilushig@samsoncorporates.com"))
            Msg2.[To].Add(New MailAddress("chamindas@samsoncorporates.com"))
            ' Msg.[To].Add(New MailAddress("palithan@samsoncorporates.com;it@samsoncorporates.com;palithan@samsoncorporates.com"))

            ' Subject of e-mail
            Msg2.Subject = "New Sib System generated Document"
            Msg2.Body = finalHtml
            Msg2.IsBodyHtml = True


            sSmtpServer = "smtp.dtechlk.com"
            'Dim a1 As New SmtpClient()
            a1.Host = sSmtpServer

            'a1.Credentials = New Net.NetworkCredential(Trim(TextBox10.Text), Trim(TextBox11.Text))
            a1.Credentials = New Net.NetworkCredential("insurance@samsoncorporates.com", "Xsw%wsx%7378##")

            a1.Port = 587
            a1.EnableSsl = True
            a1.Host = "smtp.dtechlk.com"
            a1.Send(Msg2)

            reader.Dispose()
            '-----
            '---
            '-----
            Dim Msg3 As New MailMessage()
            ' Dim fromMail1 As New MailAddress("insurance@samsoncorporates.com")
            ' Sender e-mail address.
            Msg3.From = fromMail1
            ' Recipient e-mail address.
            ' Msg.[To].Add(New MailAddress("nilushig@samsoncorporates.com"))
            Msg3.[To].Add(New MailAddress("nelanim@samsoncorporates.com"))
            ' Msg.[To].Add(New MailAddress("palithan@samsoncorporates.com;it@samsoncorporates.com;palithan@samsoncorporates.com"))

            ' Subject of e-mail
            Msg3.Subject = "New Sib System generated Document"
            Msg3.Body = finalHtml
            Msg3.IsBodyHtml = True


            sSmtpServer = "smtp.dtechlk.com"
            'Dim a1 As New SmtpClient()
            a1.Host = sSmtpServer

            'a1.Credentials = New Net.NetworkCredential(Trim(TextBox10.Text), Trim(TextBox11.Text))
            a1.Credentials = New Net.NetworkCredential("insurance@samsoncorporates.com", "Xsw%wsx%7378##")

            a1.Port = 587
            a1.EnableSsl = True
            a1.Host = "smtp.dtechlk.com"
            'a1.Send(Msg3)

            reader.Dispose()
            '-----
            '-----
            Dim Msg4 As New MailMessage()
            ' Dim fromMail1 As New MailAddress("insurance@samsoncorporates.com")
            ' Sender e-mail address.
            Msg4.From = fromMail1
            ' Recipient e-mail address.
            ' Msg.[To].Add(New MailAddress("nilushig@samsoncorporates.com"))
            Msg4.[To].Add(New MailAddress("insurance@samsoncorporates.com"))
            ' Msg.[To].Add(New MailAddress("palithan@samsoncorporates.com;it@samsoncorporates.com;palithan@samsoncorporates.com"))

            ' Subject of e-mail
            Msg4.Subject = "New Sib System generated Document"
            Msg4.Body = finalHtml
            Msg4.IsBodyHtml = True


            sSmtpServer = "smtp.dtechlk.com"
            'Dim a1 As New SmtpClient()
            a1.Host = sSmtpServer

            'a1.Credentials = New Net.NetworkCredential(Trim(TextBox10.Text), Trim(TextBox11.Text))
            a1.Credentials = New Net.NetworkCredential("insurance@samsoncorporates.com", "Xsw%wsx%7378##")

            a1.Port = 587
            a1.EnableSsl = True
            a1.Host = "smtp.dtechlk.com"
            a1.Send(Msg4)

            reader.Dispose()
            '-----
            Dim Msg5 As New MailMessage()
            ' Dim fromMail1 As New MailAddress("insurance@samsoncorporates.com")
            ' Sender e-mail address.
            Msg5.From = fromMail1
            ' Recipient e-mail address.
            ' Msg.[To].Add(New MailAddress("nilushig@samsoncorporates.com"))
            Msg5.[To].Add(New MailAddress("udanip@samsoncorporates.com"))
            ' Msg.[To].Add(New MailAddress("palithan@samsoncorporates.com;it@samsoncorporates.com;palithan@samsoncorporates.com"))

            ' Subject of e-mail
            Msg5.Subject = "New Sib System generated Document"
            Msg5.Body = finalHtml
            Msg5.IsBodyHtml = True


            sSmtpServer = "smtp.dtechlk.com"
            'Dim a1 As New SmtpClient()
            a1.Host = sSmtpServer

            'a1.Credentials = New Net.NetworkCredential(Trim(TextBox10.Text), Trim(TextBox11.Text))
            a1.Credentials = New Net.NetworkCredential("insurance@samsoncorporates.com", "Xsw%wsx%7378##")

            a1.Port = 587
            a1.EnableSsl = True
            a1.Host = "smtp.dtechlk.com"
            a1.Send(Msg5)

            reader.Dispose()
            '---
            Dim Msg6 As New MailMessage()
            ' Dim fromMail1 As New MailAddress("insurance@samsoncorporates.com")
            ' Sender e-mail address.
            Msg6.From = fromMail1
            ' Recipient e-mail address.
            ' Msg.[To].Add(New MailAddress("nilushig@samsoncorporates.com"))
            Msg6.[To].Add(New MailAddress("palithan12@gmail.com"))
            ' Msg.[To].Add(New MailAddress("palithan@samsoncorporates.com;it@samsoncorporates.com;palithan@samsoncorporates.com"))

            ' Subject of e-mail
            Msg6.Subject = "New Sib System generated Document"
            Msg6.Body = finalHtml
            Msg6.IsBodyHtml = True


            sSmtpServer = "smtp.dtechlk.com"
            'Dim a1 As New SmtpClient()
            a1.Host = sSmtpServer

            'a1.Credentials = New Net.NetworkCredential(Trim(TextBox10.Text), Trim(TextBox11.Text))
            a1.Credentials = New Net.NetworkCredential("insurance@samsoncorporates.com", "Xsw%wsx%7378##")

            a1.Port = 587
            a1.EnableSsl = True
            a1.Host = "smtp.dtechlk.com"
            a1.Send(Msg6)

            reader.Dispose()



            '---

            '---







        Catch ex As Exception
            SS = "Error"
        End Try
    End Sub



    Public Sub SendHTMLMail1()
        Dim reader As New StreamReader(Server.MapPath("~/HTMLPage1.htm"))
        Dim readFile As String = reader.ReadToEnd()
        Dim myString As String = ""

        Try
            SS = Format(Today(), "dd/MM/yyyy")

            CON = New SqlConnection
            CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SIB; user id=sa;password=tstc@123")
            'CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
            CON.Open()

            CMD = New SqlCommand("SELECT * FROM Refno", CON)


            DR = CMD.ExecuteReader


            SS = Format(Today(), "dd/MM/yyyy")


            'CMD1 = New SqlCommand("SELECT * FROM Inquery order by Id", CON)


            'DR1 = CMD1.ExecuteReader



            Dim Msg As New MailMessage()
            Dim fromMail As New MailAddress("insurance@samsoncorporates.com")



            Dim sSmtpServer As String = ""
            sSmtpServer = "smtp.dtechlk.com"
            Dim a As New SmtpClient()
            a.Host = sSmtpServer

            a.Credentials = New Net.NetworkCredential("insurance@samsoncorporates.com", "Xsw%wsx%7378##")
            a.Port = 587
            a.EnableSsl = True
            a.Host = "smtp.dtechlk.com"
            'a.Send(Msg)

            reader.Dispose()

            '------

            Dim htmlContent As New StringBuilder()

            ' Start HTML document
            htmlContent.AppendLine("<!DOCTYPE html>")
            htmlContent.AppendLine("<html lang='en'>")
            htmlContent.AppendLine("<head>")
            htmlContent.AppendLine("<meta charset='utf-8'>")
            htmlContent.AppendLine("<meta name='viewport' content='width=device-width, initial-scale=1.0'>")
            htmlContent.AppendLine("<title>New inquery</title>")

            htmlContent.AppendLine("<style>")
            htmlContent.AppendLine("        body { background-color: #f0f0f0; font-family: Calibri, Calibri; }")

            htmlContent.AppendLine("        h1 { color: #007bff; text-align: left; margin: 0 0 20px 0; background: url('https://drive.google.com/uc? export=view&id=1JDrL53pr2cfExu5t3o4gZrmz-2scb182'); }")


            htmlContent.AppendLine("</style>")


            htmlContent.AppendLine("</head>")
            htmlContent.AppendLine("<body style='font-family: 'Calibri', sans-serif; font-size: 80%;'>")




            htmlContent.AppendLine("<header class='clearfix'>")
            htmlContent.AppendLine("<div id='logo'>")
            htmlContent.AppendLine("<img src='https://drive.google.com/uc? export=view&id=19ktNCRCa81CH2PhLXhne0J2pYpLfkRGs' alt='Your Image' />")
            htmlContent.AppendLine("</div>")

            htmlContent.AppendLine("<h3>New Inqueries Last Week</h3>")

            htmlContent.AppendLine("</header>")

            htmlContent.AppendLine("<main>")


            htmlContent.AppendLine("<table border='1' style='width: 80%; border-collapse: collapse; text-align: left;'>")

            htmlContent.AppendLine("<tr>")


            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>Inquery Date</td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>Customer Name</td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>Address </td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>Contact no</td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>Email</td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>Insurance Type</td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>Renew Date </td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>Vehicle No</td>")
            htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>Remarks </td>")

            'htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff; text-align: right;'>Premium </td>")
            ' htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff; text-align: right;'>Days</td>")


            htmlContent.AppendLine("</tr>")



            Con1 = New SqlConnection
            Con1.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SIB; user id=sa;password=tstc@123")
            Con1.Open()

            ADA = New SqlDataAdapter("SELECT * from Inquery order by Id ", Con1)

            DS = New DataSet
            ADA.Fill(DS, "Inquery")

            count1 = DS.Tables("Inquery").Rows.Count

            Dim dys, P As Integer
            Dim Tot As Double
            If count1 <> 0 Then
                P = 1
                Tot = 0
                For Each Me.drt2 In DS.Tables("Inquery").Rows


                    Try

                        Dim dateResult As DateTime = DateTime.Parse(drt2("ConEntDt"))

                        Try
                            dys = (Today() - dateResult).Days
                        Catch ex As Exception
                            dys = 100
                        End Try


                        If dys <= 365 And dys >= 0 Then
                            Try
                                'dataTable.Rows.Add(Trim(drt2("Refno")), Trim(drt2("PolDt")), Trim(drt2("PolicyNo")), Trim(drt2("DNNo")), Trim(drt2("TYPE")), Trim(drt2("Customer")), Trim(drt2("Company")), Format(drt2("PREMIUM"), "#,##0.00"), dys)
                                'Tot = Tot + Val(Trim(drt2("PREMIUM")))

                                'If P = 1 Then



                                If P = 1 Then
                                    'SS = Str(drt2("ID")) + Trim(drt2("Refno")) + Trim(drt2("PolDt")) + Trim(drt2("PolicyNo")) + Trim(drt2("DNNo")) + Trim(drt2("TYPE")) + Trim(drt2("Customer")) + Trim(drt2("Company")) + Trim(drt2("PREMIUM"))
                                    'SS = "*****" + Format(Val(Trim(drt2("PREMIUM"))), "##,###,###.00")
                                    'SS = Format(Val(Trim(drt2("PREMIUM"))), "##,###,###.00")
                                    htmlContent.AppendLine("<tr>")
                                    'htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Trim(drt2("Refno")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Format(DateValue(drt2("ConEntDt")), "dd/MM/yyyy") & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Trim(drt2("ConNam")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Trim(drt2("ConAdd")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Trim(drt2("Contact")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Trim(drt2("ConEmail")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Trim(drt2("ConInsTyp")) & "</td>")

                                    Try
                                        htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Format(DateValue(drt2("ConRenDt")), "dd/MM/yyyy") & "</td>")
                                    Catch ex As Exception
                                        htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & "          " & "</td>")
                                    End Try


                                    htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Trim(drt2("ConVehNo")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff;'>" & Trim(drt2("ConSource")) & "</td>")
                                    'htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff; text-align: right;'>" & SS & "</td>")
                                    ' htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #0000ff; text-align: right;'>" & Val(dys) & "</td>")
                                    htmlContent.AppendLine("</tr>")
                                    P = 0
                                Else
                                    ' SS = Str(drt2("ID")) + Trim(drt2("Refno")) + Trim(drt2("PolDt")) + Trim(drt2("PolicyNo")) + Trim(drt2("DNNo")) + Trim(drt2("TYPE")) + Trim(drt2("Customer")) + Trim(drt2("Company")) + Trim(drt2("PREMIUM"))
                                    'SS = "*****" + Format(Val(Trim(drt2("PREMIUM"))), "##,###,###.00")
                                    'SS = Format(Val(Trim(drt2("PREMIUM"))), "##,###,###.00")
                                    htmlContent.AppendLine("<tr>")
                                    htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & Format(DateValue(drt2("ConEntDt")), "dd/MM/yyyy") & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & Trim(drt2("ConNam")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & Trim(drt2("ConAdd")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & Trim(drt2("Contact")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & Trim(drt2("ConEmail")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & Trim(drt2("ConInsTyp")) & "</td>")
                                    Try
                                        htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & Format(DateValue(drt2("ConRenDt")), "dd/MM/yyyy") & "</td>")
                                    Catch ex As Exception
                                        htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & "          " & "</td>")
                                    End Try

                                    htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & Trim(drt2("ConVehNo")) & "</td>")
                                    htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff;'>" & Trim(drt2("ConSource")) & "</td>")


                                    ' htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff; text-align: right;'>" & SS & "</td>")
                                    ' htmlContent.AppendLine("<td style='background-color: #A2D9CE; color: #0000ff; text-align: right;'>" & Val(dys) & "</td>")
                                    htmlContent.AppendLine("</tr>")
                                    P = 1
                                End If






                                ' dataTable.Rows.Add(Trim(drt2("Refno")), Trim(drt2("PolicyNo")))

                            Catch ex As Exception
                                dys = 100
                            End Try

                        End If


                    Catch ex As Exception
                        '    TxtSAdd.Text = ""
                        SS = "Error"

                    End Try


                Next
            Else
                ' Response.Redirect("InsuDept.aspx")

            End If

            'htmlContent.AppendLine("<tr>")
            'SS = Format(Tot, "#,###,###,###.00")
            ''htmlContent.AppendLine("<td style='background-color: #ff0000; color: #ffffff; font-family: 'Calibri', sans-serif; font-size: 10px;'>Refno  </td>")
            'htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>  </td>")
            'htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'></td>")
            'htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'> </td>")
            'htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>    </td>")
            'htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>  </td>")
            'htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'>Grand Total</td>")
            'htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff;'></td>")
            'htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff; text-align: right;'>" & SS & "</td>")
            'htmlContent.AppendLine("<td style='background-color: #0000ff; color: #ffffff; text-align: right;'> </td>")


            'htmlContent.AppendLine("</tr>")








            htmlContent.AppendLine("</table>")

            htmlContent.AppendLine("<table border='1' style='width: 80%; border-collapse: collapse; text-align: left;'>")

            ' htmlContent.AppendLine("<table border='1' style='font-family: 'Calibri', sans-serif; font-size: 10px; border-collapse: collapse; width: 100%;'>")


            ' htmlContent.AppendLine("<table border='1' style=font-family: 'Calibri', Calibri; font-size: 9px; border-collapse: collapse; width: 100%; text-align: left;>")

            ''   <table style="font-family: 'Arial', sans-serif; font-size: 16px; border-collapse: collapse; width: 100%;">
            'htmlContent.AppendLine("<tr>")

            ''htmlContent.AppendLine("<td style='background-color: #ff0000; color: #ffffff; font-family: 'Calibri', sans-serif; font-size: 10px;'>Refno  </td>")
            'htmlContent.AppendLine("<td style='background-color: #C70039; color: #C70039;'>.............</td>")
            'htmlContent.AppendLine("<td style='background-color: #FFFFFF; color: #0000ff;'>Without Payment. Policy Cancelled.</td>")
            'htmlContent.AppendLine("<td style='background-color: #FFC0CB; color: #FFC0CB;'>.............</td>")
            'htmlContent.AppendLine("<td style='background-color: #FFFFFF; color: #0000ff;'>Without pay in 50 days............</td>")
            'htmlContent.AppendLine("<td style='background-color: #FFD700; color: #FFD700;'>.............</td>")
            'htmlContent.AppendLine("<td style='background-color: #FFFFFF; color: #0000ff;'>Without pay in over 40-50 days....</td>")
            'htmlContent.AppendLine("<td style='background-color: #ADDFFF; color: #ADDFFF;'>.............</td>")
            'htmlContent.AppendLine("<td style='background-color: #FFFFFF; color: #0000ff;'>Without pay in below 40 days......</td>")



            'htmlContent.AppendLine("</tr>")

            htmlContent.AppendLine("</table>")



            ' htmlContent.AppendLine("<img src='https://drive.google.com/uc? export=view&id=1JyW_BDA6TdmtiJy47rDnWYurGrEIfsOj' alt='Your Image' />")




            htmlContent.AppendLine("<div id='notices'>")
            htmlContent.AppendLine("<div>NOTICE:</div>")

            htmlContent.AppendLine("</main>")

            htmlContent.AppendLine("<footer>")
            htmlContent.AppendLine("List was created on a computer system and is valid without the signature and seal.")
            htmlContent.AppendLine("</footer>")


            htmlContent.AppendLine("</body>")
            htmlContent.AppendLine("</html>")



            ' Convert StringBuilder to a string
            Dim finalHtml As String = htmlContent.ToString()



            Dim Msg1 As New MailMessage()
            Dim fromMail1 As New MailAddress("insurance@samsoncorporates.com")
            ' Sender e-mail address.
            Msg1.From = fromMail1
            ' Recipient e-mail address.
            ' Msg.[To].Add(New MailAddress("nilushig@samsoncorporates.com"))
            Msg1.[To].Add(New MailAddress("palithan@samsoncorporates.com"))
            'Msg1.[To].Add(New MailAddress("palithan12@gmail.com"))
            ' Msg.[To].Add(New MailAddress("palithan@samsoncorporates.com;it@samsoncorporates.com;palithan@samsoncorporates.com"))

            ' Subject of e-mail
            Msg1.Subject = "Sib System generated -New Inquery Last Week"
            Msg1.Body = finalHtml
            Msg1.IsBodyHtml = True


            sSmtpServer = "smtp.dtechlk.com"
            Dim a1 As New SmtpClient()
            a1.Host = sSmtpServer

            'a1.Credentials = New Net.NetworkCredential(Trim(TextBox10.Text), Trim(TextBox11.Text))
            a1.Credentials = New Net.NetworkCredential("insurance@samsoncorporates.com", "Xsw%wsx%7378##")
            a1.Port = 587
            a1.EnableSsl = True
            a1.Host = "smtp.dtechlk.com"
            a1.Send(Msg1)

            reader.Dispose()
            '-----
            Dim Msg2 As New MailMessage()
            ' Dim fromMail1 As New MailAddress("insurance@samsoncorporates.com")
            ' Sender e-mail address.
            Msg2.From = fromMail1
            ' Recipient e-mail address.
            ' Msg.[To].Add(New MailAddress("nilushig@samsoncorporates.com"))
            Msg2.[To].Add(New MailAddress("chamindas@samsoncorporates.com"))
            ' Msg.[To].Add(New MailAddress("palithan@samsoncorporates.com;it@samsoncorporates.com;palithan@samsoncorporates.com"))

            ' Subject of e-mail
            Msg2.Subject = "Sib System generated -New Inquery Last Week"
            Msg2.Body = finalHtml
            Msg2.IsBodyHtml = True


            sSmtpServer = "smtp.dtechlk.com"
            'Dim a1 As New SmtpClient()
            a1.Host = sSmtpServer

            'a1.Credentials = New Net.NetworkCredential(Trim(TextBox10.Text), Trim(TextBox11.Text))
            a1.Credentials = New Net.NetworkCredential("insurance@samsoncorporates.com", "Xsw%wsx%7378##")

            a1.Port = 587
            a1.EnableSsl = True
            a1.Host = "smtp.dtechlk.com"
            a1.Send(Msg2)

            reader.Dispose()
            '-----
            '---
            '-----
            Dim Msg3 As New MailMessage()
            ' Dim fromMail1 As New MailAddress("insurance@samsoncorporates.com")
            ' Sender e-mail address.
            Msg3.From = fromMail1
            ' Recipient e-mail address.
            ' Msg.[To].Add(New MailAddress("nilushig@samsoncorporates.com"))
            Msg3.[To].Add(New MailAddress("nelanim@samsoncorporates.com"))
            ' Msg.[To].Add(New MailAddress("palithan@samsoncorporates.com;it@samsoncorporates.com;palithan@samsoncorporates.com"))

            ' Subject of e-mail
            Msg3.Subject = "Sib System generated -New Inquery Last Week"
            Msg3.Body = finalHtml
            Msg3.IsBodyHtml = True


            sSmtpServer = "smtp.dtechlk.com"
            'Dim a1 As New SmtpClient()
            a1.Host = sSmtpServer

            'a1.Credentials = New Net.NetworkCredential(Trim(TextBox10.Text), Trim(TextBox11.Text))
            a1.Credentials = New Net.NetworkCredential("insurance@samsoncorporates.com", "Xsw%wsx%7378##")

            a1.Port = 587
            a1.EnableSsl = True
            a1.Host = "smtp.dtechlk.com"
            'a1.Send(Msg3)

            reader.Dispose()
            '-----
            '-----
            Dim Msg4 As New MailMessage()
            ' Dim fromMail1 As New MailAddress("insurance@samsoncorporates.com")
            ' Sender e-mail address.
            Msg4.From = fromMail1
            ' Recipient e-mail address.
            ' Msg.[To].Add(New MailAddress("nilushig@samsoncorporates.com"))
            Msg4.[To].Add(New MailAddress("insurance@samsoncorporates.com"))
            ' Msg.[To].Add(New MailAddress("palithan@samsoncorporates.com;it@samsoncorporates.com;palithan@samsoncorporates.com"))

            ' Subject of e-mail
            Msg4.Subject = "Sib System generated -New Inquery Last Week"
            Msg4.Body = finalHtml
            Msg4.IsBodyHtml = True


            sSmtpServer = "smtp.dtechlk.com"
            'Dim a1 As New SmtpClient()
            a1.Host = sSmtpServer

            'a1.Credentials = New Net.NetworkCredential(Trim(TextBox10.Text), Trim(TextBox11.Text))
            a1.Credentials = New Net.NetworkCredential("insurance@samsoncorporates.com", "Xsw%wsx%7378##")

            a1.Port = 587
            a1.EnableSsl = True
            a1.Host = "smtp.dtechlk.com"
            a1.Send(Msg4)

            reader.Dispose()
            '-----
            Dim Msg5 As New MailMessage()
            ' Dim fromMail1 As New MailAddress("insurance@samsoncorporates.com")
            ' Sender e-mail address.
            Msg5.From = fromMail1
            ' Recipient e-mail address.
            ' Msg.[To].Add(New MailAddress("nilushig@samsoncorporates.com"))
            Msg5.[To].Add(New MailAddress("udanip@samsoncorporates.com"))
            ' Msg.[To].Add(New MailAddress("palithan@samsoncorporates.com;it@samsoncorporates.com;palithan@samsoncorporates.com"))

            ' Subject of e-mail
            Msg5.Subject = "Sib System generated -New Inquery Last Week"
            Msg5.Body = finalHtml
            Msg5.IsBodyHtml = True


            sSmtpServer = "smtp.dtechlk.com"
            'Dim a1 As New SmtpClient()
            a1.Host = sSmtpServer

            'a1.Credentials = New Net.NetworkCredential(Trim(TextBox10.Text), Trim(TextBox11.Text))
            a1.Credentials = New Net.NetworkCredential("insurance@samsoncorporates.com", "Xsw%wsx%7378##")

            a1.Port = 587
            a1.EnableSsl = True
            a1.Host = "smtp.dtechlk.com"
            a1.Send(Msg5)

            reader.Dispose()
            '---
            Dim Msg6 As New MailMessage()
            ' Dim fromMail1 As New MailAddress("insurance@samsoncorporates.com")
            ' Sender e-mail address.
            Msg6.From = fromMail1
            ' Recipient e-mail address.
            ' Msg.[To].Add(New MailAddress("nilushig@samsoncorporates.com"))
            Msg6.[To].Add(New MailAddress("palithan12@gmail.com"))
            ' Msg.[To].Add(New MailAddress("palithan@samsoncorporates.com;it@samsoncorporates.com;palithan@samsoncorporates.com"))

            ' Subject of e-mail
            Msg6.Subject = "Sib System generated -New Inquery Last Week"
            Msg6.Body = finalHtml
            Msg6.IsBodyHtml = True


            sSmtpServer = "smtp.dtechlk.com"
            'Dim a1 As New SmtpClient()
            a1.Host = sSmtpServer

            'a1.Credentials = New Net.NetworkCredential(Trim(TextBox10.Text), Trim(TextBox11.Text))
            a1.Credentials = New Net.NetworkCredential("insurance@samsoncorporates.com", "Xsw%wsx%7378##")

            a1.Port = 587
            a1.EnableSsl = True
            a1.Host = "smtp.dtechlk.com"
            a1.Send(Msg6)

            reader.Dispose()



        Catch ex As Exception
            SS = "Error"
        End Try
    End Sub


End Class
