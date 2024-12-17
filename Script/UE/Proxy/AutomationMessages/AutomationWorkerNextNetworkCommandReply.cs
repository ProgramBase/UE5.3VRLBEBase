using Script.CoreUObject;
using Script.Library;

namespace Script.AutomationMessages
{
	[PathName("/Script/AutomationMessages.AutomationWorkerNextNetworkCommandReply")]
	public partial class FAutomationWorkerNextNetworkCommandReply : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AutomationMessages.AutomationWorkerNextNetworkCommandReply");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAutomationWorkerNextNetworkCommandReply() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAutomationWorkerNextNetworkCommandReply() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAutomationWorkerNextNetworkCommandReply A, FAutomationWorkerNextNetworkCommandReply B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAutomationWorkerNextNetworkCommandReply A, FAutomationWorkerNextNetworkCommandReply B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAutomationWorkerNextNetworkCommandReply;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}