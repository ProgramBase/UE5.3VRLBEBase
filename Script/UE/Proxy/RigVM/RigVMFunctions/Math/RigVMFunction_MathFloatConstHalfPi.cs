using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatConstHalfPi")]
	public partial class FRigVMFunction_MathFloatConstHalfPi : FRigVMFunction_MathFloatConstant, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatConstHalfPi");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatConstHalfPi()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatConstHalfPi A, FRigVMFunction_MathFloatConstHalfPi B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatConstHalfPi A, FRigVMFunction_MathFloatConstHalfPi B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatConstHalfPi;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}