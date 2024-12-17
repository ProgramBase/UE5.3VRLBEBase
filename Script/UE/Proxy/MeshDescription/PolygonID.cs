using Script.CoreUObject;
using Script.Library;

namespace Script.MeshDescription
{
	[PathName("/Script/MeshDescription.PolygonID")]
	public partial class FPolygonID : FElementID, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshDescription.PolygonID");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPolygonID()
		{
		}

		public static bool operator ==(FPolygonID A, FPolygonID B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPolygonID A, FPolygonID B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPolygonID;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}