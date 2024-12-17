using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Bookmark2DJumpToSettings")]
	public partial class FBookmark2DJumpToSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.Bookmark2DJumpToSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBookmark2DJumpToSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBookmark2DJumpToSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBookmark2DJumpToSettings A, FBookmark2DJumpToSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBookmark2DJumpToSettings A, FBookmark2DJumpToSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBookmark2DJumpToSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}