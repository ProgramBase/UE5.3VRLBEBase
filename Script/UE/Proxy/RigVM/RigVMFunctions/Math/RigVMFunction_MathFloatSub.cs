using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatSub")]
	public partial class FRigVMFunction_MathFloatSub : FRigVMFunction_MathFloatBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatSub");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatSub()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatSub A, FRigVMFunction_MathFloatSub B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatSub A, FRigVMFunction_MathFloatSub B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatSub;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}