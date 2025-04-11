<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="PlanMaster.aspx.cs" Inherits="GTechAssignment.PlanMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content" class="my-2 mx-2">
        <div class="row">
            <div class="col-12">
                <div class="card">
                    <div class="card-header">
                        <h2 class="my-2">Create Scheme</h2>
                    </div>
                    <div class="container">
                        <div class="card-body col-6">
                            <label runat="server" id="lblMsg" class="text-success text-bold text-center"></label>
                            <div class="mb-2">
                                <label for="txtName" class="form-label">Plan Name</label>
                                <input type="text" class="form-control" id="txtName" runat="server" required="required">
                            </div>
                            <div class="mb-2">
                                <label for="txtTenure" class="form-label">Tenure (Months)</label>
                                <input type="number" class="form-control" id="txtTenure" runat="server" required="required" aria-describedby="numberHelp" min="0" step="1">
                            </div>
                            <div class="mb-2">
                                <label class="form-label" for="txtROI">ROI (%)</label>
                                <input type="number" class="form-control" id="txtROI" runat="server" required="required" aria-describedby="decimalHelp" min="0" step="0.01">
                            </div>
                            <div class="d-flex justify-content-end my-2">
                                <button type="submit" class="btn btn-success" runat="server" id="btnSave" onserverclick="btnSave_ServerClick">Save</button>
                            </div>
                        </div>
                    </div>
                </div>
                ~
            </div>
        </div>
    </div>
</asp:Content>
