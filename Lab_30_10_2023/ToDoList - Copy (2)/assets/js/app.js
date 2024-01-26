let listItemContent = document.getElementById("task-content");


function modifyTaskContent(){

    let modifiedContent = document.getElementById('exampleInputTask1').value;

    listItemContent.innerText = modifiedContent;
}

function addNewTask(){

    let newListItem = document.createElement("li");
    newListItem.className = "list-group-item";

    let modifiedContent = document.getElementById('exampleInputTask1').value;
    newListItem.innerText = modifiedContent;
    let htmlBtn = '<button class="btn btn-info"><i class="fa-solid fa-pen-to-square"></i></button>';
    newListItem.innerHTML += htmlBtn;
    console.log(newListItem.innerText);

    
    let list = document.getElementById("task-ul");
    list.appendChild(newListItem);

    console.log(newListItem);
}