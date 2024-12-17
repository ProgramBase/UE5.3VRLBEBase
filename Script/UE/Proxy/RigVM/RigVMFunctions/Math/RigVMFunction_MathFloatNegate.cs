using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatNegate")]
	public partial class FRigVMFunction_MathFloatNegate : FRigVMFunction_MathFloatUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatNegate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatNegate()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatNegate A, FRigVMFunction_MathFloatNegate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatNegate A, FRigVMFunction_MathFloatNegate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatNegate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}