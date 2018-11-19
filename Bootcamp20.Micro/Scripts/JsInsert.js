function validateData() {
    if ($("#SuppName").val() == "") {
        swal("Please enter supplier name!");
        return false;
    } else {
        return true;
    }
}