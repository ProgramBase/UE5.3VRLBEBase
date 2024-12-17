using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleConstHalfPi")]
	public partial class FRigVMFunction_MathDoubleConstHalfPi : FRigVMFunction_MathDoubleConstant, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleConstHalfPi");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleConstHalfPi()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleConstHalfPi A, FRigVMFunction_MathDoubleConstHalfPi B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleConstHalfPi A, FRigVMFunction_MathDoubleConstHalfPi B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleConstHalfPi;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}