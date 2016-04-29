<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ITJobb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" Width="199px">2</asp:TextBox>
        <br />
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Horizontal">
            <Columns>
                <asp:BoundField DataField="Publicerades" HeaderText="Publicerades" SortExpression="Publicerades" />
                <asp:BoundField DataField="YrkesNamn" HeaderText="YrkesNamn" SortExpression="YrkesNamn" />
                <asp:BoundField DataField="Medellön" HeaderText="Medellön" SortExpression="Medellön" />
                <asp:BoundField DataField="Ort" HeaderText="Ort" SortExpression="Ort" />
                <asp:BoundField DataField="Rekryterare" HeaderText="Rekryterare" SortExpression="Rekryterare" />
                <asp:BoundField DataField="Tag Träff" HeaderText="Tag Träff" SortExpression="Tag Träff" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spTagMatch" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" DefaultValue="1" Name="ID" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
