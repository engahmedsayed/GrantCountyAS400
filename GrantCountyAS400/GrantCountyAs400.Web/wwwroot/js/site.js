// Write your Javascript code.
$(function () { // onDomReady
    // reset handler that clears the form
    $('form input:reset').click(function () {
        $(this).parents('form:first')
            .find(':radio, :checkbox').removeAttr('checked').end()
            .find('textarea, :text, select').val('')

        return false;
    });
});