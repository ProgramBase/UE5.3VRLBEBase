using Script.CoreUObject;
using Script.Library;

namespace Script.AutomationMessages
{
	[PathName("/Script/AutomationMessages.AutomationWorkerRequestTests")]
	public partial class FAutomationWorkerRequestTests : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AutomationMessages.AutomationWorkerRequestTests");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAutomationWorkerRequestTests() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAutomationWorkerRequestTests() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAutomationWorkerRequestTests A, FAutomationWorkerRequestTests B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAutomationWorkerRequestTests A, FAutomationWorkerRequestTests B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAutomationWorkerRequestTests;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool DeveloperDirectoryIncluded
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DeveloperDirectoryIncluded, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DeveloperDirectoryIncluded, __InBuffer);
				}
			}
		}

		public uint RequestedTestFlags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RequestedTestFlags, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RequestedTestFlags, __InBuffer);
				}
			}
		}

		private static uint __DeveloperDirectoryIncluded = 0;

		private static uint __RequestedTestFlags = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}