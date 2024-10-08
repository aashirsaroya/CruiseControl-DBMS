# **CruiseControl-DBMS**

A basic cruise ship management system built as part of a database systems class project. This application was developed using **Visual Studio C#** and **MySQL**, featuring user authentication, password recovery, and payment options, all backed by a normalized database schema.

## **Features**
- **User Authentication**: Secure login system with MySQL storing email IDs as usernames and encrypted passwords.
- **Password Recovery**: Allows users to reset their password via email recovery.
- **Payment Options**: Integrated logic to handle basic payment functionalities.
- **Database Normalization**: Schema designed to eliminate redundancy and ensure data integrity through table normalization.

## **Tech Stack**
- **Visual Studio C#**: For building the user interface and application logic.
- **MySQL**: Used for database management, ensuring efficient data storage and retrieval.

## **Installation**
To run this project locally:

1. Clone the repository:
    ```bash
    git clone https://github.com/aashirsaroya/CruiseControl-DBMS
    ```
2. Open the project in **Visual Studio**.
3. Set up the **MySQL** database:
    - Import the provided `.sql` file into your MySQL server to set up the required tables and data.
4. Configure the connection string in the application to point to your MySQL database.
5. Run the project in **Visual Studio**.

## **Usage**
- Register or log in using your email as the username.
- Recover forgotten passwords via the password recovery feature.
- Test the payment options by navigating through the cruise booking process.

