using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathQuaternionInverse")]
	public partial class FRigVMFunction_MathQuaternionInverse : FRigVMFunction_MathQuaternionUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathQuaternionInverse");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathQuaternionInverse()
		{
		}

		public static bool operator ==(FRigVMFunction_MathQuaternionInverse A, FRigVMFunction_MathQuaternionInverse B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathQuaternionInverse A, FRigVMFunction_MathQuaternionInverse B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathQuaternionInverse;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}