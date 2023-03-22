using System.ComponentModel.DataAnnotations;

namespace HelloTask.ViewModels
{
	public class HelloHomeViewModel
	{
		[Required(ErrorMessage = "Name is required.")]
		[MinLength(2, ErrorMessage = "The first name must be at least {1} characters")]
		public string Name { get; set; }
	}
}
