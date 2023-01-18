export const Filter = () => {
    return (
        <div className="d-flex flex-column rounded ms-2"
        style={{ backgroundColor: "#DCDCDC", width: '370px', height: "400px" }}>
        <h3 className="text-center mt-2">Filtering the books</h3>
        <div className="ms-3 me-3 mt-5">
            <div>
                <h4>Search the books</h4>
                <input className="form-control" type={"text"} />
            </div>
            <div className="mt-5">
                <h4>Price range of books</h4>
                <div className="d-flex">
                    <div className="d-flex">
                        <h5 className="align-self-center">From:</h5>
                        <input className="form-control w-50" type={"number"} />
                    </div>
                    <div className="d-flex">
                        <h5 className="align-self-center">To:</h5>
                        <input className="form-control w-50" type={"number"} />
                    </div>
                </div>
            </div>
        </div>
    </div>
    );
}