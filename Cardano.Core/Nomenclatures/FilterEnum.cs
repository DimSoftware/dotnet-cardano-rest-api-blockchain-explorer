namespace Cardano.Core.Nomenclatures
{
	public class FilterEnum
	{
		protected readonly string Value;

		public static readonly FilterEnum Redeemed = new FilterEnum("redeemed");
		public static readonly FilterEnum NotRedeemed = new FilterEnum("notredeemed");
		public static readonly FilterEnum All = new FilterEnum("all");

		protected FilterEnum(string value)
		{
			Value = value;
		}

		public string GetValue()
			=> Value;
	}
}
