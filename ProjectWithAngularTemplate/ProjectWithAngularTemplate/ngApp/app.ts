namespace ProjectWithAngularTemplate {

    angular.module("ProjectWithAngularTemplate", ['ngRoute'])
        .config(function($routeProvider: ng.route.IRouteProvider) {
            //$routeProvider.when('/', {
            // templateUrl: '/path/to/view',
            // controller: ProjectWithAngularTemplate.Controllers.ControllerClass,
            // controllerAs: 'views variable name for controller'
            //});
            $routeProvider.when('/', {
                template: 'Hello World!'

            });
            $routeProvider.when('/listings', {
                templateUrl: '/ngApp/views/listListings.html',
                controller: ProjectWithAngularTemplate.Controllers.ListOfListingsController,
                controllerAs: 'controller'
            });
        });
}