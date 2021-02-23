using System;

namespace CheckboxDemo.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class CheckboxViewModel
    {
        public string Name { get; set; }
        public bool IsAwesome { get; set; }
    }
}
