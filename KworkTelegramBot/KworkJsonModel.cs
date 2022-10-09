using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KworkTelegramBot
{
    
    public class KworkJsonModel
    {
        public bool success { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public object[] attributesCount { get; set; }
        public Counts counts { get; set; }
        public object[] favouriteCategories { get; set; }
        public object[] favouriteCategoriesCount { get; set; }
        public Filter filter { get; set; }
        public Filters filters { get; set; }
        public Pagination pagination { get; set; }
        public Want[] wants { get; set; }
        public object[] wantsFromAllRubrics { get; set; }
    }

    public class Counts
    {
        public string kworks_filter_id_0 { get; set; }
        public string kworks_filter_id_1 { get; set; }
        public string kworks_filter_id_2 { get; set; }
        public string kworks_filter_id_3 { get; set; }
        public string kworks_filter_id_4 { get; set; }
        public string prices_filter_id_0 { get; set; }
        public string prices_filter_id_1 { get; set; }
        public string prices_filter_id_2 { get; set; }
        public string prices_filter_id_3 { get; set; }
        public string prices_filter_id_4 { get; set; }
        public object[] attrs { get; set; }
        public string category_id_20 { get; set; }
        public string category_id_23 { get; set; }
        public string category_id_24 { get; set; }
        public string category_id_25 { get; set; }
        public string category_id_27 { get; set; }
        public string category_id_28 { get; set; }
        public string category_id_35 { get; set; }
        public string category_id_37 { get; set; }
        public string category_id_38 { get; set; }
        public string category_id_39 { get; set; }
        public string category_id_40 { get; set; }
        public string category_id_41 { get; set; }
        public string category_id_43 { get; set; }
        public string category_id_44 { get; set; }
        public string category_id_46 { get; set; }
        public string category_id_47 { get; set; }
        public string category_id_49 { get; set; }
        public string category_id_55 { get; set; }
        public string category_id_56 { get; set; }
        public string category_id_59 { get; set; }
        public string category_id_63 { get; set; }
        public string category_id_64 { get; set; }
        public string category_id_65 { get; set; }
        public string category_id_68 { get; set; }
        public string category_id_71 { get; set; }
        public string category_id_72 { get; set; }
        public string category_id_73 { get; set; }
        public string category_id_74 { get; set; }
        public string category_id_75 { get; set; }
        public string category_id_76 { get; set; }
        public string category_id_77 { get; set; }
        public string category_id_78 { get; set; }
        public string category_id_79 { get; set; }
        public string category_id_80 { get; set; }
        public string category_id_81 { get; set; }
        public string category_id_84 { get; set; }
        public string category_id_90 { get; set; }
        public string category_id_106 { get; set; }
        public string category_id_108 { get; set; }
        public string category_id_112 { get; set; }
        public string category_id_113 { get; set; }
        public string category_id_114 { get; set; }
        public string category_id_235 { get; set; }
        public string category_id_250 { get; set; }
        public string category_id_255 { get; set; }
        public string category_id_262 { get; set; }
        public string category_id_265 { get; set; }
        public string category_id_270 { get; set; }
        public string category_id_272 { get; set; }
        public string category_id_273 { get; set; }
        public string category_id_286 { get; set; }
        public int category_id_7 { get; set; }
        public int category_id_15 { get; set; }
        public int category_id_5 { get; set; }
        public int category_id_11 { get; set; }
        public int category_id_17 { get; set; }
        public int category_id_45 { get; set; }
        public int category_id_83 { get; set; }
    }

    public class Filter
    {
        public object price_from { get; set; }
        public object price_to { get; set; }
        public object hiring_from { get; set; }
        public object kworks_filters { get; set; }
        public object prices_filters { get; set; }
        public object keyword { get; set; }
    }

    public class Filters
    {
        public By_Kworks[] by_kworks { get; set; }
        public By_Budget[] by_budget { get; set; }
    }

    public class By_Kworks
    {
        public int id { get; set; }
        public string name { get; set; }
        public Boundaries boundaries { get; set; }
    }

    public class Boundaries
    {
        public int? from { get; set; }
        public int? to { get; set; }
    }

    public class By_Budget
    {
        public int id { get; set; }
        public string name { get; set; }
        public Boundaries1 boundaries { get; set; }
    }

    public class Boundaries1
    {
        public int? from { get; set; }
        public int? to { get; set; }
    }

    public class Pagination
    {
        public int current_page { get; set; }
        public Datum[] data { get; set; }
        public string first_page_url { get; set; }
        public int from { get; set; }
        public int last_page { get; set; }
        public string last_page_url { get; set; }
        public Link[] links { get; set; }
        public string next_page_url { get; set; }
        public string path { get; set; }
        public int per_page { get; set; }
        public object prev_page_url { get; set; }
        public int to { get; set; }
        public int total { get; set; }
    }

    public class Datum
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string category_id { get; set; }
        public string kwork_count { get; set; }
        public string order_count { get; set; }
        public string status { get; set; }
        public string date_create { get; set; }
        public string date_confirm { get; set; }
        public string date_expire { get; set; }
        public object date_reject { get; set; }
        public string date_active { get; set; }
        public object restart_token { get; set; }
        public string email_flag { get; set; }
        public string offer_letter_date { get; set; }
        public string last_edit_date { get; set; }
        public string last_want_moder_id { get; set; }
        public string date_moder { get; set; }
        public string need_postmoder { get; set; }
        public string lang { get; set; }
        public string price_limit { get; set; }
        public bool allow_higher_price { get; set; }
        public string views { get; set; }
        public string views_dirty { get; set; }
        public string app_id { get; set; }
        public object work_hours { get; set; }
        public string alt_status { get; set; }
        public string payment_type { get; set; }
        public object worker_level { get; set; }
        public object time_rate { get; set; }
        public object estimate { get; set; }
        public object week_time_limit { get; set; }
        public object deleted_admin_id { get; set; }
        public string last_log_moderation_type { get; set; }
        public int work_time_type { get; set; }
        public string spam_percent { get; set; }
        public object review_type { get; set; }
        public object review_date { get; set; }
        public Attr[] attrs { get; set; }
        public File[] files { get; set; }
        public User user { get; set; }
        public Category category { get; set; }
        public object current_user_review { get; set; }
    }

    public class User
    {
        public int USERID { get; set; }
        public string username { get; set; }
        public string role { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string fullname { get; set; }
        public string phone_verified { get; set; }
        public string verified { get; set; }
        public string addtime { get; set; }
        public string description { get; set; }
        public string lastlogin { get; set; }
        public object allow_ip { get; set; }
        public string country_id { get; set; }
        public string city_id { get; set; }
        public string level { get; set; }
        public string live_date { get; set; }
        public string smtp_error { get; set; }
        public string isEvent { get; set; }
        public string refType { get; set; }
        public string is_orders { get; set; }
        public string order_count { get; set; }
        public string email_flag { get; set; }
        public string order_done_count { get; set; }
        public string cache_rating_count { get; set; }
        public string cache_rating { get; set; }
        public string cache_service { get; set; }
        public string is_want_confirm { get; set; }
        public string cover { get; set; }
        public string portfolio_type { get; set; }
        public string show_poll_notify { get; set; }
        public string message_sound { get; set; }
        public string smm_access { get; set; }
        public string notify_count { get; set; }
        public string kwork_allow_status { get; set; }
        public string lang { get; set; }
        public string timezone { get; set; }
        public string timezone_id { get; set; }
        public string red_notify { get; set; }
        public string is_available_at_weekends { get; set; }
        public string fullnameen { get; set; }
        public string descriptionen { get; set; }
        public string abuse_block_level { get; set; }
        public string last_abuse_date { get; set; }
        public string worker_status { get; set; }
        public string worker_status_switch_all { get; set; }
        public string catalog_view_type { get; set; }
        public string cache_rating_count_en { get; set; }
        public string is_more_payer { get; set; }
        public string last_viewed_category_id { get; set; }
        public string is_app_market { get; set; }
        public string is_app_exchange { get; set; }
        public string is_app_enterprise { get; set; }
        public string last_email_resend_at { get; set; }
        public string profilepicture { get; set; }
        public string avatar_type { get; set; }
        public string is_bot { get; set; }
        public Data1 data { get; set; }
        public Badge[] badges { get; set; }
        public Apps_Data[] apps_data { get; set; }
        public string profile_url { get; set; }
    }

    public class Data1
    {
        public int user_id { get; set; }
        public object categories { get; set; }
        public string is_login_change { get; set; }
        public string reg_type { get; set; }
        public string used { get; set; }
        public string avgWorkTime { get; set; }
        public string kwork_count { get; set; }
        public object a { get; set; }
        public string project_letter_date { get; set; }
        public string was_subscribed_comeback { get; set; }
        public string order_done_persent { get; set; }
        public string order_done_intime_persent { get; set; }
        public string order_done_repeat_persent { get; set; }
        public string avatar_last_number { get; set; }
        public string show_stat { get; set; }
        public string disable_report_notification { get; set; }
        public string looked_lesson { get; set; }
        public string payer_level { get; set; }
        public string is_super_payer { get; set; }
        public string became_super_payer_date { get; set; }
        public string warning_messages_ignored_percent { get; set; }
        public string service_orders_total { get; set; }
        public string show_recommendations_in_track_page { get; set; }
        public string queue_orders_count { get; set; }
        public string on_unblock_queue { get; set; }
        public string wants_count { get; set; }
        public string wants_hired_percent { get; set; }
        public string connect_points { get; set; }
        public string accrued_connect_points { get; set; }
        public string connect_penalty_orders_done { get; set; }
        public string connect_penalty_spam { get; set; }
        public string connect_penalty_contacts_exchange { get; set; }
        public object connect_orders_done { get; set; }
        public string connects_last_refill_date { get; set; }
        public string portfolio_work_num { get; set; }
        public object connect_points_return_date { get; set; }
        public string count_letter_poll_1 { get; set; }
        public string count_letter_poll_2 { get; set; }
        public string count_letter_followup_category { get; set; }
        public string count_letter_followup_search { get; set; }
        public string letter_poll_1_created { get; set; }
        public string letter_followup_category_last { get; set; }
        public string letter_followup_search_last { get; set; }
        public string notification_period { get; set; }
        public object last_affiliate_payer_id { get; set; }
        public string profession { get; set; }
        public string last_statistic_update_date { get; set; }
        public string draft_number { get; set; }
        public string last_interest_letter_num { get; set; }
        public string kworks_disabled { get; set; }
        public bool is_kwork_book_info_closed { get; set; }
        public string is_mobile_push_allowed { get; set; }
        public string is_edoc_agreed { get; set; }
        public bool is_pay_oferta_accepted { get; set; }
        public string first_order_payment_date { get; set; }
        public object hour_rate { get; set; }
        public int can_moder_qualification { get; set; }
        public object phone_change_date { get; set; }
        public bool? has_job { get; set; }
        public object education_type_id { get; set; }
        public int? last_send_email_time { get; set; }
        public int? reg_os_type { get; set; }
        public bool is_dark_theme { get; set; }
        public string review_rating_percentage { get; set; }
        public int last_info_letter_num { get; set; }
        public string profile_updated_at { get; set; }
        public int? work_hours_from { get; set; }
        public int? work_hours_to { get; set; }
        public bool mobile_push_sound_on { get; set; }
        public string has_large_avatar { get; set; }
        public bool worker_novice_advice { get; set; }
        public string earned { get; set; }
        public string register_country_id { get; set; }
        public string timezone_change_date { get; set; }
        public string add_first_phone_date { get; set; }
        public object worker_first_order_done_create_date { get; set; }
        public string has_mobile_token { get; set; }
        public string notified_spam_inbox_last_time { get; set; }
        public string show_mobile_banner { get; set; }
        public string reg_source_type { get; set; }
        public object has_violation { get; set; }
        public int sent_verify_codes_count { get; set; }
        public int unread_dialog_count { get; set; }
        public int unread_message_count { get; set; }
        public int warning_dialog_count { get; set; }
        public int archive_dialog_count { get; set; }
        public string active_kwork_count { get; set; }
        public object became_advanced_date { get; set; }
        public object became_pro_date { get; set; }
        public bool is_need_show_day_poll { get; set; }
        public bool is_phone_verification_started { get; set; }
        public object last_order_done_date { get; set; }
    }

    public class Badge
    {
        public int id { get; set; }
        public string user_id { get; set; }
        public string badge_id { get; set; }
        public string date_create { get; set; }
        public Badge1 badge { get; set; }
    }

    public class Badge1
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string super_title { get; set; }
        public string super_description { get; set; }
        public int? payer_level { get; set; }
        public bool is_super_payer { get; set; }
        public string sort { get; set; }
    }

    public class Apps_Data
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int app_id { get; set; }
        public string unread_dialog_count { get; set; }
        public string unread_message_count { get; set; }
        public string warning_dialog_count { get; set; }
        public string archive_dialog_count { get; set; }
        public int notify_unread_count { get; set; }
        public string created_at { get; set; }
        public string description { get; set; }
        public string profession { get; set; }
        public string profession_en { get; set; }
        public bool notify_order_important { get; set; }
    }

    public class Category
    {
        public int CATID { get; set; }
        public string name { get; set; }
        public string seo { get; set; }
        public string seo_en { get; set; }
        public string seo_i { get; set; }
        public string seo_v { get; set; }
        public string parent { get; set; }
        public string details { get; set; }
        public string mtitle { get; set; }
        public string mdesc { get; set; }
        public string mtags { get; set; }
        public string minfo { get; set; }
        public string fox_featuredcat { get; set; }
        public string fox_cattag1 { get; set; }
        public string fox_cattag2 { get; set; }
        public string fox_cattag3 { get; set; }
        public string use_count { get; set; }
        public int order_month { get; set; }
        public int order_3_day { get; set; }
        public string max_days { get; set; }
        public string max_photo_count { get; set; }
        public string allow_mirror { get; set; }
        public int land_count { get; set; }
        public int kwork_count { get; set; }
        public string land_view_count { get; set; }
        public string is_package { get; set; }
        public string is_package_free_price { get; set; }
        public string package_standard_mult { get; set; }
        public string package_medium_mult { get; set; }
        public string package_premium_mult { get; set; }
        public string portfolio_type { get; set; }
        public int month_done_orders_count { get; set; }
        public int rotation_weight { get; set; }
        public string section_type { get; set; }
        public string custom_offer { get; set; }
        public string collage_image { get; set; }
        public float conversion { get; set; }
        public string lang { get; set; }
        public string twin_category_id { get; set; }
        public string mapped_category_id { get; set; }
        public float quality_rating_relative { get; set; }
        public int month_revenue { get; set; }
        public string short_name { get; set; }
        public object base_volume { get; set; }
        public object min_volume { get; set; }
        public object max_volume { get; set; }
        public object min_volume_type_id { get; set; }
        public object max_volume_type_id { get; set; }
        public object volume_type_id { get; set; }
        public string mobile_description { get; set; }
        public string portfolio_avaliable { get; set; }
        public float avg_offers_count { get; set; }
        public string response_time { get; set; }
        public string is_kwork_full_rate { get; set; }
        public int sort_index { get; set; }
        public string orders_inprogress_limit { get; set; }
        public string orders_inprogress_pause_off { get; set; }
        public string is_free_qualification { get; set; }
        public int is_hidden { get; set; }
        public bool admin_only { get; set; }
        public string created_at { get; set; }
        public object deleted_at { get; set; }
        public int conversion_order_count { get; set; }
        public int conversion_view_count { get; set; }
        public int finance_conversion_orders_sum { get; set; }
        public int finance_conversion { get; set; }
        public string is_subscribe_price { get; set; }
        public string related_id { get; set; }
        public object min_volume_price { get; set; }
        public object max_volume_price { get; set; }
        public object subscribe_volume { get; set; }
        public object is_show_base_volume_price { get; set; }
        public string h1 { get; set; }
        public object add_text { get; set; }
        public string images_update_time { get; set; }
        public string is_need_metrics { get; set; }
        public bool is_smm_hide { get; set; }
        public int portfolio_image_size { get; set; }
        public object portfolio_moderation_group_id { get; set; }
        public object twin_attribute_id { get; set; }
        public bool show_auto_translated { get; set; }
        public int want_middle_price { get; set; }
        public int want_sales_count { get; set; }
        public Parent_Category parent_category { get; set; }
    }

    public class Parent_Category
    {
        public int CATID { get; set; }
        public string name { get; set; }
        public string seo { get; set; }
        public string seo_en { get; set; }
        public string seo_i { get; set; }
        public string seo_v { get; set; }
        public string parent { get; set; }
        public string details { get; set; }
        public string mtitle { get; set; }
        public string mdesc { get; set; }
        public string mtags { get; set; }
        public string minfo { get; set; }
        public string fox_featuredcat { get; set; }
        public string fox_cattag1 { get; set; }
        public string fox_cattag2 { get; set; }
        public string fox_cattag3 { get; set; }
        public string use_count { get; set; }
        public int order_month { get; set; }
        public int order_3_day { get; set; }
        public string max_days { get; set; }
        public string max_photo_count { get; set; }
        public string allow_mirror { get; set; }
        public int land_count { get; set; }
        public int kwork_count { get; set; }
        public string land_view_count { get; set; }
        public string is_package { get; set; }
        public string is_package_free_price { get; set; }
        public string package_standard_mult { get; set; }
        public string package_medium_mult { get; set; }
        public string package_premium_mult { get; set; }
        public string portfolio_type { get; set; }
        public int month_done_orders_count { get; set; }
        public int rotation_weight { get; set; }
        public string section_type { get; set; }
        public string custom_offer { get; set; }
        public string collage_image { get; set; }
        public int conversion { get; set; }
        public string lang { get; set; }
        public string twin_category_id { get; set; }
        public string mapped_category_id { get; set; }
        public int quality_rating_relative { get; set; }
        public int month_revenue { get; set; }
        public string short_name { get; set; }
        public object base_volume { get; set; }
        public object min_volume { get; set; }
        public object max_volume { get; set; }
        public object min_volume_type_id { get; set; }
        public object max_volume_type_id { get; set; }
        public object volume_type_id { get; set; }
        public string mobile_description { get; set; }
        public string portfolio_avaliable { get; set; }
        public int avg_offers_count { get; set; }
        public object response_time { get; set; }
        public string is_kwork_full_rate { get; set; }
        public int sort_index { get; set; }
        public object orders_inprogress_limit { get; set; }
        public object orders_inprogress_pause_off { get; set; }
        public string is_free_qualification { get; set; }
        public int is_hidden { get; set; }
        public bool admin_only { get; set; }
        public string created_at { get; set; }
        public object deleted_at { get; set; }
        public int conversion_order_count { get; set; }
        public int conversion_view_count { get; set; }
        public int finance_conversion_orders_sum { get; set; }
        public int finance_conversion { get; set; }
        public string is_subscribe_price { get; set; }
        public string related_id { get; set; }
        public object min_volume_price { get; set; }
        public object max_volume_price { get; set; }
        public object subscribe_volume { get; set; }
        public object is_show_base_volume_price { get; set; }
        public string h1 { get; set; }
        public object add_text { get; set; }
        public string images_update_time { get; set; }
        public string is_need_metrics { get; set; }
        public bool is_smm_hide { get; set; }
        public int portfolio_image_size { get; set; }
        public object portfolio_moderation_group_id { get; set; }
        public object twin_attribute_id { get; set; }
        public bool show_auto_translated { get; set; }
        public object want_middle_price { get; set; }
        public object want_sales_count { get; set; }
    }

    public class Attr
    {
        public int id { get; set; }
        public string title { get; set; }
        public string alias { get; set; }
        public string lang { get; set; }
        public int category_id { get; set; }
        public string parent_id { get; set; }
        public string visible { get; set; }
        public string required { get; set; }
        public string allow_multiple { get; set; }
        public string allow_custom { get; set; }
        public string is_custom { get; set; }
        public string custom_max_count { get; set; }
        public string custom_moderation_status { get; set; }
        public string is_classification { get; set; }
        public string order_index { get; set; }
        public string is_free_price { get; set; }
        public string is_kwork_links_sites { get; set; }
        public string multiple_max_count { get; set; }
        public string base_volume { get; set; }
        public string min_volume { get; set; }
        public string max_volume { get; set; }
        public string min_volume_type_id { get; set; }
        public string max_volume_type_id { get; set; }
        public string volume_type_id { get; set; }
        public string hint_worker { get; set; }
        public string hint_payer { get; set; }
        public string hint_volume { get; set; }
        public string note_worker { get; set; }
        public string portfolio { get; set; }
        public string parent_portfolio { get; set; }
        public float percent_usage { get; set; }
        public string portfolio_type { get; set; }
        public string unembedded { get; set; }
        public string demo_file_upload { get; set; }
        public string force_display_in_kwork { get; set; }
        public string orders_inprogress_limit { get; set; }
        public string orders_inprogress_pause_off { get; set; }
        public string depth { get; set; }
        public int kworks_count { get; set; }
        public int month_revenue { get; set; }
        public string created_at { get; set; }
        public object default_duration { get; set; }
        public string is_custom_extra_denied { get; set; }
        public object deleted_at { get; set; }
        public string is_subscribe_price { get; set; }
        public string is_show_base_volume_price { get; set; }
        public object min_volume_price { get; set; }
        public object max_volume_price { get; set; }
        public object subscribe_volume { get; set; }
        public string meta_title { get; set; }
        public string meta_description { get; set; }
        public string h1 { get; set; }
        public object duplicated_attribute_id { get; set; }
        public object add_text { get; set; }
        public bool is_hidden { get; set; }
        public object twin_id { get; set; }
        public bool is_smm_hide { get; set; }
        public int portfolio_image_size { get; set; }
        public int want_middle_price { get; set; }
        public int want_sales_count { get; set; }
        public Pivot pivot { get; set; }
        public int max_photo_count { get; set; }
    }

    public class Pivot
    {
        public string want_id { get; set; }
        public string attribute_id { get; set; }
    }

    public class File
    {
        public int FID { get; set; }
        public string USERID { get; set; }
        public string entity_type { get; set; }
        public string entity_id { get; set; }
        public string fname { get; set; }
        public string s { get; set; }
        public int size { get; set; }
        public string time { get; set; }
        public string lang { get; set; }
        public string status { get; set; }
        public string storage { get; set; }
        public string miniature_status { get; set; }
        public string miniature_creating_attempts { get; set; }
        public string permanent { get; set; }
        public string mime_type_id { get; set; }
        public string sort_index { get; set; }
        public string url { get; set; }
    }

    public class Link
    {
        public string url { get; set; }
        public string label { get; set; }
        public bool active { get; set; }
    }

    public class Want
    {
        public int id { get; set; }
        public string lang { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public string url { get; set; }
        public File1[] files { get; set; }
        public bool isActive { get; set; }
        public bool isHigherPrice { get; set; }
        public bool isSymbolRu { get; set; }
        public int categoryMinPrice { get; set; }
        public string priceLimit { get; set; }
        public int possiblePriceLimit { get; set; }
        public object dateView { get; set; }
        public string dateExpire { get; set; }
        public string dateCreate { get; set; }
        public string dateExpireText { get; set; }
        public string dateCreateText { get; set; }
        public string kworkCount { get; set; }
        public object projectReviewType { get; set; }
        public bool getReviewCanChange { get; set; }
        public string timeLeft { get; set; }
        public int userId { get; set; }
        public string userName { get; set; }
        public string userAvatar { get; set; }
        public string userAvatarSrcSet { get; set; }
        public string userBackground { get; set; }
        public bool userIsOnline { get; set; }
        public Userbadge[] userBadges { get; set; }
        public int userActiveWants { get; set; }
        public string userWants { get; set; }
        public bool userIsOtherActiveWants { get; set; }
        public string userWantsHiredPercent { get; set; }
        public object userAlreadyWork { get; set; }
        public object currentUserReviewType { get; set; }
        public string categoryName { get; set; }
        public string parentCategoryName { get; set; }
    }

    public class File1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Userbadge
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int? payer_level { get; set; }
        public bool is_super_payer { get; set; }
        public string image_url { get; set; }
    }
}
