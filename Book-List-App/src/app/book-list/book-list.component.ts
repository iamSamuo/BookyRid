import { Component, OnInit } from '@angular/core';
import { Book } from '../models/book';
import { CommonModule } from '@angular/common';
import { BookService } from '../services/book.service';

@Component({
  selector: 'book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css'],
  standalone: true,
  imports: [CommonModule],
})
export class BookListComponent implements OnInit {
  constructor(private bookService: BookService) {}
  books: Book[] = [];

  ngOnInit(): void {
    this.bookService.getBooks().subscribe((data: Book[]) => {
      this.books = data;
    });
  }
}
