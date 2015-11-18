$("login").click(function(){
    $.ajax(
    	{url: "demo_test.txt", 
    	success: function(result){
        $("#body").html(result);
    }});
});