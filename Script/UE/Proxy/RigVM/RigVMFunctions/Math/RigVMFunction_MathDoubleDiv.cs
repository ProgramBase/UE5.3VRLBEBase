using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleDiv")]
	public partial class FRigVMFunction_MathDoubleDiv : FRigVMFunction_MathDoubleBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleDiv");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleDiv()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleDiv A, FRigVMFunction_MathDoubleDiv B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleDiv A, FRigVMFunction_MathDoubleDiv B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleDiv;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}