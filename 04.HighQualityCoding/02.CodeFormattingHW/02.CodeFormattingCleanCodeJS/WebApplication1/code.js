(function(){
    "use strict";
    var applicationName = navigator.appName;
    var addScroll;
    addScroll = false;

    if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
        addScroll = true;
    }

    var Event;
    var pX = 0;
    var pY = 0;
    var theLayer;

    document.onmousemove = mouseMove;

    if (applicationName === 'Netscape') {
        document.captureEvents(Event.MOUSEMOVE);
    }

    function mouseMove(eventInput) {
        if (applicationName === "Netscape") {
            pX = eventInput.pageX - 5;
            pY = eventInput.pageY;

            if (document.layers.ToolTip.visibility === 'show') {
                popTip();
            }
        }
        else {
            pX = event.x - 5;
            pY = event.y;

            if (document.all.ToolTip.style.visibility === 'visible') {
                popTip();
            }
        }
    }

    function popTip() {
        if (applicationName === 'Netscape') {
            theLayer = document.layers.ToolTip;
            if ((pX + 120) > window.innerWidth)        {
                pX = window.innerWidth - 150;
            }

            theLayer.left = pX + 10;
            theLayer.top = pY + 15;
            theLayer.visibility = 'show';
        }
        else {
            theLayer = document.all.ToolTip;

            if (theLayer) {
                pX = event.x - 5;
                pY = event.y;

                if (addScroll) {
                    pX = pX + document.body.scrollLeft;
                    pY = pY + document.body.scrollTop;
                }

                if ((pX + 120) > document.body.clientWidth) {
                    pX = pX - 150;
                }

                theLayer.style.pixelLeft = pX + 10;
                theLayer.style.pixelTop = pY + 15;
                theLayer.style.visibility = 'visible';
            }
        }
    }

    function hideTip() {
        if (applicationName === 'Netscape') {
            document.layers.ToolTip.visibility = 'hide';
        }
        else {
            document.all.ToolTip.style.visibility = 'hidden';
        }
    }

    function hideMenu1() {
        if (applicationName === 'Netscape') {
            document.layers.menu1.visibility = 'hide';
        }
        else {
            document.all.menu1.style.visibility = 'hidden';
        }
    }
    

    function hideMenu2() {
        if (applicationName === 'Netscape') {
            document.layers.menu2.visibility = 'hide';
        }
        else {
            document.all.menu2.style.visibility = 'hidden';
        }

    }

    function showMenu1() {
        if (applicationName === 'Netscape') {
            theLayer = document.layers.menu1;
            theLayer.visibility = 'show';
        }
        else {
            theLayer = document.all.menu1;
            theLayer.style.visibility = 'visible';
        }
    }

    function showMenu2() {
        if (applicationName === 'Netscape') {
            theLayer = document.layers.menu2;
            theLayer.visibility = 'show';
        }
        else {
            theLayer = document.all.menu2;
            theLayer.style.visibility = 'visible';
        }
    }
})();
// fostata