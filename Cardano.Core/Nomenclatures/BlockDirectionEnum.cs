namespace Cardano.Core.Nomenclatures
{
	public class BlockDirectionEnum
	{
		protected readonly string Value;

		public static readonly BlockDirectionEnum Outgoing = new BlockDirectionEnum("outgoing");
		public static readonly BlockDirectionEnum Incoming = new BlockDirectionEnum("incoming");

		protected BlockDirectionEnum(string value)
		{
			Value = value;
		}

		public string GetValue()
			=> Value;
	}
}
