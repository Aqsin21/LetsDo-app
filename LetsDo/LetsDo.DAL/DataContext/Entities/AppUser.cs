using Microsoft.AspNetCore.Identity;
namespace LetsDo.DAL.DataContext.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? ProfilPictureUrl { get; set; }
       

    }
}
