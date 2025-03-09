namespace MVC.Models
{
    public class BaseModels
    {
        public bool IsActive { get; set; }
        public string CreateBy { get; set; }
        public DateTime Created { get; set; }
        public string? EditeBy { get; set; }
        public DateTime? Edited { get; set; }
    }
}
