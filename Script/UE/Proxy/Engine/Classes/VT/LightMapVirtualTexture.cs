using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LightMapVirtualTexture")]
	public partial class ULightMapVirtualTexture : UVirtualTexture, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LightMapVirtualTexture");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}