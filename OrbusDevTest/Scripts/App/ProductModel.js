var ProductModel = function (products) {

    var self = this;

    self.products = ko.observableArray(JSON.parse(products));


}