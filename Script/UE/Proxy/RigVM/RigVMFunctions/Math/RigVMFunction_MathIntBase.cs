using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathIntBase")]
	public partial class FRigVMFunction_MathIntBase : FRigVMFunction_MathBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathIntBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathIntBase()
		{
		}

		public static bool operator ==(FRigVMFunction_MathIntBase A, FRigVMFunction_MathIntBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathIntBase A, FRigVMFunction_MathIntBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathIntBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}