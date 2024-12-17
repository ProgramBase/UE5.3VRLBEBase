using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMRemoveDecoratorAction")]
	public partial class FRigVMRemoveDecoratorAction : FRigVMAddDecoratorAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMRemoveDecoratorAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMRemoveDecoratorAction()
		{
		}

		public static bool operator ==(FRigVMRemoveDecoratorAction A, FRigVMRemoveDecoratorAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMRemoveDecoratorAction A, FRigVMRemoveDecoratorAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMRemoveDecoratorAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}