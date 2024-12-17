using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorBase")]
	public partial class FRigVMFunction_MathVectorBase : FRigVMFunction_MathBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorBase()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorBase A, FRigVMFunction_MathVectorBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorBase A, FRigVMFunction_MathVectorBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}