using System;
using System.Collections.Generic;
using System.Text;

namespace Services.CreateNews
{
  public  interface IParsUrlForRss
    {
        List<string> AddUrls();
    }
}
