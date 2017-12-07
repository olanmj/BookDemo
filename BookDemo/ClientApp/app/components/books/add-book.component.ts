import { Component, Inject } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Http, Headers } from '@angular/http';
//import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Router } from '@angular/router';

@Component({
    selector: 'app-add-book',
    templateUrl: './add-book.component.html',
    styleUrls: ['./add-book.component.css']
})
export class AddBookComponent {
    model = new BookVM();
    postResult: Object;
    

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string, private router: Router) {
        http.get(baseUrl + 'api/Authors').subscribe(result => {
            this.model.authorList = result.json() as Author[];
        }, error => console.error(error));
    }

    onSubmit(form: NgForm) {
        console.log("Submitted: " + this.model.title + " ID: " + this.model.authorID +
            " Year: " + this.model.pubDate + " Category: " + this.model.category);
        let hdrs = new Headers({ 'Content-Type': 'application/json' });
       
        this.http.post(this.baseUrl + 'api/Books', this.model,
            { headers: hdrs }).subscribe(result => {
                this.postResult = result;
                this.router.navigate(['/books']);
            });
    }



}

class BookVM {
    bookID: number;
    title: string;
    pubDate: number;
    category: string;
    authorID: string;
    authorList: Author[];
}

class Author {
    authorID: number;
    firstName: string;
    lastName: string;
}