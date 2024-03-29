﻿using BusinessLayer.Repository;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthorsController : ODataController
    {
        private BookDbContext _dbContext;
        private AuthorRepostiory _repo; 

        public AuthorsController(BookDbContext dbContext)
        {
            _dbContext = dbContext;
            _repo = new AuthorRepostiory(_dbContext);
        }
        [EnableQuery]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.Get());
        }

        [EnableQuery]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repo.GetById(id));
        }

        [EnableQuery]
        [HttpPost]
        public void Post([FromBody] Author author)
        {
            _repo.Get();
            _repo.Add(author);
            _dbContext.SaveChanges();
        }

        [HttpPut("{id}")]
        [EnableQuery]
        public void Put(int id, [FromBody] Author author)
        {
            _repo.Update(author);
            _dbContext.SaveChanges();
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
