using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_CollectionBaseMutable")]
	public partial class FRigUnit_CollectionBaseMutable : FRigUnitMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_CollectionBaseMutable");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_CollectionBaseMutable()
		{
		}

		public static bool operator ==(FRigUnit_CollectionBaseMutable A, FRigUnit_CollectionBaseMutable B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_CollectionBaseMutable A, FRigUnit_CollectionBaseMutable B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_CollectionBaseMutable;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}