using Script.CoreUObject;
using Script.Library;

namespace Script.AutomationMessages
{
	[PathName("/Script/AutomationMessages.AutomationWorkerPing")]
	public partial class FAutomationWorkerPing : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AutomationMessages.AutomationWorkerPing");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAutomationWorkerPing() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAutomationWorkerPing() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAutomationWorkerPing A, FAutomationWorkerPing B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAutomationWorkerPing A, FAutomationWorkerPing B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAutomationWorkerPing;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}