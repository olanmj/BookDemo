import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { ActivatedRoute } from '@angular/router';

@Component({
    selector: 'app-book',
    templateUrl: './book.component.html',
    styleUrls: ['./book.component.css']
})
export class BookComponent {

    public book: Book;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string, route: ActivatedRoute) {
        let id = route.snapshot.params['id'];
        http.get(baseUrl + 'api/Books/' + id).subscribe(result => {
            this.book = result.json() as Book;
        }, error => console.error(error));
    }
}

interface Book {
    bookID: number;
    title: string;
    pubDate: number;
    category: string;
    author: Author;
}

interface Author {
    firstName: string;
    lastName: string;
}
