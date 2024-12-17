using Script.CoreUObject;
using Script.Library;

namespace Script.MeshDescription
{
	[PathName("/Script/MeshDescription.BoneID")]
	public partial class FBoneID : FElementID, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshDescription.BoneID");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBoneID()
		{
		}

		public static bool operator ==(FBoneID A, FBoneID B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBoneID A, FBoneID B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBoneID;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}