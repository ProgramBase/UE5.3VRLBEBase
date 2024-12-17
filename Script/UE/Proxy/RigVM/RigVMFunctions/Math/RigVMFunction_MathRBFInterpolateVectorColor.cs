using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathRBFInterpolateVectorColor")]
	public partial class FRigVMFunction_MathRBFInterpolateVectorColor : FRigVMFunction_MathRBFInterpolateVectorBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathRBFInterpolateVectorColor");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathRBFInterpolateVectorColor()
		{
		}

		public static bool operator ==(FRigVMFunction_MathRBFInterpolateVectorColor A, FRigVMFunction_MathRBFInterpolateVectorColor B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathRBFInterpolateVectorColor A, FRigVMFunction_MathRBFInterpolateVectorColor B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathRBFInterpolateVectorColor;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FMathRBFInterpolateVectorColor_Target> Targets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Targets, __ReturnBuffer);

					return *(TArray<FMathRBFInterpolateVectorColor_Target>*)__ReturnBuffer;
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

		public FLinearColor Output
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Output, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
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