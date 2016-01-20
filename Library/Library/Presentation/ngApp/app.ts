namespace Library {
    angular.module("Library", ['ngRoute'])
        .config(function ($routeProvider: ng.route.IRouteProvider) {
            $routeProvider
                .when('/', {
                    templateUrl: '/Presentation/ngApp/views/bookList.html',
                    controller:Library.Controllers.BookListController,
                    controllerAs: 'controller'
                });
        });
}