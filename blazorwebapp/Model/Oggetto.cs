using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace blazorwebapp.Model
{
	public class Oggetto
	{
		public int Id { get; set; }

		public string? Name { get; set; }
		public string? Surname { get; set; }
		public string? Email { get; set; }
		public int? PhoneNumber { get; set; }

	}
}
