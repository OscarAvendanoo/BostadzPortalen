namespace BostadzPortalenClient.Models
{
    // Author: Oscar
    public class Response<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string ValidationErrors { get; set; }
        public T Data { get; set; }
    }
}
