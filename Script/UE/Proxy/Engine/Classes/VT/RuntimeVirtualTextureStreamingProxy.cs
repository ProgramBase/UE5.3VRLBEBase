using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RuntimeVirtualTextureStreamingProxy")]
	public partial class URuntimeVirtualTextureStreamingProxy : UTexture2D, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.RuntimeVirtualTextureStreamingProxy");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}