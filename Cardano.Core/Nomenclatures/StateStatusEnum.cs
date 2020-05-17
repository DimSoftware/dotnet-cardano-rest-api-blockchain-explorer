namespace Cardano.Core.Nomenclatures
{
	public class StateStatusEnum
	{
		protected readonly string Value;

		public static readonly StateStatusEnum Ready = new StateStatusEnum("ready");
		public static readonly StateStatusEnum Syncing = new StateStatusEnum("syncing");
		public static readonly StateStatusEnum NotResponding = new StateStatusEnum("not_responding");

		protected StateStatusEnum(string value)
		{
			Value = value;
		}

		public string GetValue()
			=> Value;
	}
}
