using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BookmarkJumpToSettings")]
	public partial class FBookmarkJumpToSettings : FBookmarkBaseJumpToSettings, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BookmarkJumpToSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBookmarkJumpToSettings()
		{
		}

		public static bool operator ==(FBookmarkJumpToSettings A, FBookmarkJumpToSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBookmarkJumpToSettings A, FBookmarkJumpToSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBookmarkJumpToSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}