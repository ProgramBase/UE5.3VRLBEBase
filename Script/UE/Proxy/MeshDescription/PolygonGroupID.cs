using Script.CoreUObject;
using Script.Library;

namespace Script.MeshDescription
{
	[PathName("/Script/MeshDescription.PolygonGroupID")]
	public partial class FPolygonGroupID : FElementID, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshDescription.PolygonGroupID");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPolygonGroupID()
		{
		}

		public static bool operator ==(FPolygonGroupID A, FPolygonGroupID B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPolygonGroupID A, FPolygonGroupID B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPolygonGroupID;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}