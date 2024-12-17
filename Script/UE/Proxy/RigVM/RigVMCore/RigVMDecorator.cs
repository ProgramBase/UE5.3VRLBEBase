using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDecorator")]
	public partial class FRigVMDecorator : FRigVMStruct, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDecorator");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDecorator()
		{
		}

		public static bool operator ==(FRigVMDecorator A, FRigVMDecorator B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDecorator A, FRigVMDecorator B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDecorator;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}