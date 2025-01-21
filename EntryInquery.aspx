<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EntryInquery.aspx.vb" Inherits="SIB.EntryInquery" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
		<title>Samson Insurance Brokers (Pvt) Ltd.</title>
				
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
                width: 578px;
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
					<table class="style1" id="table1" style="MARGIN-LEFT: 50px">
						<tr>
							<td class="style36"><asp:label id="Label4" runat="server" Height="24px" 
                                    Width="139px" Font-Size="Small" Font-Names="Calibri">Customer Id</asp:label></td>
							<td class="style37">
								<asp:textbox id="TxtConCode" tabIndex="1" runat="server" Height="20px" 
                                    Width="72px" Font-Size="Small"
									Font-Names="Calibri"></asp:textbox>
								<asp:imagebutton id="Imagebutton3" runat="server" Height="25px" Width="78px" 
                                    ImageUrl="Menu\serch.gif" ImageAlign="AbsBottom"></asp:imagebutton>
							</td>
							<td class="style37">
								<asp:Button ID="Button1" runat="server" Text="Create New" Width="148px" 
                                    BackColor="#009933" ForeColor="Yellow" />
							</td>
							<td class="style37">
								&nbsp;</td>
							<td class="style37">
								&nbsp;</td>
							<td class="style37">
								&nbsp;</td>
							<td class="style37" colspan="2">
								&nbsp;</td>
							<td class="style37">
								&nbsp;</td>
							<td class="style37">
								&nbsp;</td>
							<td class="style37">
								&nbsp;</td>
							<td class="style37">
								&nbsp;</td>
							<td class="style37" colspan="2">
								&nbsp;</td>
							<td class="style37">
								&nbsp;</td>
							<td class="style37">
								&nbsp;</td>
							<td class="style37">
								&nbsp;</td>
							<td class="style37">
								&nbsp;</td>
							<td class="style37">
								&nbsp;</td>
							<td class="style7">
								&nbsp;</td>
							<td class="style2" style="WIDTH: 199px">&nbsp;</td>
							
						</tr>
						
											
						<tr>
							<td class="style41"><asp:label id="Label8" runat="server" Height="16px" Width="114px" Font-Size="Small" Font-Names="Calibri">Customer 
                                Name</asp:label></td>
							<td class="style41" colspan="18"><asp:textbox id="TxtConNam" tabIndex="3" runat="server" Height="20px" Width="432px" Font-Size="Small"
									Font-Names="Calibri"></asp:textbox></td>
						
							<td class="style41"></td>
						
						</tr>
						<tr>
							<td class="style41"><asp:label id="Label10" 
                                    runat="server" Height="24px" Width="136px" Font-Size="Small" 
                                    Font-Names="Calibri"> Customer Address</asp:label></td>
							<td class="style41" colspan="18"><asp:textbox id="TxtConAdd1" runat="server" Height="20px" Width="432px" Font-Size="Small" Font-Names="Calibri"></asp:textbox></td>
							<td class="style41"></td>
						</tr>
						<tr>
							<td class="style41">
                                <asp:label id="Label11" runat="server" Height="24px" Width="129px" Font-Size="Small" Font-Names="Calibri">Contact 
                                Nos</asp:label></td>
							<td class="style41" colspan="18"><asp:textbox id="TxtContact" runat="server" 
                                    Height="20px" Width="340px" Font-Size="X-Small" Font-Names="Calibri"></asp:textbox></td>
							<td class="style41"></td>
						</tr>
						<tr>
							<td><asp:label id="Label1" 
                                    runat="server" Height="24px" Width="136px" Font-Size="Small" 
                                    Font-Names="Calibri">Email</asp:label></td>
							<td colspan="2">
                                <asp:textbox id="TxtCusEmail" runat="server" Height="20px" 
                                    Width="340px" Font-Size="Small" Font-Names="Calibri"></asp:textbox></td>
							<td colspan="2">
                                <asp:Label ID="Label14" runat="server" Font-Names="Calibri" Font-Size="Small" 
                                    Text="Vehicle No"></asp:Label>
                            </td>
							<td colspan="2">
                                <asp:textbox id="TxtVehNo" runat="server" Height="20px" 
                                    Width="340px" Font-Size="Small" Font-Names="Calibri"></asp:textbox></td>
							<td colspan="6">&nbsp;</td>
							<td colspan="6">&nbsp;</td>
							<td class="style41"></td>
						</tr>
						<tr>
							<td class="style43">
                                <asp:label id="Label2" runat="server" Height="24px" Width="129px" Font-Size="Small" Font-Names="Calibri">Insurance 
                                Type</asp:label></td>
							<td class="style43" colspan="2">
                                <asp:textbox id="TxtInsTyp" runat="server" Height="20px" 
                                    Width="340px" Font-Size="X-Small" Font-Names="Calibri"></asp:textbox></td>
							<td class="style43" colspan="2">
                                <asp:Label ID="Label12" runat="server" Font-Names="Calibri" Font-Size="Small" 
                                    Text="Source"></asp:Label>
                            </td>
							<td class="style43" colspan="2">
                                <asp:textbox id="TxtSource" runat="server" Height="20px" 
                                    Width="340px" Font-Size="Small" Font-Names="Calibri"></asp:textbox></td>
							<td class="style43" colspan="6"></td>
							<td class="style43" colspan="6"></td>
							<td class="style43"></td>
						</tr>
						<tr>
							<td class="style41"><asp:label id="Label5" runat="server" Height="24px" 
                                    Width="147px" Font-Size="Small" Font-Names="Calibri">Renew Date(dd/mm/yyyy)</asp:label></td>
							<td class="style41" colspan="18">
								<asp:textbox id="TxtRenDt" runat="server" Height="20px" Width="88px"></asp:textbox>
                                <asp:ImageButton ID="Save11" runat="server" ImageUrl="Menu\save11.png" 
                                    Width="29px" />
                            </td>
							<td class="style41">
								</td>
							<td class="style42"></td>
								
						</tr>
						<tr>
							<td class="style38" rowspan="2">
                                <asp:Image ID="Image2" runat="server" Height="404px" 
                                    ImageUrl="~/Menu/EmpMaster4.jpg" Width="133px" />
                            </td>
							<td class="style39" colspan="18">&nbsp;
								<div>
									<div id="Layer1" style="OVERFLOW: scroll; WIDTH: 855px; HEIGHT: 252px">
    <asp:GridView ID="MyDataGrid" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" 
                                            BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" 
                                            Font-Names="Calibri" Font-Size="Small" Width="835px" 
                                            AutoGenerateColumns="False"  >
        <RowStyle BackColor="#F7F7DE" />
        
       
        
        
        <Columns>
                  <asp:BoundField DataField="id" HeaderText="id" visible="false"/>
                 
                  <asp:TemplateField HeaderText="Delete">
                  <ItemTemplate>
                  <asp:ImageButton ID="btnDelete" runat="server" ImageUrl="menu\delete.jpg" CommandName="Delete" CommandArgument='<%# Eval("id") %>' />
                  </ItemTemplate>
                  </asp:TemplateField>
                   
         
                
            <asp:Boundfield DataField="Id" HeaderText="Customer #">
							<HeaderStyle Width="1.0in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
			</asp:Boundfield>
						<asp:BoundField DataField="ConEntDt" HeaderText="SubMit Date">
							<HeaderStyle Width="1.0in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
          
						<asp:BoundField DataField="ConNam" HeaderText="Name">
							<HeaderStyle Width="2.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
						
						<asp:BoundField DataField="ConAdd" HeaderText="Address">
							<HeaderStyle Width="2.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
						<asp:BoundField DataField="ConEmail" HeaderText="E_Mail">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
						<asp:BoundField DataField="Contact" HeaderText="Contact Nos">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
						<asp:BoundField DataField="ConInsTyp" HeaderText="Insurance Type">
							<HeaderStyle Width="1.0in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
						<asp:BoundField DataField="ConRenDt" HeaderText="Renew Date">
							<HeaderStyle Width="1.0in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
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
							<td class="style40" rowspan="6">
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
							</td>
						</tr>
						<tr>
							<td class="style39" colspan="18">&nbsp;</td>
						</tr>
						<tr>
							<td class="style38">
                                &nbsp;</td>
							<td class="style39" colspan="18">&nbsp;</td>
						</tr>
						<tr>
							<td class="style38">
                                &nbsp;</td>
							<td class="style39" colspan="18">&nbsp;</td>
						</tr>
						<tr>
							<td class="style38">
                                &nbsp;</td>
							<td class="style39" colspan="18">&nbsp;</td>
						</tr>
						<tr>
							<td class="style38">
                                &nbsp;</td>
							<td class="style39" colspan="18">&nbsp;</td>
						</tr>
					</table>
				</div>
      <div>


  </div>
    
    
    </form>
</body>
</html>
