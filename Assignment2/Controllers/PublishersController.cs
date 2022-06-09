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
    public class PublishersController : ODataController
    {
        private BookDbContext _dbContext;
        private PublisherRepository _repo; 

        public PublishersController(BookDbContext dbContext)
        {
            _dbContext = dbContext;
            _repo = new PublisherRepository(_dbContext);
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
        public void Post([FromBody] Publisher publisher)
        {
            _repo.Get();
            _repo.Add(publisher);
            _dbContext.SaveChanges();
        }

        [HttpPut("{id}")]
        [EnableQuery]
        public void Put(int id, [FromBody] Publisher publisher)
        {
            _repo.Update(publisher);
            _dbContext.SaveChanges();
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
