using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathBoolConstFalse")]
	public partial class FRigVMFunction_MathBoolConstFalse : FRigVMFunction_MathBoolConstant, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathBoolConstFalse");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathBoolConstFalse()
		{
		}

		public static bool operator ==(FRigVMFunction_MathBoolConstFalse A, FRigVMFunction_MathBoolConstFalse B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathBoolConstFalse A, FRigVMFunction_MathBoolConstFalse B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathBoolConstFalse;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}