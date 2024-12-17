using Script.CoreUObject;
using Script.Library;

namespace Script.MeshDescription
{
	[PathName("/Script/MeshDescription.EdgeID")]
	public partial class FEdgeID : FElementID, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshDescription.EdgeID");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdgeID()
		{
		}

		public static bool operator ==(FEdgeID A, FEdgeID B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdgeID A, FEdgeID B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdgeID;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}