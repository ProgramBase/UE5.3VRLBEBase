using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleDeg")]
	public partial class FRigVMFunction_MathDoubleDeg : FRigVMFunction_MathDoubleUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleDeg");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleDeg()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleDeg A, FRigVMFunction_MathDoubleDeg B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleDeg A, FRigVMFunction_MathDoubleDeg B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleDeg;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}