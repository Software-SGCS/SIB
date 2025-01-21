<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EntrySibPage1.aspx.vb" Inherits="SIB.EntrySibPage1" %>
<%@ Register assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
		<title>Samson Insurance Brokers (Pvt) Ltd</title>
				
	    <style type="text/css">
            .style1
        {
            width: 122%;
        }
        *
        {
            margin: 0px;
                padding: 0px;
            }
            .style7
            {
                height: 30px;
                width: 828px;
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
            	background-color:Maroon;
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
             #Menu ul ul ul
             {
              margin-left:190px;
              top:0px;
             }
       
       .style32
            {
                width: 578px;
                height: 48px;
            }
            .style33
            {
                width: 326px;
                height: 48px;
            }
            .style34
            {
                width: 1304px;
                height: 48px;
            }
            .style35
            {
            }
        .style58
            {
                height: 48px;
            }
       
        .style60
            {
                width: 578px;
                height: 48px;
            }
            
		     .style49
            {
                width: 578px;
                height: 3px;
            }
                         
             .style70
            {
            }
		             
           .style62
            {
                width: 578px;
                height: 48px;
            }
             .style47
            {
                width: 578px;
                height: 48px;
            }
            .style75
            {
                height: 48px;
            }
            .style77
            {
                height: 3px;
            }
            .style78
            {
                height: 7px;
            }
            .style79
            {
                width: 578px;
                height: 7px;
            }
            .style80
            {
                height: 3px;
                width: 45px;
            }
            .style81
            {
                width: 45px;
            }
        </style>
		
	    
	</head>
	<body>
    <form id="form1" runat="server">
  <div>
				<table class="style1" style="MARGIN-LEFT: 50px">
					<tr>
						<td class="style33">
                            <asp:image id="Image1" runat="server" Height="43px" 
                                Width="756px" ImageUrl="~/Menu/SibHead.png" ImageAlign="TextTop"></asp:image></td>
						<td class="style34">
							&nbsp;</td>
						
						
						<td class="style34">
							&nbsp;</td>
						
						
						<td class="style34">
							&nbsp;</td>
						
						
						<td class="style34">
                                <asp:ImageButton ID="ImgBt0" runat="server" ImageUrl="~/Menu/siblogo.png" 
                                    Width="72px" Height="52px" ImageAlign="Top" CausesValidation="False" />
						</td>
						
						
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
			
					<table class="style7" id="table1" style="MARGIN-LEFT: 50px; height: 587px;">
					
							<tr class="style35">
							<td class="style35" colspan="3">
                                <asp:label id="Label8" runat="server" Height="25px" Width="114px" Font-Size="Small" Font-Names="Calibri"> 
                                Reference No</asp:label></td>
							<td class="style35" colspan="8">
                            <asp:TextBox ID="Refno" runat="server" Width="205px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                            </td>
							
							<td class="style35" colspan="3">
                                <asp:label id="Label117" runat="server" Height="25px" Width="85px" 
                                    Font-Size="Small" Font-Names="Calibri">Search Policy</asp:label>
                                </td>
							
							<td class="style35" colspan="6">
                                <asp:TextBox ID="TxtPolicy1" runat="server" Width="234px" 
                                    Font-Names="Calibri" Font-Size="Small"></asp:TextBox>
                                </td>
							
						<td class="style35" colspan="2">
                                <asp:ImageButton ID="Imagebutton3" runat="server" Height="21px" 
                                    ImageAlign="AbsBottom" ImageUrl="Menu\serch.gif" Width="83px" />
                                </td>
						<td class="style35" colspan="9">
                                &nbsp;</td>
						</tr>				
						<tr>
							<td class="style35" colspan="3">
                                <asp:label id="Label23" runat="server" Height="25px" Width="86px" 
                                    Font-Size="Small" Font-Names="Calibri">Policy No</asp:label>
                                </td>
							<td class="style35" colspan="3">
                                <asp:TextBox ID="TxtPolNo" runat="server" Width="205px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                            </td>
							
							<td class="style35" colspan="14">
                                &nbsp;</td>
							
						<td class="style35" colspan="2">
                                &nbsp;</td>
						<td class="style35" colspan="9">
                                &nbsp;</td>
						</tr>
						<tr>
							<td class="style35" colspan="3">
                                <asp:label id="Label10" runat="server" Height="25px" 
                                    Width="95px" Font-Size="Small" Font-Names="Calibri">Insured</asp:label></td>
							<td class="style35" colspan="6">
                                <asp:TextBox ID="TxtCustomer" 
                                    runat="server"  Width="384px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                            </td>
							
							<td class="style35" colspan="7">
                                <asp:label id="Label22" runat="server" Height="25px" Width="85px" 
                                    Font-Size="Small" Font-Names="Calibri">Search Refno</asp:label>
                            </td>
							
							<td class="style35" colspan="4">
                                <asp:DropDownList ID="LstInvoice" runat="server" Font-Names="Calibri" 
                                    Height="28px" Width="198px" AutoPostBack="True" BackColor="#FFCCCC">
                                </asp:DropDownList>
                            </td>
							
						<td class="style35" colspan="2">
                                &nbsp;</td>
						<td class="style35" colspan="9">
                                &nbsp;</td>
						</tr>
						<tr>
							<td class="style35" colspan="3">
                                <asp:label id="Label5" runat="server" Height="25px" 
                                    Width="153px" Font-Size="Small" Font-Names="Calibri">Insurance Company</asp:label></td>
							<td class="style35" colspan="7">
                                <asp:TextBox ID="TxtCompany" 
                                    runat="server"  Width="386px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                            </td>
							
							<td class="style35" colspan="5">
                                <asp:label id="Label116" runat="server" Height="25px" Width="85px" 
                                    Font-Size="Small" Font-Names="Calibri">Search Policy</asp:label>
                            </td>
							
							<td class="style35" colspan="5">
                                <asp:DropDownList ID="LstPolicy" runat="server" Font-Names="Calibri" 
                                    Height="28px" Width="198px" AutoPostBack="True" BackColor="#FFCCCC">
                                </asp:DropDownList>
                            </td>
							
						<td class="style35" colspan="2">
                                &nbsp;</td>
						<td class="style35" colspan="9" rowspan="4">
                                &nbsp;</td>
						</tr>
						<tr>
							<td colspan="3">
                                <asp:label id="Label3" runat="server" Height="25px" 
                                    Width="152px" Font-Size="Small" Font-Names="Calibri">Type</asp:label></td>
							<td colspan="5">
                                <asp:DropDownList ID="LstTyp" runat="server" Height="25px" Width="200px" 
                                    Font-Names="Calibri" Font-Size="Small" AutoPostBack="True">
                                </asp:DropDownList>
                            </td>
							
							<td colspan="5">
                                <asp:label id="Label4" runat="server" Height="25px" 
                                    Width="67px" Font-Size="Small" Font-Names="Calibri">Vehicle No</asp:label>
                            </td>
							
							<td colspan="5">
                                <asp:TextBox ID="TxtVehNo" runat="server" Width="157px" 
                                    Font-Names="Calibri" Font-Size="Small"></asp:TextBox>
                                </td>
						<td class="style70" colspan="2" rowspan="3">
                                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
                                    BorderColor="Black" Font-Names="Verdana" 
                                    Font-Size="9pt" ForeColor="Black" Height="32px" NextPrevFormat="ShortMonth" 
                                    Width="90px" BorderStyle="Solid" CellSpacing="1">
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
						<td class="style70" colspan="2" rowspan="3">
                                &nbsp;</td>
						</tr>
                      <tr>
							<td colspan="3">
                                <asp:label id="Label17" runat="server" Height="25px" Width="113px" 
                                    Font-Size="Small" Font-Names="Calibri">Policy Date</asp:label>
                                </td>
							<td colspan="5">
                                <asp:TextBox ID="TxtPolDt" runat="server" Width="92px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                                <asp:ImageButton ID="ImgBt" runat="server" ImageUrl="~/Menu/Cal3.jpg" 
                                    Width="33px" Height="24px" ImageAlign="Top" CausesValidation="False" />
                            </td>
							
							<td colspan="5">
                                <asp:label id="Label115" runat="server" Height="25px" 
                                    Width="65px" Font-Size="Small" Font-Names="Calibri">User</asp:label>
                            </td>
							
							<td colspan="5">
                                <asp:TextBox ID="TxtUser" runat="server" Width="160px" 
                                    Font-Names="Calibri" Font-Size="Small"></asp:TextBox>
                                </td>
						</tr>
						<tr>
							<td colspan="3" class="style78">
                                <asp:label id="Label119" runat="server" Height="25px" Width="113px" 
                                    Font-Size="Small" Font-Names="Calibri">Currency</asp:label>
                                </td>
							<td colspan="10" class="style78">
                                <asp:TextBox ID="TxtCncy" runat="server" Width="64px" 
                                    Font-Names="Calibri" Font-Size="Small"></asp:TextBox>
                                </td>
							
							<td class="style79" colspan="5">
                                </td>
						</tr>
						
					    <tr>
							<td class="style77" colspan="2">
                                <asp:label id="Label78" runat="server" Height="25px" Width="93px" 
                                    Font-Size="Small" Font-Names="Calibri">Date(D/N )</asp:label>
                            </td>
							<td class="style80">
                                &nbsp;</td>
							<td class="style77">
                                <asp:label id="Label38" runat="server" Height="25px" Width="77px" 
                                    Font-Size="Small" Font-Names="Calibri">D/N No</asp:label>
                            </td>
							<td class="style77" colspan="3">
                                <asp:label id="Label118" runat="server" Height="25px" Width="77px" 
                                    Font-Size="Small" Font-Names="Calibri">New Refno</asp:label>
                            </td>
							<td class="style77" colspan="5">
                                <asp:label id="Label114" runat="server" Height="25px" Width="79px" 
                                    Font-Size="Small" Font-Names="Calibri">Sum Insured</asp:label>
                            </td>
							<td class="style77" colspan="5">
                                &nbsp;</td>
							<td class="style77">
                                <asp:label id="Label72" runat="server" Height="25px" Width="72px" 
                                    Font-Size="Small" Font-Names="Calibri">Basic</asp:label>
                            </td>
						    <td class="style49">
                                <asp:label id="Label75" runat="server" Height="25px" Width="60px" 
                                    Font-Size="Small" Font-Names="Calibri">Srcc</asp:label>
                            </td>
						    <td class="style49">
                                <asp:label id="Label76" runat="server" Height="25px" Width="57px" 
                                    Font-Size="Small" Font-Names="Calibri">Tc</asp:label>
                            </td>
						    <td class="style49">
                                <asp:label id="Label73" runat="server" Height="25px" Width="72px" 
                                    Font-Size="Small" Font-Names="Calibri">Other</asp:label>
                                </td>
						    <td class="style49">
                                <asp:label id="Label77" runat="server" Height="25px" Width="84px" 
                                    Font-Size="Small" Font-Names="Calibri">Premium</asp:label>
                                </td>
						    <td class="style49">
                                </td>
						    <td class="style49" colspan="2">
                                </td>
						    <td class="style49" colspan="2">
                                </td>
						    <td class="style49" colspan="2">
                                </td>
						    <td class="style49">
                                </td>
						    <td class="style49">
                                </td>
						</tr>
					      <tr>
							<td class="style75">
                                    <asp:TextBox ID="TxtDnDt" runat="server" Width="91px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                              </td>
							<td class="style75">
                                <asp:ImageButton ID="ImgBt1" runat="server" ImageUrl="~/Menu/Cal3.jpg" 
                                    Width="33px" Height="24px" ImageAlign="Top" CausesValidation="False" />
                              </td>
							<td class="style81">
                                    &nbsp;</td>
							<td>
                                    <asp:TextBox ID="TxtDno" runat="server" Width="201px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                              </td>
							<td>
                                    <asp:TextBox ID="TxtRefno1" runat="server" Width="144px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                              </td>
							<td colspan="12">
                                    <asp:TextBox ID="txtSins" runat="server"  Width="117px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                                </td>
							<td>
                                    <asp:TextBox ID="TxtBasic" runat="server"  Width="72px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                              </td>
						    <td class="style58">
                                    <asp:TextBox ID="txtSrcc" runat="server"  Width="73px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                                </td>
						    <td class="style32">
                                    <asp:TextBox ID="txtTc" runat="server" Width="71px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                                </td>
						    <td class="style32">
                                    <asp:TextBox ID="TxtOth" runat="server"  Width="74px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                              </td>
						    <td class="style58">
                                    <asp:TextBox ID="TxtPremium" runat="server"  Width="82px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                              </td>
						    <td class="style58" colspan="4">
                                <asp:ImageButton ID="ImageButton2" runat="server" Height="32px" 
                                    ImageUrl="~/Menu/Insert-Button.png" Width="35px" />
                              </td>
						    <td class="style58" colspan="4">
                                &nbsp;</td>
						    <td class="style32">
                                &nbsp;</td>
                             <td class="style58">
                                 </td>
                             <td class="style58">
                                 </td>
                             <td class="style58">
                                 </td>
                              <td class="style58">
                                  </td>
                              <td class="style58">
                                  </td>
                               <td class="style58">
                                   </td>
                                
						</tr>
					    <tr>
							<td class="style60" colspan="22" rowspan="3">
                                						
								<div>
									<div id="Layer1" style="OVERFLOW: scroll; WIDTH: 1009px; HEIGHT: 135px">
    <asp:GridView ID="MyDataGrid" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" 
                                            BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" 
                                            Font-Names="Calibri" Font-Size="Small" Width="987px" 
                                            AutoGenerateColumns="False" AutoGenerateDeleteButton="false" 
                                            AutoGenerateEditButton="false" Height="16px" >
        <RowStyle BackColor="#F7F7DE" />
        
        
        
        
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" visible="false"/>
                 
                  <asp:TemplateField HeaderText="Delete">
                  <ItemTemplate>
                  <asp:ImageButton ID="btnDelete" runat="server" ImageUrl="menu\delete.jpg" CommandName="Delete" CommandArgument='<%# Eval("id") %>' />
                  </ItemTemplate>
            </asp:TemplateField>
             
            
            
                        <asp:BoundField DataField="PolDt" ReadOnly="True" HeaderText="Date">
							<HeaderStyle Width="1.2in"></HeaderStyle>
						</asp:BoundField>
						<asp:BoundField DataField="DNNO" ReadOnly="True" HeaderText="D/N No  ">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
						<asp:BoundField DataField="Refno" ReadOnly="True" HeaderText="Refno  ">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
						
						<asp:BoundField DataField="SumINS" ReadOnly="True" HeaderText="Sum Insured">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundField>
						
						<asp:BoundField DataField="Basic" ReadOnly="True" HeaderText="Basic">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundField>
						
						<asp:BoundField DataField="Srcc" ReadOnly="True" HeaderText="Srcc">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundField>
						
						<asp:BoundField DataField="Tc" ReadOnly="True" HeaderText="Tc">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundField>
						<asp:BoundField DataField="Oth" ReadOnly="True" HeaderText="Other">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundField>
						<asp:BoundField DataField="PREMIUM" ReadOnly="True" HeaderText="Premium">
							<HeaderStyle Width="1.0in"></HeaderStyle>
							<ItemStyle HorizontalAlign="right"></ItemStyle>
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
						    <td class="style62" colspan="2">
                                <asp:ImageButton ID="ImageButton7" runat="server" Height="33px" 
                                    ImageUrl="~/Menu/next-button.png" Width="38px" />
                              </td>
						    <td class="style62" colspan="4">
                                    &nbsp;</td>
						    <td class="style62" colspan="2">
                                    &nbsp;</td>
						    <td class="style60">
                                    &nbsp;</td>
						</tr>
					    <tr>
						    <td class="style62" colspan="2">
                                &nbsp;</td>
						    <td class="style62" colspan="4">
                                &nbsp;</td>
						    <td class="style62" colspan="2">
                                &nbsp;</td>
						    <td class="style60">
                                &nbsp;</td>
						</tr>
					<tr>
						    <td class="style32" colspan="9">
                                &nbsp;</td>
						</tr>
						
						
						
					
						<tr>
							<td class="style47" colspan="18">
                                &nbsp;</td>
						    <td class="style32" colspan="2">
                                <asp:TextBox ID="TxtCom" runat="server" Visible="False" Width="35px"></asp:TextBox>
                            </td>
						    <td class="style32" colspan="2">
                                <asp:TextBox ID="TxtEpfNo" runat="server" Height="25px" Width="22px" 
                                    Visible="False"></asp:TextBox>
                                <asp:TextBox ID="TxtPer" runat="server" Visible="False" Height="25px" 
                                    Width="42px"></asp:TextBox>
                            </td>
						</tr>						
					
					
					
						<tr>
							<td class="style47" colspan="18">
                                <asp:TextBox ID="TxtRef" runat="server" Visible="False"></asp:TextBox>
                                <asp:DropDownList ID="LstCom" runat="server" Height="25px" Width="285px" 
                                    Font-Names="Calibri" Font-Size="Small" AutoPostBack="True" 
                                    BackColor="#DEDFDE">
                                </asp:DropDownList>
                            </td>
						    <td class="style32" colspan="2">
                                <asp:Label ID="TxtInTot" runat="server" Text="Label" Visible="False"></asp:Label>
                                <asp:ImageButton ID="ImageButton1" runat="server" Height="36px" 
                                    ImageUrl="~/Menu/save11.png" Width="40px" Enabled="False" 
                                    Visible="False" />
                            </td>
						    <td class="style32" colspan="2">
                                <asp:DropDownList ID="LstFlag2" runat="server" Visible="False" Height="25px" 
                                    Width="36px">
                                </asp:DropDownList>
                            </td>
						</tr>			
					
					</table>
					
				</div>
      <div>


  </div>
    
    
    </form>
</body>
</html>

