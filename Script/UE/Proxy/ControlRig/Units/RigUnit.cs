using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit")]
	public partial class FRigUnit : FRigVMStruct, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit()
		{
		}

		public static bool operator ==(FRigUnit A, FRigUnit B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit A, FRigUnit B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}