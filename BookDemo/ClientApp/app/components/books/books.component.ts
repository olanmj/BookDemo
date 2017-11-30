import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';



@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent  {

    public books: Book[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Books').subscribe(result => {
            this.books = result.json() as Book[];
        }, error => console.error(error));
    }

}

interface Book {
    title: string;
    pubDate: number;
    category: string;
    author: Author;
}

interface Author {
    firstName: string;
    lastName: string;
}
