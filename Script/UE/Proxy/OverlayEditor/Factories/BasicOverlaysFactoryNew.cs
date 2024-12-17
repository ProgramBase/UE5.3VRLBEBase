using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.OverlayEditor
{
	[PathName("/Script/OverlayEditor.BasicOverlaysFactoryNew")]
	public partial class UBasicOverlaysFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OverlayEditor.BasicOverlaysFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}