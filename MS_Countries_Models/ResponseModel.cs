namespace MS_Countries_Models
{
    public class ResponseModel
    {
        public object Data { get; set; }
        public bool Status { get; set; }
        public int StutusCode { get; set; }
        public string Message { get; set; }

        public ResponseModel() {
            Data = new object();
            Status = false;
            StutusCode = 500;
            Message = "Algo salio mal";
        }
    }
}
