using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorMakeBezierFourPoint")]
	public partial class FRigVMFunction_MathVectorMakeBezierFourPoint : FRigVMFunction_MathVectorBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorMakeBezierFourPoint");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorMakeBezierFourPoint()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorMakeBezierFourPoint A, FRigVMFunction_MathVectorMakeBezierFourPoint B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorMakeBezierFourPoint A, FRigVMFunction_MathVectorMakeBezierFourPoint B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorMakeBezierFourPoint;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigVMFourPointBezier Bezier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Bezier, __ReturnBuffer);

					return *(FRigVMFourPointBezier*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Bezier, __InBuffer);
				}
			}
		}

		private static uint __Bezier = 0;

	}
}