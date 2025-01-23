**Library Management System**
This is a console-based Library Management System implemented in C#. The system demonstrates core Object-Oriented Programming (OOP) principles, adherence to SOLID principles, and the use of design patterns like Singleton and Factory. It provides functionalities to efficiently manage both physical books and eBooks, allowing users to add, remove, search, and list library items.





**Features**

**Add Books and eBooks**: Users can add new books or eBooks with detailed attributes such as title, author, publication year, ISBN, and more.

**Remove Books:** Books and eBooks can be removed from the library using their unique identifiers.

**Search Books:** Search for books by attributes such as title, author, or ISBN.

**List Books:** Display all books, categorized into physical books and eBooks for easy navigation.





**Core Concepts and Principles**

**Object-Oriented Programming (OOP)**

**Encapsulation:** Book data is protected within classes to ensure data integrity.

**Inheritance:** Common attributes are encapsulated in a base Book class, extended by PhysicalBook and EBook subclasses.

**Polymorphism:** Methods like DisplayDetails are overridden to provide specific functionality for each book type.

**Abstraction:** Abstract classes and interfaces define the common behaviors without exposing implementation details.






**SOLID Principles**

**Single Responsibility Principle (SRP):** Each class handles a single responsibility, making the code easy to maintain.

**Open/Closed Principle (OCP):** The system can be extended without modifying existing code.

**Liskov Substitution Principle (LSP):** Subclasses (PhysicalBook, EBook) can replace the base Book class seamlessly.

**Interface Segregation Principle (ISP):** Interfaces are lean and tailored to their specific use cases.

**Dependency Inversion Principle (DIP):** High-level modules depend on abstractions rather than low-level modules.





