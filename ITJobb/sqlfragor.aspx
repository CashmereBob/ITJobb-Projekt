<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sqlfragor.aspx.cs" Inherits="ITJobb.sqlfragor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        
            Yrkestitlar:<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="JobName" HeaderText="JobName" SortExpression="JobName" />
                    <asp:BoundField DataField="Job Amount" HeaderText="Job Amount" ReadOnly="True" SortExpression="Job Amount" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spYrkestitlar" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            <br />
            Orter:<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="OrtNamn" HeaderText="OrtNamn" SortExpression="OrtNamn" />
                    <asp:BoundField DataField="total jobb" HeaderText="total jobb" ReadOnly="True" SortExpression="total jobb" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spOrter" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            <br />
            Målsidor:<asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="Jobbsida" HeaderText="Jobbsida" SortExpression="Jobbsida" />
                    <asp:BoundField DataField="Antal Jobb" HeaderText="Antal Jobb" ReadOnly="True" SortExpression="Antal Jobb" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spMålsida" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            <br />
            Rekryterare:<asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource4" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="Antal Jobb" HeaderText="Antal Jobb" ReadOnly="True" SortExpression="Antal Jobb" />
                    <asp:BoundField DataField="ForetagsNamn" HeaderText="ForetagsNamn" SortExpression="ForetagsNamn" />
                    <asp:BoundField DataField="AnnonsURL" HeaderText="AnnonsURL" SortExpression="AnnonsURL" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spAntalJobbPerArbetsgivare" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            <br />
            Löner:<asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource5" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="Publicerades" HeaderText="Publicerades" SortExpression="Publicerades" />
                    <asp:BoundField DataField="Tjänst" HeaderText="Tjänst" SortExpression="Tjänst" />
                    <asp:BoundField DataField="Genomsnittslön" HeaderText="Genomsnittslön" SortExpression="Genomsnittslön" />
                    <asp:BoundField DataField="Ort" HeaderText="Ort" SortExpression="Ort" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spSaleryInquiery" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            <br />
            Frisök:<br />
            <asp:TextBox ID="TextBox1" runat="server">Webb</asp:TextBox>
            <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource6" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="Publicerades" HeaderText="Publicerades" SortExpression="Publicerades" />
                    <asp:BoundField DataField="Jobb Titel" HeaderText="Jobb Titel" SortExpression="Jobb Titel" />
                    <asp:BoundField DataField="Ort" HeaderText="Ort" SortExpression="Ort" />
                    <asp:BoundField DataField="Rekryterare" HeaderText="Rekryterare" SortExpression="Rekryterare" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spFriSok" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="Webb" Name="sok" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            Målsidor:<br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource7" DataTextField="MalsidaNamn" DataValueField="MalsidaNamn">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="SELECT * FROM [Malsidas]"></asp:SqlDataSource>
            <asp:GridView ID="GridView7" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource8" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="Site Name" HeaderText="Site Name" SortExpression="Site Name" />
                    <asp:BoundField DataField="Work Title" HeaderText="Work Title" SortExpression="Work Title" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource8" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spMalsidor" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" DefaultValue="" Name="malsida" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            Ort:<br />
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource9" DataTextField="OrtNamn" DataValueField="OrtNamn">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource9" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="SELECT * FROM [Orts]"></asp:SqlDataSource>
            <asp:GridView ID="GridView8" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource10" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="ort" HeaderText="ort" SortExpression="ort" />
                    <asp:BoundField DataField="yrke" HeaderText="yrke" SortExpression="yrke" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource10" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spSokOrt" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList2" Name="ort" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            Rekryterare:<br />
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource11" DataTextField="ForetagsNamn" DataValueField="ForetagsNamn">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource11" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="SELECT * FROM [Rekryterares]"></asp:SqlDataSource>
            <asp:GridView ID="GridView9" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource12" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="Antal Jobb" HeaderText="Antal Jobb" ReadOnly="True" SortExpression="Antal Jobb" />
                    <asp:BoundField DataField="ForetagsNamn" HeaderText="ForetagsNamn" SortExpression="ForetagsNamn" />
                    <asp:BoundField DataField="AnnonsURL" HeaderText="AnnonsURL" SortExpression="AnnonsURL" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource12" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spAntalJobbPerArbetsgivare" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            <br />
            Yrken:<br />
            <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource13" DataTextField="YrkesNamn" DataValueField="YrkesNamn">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource13" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="SELECT * FROM [YrkesTitels]"></asp:SqlDataSource>
            <asp:GridView ID="GridView10" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource14" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="AnnonsURL" HeaderText="AnnonsURL" SortExpression="AnnonsURL" />
                    <asp:BoundField DataField="YrkesNamn" HeaderText="YrkesNamn" SortExpression="YrkesNamn" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource14" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spSoekYrke" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList4" Name="Yrkesnamn" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        <br />
        
    
    </div>
    </form>
</body>
</html>
