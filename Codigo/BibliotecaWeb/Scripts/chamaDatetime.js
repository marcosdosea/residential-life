if (!Modernizr.inputtypes.dateTime) {
    $(function () {
        $("dateTime").appendDtpicker({
            futureOnly: true,
            locale: 'br',
            closeOnSelected: true,
            calendarMouseScroll: false
        });
    });
};