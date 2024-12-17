using Script.CoreUObject;
using Script.Library;

namespace Script.AutomationMessages
{
	[PathName("/Script/AutomationMessages.AutomationWorkerWorkerOffline")]
	public partial class FAutomationWorkerWorkerOffline : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AutomationMessages.AutomationWorkerWorkerOffline");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAutomationWorkerWorkerOffline() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAutomationWorkerWorkerOffline() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAutomationWorkerWorkerOffline A, FAutomationWorkerWorkerOffline B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAutomationWorkerWorkerOffline A, FAutomationWorkerWorkerOffline B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAutomationWorkerWorkerOffline;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}