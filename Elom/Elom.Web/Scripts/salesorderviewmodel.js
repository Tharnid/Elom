SalesOrderViewModel = function (data) {
    var self = this;
    ko.mapping.fromJS(data, {}, self);

    self.save = function () {
        $.ajax({
            url: "/Sales/Save/",
            type: "Post",
            data: ko.toJSON(self),
            contentType: "application/json",
            success: function (data) {
                if(data.SalesOrderViewModel != null) // map only if present
                    ko.mapping.fromJS(data.SalesOrderViewModel, {}, self);
            }
        });
    }
};