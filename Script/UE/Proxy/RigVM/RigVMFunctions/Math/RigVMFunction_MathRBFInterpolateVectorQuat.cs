using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathRBFInterpolateVectorQuat")]
	public partial class FRigVMFunction_MathRBFInterpolateVectorQuat : FRigVMFunction_MathRBFInterpolateVectorBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathRBFInterpolateVectorQuat");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathRBFInterpolateVectorQuat()
		{
		}

		public static bool operator ==(FRigVMFunction_MathRBFInterpolateVectorQuat A, FRigVMFunction_MathRBFInterpolateVectorQuat B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathRBFInterpolateVectorQuat A, FRigVMFunction_MathRBFInterpolateVectorQuat B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathRBFInterpolateVectorQuat;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FMathRBFInterpolateVectorQuat_Target> Targets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Targets, __ReturnBuffer);

					return *(TArray<FMathRBFInterpolateVectorQuat_Target>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Targets, __InBuffer);
				}
			}
		}

		public FQuat Output
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Output, __ReturnBuffer);

					return *(FQuat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Output, __InBuffer);
				}
			}
		}

		private static uint __Targets = 0;

		private static uint __Output = 0;

	}
}