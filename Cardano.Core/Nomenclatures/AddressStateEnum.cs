namespace Cardano.Core.Nomenclatures
{
	public class AddressStateEnum
	{
		protected readonly string Value;

		public static readonly AddressStateEnum Used = new AddressStateEnum("used");
		public static readonly AddressStateEnum Unused = new AddressStateEnum("unused");

		protected AddressStateEnum(string value)
		{
			Value = value;
		}

		public string GetValue()
			=> Value;
	}
}
