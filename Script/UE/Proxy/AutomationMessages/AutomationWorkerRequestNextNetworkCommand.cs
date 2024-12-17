using Script.CoreUObject;
using Script.Library;

namespace Script.AutomationMessages
{
	[PathName("/Script/AutomationMessages.AutomationWorkerRequestNextNetworkCommand")]
	public partial class FAutomationWorkerRequestNextNetworkCommand : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AutomationMessages.AutomationWorkerRequestNextNetworkCommand");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAutomationWorkerRequestNextNetworkCommand() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAutomationWorkerRequestNextNetworkCommand() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAutomationWorkerRequestNextNetworkCommand A, FAutomationWorkerRequestNextNetworkCommand B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAutomationWorkerRequestNextNetworkCommand A, FAutomationWorkerRequestNextNetworkCommand B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAutomationWorkerRequestNextNetworkCommand;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public uint ExecutionCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExecutionCount, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExecutionCount, __InBuffer);
				}
			}
		}

		private static uint __ExecutionCount = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}