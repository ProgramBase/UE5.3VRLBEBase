using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleMod")]
	public partial class FRigVMFunction_MathDoubleMod : FRigVMFunction_MathDoubleBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleMod");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleMod()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleMod A, FRigVMFunction_MathDoubleMod B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleMod A, FRigVMFunction_MathDoubleMod B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleMod;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}