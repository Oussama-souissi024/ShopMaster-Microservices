namespace ShopMaster.Web.Utility
{
	public class SD
	{
		public static string? CouponAPIBase {  get; set; }
        public static string? PrroductAPIBase { get; set; }
        public static string? AuthAPIBase { get; set; }
        public static string? ShoppingCardAPIBase { get; set; }

        public const string RoleAdmin = "ADMIN";
        public const string RoleCustomer = "CUSTOMER";
        public const string TokenCookie = "JWTToken";

        public enum ApiType
		{
			GET,
			POST,
			PUT,
			DELETE
		}
	}
}
