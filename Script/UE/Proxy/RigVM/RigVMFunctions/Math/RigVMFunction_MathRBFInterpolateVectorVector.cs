using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathRBFInterpolateVectorVector")]
	public partial class FRigVMFunction_MathRBFInterpolateVectorVector : FRigVMFunction_MathRBFInterpolateVectorBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathRBFInterpolateVectorVector");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathRBFInterpolateVectorVector()
		{
		}

		public static bool operator ==(FRigVMFunction_MathRBFInterpolateVectorVector A, FRigVMFunction_MathRBFInterpolateVectorVector B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathRBFInterpolateVectorVector A, FRigVMFunction_MathRBFInterpolateVectorVector B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathRBFInterpolateVectorVector;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FMathRBFInterpolateVectorVector_Target> Targets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Targets, __ReturnBuffer);

					return *(TArray<FMathRBFInterpolateVectorVector_Target>*)__ReturnBuffer;
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

		public FVector Output
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Output, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
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