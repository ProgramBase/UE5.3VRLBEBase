using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_DynamicHierarchyBase")]
	public partial class FRigUnit_DynamicHierarchyBase : FRigUnit, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_DynamicHierarchyBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_DynamicHierarchyBase()
		{
		}

		public static bool operator ==(FRigUnit_DynamicHierarchyBase A, FRigUnit_DynamicHierarchyBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_DynamicHierarchyBase A, FRigUnit_DynamicHierarchyBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_DynamicHierarchyBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}