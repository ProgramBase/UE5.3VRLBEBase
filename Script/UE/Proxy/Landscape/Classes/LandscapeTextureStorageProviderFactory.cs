using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeTextureStorageProviderFactory")]
	public partial class ULandscapeTextureStorageProviderFactory : UTextureAllMipDataProviderFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Landscape.LandscapeTextureStorageProviderFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}