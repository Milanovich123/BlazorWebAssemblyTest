function createAlert(message) {
    alert(message);
}
function log(message) {
    console.log(message);
}
let isButtonGroupHovered = false;

function createViewer(url) {
    $('#viewer-container').viewer({
        translucentOpacity: 0.05,
        enableTouch: true,
        enableClippingPlaneWidget: true
    });
    $('#viewer-container').viewer('loadUrl', url);  
    checkButtonGroupHover();
    $('#viewer-container').bind('viewer.select', function (event, selected) {
        if (!isButtonGroupHovered) {
            console.log("Selected objects: " + selected.toString());
            DotNet.invokeMethodAsync('BlazorProject.Client', "ChangeParaContentValue", selected.toString());
        }
    });
}
function showModel(id) {
    $('#viewer-container').viewer('showModel', id);
}
function hideModel(id) {
    $('#viewer-container').viewer('hideModel', id);
}

function showSelected(...ids) {
    ids.forEach(id => {
        $('#viewer-container').viewer('show', id);
    });
}
function showAll() {
    $('#viewer-container').viewer('showAll');
    console.log("Showing all");
}
function hideOther(...ids) {
    $('#viewer-container').viewer('hideAll');
    if (ids.length === 1 && ids[0] === "") {
    } else {
        ids.forEach(id => {
            $('#viewer-container').viewer('show', id);
        });
    }
}
function hideSelected(...ids) {
    ids.forEach(id => {
        $('#viewer-container').viewer('hide', id);
    });
}
function translucent(...ids) {
    ids.forEach(id => {
        $('#viewer-container').viewer('translucent', id);
    });
}
function translucentAll(...ids) {
    $('#viewer-container').viewer('translucentAll');
    if (ids.length === 1 && ids[0] === "") {
    } else {
        ids.forEach(id => {
            $('#viewer-container').viewer('show', id);
        });
    }
}

function modelInfo() {
    $('#viewer-container').viewer('modelInfo', function (modelInfos) {
        console.log(modelInfos);
    });
}
function checkButtonGroupHover() {
    const buttonGroup = document.querySelector('.btn-group');
    if (buttonGroup) {
        buttonGroup.addEventListener('mouseenter', () => {
            isButtonGroupHovered = true;
        });
        buttonGroup.addEventListener('mouseleave', () => {
            isButtonGroupHovered = false;
        });
    } else {
        console.log("buttonGroup was not found.");
    }
}
