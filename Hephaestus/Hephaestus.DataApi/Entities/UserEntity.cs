using Microsoft.AspNetCore.Identity;

namespace Hephaestus.DataApi.Entities
{
    public class UserEntity : IdentityUser<Guid>
    {
        public string Role {  get; set; }       
    }
}
