﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace DownloaderTests
{
    public class Class1
    {
        /// <summary>
        /// http://www.gummy-stuff.org/Yahoo-data.htm
        /// </summary>
        [Test]
        public void GetSomethingTest()
        {
            var webClient = new WebClient();
            var downloadString = webClient.DownloadString(@"http://finance.yahoo.com/d/quotes.csv?s=XOM+BBDb.TO+JNJ+MSFT&f=snd1l1yr");
        }




    }
}
