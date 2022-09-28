<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/Admin.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="VaccineMangmentApp.AdminPanel.Home" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
                <form id="form1" runat="server" class="frmalg">
                    <div class="row">
                        <div class="col-6">
                            <h2>Vaccine Booking  Details</h2>
                            <asp:GridView ID="GridView1" runat="server" AllowSorting="True"  CellPadding="4" DataSourceID="sqlSrc1" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataKeyNames="ID">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                                    <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                                    <asp:BoundField DataField="VaccineName" HeaderText="VaccineName" SortExpression="VaccineName" />
                                    <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                                    <asp:BoundField DataField="CenterName" HeaderText="CenterName" SortExpression="CenterName" />
                                    <asp:BoundField DataField="Startus" HeaderText="Startus" SortExpression="Startus" />
                                    <asp:BoundField DataField="ModifiedDate" HeaderText="ModifiedDate" SortExpression="ModifiedDate" />
                                    <asp:BoundField DataField="BookedDate" HeaderText="BookedDate" SortExpression="BookedDate" />
                                    <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID" />
                                    <asp:BoundField DataField="CenterID" HeaderText="CenterID" SortExpression="CenterID" />
                                    <asp:BoundField DataField="VaccineID" HeaderText="VaccineID" SortExpression="VaccineID" />
                                </Columns>
                                <EditRowStyle BackColor="#7C6F57" />
                                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#E3EAEB" />
                                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                                <SortedAscendingHeaderStyle BackColor="#246B61" />
                                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                                <SortedDescendingHeaderStyle BackColor="#15524A" />
                            </asp:GridView>
                         </div>
                    </div>
                </form>
        </div>
        <asp:SqlDataSource ID="sqlSrc1" runat="server" ConnectionString="<%$ ConnectionStrings:VaccineMasterConnectionString %>" SelectCommand="SELECT [ID], [VaccineName], [UserName], [City], [CenterName], [Startus], [ModifiedDate], [BookedDate], [UserID], [CenterID], [VaccineID] FROM [VaccineBookingMaster]" DeleteCommand="DELETE FROM [VaccineBookingMaster] WHERE [ID] = @ID" InsertCommand="INSERT INTO [VaccineBookingMaster] ([VaccineName], [UserName], [City], [CenterName], [Startus], [ModifiedDate], [BookedDate], [UserID], [CenterID], [VaccineID]) VALUES (@VaccineName, @UserName, @City, @CenterName, @Startus, @ModifiedDate, @BookedDate, @UserID, @CenterID, @VaccineID)" UpdateCommand="UPDATE [VaccineBookingMaster] SET [VaccineName] = @VaccineName, [UserName] = @UserName, [City] = @City, [CenterName] = @CenterName, [Startus] = @Startus, [ModifiedDate] = @ModifiedDate, [BookedDate] = @BookedDate, [UserID] = @UserID, [CenterID] = @CenterID, [VaccineID] = @VaccineID WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="VaccineName" Type="String" />
                <asp:Parameter Name="UserName" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="CenterName" Type="String" />
                <asp:Parameter Name="Startus" Type="String" />
                <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                <asp:Parameter Name="BookedDate" Type="DateTime" />
                <asp:Parameter Name="UserID" Type="Int32" />
                <asp:Parameter Name="CenterID" Type="Int32" />
                <asp:Parameter Name="VaccineID" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="VaccineName" Type="String" />
                <asp:Parameter Name="UserName" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="CenterName" Type="String" />
                <asp:Parameter Name="Startus" Type="String" />
                <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                <asp:Parameter Name="BookedDate" Type="DateTime" />
                <asp:Parameter Name="UserID" Type="Int32" />
                <asp:Parameter Name="CenterID" Type="Int32" />
                <asp:Parameter Name="VaccineID" Type="Int32" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
</asp:Content>