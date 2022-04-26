function createAlert(message) {
    alert(message);
}
function log(message) {
    console.log(message);
}
function createViewer(url) {
    $('#viewer-container').viewer({
        //defaultColor: 'red',
        //selectedColor: 'blue',
        translucentOpacity: 0.05,
        enableTouch: true,
        enableClippingPlaneWidget: true
    });
    $('#viewer-container').viewer('loadUrl', url);  
    $('#viewer-container').bind('viewer.select', function (event, selected) {
        console.log("Selected objects: " + selected.toString());
        DotNet.invokeMethodAsync('BlazorProject.Client', "ChangeParaContentValue", selected.toString());
    });
}
function hideAll() {
    $('#viewer-container').viewer('hideAll');
}
function showAll() {
    $('#viewer-container').viewer('showAll');
}
function showModel(id) {
    $('#viewer-container').viewer('showModel', id);
}
function hideModel(id) {
    $('#viewer-container').viewer('hideModel', id);
}
function hideSelected(id) {
    $('#viewer-container').viewer('hide', id);
    //console.log("Hiding object with id: " + id);
}
function translucent(id) {
    $('#viewer-container').viewer('translucent', id);
}
function opaque(id) {
    $('#viewer-container').viewer('opaque', id);
}
function modelInfo() {
    $('#viewer-container').viewer('modelInfo', function (modelInfos) {
        console.log(modelInfos);
    });
}
