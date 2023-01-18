import {Link} from "react-router-dom";
import {FontAwesomeIcon} from "@fortawesome/react-fontawesome";
import {faBookOpen} from "@fortawesome/free-solid-svg-icons";

export const Header = () => {

    const userLogged = false;

    return (
        <nav className="navbar navbar-expand-lg" style={{backgroundColor: "#f8f8ff"}}>
            <div className="container-fluid">
                <Link className="navbar-brand" to={"/"}>
                    <FontAwesomeIcon className="me-2" icon={faBookOpen}/>
                    Read Student Books
                </Link>
                <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarText"
                        aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
                    <span className="navbar-toggler-icon"></span>
                </button>
                <div className="collapse navbar-collapse" id="navbarText">
                    <ul className="navbar-nav me-auto mb-2 mb-lg-0">
                        <li className="nav-item">
                            <Link className="nav-link" aria-current="page" to={"/"}>Home</Link>
                        </li>
                        <li className="nav-item">
                            <Link className="nav-link" to={"/books"}>Book Store</Link>
                        </li>
                        <li className="nav-item">
                            <Link className="nav-link" to={"/about-us"}>About Us</Link>
                        </li>
                    </ul>
                </div>
                <div>
                    {
                        userLogged
                            ? <div className={"d-flex"}>
                                <div
                                    className="d-flex bg-secondary rounded-circle justify-content-center me-1"
                                    style={{width: "25px", height: "25px", color: "lightgray"}}>
                                    <h5 className="text-center">E</h5>
                                </div>
                                <Link className={"text-decoration-none text-dark"}>edvin12</Link>
                            </div>
                            : <Link className={"btn btn-outline-dark"} to={"/login"}>Login</Link>
                    }
                </div>
            </div>
        </nav>
    );
}