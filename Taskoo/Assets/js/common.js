
$(window).load(function () {
    $('#task-loading-animation-container').fadeOut(300);
});

$(document).ready(function () {

    managePriorityIcons();
    initDatePicker();
    initCheckBoxRadio();
    manageCheckboxBehavior();

    function managePriorityIcons()
    {
        var pathname = window.location.pathname;
        var arr = pathname.split('/');

        if (arr[1] == "CreateTask" || arr[1] == "EditTask")
        {
            $('#task-filter').remove();
        }

        var priority = arr[arr.length - 1];

        if(priority == 'a')
        {
            $('#green-triangle').removeClass();
            $('#green-triangle').addClass('task-transparent-icon');
        }
        else {
            switch (priority) {
                case 'g':
                    $('#green-triangle').addClass('task-highlighted-icon task-transparent-icon');
                    break;
                case 'y':
                    $('#yellow-triangle').addClass('task-highlighted-icon task-transparent-icon');
                    $('#green-triangle').removeClass();
                    $('#green-triangle').addClass('task-transparent-icon');
                    break;
                case 'r':
                    $('#red-triangle').addClass('task-highlighted-icon task-transparent-icon');
                    $('#green-triangle').removeClass();
                    $('#green-triangle').addClass('task-transparent-icon');
                    break;
            }
        }
    }

    function initDatePicker()
    {
        $(function () {
            $('#task-date-picker').datepicker({
                dateFormat: "dd-mm-yy"
            });
        });
    }

    function initCheckBoxRadio() {
        $(function () {
            $('.task-checkbox').checkboxradio();
        });
    }

    function manageCheckboxBehavior()
    {
        $('.task-radio-container').click(function () {
            $('.task-radio-button', this).prop('checked', true);

            $('.task-radio-img').css('opacity', '.3');
            $('.task-radio-img', this).css('opacity', '1');
        });
    }

});

