import { Link } from "react-router-dom";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faBookOpen } from "@fortawesome/free-solid-svg-icons";
export const Footer = () => {
    return (
        <footer className="bg-dark text-white py-3 mt-5 align-content-end bottom-0 w-100">
            <div className="container">
                <div className="row justify-content-between">
                    <div className="col-md-3">
                        <h5>Links</h5>
                        <ul className="list-unstyled">
                            <li><Link className="text-white" to={"/"}>Home</Link></li>
                            <li><Link className="text-white" to={"/books"}>Books</Link></li>
                            <li><Link className="text-white" to={"/about-us"}>About Us</Link></li>
                        </ul>
                    </div>
                    <div className="col-md-3 d-flex text-secondary">
                        <FontAwesomeIcon className="" icon={faBookOpen} style={{width:"100px",height:"100px"}}/>
                        <div className="ms-3 mt-2">
                        <h5 className="text-break w-50">Read Student Books</h5>
                        </div>
                    </div>
                    <div className="col-md-3 text-white">
                        <h5>Contact</h5>
                        <p>
                            123 Main Street<br />
                            Koper, Slovenia 12345<br />
                            <a className="text-white" href="#">readstudentbooks@readstudentbooks.com</a>
                        </p>
                    </div>
                </div>
            </div>
        </footer>
    );
}