<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DBest_Project._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>CPSC1517 - Course Project</h1>
        </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Form Description</h2>
            <p>Form descriptions go here</p>
        </div>
        <div class="col-md-12">
            <h2>Known Bugs</h2>
            <ul>
                <li>Class Diagrams not added</li>
            </ul>
        </div>
        <div class="col-md-12">
            <h2>Entity Relationship Diagram</h2>
            <asp:Image ID="ERD" runat="server" ImageUrl="~/Images/ERD.png" />
        </div>
        <div class="col-md-4">
            <h2>Class Diagrams</h2>
            <p>Class Diagrams go here</p>
        </div>
        <div class="col-md-12">
            <h2>Stored Procedures</h2>
            <ul>
                <li><b>Students_FindByPartialName</b> - Returns zero or more Students
                    whos first or last name includes the supplied string</li>
                <li><b>StudentAddressess_FindByStudent</b> - Returns zero or more 
                    StudentAddresses matching the supplied student id</li>
                <li><b>Addresses_FindByPartialStreetAddress</b> - Returns zero or 
                    more Addresses whos Number and Street contains the supplied 
                    values.</li>
                <li><b>StudentAddressess_FindByDateRange</b> - Returns zero or more 
                    StudentAddresses whos SinceDate is within a date range 
                    (date A and B)</li>
            </ul>
        </div>
    </div>
</asp:Content>
