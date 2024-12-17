using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleConstPi")]
	public partial class FRigVMFunction_MathDoubleConstPi : FRigVMFunction_MathDoubleConstant, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleConstPi");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleConstPi()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleConstPi A, FRigVMFunction_MathDoubleConstPi B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleConstPi A, FRigVMFunction_MathDoubleConstPi B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleConstPi;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}