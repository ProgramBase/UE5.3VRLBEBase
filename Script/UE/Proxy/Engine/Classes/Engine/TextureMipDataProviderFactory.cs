using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TextureMipDataProviderFactory")]
	public partial class UTextureMipDataProviderFactory : UAssetUserData, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.TextureMipDataProviderFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}