import {Component} from "react";
import {Route, BrowserRouter as Router, Routes, Navigate} from "react-router-dom";
import {Footer} from "../components/Footer";
import {Header} from '../components/Header';
import {Books} from "../pages/Books/Books";
import {Home} from "../pages/Home";
import './App.css';
import {BooksInfo} from "../pages/Books/BooksInfo";
import {AboutUs} from "../pages/AboutUs";
import {Login} from "../pages/Authentication/Login";
import {Register} from "../pages/Authentication/Register";
import {BookViewer} from "../components/BookViewer";

class App extends Component {

    constructor(props) {
        super(props);

        this.state = {
            books: [
                {
                    id: 1,
                    title: "Computer networks",
                    author: "Andrew Tanenbaum",
                    price: 29,
                    yearRelease: 2015,
                    image: "computer-networks-book.jpg",
                    numPages: 667,
                    description: "\"Computer Networks\" by Andrew Tanenbaum is a comprehensive guide to the fundamentals of computer networking. This book covers a wide range of topics, including the physical and data link layers, network protocols, and topologies. The text is well-written and easy to understand, making it an excellent resource for both students and professionals in the field. The book includes numerous examples, diagrams, and exercises to help readers understand the concepts and apply them to real-world situations. Overall, \"Computer Networks\" by Andrew Tanenbaum is a must-have for anyone looking to gain a solid understanding of computer networking."
                },
                {
                    id: 2,
                    title: "Psychokibernetics",
                    author: "Maxwell Maltz",
                    price: 20,
                    yearRelease: 1960,
                    image: "book-psychokibernetics.jpg",
                    numPages: 283,
                    description: "\"Psycho-Cybernetics\" by Maxwell Maltz is a classic self-help book that explores the connection between the human mind and the functioning of a cybernetic system. The book is based on the idea that our self-image, or the way we see ourselves, plays a crucial role in our ability to achieve our goals and improve our lives. Maltz provides practical techniques and exercises to help readers change their self-image and develop a more positive outlook on life. He also explains how the principles of cybernetics can be applied to personal growth and success. The book has been widely popular since its first publication in 1960 and continues to be a reference in the self-help and personal development industry. Overall, \"Psycho-Cybernetics\" by Maxwell Maltz is a valuable guide for anyone looking to improve their self-image and achieve their goals."
                },
                {
                    id: 3,
                    title: "Distributed Systems",
                    author: "Andrew Tanenbaum",
                    price: 39,
                    yearRelease: 2017,
                    image: "distributed-systems-book.png",
                    numPages: 750,
                    description: "\"Distributed Systems: Principles and Paradigms\" by Andrew Tanenbaum and Maarten van Steen is a comprehensive textbook that covers the fundamental concepts and principles of distributed systems. The book is divided into two parts, with the first part focusing on the basic concepts of distributed systems, such as communication, coordination, and replication, while the second part covers more advanced topics, such as distributed algorithms, fault tolerance, and security. The book is written in a clear and accessible style, making it suitable for both students and professionals. It includes numerous examples, diagrams, and exercises to help readers understand the concepts and apply them to real-world situations. With its broad coverage of the field and its focus on both theory and practice, \"Distributed Systems: Principles and Paradigms\" by Andrew Tanenbaum and Maarten van Steen is an essential resource for anyone interested in distributed systems."
                },
                {
                    id: 4,
                    title: "Calculus",
                    author: "James Steward",
                    price: 45,
                    yearRelease: 2008,
                    image: "calculus-book.jpg",
                    numPages: 1180,
                    description: "\"Calculus\" by James Steward is a comprehensive textbook that covers all the essential concepts of calculus. The book is designed for students taking a first course in calculus and covers topics such as limits, derivatives, and integrals. The book also includes numerous worked-out examples, exercises, and applications to help students understand the concepts and solve problems. James Steward's writing style is clear, concise and easy to follow, making it accessible to students of all levels. The book also includes a number of helpful features such as summary of key points, review questions and self-test exercises to help students assess their understanding of the material. Overall, \"Calculus\" by James Steward is a comprehensive and accessible introduction to the subject and it is highly recommended for students and instructors alike."
                },
                {
                    id: 5,
                    title: "Discrete mathematics",
                    author: "P. Arunachalam",
                    price: 37,
                    yearRelease: 2012,
                    image: "discrete-mathematics-book.jpg",
                    numPages: 874,
                    description: "\"Discrete Mathematics\" by Arunachalam is a comprehensive textbook that covers the fundamental concepts of discrete mathematics. The book is designed for students taking a first course in the subject and covers a wide range of topics including propositional and predicate logic, set theory, relations, functions, graph theory, and combinatorics. The book is written in a clear and accessible style and includes numerous examples, exercises, and applications to help students understand the concepts and solve problems. The author also includes some historical background of the topic to give context to the students. The book also includes a number of helpful features such as summaries, review questions and practice exercises to help students assess their understanding of the material. Overall, \"Discrete Mathematics\" by Arunachalam is an excellent resource for students and instructors who are new to the subject, and it is highly recommended for anyone looking to gain a solid understanding of discrete mathematics."
                }
            ],
            book: {}
        }
    }

    render() {
        return (
            <Router>
                <Header/>
                <Routes>
                    <Route path="*" element={<Navigate to="/" replace/>}/>
                    <Route path="/" element={<Home/>}/>
                    <Route path="/books" element={<Books books={this.state.books} getBook={this.getBook}/>}/>
                    <Route path="/books/info/:id" element={<BooksInfo book={this.state.book}/>}/>
                    <Route path="/about-us" element={<AboutUs/>}/>
                    <Route path="/login" element={<Login/>}/>
                    <Route path="/register" element={<Register/>}/>
                    <Route path={"/book-view"} element={<BookViewer/>}/>
                </Routes>
                <Footer/>
            </Router>
        );
    }

    getBook = (bookId) => {
        let book = this.state.books.find(book => book.id === bookId);
        this.setState({
            book: book
        })
    }
}

export default App;
