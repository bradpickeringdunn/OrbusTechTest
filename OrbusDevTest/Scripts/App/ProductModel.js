var ProductModel = function (products) {

    var self = this;

    var categories = [];
    var subCategories = [];

    self.products = ko.observableArray(JSON.parse(products));

    self.Categories = ko.observableArray(categories);
    self.SubCategories = ko.observableArray(subCategories);

    self.LoadCategories = function () {

        $.ajax({
            url: "http://localhost:37386/api/Category/",
            method: "GET",
            success: function (data) {
                self.Categories(data);
                self.LoadSubCategories(data[0].Id)
            }
        }).done(function () {
            $(this).addClass("done");
        });

    };

    self.LoadSubCategories = function (categoryId) {

        $.ajax({
            url: "http://localhost:37386/api/Category/GetSubCategories/" ,
            method: "GET",
            data:{categoryId:categoryId},
            success: function (data) {
                self.SubCategories(data);
            }
        }).done(function () {
            $(this).addClass("done");
        });

    };
}