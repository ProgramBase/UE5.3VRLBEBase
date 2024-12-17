using Script.CoreUObject;
using Script.Library;

namespace Script.MeshDescription
{
	[PathName("/Script/MeshDescription.VertexID")]
	public partial class FVertexID : FElementID, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshDescription.VertexID");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVertexID()
		{
		}

		public static bool operator ==(FVertexID A, FVertexID B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVertexID A, FVertexID B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVertexID;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}