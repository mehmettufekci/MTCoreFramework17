﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MTFramework.Business.Abstract;

namespace MTFramework.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet(template: "getall")]
        public IActionResult GetList()
        {
            var result = _categoryService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet(template: "getbyid")]
        public IActionResult GetById(int categoryId)
        {
            var result = _categoryService.GetById(categoryId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        //[HttpPost(template: "add")]
        //public IActionResult Add(Category category)
        //{
        //    var result = _categoryService.Add(category);
        //    if (result.Success)
        //    {
        //        return Ok(result.Message);
        //    }

        //    return BadRequest(result.Message);
        //}

        //[HttpPost(template: "update")]
        //public IActionResult Update(Category category)
        //{
        //    var result = _categoryService.Update(category);
        //    if (result.Success)
        //    {
        //        return Ok(result.Message);
        //    }

        //    return BadRequest(result.Message);
        //}

        //[HttpPost(template: "delete")]
        //public IActionResult Delete(Category category)
        //{
        //    var result = _categoryService.Delete(category);
        //    if (result.Success)
        //    {
        //        return Ok(result.Message);
        //    }

        //    return BadRequest(result.Message);
        //}
    }
}