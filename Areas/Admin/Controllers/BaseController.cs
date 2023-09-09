using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;

namespace MyFurnitureShop.Areas.Admin.Controllers
{
    using static MyFurnitureShop.Areas.Admin.Constants.AdminConstants;

    [Area(AreaName)]
    [Route("Admin/[controller]/[Action]/{id}")]
    [Authorize(Roles = AdminRollName)]

    public class BaseController : Controller
    {

    }
}
