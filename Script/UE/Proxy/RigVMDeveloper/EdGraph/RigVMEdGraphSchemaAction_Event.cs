using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMEdGraphSchemaAction_Event")]
	public partial class FRigVMEdGraphSchemaAction_Event : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMEdGraphSchemaAction_Event");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMEdGraphSchemaAction_Event()
		{
		}

		public static bool operator ==(FRigVMEdGraphSchemaAction_Event A, FRigVMEdGraphSchemaAction_Event B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMEdGraphSchemaAction_Event A, FRigVMEdGraphSchemaAction_Event B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMEdGraphSchemaAction_Event;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}