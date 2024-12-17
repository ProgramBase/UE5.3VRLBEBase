using Script.CoreUObject;
using Script.Library;

namespace Script.MeshDescription
{
	[PathName("/Script/MeshDescription.UVID")]
	public partial class FUVID : FElementID, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshDescription.UVID");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FUVID()
		{
		}

		public static bool operator ==(FUVID A, FUVID B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FUVID A, FUVID B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FUVID;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}