// Write your Javascript code.
document.querySelector('#dropit').addEventListener('dragover', function(e) {
    e.preventDefault(); // Annule l'interdiction de drop
});
document.querySelector('#dropit').addEventListener('drop', function (e) {
    var data = e.dataTransfer.getData("text");
    var data1 = e.currentTarget.id;
    console.log(data);
    if (data == "titledrag") {
        var txt = document.createElement("h1");
        txt.innerHTML = "<input type='text' />";
        $("#dropit").append(txt).fadeIn();
    }
    else if (data == "paradrag") {
        var txt2 = document.createElement('p');
        txt2.innerHTML = "<input type='text'>";
        $("#dropit").append(txt2).fadeIn();
    }

});
var dragitup = document.querySelectorAll('.dragit');
Array.from(dragitup).forEach(link => {
    link.addEventListener('dragstart', function (e) {
        e.dataTransfer.setData('text', e.target.id);
        console.log(e.target.id);
    });
});

//document.querySelectorAll('.dragit').addEventListener('dragstart', function (e) {
//    e.preventDefault();
//    e.dataTransfer.setData('text', e.target.id);
//    console.log(e.target.id);
//});
//draggableElement.addEventListener('dragstart', function (e) {
//    e.dataTransfer.setData('text/plain', '');
//});

