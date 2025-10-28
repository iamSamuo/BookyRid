import { Component, OnInit } from '@angular/core';
import { Book } from '../models/book';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css'],
  standalone: true,
  imports: [CommonModule],
})
export class BookListComponent implements OnInit {
  constructor() {}
  books: Book[] = [
    { id: 1, auther: 'Author One', title: 'Book Title One' },
    { id: 2, auther: 'Author Two', title: 'Book Title Two' },
    { id: 3, auther: 'Author Three', title: 'Book Title Three' },
  ];

  ngOnInit(): void {}
}
