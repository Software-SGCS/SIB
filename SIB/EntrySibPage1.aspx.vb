Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Imports System.IO

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports System
Imports System.Web.Security
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls



Public Class EntrySibPage1
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
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
    Dim SS As String
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
    Dim T1, T2, T3, Tot1, Tot2 As Integer

    Dim TT1 As String
    Protected WithEvents BtnSubmit As System.Web.UI.WebControls.Button
    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
    Dim TT As String


    Protected WithEvents LstCode As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstVat As System.Web.UI.WebControls.DropDownList

    Protected WithEvents LstFlag2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtPer As System.Web.UI.WebControls.TextBox


    Protected WithEvents TxtLInvNo As System.Web.UI.WebControls.TextBox

    Protected WithEvents LstTT As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Lstvat1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents BtnSave As System.Web.UI.WebControls.Button

    Protected WithEvents txtEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents BttEmpNo As System.Web.UI.WebControls.Button
    Protected WithEvents TxtEpfNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtDepNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtCom As System.Web.UI.WebControls.TextBox

    Protected WithEvents TxtVehNo As System.Web.UI.WebControls.TextBox

    Protected WithEvents TxtPremium As System.Web.UI.WebControls.TextBox

    Protected WithEvents Button1 As System.Web.UI.WebControls.Button

    Protected WithEvents TxtInTot As System.Web.UI.WebControls.Label

    Protected WithEvents C As System.Web.UI.WebControls.CheckBox


    Protected WithEvents Label27 As System.Web.UI.WebControls.Label

    Protected WithEvents Label28 As System.Web.UI.WebControls.Label

    Protected WithEvents Label30 As System.Web.UI.WebControls.Label

    Protected WithEvents Label33 As System.Web.UI.WebControls.Label
    Protected WithEvents Label34 As System.Web.UI.WebControls.Label
    Protected WithEvents Label35 As System.Web.UI.WebControls.Label


    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Label36 As System.Web.UI.WebControls.Label

    Protected WithEvents Label37 As System.Web.UI.WebControls.Label

    Protected WithEvents Label39 As System.Web.UI.WebControls.Label

    Protected WithEvents Label40 As System.Web.UI.WebControls.Label

    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel

    Protected WithEvents Label31 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel


    Protected WithEvents Label26 As System.Web.UI.WebControls.Label

    Protected WithEvents Label41 As System.Web.UI.WebControls.Label

    Protected WithEvents Label42 As System.Web.UI.WebControls.Label

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



        '        YY = Right(Trim(Year(Format(Date.Today))), 2)
        If Not IsPostBack Then


            CMD = New SqlCommand("SELECT DISTINCT TYPE From dbo.Refno", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                TT = Trim(DR.GetValue(0))
                LstTyp.Items.Add(TT)
            End While

            DR.Close()


            'CMD = New SqlCommand("SELECT EXNO,CNAME From Supplier order by CNAME", CON)

            'DR1 = CMD.ExecuteReader
            'While DR1.Read
            '    TT = Trim(DR1.GetValue(1))

            'End While

            'DR1.Close()

            CMD = New SqlCommand("SELECT DISTINCT Refno FROM Refno order by REFNO", CON)
            'ADA = New SqlDataAdapter("SELECT * FROM MasterDocs Where Mas_RefNo='" & Trim(Txtrefno1.text) & "'", CON)
            DR = CMD.ExecuteReader


            While DR.Read
                TT = DR.GetValue(0)
                LstInvoice.Items.Add(TT)
            End While
            DR.Close()
            CMD = New SqlCommand("SELECT DISTINCT POLICYNO FROM Refno order by POLICYNO", CON)
            'ADA = New SqlDataAdapter("SELECT * FROM MasterDocs Where Mas_RefNo='" & Trim(Txtrefno1.text) & "'", CON)
            DR = CMD.ExecuteReader


            While DR.Read
                TT = DR.GetValue(0)
                LstPolicy.Items.Add(TT)
            End While
            DR.Close()

        End If


        'CMD = New SqlCommand("SELECT Itm,Itm_des From WfDesA order by Id", CON)

        'DR = CMD.ExecuteReader

        'If Not IsPostBack Then
        '    TxtEpfNo.Text = "1"

        '    While DR.Read

        '        TT = DR.GetValue(0) + "-" + DR.GetValue(1)

        '    End While



        'End If

        'DR.Close()

        If Not Page.IsPostBack Then
            Calendar1.Visible = False
            LstFlag2.SelectedValue = "No"
            'Label11.Visible = False
            LstFlag2.Visible = False
            TxtPer.Visible = False
            TxtPer.Text = 0

            ' End If
            Refno.Visible = True
            Refno.Enabled = True
            Refno.Text = ""
            '-----
            'ImageButton1.Visible = True
            'ImageButton1.Enabled = True
            'ImageButton6.Visible = True
            'ImageButton1.ImageUrl = "~/Menu/save11.png"
            ' TxtInvDt.Text = " "


            'ADA = New SqlDataAdapter("SELECT * FROM InvoiceNo", CON)

            TxtVehNo.ReadOnly = False
            TxtCncy.Text = "LKR"
            TxtPer.Text = "N"
            TxtPolNo.Text = ""
            TxtCustomer.Text = ""
            TxtCompany.Text = ""
            TxtVehNo.Text = ""
            TxtPolDt.Text = ""

            TxtDno.Text = ""
            TxtDnDt.Text = ""
            txtSins.Text = "0"
            TxtBasic.Text = "0"
            txtSrcc.Text = "0"
            TxtPremium.Text = "0"
            txtTc.Text = "0"
            TxtOth.Text = "0"
            TxtPremium.Text = "0"
            ''sinvno = Mid(Trim(TxtRefno.Text), 8, 5)

            '' Dim Cmd11 As New SqlCommand("UPDATE RefNo SET refno=" & sinvno, CON)
            ''Cmd11.ExecuteNonQuery()

            '-----

        End If





    End Sub


    Public Sub BindTheGrid1()

        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SIB; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
        CON.Open()


        ADA = New SqlDataAdapter("Select id,PolDt ,DNNO ,Refno, CONVERT(DECIMAL(15,2),SumINS,2) as SumINS ,CONVERT(DECIMAL(10,2),Basic,2) as Basic ,CONVERT(DECIMAL(10,2),Srcc,2) as Srcc,CONVERT(DECIMAL(10,2),Tc,2) as Tc,CONVERT(DECIMAL(10,2),Oth,2) as Oth,CONVERT(DECIMAL(15,2),Premium,2) as Premium from Refno where Refno='" & Trim(Refno.Text) & "' order by Id", CON)

        DS = New DataSet
        '' SS = "SELECT * FROM HltMaster1 WHERE Emp_Com='" & Mid(Lstcom.SelectedValue, 1, 3) & "' and Emp_No=" & Val(TempEmpno) & " and Emp_Accyr='" & Trim(TxtYr.Text) & "'"
        ADA.Fill(DS, "Refno")

        count1 = DS.Tables("Refno").Rows.Count

        If count1 <> 0 Then

        Else
            'TxtEmpNam.Enabled = True
            'LstCom1.Enabled = True
            'TxtIdNo.Enabled = True


            'TxtEmpNam.Text = " "
            'TxtIdNo.Text = " "
        End If



        Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,convert(varchar(10),PolDt,103) as PolDt ,DNNO ,Refno, CONVERT(DECIMAL(15,2),SumINS,2) as SumINS ,CONVERT(DECIMAL(10,2),Basic,2) as Basic ,CONVERT(DECIMAL(10,2),Srcc,2) as Srcc,CONVERT(DECIMAL(10,2),Tc,2) as Tc,CONVERT(DECIMAL(10,2),Oth,2) as Oth,CONVERT(DECIMAL(15,2),Premium,2) as Premium from Refno where PolicyNo='" & Trim(TxtPolNo.Text) & "' order by Id", CON)

        cmdCustomers.CommandType = CommandType.Text
        'objConn.Open()
        MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
        MyDataGrid.DataBind()
        CON.Close()
    End Sub
    Protected Sub MyDataGrid_RowCommand(ByVal sender As Object, ByVal e As GridViewCommandEventArgs) Handles MyDataGrid.RowCommand



        If e.CommandName = "Delete" Then
            Dim id As Integer = Convert.ToInt32(e.CommandArgument)
            ' Code to delete the data item with the specified ID '
            Dim DeleteCmd As String = "DELETE from RefNo Where id =" & id

            Dim Cmd As New SqlCommand(DeleteCmd, CON)
            ' Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))

            Cmd.ExecuteNonQuery()

            'BindTheGrid()
        End If

        'BindTheGrid()
    End Sub

    Protected Sub MyDataGrid_RowDeleting(ByVal sender As Object, ByVal e As GridViewDeleteEventArgs) Handles MyDataGrid.RowDeleting

        BindTheGrid1()

        ' Code to delete the row from the GridView control '
    End Sub
    Public Sub BindData()
        ADA = New SqlDataAdapter("SELECT * FROM Refno WHERE Refno = '" & LstInvoice.SelectedValue & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "Refno")
        count = DS.Tables("Refno").Rows.Count
        For Each Me.Dtr1 In DS.Tables("Refno").Rows

            'CMD.CommandText = ("INSERT INTO WFMasAA (Mas_Refno,Mas_CusCode,Mas_InvNo,Mas_InvDt,Mas_Term,Mas_JobNo,Mas_Ves,Mas_Vog,Mas_Pol,Mas_Etd,Mas_Eta,Mas_Shipper,Mas_Cdty,Mas_Rem,Mas_Bilno,Mas_MbNo,Mas_NoPkg,Mas_Gw,Mas_Vol,Mas_NoCntr,Mas_Cncy,Mas_CnDtl) VALUES ('" & Refno.Text & "','" & Mid(Trim(Lstcom.SelectedValue), 1, 3) & "','" & Trim(TxtBillNo.Text) & "','" & Mid(Trim(TxtBillDt.Text), 4, 2) + "/" + Mid(Trim(TxtBillDt.Text), 1, 2) + "/" + Mid(Trim(TxtBillDt.Text), 7, 4) & "','" & Trim(TxtTerm.Text) & "','" & Trim(TxtJobNo.Text) & "','" & Trim(TxtVes.Text) & "','" & Trim(TxtVog.Text) & "','" & Trim(TxtPol.Text) & "','" & Mid(Trim(TxtEdt.Text), 4, 2) + "/" + Mid(Trim(TxtEdt.Text), 1, 2) + "/" + Mid(Trim(TxtEdt.Text), 7, 4) & "','" & Mid(Trim(TxtEta.Text), 4, 2) + "/" + Mid(Trim(TxtEta.Text), 1, 2) + "/" + Mid(Trim(TxtEta.Text), 7, 4) & "','" & Trim(LstShipper.SelectedValue) & "','" & Trim(TxtCdty.Text) & "','" & Trim(TxtRem.Text) & "','" & Trim(TxtBlno.Text) & "','" & Trim(TxtMbno.Text) & "','" & Trim(TxtNoPkg.Text) & "'," & Trim(txtGw.Text) & "," & Trim(TxtVol.Text) & ",'" & Trim(txtNoCntr.Text) & "','" & Trim(txtFcncy.Text) & "','" & Trim(TxtCon.Text) & "')")
            'CMD.ExecuteNonQuery()


            Refno.Text = Dtr1("Refno")

            Try
                TxtPolNo.Text = Dtr1("PolicyNo")
            Catch ex As Exception
                TxtPolNo.Text = ""
            End Try



            Try

                TxtPolDt.Text = Format(DateValue(Dtr1("PolDt")), "dd/MM/yyyy")

            Catch ex As Exception

            End Try

            Try

                TxtCustomer.Text = Dtr1("Customer")

            Catch ex As Exception

            End Try
            Try

                TxtCompany.Text = Dtr1("Company")

            Catch ex As Exception

            End Try

            Try

                TxtVehNo.Text = Trim(Dtr1("VEHICLENO"))

            Catch ex As Exception
                TxtVehNo.Text = "NotAvailable"
            End Try

            Try

                LstTyp.SelectedValue = Trim(Dtr1("TYPE"))

            Catch ex As Exception
                LstTyp.SelectedItem.Value = ""
            End Try

            Try

                TxtUser.Text = Trim(Dtr1("USER"))

            Catch ex As Exception
                TxtUser.Text = ""
            End Try



            'DR1.Close()





            ' Try
            'TxtCon.Text = Dtr1("Mas_CnDtl")
            ' Catch ex As Exception

            '  End Try

        Next
    End Sub
    Public Sub BindData1()
        ADA = New SqlDataAdapter("SELECT * FROM Refno WHERE PolicyNo = '" & Trim(LstPolicy.SelectedValue) & "' Order by PolicyNo", CON)
        DS = New DataSet
        ADA.Fill(DS, "Refno")
        count = DS.Tables("Refno").Rows.Count
        For Each Me.Dtr1 In DS.Tables("Refno").Rows

            'CMD.CommandText = ("INSERT INTO WFMasAA (Mas_Refno,Mas_CusCode,Mas_InvNo,Mas_InvDt,Mas_Term,Mas_JobNo,Mas_Ves,Mas_Vog,Mas_Pol,Mas_Etd,Mas_Eta,Mas_Shipper,Mas_Cdty,Mas_Rem,Mas_Bilno,Mas_MbNo,Mas_NoPkg,Mas_Gw,Mas_Vol,Mas_NoCntr,Mas_Cncy,Mas_CnDtl) VALUES ('" & Refno.Text & "','" & Mid(Trim(Lstcom.SelectedValue), 1, 3) & "','" & Trim(TxtBillNo.Text) & "','" & Mid(Trim(TxtBillDt.Text), 4, 2) + "/" + Mid(Trim(TxtBillDt.Text), 1, 2) + "/" + Mid(Trim(TxtBillDt.Text), 7, 4) & "','" & Trim(TxtTerm.Text) & "','" & Trim(TxtJobNo.Text) & "','" & Trim(TxtVes.Text) & "','" & Trim(TxtVog.Text) & "','" & Trim(TxtPol.Text) & "','" & Mid(Trim(TxtEdt.Text), 4, 2) + "/" + Mid(Trim(TxtEdt.Text), 1, 2) + "/" + Mid(Trim(TxtEdt.Text), 7, 4) & "','" & Mid(Trim(TxtEta.Text), 4, 2) + "/" + Mid(Trim(TxtEta.Text), 1, 2) + "/" + Mid(Trim(TxtEta.Text), 7, 4) & "','" & Trim(LstShipper.SelectedValue) & "','" & Trim(TxtCdty.Text) & "','" & Trim(TxtRem.Text) & "','" & Trim(TxtBlno.Text) & "','" & Trim(TxtMbno.Text) & "','" & Trim(TxtNoPkg.Text) & "'," & Trim(txtGw.Text) & "," & Trim(TxtVol.Text) & ",'" & Trim(txtNoCntr.Text) & "','" & Trim(txtFcncy.Text) & "','" & Trim(TxtCon.Text) & "')")
            'CMD.ExecuteNonQuery()


            Refno.Text = Dtr1("Refno")

            Try
                TxtPolNo.Text = Dtr1("PolicyNo")
            Catch ex As Exception
                TxtPolNo.Text = ""
            End Try



            Try

                TxtPolDt.Text = Format(DateValue(Dtr1("PolDt")), "dd/MM/yyyy")

            Catch ex As Exception

            End Try

            Try

                TxtCustomer.Text = Dtr1("Customer")

            Catch ex As Exception

            End Try
            Try

                TxtCompany.Text = Dtr1("Company")

            Catch ex As Exception

            End Try

            Try

                TxtVehNo.Text = Trim(Dtr1("VEHICLENO"))

            Catch ex As Exception
                TxtVehNo.Text = "NotAvailable"
            End Try

            Try

                LstTyp.SelectedValue = Trim(Dtr1("TYPE"))

            Catch ex As Exception
                LstTyp.SelectedItem.Value = ""
            End Try

            Try

                TxtUser.Text = Trim(Dtr1("USER"))

            Catch ex As Exception
                TxtUser.Text = ""
            End Try



            'DR1.Close()





            ' Try
            'TxtCon.Text = Dtr1("Mas_CnDtl")
            ' Catch ex As Exception

            '  End Try

        Next
    End Sub

    Public Sub BindData2()
        ADA = New SqlDataAdapter("SELECT * FROM Refno WHERE PolicyNo Like '%" & Trim(TxtPolicy1.Text) & "%' Order by PolicyNo", CON)

        ''SELECT * FROM Customers WHERE CustomerName LIKE '%or%'
        DS = New DataSet
        ADA.Fill(DS, "Refno")
        count = DS.Tables("Refno").Rows.Count
        For Each Me.Dtr1 In DS.Tables("Refno").Rows

            'CMD.CommandText = ("INSERT INTO WFMasAA (Mas_Refno,Mas_CusCode,Mas_InvNo,Mas_InvDt,Mas_Term,Mas_JobNo,Mas_Ves,Mas_Vog,Mas_Pol,Mas_Etd,Mas_Eta,Mas_Shipper,Mas_Cdty,Mas_Rem,Mas_Bilno,Mas_MbNo,Mas_NoPkg,Mas_Gw,Mas_Vol,Mas_NoCntr,Mas_Cncy,Mas_CnDtl) VALUES ('" & Refno.Text & "','" & Mid(Trim(Lstcom.SelectedValue), 1, 3) & "','" & Trim(TxtBillNo.Text) & "','" & Mid(Trim(TxtBillDt.Text), 4, 2) + "/" + Mid(Trim(TxtBillDt.Text), 1, 2) + "/" + Mid(Trim(TxtBillDt.Text), 7, 4) & "','" & Trim(TxtTerm.Text) & "','" & Trim(TxtJobNo.Text) & "','" & Trim(TxtVes.Text) & "','" & Trim(TxtVog.Text) & "','" & Trim(TxtPol.Text) & "','" & Mid(Trim(TxtEdt.Text), 4, 2) + "/" + Mid(Trim(TxtEdt.Text), 1, 2) + "/" + Mid(Trim(TxtEdt.Text), 7, 4) & "','" & Mid(Trim(TxtEta.Text), 4, 2) + "/" + Mid(Trim(TxtEta.Text), 1, 2) + "/" + Mid(Trim(TxtEta.Text), 7, 4) & "','" & Trim(LstShipper.SelectedValue) & "','" & Trim(TxtCdty.Text) & "','" & Trim(TxtRem.Text) & "','" & Trim(TxtBlno.Text) & "','" & Trim(TxtMbno.Text) & "','" & Trim(TxtNoPkg.Text) & "'," & Trim(txtGw.Text) & "," & Trim(TxtVol.Text) & ",'" & Trim(txtNoCntr.Text) & "','" & Trim(txtFcncy.Text) & "','" & Trim(TxtCon.Text) & "')")
            'CMD.ExecuteNonQuery()


            Refno.Text = Dtr1("Refno")

            Try
                TxtPolNo.Text = Dtr1("PolicyNo")
            Catch ex As Exception
                TxtPolNo.Text = ""
            End Try



            Try

                TxtPolDt.Text = Format(DateValue(Dtr1("PolDt")), "dd/MM/yyyy")

            Catch ex As Exception

            End Try

            Try

                TxtCustomer.Text = Dtr1("Customer")

            Catch ex As Exception

            End Try
            Try

                TxtCompany.Text = Dtr1("Company")

            Catch ex As Exception

            End Try

            Try

                TxtVehNo.Text = Trim(Dtr1("VEHICLENO"))

            Catch ex As Exception
                TxtVehNo.Text = "NotAvailable"
            End Try

            Try

                LstTyp.SelectedValue = Trim(Dtr1("TYPE"))

            Catch ex As Exception
                LstTyp.SelectedItem.Value = ""
            End Try

            Try

                TxtUser.Text = Trim(Dtr1("USER"))

            Catch ex As Exception
                TxtUser.Text = ""
            End Try



            'DR1.Close()





            ' Try
            'TxtCon.Text = Dtr1("Mas_CnDtl")
            ' Catch ex As Exception

            '  End Try

        Next
    End Sub


    Public Sub dtgCustomers_Update(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
        '' Dim objConn As con = New con(ConfigurationSettings.AppSettings("ConnectionString"))
        ''objConn = New SqlConnection
        ''objConn.ConnectionString = ("Jet Sql:Global Partial Bulk Ops=2;Jet Sql:Registry Path=;Jet Sql:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Insu\Data\Insu.mdb;Mode=Share Deny None;Jet Sql:Engine Type=5;Provider=Microsoft.Jet.Sql.4.0;Jet Sql:System database=;Jet Sql:SFP=False;persist security info=False;Extended Properties=;Jet Sql:Compact Without Replica Repair=False;Jet Sql:Encrypt Database=False;Jet Sql:Create System Database=False;Jet Sql:Don't Copy Locale on Compact=False;User ID=Admin;Jet Sql:Global Bulk Transactions=1")
        ''objConn.Open()


        'Dim cmdCustomers As SqlCommand
        'Dim strid As String = CType(e.Item.FindControl("lblNo"), Label).Text
        'Dim strfg As String = CType(e.Item.FindControl("ddlCountry"), DropDownList).SelectedItem.Value
        'Dim strTpay As Double = Val(CType(e.Item.FindControl("lblTpay"), Label).Text)
        'Dim strEfdt As String = CType(e.Item.FindControl("lblEfdt"), Label).Text
        'Dim strExdt As String = CType(e.Item.FindControl("lblExdt"), Label).Text
        'Dim strVal As String = CType(e.Item.FindControl("lblVal"), Label).Text
        'Dim strCom As String = CType(e.Item.FindControl("lblCom"), Label).Text

        'Dim Talv As Double
        'Dim Balv As Double
        'Dim dr1 As DataRow
        'Dim strSql As String
        'Dim Count1 As Integer

        'Dim str_no As String
        'Dim str_name As String
        'Dim str_mail As String

        'strSql = "UPDATE VehMast SET ALLOW2='" & strfg & "' WHERE ALLOW2='Select' and Veh_No='" & strid & "'"
        'cmdCustomers = New SqlCommand(strSql, objConn)
        '' objConn.Open()
        'cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        'dtgCustomers.EditItemIndex = -1
        'BindTheGrid1()
        'dtgCustomers.Visible = True

        'ADA = New SqlDataAdapter("SELECT * FROM EMPMAST WHERE EMP_no = '22222'", objConn)
        'DS = New DataSet
        'ADA.Fill(DS, "EmpMast")

        'Count1 = DS.Tables("EmpMast").Rows.Count
        'If Count1 <> 0 Then
        '    For Each dr1 In DS.Tables("EmpMast").Rows
        '        Talv = dr1("Emp_talv")
        '        Balv = dr1("Emp_balv")
        '        str_no = dr1("Emp_no")
        '        str_name = dr1("Emp_name")
        '        str_mail = dr1("Emp_email")
        '    Next
        'End If

        '' BindTheGrid()

    End Sub

    Public Sub SetDropDownIndex(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ed As System.Web.UI.WebControls.DropDownList
        ed = sender
        ed.SelectedIndex = ed.Items.IndexOf(ed.Items.FindByText(strCountry))
    End Sub
    Private Sub LstTyp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'DR.Close()
        '' Dim TT1 As String

        'CON = New SqlConnection
        'CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SIB; user id=sa;password=tstc@123")
        ''CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
        'CON.Open()

        'CMD = New SqlCommand("SELECT sys_rno,sys_des1 From SysMast where sys_rtp='03' and substring(sys_des2,1,2)='" & TT1 & "'", CON)


        'DR = CMD.ExecuteReader



        'While DR.Read
        '    TT = DR.GetValue(0) + " " + DR.GetValue(1)

        'End While


        'DR.Close()


        ''CMD = New SqlCommand("SELECT Itm_no,Itm_des,Cat_no,Cost_pr,Sale_pr,itm_stk From ItmMast where mid(itm_no,1,2)='" & CRI1 & "' and mid(itm_no,3,2)='" & CRI2 & "' and mid(itm_no,4,2)='" & CRI3 & "'", CON)
        'CMD = New SqlCommand("SELECT Itm_no,Itm_des,Cat_no,Cost_pr,Sale_pr,itm_stk,Itm_dis From ItmMast where substring(itm_no,1,2)='" & CRI1 & "'and substring(itm_no,3,2)='" & CRI2 & "' and substring(itm_no,5,2)='" & CRI3 & "'", CON)
        'DR = CMD.ExecuteReader

        '' If Not IsPostBack Then
        'While DR.Read

        '    str1 = Space(50)
        '    str2 = Space(20)
        '    str1 = DR.GetValue(1) + str1
        '    str1 = Left(str1, 50)
        '    str2 = str2 + Str(DR.GetValue(4))
        '    str2 = Right(str2, 20)
        '    TT = DR.GetValue(0) + " " + str1 + " " + str2

        'End While
        '' End If

        'DR.Close()
        ''BindTheGrid()
        ''BindTheGrid2()
    End Sub



    Private Sub BtnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click
        Dim Sitmno As String
        Dim Sdes As String
        Dim SRef As String
        'Dim SQty As Double
        Dim SVal As Double

        Sitmno = Trim(TxtDnDt.Text)
        Sdes = TxtDno.Text
        SRef = TxtRef.Text
        SVal = TxtPremium.Text


        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=ImpShp; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
        CON.Open()

        If C.Checked = True Then
            SS = "Y"
        Else
            SS = "N"
        End If

        'If BtnEdit.Enabled = True Then
        'CMD.CommandText = ("INSERT INTO InlTemp (Inv_No,Inv_ItmNo,Inv_des,Inv_pr,Inv_val,Inv_qty) VALUES ('" & LstInvNo.SelectedValue & "','" & Sitmno & "','" & Sdes & "'," & Spri & "," & SVal & "," & SQty & ")")
        'Else
        CMD.CommandText = ("INSERT INTO WFMas (Mas_Refno,Bill_Itm,Bill_Des,Bill_Refno,Bill_Pay,Bill_Amt) VALUES ('" & TxtVehNo.Text & "','" & Sitmno & "','" & Sdes & "','" & SRef & "','" & SS & "'," & SVal & ")")
        ' End If

        CMD.ExecuteNonQuery()
        BindTheGrid1()

    End Sub



    Sub MyDataGrid_DeleteCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        'Dim strConn As String = "Provider=Microsoft.Jet.Sql.4.0;Data Source=" & server.mappath("\pathAndNameToYourDB.mdb") & ";"
        Dim DeleteCmd As String = "DELETE from WFMasA Where id = @Id"
        'Dim MyConn As New SqlConnection(CON)
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))
        'CON.Open()
        Cmd.ExecuteNonQuery()
        'CON.Close()
        BindTheGrid1()
    End Sub
    Sub MyDataGrid_UpdateCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)

        Dim cmdCustomers As SqlCommand


        Dim stritmNo As String = e.Item.Cells(2).Text
        Dim strdes As String = e.Item.Cells(3).Text
        Dim strpr As String = e.Item.Cells(4).Text
        Dim StrQty As String = e.Item.Cells(5).Text
        Dim strval As String = e.Item.Cells(6).Text


        Dim StrSql As String


        StrSql = "UPDATE InlTemp SET Inv_Qty=" & StrQty & " WHERE Inv_Itmno='" & stritmNo & "'"
        cmdCustomers = New SqlCommand(StrSql, CON)
        ' objConn.Open()
        'cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        ' MyDataGrid.EditItemIndex = -1
        BindTheGrid1()
        MyDataGrid.Visible = True

    End Sub





    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LstInvNo.Visible = True
        LstInvNo.Enabled = True
        'TxtInvNo.Visible = False
        'TxtInvNo.Enabled = False
        ' BtnAdd.Enabled = False
        BtnSave.Enabled = False
        ' BtnEdit.Enabled = False

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        CMD.Connection = CON
        'SS = "UPDATE ShipDocs SET Mas_flag7='Y',CL_BlDt='" & Format(DateValue(TxtBillDt.Text), "MM/dd/yyyy") & "',CL_WName='" & Trim(TxtWName.Text) & "',CL_EntryNo='" & Trim(TxtEntry.Text) & "',CL_Ves='" & Trim(TxtVName.Text) & "',CL_LName='" & Trim(TxtLName.Text) & "'    where Mas_Refno='" & Trim(TxtRefno.Text) & "'"
        '' CMD.CommandText = ("UPDATE ShipDocs SET Mas_flag7='Y',CL_BlDt='" & Mid(Trim(TxtBillDt.Text), 4, 2) + "/" + Mid(Trim(TxtBillDt.Text), 1, 2) + "/" + Mid(Trim(TxtBillDt.Text), 7, 4) & "',CL_WName='" & Trim(TxtWName.Text) & "',CL_EntryNo='" & Trim(TxtEntry.Text) & "',CL_Ves='" & Trim(TxtVName.Text) & "',CL_LName='" & Trim(TxtLName.Text) & "',CL_Ctns='" & Trim(TxtCtns.Text) & "' where Mas_Refno='" & Trim(TxtRefno.Text) & "'")
        CMD.ExecuteNonQuery()

        BtnSave.Enabled = False

    End Sub


    'Private Sub LstItmNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstItmNo.SelectedIndexChanged







    '    TxtVal.Text = "         0.00"
    '    TxtRef.Text = ""


    '    CMD = New SqlCommand("SELECT Itm,Itm_des,Itm_Cncy,Itm_Unit,Itm_price From WfDesA where Itm='" & Trim(TxtItm.Text) & "'", CON)

    '    DR = CMD.ExecuteReader

    '    While DR.Read

    '        txtUnit.Text = Trim(DR.GetValue(3))
    '        'LstItmNo.Items.Add(TT)

    '        txtCncy1.Text = Trim(DR.GetValue(2))
    '        txtprice.Text = Format(Val(Trim(DR.GetValue(4))), "00000.00")

    '    End While
    '    DR.Close()


    '    CMD = New SqlCommand("SELECT CNCY,EXG From CUSK where CNCY='" & Trim(txtCncy1.Text) & "'", CON)

    '    DR = CMD.ExecuteReader

    '    While DR.Read
    '        '  q = Format(p, "0000000")
    '        TxtCncy.Text = Format(Val(Trim(DR.GetValue(1))), "000.0000")
    '        'LstItmNo.Items.Add(TT)
    '    End While

    '    TxtQty.Text = "1"


    '    TxtVal.Text = Val(TxtQty.Text) * Val(TxtCncy.Text) * Val(txtprice.Text)
    '    TxtVal.Text = "" + Format(Val(TxtVal.Text), "0000000.00")
    '    DR.Close()
    'End Sub


    Private Sub LstCntry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  DR.Close()
        'Dim TT1 As String


        CMD = New SqlCommand("SELECT sys_rno,sys_des1 From SysMast where sys_rtp='03' and substring(sys_des2,1,2)='" & TT1 & "'", CON)


        DR = CMD.ExecuteReader



        While DR.Read
            TT = DR.GetValue(0) + " " + DR.GetValue(1)

        End While

        DR.Close()




        'CMD = New SqlCommand("SELECT Itm_no,Itm_des,Cat_no,Cost_pr,Sale_pr,itm_stk From ItmMast where mid(itm_no,1,2)='" & CRI1 & "' and mid(itm_no,3,2)='" & CRI2 & "' and mid(itm_no,4,2)='" & CRI3 & "'", CON)
        CMD = New SqlCommand("SELECT Itm_no,Itm_des,Cat_no,Cost_pr,Sale_pr,itm_stk,Itm_dis From ItmMast where substring(itm_no,1,2)='" & CRI1 & "'and substring(itm_no,3,2)='" & CRI2 & "' and substring(itm_no,5,2)='" & CRI3 & "'", CON)
        DR = CMD.ExecuteReader
        'LstItmNo.Items.Clear()

        ' If Not IsPostBack Then
        While DR.Read

            str1 = Space(50)
            str2 = Space(20)
            str1 = DR.GetValue(1) + str1
            str1 = Left(str1, 50)
            str2 = str2 + Str(DR.GetValue(4))
            str2 = Right(str2, 20)
            TT = DR.GetValue(0) + " " + str1 + " " + str2

        End While
        ' End If
        'BtnAdd.Enabled = True
        'BtnEdit.Enabled = True
        DR.Close()
        'BindTheGrid()
        'BindTheGrid2()
    End Sub
    Private Sub LstVat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstVat.SelectedIndexChanged
        If LstVat.SelectedValue = "No" Then
            LstFlag2.Visible = True
            ' Label11.Visible = True
            ' Label12.Visible = True

        Else
            LstFlag2.Visible = False
            ' Label11.Visible = False

            TxtPer.Text = 0
            TxtPer.Visible = False

        End If


    End Sub

    Private Sub LstFlag2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstFlag2.SelectedIndexChanged
        If LstFlag2.SelectedValue = "No" Then
            TxtPer.Visible = False
            TxtPer.Text = 0

            ' Label11.Visible = True
        Else
            '  Label11.Visible = True

            TxtPer.Visible = True
            TxtPer.Text = 6
        End If

    End Sub

    Private Overloads Sub ImgBt_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBt.Click

        ' TxtRem.Visible = False
        'TxtCon.Visible = False
        ' Panel2.Visible = False
        Calendar1.Visible = True
        TxtEpfNo.Text = "1"
    End Sub
    Private Overloads Sub ImgBt1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBt1.Click

        ' TxtRem.Visible = False
        'TxtCon.Visible = False
        ' Panel2.Visible = False
        Calendar1.Visible = True
        TxtEpfNo.Text = "2"
    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged

        If TxtEpfNo.Text = "1" Then
            TxtPolDt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
            TxtDnDt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        End If
        If TxtEpfNo.Text = "2" Then
            TxtDnDt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        End If
        If TxtEpfNo.Text = "3" Then
            '' TxtEta.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        End If
        Calendar1.Visible = False


        'TxtRem.Visible = True'
        ' TxtCon.Visible = True
        'Panel2.Visible = True
        'BindTheGrid()
    End Sub



    Private Sub Lstcom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstCom.SelectedIndexChanged
        If TxtPer.Text = "N" Then
            ADA = New SqlDataAdapter("SELECT * FROM FreInvNo", CON)

            DS = New DataSet
            ADA.Fill(DS, "FreInvNo")

            count1 = DS.Tables("FreInvNo").Rows.Count


            If count1 <> 0 Then

                For Each Me.drt2 In DS.Tables("FreInvNo").Rows
                    '
                    Dim q, s As String
                    Dim p As Double
                    s = drt2("Inv_no")
                    p = drt2("Inv_no")
                    q = Format(p, "0000")

                    TxtVehNo.Text = p
                    Refno.Text = Trim(drt2("Inv_Ref")) + Mid(Trim(Year(Today())), 3, 2) + "/" + q
                    TxtPolNo.Text = "SLPLI" + Mid(Trim(Year(Today())), 3, 2) + q
                Next
            Else
                ' Response.Redirect("InsuDept.aspx")

            End If
            BindTheGrid1()
        Else


        End If



        ' End If
    End Sub





    Private Sub Reflist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not IsPostBack Then
        ''TxtRefno.Text = Trim(Reflist.SelectedValue)
        TxtPolNo.Text = Right(Trim(TxtVehNo.Text), 4)
        ImageButton1.Enabled = True
        BindTheGrid1()
        BindData()
        '
        'End If
    End Sub

    Private Sub TxtItm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDnDt.TextChanged

    End Sub




    Private Sub ImageButton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click


        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SIB; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=ImpShp; user id=sa;password=tstc123")
        CON.Open()


        CMD = New SqlCommand("SELECT DISTINCT TYPE From dbo.Refno ", CON)

        If Trim(Refno.Text) = Trim(TxtRefno1.Text) Then
            DR = CMD.ExecuteReader
            'If BtnEdit.Enabled = True Then
            'CMD.CommandText = ("INSERT INTO InlTemp (Inv_No,Inv_ItmNo,Inv_des,Inv_pr,Inv_val,Inv_qty) VALUES ('" & LstInvNo.SelectedValue & "','" & Sitmno & "','" & Sdes & "'," & Spri & "," & SVal & "," & SQty & ")")
            'Else
            DR.Close()
            SS = "INSERT INTO Refno (RefNo,POLICYNO,PolDt,Customer,Company,TYPE,VEHICLENO,DNNO,SumINS,Premium,Basic,Srcc,Tc,Oth,User) VALUES ('" & Trim(Refno.Text) & "','" & Trim(TxtPolNo.Text) & "','" & Mid(Trim(TxtDnDt.Text), 4, 2) + "/" + Mid(Trim(TxtDnDt.Text), 1, 2) + "/" + Mid(Trim(TxtDnDt.Text), 7, 4) & "','" & Trim(TxtCustomer.Text) & "','" & Trim(TxtCompany.Text) & "','" & Trim(LstTyp.SelectedValue) & "','" & Trim(TxtVehNo.Text) & "','" & Trim(TxtDno.Text) & "'," & Val(Trim(txtSins.Text)) & "," & Val(Trim(TxtPremium.Text)) & "," & Val(Trim(TxtBasic.Text)) & "," & Val(Trim(txtSrcc.Text)) & "," & Val(Trim(txtTc.Text)) & "," & Val(Trim(TxtOth.Text)) & ",'" & Trim(TxtUser.Text) & "')"
            CMD.CommandText = ("INSERT INTO Refno (RefNo,POLICYNO,Cncy,PolDt,Customer,Company,TYPE,VEHICLENO,DNNO,SumINS,Premium,Basic,Srcc,Tc,Oth,[USER]) VALUES ('" & Trim(Refno.Text) & "','" & Trim(TxtPolNo.Text) & "','" & Trim(TxtCncy.Text) & "','" & Mid(Trim(TxtDnDt.Text), 4, 2) + "/" + Mid(Trim(TxtDnDt.Text), 1, 2) + "/" + Mid(Trim(TxtDnDt.Text), 7, 4) & "','" & Trim(TxtCustomer.Text) & "','" & Trim(TxtCompany.Text) & "','" & Trim(LstTyp.SelectedValue) & "','" & Trim(TxtVehNo.Text) & "','" & Trim(TxtDno.Text) & "'," & Val(Trim(txtSins.Text)) & "," & Val(Trim(TxtPremium.Text)) & "," & Val(Trim(TxtBasic.Text)) & "," & Val(Trim(txtSrcc.Text)) & "," & Val(Trim(txtTc.Text)) & "," & Val(Trim(TxtOth.Text)) & ",'" & Trim(TxtUser.Text) & "')")
            ' End If
            ' CMD.CommandText = ("INSERT INTO dbo.Refno(RefNo,POLICYNO,Customer,Company,TYPE,VEHICLENO,DNNO) VALUES ('" & Trim(Refno.Text) & "','" & Trim(TxtPolNo.Text) & "','" & Trim(TxtCustomer.Text) & "','" & Trim(TxtCompany.Text) & "','" & Trim(LstTyp.SelectedValue) & "','" & Trim(TxtVehNo.Text) & "','" & Trim(TxtDno.Text) & "')")
            ' End If
        Else
            DR = CMD.ExecuteReader
            'If BtnEdit.Enabled = True Then
            'CMD.CommandText = ("INSERT INTO InlTemp (Inv_No,Inv_ItmNo,Inv_des,Inv_pr,Inv_val,Inv_qty) VALUES ('" & LstInvNo.SelectedValue & "','" & Sitmno & "','" & Sdes & "'," & Spri & "," & SVal & "," & SQty & ")")
            'Else
            DR.Close()
            SS = "INSERT INTO Refno (RefNo,POLICYNO,PolDt,Customer,Company,TYPE,VEHICLENO,DNNO,SumINS,Premium,Basic,Srcc,Tc,Oth,User) VALUES ('" & Trim(Refno.Text) & "','" & Trim(TxtPolNo.Text) & "','" & Mid(Trim(TxtDnDt.Text), 4, 2) + "/" + Mid(Trim(TxtDnDt.Text), 1, 2) + "/" + Mid(Trim(TxtDnDt.Text), 7, 4) & "','" & Trim(TxtCustomer.Text) & "','" & Trim(TxtCompany.Text) & "','" & Trim(LstTyp.SelectedValue) & "','" & Trim(TxtVehNo.Text) & "','" & Trim(TxtDno.Text) & "'," & Val(Trim(txtSins.Text)) & "," & Val(Trim(TxtPremium.Text)) & "," & Val(Trim(TxtBasic.Text)) & "," & Val(Trim(txtSrcc.Text)) & "," & Val(Trim(txtTc.Text)) & "," & Val(Trim(TxtOth.Text)) & ",'" & Trim(TxtUser.Text) & "')"
            CMD.CommandText = ("INSERT INTO Refno (RefNo,POLICYNO,Cncy,PolDt,Customer,Company,TYPE,VEHICLENO,DNNO,SumINS,Premium,Basic,Srcc,Tc,Oth,[USER]) VALUES ('" & Trim(TxtRefno1.Text) & "','" & Trim(TxtPolNo.Text) & "','" & Trim(TxtCncy.Text) & "','" & Mid(Trim(TxtDnDt.Text), 4, 2) + "/" + Mid(Trim(TxtDnDt.Text), 1, 2) + "/" + Mid(Trim(TxtDnDt.Text), 7, 4) & "','" & Trim(TxtCustomer.Text) & "','" & Trim(TxtCompany.Text) & "','" & Trim(LstTyp.SelectedValue) & "','" & Trim(TxtVehNo.Text) & "','" & Trim(TxtDno.Text) & "'," & Val(Trim(txtSins.Text)) & "," & Val(Trim(TxtPremium.Text)) & "," & Val(Trim(TxtBasic.Text)) & "," & Val(Trim(txtSrcc.Text)) & "," & Val(Trim(txtTc.Text)) & "," & Val(Trim(TxtOth.Text)) & ",'" & Trim(TxtUser.Text) & "')")
            ' End If
            ' CMD.CommandText = ("INSERT INTO dbo.Refno(RefNo,POLICYNO,Customer,Company,TYPE,VEHICLENO,DNNO) VALUES ('" & Trim(Refno.Text) & "','" & Trim(TxtPolNo.Text) & "','" & Trim(TxtCustomer.Text) & "','" & Trim(TxtCompany.Text) & "','" & Trim(LstTyp.SelectedValue) & "','" & Trim(TxtVehNo.Text) & "','" & Trim(TxtDno.Text) & "')")
            ' End If

        End If
        CMD.ExecuteNonQuery()
        BindTheGrid1()



    End Sub

    Private Sub Imagebutton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        'CMD.Connection = CON
        ''SS = "UPDATE ShipDocs SET Mas_flag7='Y',CL_BlDt='" & Format(DateValue(TxtBillDt.Text), "MM/dd/yyyy") & "',CL_WName='" & Trim(TxtWName.Text) & "',CL_EntryNo='" & Trim(TxtEntry.Text) & "',CL_Ves='" & Trim(TxtVName.Text) & "',CL_LName='" & Trim(TxtLName.Text) & "'    where Mas_Refno='" & Trim(TxtRefno.Text) & "'"
        ''CMD.CommandText = ("UPDATE WfMasAA SET Mas_flag7='Y',CL_BlDt='" & Mid(Trim(TxtBillDt.Text), 4, 2) + "/" + Mid(Trim(TxtBillDt.Text), 1, 2) + "/" + Mid(Trim(TxtBillDt.Text), 7, 4) & "',CL_WName='" & Trim(TxtWName.Text) & "',CL_EntryNo='" & Trim(TxtEntry.Text) & "',CL_Ves='" & Trim(TxtVName.Text) & "',CL_LName='" & Trim(TxtLName.Text) & "',CL_Ctns='" & Trim(TxtCtns.Text) & "' where Mas_Refno='" & Trim(TxtRefno.Text) & "'")


        'If TxtPer.Text = "N" Then
        '    SS = "INSERT INTO WFMasAA (Mas_Refno,Mas_CusCode,Mas_InvNo,Mas_InvDt,Mas_Term,Mas_JobNo,Mas_Ves,Mas_Vog,Mas_Pol,Mas_Etd,Mas_Eta,Mas_Shipper,Mas_Cdty,Mas_Rem,Mas_Bilno,Mas_MbNo,Mas_NoPkg,Mas_Gw,Mas_Vol,Mas_NoCntr,Mas_Cncy,Mas_CnDtl) VALUES ('" & Refno.Text & "','" & Mid(Trim(LstCom.SelectedValue), 1, 3) & "','" & Trim(TxtBillNo.Text) & "','" & Mid(Trim(TxtBillDt.Text), 4, 2) + "/" + Mid(Trim(TxtBillDt.Text), 1, 2) + "/" + Mid(Trim(TxtBillDt.Text), 7, 4) & "','" & Trim(TxtTerm.Text) & "','" & Trim(TxtJobNo.Text) & "','" & Trim(TxtVes.Text) & "','" & Trim(TxtVog.Text) & "','" & Trim(TxtPol.Text) & "','" & Mid(Trim(TxtEdt.Text), 4, 2) + "/" + Mid(Trim(TxtEdt.Text), 1, 2) + "/" + Mid(Trim(TxtEdt.Text), 7, 4) & "','" & Mid(Trim(TxtEta.Text), 4, 2) + "/" + Mid(Trim(TxtEta.Text), 1, 2) + "/" + Mid(Trim(TxtEta.Text), 7, 4) & "','" & Trim(LstShipper.SelectedValue) & "','" & Trim(TxtCdty.Text) & "','" & Trim(TxtRem.Text) & "','" & Trim(TxtBlno.Text) & "','" & Trim(TxtMbno.Text) & "','" & Trim(TxtNoPkg.Text) & "','" & Trim(txtGw.Text) & "','" & Trim(TxtVol.Text) & "','" & Trim(txtNoCntr.Text) & "','" & Trim(txtFcncy.Text) & "','" & Trim(TxtCon.Text) & "')"
        '    CMD.CommandText = ("INSERT INTO WFMasAA (Mas_Refno,Mas_CusCode,Mas_InvNo,Mas_InvDt,Mas_Term,Mas_JobNo,Mas_Ves,Mas_Vog,Mas_Pol,Mas_Etd,Mas_Eta,Mas_Shipper,Mas_Cdty,Mas_Rem,Mas_Bilno,Mas_MbNo,Mas_NoPkg,Mas_Gw,Mas_Vol,Mas_NoCntr,Mas_Cncy,Mas_CnDtl,Mas_PkgTyp,Flg3) VALUES ('" & Refno.Text & "','" & Mid(Trim(LstCom.SelectedValue), 1, 3) & "','" & Trim(TxtBillNo.Text) & "','" & Mid(Trim(TxtBillDt.Text), 4, 2) + "/" + Mid(Trim(TxtBillDt.Text), 1, 2) + "/" + Mid(Trim(TxtBillDt.Text), 7, 4) & "','" & Trim(TxtTerm.Text) & "','" & Trim(TxtJobNo.Text) & "','" & Trim(TxtVes.Text) & "','" & Trim(TxtVog.Text) & "','" & Trim(TxtPol.Text) & "','" & Mid(Trim(TxtEdt.Text), 4, 2) + "/" + Mid(Trim(TxtEdt.Text), 1, 2) + "/" + Mid(Trim(TxtEdt.Text), 7, 4) & "','" & Mid(Trim(TxtEta.Text), 4, 2) + "/" + Mid(Trim(TxtEta.Text), 1, 2) + "/" + Mid(Trim(TxtEta.Text), 7, 4) & "','" & Trim(LstShipper.SelectedValue) & "','" & Trim(TxtCdty.Text) & "','" & Trim(TxtRem.Text) & "','" & Trim(TxtBlno.Text) & "','" & Trim(TxtMbno.Text) & "','" & Trim(TxtNoPkg.Text) & "'," & Trim(txtGw.Text) & "," & Trim(TxtVol.Text) & ",'" & Trim(txtNoCntr.Text) & "','" & Trim(txtFcncy.Text) & "','" & Trim(TxtCon.Text) & "','" & Trim(TxtPkgTyp.Text) & "','Y')")
        '    CMD.ExecuteNonQuery()

        '    ImageButton1.Enabled = False


        '    Dim Cmd11 As New SqlCommand("UPDATE FreInvNo SET Inv_No=" & (Val(TxtVehNo.Text) + 1), CON)
        '    Cmd11.ExecuteNonQuery()

        '    ImageButton1.Visible = True
        '    ImageButton1.Enabled = False
        '    'ImageButton6.Visible = True
        '    ImageButton1.ImageUrl = "~/Menu/save1.png"

        '    ImageButton7.Visible = True
        'Else


        '    CMD.CommandText = ("UPDATE WFMasAA SET Mas_Refno='" & Trim(Refno.Text) & "',Mas_CusCode='" & Mid(Trim(LstCom.SelectedValue), 1, 3) & "',Mas_InvNo='" & Trim(TxtBillNo.Text) & "',Mas_InvDt='" & Mid(Trim(TxtBillDt.Text), 4, 2) + "/" + Mid(Trim(TxtBillDt.Text), 1, 2) + "/" + Mid(Trim(TxtBillDt.Text), 7, 4) & "',Mas_Term='" & Trim(TxtTerm.Text) & "',Mas_JobNo='" & Trim(TxtJobNo.Text) & "',Mas_Ves='" & Trim(TxtVes.Text) & "',Mas_Vog='" & Trim(TxtVog.Text) & "',Mas_Pol='" & Trim(TxtPol.Text) & "',Mas_Etd='" & Mid(Trim(TxtEdt.Text), 4, 2) + "/" + Mid(Trim(TxtEdt.Text), 1, 2) + "/" + Mid(Trim(TxtEdt.Text), 7, 4) & "',Mas_Eta='" & Mid(Trim(TxtEta.Text), 4, 2) + "/" + Mid(Trim(TxtEta.Text), 1, 2) + "/" + Mid(Trim(TxtEta.Text), 7, 4) & "',Mas_Shipper='" & Trim(LstShipper.SelectedValue) & "' ,Mas_Cdty='" & Trim(TxtCdty.Text) & "',Mas_Rem='" & Trim(TxtRem.Text) & "',Mas_Bilno='" & Trim(TxtBlno.Text) & "',Mas_MbNo='" & Trim(TxtMbno.Text) & "',Mas_NoPkg='" & Trim(TxtNoPkg.Text) & "',Mas_Gw='" & Trim(txtGw.Text) & "',Mas_Vol='" & Trim(TxtVol.Text) & "',Mas_NoCntr='" & Trim(txtNoCntr.Text) & "',Mas_Cncy='" & Trim(txtFcncy.Text) & "',Mas_CnDtl='" & Trim(TxtCon.Text) & "',Mas_PkgTyp='" & Trim(TxtPkgTyp.Text) & "',Flg3='Y' where Mas_InvNo='" & Trim(TxtBillNo.Text) & "'")
        '    CMD.ExecuteNonQuery()

        '    ImageButton1.Visible = True
        '    ImageButton1.Enabled = False
        '    'ImageButton6.Visible = True
        '    ImageButton1.ImageUrl = "~/Menu/save1.png"

        '    ImageButton7.Visible = True




        'End If




    End Sub

   

    

    


    Private Sub Imagebutton7_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        'ImageButton1.Visible = True
        'ImageButton1.Enabled = True
        ''ImageButton6.Visible = True
        'ImageButton1.ImageUrl = "~/Menu/save11.png"

        TxtPer.Text = "N"

       

        'TxtCdty.Text = " General"
        'txtFcncy.Text = " LKR"
        'TxtCustomer.Text = " "

        'TxtTerm.Text = " "
        'TxtJobNo.Text = " "
        'TxtVes.Text = " "
        'TxtVog.Text = " "
        'TxtPol.Text = " "
        'TxtRem.Text = " "
        'TxtCom.Text = " "
        'TxtNoPkg.Text = " "
        'txtGw.Text = " "
        'TxtVol.Text = " "
        'txtNoCntr.Text = " "
        'TxtCon.Text = " "
        'TxtPkgTyp.Text = " "
        TxtPolNo.Text = ""
        TxtCustomer.Text = ""
        TxtCompany.Text = ""
        TxtVehNo.Text = ""
        TxtPolDt.Text = ""
        TxtDno.Text = ""
        TxtDnDt.Text = ""
        txtSins.Text = "0"
        TxtBasic.Text = "0"
        txtSrcc.Text = "0"
        TxtPremium.Text = "0"
        txtSins.Text = "0"

        Calendar1.Visible = False
        LstFlag2.SelectedValue = "No"
        'Label11.Visible = False
        LstFlag2.Visible = False
        TxtPer.Visible = False
        TxtPer.Text = 0

        ' End If
        Refno.Visible = True
        Refno.Enabled = True
        Refno.Text = ""
        '-----
        'ImageButton1.Visible = True
        'ImageButton1.Enabled = True
        ''ImageButton6.Visible = True
        'ImageButton1.ImageUrl = "~/Menu/save11.png"
        '' TxtInvDt.Text = " "


        'ADA = New SqlDataAdapter("SELECT * FROM InvoiceNo", CON)

        TxtVehNo.ReadOnly = False

        TxtPer.Text = "N"


        TxtDno.Text = ""
        TxtDnDt.Text = ""
        txtSins.Text = "0"
        TxtBasic.Text = "0"
        txtSrcc.Text = "0"
        TxtPremium.Text = "0"
        txtTc.Text = "0"
        TxtOth.Text = "0"
        TxtPremium.Text = "0"


        BindTheGrid1()

    End Sub



    Private Sub LstInvoice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstInvoice.SelectedIndexChanged
        ''ImageButton1.Visible = True
        ''ImageButton1.Enabled = True
        ' ''ImageButton6.Visible = True
        ''ImageButton1.ImageUrl = "~/Menu/save11.png"
        BindData()
        BindTheGrid1()
        TxtPer.Text = "Y"

    End Sub

    Private Sub LstPolicy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstPolicy.SelectedIndexChanged
        ''ImageButton1.Visible = True
        ''ImageButton1.Enabled = True
        ' ''ImageButton6.Visible = True
        ''ImageButton1.ImageUrl = "~/Menu/save11.png"
        BindData1()
        BindTheGrid1()
        TxtPer.Text = "Y"

    End Sub

    
    Protected Sub Imagebutton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton3.Click
        BindData2()
        BindTheGrid1()
        TxtPer.Text = "Y"

    End Sub

    
End Class
