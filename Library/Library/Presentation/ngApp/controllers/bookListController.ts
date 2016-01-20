namespace Library.Controllers {
    export class BookListController {
        public books;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/books')
                .then((response) => {
                    this.books = response.data;
                });
        }
    }
}