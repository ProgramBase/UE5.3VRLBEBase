using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_HierarchyBaseMutable")]
	public partial class FRigUnit_HierarchyBaseMutable : FRigUnitMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_HierarchyBaseMutable");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_HierarchyBaseMutable()
		{
		}

		public static bool operator ==(FRigUnit_HierarchyBaseMutable A, FRigUnit_HierarchyBaseMutable B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_HierarchyBaseMutable A, FRigUnit_HierarchyBaseMutable B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_HierarchyBaseMutable;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}