namespace Cardano.Core.Nomenclatures
{
	public class DelegationStatusEnum
	{
		protected readonly string Value;

		public static readonly DelegationStatusEnum NotDelegating = new DelegationStatusEnum("not_delegating");
		public static readonly DelegationStatusEnum Delegating = new DelegationStatusEnum("delegating");

		protected DelegationStatusEnum(string value)
		{
			Value = value;
		}

		public string GetValue()
			=> Value;
	}
}
