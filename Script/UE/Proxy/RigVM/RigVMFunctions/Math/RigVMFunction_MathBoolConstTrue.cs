using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathBoolConstTrue")]
	public partial class FRigVMFunction_MathBoolConstTrue : FRigVMFunction_MathBoolConstant, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathBoolConstTrue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathBoolConstTrue()
		{
		}

		public static bool operator ==(FRigVMFunction_MathBoolConstTrue A, FRigVMFunction_MathBoolConstTrue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathBoolConstTrue A, FRigVMFunction_MathBoolConstTrue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathBoolConstTrue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}