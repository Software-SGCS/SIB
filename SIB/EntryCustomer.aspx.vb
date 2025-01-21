Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Mail
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System
Imports System.Web.Security
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports CrystalDecisions.CrystalReports.Engine


Public Class EntryCustomer
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection

    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD, CMD1 As SqlCommand
    Dim DR, DR1, DR2, DR3 As SqlDataReader
    Dim DS, DS1 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim drt2, drt3, drt1 As DataRow
    Dim CHKDUP As Boolean
    'Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Dim CRI1, CRI2, CRI3 As String
    Dim str1, str2 As String
    Dim Sinvno As String
    Dim TempEmpno, TempCom As String
    Dim ss, Pflag As String
    Dim Tno As String
    Dim Tno1 As String
    Dim Tno2 As String
    Dim count1, Count2 As Integer
    Dim StrConCode, StrConNam, StrConAdd1, StrConAdd2, StrConAdd3, StrBnkNam, StrBnkAdd, StrCod, Strpod, StrExg, StrCncy As String

    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
    Dim TT As String
    Dim TT1 As String
    Protected WithEvents BtnSave11 As System.Web.UI.WebControls.Button


    Protected WithEvents lbtnEdit As System.Web.UI.WebControls.LinkButton
    Protected WithEvents lbtnUpdate As System.Web.UI.WebControls.LinkButton
    Protected WithEvents lbtnCancel As System.Web.UI.WebControls.LinkButton
    Protected WithEvents lblDelete As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel

    Protected WithEvents Save111 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents L1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label

    Protected WithEvents Save1111 As System.Web.UI.WebControls.ImageButton


    Protected WithEvents TxtChqNo As System.Web.UI.WebControls.TextBox


    Protected strCountry As String


#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init

        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load


        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SIB; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
        CON.Open()



        'Global.PwFlag = "N"

        'If Global.PwLevel = "1" Then
        'lobal.PwFlag = "Y"

        'Else
        '    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='ExpNewEntry7.aspx' and Form_level='" & Global.PwLevel & "'", CON)

        '   DR = CMD.ExecuteReader
        '   While DR.Read
        '    End While

        '   DR.Close()

        'End If

        '----------------
        Pflag = "N"

        If Count2 = "1" Then
            Pflag = "Y"
        Else

            If Count2 = "2" Then
                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='ExpNewEntry7.aspx' and Form_level2='1'", CON)

            Else
                If Count2 = "3" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='ExpNewEntry7.aspx' and Form_level3='1'", CON)

                Else
                    If Count2 = "4" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='ExpNewEntry7.aspx' and Form_level4='1'", CON)
                    Else
                        If Count2 = "5" Then

                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='ExpNewEntry7.aspx' and Form_level5='1'", CON)

                        Else
                            '   CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PQR.aspx' and Form_level='" & Global.PwLevel & "'", CON)

                        End If

                    End If
                End If

            End If
            'CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosOpEntry.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            '  DR = CMD.ExecuteReader
            ' While DR.Read
            Pflag = "Y"
            ' End While

            'DR.Close()
        End If

        If Pflag = "Y" Then
            Response.AddHeader("Refresh", 1800)
        Else
            Response.Redirect("POSDispaly11.aspx")
        End If


        '-----------------


        ' BttIns1.Enabled = False
        If Not IsPostBack Then

            ' Panel6.BackImageUrl = "Menu\EmpMaster4.jpg"
            TxtFdt.Text = Format(Today(), "dd/MM/yyyy")
            TxtTdt.Text = Format(Today(), "dd/MM/yyyy")

            Calendar1.Visible = False

            CMD = New SqlCommand("SELECT Dnno FROM Refno where PaidY<>'Y' and Poldt>='" & Mid(Trim(TxtFdt.Text), 7, 4) + "-" + Mid(Trim(TxtFdt.Text), 4, 2) + "-" + Mid(Trim(TxtFdt.Text), 1, 2) & "' and Poldt<='" & Mid(Trim(TxtTdt.Text), 7, 4) + "-" + Mid(Trim(TxtTdt.Text), 4, 2) + "-" + Mid(Trim(TxtTdt.Text), 1, 2) & "' order by PolicyNo", CON)

            'ADA = New SqlDataAdapter("SELECT * FROM MasterDocs Where Mas_RefNo='" & Trim(Txtrefno1.text) & "'", CON)
            DR = CMD.ExecuteReader
            LstPolicyNo.Items.Clear()

            While DR.Read
                TT = DR.GetValue(0)
                LstPolicyNo.Items.Add(TT)
            End While
            DR.Close()

            Save11.Visible = True
            Save1.Visible = False
            Save11.Enabled = True
            Save11.ImageUrl = "Menu\save11.png"

            BindTheGrid()
        End If




    End Sub
    Public Sub BindTheGrid()
        'Try
        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SIB; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
        CON.Open()

        CMD = New SqlCommand("SELECT Dnno FROM Refno where PaidY<>'Y' and Poldt>='" & Mid(Trim(TxtFdt.Text), 7, 4) + "-" + Mid(Trim(TxtFdt.Text), 4, 2) + "-" + Mid(Trim(TxtFdt.Text), 1, 2) & "' and Poldt<='" & Mid(Trim(TxtTdt.Text), 7, 4) + "-" + Mid(Trim(TxtTdt.Text), 4, 2) + "-" + Mid(Trim(TxtTdt.Text), 1, 2) & "' order by PolicyNo", CON)

        'ADA = New SqlDataAdapter("SELECT * FROM MasterDocs Where Mas_RefNo='" & Trim(Txtrefno1.text) & "'", CON)
        DR = CMD.ExecuteReader
        LstPolicyNo.Items.Clear()

        While DR.Read
            TT = DR.GetValue(0)
            LstPolicyNo.Items.Add(TT)
        End While
        DR.Close()

        ss = "Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster where trim(emp_No)='" & Trim(TempEmpno) & "' and Emp_Com='" & TempCom & "Select id,Refno,Format(Poldt,'dd/MM/yyyy') as PolDt,Customer,PolicyNo,Dnno,Company,format(Premium,'#,###.00') as Premium,ChequeNo,Format(PaidDt,'dd/MM/yyyy') as PaidDt From Refno"


        Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,Refno,convert(varchar(10), Poldt, 103) AS Poldt,Customer,PolicyNo,Dnno,Company,cncy,CONVERT(DECIMAL(12,2),Premium,2) as Premium, ChequeNo,convert(varchar(10),PaidDt, 103) AS PaidDt From Refno where Poldt>='" & Mid(Trim(TxtFdt.Text), 7, 4) + "-" + Mid(Trim(TxtFdt.Text), 4, 2) + "-" + Mid(Trim(TxtFdt.Text), 1, 2) & "' and Poldt<='" & Mid(Trim(TxtTdt.Text), 7, 4) + "-" + Mid(Trim(TxtTdt.Text), 4, 2) + "-" + Mid(Trim(TxtTdt.Text), 1, 2) & "' order by PolDt", CON)
        ' Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,Refno,Poldt,Customer,PolicyNo,Dnno,Company,CONVERT(DECIMAL(12,2),Premium,2) as Premium, ChequeNo, PaidDt From Refno where PaidY='Y' and Poldt>='" & Mid(Trim(TxtFdt.Text), 7, 4) + "-" + Mid(Trim(TxtFdt.Text), 4, 2) + "-" + Mid(Trim(TxtFdt.Text), 1, 2) & "' and Poldt<='" & Mid(Trim(TxtTdt.Text), 7, 4) + "-" + Mid(Trim(TxtTdt.Text), 4, 2) + "-" + Mid(Trim(TxtTdt.Text), 1, 2) & "' order by PolDt", CON)

        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)

        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType from RelationMaster", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType,Emp_Chqno from RelationMaster", CON)
        cmdCustomers.CommandType = CommandType.Text
        MyDataGrid.Enabled = True

        MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
        MyDataGrid.DataBind()

        MyDataGrid.Visible = True
        ' CON.Close()

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub Save11_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Save11.Click

        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SIB; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
        CON.Open()


        CMD = New SqlCommand("SELECT * FROM RefNo", CON)
        DR = CMD.ExecuteReader


        DR.Close()


        ADA = New SqlDataAdapter("SELECT * FROM Refno WHERE DNno = '" & Trim(TxtDnno.Text) & "'", CON)
        DS = New DataSet

        ADA.Fill(DS, "Refno")

        count1 = DS.Tables("Refno").Rows.Count





        If count1 <> 0 Then

            'ss = "UPDATE CUSF SET CCODE='" & Trim(TxtConCode.Text) & "',CONAME='" & Trim(TxtRefno.Text) & "',COADD1= '" & Trim(TxtType.Text) & "',COADD2= '" & Trim(TxtCusEmail.Text) & "',CONO= '" & Trim(TxtAmt.Text) & "' WHERE CCODE='" & Trim(TxtConCode.Text) & "'"
            If Trim(TxtPdt.Text) = "" Then
                CMD.Connection = CON
                CMD.CommandText = ("UPDATE Refno SET PaidPremium='" & Trim(TxtAmt.Text) & "',PaidY='Y',ChequeNo='" & Trim(TxtChqNo.Text) & "',Cncy='" & Trim(TxtCncy.Text) & "' WHERE Dnno='" & Trim(TxtDnno.Text) & "'")
                CMD.ExecuteNonQuery()

            Else

                CMD.Connection = CON
                CMD.CommandText = ("UPDATE Refno SET PaidPremium='" & Trim(TxtAmt.Text) & "',PaidY='Y',ChequeNo='" & Trim(TxtChqNo.Text) & "',Cncy='" & Trim(TxtCncy.Text) & "',PaidDt='" & Mid(Trim(TxtPdt.Text), 4, 2) + "/" + Mid(Trim(TxtPdt.Text), 1, 2) + "/" + Mid(Trim(TxtPdt.Text), 7, 4) & "' WHERE Dnno='" & Trim(TxtDnno.Text) & "'")
                CMD.ExecuteNonQuery()
            End If
        End If

        BindTheGrid()
        Save11.Enabled = False
        Save11.ImageUrl = "Menu\save1.png"


        ' Save1.Visible = True
    End Sub




    Protected Sub TxtConCode_TextChanged1(ByVal sender As Object, ByVal e As EventArgs) Handles TxtDnno1.TextChanged
        Save11.Enabled = True
        Save11.ImageUrl = "Menu\save11.png"

    End Sub

    Protected Sub Imagebutton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton4.Click
        ' TxtRem.Visible = False
        'TxtCon.Visible = False
        ' Panel2.Visible = False
        Calendar1.Visible = True
        TxtEpfNo.Text = "3"
    End Sub

    Protected Sub Imagebutton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton5.Click
        ' TxtRem.Visible = False
        'TxtCon.Visible = False
        ' Panel2.Visible = False
        Calendar1.Visible = True
        TxtEpfNo.Text = "2"
    End Sub

    Protected Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Calendar1.SelectionChanged
        If TxtEpfNo.Text = "1" Then
            TxtFdt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
            ' TxtTdt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        End If
        If TxtEpfNo.Text = "2" Then
            TxtTdt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        End If
        If TxtEpfNo.Text = "3" Then
            TxtPdt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        End If
        BindTheGrid()

        Calendar1.Visible = False
    End Sub

    Protected Sub LstPolicyNo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LstPolicyNo.SelectedIndexChanged
        BindData()
    End Sub


    Public Sub BindData()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SIB; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
        CON.Open()

        ' ss = "SELECT * FROM SLine WHERE Sline = '" & Trim(TxtDnno1.Text) & "'"
        ADA = New SqlDataAdapter("SELECT * FROM Refno WHERE Dnno = '" & Trim(LstPolicyNo.SelectedValue) & "'", CON)
        DS1 = New DataSet

        Save11.Enabled = True
        Save11.ImageUrl = "Menu\save11.png"




        ADA.Fill(DS1, "Refno")
        Save11.Visible = True
        Save1.Visible = False
        count1 = DS1.Tables("Refno").Rows.Count

        If count1 <> 0 Then




            For Each Me.drt2 In DS1.Tables("Refno").Rows


                Try
                    TxtRefno.Text = drt2("Refno")
                Catch ex As Exception
                    TxtRefno.Text = ""
                End Try

                Try
                    TxtPolDt.Text = Format(drt2("PolDt"), "dd/MM/yyyy")

                    'TxtTdt.Text = Format(Today(), "dd/MM/yyyy")
                Catch ex As Exception
                    TxtPolDt.Text = ""
                End Try

                Try
                    TxtCustomer.Text = drt2("Customer")
                Catch ex As Exception
                    TxtCustomer.Text = ""
                End Try


                Try
                    TxtDnno.Text = drt2("DNNo")
                Catch ex As Exception
                    TxtDnno.Text = ""
                End Try

                Try
                    TxtCompany.Text = drt2("Company")
                Catch ex As Exception
                    TxtCompany.Text = ""
                End Try

                Try
                    TxtSumIns.Text = "*****" + Format(drt2("SumIns"), "###,###,###,###,###.00")
                Catch ex As Exception
                    TxtSumIns.Text = ""
                End Try

                Try
                    TxtVehicleNo.Text = drt2("VehicleNo")
                Catch ex As Exception
                    TxtVehicleNo.Text = ""
                End Try

                'TxtInTot.Text = "*****" + Format(TotAmt1, "###,###,###,###,###.00")


                Try
                    TxtPremium.Text = "*****" + Format(drt2("Premium"), "###,###,###,###,###.00")

                Catch ex As Exception
                    TxtPremium.Text = ""
                End Try
                Try
                    TxtPolicyNo.Text = drt2("PolicyNo")
                Catch ex As Exception
                    TxtPolicyNo.Text = ""
                End Try

                Try
                    TxtPolicyNo.Text = drt2("PolicyNo")
                Catch ex As Exception
                    TxtPolicyNo.Text = ""
                End Try

                Try
                    TxtVehicleNo.Text = drt2("VehicleNo")
                Catch ex As Exception
                    TxtVehicleNo.Text = ""
                End Try

                Try
                    TxtCncy.Text = drt2("cncy")
                Catch ex As Exception
                    TxtCncy.Text = ""
                End Try

                Try
                    'TxtPdt.Text = Mid(Trim(drt2("PaidDt")), 4, 2) + "/" + Mid(Trim(drt2("PaidDt")), 1, 2) + "/" + Mid(Trim(drt2("PaidDt")), 7, 4)

                    TxtPdt.Text = Format(drt2("PaidDt"), "dd/MM/yyyy")



                Catch ex As Exception
                    TxtPdt.Text = ""
                End Try
                Try
                    TxtAmt.Text = drt2("PaidPremium")
                Catch ex As Exception
                    TxtAmt.Text = "0"
                End Try
                Try
                    TxtChqNo.Text = drt2("ChequeNo")
                Catch ex As Exception
                    TxtChqNo.Text = ""
                End Try

                'Try
                'TxtType.Text = drt2("Premium")
                'Catch ex As Exception
                'TxtPremium.Text = ""
                'End Try

            Next

        Else


            ' TxtConCode.Text = " "
            TxtRefno.Text = " "
            TxtPolDt.Text = " "
            TxtAmt.Text = " "



        End If



        BindTheGrid()




    End Sub

    Public Sub BindData1()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SIB; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
        CON.Open()

        ' ss = "SELECT * FROM SLine WHERE Sline = '" & Trim(TxtDnno1.Text) & "'"
        ADA = New SqlDataAdapter("SELECT * FROM Refno WHERE Dnno = '" & Trim(TxtDnno1.Text) & "'", CON)
        DS1 = New DataSet

        Save11.Enabled = True
        Save11.ImageUrl = "Menu\save11.png"




        ADA.Fill(DS1, "Refno")
        Save11.Visible = True
        Save1.Visible = False
        count1 = DS1.Tables("Refno").Rows.Count

        If count1 <> 0 Then




            For Each Me.drt2 In DS1.Tables("Refno").Rows


                Try
                    TxtRefno.Text = drt2("Refno")
                Catch ex As Exception
                    TxtRefno.Text = ""
                End Try

                Try
                    TxtPolDt.Text = Format(drt2("PolDt"), "dd/MM/yyyy")

                    'TxtTdt.Text = Format(Today(), "dd/MM/yyyy")
                Catch ex As Exception
                    TxtPolDt.Text = ""
                End Try

                Try
                    TxtCustomer.Text = drt2("Customer")
                Catch ex As Exception
                    TxtCustomer.Text = ""
                End Try


                Try
                    TxtDnno.Text = drt2("DNNo")
                Catch ex As Exception
                    TxtDnno.Text = ""
                End Try

                Try
                    TxtCompany.Text = drt2("Company")
                Catch ex As Exception
                    TxtCompany.Text = ""
                End Try

                Try
                    TxtSumIns.Text = "*****" + Format(drt2("SumIns"), "###,###,###,###,###.00")
                Catch ex As Exception
                    TxtSumIns.Text = ""
                End Try

                Try
                    TxtVehicleNo.Text = drt2("VehicleNo")
                Catch ex As Exception
                    TxtVehicleNo.Text = ""
                End Try

                'TxtInTot.Text = "*****" + Format(TotAmt1, "###,###,###,###,###.00")


                Try
                    TxtPremium.Text = "*****" + Format(drt2("Premium"), "###,###,###,###,###.00")

                Catch ex As Exception
                    TxtPremium.Text = ""
                End Try
                Try
                    TxtPolicyNo.Text = drt2("PolicyNo")
                Catch ex As Exception
                    TxtPolicyNo.Text = ""
                End Try

                Try
                    TxtPolicyNo.Text = drt2("PolicyNo")
                Catch ex As Exception
                    TxtPolicyNo.Text = ""
                End Try

                Try
                    TxtVehicleNo.Text = drt2("VehicleNo")
                Catch ex As Exception
                    TxtVehicleNo.Text = ""
                End Try
                Try
                    TxtCncy.Text = drt2("cncy")
                Catch ex As Exception
                    TxtCncy.Text = ""
                End Try

                Try
                    'TxtPdt.Text = Mid(Trim(drt2("PaidDt")), 4, 2) + "/" + Mid(Trim(drt2("PaidDt")), 1, 2) + "/" + Mid(Trim(drt2("PaidDt")), 7, 4)
                    TxtPdt.Text = Format(drt2("PaidDt"), "dd/MM/yyyy")
                Catch ex As Exception
                    TxtPdt.Text = ""
                End Try
                Try
                    TxtAmt.Text = drt2("PaidPremium")
                Catch ex As Exception
                    TxtAmt.Text = "0"
                End Try
                Try
                    TxtChqNo.Text = drt2("ChequeNo")
                Catch ex As Exception
                    TxtChqNo.Text = ""
                End Try
                'Try
                'TxtType.Text = drt2("Premium")
                'Catch ex As Exception
                'TxtPremium.Text = ""
                'End Try

            Next

        Else


            ' TxtConCode.Text = " "
            TxtRefno.Text = " "
            TxtPolDt.Text = " "
            TxtAmt.Text = " "



        End If



        BindTheGrid()

    End Sub

    Protected Sub TxtFdt_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtFdt.TextChanged
        BindTheGrid()
    End Sub

    Protected Sub TxtTdt_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtTdt.TextChanged
        BindTheGrid()
    End Sub

    Protected Sub Imagebutton6_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton6.Click
        Calendar1.Visible = True
        TxtEpfNo.Text = "1"
    End Sub

    Protected Sub Imagebutton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton3.Click
        BindData1()
    End Sub
End Class

