using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryVM)
        {
            postCategory.ID = postCategoryVM.ID;
            postCategory.Name = postCategoryVM.Name;
            postCategory.Alias = postCategoryVM.Alias;
            postCategory.Description = postCategoryVM.Description;
            postCategory.ParentID = postCategoryVM.ParentID;
            postCategory.DisplayOrder = postCategoryVM.DisplayOrder;
            postCategory.Image = postCategoryVM.Image;
            postCategory.HomeFlag = postCategoryVM.HomeFlag;
            postCategory.CreatedDate = postCategoryVM.CreatedDate;
            postCategory.CreatedBy = postCategoryVM.CreatedBy;
            postCategory.UpdatedDate = postCategoryVM.UpdatedDate;
            postCategory.UpdatedBy = postCategoryVM.UpdatedBy;
            postCategory.MataKeyword = postCategoryVM.MataKeyword;
            postCategory.MataDescription = postCategoryVM.MataDescription;
            postCategory.Status = postCategoryVM.Status;
        }

        public static void UpdatePost(this Post post, PostViewModel postVM)
        {
            post.ID = postVM.ID;
            post.Name = postVM.Name;
            post.Alias = postVM.Alias;
            post.Description = postVM.Description;
            post.CategoryID = postVM.CategoryID;
            post.Content = postVM.Content;
            post.Image = postVM.Image;
            post.HomeFlag = postVM.HomeFlag;
            post.ViewCount = postVM.ViewCount;
            post.CreatedDate = postVM.CreatedDate;
            post.CreatedBy = postVM.CreatedBy;
            post.UpdatedDate = postVM.UpdatedDate;
            post.UpdatedBy = postVM.UpdatedBy;
            post.MataKeyword = postVM.MataKeyword;
            post.MataDescription = postVM.MataDescription;
            post.Status = postVM.Status;
        }

        public static void UpdateError(this Error error, ErrorViewModel errorVM)
        {
            error.ID = errorVM.ID;
            error.Massage = errorVM.Massage;
            error.StackTrace = errorVM.StackTrace;
            error.CreatedDate = errorVM.CreatedDate;
        }

        public static void UpdateFooter(this Footer footer, FooterViewModel footerVM)
        {
            footer.ID = footerVM.ID;
            footer.Content = footerVM.Content;
        }

        public static void UpadateMenuGroup(this MenuGroup menuGroup, MenuGroupViewModel menuGroupVM)
        {
            menuGroup.ID = menuGroupVM.ID;
            menuGroup.Name = menuGroupVM.Name;
        }

        public static void UpadateMenu(this Menu menu, MenuViewModel menuVM)
        {
            menu.ID = menuVM.ID;
            menu.Name = menuVM.Name;
            menu.GroupID = menuVM.GroupID;
            menu.DisplayOrder = menuVM.DisplayOrder;
            menu.Status = menuVM.Status;
            menu.URL = menuVM.URL;
            menu.Target = menuVM.Target;
        }

        public static void UpadateOrderDetail(this OrderDetail orderDetail, OrderDetailViewModel orderDetailVM)
        {
            orderDetail.OrderID = orderDetailVM.OrderID;
            orderDetail.ProductID = orderDetailVM.ProductID;
            orderDetail.Quatity = orderDetailVM.Quatity;
        }

        public static void UpadateOrder(this Order order, OrderViewModel orderVM)
        {
            order.ID = orderVM.ID;
            order.CustomerName = orderVM.CustomerName;
            order.CustomerMobile = orderVM.CustomerMobile;
            order.CustomerMessage = orderVM.CustomerMessage;
            order.CustomerEmail = orderVM.CustomerEmail;
            order.CustomerAddress = orderVM.CustomerAddress;
            order.CreatedDate = orderVM.CreatedDate;
            order.CreatedBy = orderVM.CreatedBy;
            order.PaymentMethod = orderVM.PaymentMethod;
            order.PaymentStatus = orderVM.PaymentStatus;
            order.Status = orderVM.Status;
        }

        public static void UpadatePage(this Page page, Page pageVM)
        {
            page.ID = pageVM.ID;
            page.Name = pageVM.Name;
            page.Alias = pageVM.Alias;
            page.Content = pageVM.Content;
            page.CreatedDate = pageVM.CreatedDate;
            page.CreatedBy = pageVM.CreatedBy;
            page.MataDescription = pageVM.MataDescription;
            page.MataKeyword = pageVM.MataKeyword;
            page.UpdatedDate = pageVM.UpdatedDate;
            page.UpdatedBy = pageVM.UpdatedBy;
            page.Status = pageVM.Status;
        }

        public static void UpadatePostTag(this PostTag postTag, PostTagViewModel postTagVM)
        {
            postTag.PostID = postTagVM.PostID;
            postTag.TagID = postTagVM.TagID;
        }

        public static void UpdateProduct(this Product product, ProductViewModel productVM)
        {
            product.ID = productVM.ID;
            product.Name = productVM.Name;
            product.Alias = productVM.Alias;
            product.CategoryID = productVM.CategoryID;
            product.Image = productVM.Image;
            product.MoreImages = productVM.MoreImages;
            product.Price = productVM.Price;
            product.PromotionPrice = productVM.PromotionPrice;
            product.Warranty = productVM.Warranty;
            product.Description = productVM.Description;
            product.Content = productVM.Content;
            product.HomeFlag = productVM.HomeFlag;
            product.HotFlag = productVM.HotFlag;
            product.ViewCount = productVM.ViewCount;
            product.CreatedDate = productVM.CreatedDate;
            product.CreatedBy = productVM.CreatedBy;
            product.UpdatedDate = productVM.UpdatedDate;
            product.UpdatedBy = productVM.UpdatedBy;
            product.MataKeyword = productVM.MataKeyword;
            product.MataDescription = productVM.MataDescription;
            product.Status = productVM.Status;
        }

        public static void UpdateProductCategory(this ProductCategory productCategory, ProductCategoryViewModel productCategoryVM)
        {
            productCategory.ID = productCategoryVM.ID;
            productCategory.Name = productCategoryVM.Name;
            productCategory.Alias = productCategoryVM.Alias;
            productCategory.ParentID = productCategoryVM.ParentID;
            productCategory.Image = productCategoryVM.Image;
            productCategory.DisplayOrder = productCategoryVM.DisplayOrder;
            productCategory.HomeFlag = productCategoryVM.HomeFlag;
            productCategory.Description = productCategoryVM.Description;
            productCategory.CreatedDate = productCategoryVM.CreatedDate;
            productCategory.CreatedBy = productCategoryVM.CreatedBy;
            productCategory.UpdatedDate = productCategoryVM.UpdatedDate;
            productCategory.UpdatedBy = productCategoryVM.UpdatedBy;
            productCategory.MataKeyword = productCategoryVM.MataKeyword;
            productCategory.MataDescription = productCategoryVM.MataDescription;
            productCategory.Status = productCategory.Status;
        }

        public static void UpadateProductTag(this ProductTag productTag, ProductTagViewModel productTagVM)
        {
            productTag.ProductID = productTagVM.ProductID;
            productTag.TagID = productTagVM.TagID;
        }

        public static void UpadateSlide(this Slide slide, SlideViewModel slideVM)
        {
            slide.ID = slideVM.ID;
            slide.Name = slideVM.Name;
            slide.Url = slideVM.Url;
            slide.Description = slideVM.Description;
            slide.DisplayOrder = slideVM.DisplayOrder;
            slide.Status = slideVM.Status;
        }

        public static void UpadateSupportOnline(this SupportOnline supportOnline, SupportOnlineViewModel supportOnlineVM)
        {
            supportOnline.ID = supportOnlineVM.ID;
            supportOnline.Name = supportOnlineVM.Name;
            supportOnline.Mobile = supportOnlineVM.Mobile;
            supportOnline.Skype = supportOnlineVM.Skype;
            supportOnline.DisplayOrder = supportOnlineVM.DisplayOrder;
            supportOnline.Status = supportOnlineVM.Status;
            supportOnline.Yahoo = supportOnlineVM.Yahoo;
            supportOnline.Facebook = supportOnlineVM.Facebook;
            supportOnline.Deparment = supportOnlineVM.Deparment;
            supportOnline.Email = supportOnlineVM.Email;
        }
        public static void UpadateSystemConfig(this SystemConfig systemConfig, SystemConfigViewModel systemConfigVM)
        {
            systemConfig.ID = systemConfigVM.ID;
            systemConfig.ValueInt = systemConfigVM.ValueInt;
            systemConfig.ValueString = systemConfigVM.ValueString;
        }
        public static void UpadateTag(this Tag tag, TagViewModel tagVM)
        {
            tag.ID = tagVM.ID;
            tag.Name= tagVM.Name;
            tag.Type = tagVM.Type;
        }
        public static void UpadateVisitorStatistic(this VisitorStatistic visitorStatistic, VisitorStatisticViewModel visitorStatisticVM)
        {
            visitorStatistic.ID = visitorStatisticVM.ID;
            visitorStatistic.IPAddress = visitorStatisticVM.IPAddress;
            visitorStatistic.VisiteDate = visitorStatisticVM.VisiteDate;
        }
    }
}