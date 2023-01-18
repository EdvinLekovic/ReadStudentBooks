import {Document, Outline, Page, pdfjs} from "react-pdf";
import {useState} from "react";
pdfjs.GlobalWorkerOptions.workerSrc = `//cdnjs.cloudflare.com/ajax/libs/pdf.js/${pdfjs.version}/pdf.worker.min.js`;
export const BookViewer = () => {
    const [numPages, setNumPages] = useState(1);
    const [pageNumber, setPageNumber] = useState(1);

    function onDocumentLoadSuccess({ numPages }) {
        setNumPages(numPages);
        setPageNumber(1);
    }

    function onItemClick({ pageNumber: itemPageNumber }) {
        setPageNumber(itemPageNumber);
    }

    function changePage(offset) {
        setPageNumber(prevPageNumber => prevPageNumber + offset);
    }

    function previousPage() {
        changePage(-1);
    }

    function nextPage() {
        changePage(1);
    }

    return (
        <div className={"d-flex justify-content-center mt-3"}>
            <Document className={"h-50 border"} file={"Calculus_Early_Transcendentals_8th_Editi.pdf"}
                      onLoadSuccess={onDocumentLoadSuccess}
                      style={{height:"500px"}}>
                <Page pageNumber={pageNumber}/>
            </Document>
            <div className={'ms-2 d-flex flex-column'}>
                <p>
                    Page {pageNumber || (numPages ? 1 : '--')} of {numPages || '--'}
                </p>
                <button
                    className={"btn btn-dark"}
                    type="button"
                    disabled={pageNumber <= 1}
                    onClick={previousPage}>
                    Previous
                </button>
                <button
                    className={"btn btn-dark mt-1"}
                    type="button"
                    disabled={pageNumber >= numPages}
                    onClick={nextPage}>
                    Next
                </button>
            </div>
        </div>
    );
}