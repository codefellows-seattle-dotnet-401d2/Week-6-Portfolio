﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Environment;

namespace Portfolio.Models
{
    public class Projects
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Technologies { get; set; }

        public string ImageUrl { get; set; }

        public byte[] Image { get; set; }

        public IEnumerable<string> ProjectList
        {
            get { return (Technologies ?? String.Empty).Split(); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /*
        public string GetInlineImageSrc()
        {

        }
        */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        public void SetImage(Microsoft.AspNetCore.Http.IFormFile file)
        {

        }
    }
}
