using System;

namespace KlasyGeneryczneSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            var response = new ApiResponse<DateTime>();
            var response2 = new ApiResponse<string>();
            var response3 = new ApiResponse<bool>();
            
            //...
            if (response.Succedded)
            {
                var date = response.Response;
            }
            else
            {
                var error = response.ErrorMessage;

                Console.WriteLine(error);
            }
        }
    }

    public class ApiResponse<T>
    {
        public T Response { get; set; }
        public string ErrorMessage { get; set; }

        public bool Succedded { get; set; }
    }

    /*public class ApiResponse2            // bez sensu, kopiuj wklej unikamy!
    {
        public string UserName { get; set; }
        public string ErrorMessage { get; set; }

        public bool Succedded { get; set; }
    }*/
}
