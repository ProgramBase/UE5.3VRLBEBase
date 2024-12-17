using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleCos")]
	public partial class FRigVMFunction_MathDoubleCos : FRigVMFunction_MathDoubleUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleCos");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleCos()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleCos A, FRigVMFunction_MathDoubleCos B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleCos A, FRigVMFunction_MathDoubleCos B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleCos;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}