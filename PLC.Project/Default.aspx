<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PLC.Project._Default" %>




<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<%--        <asp:ScriptManager ID="SC1" runat="server"></asp:ScriptManager>--%>
<asp:UpdatePanel id="UpdatePanel1" runat="server">
      <ContentTemplate>



<style type="text/css">
 table.center {
    margin-left: auto;
    margin-right: auto;
    width: 500px;
}
 html, body
{
    height: 100%;
}
 tr {
    height: 1px;
}
td {
    /*border: 1px solid #000;*/
    height: 100%;
}
label { 
    display: block; 
    border: 1px solid #f00;
    min-height: 100%; /* for the latest browsers which support min-height */
    height: auto !important; /* for newer IE versions */
    height: 100%; /* the only height-related attribute that IE6 does not ignore  */
}
    </style>

          <br />
          <br />
          <br />
          <br />
          <br />
          <br />
          <br />
          <br />




          <table border="0"  class="center" style="width:100%;height:100%;" >
                  <tr>
           <td><span class="label label-default" runat="server" id="Span18" style="display: none;">xxxx</span></td>
              <td width="6%"><span class="label label-default" runat="server" id="Span19" style="display: none;">.</span></td>
              <td width="6%"><span class="label label-default" runat="server" id="Span20" style="display: none;">.</span></td>
              <td width="6%"><span class="label label-default" runat="server" id="Span21" style="display: none;">.</span></td>
              <td width="6%"><span class="label label-default" runat="server" id="Span22" style="display: none;">.</span></td>
              <td width="6%"><span class="label label-default" runat="server" id="Span23" style="display: none;">.</span></td>  
              <td width="6%"><span class="label label-default" runat="server" id="Span24" style="display: none;">.</span></td>
              <td width="6%"><span class="label label-default" runat="server" id="Span25" style="display: none;">.</span></td>
              <td width="6%"><span class="label label-default" runat="server" id="Span26" style="display: none;">.</span></td>
              <td width="6%"><span class="label label-default" runat="server" id="Span27" style="display: none;">.</span></td>
              <td width="6%"><span class="label label-default" runat="server" id="Span28" style="display: none;">.</span></td>
              <td width="6%"><span class="label label-default" runat="server" id="Span29" style="display: none;">.</span></td>
              <td width="6%"><span class="label label-default" runat="server" id="Span30" style="display: none;">.</span></td>  
              <td width="6%"><span class="label label-default" runat="server" id="Span31" style="display: none;">.</span></td>
              <td width="6%"><span class="label label-default" runat="server" id="Span32" style="display: none;">.</span></td>
        <td colspan="2" width="12%"><h1><span class="label label-success" runat="server" id="SHOWCOUNT" style="display: block;">0/30</span></h1></td>
    </tr>
          </table>
          <br />
          <br />


<table border="1"  class="center" style="width:100%;height:100%;" >





       <tr>
              <td><span class="label label-default" runat="server" id="M1" style="display: block;">.</span></td>
              <td><span class="label label-default" runat="server" id="M2" style="display: block;">.</span></td>
              <td><span class="label label-default" runat="server" id="M3" style="display: block;">.</span></td>
              <td><span class="label label-default" runat="server" id="M4" style="display: block;">.</span></td>
              <td><span class="label label-default" runat="server" id="M5" style="display: block;">.</span></td>
              <td><span class="label label-default" runat="server" id="M6" style="display: block;">.</span></td>  
              <td><span class="label label-default" runat="server" id="M7" style="display: block;">.</span></td>
              <td><span class="label label-default" runat="server" id="M8" style="display: block;">.</span></td>
              <td><span class="label label-default" runat="server" id="M9" style="display: block;">.</span></td>
              <td><span class="label label-default" runat="server" id="M10" style="display: block;">.</span></td>
              <td><span class="label label-default" runat="server" id="M11" style="display: block;">.</span></td>
              <td><span class="label label-default" runat="server" id="M12" style="display: block;">.</span></td>
              <td><span class="label label-default" runat="server" id="M13" style="display: block;">.</span></td>  
              <td><span class="label label-default" runat="server" id="M14" style="display: block;">.</span></td>
              <td><span class="label label-default" runat="server" id="M15" style="display: block;">.</span></td>
              <td><span class="label label-default" runat="server" id="M16" style="display: block;">.</span></td>  
              <td><span class="label label-default" runat="server" id="M17" style="display: block;">.</span></td>
    </tr>

    <tr>
        <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L1">L1</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L2" >L2</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L3">L3</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L4">L4</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L5">L5</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L6">L6</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L7">L7</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L8">L8</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L9">L9</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L10">L10</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L11">L11</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L12">L12</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L13">L13</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L14">L14</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L15">L5</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L16">L6</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="L17">L17</button></td>

    </tr>
    <tr>
        <td>&nbsp; &nbsp;
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            &nbsp; &nbsp; &nbsp;</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
          <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
           <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
    </tr>

    
    <tr>
        <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S1">S1</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S2">S2</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S3">S3</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S4">S4</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S5">S5</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S6">S6</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S7">S7</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S8">S8</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S9">S9</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S10">S10</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S11">S11</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S12">S12</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S13">S13</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S14">S14</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S15">S15</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S16">S16</button></td>
           <td> <button type="button" class="btn btn-danger center-block" runat="server" id="S17">S17</button></td>

    </tr>
 
       <tr>
        <td>&nbsp; &nbsp;
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            &nbsp; &nbsp; &nbsp;</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
          <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
           <td>&nbsp</td>
         <td>&nbsp</td>
         <td>&nbsp</td>
    </tr>

         <tr>
        <td><span class="label label-default" runat="server" id="Span1" style="display: block;">0</span></td>
              <td><span class="label label-default" runat="server" id="Span2" style="display: block;">0</span></td>
              <td><span class="label label-default" runat="server" id="Span3" style="display: block;">0</span></td>
              <td><span class="label label-default" runat="server" id="Span4" style="display: block;">0</span></td>
              <td><span class="label label-default" runat="server" id="Span5" style="display: block;">0</span></td>
              <td><span class="label label-default" runat="server" id="Span6" style="display: block;">0</span></td>  
              <td><span class="label label-default" runat="server" id="Span7" style="display: block;">0</span></td>
              <td><span class="label label-default" runat="server" id="Span8" style="display: block;">0</span></td>
              <td><span class="label label-default" runat="server" id="Span9" style="display: block;">0</span></td>
              <td><span class="label label-default" runat="server" id="Span10" style="display: block;">0</span></td>
              <td><span class="label label-default" runat="server" id="Span11" style="display: block;">0</span></td>
              <td><span class="label label-default" runat="server" id="Span12" style="display: block;">0</span></td>
              <td><span class="label label-default" runat="server" id="Span13" style="display: block;">0</span></td>  
              <td><span class="label label-default" runat="server" id="Span14" style="display: block;">0</span></td>
              <td><span class="label label-default" runat="server" id="Span15" style="display: block;">0</span></td>
              <td><span class="label label-default" runat="server" id="Span16" style="display: block;">0</span></td>  
              <td><span class="label label-default" runat="server" id="Span17" style="display: block;">0</span></td>
    </tr>


</table>
    <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
    </asp:Timer>
    </ContentTemplate>


    </asp:UpdatePanel>

</asp:Content>

