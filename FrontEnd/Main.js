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



// async function renderToDo(toDoItem) {
// }


// // Adding a new ToDo List item
// // async function handleAddToDo(event) {
// //     // stops page reloading by default
// //     event.preventDefault();
// //     // get title and priority from form
// //     const partialTodo = {
// //         title: event.target[0].value,
// //         priority: event.target[1].value,
// //     };
// //     // sent to database and recieve full item including id
// //     const completeTodo = await sendToDo("/todoitems", "POST", partialTodo);
// //     event.target.reset();
// //     renderToDo(completeTodo);
// // }



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
submitButton.addEventListener("click", submitEntry);
//text box
let entryArea = document.getElementById("entryArea");

// Button clicked function
async function submitEntry(event) {

    event.preventDefault();
    const entry = {
        journalEntry: entryArea.innerText
    }
    const entryAdd = await postJournalEntry("/journal", "POST", entry);

}

async function postJournalEntry(path, method, body) {
    const res = await fetch(`${BACKEND_URL}${path}`, {
        method,
        headers: { "content-type": "application/json" },
        body: JSON.stringify(body),
    });
    // await response (res) from the INSERT
    const data = await res.json();
    // return response
    return data;
}




