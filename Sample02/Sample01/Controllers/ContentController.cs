using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sample01.Models;

namespace Sample01.Controllers
{
    public class ContentController : Controller
    {

        private readonly Content contents;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="option">这里创建IOptions<Content> option 这个对象的东西就是容器.</param>
        public ContentController(IOptions<Content> option)
        {
            contents = option.Value;
        }

        public IActionResult Index()
        {
            //var contents = new List<Content>();
            //for (int i = 1; i < 11; i++)
            //{
            //    contents.Add(new Content { Id = i, title = $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-i) });
            //}
            //return View(new ContentViewModel { Contents = contents });

            return View(new ContentViewModel { Contents = new List<Content> { contents } });
        }
    }
}