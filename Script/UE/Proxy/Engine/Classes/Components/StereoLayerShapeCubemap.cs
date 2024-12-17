using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StereoLayerShapeCubemap")]
	public partial class UStereoLayerShapeCubemap : UStereoLayerShape, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.StereoLayerShapeCubemap");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}