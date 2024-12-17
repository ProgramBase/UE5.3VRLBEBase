using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TextureAllMipDataProviderFactory")]
	public partial class UTextureAllMipDataProviderFactory : UTextureMipDataProviderFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.TextureAllMipDataProviderFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}