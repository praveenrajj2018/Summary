﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LXP.Core.IServices;

namespace LXP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseLevelController : BaseController
    {
        private readonly ICourseLevelServices _courseLevelServices;
        public CourseLevelController(ICourseLevelServices courseLevelServices) { 
         this._courseLevelServices = courseLevelServices;
        }
        ///<response code="200">Success</response>
        ///<response code="500">Internal server Error</response>
        [HttpGet("/lxp/course/courselevel/{accessedBy}")]
        public async Task<IActionResult> GetAllCourseLevel(string accessedBy)
        {
            return Ok(CreateSuccessResponse(await _courseLevelServices.GetAllCourseLevel(accessedBy)));
        }
    }
}
