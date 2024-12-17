using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathTransformInverse")]
	public partial class FRigVMFunction_MathTransformInverse : FRigVMFunction_MathTransformUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathTransformInverse");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathTransformInverse()
		{
		}

		public static bool operator ==(FRigVMFunction_MathTransformInverse A, FRigVMFunction_MathTransformInverse B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathTransformInverse A, FRigVMFunction_MathTransformInverse B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathTransformInverse;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}