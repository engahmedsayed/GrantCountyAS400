// Write your Javascript code.
$(function () { // onDomReady
    // reset handler that clears the form
    $('form input:reset').click(function () {
        $(this).parents('form:first')
            .find(':radio, :checkbox').removeAttr('checked').end()
            .find('textarea, :text, :input[type="number"], select').val('');

        return false;
    });

    // show nested submenu
    $('.dropdown-submenu a.sub-link').on("click", function (e) {
        $('.dropdown-submenu a.sub-link').next('ul').hide(); // hide any previous displayed submenus
        $(this).next('ul').toggle();
        e.stopPropagation();
        e.preventDefault();
    });
});

//import { debug } from "util";

/*search for users that contains written string*/
function Search() {
    var searchVal = $("#searchText").val();
    var param = {};
    param.searchVal = searchVal;
    $.ajax({
        url: refreshUrl,
        type: "GET",
        data: param,
        success: function (html) {
            $("#userList").html(html);
        },
        error: function (e) {
            console.log(e);
        }
    });
}

/*press enter on search textBox*/
/*@event event object*/
function enterSearch(event) {
    if (event.keyCode == 13) {
        Search();
    }
}