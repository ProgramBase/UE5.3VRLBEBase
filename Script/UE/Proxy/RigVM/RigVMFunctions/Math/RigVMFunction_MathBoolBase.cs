using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathBoolBase")]
	public partial class FRigVMFunction_MathBoolBase : FRigVMFunction_MathBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathBoolBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathBoolBase()
		{
		}

		public static bool operator ==(FRigVMFunction_MathBoolBase A, FRigVMFunction_MathBoolBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathBoolBase A, FRigVMFunction_MathBoolBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathBoolBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}