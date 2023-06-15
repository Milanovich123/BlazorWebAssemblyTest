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
        } else {
            console.log("Hovering over group button so we don't interact with the viewer.");
        }
    });
}
function showModel(id) {
    $('#viewer-container').viewer('showModel', id);
}
function hideModel(id) {
    $('#viewer-container').viewer('hideModel', id);
}

function showSelected(id) {
    $('#viewer-container').viewer('show', id);
    console.log(typeof(id));
}
function showAll() {
    $('#viewer-container').viewer('showAll');
    console.log("Showing all");
}
function hideOther(id) {
    $('#viewer-container').viewer('hideAll');
    $('#viewer-container').viewer('show', id);
    console.log("Hiding all except: " + id);
}
function hideSelected(id) {
    $('#viewer-container').viewer('hide', id);
    console.log("Hiding object with id: " + id);
}
function translucent(id) {
    $('#viewer-container').viewer('translucent', id);
    console.log("Translucant on object with id: " + id);
}
function translucentAll(id) {
    $('#viewer-container').viewer('translucentAll');
    $('#viewer-container').viewer('show', id);
    console.log("Make all translucent except: " + id);
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
            console.log("Hovering over button group.");
        });
        buttonGroup.addEventListener('mouseleave', () => {
            isButtonGroupHovered = false;
            console.log("Stopped hovering over button group.");
        });
    } else {
        console.log("buttonGroup was not found.");
    }
}
