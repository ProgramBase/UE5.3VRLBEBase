using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatSin")]
	public partial class FRigVMFunction_MathFloatSin : FRigVMFunction_MathFloatUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatSin");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatSin()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatSin A, FRigVMFunction_MathFloatSin B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatSin A, FRigVMFunction_MathFloatSin B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatSin;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}