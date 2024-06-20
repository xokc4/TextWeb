let columnIndex = 0;
let columnIndexStrok = 0;

function addRow() {
    const tableBody = document.getElementById('priceListTable').getElementsByTagName('tbody')[0];
    const row = tableBody.insertRow();
    row.insertCell(0).innerHTML = `Колонка ${columnIndex + 1}`;
    row.insertCell(1).innerHTML = '<input type="text" class="form-control" name="row[]">';
    row.insertCell(2).innerHTML = `
        <select class="form-control" name="rowType[]">
            <option value="text">Текст</option>
            <option value="number">Число</option>
            <option value="date">Дата</option>
        </select>`;
    row.insertCell(3).innerHTML = '<button class="btn btn-danger" onclick="removeRow(this)">Удалить</button>';
    columnIndex++;
    columnIndexStrok++;
}

function removeRow(buttonElement) {
    const row = buttonElement.parentElement.parentElement;
    columnIndex--;
    columnIndexStrok--;
    row.remove();
}

function submitData(event) {
    event.preventDefault(); // Prevent form submission

    const tableBody = document.getElementById('priceListTable').getElementsByTagName('tbody')[0];
    const rows = Array.from(tableBody.getElementsByTagName('tr'));
    const data = {
        ListName: document.getElementById('listName').value,
        Rows: rows.map(row => {
            const cells = Array.from(row.getElementsByTagName('td'));
            return cells[1].children[0] ? cells[1].children[0].value : '';
        })
    };

    fetch('/AddPriceList/ProcessPriceList', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
    })
        .then(response => response.json())
        .then(data => {
            console.log('Успешно:', data);
            // Обработка ответа от сервера
        })
        .catch((error) => {
            console.error('Ошибка:', error);
        });
}
