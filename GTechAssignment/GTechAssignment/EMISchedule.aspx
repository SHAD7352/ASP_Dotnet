<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="EMISchedule.aspx.cs" Inherits="GTechAssignment.EMISchedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content" class="my-2 mx-2">
        <div class="row">
            <div class="col-12">
                <div class="card">
                    <div class="card-header">
                        <h2 class="my-2">EMI Schedule</h2>
                    </div>
                    <div class="container">
                        <div class="row">
                            <div class="col-12 d-flex">
                                <div class="col-5 mx-2">
                                    <div class="card-body">
                                        <label runat="server" id="lblMsg" class="text-success text-bold text-center"></label>
                                        <div class="mb-2">
                                            <label class="form-label">Select Plan Name</label>
                                            <asp:DropDownList runat="server" ID="ddlPlanName" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlPlanName_SelectedIndexChanged"></asp:DropDownList>
                                        </div>
                                        <div class="mb-2">
                                            <label for="txtTenure" class="form-label">Tenure (Months)</label>
                                            <input type="number" class="form-control" id="txtTenure" runat="server" required="required" aria-describedby="numberHelp" min="0" step="1" readonly="readonly">
                                        </div>
                                        <div class="mb-2">
                                            <label class="form-label" for="txtROI">ROI (%)</label>
                                            <input type="number" class="form-control" id="txtROI" runat="server" required="required" aria-describedby="decimalHelp" min="0" step="0.01" readonly="readonly">
                                        </div>
                                        <div class="mb-2">
                                            <label for="txtLoanAmount" class="form-label">Enter Loan Amount</label>
                                            <input type="text" class="form-control" id="txtLoanAmount" runat="server" required="required">
                                        </div>
                                        <div class="mb-2">
                                            <label for="txtLoanDate" class="form-label">Loan Date</label>
                                            <input type="date" class="form-control" id="txtLoanDate" runat="server" required="required">
                                            <div class="d-flex justify-content-end">
                                                <button runat="server" id="btnCalculateEmi" onserverclick="btnCalculateEmi_ServerClick" class="btn btn-sm btn-primary my-2">
                                                    Calculate EMI
                                                </button>
                                            </div>

                                        </div>
                                        <div class="mb-2">
                                            <label for="txtEmiAmount" class="form-label">EMI Amount</label>
                                            <input type="text" class="form-control" id="txtEmiAmount" runat="server" aria-describedby="decimalHelp" min="0" step="0.01" readonly="readonly">
                                        </div>
                                        <div class="d-flex justify-content-end my-2">
                                            <button type="submit" class="btn btn-success" runat="server" id="btnSave" onserverclick="btnSave_ServerClick">Save</button>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-7">
                                    <div class="table-responsive">
                                        <asp:GridView ID="gdvEmiSchedule" runat="server" CssClass="table table-striped table-hover custom-grid" AutoGenerateColumns="false">
                                            <Columns>
                                                <asp:TemplateField HeaderText="EMI No">
                                                    <HeaderStyle BackColor="Black" ForeColor="White" />
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblEMINo" runat="server" Text='<%#Eval("EmiNo")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Due Date">
                                                    <HeaderStyle BackColor="Black" ForeColor="White" />
                                                    <ItemTemplate>
                                                        <asp:Label ID="DueDate" runat="server" Text='<%#Eval("DueDate")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="EMI Amount">
                                                    <HeaderStyle BackColor="Black" ForeColor="White" />
                                                    <ItemTemplate>
                                                        <asp:Label ID="EMIAmount" runat="server" Text='<%#Eval("EMIAmount")%>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
