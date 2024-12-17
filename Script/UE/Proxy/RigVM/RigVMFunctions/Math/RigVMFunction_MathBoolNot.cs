using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathBoolNot")]
	public partial class FRigVMFunction_MathBoolNot : FRigVMFunction_MathBoolUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathBoolNot");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathBoolNot()
		{
		}

		public static bool operator ==(FRigVMFunction_MathBoolNot A, FRigVMFunction_MathBoolNot B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathBoolNot A, FRigVMFunction_MathBoolNot B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathBoolNot;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}