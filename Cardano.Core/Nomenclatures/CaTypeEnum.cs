namespace Cardano.Core.Nomenclatures
{
	public class CaTypeEnum
	{
		protected readonly string Value;

		public static readonly CaTypeEnum CPubKeyAddress = new CaTypeEnum(nameof(CPubKeyAddress));
		public static readonly CaTypeEnum CRedeemAddress = new CaTypeEnum(nameof(CRedeemAddress));

		protected CaTypeEnum(string value)
		{
			Value = value;
		}

		public string GetValue()
			=> Value;
	}
}
