export const AboutUs = () => {
    return (
        <div className={"mt-1 d-flex flex-column container align-items-center"}
             style={{paddingLeft: "15rem", paddingRight: "15rem"}}>
            <h1 className>About Us</h1>
            <div className={"mt-5 d-flex align-content-around w-100"}>
                <img src="/aboutUs1.jpg" style={{width: "300px", height: "250px"}}/>
                <p>
                    Welcome to Read Student Books!
                    We are a team of educators and book lovers who are passionate about making knowledge accessible to all.
                    <br/>
                    Founded with the belief that education should be a right, not a privilege,
                    we have dedicated ourselves to providing students with the resources they need to succeed in their studies.
                    Our collection includes a wide range of academic books and materials,
                    covering subjects such as science, math, history, literature, and more.
                </p>
            </div>
            <div className={"d-flex align-content-around w-100"}>
                <p>
                    At Read Student Books, we believe that everyone should have access to quality education,
                    regardless of their circumstances.
                    That's why we also offer our resources online,
                    so that every student can have the chance to learn and grow.
                    <br/>
                    Thank you for choosing Read Student Books.
                    We hope that you will find our resources helpful and
                    informative as you pursue your academic goals.
                </p>
                <img src="/aboutUs2.png" style={{width: "300px", height: "300px"}}/>
            </div>
        </div>
    );
}