// Write your Javascript code.
//Tool to create article and tutorials
var chipit = document.querySelectorAll(".chips");
Array.from(chipit).forEach(link => {
    link.addEventListener('click', function () {
        var show = document.createElement('li');
        alert($(this).attr('title'));
        //alert($(link.currentTarget).data('title'));
        //var ix = $(link.currentTarget).data('title');
        var ix = $(this).attr('title');
        //show.innerHTML = "<a class='button'><span>remove</span><div class='icon'><i class='fa fa-remove close'></i><i class='fa fa-check'></i></div>";
        show.innerHTML = "<div class='chips'>"+ix+"</div>";
        var container = document.getElementById('containerright');
        container.appendChild(show);
    });
});
console.log(chipit);
document.querySelector('#dropit').addEventListener('dragover', function(e) {
    e.preventDefault(); // Annule l'interdiction de drop
});
document.querySelector('#dropit').addEventListener('drop', function (e) {
    var data = e.dataTransfer.getData("text");
    var data1 = e.currentTarget.id;
    console.log(data);
    if (data == "titledrag") {
        var txt = document.createElement("li");
        txt.innerHTML = "<h1><input id='TextIns' name='TextIns' value='' type='text'></h1>";
        $("#dropitdown").append(txt).fadeIn();
    }
    else if (data == "paradrag") {
        var txt2 = document.createElement('li');
        txt2.innerHTML = "<p><input asp-for='TextIns' /></p>";
        $("#dropitdown").append(txt2).fadeIn();
    }

});
var dragitup = document.querySelectorAll('.dragit');
Array.from(dragitup).forEach(link => {
    link.addEventListener('dragstart', function (e) {
        e.dataTransfer.setData('text', e.target.id);
        console.log(e.target.id);
    });
});
var sortitout = document.getElementById('dropitdown');
var sortable = Sortable.create(sortitout);
function doit() {
    var htmlToString = document.getElementById('dropitdown').innerHTML;
    document.getElementById('stringHtml').value = htmlToString;
    var ekko = "";
}
//Tool to create scripts


//Array.from(chipit).forEach(eve => {
//    eve.addEventListener('onclick', function () {
//        var show = document.createElement('span');
//        show.innerHTML = "show";
//        var container = document.getElementById('containerright');
//        container.appendChild(show);
//    });
//});
//function chipitup() {
//    var show = document.createElement('span');
//    show.innerHTML = "show";
//    var container = document.getElementById('containerright');
//    container.appendChild(show);
//}

//document.querySelectorAll('.dragit').addEventListener('dragstart', function (e) {
//    e.preventDefault();
//    e.dataTransfer.setData('text', e.target.id);
//    console.log(e.target.id);
//});
//draggableElement.addEventListener('dragstart', function (e) {
//    e.dataTransfer.setData('text/plain', '');
//});

