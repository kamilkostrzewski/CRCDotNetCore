class MeasurementListSection {
    addNewMeasurement(measurement) {
        let grid = document.querySelector('#measurements_container')
        let newRow = grid.children[1].cloneNode(true)

        let nameColumn = newRow.querySelector('div[data-column-type=\'name\']')
        let valueColumn = newRow.querySelector('div[data-column-type=\'value\']')

        nameColumn.innetHTML = measurement.name
        nameColumn.innetHTML = measurement.value

        newRow.classList.remove('d-none')
        grid.appendChild(newRow)
    }
}