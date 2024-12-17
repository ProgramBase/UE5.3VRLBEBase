using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_GetDeltaTime")]
	public partial class FRigVMFunction_GetDeltaTime : FRigVMFunction_AnimBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_GetDeltaTime");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_GetDeltaTime()
		{
		}

		public static bool operator ==(FRigVMFunction_GetDeltaTime A, FRigVMFunction_GetDeltaTime B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_GetDeltaTime A, FRigVMFunction_GetDeltaTime B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_GetDeltaTime;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Result
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Result, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Result, __InBuffer);
				}
			}
		}

		private static uint __Result = 0;

	}
}