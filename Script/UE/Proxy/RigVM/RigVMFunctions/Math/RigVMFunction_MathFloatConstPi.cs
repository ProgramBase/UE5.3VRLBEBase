using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatConstPi")]
	public partial class FRigVMFunction_MathFloatConstPi : FRigVMFunction_MathFloatConstant, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatConstPi");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatConstPi()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatConstPi A, FRigVMFunction_MathFloatConstPi B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatConstPi A, FRigVMFunction_MathFloatConstPi B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatConstPi;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}