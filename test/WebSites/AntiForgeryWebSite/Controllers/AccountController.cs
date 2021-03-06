﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Mvc;

namespace AntiForgeryWebSite
{
    // This controller is reachable via traditional routing.
    public class AccountController : Controller
    {
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl = null)
        {
            ViewBag.ReturnUrl = returnUrl;

            return View();
        }

        [AllowAnonymous]
        public string UseFacebookLogin()
        {
            return "somestring";
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public string Login(LoginViewModel model)
        {
            return "OK";
        }

        // GET: /Account/FlushAsyncLogin
        [AllowAnonymous]
        public ActionResult FlushAsyncLogin(string returnUrl = null)
        {
            ViewBag.ReturnUrl = returnUrl;

            return View();
        }

        // POST: /Account/FlushAsyncLogin
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public string FlushAsyncLogin(LoginViewModel model)
        {
            return "OK";
        }
    }
}