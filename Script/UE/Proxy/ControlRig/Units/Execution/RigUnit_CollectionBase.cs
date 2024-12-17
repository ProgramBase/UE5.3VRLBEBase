using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_CollectionBase")]
	public partial class FRigUnit_CollectionBase : FRigUnit, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_CollectionBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_CollectionBase()
		{
		}

		public static bool operator ==(FRigUnit_CollectionBase A, FRigUnit_CollectionBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_CollectionBase A, FRigUnit_CollectionBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_CollectionBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}