using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathTransformBase")]
	public partial class FRigVMFunction_MathTransformBase : FRigVMFunction_MathBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathTransformBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathTransformBase()
		{
		}

		public static bool operator ==(FRigVMFunction_MathTransformBase A, FRigVMFunction_MathTransformBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathTransformBase A, FRigVMFunction_MathTransformBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathTransformBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}