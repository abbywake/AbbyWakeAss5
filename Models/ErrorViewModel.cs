using System;

namespace AbbyWakeAss5.Models
{
    public class ErrorViewModel
    {
        //An Error View Model so it sets a requestiD, and then it will show if that is the case. 
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
