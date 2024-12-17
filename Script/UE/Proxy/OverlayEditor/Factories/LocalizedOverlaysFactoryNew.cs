using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.OverlayEditor
{
	[PathName("/Script/OverlayEditor.LocalizedOverlaysFactoryNew")]
	public partial class ULocalizedOverlaysFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OverlayEditor.LocalizedOverlaysFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}