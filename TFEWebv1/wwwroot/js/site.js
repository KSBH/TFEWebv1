// Write your Javascript code.
document.querySelector('#dropit').addEventListener('dragover', function(e) {
    e.preventDefault(); // Annule l'interdiction de drop
});
document.querySelector('#dropit').addEventListener('drop', function (e) {
    var data = e.dataTransfer.getData("text");
    var data1 = e.currentTarget.id;
    console.log(data);
    if (data == "titledrag") {
        var txt = document.createElement("li");
        txt.innerHTML = "foo<h1><input type='text' /></h1>";
        $("#dropitdown").append(txt).fadeIn();
    }
    else if (data == "paradrag") {
        var txt2 = document.createElement('li');
        txt2.innerHTML = "<p><input type='text' /></p>";
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

//document.querySelectorAll('.dragit').addEventListener('dragstart', function (e) {
//    e.preventDefault();
//    e.dataTransfer.setData('text', e.target.id);
//    console.log(e.target.id);
//});
//draggableElement.addEventListener('dragstart', function (e) {
//    e.dataTransfer.setData('text/plain', '');
//});

