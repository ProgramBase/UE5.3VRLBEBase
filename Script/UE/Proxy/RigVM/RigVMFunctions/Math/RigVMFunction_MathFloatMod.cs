using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatMod")]
	public partial class FRigVMFunction_MathFloatMod : FRigVMFunction_MathFloatBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatMod");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatMod()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatMod A, FRigVMFunction_MathFloatMod B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatMod A, FRigVMFunction_MathFloatMod B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatMod;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}