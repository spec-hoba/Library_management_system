# Library Management System (OOP)

## Description
This is a simple Library Management System built using C# and the principles of Object-Oriented Programming (OOP).  
The project demonstrates core OOP concepts such as classes, encapsulation, inheritance, and polymorphism.  
It provides basic functionality for managing a library’s collection of books and simulates librarian–user interactions.

## Features
- Add new books to the library  
- Remove books from the collection  
- Display a list of all available books  
- Regular users can borrow books and view available books  
- Clean OOP design with multiple classes  

## User Stories
- As a user, I want to borrow books and display available books so that I can make use of the library’s resources  
- As a librarian, I want to add new books to the library's collection so that they can be available for borrowing  
- As a librarian, I want to remove books from the library's collection so that we can keep the collection up-to-date  
- As a librarian, I want to display a list of all the books in the library's collection so that users can easily find books they are interested in  

## Technologies Used
- C#  
- .NET Framework  
- Visual Studio  

## What I Learned
1. Single Responsibility Principle: each class is responsible for one specific task (e.g., the `Borrow` method is in the `Library` class and only called by the `RegularUser` class).  
2. Code Structure & Separation of Concerns: separating classes keeps the code architecture clean and avoids mixing responsibilities.  
3. Value Equality vs Reference Equality: since this is a console app without GUI, I compared objects based on their values instead of references.  
