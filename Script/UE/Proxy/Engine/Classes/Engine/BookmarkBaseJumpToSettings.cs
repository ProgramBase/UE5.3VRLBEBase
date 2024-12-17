using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BookmarkBaseJumpToSettings")]
	public partial class FBookmarkBaseJumpToSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BookmarkBaseJumpToSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBookmarkBaseJumpToSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBookmarkBaseJumpToSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBookmarkBaseJumpToSettings A, FBookmarkBaseJumpToSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBookmarkBaseJumpToSettings A, FBookmarkBaseJumpToSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBookmarkBaseJumpToSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}