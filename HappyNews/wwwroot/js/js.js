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
        success: function (Comm) {
             let rr = JSON.parse(Comm);
            let ptext = rr.CommentText;
            user= rr.Userid;

            $('#commentdiv').after('<p>${user}</p>');
            $('#commentdiv').after('<p>${ptext}</p>');
          
            
            
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