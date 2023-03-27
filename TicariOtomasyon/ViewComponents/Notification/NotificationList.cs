﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicariOtomasyon.ViewComponents.Notification
{
    public class NotificationList : ViewComponent
    {
        NotificationManager nm = new NotificationManager(new EfNotificationRepository());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            var values = c.Notifications.OrderBy(x => x.NotificationDate).Skip(Math.Max(0, c.Notifications.Count() - 3)).ToList();
            return View(values);
        }
    }
}
