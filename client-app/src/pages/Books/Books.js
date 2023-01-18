import {Filter} from "../../components/Filter";
import {Book} from "../../components/Book";
import {
    Button,
    CloseButton,
    Modal,
    ModalBody,
    ModalFooter,
    ModalHeader,
    ModalTitle
} from "react-bootstrap";
import {useState} from "react";

export const Books = (props) => {

    const [show, setShow] = useState(false);
    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);

    return (
        <div className={"d-flex ms-2 mt-2"}>
            <Filter/>
            <div className="d-flex flex-column ms-2 mt-2">
                <Button className={"ms-3 btn btn-primary w-25"} onClick={handleShow}>Add books here</Button>
                <div className="ms-3 d-flex flex-wrap mt-3">
                    {props.books.map(book =>
                        <Book key={book.id} book={book} getBook={props.getBook}/>
                    )}
                </div>
            </div>
            <Modal show={show} onHide={handleClose}>
                <ModalHeader><CloseButton onClick={handleClose}></CloseButton></ModalHeader>
                <ModalTitle>
                    <h1 className={"text-center mt-2"}>Add new book</h1>
                </ModalTitle>
                <ModalBody>
                    <label>Title:</label>
                    <input type={"text"} className={"form-control"}/>
                    <label>Author:</label>
                    <input type={"text"} className={"form-control"}/>
                    <label>Description:</label>
                    <textarea className={"form-control"}/>
                    <label>Book file:</label>
                    <input type={"file"} className={"form-control"}/>
                    <label>Book image:</label>
                    <input type={"file"} className={"form-control"}/>
                    <label>Price:</label>
                    <input type={"number"} className={"form-control"}/>
                </ModalBody>
                <ModalFooter>
                    <button className={"btn btn-primary"}>Add new book</button>
                </ModalFooter>
            </Modal>

        </div>
    );
}