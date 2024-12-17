using Script.CoreUObject;
using Script.Library;

namespace Script.MeshDescription
{
	[PathName("/Script/MeshDescription.TriangleID")]
	public partial class FTriangleID : FElementID, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshDescription.TriangleID");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTriangleID()
		{
		}

		public static bool operator ==(FTriangleID A, FTriangleID B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTriangleID A, FTriangleID B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTriangleID;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}