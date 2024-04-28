#region Usings
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Dtos.Weapon;
#endregion

namespace dotnet_rpg.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeaponController : ControllerBase
    {
        #region Fields
        private readonly IWeaponService _weaponService;
        #endregion

        #region Ctor
        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }
        #endregion

        #region POST
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
        {
            return Ok(await _weaponService.AddWeapon(newWeapon));
        }
        #endregion
    }
}