using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleConstE")]
	public partial class FRigVMFunction_MathDoubleConstE : FRigVMFunction_MathDoubleConstant, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleConstE");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleConstE()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleConstE A, FRigVMFunction_MathDoubleConstE B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleConstE A, FRigVMFunction_MathDoubleConstE B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleConstE;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}