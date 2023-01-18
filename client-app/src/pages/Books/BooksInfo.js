import {Button, Modal, ModalBody, ModalFooter, ModalTitle} from "react-bootstrap";
import {useState} from "react";
import {Link} from "react-router-dom";


export const BooksInfo = (props) => {
    const [show, setShow] = useState(false);
    const [, setSelectedTransaction] = useState('');
    const bookIsBuyed = false;

    const selectTransactionToByWith = (event) => {
        setSelectedTransaction(event.target.value);
    }

    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);

    return (
        <div className={"container ms-5 me-5"}>
            <div className={"d-flex align-items-center"}>
                <div className="d-flex flex-column w-50 mt-5" style={{height: "500px"}}>
                    <div className={"d-flex flex-column justify-content-center"}>
                        <h2 className={"text-center"}>Title: {props.book.title}</h2>
                        <h3 className={"text-center"}>Author: {props.book.author}</h3>
                    </div>
                    <div className={"m-auto text-center"}>
                        <h3>Number of pages: {props.book.numPages}</h3>
                        <h3>Year of release: {props.book.yearRelease}</h3>
                    </div>
                </div>
                <div className={"d-flex flex-column w-50 mt-3"} style={{height: "500px"}}>
                    <img className={"m-auto text-center"} src={`/${props.book.image}`} alt=""
                         style={{width: "350px", height: "500px"}}/>
                    <div className={"d-flex mt-2"}>
                        <div className={"m-auto w-50 text-center"}>
                            <div className={"btn-group"}>
                            {bookIsBuyed
                                ? <Button className={"w-100"} variant={"secondary"} onClick={handleShow}>Buy book
                                    now</Button>
                                : <Link className={"w-100 btn btn-secondary"} to={"/book-view"}>Read the book</Link>
                            }
                                <button type="button" className="btn btn-secondary dropdown-toggle dropdown-toggle-split"
                                        data-bs-toggle="dropdown" aria-expanded="false" data-bs-reference="parent">
                                    <span className="visually-hidden">Toggle Dropdown</span>
                                </button>
                                <ul className="dropdown-menu dropdown-menu-dark">
                                    <li><a className="dropdown-item active" onClick={handleClose}>Edit</a>
                                </li>
                                <li><a className="dropdown-item" onClick={handleClose}>Delete</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
</div>
    <div className={"bg-light mt-5 d-flex flex-column align-items-center"} style={{height: "200px"}}>
        <h3 className={"mt-3 mb-3"}>Description of the book</h3>
        <p className={"text-break text-center"}>
            {props.book.description}
        </p>
    </div>
    <Modal show={show} onHide={handleClose}>
        <ModalTitle>
            <h1 className={"text-center mt-3"}>Buy new book</h1>
        </ModalTitle>
        <ModalBody>
            <div className="d-flex flex-column">
                <div className="d-flex align-self-center">
                    <h5>Personal info</h5>
                </div>
                <div className="d-flex flex-column mt-2">
                    <label>Name:</label>
                    <input type="text" className="form-control" required placeholder="Enter your name"
                           name={"name"}/>
                </div>
                <div className="d-flex flex-column mt-2">
                    <label>Lastname:</label>
                    <input type="text" className="form-control" required placeholder="Enter your lastname"
                           name={"lastName"}/>
                </div>
                <div className="d-flex align-self-center mt-4">
                    <h5>Payment info</h5>
                </div>
                <button
                    className={`btn btn-outline-dark mb-1 d-flex justify-content-between m-auto`}
                    style={{width: "68%"}}
                    onChange={selectTransactionToByWith}>
                    <div className="d-flex m-auto">
                        <div className="d-flex">
                            <img src="/credit-card.png" style={{width: "50px", height: "50px"}} alt="img"/>
                        </div>
                        <div className="ms-2 d-flex flex-column">
                            <small className="text-muted">Card
                                number: 1111 2222 3333 4444</small>
                            <small className="text-muted">Expiration date:
                                10/2023</small>
                        </div>
                    </div>
                </button>
                <div className="d-flex flex-column w-25 m-auto">
                    <label>CVV:</label>
                    <input type="text"
                           className="form-control"
                           required
                           placeholder="ex. 414"/>
                </div>
                <div className="d-flex mt-4 m-auto">
                    <button className="btn btn-outline-dark" type="button" data-bs-toggle="collapse"
                            data-bs-target="#multiCollapseExample1" aria-expanded="false"
                            aria-controls="multiCollapseExample1">Add Credit Card
                    </button>
                </div>
                <div className="col mt-2">
                    <div className="collapse multi-collapse" id="multiCollapseExample1">
                        <div className="card card-body">
                            <div className="d-flex flex-column">
                                <div className="d-flex flex-column mt-2">
                                    <label>Transactional card number:</label>
                                    <input type="text"
                                           className="form-control"
                                           required
                                           placeholder="Enter transactional number"
                                           name={"transactionalNumber"}/>
                                </div>
                                <div className="d-flex mt-2 justify-content-between">
                                    <div className="d-flex flex-column">
                                        <label>Expiration Date:</label>
                                        <div className="d-flex">
                                            <input type="number"
                                                   className="form-control w-25 me-2"
                                                   required
                                                   placeholder="MM"
                                                   name={"expirationMonth"}/>
                                            <input type="number"
                                                   className="form-control w-25"
                                                   required
                                                   placeholder="YYYY"
                                                   name={"expirationYear"}/>
                                        </div>
                                    </div>
                                    <div className="d-flex flex-column w-25">
                                        <label>CVV:</label>
                                        <input type="text"
                                               className="form-control"
                                               required
                                               placeholder="ex. 414"
                                               name={"cvvCode"}/>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ModalBody>
        <ModalFooter>
            <Button variant={"btn btn-primary"} onClick={handleClose}>Buy new book</Button>
        </ModalFooter>
    </Modal>
</div>
)
    ;
}