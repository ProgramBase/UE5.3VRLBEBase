using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathBase")]
	public partial class FRigVMFunction_MathBase : FRigVMStruct, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathBase()
		{
		}

		public static bool operator ==(FRigVMFunction_MathBase A, FRigVMFunction_MathBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathBase A, FRigVMFunction_MathBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}