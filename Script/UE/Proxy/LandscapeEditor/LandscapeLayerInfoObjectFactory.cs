using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.LandscapeLayerInfoObjectFactory")]
	public partial class ULandscapeLayerInfoObjectFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LandscapeEditor.LandscapeLayerInfoObjectFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}