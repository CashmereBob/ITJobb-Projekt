<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sqlfragor.aspx.cs" Inherits="ITJobb.sqlfragor" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <!-- Bootstrap core CSS -->
    <link href="Content/bootstrap.css" rel="stylesheet" />

    <!-- Custom styles for this template -->
    <link href="Site.css" rel="stylesheet" />

    <!-- Just for debugging purposes. Don't actually copy these 2 lines! -->
    <!--[if lt IE 9]><script src="../../assets/js/ie8-responsive-file-warning.js"></script><![endif]-->
    <script src="Scripts/ie-emulation-modes-warning.js"></script>


</head>
<body>
    <div class="row">
      <div class="container">    

    <form id="form1" runat="server">
    <div>
            <hr>
             <p class="lead">Lista samtliga yrkestitlar och mängden jobb som finns representerade för vardera yrkestitel:</p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CssClass= "table table-striped table-bordered table-condensed">
                <Columns>
                    <asp:BoundField DataField="Titel" HeaderText="Titel" SortExpression="Titel" />
                    <asp:BoundField DataField="Antal" HeaderText="Antal" ReadOnly="True" SortExpression="Antal" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spYrkestitlar" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            <hr>
        
            <p class="lead">Lista samtliga orter och mängden jobb som finns representerade för vardera ort:</p>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" CssClass= "table table-striped table-bordered table-condensed">
                <Columns>
                    <asp:BoundField DataField="Ort" HeaderText="Ort" SortExpression="Ort" />
                    <asp:BoundField DataField="Antal" HeaderText="Antal" ReadOnly="True" SortExpression="Antal" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spOrter" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            <hr>
             <p class="lead">Lista samtliga målsidor och mängden jobb som finns representerade för vardera målsida:</p>
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" CssClass= "table table-striped table-bordered table-condensed">
                <Columns>
                    <asp:BoundField DataField="Ursprungssida" HeaderText="Ursprungssida" SortExpression="Ursprungssida" />
                    <asp:BoundField DataField="Antal" HeaderText="Antal" ReadOnly="True" SortExpression="Antal" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spMålsida" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            <hr>
             <p class="lead">Lista samtliga rekryterare och mängden jobb som finns representerade för vardera rekryterare:</p>
        <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource4" CssClass= "table table-striped table-bordered table-condensed">
                <Columns>
                    <asp:BoundField DataField="Antal" HeaderText="Antal" ReadOnly="True" SortExpression="Antal" />
                    <asp:BoundField DataField="Företag" HeaderText="Företag" SortExpression="Företag" />
                    <asp:BoundField DataField="Företags URL" HeaderText="Företags URL" SortExpression="Företags URL" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spAntalJobbPerArbetsgivare" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            <hr>
             <p class="lead">Lista samtliga annonser efter medellön:</p>
        <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource5" CssClass= "table table-striped table-bordered table-condensed">
                <Columns>
                    <asp:BoundField DataField="Publicerades" HeaderText="Publicerades" SortExpression="Publicerades" />
                    <asp:BoundField DataField="Titel" HeaderText="Titel" SortExpression="Titel" />
                    <asp:BoundField DataField="Genomsnittslön" HeaderText="Genomsnittslön" SortExpression="Genomsnittslön" />
                    <asp:BoundField DataField="Ort" HeaderText="Ort" SortExpression="Ort" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spSaleryInquiery" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            <hr>
             <p class="lead">Frisök på företagsannonser:</p>
        
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control">Webb</asp:TextBox>
        <br />
            <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource6" CssClass= "table table-striped table-bordered table-condensed">
                <Columns>
                    <asp:BoundField DataField="Publicerades" HeaderText="Publicerades" SortExpression="Publicerades" />
                    <asp:BoundField DataField="Titel" HeaderText="Titel" SortExpression="Titel" />
                    <asp:BoundField DataField="Ort" HeaderText="Ort" SortExpression="Ort" />
                    <asp:BoundField DataField="Rekryterare" HeaderText="Rekryterare" SortExpression="Rekryterare" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spFriSok" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="Webb" Name="sok" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <hr>
             <p class="lead">Visa annonser för sökt målsida:</p>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource7" DataTextField="MalsidaNamn" DataValueField="MalsidaNamn" CssClass="form-control">
            </asp:DropDownList>
        <br />
            <asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="SELECT * FROM [Malsidas]"></asp:SqlDataSource>
            <asp:GridView ID="GridView7" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource8" CssClass= "table table-striped table-bordered table-condensed">
                <Columns>
                    <asp:BoundField DataField="Ursprungssida" HeaderText="Ursprungssida" SortExpression="Ursprungssida" />
                    <asp:BoundField DataField="Titel" HeaderText="Titel" SortExpression="Titel" />
                    <asp:BoundField DataField="Annons URL" HeaderText="Annons URL" SortExpression="Annons URL" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource8" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spMalsidor" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" DefaultValue="" Name="malsida" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <hr>
             <p class="lead">Visa annonser för sökt ort:</p>
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource9" DataTextField="OrtNamn" DataValueField="OrtNamn" CssClass="form-control">
            </asp:DropDownList>
        <br />
            <asp:SqlDataSource ID="SqlDataSource9" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="SELECT * FROM [Orts]"></asp:SqlDataSource>
            <asp:GridView ID="GridView8" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource10" CssClass= "table table-striped table-bordered table-condensed">
                <Columns>
                    <asp:BoundField DataField="Ort" HeaderText="Ort" SortExpression="Ort" />
                    <asp:BoundField DataField="Titel" HeaderText="Titel" SortExpression="Titel" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource10" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spSokOrt" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList2" Name="ort" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <hr>
             <p class="lead">Visa annonser för sökt rekryterare:</p>
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource11" DataTextField="ForetagsNamn" DataValueField="ForetagsNamn" CssClass="form-control">
            </asp:DropDownList>
        <br />
            <asp:SqlDataSource ID="SqlDataSource11" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="SELECT * FROM [Rekryterares]"></asp:SqlDataSource>
            <asp:GridView ID="GridView9" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource12" CssClass= "table table-striped table-bordered table-condensed">
                <Columns>
                    <asp:BoundField DataField="Publicerades" HeaderText="Publicerades" SortExpression="Publicerades" />
                    <asp:BoundField DataField="Titel" HeaderText="Titel" SortExpression="Titel" />
                    <asp:BoundField DataField="Ort" HeaderText="Ort" SortExpression="Ort" />
                    <asp:BoundField DataField="Rekryterare" HeaderText="Rekryterare" SortExpression="Rekryterare" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource12" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spSokForetagsAnnonser" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList3" Name="Rekryterare" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <hr>
             <p class="lead">Visa annonser för sökt yrke:</p>
            <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource13" DataTextField="YrkesNamn" DataValueField="YrkesNamn" CssClass="form-control">
            </asp:DropDownList>
        <br />
            <asp:SqlDataSource ID="SqlDataSource13" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="SELECT * FROM [YrkesTitels]"></asp:SqlDataSource>
            <asp:GridView ID="GridView10" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource14" CssClass= "table table-striped table-bordered table-condensed">
                <Columns>
                    <asp:BoundField DataField="Titel" HeaderText="Titel" SortExpression="Titel" />
                    <asp:BoundField DataField="Annons URL" HeaderText="Annons URL" SortExpression="Annons URL" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource14" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spSoekYrke" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList4" Name="Yrkesnamn" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <hr>
             <p class="lead">Välj inloggad användare:</p>
            <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource15" DataTextField="AnvandareId" DataValueField="AnvandareId" CssClass="form-control">
            </asp:DropDownList>
        <br />
            <asp:SqlDataSource ID="SqlDataSource15" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="SELECT * FROM [Anvandares]"></asp:SqlDataSource> 
             <p class="lead">Lista jobb som användare sökt:</p>
        <asp:GridView ID="GridView11" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource16" CssClass= "table table-striped table-bordered table-condensed">
                <Columns>
                    <asp:BoundField DataField="Titel" HeaderText="Titel" SortExpression="Titel" />
                    <asp:BoundField DataField="Ort" HeaderText="Ort" SortExpression="Ort" />
                    <asp:BoundField DataField="Medellön" HeaderText="Medellön" SortExpression="Medellön" />
                    <asp:BoundField DataField="Rekryterare" HeaderText="Rekryterare" SortExpression="Rekryterare" />
                    <asp:BoundField DataField="Kontakt Adress" HeaderText="Kontakt Adress" SortExpression="Kontakt Adress" />
                    <asp:BoundField DataField="Publicerades" HeaderText="Publicerades" SortExpression="Publicerades" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource16" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spSokSoktaJobb" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList5" Name="ID" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            
        
            <br />
             <p class="lead">Visa CV URL:</p>
        <asp:GridView ID="GridView12" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource17" CssClass= "table table-striped table-bordered table-condensed">
                <Columns>
                    <asp:BoundField DataField="Namn" HeaderText="Namn" ReadOnly="True" SortExpression="Namn" />
                    <asp:BoundField DataField="CV URL" HeaderText="CV URL" SortExpression="CV URL" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource17" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spListaCV" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList5" DefaultValue="2" Name="AnvändarID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
             <p class="lead">Visa Personligtbrev URL:</p>
        <asp:GridView ID="GridView13" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource18" CssClass= "table table-striped table-bordered table-condensed">
                <Columns>
                    <asp:BoundField DataField="Namn" HeaderText="Namn" ReadOnly="True" SortExpression="Namn" />
                    <asp:BoundField DataField="Personligtbrev URL" HeaderText="Personligtbrev URL" SortExpression="Personligtbrev URL" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource18" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spListaPB" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList5" Name="ID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <p class="lead">Visa inloggad användares personannonser:</p>
                <asp:GridView ID="GridView15" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource20" CssClass= "table table-striped table-bordered table-condensed">
                <Columns>
                    <asp:BoundField DataField="Namn" HeaderText="Namn" ReadOnly="True" SortExpression="Namn" />
                    <asp:BoundField DataField="Publiceringsdatum" HeaderText="Publiceringsdatum" SortExpression="Publiceringsdatum" />
                    <asp:BoundField DataField="Titel" HeaderText="Titel" SortExpression="Titel" />
                    <asp:BoundField DataField="Beskrivning" HeaderText="Beskrivning" SortExpression="Beskrivning" />
                </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource20" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" SelectCommand="spSoekAnnons" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList5" Name="ID" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            
        
            <br />
             <p class="lead">Visa företagsannonser som matchar användarens personannons:</p>
        <asp:GridView ID="GridView14" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource19" CssClass= "table table-striped table-bordered table-condensed">
                <Columns>
                    <asp:BoundField DataField="Publicerades" HeaderText="Publicerades" SortExpression="Publicerades" />
                    <asp:BoundField DataField="Titel" HeaderText="Titel" SortExpression="Titel" />
                    <asp:BoundField DataField="Medellön" HeaderText="Medellön" SortExpression="Medellön" />
                    <asp:BoundField DataField="Ort" HeaderText="Ort" SortExpression="Ort" />
                    <asp:BoundField DataField="Rekryterare" HeaderText="Rekryterare" SortExpression="Rekryterare" />
                    <asp:BoundField DataField="Tag Träff" HeaderText="Tag Träff" SortExpression="Tag Träff" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource19" runat="server" ConnectionString="<%$ ConnectionStrings:ITJobbDBConnectionString %>" InsertCommand="spTagMatch" InsertCommandType="StoredProcedure" SelectCommand="spTagMatch" SelectCommandType="StoredProcedure">
                <InsertParameters>
                    <asp:Parameter Name="ID" Type="String" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList5" DefaultValue="2" Name="ID" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        <br />
        
    
    </div>
    </form>

    </div>
    </div>

    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="Scripts/jquery.min.js"></script>
    <script>window.jQuery || document.write('<script src="Scripts/jquery.min.js"><\/script>')</script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
