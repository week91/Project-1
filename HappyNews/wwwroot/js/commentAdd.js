

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
            for (let i = 0; i < rr.length; i++)
            {
                pp = rr[i].CommentText
                ppp=rr[i].

                $('#commentdiv').after(`<div class="card-body">
    <h5 class="card-title"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">${ppp}</font></font></h5>
    <p class="card-text"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">${pp}</font></font></p>
    <font style="vertical-align: inherit;"><font style="vertical-align: inherit;"></font></font>
  </div>`);
            }
            
        },
        error: function () {
            alert('error');

        }


    })
}


 commentsAdd();