using System.ComponentModel.DataAnnotations;

namespace SmartShades.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}