

function commentsAdd() {
    var myDiv = document.querySelector('#my-div1');
   data = myDiv.dataset.newsid;
        
    $.ajax({
        url: '/Home/CommentAdd',
        method: 'GET',
        dataType: 'Json',
        data: { data: JSON.stringify(data) },
        success: function (coment) {
            
            let comment = JSON.parse(coment);
            for (let i = 0; i < comment.length; i++) {
                 
                $('#commentdiv').after("<p class=shadow-sm p-3 mb-5 bg-white rounded ><b>" + comment[i].Userid + "</b><br />" + comment[i].CommentText + "</p>");
            }
            
        },
        error: function () {
            alert('error');

        }


    })
}


 commentsAdd();