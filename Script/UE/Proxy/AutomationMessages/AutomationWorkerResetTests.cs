using Script.CoreUObject;
using Script.Library;

namespace Script.AutomationMessages
{
	[PathName("/Script/AutomationMessages.AutomationWorkerResetTests")]
	public partial class FAutomationWorkerResetTests : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AutomationMessages.AutomationWorkerResetTests");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAutomationWorkerResetTests() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAutomationWorkerResetTests() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAutomationWorkerResetTests A, FAutomationWorkerResetTests B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAutomationWorkerResetTests A, FAutomationWorkerResetTests B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAutomationWorkerResetTests;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}