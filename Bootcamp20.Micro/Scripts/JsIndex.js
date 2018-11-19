function check(Id) {
    swal({
        title: "Are you sure?",
        text: "You will not be able to recover this imaginary file!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Yes, delete it!",
        closeOnConfirm: false
    },
    function () {
        $.ajax({
            url: "/Suppliers/Delete/",
            data: {
                'Id': Id
            },
            type: "POST",
            success: function (response) {
                swal
                    ({
                        title: "Deleted!",
                        text: "That data has been soft delete!",
                        type: "success"
                    },
                        function () {
                            window.location.href = '/Suppliers/Index/';
                            //settimeout(function(){
                            //    location.reload();
                            //}, 1200);
                        });
            },
            error: function (response) {
                swal("Oops", "We couldn't connect to the server!", "error");
            }
        });
    });
}