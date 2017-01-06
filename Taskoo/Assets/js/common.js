
$(document).ready(function () {

    managePriorityIcons();
    initDatePicker();

    function managePriorityIcons()
    {
        var pathname = window.location.pathname;
        var arr = pathname.split('/');
        var priority = arr[arr.length - 1];

        if(priority == 'a')
        {
            $("#green-triangle").removeClass();
            $("#green-triangle").addClass('task-transparent-icon');
        }
        else {
            switch (priority) {
                case 'g':
                    $("#green-triangle").addClass('task-highlighted-icon task-transparent-icon');
                    break;
                case 'y':
                    $("#yellow-triangle").addClass('task-highlighted-icon task-transparent-icon');
                    $("#green-triangle").removeClass();
                    $("#green-triangle").addClass('task-transparent-icon');
                    break;
                case 'r':
                    $("#red-triangle").addClass('task-highlighted-icon task-transparent-icon');
                    $("#green-triangle").removeClass();
                    $("#green-triangle").addClass('task-transparent-icon');
                    break;
            }
        }
    }

    function initDatePicker()
    {
        $(function () {
            $("#task-date-picker").datepicker();
        });
    }

});

