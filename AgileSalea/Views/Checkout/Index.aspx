<%@ Page Title="" 
Language="C#" 
MasterPageFile="~/Views/Shared/Site.Master" 
CodeBehind="~/Views/Checkout/Index.aspx.cs"
Inherits="AgileSalea.Views.Checkout.Index" AutoEventWireup="True" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ApplicationContent" runat="server">

    <span style="text-align:center;"><h2> - Purchase Validation - </h2></span>
    <div id="InvoiceValidationForm">
       <form method="post" action="" name="InvoiceForm">
        <h2><span class="processBubble">&nbsp;  1&nbsp;  </span> &nbsp;- Billing Information -</h2>
        <div id="1">
          <table>
             <tr>
                 <td>* Name </td><td><input type="text" name="txtFName" /></td><td></td>
                 <td>* Province</td><td><asp:Literal ID="litPersProvinceDDL" runat="server"></asp:Literal></td>
             </tr>
             <tr>
                 <td></td><td id="eFname" class="error">This field is required</td><td>&nbsp;</td><td>&nbsp;</td>
             </tr>
             <tr>
                 <td>* Last Name</td><td><input type="text" name="txtLName" /></td>
                 <td></td>
                 <td>* City</td><td><input type="text" name="txtPersCity" /></td>
             </tr>
             <tr>
                 <td>&nbsp;</td><td id="eLname"  class="error">This field is required</td>
                 <td>&nbsp;</td><td>&nbsp;</td><td id="ePcity"  class="error">This field is required</td>
             </tr>
             <tr>
                 <td>* Email</td><td><input type="text" name="txtEmail" /></td><td></td>
                 <td>* Street</td><td><input type="text" name="txtPersSt" /></td>
             </tr>
             <tr>
                 <td>&nbsp;</td><td id="eEmail"  class="error">This field is required</td>
                 <td>&nbsp;</td><td>&nbsp;</td><td id="ePst"  class="error">This field is required</td>
             </tr>
             <tr>
                 <td>* Birth date</td><td><input type="text" name="txtBday" /></td><td></td>
                 <td>* Street Number</td><td><input type="text" name="txtPersStNo" /></td>
             </tr>
             <tr>
                 <td>&nbsp;</td><td id="eBday"  class="error">This field is required</td><td>&nbsp;</td><td>&nbsp;</td><td id="ePstNo"  class="error">This field is required</td>
             </tr>
             <tr>
                 <td>* Sex</td><td style="height: 27px"><input type="radio" name="rbMale" checked /> Male <input type="radio" name="rbFemale" /> Female </td>
                 <td>* Zip Code</td><td style="height: 27px"><input type="text" name="txtPersZC" /></td><td></td>
             </tr>
             <tr>
                 <td style="height: 27px">&nbsp;</td><td>&nbsp;</td><td style="height: 27px">&nbsp;</td><td id="ePzc"  class="error">This field is required</td>
                 <td></td>
             </tr>
             <tr>
                 <td></td><td></td><td>* Phone</td><td><input type="text" name="txtPersPh" /></td><td></td>
             </tr>
             <tr>
                 <td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td id="ePph"  class="error">This field is required</td><td></td>
             </tr>
             <tr>
                 <td colspan="5"><button type="button" onclick="nextValidationForm(1)"> Continue </button></td>
             </tr>
          </table>
        </div>
        <hr />
        <h2><span class="processBubble">&nbsp;  2&nbsp; </span>- Delivery Information -</h2>
        <div id="2" style="display:none">
          <table>
             <tr><td>* Who will receive the Package?</td><td><input type="text" name="txtReceiverName" /></td>
                 <td>
                 </td>
                 <td>
                 </td>
              </tr>
             <tr><td>&nbsp;</td><td id="eRname" class="error">This field is required</td>
                 <td>
                     &nbsp;</td>
                 <td>
                     &nbsp;</td>
              </tr>
             <tr><td>* Province</td><td><asp:Literal ID="litDelProv" runat="server"></asp:Literal></td><td>* DNI</td><td><input type="text" name="txtDelDNI"/></td></tr>
             <tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td id="eDeldni" class="error">This field is required</td></tr>
             <tr><td>* City</td><td><input type="text" name="txtDelCity" /></td><td >* Comments</td>
                 <td rowspan="10">
                 <input type="text" name="txtDelComm" value="n/a" style="width: 160px; height: 127px" /></td></tr>
             <tr><td>&nbsp;</td><td id="eDelcity" class="error">This field is required</td><td >&nbsp;</td></tr>
             <tr><td>* Street</td><td><input type="text" name="txtDelSt" /></td></tr>
             <tr><td>&nbsp;</td><td id="eDelst" class="error">This field is required</td></tr>
             <tr><td>* Number</td><td><input type="text" name="txtDelStNo"/></td></tr>
             <tr><td>&nbsp;</td><td id="eDelstno" class="error">This field is required</td></tr>
             <tr><td>* Zip Code</td><td><input type="text" name="txtDelZC"/></td></tr>
             <tr><td>&nbsp;</td><td id="eDelzc" class="error">This field is required</td></tr>
             <tr><td>* Phone</td><td><input type="text" name="txtDelPhone"/></td></tr>
             <tr><td>&nbsp;</td><td id="eDelph" class="error">This field is required</td></tr>
             <tr><td colspan="4"><button type="button" onclick="prevValidationForm(2)"> Back </button><button type="button" onclick="nextValidationForm(2);"> Continue </button></td></tr>
          </table>
        </div>
         <hr />
        <h2><span class="processBubble">  &nbsp;  3&nbsp;  </span> - Delivery Time -</h2>
        <div id="3" style="display:none">
           <table>
             <tr><td>* Select Delivery Day</td><td><asp:Literal ID="litShippingDay" runat="server"></asp:Literal></td><td class="okCheck"></td><td rowspan="5"><strong>Shipping cost is the same<br />for all locations.</strong></td></tr>
             <tr><td>* Select Time range</td><td><asp:Literal ID="litTimeRange" runat="server"></asp:Literal></td></tr>
             <tr><td>Shipping Cost: </td><td>$10.00</td></tr>
             <tr><td colspan="6"><button type="button" onclick="prevValidationForm(3)"> Back </button><button type="button" onclick="nextValidationForm(3);"> Continue </button></td></tr>
          </table>      
        </div>
        <hr /> 
        <h2><span class="processBubble">&nbsp;  4&nbsp;  </span> &nbsp;- Payment Information</h2>
        <div id="4" style="display:none">
           <table style="width: 425px">
             <tr><td>Credit Card Type</td><td><asp:Literal ID="litCardType" runat="server"></asp:Literal></td></tr>
             <tr><td>Bank</td><td><asp:Literal ID="litBank" runat="server"></asp:Literal></td></tr>
             <tr><td>Credit Card #</td><td><input type="text" name="txtCreditCard" /></td></tr>
             <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
             <tr><td colspan="2"><button type="button" onclick="prevValidationForm(4)"> Back </button><button type="button" onclick="finishPurchase()"> Finish Purchase </button></td></tr>
          </table> 
          
        </div>
        <hr />
      </form>
    </div>

</asp:Content>
