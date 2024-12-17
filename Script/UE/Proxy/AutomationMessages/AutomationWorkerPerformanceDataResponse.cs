using Script.CoreUObject;
using Script.Library;

namespace Script.AutomationMessages
{
	[PathName("/Script/AutomationMessages.AutomationWorkerPerformanceDataResponse")]
	public partial class FAutomationWorkerPerformanceDataResponse : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AutomationMessages.AutomationWorkerPerformanceDataResponse");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAutomationWorkerPerformanceDataResponse() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAutomationWorkerPerformanceDataResponse() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAutomationWorkerPerformanceDataResponse A, FAutomationWorkerPerformanceDataResponse B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAutomationWorkerPerformanceDataResponse A, FAutomationWorkerPerformanceDataResponse B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAutomationWorkerPerformanceDataResponse;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bSuccess
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSuccess, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSuccess, __InBuffer);
				}
			}
		}

		public FString ErrorMessage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ErrorMessage, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ErrorMessage, __InBuffer);
				}
			}
		}

		private static uint __bSuccess = 0;

		private static uint __ErrorMessage = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}