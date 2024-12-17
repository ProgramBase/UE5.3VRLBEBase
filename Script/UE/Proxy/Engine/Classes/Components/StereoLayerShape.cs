using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StereoLayerShape")]
	public partial class UStereoLayerShape : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.StereoLayerShape");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}