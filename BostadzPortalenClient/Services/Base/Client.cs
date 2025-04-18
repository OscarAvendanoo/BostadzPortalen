namespace BostadzPortalenClient.Services.Base
{
    public partial class Client : IClient
    {
        //Author: ALL
        public HttpClient HttpClient
        {
            get
            {
                return HttpClient;
            }
        }
    }
}
