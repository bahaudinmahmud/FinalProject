﻿namespace TrollMarket.Presentation.Web.Models
{
    public class PaginationInfoViewModel
    {
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int PageNumber { get; set; }
        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling((double)TotalItems / PageSize);
            }
        }
    }
}
