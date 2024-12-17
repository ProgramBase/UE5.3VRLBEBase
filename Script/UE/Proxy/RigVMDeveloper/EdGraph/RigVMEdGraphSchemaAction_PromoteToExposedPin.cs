using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMEdGraphSchemaAction_PromoteToExposedPin")]
	public partial class FRigVMEdGraphSchemaAction_PromoteToExposedPin : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMEdGraphSchemaAction_PromoteToExposedPin");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMEdGraphSchemaAction_PromoteToExposedPin()
		{
		}

		public static bool operator ==(FRigVMEdGraphSchemaAction_PromoteToExposedPin A, FRigVMEdGraphSchemaAction_PromoteToExposedPin B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMEdGraphSchemaAction_PromoteToExposedPin A, FRigVMEdGraphSchemaAction_PromoteToExposedPin B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMEdGraphSchemaAction_PromoteToExposedPin;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}