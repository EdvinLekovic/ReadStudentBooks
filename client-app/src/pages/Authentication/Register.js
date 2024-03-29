import {Link, useHistory} from "react-router-dom";
import {useState} from "react";

export const Register = (props) => {

    // const history = useHistory();
    const [formData, updateFormData] = useState({
        username:"",
        name: "",
        lastname: "",
        password: "",
        repeatPassword: ""
    });

    const handleChange = (e) => {
        updateFormData({
            ...formData,
            [e.target.name]: e.target.value.trim()
        })
    }

    const onFormSubmit = (e) => {
        e.preventDefault();
        const username = formData.username;
        const name = formData.name;
        const lastname = formData.lastname;
        const password = formData.password;
        const repeatPassword = formData.repeatPassword;

        register(username,name,lastname,password,repeatPassword);
        //history.push("/login")
    }

    const register = (username,name,lastname,password,repeatPassword) => {
        // userRepository
        //     .register(username,
        //         name,
        //         lastname,
        //         password,
        //         repeatPassword);
    }


    return (
        <div className="d-flex pt-5 mt-5">
            <div className="d-flex flex-column shadow-lg p-3 mb-5 bg-body rounded w-25 m-auto ">
                <div className="border-bottom">
                    <h3>Register</h3>
                </div>
                <form className="d-flex flex-column justify-content-center" onSubmit={onFormSubmit}>
                    <input type="text"
                           id="username"
                           name={"username"}
                           required
                           className="form-control mt-3"
                           placeholder={"Username"}
                           onChange={handleChange}/>

                    <input type="text"
                           id="name"
                           name={"name"}
                           required
                           className="form-control mt-3"
                           placeholder={"Name"}
                           onChange={handleChange}/>

                    <input type="text"
                           id="lastname"
                           name={"lastname"}
                           required
                           className="form-control mt-3"
                           placeholder={"Lastname"}
                           onChange={handleChange}/>

                    <input type="password"
                           id="password"
                           name={"password"}
                           required
                           className="form-control mt-3"
                           placeholder={"Password"}
                           onChange={handleChange}/>

                    <input type="password"
                           id="repeatPassword"
                           name={"repeatPassword"}
                           required
                           className="form-control mt-3"
                           placeholder={"Repeat Password"}
                           onChange={handleChange}/>

                    <button type="submit"
                            className="btn btn-dark w-100 mt-3">Sign up
                    </button>
                </form>
                <Link className="text-dark text-center mt-3" to={"/login"}>Already have an account?</Link>
            </div>
        </div>
    )

}