using Script.CoreUObject;
using Script.Library;

namespace Script.AutomationMessages
{
	[PathName("/Script/AutomationMessages.AutomationWorkerFindWorkers")]
	public partial class FAutomationWorkerFindWorkers : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AutomationMessages.AutomationWorkerFindWorkers");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAutomationWorkerFindWorkers() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAutomationWorkerFindWorkers() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAutomationWorkerFindWorkers A, FAutomationWorkerFindWorkers B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAutomationWorkerFindWorkers A, FAutomationWorkerFindWorkers B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAutomationWorkerFindWorkers;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Changelist
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Changelist, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Changelist, __InBuffer);
				}
			}
		}

		public FString GameName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameName, __InBuffer);
				}
			}
		}

		public FString ProcessName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProcessName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProcessName, __InBuffer);
				}
			}
		}

		public FGuid SessionId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SessionId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SessionId, __InBuffer);
				}
			}
		}

		private static uint __Changelist = 0;

		private static uint __GameName = 0;

		private static uint __ProcessName = 0;

		private static uint __SessionId = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}