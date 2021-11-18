namespace AC.Utils.Models
{
  public class ValidationInformation
  {
    public string? Message { get; set; }
    public ValidationResult Result { get; set; }
    public ValidationInformation(ValidationResult result, string message = "")
    {
      this.Result = result;
      this.Message = message;
    }
  }
}
