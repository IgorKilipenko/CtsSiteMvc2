$(document).ready(function () {
    applyShowEffects();
});



/* SHOW EFFECTS */

function applyShowEffects() {

    activateEffects();
}


function activateEffects() {
    
    var elements = $("[show-effect]").not(".is_animate");

    if (elements != null && elements.length > 0) {
        $(window).scroll(function () {
            elements.each(function (i, item) {
                var h = $(window).height();
                if (($(window).scrollTop() + h) > $(item).offset().top + $(item).height() * 0.1) {
                    $(item).addClass("is-animate");
                    //alert("");
                }
                else if (($(window).scrollTop() + h) < $(item).offset().top + $(item).height() * 0.1)
                    $(item).removeClass("is-animate");
            })
        })
    }

}