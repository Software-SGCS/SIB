<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EntryCustomer.aspx.vb" Inherits="SIB.EntryCustomer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
		<title>Samson Insurance Brokers (Pvt) Ltd</title>
				
	    <style type="text/css">
            .style1
        {
            width: 122%;
        }
        .style2
        {
            width: 339px;
        }
        *
        {
            padding:0px;
	        margin-left: 0px;
	        margin-right: 0px;
	        margin-top: 0px;
        }
            .style10
            {
                width: 308px;
                height: 48px;
            }
                       
            #Menu ul
        {
        	list-style:none;
        }
            #Menu ul li
            {
            	background-color:blue;
            	border:1px solid white;
            	width:190px;
            	height:35px;
            	line-height:35px;
            	text-align:center;
            	float:left;
            	position:relative;
            }
              #Menu ul li a
              {
              	text-decoration:none;
              	color:White;
              	display:block;
	            width: 191px;
              }
              #Menu ul li a:hover
              {
                 background-color:Gray;
			           
              }
              /*Second UL */
              #Menu ul ul
              {
              position:absolute;
             display:none;       
              }
              #Menu ul li:hover >ul
              {
              display:block;
              }
       
       
       
       
            .style33
            {
                width: 578px;
                height: 48px;
            }
            .style34
            {
                width: 1304px;
                height: 48px;
            }
            .style35
            {
                width: 97px;
            }
       
       
       
       
            .style36
            {
                width: 97px;
                height: 22px;
            }
            .style37
            {
                height: 22px;
            }
       
       
       
       
            .style38
            {
                width: 97px;
                height: 26px;
            }
            .style39
            {
                height: 26px;
            }
            .style40
            {
                height: 25px;
            }
            .style41
            {
                width: 199px;
            }
       
       
       
       
            .style42
            {
                width: 97px;
                height: 13px;
            }
            .style43
            {
                height: 13px;
            }
            .style44
            {
                width: 97px;
                height: 3px;
            }
            .style45
            {
                height: 3px;
            }
                   
       
       
       
        </style>
		
	    
		
	</head>
	<body>
    <form id="form1" runat="server">
  <div>
				<table class="style1" style="MARGIN-LEFT: 50px">
					<tr>
						<td class="style33">
                            <asp:image id="Image1" runat="server" Height="38px" 
                                Width="676px" ImageUrl="~/Menu/SibHead.png" ImageAlign="TextTop"></asp:image></td>
						<td class="style34">
							&nbsp;</td>
						
						
						<td class="style34">
							&nbsp;</td>
						
						
						<td class="style34">
                                &nbsp;</td>
						
						
						<td class="style34">
                                <asp:ImageButton ID="ImgBt0" runat="server" ImageUrl="~/Menu/siblogo.png" 
                                    Width="62px" Height="35px" ImageAlign="Top" 
                                CausesValidation="False" />
						</td>
						
						
						<td class="style34">
                                &nbsp;</td>
						
						
						<td class="style34">
							&nbsp;</td>
						
						
						<td class="style34">
							&nbsp;</td>
						
						
						<td class="style34">
                                    &nbsp;</td>
						
						
                                <td class="style10" rowspan="2">
                                    &nbsp;</td>
                                    
                             
					</tr>
					
					
					
				</table>
			</div>
			<div id="Menu" class="style1" style="MARGIN-LEFT: 50px">
				<ul>
					<li>
						<a href="Home.aspx">Home</a>
					</li>
					<li>
						<a href="#">Services</a>
						  <ul>
						<li>
								<a href="EntrySibPage1.aspx">Policy</a>
							</li>
							<li>  
								<a href="EntryCustomer.aspx">Payment Received</a>
							</li>
							<li>  
								<a href="EntryInquery.aspx">New Inquery</a>
							</li>
							<li>
								<a href="#">-------------</a>
							        <ul>
					                     <li>
					                     	<a href="#">-------------</a>
					                     </li>
							             <li>
					                     	<a href="#">-------------</a>
					                     </li>
							        </ul>
							
							</li>
							
							<li>
								<a href="#">-------------</a>
							</li>
						</ul>
					</li>
					<li>
						<a href="#">Information</a>
						<ul>
						<li>
								<a href="#">-------------</a>
							</li>
							<li>
								<a href="#">-------------</a>
							</li>
							<li>
								<a href="#">-------------</a>
							</li>
							<li>
								<a href="#">-------------</a>
							</li>
							<li>
								<a href="#">-------------</a>
							</li>
							<li>
								<a href="#">-------------</a>
							</li>
						</ul>
					   </li>
						<li>
						<a href="#">Reports</a>
					</li>
					<li>
						<a href="#">Contacts</a>
					</li>
					<li>
						<a href="#"></a>
					</li>
				</ul>
			</div>		
			
				
				<div>
					<table class="style1" id="table1" style="MARGIN-LEFT: 50px">
						<tr>
							<td class="style35"><asp:label id="Label4" runat="server" Height="24px" Width="112px" Font-Size="Small" Font-Names="Calibri">D/N 
                                No</asp:label></td>
							<td colspan="20">
								<asp:DropDownList ID="LstPolicyNo" runat="server" Height="24px" Width="224px" 
                                    AutoPostBack="True" Font-Names="Calibri" Font-Size="Small">
                                </asp:DropDownList>
							</td>
							<td colspan="5">
								<asp:label id="Label12" runat="server" Height="24px" Width="57px" 
                                    Font-Size="Small" Font-Names="Calibri">From Date</asp:label>
							</td>
							<td colspan="2">
								<asp:textbox id="TxtFdt" tabIndex="1" runat="server" Height="20px" 
                                    Width="66px" Font-Size="Small"
									Font-Names="Calibri" AutoPostBack="True"></asp:textbox>
							</td>
							<td>
								<asp:imagebutton id="Imagebutton6" runat="server" Height="31px" Width="36px" 
                                    ImageUrl="~/Menu/Cal2.jpg" ImageAlign="AbsBottom"></asp:imagebutton>
							</td>
							<td>
								<asp:label id="Label13" runat="server" Height="24px" Width="45px" 
                                    Font-Size="Small" Font-Names="Calibri">To Date</asp:label>
							</td>
							<td colspan="2">
								<asp:textbox id="TxtTdt" tabIndex="1" runat="server" Height="20px" 
                                    Width="64px" Font-Size="Small"
									Font-Names="Calibri" AutoPostBack="True"></asp:textbox>
							</td>
							<td colspan="2">
								<asp:imagebutton id="Imagebutton5" runat="server" Height="30px" Width="37px" 
                                    ImageUrl="~/Menu/Cal2.jpg" ImageAlign="AbsBottom"></asp:imagebutton>
							</td>
							<td colspan="2">
							</td>
							<td colspan="7">
							</td>
							<td class="style5" colspan="9" rowspan="4">
                                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
                                    BorderColor="Black" Font-Names="Verdana" 
                                    Font-Size="9pt" ForeColor="Black" Height="170px" NextPrevFormat="ShortMonth" 
                                    Width="249px" BorderStyle="Solid" CellSpacing="1">
                                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                    <TodayDayStyle BackColor="#999999" ForeColor="White" />
                                    <OtherMonthDayStyle ForeColor="#999999" />
                                    <DayStyle BackColor="#CCCCCC" />
                                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                                        Height="8pt" />
                                    <TitleStyle BackColor="#333399" Font-Bold="True" 
                                        Font-Size="12pt" ForeColor="White" BorderStyle="Solid" Height="12pt" />
                                </asp:Calendar>
							</td>
							<td class="style5" colspan="37" rowspan="4">
								&nbsp;</td>
							<td>
								</td>
							
						</tr>
						
											
						<tr>
							<td class="style36"><asp:label id="Label8" runat="server" Height="16px" Width="114px" Font-Size="Small" Font-Names="Calibri">Search 
                                D/N No</asp:label></td>
							<td class="style37" colspan="5">
								<asp:textbox id="TxtDnno1" tabIndex="1" runat="server" Height="20px" 
                                    Width="221px" Font-Size="Small"
									Font-Names="Calibri"></asp:textbox>
								</td>
						
							<td class="style37" colspan="15">
								<asp:imagebutton id="Imagebutton3" runat="server" Height="25px" Width="78px" 
                                    ImageUrl="Menu\serch.gif" ImageAlign="AbsBottom"></asp:imagebutton>
								</td>
						
							<td class="style37" colspan="4">
                                <asp:label id="Label19" runat="server" Height="24px" Width="67px" 
                                    Font-Size="Small" Font-Names="Calibri">Policy No</asp:label>
                            </td>
						
							<td class="style37" colspan="18">
								<asp:textbox id="TxtPolicyNo" runat="server" Height="20px" Width="238px" 
                                    Font-Names="Calibri" Font-Size="Small" Enabled="False" BackColor="#CCFFCC"></asp:textbox>
                            </td>
						
						</tr>
						<tr>
							<td class="style36"><asp:label id="Label5" runat="server" Height="16px" Width="114px" Font-Size="Small" Font-Names="Calibri">Reference 
                                No</asp:label></td>
							<td class="style37" colspan="20">
                                <asp:textbox id="TxtRefno" tabIndex="3" runat="server" 
                                    Height="20px" Width="179px" Font-Size="Small"
									Font-Names="Calibri" Enabled="False" BackColor="#CCFFCC"></asp:textbox></td>
						
							<td class="style37" colspan="4">
                                <asp:Label ID="Label6" runat="server" Font-Names="Calibri" Font-Size="Small" 
                                    Text="Customer" Width="57px"></asp:Label>
                            </td>
						
							<td class="style37" colspan="18">
                                <asp:textbox id="TxtCustomer" tabIndex="3" 
                                    runat="server" Height="20px" Width="320px" Font-Size="Small"
									Font-Names="Calibri" Enabled="False" BackColor="#CCFFCC"></asp:textbox></td>
						
						</tr>
						
						
						<tr>
							<td class="style38"><asp:label id="Label10" 
                                    runat="server" Height="24px" Width="136px" Font-Size="Small" 
                                    Font-Names="Calibri">D/N No</asp:label></td>
							<td class="style39" colspan="20">
                                <asp:textbox id="TxtDnno" tabIndex="3" runat="server" 
                                    Height="20px" Width="179px" Font-Size="Small"
									Font-Names="Calibri" EnableViewState="False" BackColor="#CCFFCC"></asp:textbox></td>
						
							<td class="style39" colspan="4">
                                <asp:Label ID="Label15" runat="server" Font-Names="Calibri" Font-Size="Small" 
                                    Text="Company"></asp:Label>
                            </td>
						
							<td class="style39" colspan="18">
                                <asp:textbox id="TxtCompany" tabIndex="3" 
                                    runat="server" Height="20px" Width="320px" Font-Size="Small"
									Font-Names="Calibri" Enabled="False" BackColor="#CCFFCC"></asp:textbox></td>
						
						</tr>
						<tr>
							<td class="style38">
                           <asp:label id="Label18" 
                                    runat="server" Height="24px" Width="136px" Font-Size="Small" 
                                    Font-Names="Calibri">Policy date</asp:label>     </td>
							<td class="style39" colspan="20">
                                <asp:textbox id="TxtPolDt" runat="server" 
                                    Height="20px" Width="178px" Font-Size="Small" Font-Names="Calibri" 
                                    Enabled="False" BackColor="#CCFFCC"></asp:textbox></td>
						
							<td class="style39" colspan="4">
                                <asp:label id="Label16" runat="server" Height="24px" Width="50px" 
                                    Font-Size="Small" Font-Names="Calibri">Premium</asp:label>
                            </td>
						
							<td class="style39" colspan="18">
								<asp:textbox id="TxtPremium" runat="server" Height="20px" Width="138px" 
                                    Font-Names="Calibri" Font-Size="Small" Enabled="False" BackColor="#CCFFCC"></asp:textbox>
                                                    </td>
						
						</tr>
						
						<tr>
							<td class="style42">
                                <asp:label id="Label3" 
                                    runat="server" Height="24px" Width="136px" Font-Size="Small" 
                                    Font-Names="Calibri">Sum Insured</asp:label>     </td>
							<td class="style43" colspan="20">
                                <asp:textbox id="TxtSumIns" runat="server" 
                                    Height="20px" Width="179px" Font-Size="Small" Font-Names="Calibri" 
                                    Enabled="False" BackColor="#CCFFCC"></asp:textbox></td>
						
							<td class="style43" colspan="4">
                                <asp:label id="Label17" runat="server" Height="24px" Width="71px" 
                                    Font-Size="Small" Font-Names="Calibri">Vehicle No</asp:label>
                            </td>
						
							<td class="style43" colspan="18">
								<asp:textbox id="TxtVehicleNo" runat="server" Height="20px" Width="139px" 
                                    Font-Names="Calibri" Font-Size="Small" Enabled="False" BackColor="#CCFFCC"></asp:textbox>
                                                    </td>
						
						</tr>
							
						
						
						<tr>
							<td class="style42">
                                <asp:label id="Label11" runat="server" Height="24px" Width="129px" Font-Size="Small" Font-Names="Calibri">Paid 
                                Amount(Rs.)</asp:label></td>
							<td class="style43" colspan="3">
                                <asp:textbox id="TxtAmt" runat="server" Height="20px" 
                                    Width="139px" Font-Size="Small" Font-Names="Calibri"></asp:textbox></td>
							<td class="style43" colspan="3">
                                <asp:label id="Label20" runat="server" Height="24px" Width="53px" 
                                    Font-Size="Small" Font-Names="Calibri">Currency</asp:label>
                            </td>
							<td class="style43" colspan="3">
								<asp:textbox id="TxtCncy" runat="server" Height="20px" Width="41px" 
                                    Font-Names="Calibri" Font-Size="Small"></asp:textbox>
                                </td>
							<td class="style43" colspan="4">
                                &nbsp;</td>
							<td class="style43" colspan="6">
								&nbsp;</td>
							<td class="style43" colspan="3">
                                &nbsp;</td>
							<td class="style43" colspan="4">
                                &nbsp;</td>
							<td class="style43" colspan="4">
								&nbsp;</td>
							<td class="style43" colspan="4">
                                &nbsp;</td>
							<td class="style43" colspan="12">
								&nbsp;</td>
							<td class="style43" colspan="3">
                                </td>
							<td class="style43">
                                </td>
							<td class="style43" colspan="3">
                                </td>
							<td class="style43">
								</td>
							<td class="style43" colspan="2">
                                </td>
							<td class="style43" colspan="2">
								</td>
							<td class="style43" colspan="2">
                                </td>
							<td class="style43" colspan="3">
                                </td>
							<td class="style43" colspan="3">
                                </td>
							<td class="style43">
                                </td>
							<td class="style43">
                                </td>
							<td class="style43" colspan="4">
                                </td>
							<td class="style43" colspan="5">
                                </td>
							<td class="style43" colspan="7">
                                </td>
							<td class="style43" colspan="3">
                                </td>
							<td class="style43">
                                </td>
						</tr>
						<tr>
							<td class="style35">
                                <asp:label id="Label1" runat="server" Height="24px" Width="129px" Font-Size="Small" Font-Names="Calibri">Cheque 
                                No</asp:label></td>
							<td class="style6" colspan="88">
                                <asp:textbox id="TxtChqNo" runat="server" Height="20px" 
                                    Width="138px" Font-Size="Small" Font-Names="Calibri"></asp:textbox></td>
						</tr>
						<tr>
							<td class="style35">
                                <asp:label id="Label2" runat="server" Height="24px" Width="129px" Font-Size="Small" Font-Names="Calibri">Paid 
                                Date</asp:label></td>
							<td class="style6">
                                <asp:textbox id="TxtPdt" runat="server" Height="20px" 
                                    Width="91px" Font-Size="Small" Font-Names="Calibri"></asp:textbox></td>
							<td class="style6">
								<asp:imagebutton id="Imagebutton4" runat="server" Height="31px" Width="36px" 
                                    ImageUrl="~/Menu/Cal2.jpg" ImageAlign="AbsBottom"></asp:imagebutton>
							</td>
							<td class="style6" colspan="2">
                                <asp:imagebutton id="Save11" runat="server" Height="30px" Width="35px" 
                                    ImageUrl="Menu\save11.png" ImageAlign="AbsBottom"></asp:imagebutton></td>
							<td class="style6">
                                &nbsp;</td>
							<td class="style6" colspan="2">
                                &nbsp;</td>
							<td class="style6">
								&nbsp;</td>
							<td class="style6" colspan="2">
                                &nbsp;</td>
							<td class="style6">
                                &nbsp;</td>
							<td class="style6">
                                &nbsp;</td>
							<td class="style6" colspan="2">
                                &nbsp;</td>
							<td class="style6">
                                &nbsp;</td>
							<td class="style6">
                                &nbsp;</td>
							<td class="style6">
                                &nbsp;</td>
							<td class="style6">
                                &nbsp;</td>
							<td class="style6" colspan="3">
                                &nbsp;</td>
							<td class="style6" colspan="2">
                                &nbsp;</td>
							<td class="style6">
								&nbsp;</td>
							<td colspan="3">
                                &nbsp;</td>
							<td class="style6" colspan="5">
                                &nbsp;</td>
							<td class="style6" colspan="4">
                                &nbsp;</td>
							<td class="style6">
                                &nbsp;</td>
							<td class="style6">
                                &nbsp;</td>
							<td class="style6">
								&nbsp;</td>
							<td class="style6">
                                &nbsp;</td>
							<td class="style6">
                                &nbsp;</td>
							<td class="style6" colspan="2">
                                &nbsp;</td>
							<td class="style6">
                                &nbsp;</td>
							<td class="style6">
                                &nbsp;</td>
							<td class="style6" colspan="2">
                                &nbsp;</td>
							<td class="style6">
                                &nbsp;</td>
							<td class="style6" colspan="3">
                                &nbsp;</td>
							<td class="style6" colspan="15">
                                <asp:textbox id="TxtEpfNo" runat="server" 
                                    Height="20px" Width="58px" Font-Size="Small" Font-Names="Calibri" 
                                    Visible="False"></asp:textbox></td>
							<td class="style6" colspan="4">
                                &nbsp;</td>
							<td class="style6" colspan="12">
                                &nbsp;</td>
							<td class="style6" colspan="4">
                                &nbsp;</td>
							<td class="style6" colspan="2">
                                &nbsp;</td>
						</tr>
						
						
						
						
						<tr>
							<td class="style35">&nbsp;</td>
							<td class="style6" colspan="88">
								&nbsp;</td>
							<td class="style41"></td>
								
						</tr>
						<tr>
							<td class="style35" rowspan="6">
                                <asp:Image ID="Image2" runat="server" Height="271px" 
                                    ImageUrl="~/Menu/siblogo.png" Width="135px" />
                            </td>
							<td class="style6" colspan="52" rowspan="6">&nbsp;
								<div>
									<div id="Layer1" style="OVERFLOW: scroll; WIDTH: 967px; HEIGHT: 265px">
    <asp:GridView ID="MyDataGrid" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" 
                                            BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" 
                                            Font-Names="Calibri" Font-Size="Small" Width="948px" 
                                            AutoGenerateColumns="False" AutoGenerateDeleteButton="false" 
                                            AutoGenerateEditButton="false" >
        <RowStyle BackColor="#F7F7DE" />
        
        
        
        
        <Columns>
           <asp:BoundField DataField="id" HeaderText="id" visible="false"/>
                 
                                               
                     
                
            <asp:Boundfield DataField="Refno" HeaderText="Reference #">
							<HeaderStyle Width="1.2in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
			</asp:Boundfield>
						<asp:BoundField DataField="PolDt" HeaderText="Policy Date">
							<HeaderStyle Width="1.2in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
          
						<asp:BoundField DataField="PolicyNo" HeaderText="Policy No">
							<HeaderStyle Width="1.2in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
						
						<asp:BoundField DataField="DNNO" HeaderText="D/N No">
							<HeaderStyle Width="1.2in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
						<asp:BoundField DataField="Customer" HeaderText="Customer">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
						<asp:BoundField DataField="Company" HeaderText="Company">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
                        <asp:BoundField DataField="Cncy" HeaderText="Cny">
							<HeaderStyle Width="0.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>                                                                     
                        <asp:BoundField DataField="Premium" HeaderText="Premium">
							<HeaderStyle Width="1.0in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundField>
						<asp:BoundField DataField="ChequeNo" HeaderText="Cheque no">
							<HeaderStyle Width="1.0in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundField>
						<asp:BoundField DataField="PaidDt" HeaderText="Paid Date">
							<HeaderStyle Width="1.0in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
                                    </div>
								</div>
							</td>
							<td class="style6" colspan="3" rowspan="2">
                                &nbsp;</td>
							<td class="style6" colspan="2" rowspan="6">&nbsp;</td>
							<td class="style6" colspan="2" rowspan="2">
                                &nbsp;</td>
							<td class="style6" colspan="2" rowspan="6">&nbsp;</td>
							<td class="style6" rowspan="6">&nbsp;</td>
							<td class="style6" colspan="2" rowspan="6">&nbsp;</td>
							<td class="style6" rowspan="6">&nbsp;</td>
							<td class="style6" colspan="4" rowspan="2">
                                &nbsp;</td>
							<td class="style6" colspan="2" rowspan="6">&nbsp;</td>
							<td class="style6" colspan="2" rowspan="6">&nbsp;</td>
							<td class="style6" rowspan="6">&nbsp;</td>
							<td class="style6" rowspan="6">&nbsp;</td>
							<td class="style6" rowspan="6">&nbsp;</td>
							<td class="style6" colspan="2" rowspan="6">&nbsp;</td>
							<td class="style6">&nbsp;</td>
							<td class="style6" rowspan="3">&nbsp;</td>
							<td class="style6" rowspan="6">&nbsp;</td>
							<td class="style6" rowspan="6">&nbsp;</td>
							<td class="style6" rowspan="6">&nbsp;</td>
							<td class="style6" colspan="2" rowspan="6">&nbsp;</td>
							<td class="style6" colspan="3" rowspan="6">&nbsp;</td>
						</tr>
						<tr>
							<td class="style6"></td>
						</tr>
						<tr>
							<td class="style6" colspan="3">
                                &nbsp;</td>
							<td class="style6" colspan="2">&nbsp;</td>
							<td class="style6" colspan="4">&nbsp;</td>
							<td class="style6">&nbsp;</td>
						</tr>
						<tr>
							<td class="style40" colspan="3"></td>
							<td class="style40" colspan="2"></td>
							<td class="style40" colspan="4"></td>
							<td class="style40" colspan="2"></td>
						</tr>
						<tr>
							<td class="style6" colspan="3">&nbsp;</td>
							<td class="style6" colspan="2">&nbsp;</td>
							<td class="style6" colspan="4">&nbsp;</td>
							<td class="style6" colspan="2">&nbsp;</td>
						</tr>
						<tr>
							<td class="style6" colspan="3">&nbsp;</td>
							<td class="style6" colspan="2">&nbsp;</td>
							<td class="style6" colspan="4">&nbsp;</td>
							<td class="style6" colspan="2">&nbsp;</td>
						</tr>
					</table>
					<table class="style1" style="WIDTH: 100%; HEIGHT: 12px">
						<tr>
							<td class="style2" style="WIDTH: 199px"><asp:imagebutton id="Save1" runat="server" Height="39px" Width="48px" ImageUrl="Menu\save1.png"></asp:imagebutton></td>
							<td class="style2" style="WIDTH: 199px">&nbsp;</td>
							<td class="style2" style="WIDTH: 199px">&nbsp;
								<asp:button id="BtnAdd" tabIndex="7" runat="server" Font-Bold="True" Width="64px" Text="Add"
									Visible="False" Enabled="False"></asp:button></td>
							<td class="style2" style="WIDTH: 199px">&nbsp;
								<asp:button id="BtnEdit" tabIndex="8" runat="server" Font-Bold="True" Width="64px" Text="Edit"
									Visible="False" Enabled="False"></asp:button></td>
							<td>&nbsp;<asp:button id="BtnCle" tabIndex="9" runat="server" Font-Bold="True" Height="24px" Width="64px"
									Text="Clear" Visible="False" Enabled="False"></asp:button></td>
							<td class="style2" style="WIDTH: 199px"><asp:button id="BtnDel" tabIndex="11" runat="server" Font-Bold="True" Width="64px" Text="Delete"
									Visible="False" Enabled="False"></asp:button></td>
							<td>
								<h1>&nbsp;</h1>
							</td>
							<td class="style2" style="WIDTH: 199px">&nbsp;<asp:button id="BtnSave" tabIndex="11" runat="server" Font-Bold="True" Width="64px" Text="Save"
									Visible="False" Enabled="False"></asp:button></td>
							<td>&nbsp;</td>
						</tr>
					</table>
				</div>
      <div>


  </div>
    
    
    </form>
</body>
</html>
