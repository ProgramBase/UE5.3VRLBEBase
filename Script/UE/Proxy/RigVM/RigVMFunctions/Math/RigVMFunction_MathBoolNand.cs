using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathBoolNand")]
	public partial class FRigVMFunction_MathBoolNand : FRigVMFunction_MathBoolBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathBoolNand");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathBoolNand()
		{
		}

		public static bool operator ==(FRigVMFunction_MathBoolNand A, FRigVMFunction_MathBoolNand B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathBoolNand A, FRigVMFunction_MathBoolNand B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathBoolNand;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}