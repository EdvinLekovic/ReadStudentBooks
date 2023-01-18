import {Link} from "react-router-dom";

export const Book = (props) => {
    return (
        <Link className="mt-2 d-flex flex-column shadow-lg shadow rounded me-2 mb-2 text-dark text-decoration-none"
              onClick={() => props.getBook(props.book.id)}
              to={`/books/info/${props.book.id}`}>
            <img className="border" src={`/${props.book.image}`} style={{width: "250px", height: "350px"}}/>
            <div className="d-flex flex-column" style={{width: "250px"}}>
                <h4 className={"text-break"}>Title: <br/> {props.book.title}</h4>
                <h5 className={"text-break"}>Author: <br/>  {props.book.author}</h5>
                <h4 className="mt-3">Price: <br/>  ${props.book.price}</h4>
            </div>
        </Link>
    );
}