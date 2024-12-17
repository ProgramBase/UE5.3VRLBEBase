using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ThumbnailInfo")]
	public partial class UThumbnailInfo : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ThumbnailInfo");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}