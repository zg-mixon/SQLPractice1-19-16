var Library;
(function (Library) {
    var Controllers;
    (function (Controllers) {
        var BookListController = (function () {
            function BookListController($http) {
                var _this = this;
                this.$http = $http;
                $http.get('/api/books')
                    .then(function (response) {
                    _this.books = response.data;
                });
            }
            return BookListController;
        })();
        Controllers.BookListController = BookListController;
    })(Controllers = Library.Controllers || (Library.Controllers = {}));
})(Library || (Library = {}));
//# sourceMappingURL=bookListController.js.map