using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleBase")]
	public partial class FRigVMFunction_MathDoubleBase : FRigVMFunction_MathBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleBase()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleBase A, FRigVMFunction_MathDoubleBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleBase A, FRigVMFunction_MathDoubleBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}