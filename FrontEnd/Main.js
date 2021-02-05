// // the server backend
// const BACKEND_URL = "http://localhost:5000";

// // first function to call
// async function loadInitialToDos() {
//     // gets all things from backend
//     // const res = await fetch(`${BACKEND_URL}/todoitems`);
//     // Getting all the results as JSON objects
//     // const data = await res.json();
//     // rendering each of them ( displaying)
//     //  data.forEach(renderToDo);
// }

// function renderToDo(toDoItem) {
// }


// // Adding a new ToDo List item
// async function handleAddToDo(event) {
//     // stops page reloading by default
//     event.preventDefault();
//     // get title and priority from form
//     const partialTodo = {
//         title: event.target[0].value,
//         priority: event.target[1].value,
//     };
//     // sent to database and recieve full item including id
//     const completeTodo = await sendToDo("/todoitems", "POST", partialTodo);
//     event.target.reset();
//     renderToDo(completeTodo);
// }

// // sending it off to the database
// async function sendToDo(path, method, body = "") {
//     const res = await fetch(`${BACKEND_URL}${path}`, {
//         method,
//         headers: {
//             "content-type": "application/json",
//         },
//         body: JSON.stringify(body),
//     });

//     // await response (res) from the INSERT
//     const data = await res.json();
//     // return response
//     return data;
// }



// // Perform a DELETE on the backend for the specific record
// async function deleteToDo(toDoItem) {
//     const res = await fetch(`${BACKEND_URL}/todoitems/${toDoItem.id}`, {
//         method: "DELETE",
//     });
//     if (res.ok) {
//         document.querySelector(`#to-do-item-${toDoItem.id}`).remove();
//     }
// }


// inputForm.addEventListener("submit", handleAddToDo);

// loadInitialToDos();

// START

// server
const BACKEND_URL = "http://localhost:5000";

// variables
let submitButton = document.getElementById("submitButton");
sortbutton.addEventListener("click", submitEntry);

//text box
let entryArea = document.getElementById("entryArea");

function submitEntry(event) {

}

