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

    $('body').on('click', '#userList .pagination a', function (event) {
        event.preventDefault();
        console.log('page');
        var searchVal = $('#searchText').val();
        var currentPage = $(this).html();
        if (currentPage == '&gt;') { currentPage = $('#pageCount').val(); }
        if (currentPage == '&lt;') { currentPage = 1; }
        if (searchVal == undefined || searchVal == '') {
            searchVal = '?page=' + currentPage;
        } else {
            searchVal = '?searchVal=' + searchVal + '&page=' + currentPage;
        }
        var url = refreshUrl + searchVal;
        console.log(url);
        $.ajax({
            url: url,
            success: function (result) {
                ChangeUrl('index', url);
                $('#userList').html(result);
            }
        });
    });
});

window.addEventListener("popstate", function (e) {
    $.ajax({
        url: location.href,
        success: function (result) {
            $('#userList').html(result);
        }
    });
});
function ChangeUrl(page, url) {
    if (typeof (history.pushState) != "undefined") {
        var obj = { Page: page, Url: url };
        history.pushState(null, obj.Page, obj.Url);
    } else {
        alert("Browser does not support HTML5.");
    }
}

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