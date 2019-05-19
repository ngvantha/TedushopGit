using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            //Mapper.CreateMap<Post, PostViewModel>();
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<PostTag, PostTagViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();
                cfg.CreateMap<Error, ErrorViewModel>();
                cfg.CreateMap<Footer, FooterViewModel>();
                cfg.CreateMap<Menu, MenuViewModel>();
                cfg.CreateMap<MenuGroup, MenuGroupViewModel>();
                cfg.CreateMap<Order, OrderViewModel>();
                cfg.CreateMap<OrderDetail, OrderDetailViewModel>();
                cfg.CreateMap<Page, PageViewModel>();
                cfg.CreateMap<Product, ProductViewModel>();
                cfg.CreateMap<ProductCategory, ProductCategoryViewModel>();
                cfg.CreateMap<ProductTag, ProductTagViewModel>();
                cfg.CreateMap<Slide, SlideViewModel>();
                cfg.CreateMap<SupportOnline, SupportOnlineViewModel>();
                cfg.CreateMap<SystemConfig, SystemConfigViewModel>();
                cfg.CreateMap<VisitorStatistic, VisitorStatisticViewModel>();

            });
        }
    }
}