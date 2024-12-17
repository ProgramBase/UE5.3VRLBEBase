using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_DynamicHierarchyBaseMutable")]
	public partial class FRigUnit_DynamicHierarchyBaseMutable : FRigUnitMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_DynamicHierarchyBaseMutable");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_DynamicHierarchyBaseMutable()
		{
		}

		public static bool operator ==(FRigUnit_DynamicHierarchyBaseMutable A, FRigUnit_DynamicHierarchyBaseMutable B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_DynamicHierarchyBaseMutable A, FRigUnit_DynamicHierarchyBaseMutable B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_DynamicHierarchyBaseMutable;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}