$(document).ready(function() {

    $(".mli").mouseover(function() {
        $(".mli .submenu").css("display", "block");
    });
    $(".mli").mouseout(function() {
        $(".mli .submenu").css("display", "none");
    });

    $('input[name=txtFName]').change(function() { var x = document.getElementsByName("txtFName"); if (!/[\d]/.test(x[0].value)) { document.getElementById("eFname").innerHTML = "<img src='../../content/images/validated_check.png' />"; } else { document.getElementById("eFname").innerHTML = "<span style='color:Red'>error: This field cannot be numeric</span>"; } });
    $('input[name=txtLName]').change(function() { var x = document.getElementsByName("txtLName"); if (!/[\d]/.test(x[0].value)) { document.getElementById("eLname").innerHTML = "<img src='../../content/images/validated_check.png' />"; } else { document.getElementById("eLname").innerHTML = "<span style='color:Red'>error: This field cannot be numeric</span>"; } });
    $('input[name=txtEmail]').change(function() { var x = document.getElementsByName("txtEmail")[0].value; if (/\S+@\S+\.\S+/.test(x)) { document.getElementById("eEmail").innerHTML = "<img src='../../content/images/validated_check.png' />"; } else { document.getElementById("eEmail").innerHTML = "<span style='color:Red'>error: Invalid Email type</span>"; } });
    $('input[name=txtBday]').change(function() { var x = document.getElementsByName("txtBday"); if (/^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$/g.test(x[0].value)) { document.getElementById("eBday").innerHTML = "<img src='../../content/images/validated_check.png' />"; } else { document.getElementById("eBday").innerHTML = "<span style='color:Red'>error: Birthday error</span>"; } });
    $('input[name=txtPersCity]').change(function() { var x = document.getElementsByName("txtPersCity"); if (isNaN(x[0].value)) { document.getElementById("ePcity").innerHTML = "<img src='../../content/images/validated_check.png' />"; } else { document.getElementById("ePcity").innerHTML = "<span style='color:Red'>error: This field cannot be numeric</span>"; } });
    $('input[name=txtPersSt]').change(function() { var x = document.getElementsByName("txtPersSt"); if (isNaN(x[0].value)) { document.getElementById("ePst").innerHTML = "<img src='../../content/images/validated_check.png' />"; } else { document.getElementById("ePst").innerHTML = "<span style='color:Red'>error: Street should contain letters too</span>"; } });
    $('input[name=txtPersStNo]').change(function() { var x = document.getElementsByName("txtPersStNo"); if (!isNaN(x[0].value)) { document.getElementById("ePstNo").innerHTML = "<img src='../../content/images/validated_check.png' />"; } else { document.getElementById("ePstNo").innerHTML = "<span style='color:Red'>error: Street No. should be numeric</span>"; } });
    $('input[name=txtPersZC]').change(function() { var x = document.getElementsByName("txtPersZC"); if (!isNaN(x[0].value)) { document.getElementById("ePzc").innerHTML = "<img src='../../content/images/validated_check.png' />"; } else { document.getElementById("ePzc").innerHTML = "<span style='color:Red'>error: Zip Code should be numeric</span>"; } });
    $('input[name=txtPersPh]').change(function() { var x = document.getElementsByName("txtPersPh")[0].value; if (/^(?!.*-.*-.*-)(?=(?:\d{8,10}$)|(?:(?=.{9,11}$)[^-]*-[^-]*$)|(?:(?=.{10,12}$)[^-]*-[^-]*-[^-]*$)  )[\d-]+$/.test(x)) { document.getElementById("ePph").innerHTML = "<img src='../../content/images/validated_check.png' />"; } else { document.getElementById("ePph").innerHTML = "<span style='color:Red'>error: Phone Field should be numeric</span>"; } });

    $('input[name=txtReceiverName]').change(function() { var x = document.getElementsByName("txtReceiverName"); if (!/[\d]/.test(x[0].value)) { document.getElementById("eRname").innerHTML = "<img src='../../content/images/validated_check.png' />"; } else { document.getElementById("eRname").innerHTML = "<span style='color:Red'>error: This field cannot be numeric</span>"; } });
    $('input[name=txtDelDNI]').change(function() { var x = document.getElementsByName("txtDelDNI"); if (/\d+.\d+\.\d+/.test(x[0].value)) { document.getElementById("eDeldni").innerHTML = "<img src='../../content/images/validated_check.png' />"; } else { document.getElementById("eDeldni").innerHTML = "<span style='color:Red'>error: DNI should contain NUMBERS and DOTS i.e: 33.000.000</span>"; } });
    $('input[name=txtDelCity]').change(function() { var x = document.getElementsByName("txtDelCity"); if (isNaN(x[0].value)) { document.getElementById("eDelcity").innerHTML = "<img src='../../content/images/validated_check.png' />"; } else { document.getElementById("eDelcity").innerHTML = "<span style='color:Red'>error: This field cannot be numeric</span>"; } });
    $('input[name=txtDelSt]').change(function() { var x = document.getElementsByName("txtDelSt"); if (isNaN(x[0].value)) { document.getElementById("eDelst").innerHTML = "<img src='../../content/images/validated_check.png' />"; } else { document.getElementById("eDelst").innerHTML = "<span style='color:Red'>error: Street should contain letters too</span>"; } });
    $('input[name=txtDelStNo]').change(function() { var x = document.getElementsByName("txtDelStNo"); if (!isNaN(x[0].value)) { document.getElementById("eDelstno").innerHTML = "<img src='../../content/images/validated_check.png' />"; } else { document.getElementById("eDelstno").innerHTML = "<span style='color:Red'>error: Street No. should be numeric</span>"; } });
    $('input[name=txtDelZC]').change(function() { var x = document.getElementsByName("txtDelZC"); if (!isNaN(x[0].value)) { document.getElementById("eDelzc").innerHTML = "<img src='../../content/images/validated_check.png' />"; } else { document.getElementById("eDelzc").innerHTML = "<span style='color:Red'>error: Zip Code should be numeric</span>"; } });
    $('input[name=txtDelPhone]').change(function() { var x = document.getElementsByName("txtDelPhone")[0].value; if (/^(?!.*-.*-.*-)(?=(?:\d{8,10}$)|(?:(?=.{9,11}$)[^-]*-[^-]*$)|(?:(?=.{10,12}$)[^-]*-[^-]*-[^-]*$)  )[\d-]+$/.test(x)) { document.getElementById("eDelph").innerHTML = "<img src='../../content/images/validated_check.png' />"; } else { document.getElementById("eDelph").innerHTML = "<span style='color:Red'>error: Phone Field should be numeric</span>"; } });
    $("#sliderNext").click(function() {
        $("#carousel .items #" + count).show("slide", { direction: 'left' }, 500);
        $("#control" + (function() { return count === 1 ? 3 : count - 1; } ())).removeClass("active");
        $("#control" + count).addClass("active");
        $("#carousel .items #" + count).delay(5500).hide("slide", { direction: 'right' }, 500);

        if (count == sc) {
            count = 1;
        }
        else {
            count = count + 1;
        }
    });
    $("#sliderPrev").click(function() {
        var prev = (function() { return count === 1 ? 3 : count - 1; } ());
        $("#carousel .items #" + prev).show("slide", { direction: 'left' }, 500);
        $("#control" + count).removeClass("active");
        $("#control" + prev).addClass("active");
        $("#carousel .items #" + prev).delay(5500).hide("slide", { direction: 'right' }, 500);
    });

});

function validate(id) {
    if (id > 0) {
        var errorFields = $(".error:contains(error)").text();
        var emptyField = $("#" + id + ":contains(This field)").text();
    }
    else {
        var errorFields = $(".error:contains(error)").text();
        var emptyField = $(".error:contains(This field)").text();
    }
    if (errorFields.length <= 0 && emptyField.length <= 0)
    { return true; }
    else
    {return false;}
}
function validateAll() {
    var errorFields = $(".error:contains(error)").text();
    var emptyField = $(".error:contains(This field)").text();
    alert(errorFields.length);
    if (errorFields.length <= 0 && emptyField.length <= 0)
    { return true; }
    else
    { return false; }
}

function nextValidationForm(id) {

    if (validate(id) != false) {
        var next = id + 1;
        $("#" + id).css("display", "none");
        $("#" + next).css("display", "block");
    }
}

function prevValidationForm(id) {
    if (validate(id) != false) {
        var prev = id - 1;
        $("#" + id).css("display", "none");
        $("#" + prev).css("display", "block");
    }
}

function finishPurchase() {

    if (validateAll() != false) {
        alert('Your Purchase has been Registered, A Sales Rep will call you shortly!')
    }
    else {
        alert('Please review your form!');
    }
}

function Onload() {

    $("#carousel .items #1").show("fade", 500);
    $("#carousel .items #1").delay(5500).hide("slide", { direction: 'right' }, 500);

    var sc = $(".items img").size();
    var count = 2;

    setInterval(function() {
        $("#carousel .items #" + count).show("slide", { direction: 'left' }, 500);
        $("#control" + (function() { return count === 1 ? 3 : count-1; } ())).removeClass("active");
        $("#control" + count).addClass("active");
        $("#carousel .items #" + count).delay(5500).hide("slide", { direction: 'right' }, 500);

        if (count == sc) {
            count = 1;
        }
        else {
            count = count + 1;
        }
    }, 6500);

    
    
}
