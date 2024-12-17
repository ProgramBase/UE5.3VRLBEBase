using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StereoLayerShapeQuad")]
	public partial class UStereoLayerShapeQuad : UStereoLayerShape, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.StereoLayerShapeQuad");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}