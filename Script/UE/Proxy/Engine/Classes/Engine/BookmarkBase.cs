using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BookmarkBase")]
	public partial class UBookmarkBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.BookmarkBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}