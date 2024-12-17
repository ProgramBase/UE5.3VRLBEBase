using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathColorBase")]
	public partial class FRigVMFunction_MathColorBase : FRigVMFunction_MathBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathColorBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathColorBase()
		{
		}

		public static bool operator ==(FRigVMFunction_MathColorBase A, FRigVMFunction_MathColorBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathColorBase A, FRigVMFunction_MathColorBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathColorBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}