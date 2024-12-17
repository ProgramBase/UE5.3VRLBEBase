using Script.CoreUObject;
using Script.Library;

namespace Script.AutomationMessages
{
	[PathName("/Script/AutomationMessages.AutomationWorkerRequestTestsReplyComplete")]
	public partial class FAutomationWorkerRequestTestsReplyComplete : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AutomationMessages.AutomationWorkerRequestTestsReplyComplete");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAutomationWorkerRequestTestsReplyComplete() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAutomationWorkerRequestTestsReplyComplete() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAutomationWorkerRequestTestsReplyComplete A, FAutomationWorkerRequestTestsReplyComplete B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAutomationWorkerRequestTestsReplyComplete A, FAutomationWorkerRequestTestsReplyComplete B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAutomationWorkerRequestTestsReplyComplete;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FAutomationWorkerSingleTestReply> Tests
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Tests, __ReturnBuffer);

					return *(TArray<FAutomationWorkerSingleTestReply>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Tests, __InBuffer);
				}
			}
		}

		private static uint __Tests = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}