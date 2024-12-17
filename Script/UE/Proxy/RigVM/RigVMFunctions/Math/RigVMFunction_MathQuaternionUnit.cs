using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathQuaternionUnit")]
	public partial class FRigVMFunction_MathQuaternionUnit : FRigVMFunction_MathQuaternionUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathQuaternionUnit");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathQuaternionUnit()
		{
		}

		public static bool operator ==(FRigVMFunction_MathQuaternionUnit A, FRigVMFunction_MathQuaternionUnit B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathQuaternionUnit A, FRigVMFunction_MathQuaternionUnit B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathQuaternionUnit;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}