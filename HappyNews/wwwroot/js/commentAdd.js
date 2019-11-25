

function commentsAdd() {
    var myDiv = document.querySelector('#my-div1');
   data = myDiv.dataset.newsid;
        
    $.ajax({
        url: '/Home/CommentAdd',
        method: 'GET',
        dataType: 'Json',
        data: { data: JSON.stringify(data) },
        success: function (m1) {
            alert(m1);
            let rr = JSON.parse(m1);
            for (let i = 0; i < rr.length; i++) {
                pp = rr[i].CommentText;
                ppp = rr[i].Userid;

                    $('#commentdiv').after("<p><b>" + pp + "</b><br />" + ppp + "</p>");
            }
            
        },
        error: function () {
            alert('error');

        }


    })
}


 commentsAdd();