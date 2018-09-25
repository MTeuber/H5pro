﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace H5pro.Controllers
{
    public class CreateUserController : Controller
    {
        // GET: 
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult index(User user)
        {
            if(ModelState.IsValid)
            {
                DataClassDataContext db = new DataClassDataContext();
                db.Users.InsertOnSubmit(user);
                db.Users.Context.SubmitChanges();
                
            }

            return View();
        }
    }
}