using Script.CoreUObject;
using Script.Library;

namespace Script.Overlay
{
	[PathName("/Script/Overlay.Overlays")]
	public partial class UOverlays : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Overlay.Overlays");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}