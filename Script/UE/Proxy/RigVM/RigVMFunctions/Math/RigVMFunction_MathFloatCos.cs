using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatCos")]
	public partial class FRigVMFunction_MathFloatCos : FRigVMFunction_MathFloatUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatCos");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatCos()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatCos A, FRigVMFunction_MathFloatCos B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatCos A, FRigVMFunction_MathFloatCos B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatCos;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}