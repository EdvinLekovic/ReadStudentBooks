import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faBookReader, faBrain, faMoneyBillWave } from "@fortawesome/free-solid-svg-icons";

export const Home = () => {
    return (
        <div>
            <div className="d-flex">
                <div className="w-50 d-flex flex-column shadow-lg">
                    <h3 className="text-dark text-center mt-5">Welcome to our student book page</h3>
                    <div className="m-auto">
                        <p className="text-break ms-3 me-3 ">We are offering to you to platform where you can be able to read books about the subjects you are listening in your school or faculty,
                            also for everyone wanting to improve their knowledge and bringing to another level. </p>
                    </div>
                </div>
                <img className="w-50" src="/reading-book.jpeg" alt="reading book" style={{ height: "500px" }} />
            </div>
            <div className="d-flex container" style={{marginTop:"100px"}}>
                <div className="d-flex flex-column" style={{width:"33.33%"}}>
                    <FontAwesomeIcon className="align-self-center" icon={faBookReader} style={{width:"100px",height:"100px"}}/>
                    <p className="text-break ms-5 me-5 mt-3 text-center">
                        This is the place to get better at your studies, improve your knowledge, 
                        and increase the chance to pass the exams
                    </p>
                </div>
                <div className="d-flex flex-column" style={{width:"33.33%"}}>
                    <FontAwesomeIcon className="align-self-center" icon={faBrain} style={{width:"100px",height:"100px"}}/>
                    <p className="text-break ms-5 me-5 mt-3 text-center">
                        With learning you are going to improve your mind and get better version of yourself.
                    </p>
                </div>
                <div className="d-flex flex-column" style={{width:"33.33%"}}>
                    <FontAwesomeIcon className="align-self-center" icon={faMoneyBillWave} style={{width:"100px",height:"100px"}}/>
                    <p className="text-break ms-5 me-5 mt-3 text-center">
                        While you posting the books you have and helping others, 
                        you have also great opportunity to earn some money.
                    </p>
                </div>
            </div>
        </div>
    );
}