using Script.CoreUObject;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.AutomationWaitForLoadingOptions")]
	public partial class FAutomationWaitForLoadingOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/FunctionalTesting.AutomationWaitForLoadingOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAutomationWaitForLoadingOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAutomationWaitForLoadingOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAutomationWaitForLoadingOptions A, FAutomationWaitForLoadingOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAutomationWaitForLoadingOptions A, FAutomationWaitForLoadingOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAutomationWaitForLoadingOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool WaitForReplicationToSettle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WaitForReplicationToSettle, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WaitForReplicationToSettle, __InBuffer);
				}
			}
		}

		private static uint __WaitForReplicationToSettle = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}