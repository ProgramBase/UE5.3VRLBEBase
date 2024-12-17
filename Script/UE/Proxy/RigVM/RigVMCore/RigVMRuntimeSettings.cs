using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMRuntimeSettings")]
	public partial class FRigVMRuntimeSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMRuntimeSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMRuntimeSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMRuntimeSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMRuntimeSettings A, FRigVMRuntimeSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMRuntimeSettings A, FRigVMRuntimeSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMRuntimeSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int MaximumArraySize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaximumArraySize, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaximumArraySize, __InBuffer);
				}
			}
		}

		public bool bEnableProfiling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEnableProfiling, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEnableProfiling, __InBuffer);
				}
			}
		}

		private static uint __MaximumArraySize = 0;

		private static uint __bEnableProfiling = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}