using System;
using System.Collections.Generic;
using System.Text;
using Services.CreateNews;
using Services.UoW;

namespace Services.Hangfire
{
    interface IHangfireNews
    {
       void  TaskNewsAddStart() ;
    }
}
