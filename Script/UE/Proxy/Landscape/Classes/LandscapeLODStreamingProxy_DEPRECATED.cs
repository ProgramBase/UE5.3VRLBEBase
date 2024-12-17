using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeLODStreamingProxy_DEPRECATED")]
	public partial class ULandscapeLODStreamingProxy_DEPRECATED : UStreamableRenderAsset, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Landscape.LandscapeLODStreamingProxy_DEPRECATED");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}