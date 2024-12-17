using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_HierarchyBase")]
	public partial class FRigUnit_HierarchyBase : FRigUnit, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_HierarchyBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_HierarchyBase()
		{
		}

		public static bool operator ==(FRigUnit_HierarchyBase A, FRigUnit_HierarchyBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_HierarchyBase A, FRigUnit_HierarchyBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_HierarchyBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}