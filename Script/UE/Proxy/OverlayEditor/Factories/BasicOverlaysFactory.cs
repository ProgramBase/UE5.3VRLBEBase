using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.OverlayEditor
{
	[PathName("/Script/OverlayEditor.BasicOverlaysFactory")]
	public partial class UBasicOverlaysFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OverlayEditor.BasicOverlaysFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}