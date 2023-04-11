using Microsoft.AspNetCore.Mvc;
using ShopOnline2022.Models;
using System.Collections.Generic;

namespace ShopOnline2022.ViewComponents
{
    public class PagingDataSource
    {
        public string PageFirstUrl { get; set; }
        public string PageLastUrl { get; set; }
        public string PageBackUrl { get; set; }
        public string PageNextUrl { get; set; }
        public Dictionary<int, string> PageNumbers { get; set; }
        public int Page { get; set; }
    }

    public class vcPaging : ViewComponent
    {
        public IViewComponentResult Invoke(int totals, int pageSize, int page, string url)
        {
            int totalPages = (int)Math.Ceiling((double)totals / pageSize);
            int pageFirst = 1;
            int pageLast = totalPages;

            int pageBack = page - 1;
            if (pageBack == 0)
                pageBack = 1;

            int pageNext = page + 1;
            if(pageNext > pageLast)
                pageNext = pageLast;

            string pageFirstUrl = string.Format(url, pageFirst);
            string pageLastUrl = string.Format(url, pageLast);
            string pageBackUrl = string.Format(url, pageBack);
            string pageNextUrl = string.Format(url, pageNext);

            Dictionary<int, string> pageNumbers = new Dictionary<int, string>();
            for (int i = pageFirst; i <= pageLast; i++)
            {
                pageNumbers.Add(i, string.Format(url, i));
            }

            //Build 1 obj chứa cả 5 dữ liệu này để trả về cho view
            PagingDataSource data = new PagingDataSource();
            data.PageFirstUrl = pageFirstUrl;
            data.PageLastUrl  = pageLastUrl;
            data.PageBackUrl  = pageBackUrl;
            data.PageNextUrl  = pageNextUrl;
            data.PageNumbers  = pageNumbers;
            data.Page         = page;

            return View(data);
        }
    }
}
