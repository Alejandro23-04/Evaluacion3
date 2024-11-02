namespace Evaluacion3.Models
{
    public class ErrorViewModelxxx
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
