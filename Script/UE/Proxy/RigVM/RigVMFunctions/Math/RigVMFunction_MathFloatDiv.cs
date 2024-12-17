using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatDiv")]
	public partial class FRigVMFunction_MathFloatDiv : FRigVMFunction_MathFloatBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatDiv");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatDiv()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatDiv A, FRigVMFunction_MathFloatDiv B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatDiv A, FRigVMFunction_MathFloatDiv B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatDiv;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}