using Script.CoreUObject;
using Script.Library;

namespace Script.MeshDescription
{
	[PathName("/Script/MeshDescription.VertexInstanceID")]
	public partial class FVertexInstanceID : FElementID, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshDescription.VertexInstanceID");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVertexInstanceID()
		{
		}

		public static bool operator ==(FVertexInstanceID A, FVertexInstanceID B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVertexInstanceID A, FVertexInstanceID B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVertexInstanceID;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}