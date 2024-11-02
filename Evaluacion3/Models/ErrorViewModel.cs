namespace Evaluacion3.Models
{
    public class ErrorViewModelxxxs
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
