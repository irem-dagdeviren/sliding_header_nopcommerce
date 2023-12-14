using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Widgets.HeaderSliderPlugin.Models
{
    public record ConfigurationModel : BaseNopEntityModel
    {
        public ConfigurationModel()
        {

        }
        public string Title { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.HeaderSliderPlugin.StartDate")]
        public DateTime StartDate { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.HeaderSliderPlugin.EndDate")]
        public DateTime EndDate { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.HeaderSliderPlugin.isDisabled")]
        public bool IsDisabled { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.HeaderSliderPlugin.FontFamily")]
        public string? FontFamily { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.HeaderSliderPlugin.FontSize")]
        public string? FontSize { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.HeaderSliderPlugin.FontColor")]
        public string? FontColor { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.HeaderSliderPlugin.WidgetHeight")]
        public string? WidgetHeight { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.HeaderSliderPlugin.BackgroundColor")]
        public string? BackgroundColor { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.HeaderSliderPlugin.Zone")]
        public string Zone { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.HeaderSliderPlugin.AnimationTime")]
        public string AnimationTime { get; set; }

        public ConfigurationSearchModel ConfigurationSearchModel = new ConfigurationSearchModel();

        public IList<SelectListItem> Zones { get; set; } = new List<SelectListItem>
    {
               new SelectListItem { Value = PublicWidgetZones.AccountNavigationAfter , Text = "account_navigation_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.AccountNavigationBefore , Text = "account_navigation_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.AdminHeaderLinksAfter , Text = "admin_header_links_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.AddressBottom , Text = "address_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ApplyVendorBottom , Text = "applyvendor_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ApplyVendorTop , Text = "applyvendor_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BlogListPageAfterPost , Text = "bloglist_page_after_post", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BlogListPageAfterPostBody , Text = "bloglist_page_after_post_body", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BlogListPageAfterPosts , Text = "bloglist_page_after_posts", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BlogListPageBeforePost , Text = "bloglist_page_before_post", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BlogListPageBeforePostBody , Text = "bloglist_page_before_post_body", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BlogListPageBeforePosts , Text = "bloglist_page_before_posts", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BlogListPageInsidePost , Text = "bloglist_page_inside_post", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BlogPostPageAfterComments , Text = "blogpost_page_after_comments", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BlogPostPageBeforeBody , Text = "blogpost_page_before_body", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BlogPostPageBeforeComments , Text = "blogpost_page_before_comments", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BlogPostPageBottom , Text = "blogpost_page_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BlogPostPageInsideComment , Text = "blogpost_page_inside_comment", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BlogPostPageTop , Text = "blogpost_page_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsActivediscussionsAfterHeader , Text = "boards_activediscussions_after_header", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsActivediscussionsAfterTopics , Text = "boards_activediscussions_after_topics", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsForumAfterHeader , Text = "boards_forum_after_header", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsForumBottom , Text = "boards_forum_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsForumGroupAfterHeader , Text = "boards_forumgroup_after_header", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsForumGroupBottom , Text = "boards_forumgroup_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsForumTop , Text = "boards_forum_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsMainAfterActivediscussions , Text = "boards_main_after_activediscussions", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsMainAfterHeader , Text = "boards_main_after_header", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsMainBeforeActivediscussions , Text = "boards_main_before_activediscussions", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsPostCreateAfter , Text = "boards_postcreate_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsPostCreateBefore , Text = "boards_postcreate_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsPostEditAfter , Text = "boards_postedit_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsPostEditBefore , Text = "boards_postedit_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsSearchAfterResults , Text = "boards_search_after_results", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsSearchAfterSearchform , Text = "boards_search_after_searchform", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsSearchBeforeResults , Text = "boards_search_before_results", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsSearchBeforeSearchform , Text = "boards_search_before_searchform", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsTopicAfterHeader , Text = "boards_topic_after_header", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsTopicBottom , Text = "boards_topic_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsTopicCreateAfter , Text = "boards_topiccreate_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsTopicCreateBefore , Text = "boards_topiccreate_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsTopicEditAfter , Text = "boards_topicedit_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsTopicEditBefore , Text = "boards_topicedit_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BoardsTopicTop , Text = "boards_topic_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BodyEndHtmlTagBefore , Text = "body_end_html_tag_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.BodyStartHtmlTagAfter , Text = "body_start_html_tag_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CategoryDetailsAfterBreadcrumb , Text = "categorydetails_after_breadcrumb", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CategoryDetailsAfterFeaturedProducts , Text = "categorydetails_after_featured_products", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CategoryDetailsBeforeFeaturedProducts , Text = "categorydetails_before_featured_products", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CategoryDetailsBeforeFilters , Text = "categorydetails_before_filters", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CategoryDetailsBeforeProductList , Text = "categorydetails_before_product_list", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CategoryDetailsBeforeSubcategories , Text = "categorydetails_before_subcategories", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CategoryDetailsBottom , Text = "categorydetails_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CategoryDetailsTop , Text = "categorydetails_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutBillingAddressBottom , Text = "checkout_billing_address_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutBillingAddressMiddle , Text = "checkout_billing_address_middle", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutBillingAddressTop , Text = "checkout_billing_address_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutCompletedBottom , Text = "checkout_completed_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutCompletedTop , Text = "checkout_completed_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutConfirmBottom , Text = "checkout_confirm_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutConfirmTop , Text = "checkout_confirm_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutPaymentInfoBottom , Text = "checkout_payment_info_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutPaymentInfoTop , Text = "checkout_payment_info_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutPaymentMethodBottom , Text = "checkout_payment_method_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutPaymentMethodTop , Text = "checkout_payment_method_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutPickUpPointsAfter , Text = "checkout_pickup_points_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutProgressAfter , Text = "checkout_progress_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutProgressBefore , Text = "checkout_progress_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutShippingAddressBottom , Text = "checkout_shipping_address_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutShippingAddressMiddle , Text = "checkout_shipping_address_middle", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutShippingAddressTop , Text = "checkout_shipping_address_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutShippingMethodBottom , Text = "checkout_shipping_method_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.CheckoutShippingMethodTop , Text = "checkout_shipping_method_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ContactUsBottom , Text = "contactus_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ContactUsTop , Text = "contactus_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ContactVendorBottom , Text = "contactvendor_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ContactVendorTop , Text = "contactvendor_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ContentAfter , Text = "content_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ContentBefore , Text = "content_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.Footer , Text = "footer", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.HeaderAfter , Text = "header_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.HeaderBefore , Text = "header_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.HeaderLinksAfter , Text = "header_links_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.HeaderLinksBefore , Text = "header_links_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.HeaderMenuAfter , Text = "header_menu_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.HeaderMenuBefore , Text = "header_menu_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.HeaderMiddle , Text = "header_middle", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.HeaderSelectors , Text = "header_selectors", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.HeadHtmlTag , Text = "head_html_tag", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.HomepageBeforeBestSellers , Text = "home_page_before_best_sellers", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.HomepageBeforeCategories , Text = "home_page_before_categories", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.HomepageBeforeNews , Text = "home_page_before_news", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.HomepageBeforePoll , Text = "home_page_before_poll", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.HomepageBeforeProducts , Text = "home_page_before_products", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.HomepageBottom , Text = "home_page_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.HomepageTop , Text = "home_page_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.LeftSideColumnAfter , Text = "left_side_column_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.LeftSideColumnAfterBlogArchive , Text = "left_side_column_after_blog_archive", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.LeftSideColumnAfterCategoryNavigation , Text = "left_side_column_after_category_navigation", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.LeftSideColumnBefore , Text = "left_side_column_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.LeftSideColumnBlogAfter , Text = "left_side_column_blog_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.LeftSideColumnBlogBefore , Text = "left_side_column_blog_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.LoginBottom , Text = "login_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.LoginTop , Text = "login_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.MainColumnAfter , Text = "main_column_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.MainColumnBefore , Text = "main_column_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ManufacturerDetailsAfterFeaturedProducts , Text = "manufacturerdetails_after_featured_products", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ManufacturerDetailsBeforeFeaturedProducts , Text = "manufacturerdetails_before_featured_products", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ManufacturerDetailsBeforeFilters , Text = "manufacturerdetails_before_filters", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ManufacturerDetailsBeforeProductList , Text = "manufacturerdetails_before_product_list", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ManufacturerDetailsBottom , Text = "manufacturerdetails_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ManufacturerDetailsTop , Text = "manufacturerdetails_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.MobHeaderMenuAfter , Text = "mob_header_menu_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.MobHeaderMenuBefore , Text = "mob_header_menu_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.NewsItemPageAfterComments , Text = "newsitem_page_after_comments", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.NewsItemPageBeforeBody , Text = "newsitem_page_before_body", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.NewsItemPageBeforeComments , Text = "newsitem_page_before_comments", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.NewsItemPageInsideComment , Text = "newsitem_page_inside_comment", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.NewsListPageAfterItems , Text = "newslist_page_after_items", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.NewsListPageBeforeItems , Text = "newslist_page_before_items", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.NewsListPageInsideItem , Text = "newslist_page_inside_item", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.Notifications , Text = "notifications", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OpcContentAfter , Text = "opc_content_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OpcContentBefore , Text = "opc_content_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OpCheckoutBillingAddressBottom , Text = "op_checkout_billing_address_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OpCheckoutBillingAddressMiddle , Text = "op_checkout_billing_address_middle", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OpCheckoutBillingAddressTop , Text = "op_checkout_billing_address_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OpCheckoutConfirmBottom , Text = "op_checkout_confirm_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OpCheckoutConfirmTop , Text = "op_checkout_confirm_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OpCheckoutPaymentInfoBottom , Text = "op_checkout_payment_info_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OpCheckoutPaymentInfoTop , Text = "op_checkout_payment_info_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OpCheckoutPaymentMethodBottom , Text = "op_checkout_payment_method_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OpCheckoutPaymentMethodTop , Text = "op_checkout_payment_method_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OpCheckoutShippingAddressBottom , Text = "op_checkout_shipping_address_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OpCheckoutShippingAddressMiddle , Text = "op_checkout_shipping_address_middle", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OpCheckoutShippingAddressTop , Text = "op_checkout_shipping_address_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OpCheckoutShippingMethodBottom , Text = "op_checkout_shipping_method_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OpCheckoutShippingMethodTop , Text = "op_checkout_shipping_method_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderDetailsBillingAddress , Text = "order_details_billing_address", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderDetailsPageAfterproducts , Text = "orderdetails_page_afterproducts", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderDetailsPageBeforeproducts , Text = "orderdetails_page_beforeproducts", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderDetailsPageBottom , Text = "orderdetails_page_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderDetailsPageOverview , Text = "orderdetails_page_overview", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderDetailsPageTop , Text = "orderdetails_page_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderDetailsProductLine , Text = "orderdetails_product_line", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderDetailsShippingAddress , Text = "order_details_shipping_address", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderSummaryBillingAddress , Text = "order_summary_billing_address", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderSummaryCartFooter , Text = "order_summary_cart_footer", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderSummaryContentAfter , Text = "order_summary_content_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderSummaryContentBefore , Text = "order_summary_content_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderSummaryContentDeals , Text = "order_summary_content_deals", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderSummaryPaymentMethodInfo , Text = "order_summary_payment_method_info", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderSummaryShippingAddress , Text = "order_summary_shipping_address", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderSummaryShippingMethodInfo , Text = "order_summary_shipping_method_info", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.OrderSummaryTotals , Text = "order_summary_totals", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductBoxAddinfoAfter , Text = "productbox_addinfo_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductBoxAddinfoBefore , Text = "productbox_addinfo_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductBoxAddinfoMiddle , Text = "productbox_addinfo_middle", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductBreadcrumbAfter , Text = "productbreadcrumb_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductBreadcrumbBefore , Text = "productbreadcrumb_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductDetailsAddInfo , Text = "productdetails_add_info", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductDetailsAfterBreadcrumb , Text = "productdetails_after_breadcrumb", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductDetailsAfterPictures , Text = "productdetails_after_pictures", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductDetailsAfterVideos , Text = "productdetails_after_videos", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductDetailsBeforeCollateral , Text = "productdetails_before_collateral", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductDetailsBeforePictures , Text = "productdetails_before_pictures", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductDetailsBeforeVideos , Text = "productdetails_before_videos", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductDetailsBottom , Text = "productdetails_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductDetailsEssentialBottom , Text = "productdetails_essential_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductDetailsEssentialTop , Text = "productdetails_essential_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductDetailsInsideOverviewButtonsAfter , Text = "productdetails_inside_overview_buttons_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductDetailsInsideOverviewButtonsBefore , Text = "productdetails_inside_overview_buttons_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductDetailsOverviewBottom , Text = "productdetails_overview_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductDetailsOverviewTop , Text = "productdetails_overview_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductDetailsTop , Text = "productdetails_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductReviewsPageBottom , Text = "productreviews_page_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductReviewsPageInsideReview , Text = "productreviews_page_inside_review", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductReviewsPageTop , Text = "productreviews_page_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductsByTagBeforeProductList , Text = "productsbytag_before_product_list", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductsByTagBottom , Text = "productsbytag_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductsByTagTop , Text = "productsbytag_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductPriceTop , Text = "product_price_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductPriceBottom , Text = "product_price_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductSearchPageAdvanced , Text = "productsearch_page_advanced", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductSearchPageAfterResults , Text = "productsearch_page_after_results", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductSearchPageBasic , Text = "productsearch_page_basic", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProductSearchPageBeforeResults , Text = "productsearch_page_before_results", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProfilePageInfoUserdetails , Text = "profile_page_info_userdetails", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.ProfilePageInfoUserstats , Text = "profile_page_info_userstats", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.RegisterBottom , Text = "register_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.RegisterTop , Text = "register_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.SearchBox , Text = "searchbox", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.SearchBoxBeforeSearchButton , Text = "searchbox_before_search_button", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.SitemapAfter , Text = "sitemap_after", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.SitemapBefore , Text = "sitemap_before", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.TopicDetailsTop , Text = "topic_details_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.TopicDetailsBottom , Text = "topic_details_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.VendorDetailsBottom , Text = "vendordetails_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.VendorDetailsTop , Text = "vendordetails_top", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.WishlistBottom , Text = "wishlist_bottom", Selected = false},
        new SelectListItem { Value = PublicWidgetZones.WishlistTop , Text = "wishlist_top", Selected = false}

    };
        public IList<SelectListItem> Fonts { get; set; } = new List<SelectListItem>
    {
        new SelectListItem { Value = "'Arial', sans-serif", Text = "Arial", Selected = false },
        new SelectListItem { Value = "'Times New Roman', serif", Text = "Times New Roman", Selected = false },
        new SelectListItem { Value = "'Verdana', sans-serif", Text = "Verdana", Selected = false },
        new SelectListItem { Value = "'Courier New', monospace", Text = "Courier New", Selected = false },
        new SelectListItem { Value = "'Comic Sans MS', cursive", Text = "Comic Sans MS", Selected = false },
        new SelectListItem { Value = "'Georgia', serif", Text = "Georgia", Selected = false },
        new SelectListItem { Value = "'Palatino Linotype', serif", Text = "Palatino Linotype", Selected = false },
        new SelectListItem { Value = "'Impact', sans-serif", Text = "Impact", Selected = false },
        new SelectListItem { Value = "'Tahoma', sans-serif", Text = "Tahoma", Selected = false },
        new SelectListItem { Value = "'Trebuchet MS', sans-serif", Text = "Trebuchet MS", Selected = false },
        new SelectListItem { Value = "'Lucida Console', monospace", Text = "Lucida Console", Selected = false },
        new SelectListItem { Value = "'Helvetica', sans-serif", Text = "Helvetica", Selected = false },
        new SelectListItem { Value = "'Garamond', serif", Text = "Garamond", Selected = false },
        new SelectListItem { Value = "'Book Antiqua', serif", Text = "Book Antiqua", Selected = false },
        new SelectListItem { Value = "'Arial Black', sans-serif", Text = "Arial Black", Selected = false },
        new SelectListItem { Value = "'Century Gothic', sans-serif", Text = "Century Gothic", Selected = false },
        new SelectListItem { Value = "'Franklin Gothic Medium', sans-serif", Text = "Franklin Gothic Medium", Selected = false },
        new SelectListItem { Value = "'Copperplate Gothic Bold', sans-serif", Text = "Copperplate Gothic Bold", Selected = false },
        new SelectListItem { Value = "'Courier', monospace", Text = "Courier", Selected = false },
        new SelectListItem { Value = "'Brush Script MT', cursive", Text = "Brush Script MT", Selected = false },
        new SelectListItem { Value = "'Consolas', monospace", Text = "Consolas", Selected = false },
        new SelectListItem { Value = "'Optima', sans-serif", Text = "Optima", Selected = false },
        new SelectListItem { Value = "'Arial Narrow', sans-serif", Text = "Arial Narrow", Selected = false },
        new SelectListItem { Value = "'Baskerville Old Face', serif", Text = "Baskerville Old Face", Selected = false },
        new SelectListItem { Value = "'Cambria', serif", Text = "Cambria", Selected = false },
        new SelectListItem { Value = "'Palatino', serif", Text = "Palatino", Selected = false },
        new SelectListItem { Value = "'Rockwell', serif", Text = "Rockwell", Selected = false },
        new SelectListItem { Value = "'Segoe UI', sans-serif", Text = "Segoe UI", Selected = false },
        new SelectListItem { Value = "'Segoe Print', sans-serif", Text = "Segoe Print", Selected = false },
        new SelectListItem { Value = "'Segoe Script', cursive", Text = "Segoe Script", Selected = false }
};

    }

}