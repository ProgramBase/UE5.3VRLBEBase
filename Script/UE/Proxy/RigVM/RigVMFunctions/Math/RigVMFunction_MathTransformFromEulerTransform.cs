using Script.CoreUObject;
using Script.Library;
using Script.AnimationCore;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathTransformFromEulerTransform")]
	public partial class FRigVMFunction_MathTransformFromEulerTransform : FRigVMFunction_MathTransformBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathTransformFromEulerTransform");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathTransformFromEulerTransform()
		{
		}

		public static bool operator ==(FRigVMFunction_MathTransformFromEulerTransform A, FRigVMFunction_MathTransformFromEulerTransform B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathTransformFromEulerTransform A, FRigVMFunction_MathTransformFromEulerTransform B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathTransformFromEulerTransform;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FEulerTransform EulerTransform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EulerTransform, __ReturnBuffer);

					return *(FEulerTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EulerTransform, __InBuffer);
				}
			}
		}

		public FTransform Result
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Result, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Result, __InBuffer);
				}
			}
		}

		private static uint __EulerTransform = 0;

		private static uint __Result = 0;

	}
}