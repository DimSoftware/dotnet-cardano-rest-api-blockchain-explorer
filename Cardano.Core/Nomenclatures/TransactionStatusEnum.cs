namespace Cardano.Core.Nomenclatures
{
	public class TransactionStatusEnum
	{
		protected readonly string Value;

		public static readonly TransactionStatusEnum Pending = new TransactionStatusEnum("pending");
		public static readonly TransactionStatusEnum InLedger = new TransactionStatusEnum("in_ledger");

		protected TransactionStatusEnum(string value)
		{
			Value = value;
		}

		public string GetValue()
			=> Value;
	}
}
