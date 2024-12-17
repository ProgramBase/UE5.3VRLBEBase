using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatBase")]
	public partial class FRigVMFunction_MathFloatBase : FRigVMFunction_MathBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatBase()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatBase A, FRigVMFunction_MathFloatBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatBase A, FRigVMFunction_MathFloatBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}