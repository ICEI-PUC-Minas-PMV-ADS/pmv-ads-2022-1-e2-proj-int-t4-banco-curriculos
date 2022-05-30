const handleInprogressCheckbox = (idCheckbox, idInput) => {
    const isChecked = document.querySelector(`#${idCheckbox}`)?.checked
    if (isChecked) {
        document.querySelector(`#${idInput}`).setAttribute('disabled', true)
        return
    }

    document.querySelector(`#${idInput}`).removeAttribute('disabled')
}