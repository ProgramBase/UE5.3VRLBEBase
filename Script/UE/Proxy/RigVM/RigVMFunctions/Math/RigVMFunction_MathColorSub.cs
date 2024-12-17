using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathColorSub")]
	public partial class FRigVMFunction_MathColorSub : FRigVMFunction_MathColorBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathColorSub");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathColorSub()
		{
		}

		public static bool operator ==(FRigVMFunction_MathColorSub A, FRigVMFunction_MathColorSub B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathColorSub A, FRigVMFunction_MathColorSub B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathColorSub;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}