using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatDeg")]
	public partial class FRigVMFunction_MathFloatDeg : FRigVMFunction_MathFloatUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatDeg");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatDeg()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatDeg A, FRigVMFunction_MathFloatDeg B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatDeg A, FRigVMFunction_MathFloatDeg B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatDeg;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}