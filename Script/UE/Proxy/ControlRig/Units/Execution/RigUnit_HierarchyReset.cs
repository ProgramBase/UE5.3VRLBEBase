using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_HierarchyReset")]
	public partial class FRigUnit_HierarchyReset : FRigUnit_DynamicHierarchyBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_HierarchyReset");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_HierarchyReset()
		{
		}

		public static bool operator ==(FRigUnit_HierarchyReset A, FRigUnit_HierarchyReset B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_HierarchyReset A, FRigUnit_HierarchyReset B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_HierarchyReset;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}