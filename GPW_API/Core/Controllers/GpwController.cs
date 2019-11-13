﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GPW_API.App_Start;
using GPW_API.Core.Dtos;
using GPW_API.Core.Models;
using GPW_API.DataAccess;
using GPW_API.DataAccess.References;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GPW_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GpwController : ControllerBase
    {

        private GpwContext _context;


        MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new MappingProfile());
        });

        public GpwController()
        {
            _context = new GpwContext();
        }

        [HttpGet]
        public ActionResult<List<GpwCompany>> Get()
        {
            return Ok(_context.gpwCompanies.ToList());
        }
    }
}
