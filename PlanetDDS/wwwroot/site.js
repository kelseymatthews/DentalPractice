
function getPatients() {
    fetch('patient')
        .then(response => response.json())
        .then(data => displayPatients(data))
        .catch(error => console.error('Unable to get patients.', error));
}  

function displayPatients(data) {
    const tBody = document.getElementById('patients');
    var jsonStr = JSON.stringify(data);
    tBody.innerHTML = jsonStr;
}

function getDentists() {
    fetch('dentist')
        .then(response => response.json())
        .then(data => displayDentists(data))
        .catch(error => console.error('Unable to get dentists.', error));
}

function displayDentists(data) {
    const tBody = document.getElementById('dentists');
    var jsonStr = JSON.stringify(data);
    tBody.innerHTML = jsonStr;
}