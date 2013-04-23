(function generateRandomColor() {
    var contentDiv = document.getElementById('content');
    contentDiv.style.width = (screen.width - 100) + 'px';
    contentDiv.style.height = (screen.height - 300) + 'px';
    var stopButton = document.getElementById('Stop');
    stopButton.className = 'disabledButton'
    stopButton.onclick = function () { }; 
})();

var timer;

function onButtonStopClick(event) {
    'use strict';

    var startButton = document.getElementById('Start');
    startButton.className = 'enabledButton';
    startButton.onclick = function () {
        onButtonStartClick();
    };

    var stopButton = document.getElementById('Stop');
    stopButton.className = 'disabledButton';

    clearInterval(timer);

    stopButton.onclick = function () { };
}

function onButtonStartClick(event) {
    'use strict';
    if (!event) event = window.event;

    var stopButton = document.getElementById('Stop');
    stopButton.className = 'enabledButton';
    stopButton.onclick = function () { onButtonStopClick(); };

    var startButton = document.getElementById('Start');
    startButton.className = 'disabledButton';

    var refreshInterval = 500;
    timer = setInterval(function () {
        createDivElements();
    }, refreshInterval);

    startButton.onclick = function () { };

    if (event.preventDefault) {
        event.preventDefault();
    }

    return false;
}

function createDivElements() {
    'use strict';

    var contentDiv = document.getElementById('content');
    var defaultDivCount = 5;
    var divCount = document.getElementById('divCount').value;

    while (contentDiv.firstChild) {
        contentDiv.removeChild(contentDiv.firstChild);
    }

    var randomDiv;
    var currCount = 0;
    var documentFragment = document.createDocumentFragment();

    while (currCount < divCount) {
        randomDiv = document.createElement('div');
        randomDiv.className = 'styled';
        randomDiv.innerHTML = '<strong>div</strong>';

        var divMinSize = 20;
        var divMaxSize = 100;
        randomDiv.style.width = generateRandomNum(divMinSize, divMaxSize) + 'px';
        randomDiv.style.height = randomDiv.style.width;

        var divMinBorderWidth = 1;
        var divMaxBorderWidth = 20;
        randomDiv.style.borderWidth = generateRandomNum(divMinBorderWidth, divMaxBorderWidth) + 'px';

        var divMinBorderRadius = 0;
        var divMaxBorderRadius = 40;
        randomDiv.style.borderRadius = generateRandomNum(divMinBorderRadius, divMaxBorderRadius) + 'px';

        randomDiv.style.borderColor = generateRandomColor();

        var maxHeight = contentDiv.offsetHeight - divMaxSize - divMaxBorderRadius;
        var top;
        top = generateRandomNum(0, maxHeight);
        randomDiv.style.top = top + 'px';

        var maxWidth = contentDiv.offsetWidth - divMaxSize - divMaxBorderRadius;
        var left;
        left = generateRandomNum(0, maxWidth);
        randomDiv.style.left = left + 'px';

        randomDiv.style.fontSize = parseInt(randomDiv.style.width, 10) / 2 + 'px';
        randomDiv.style.lineHeight = parseInt(randomDiv.style.width, 10) + 'px';
        randomDiv.style.background = generateRandomColor();
        randomDiv.style.color = generateRandomColor();

        documentFragment.appendChild(randomDiv);

        currCount++;
    }
    contentDiv.appendChild(documentFragment);
}

function generateRandomNum(min, max) {
    'use strict';
    return Math.floor((Math.random() * (max - min)) + min);
}

function generateRandomColor() {
    'use strict';
    var red = generateRandomNum(0, 255);
    var green = generateRandomNum(0, 255);
    var blue = generateRandomNum(0, 255);
    var alpha = generateRandomNum(0, 255);
    return 'rgba(' + red + ',' + green + ',' + blue + alpha + ')';
}

