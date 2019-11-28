$("#comment_add").click(function () {
   
        
    
    
    var myDiv = document.querySelector('#my-div');

    let comment = {
        Newsid: myDiv.dataset.newsid,
        Userid: myDiv.dataset.userid,
        CommentText: $("#comment-body")[0].value }
    
    
    $.ajax({
        url: '/Home/Comment',
        method: 'GET',
        dataType:'Json',
        data: { data: JSON.stringify(comment)}, 
        success: function (data) {
            let com = JSON.parse(data);
            
            $('#commentdiv').after("<p class=shadow-sm p-3 mb-5 bg-white rounded ><b>" + com.Userid + "</b><br />" + com.CommentText + "</p>");
        
            clearForm();
        },
        error: function () {
            alert('error');

        }
                     

    }); $("#comment-body").reset;
})
clearForm();
function clearForm() {
    $("#comment-body").val("");
   
}