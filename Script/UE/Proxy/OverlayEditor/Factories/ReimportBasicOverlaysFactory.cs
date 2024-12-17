using Script.CoreUObject;
using Script.Library;

namespace Script.OverlayEditor
{
	[PathName("/Script/OverlayEditor.ReimportBasicOverlaysFactory")]
	public partial class UReimportBasicOverlaysFactory : UBasicOverlaysFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OverlayEditor.ReimportBasicOverlaysFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}