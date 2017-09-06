﻿using System.Collections.Generic;
using Nop.Web.Framework.Mvc;
using Nop.Web.Models.Catalog;
using Nop.Web.Models.Topics;

namespace Nop.Web.Models.Common
{
    public partial class SitemapModel : BaseNopModel
    {
        public SitemapModel()
        {
            Products = new List<ProductOverviewModel>();
            Categories = new List<SmCategoryModel>();
            Manufacturers = new List<ManufacturerModel>();
            Topics = new List<TopicModel>();
        }
        public IList<ProductOverviewModel> Products { get; set; }
        public IList<SmCategoryModel> Categories { get; set; }
        public IList<ManufacturerModel> Manufacturers { get; set; }
        public IList<TopicModel> Topics { get; set; }
    }
}