using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.VirtualTexturingEditor
{
	[PathName("/Script/VirtualTexturingEditor.RuntimeVirtualTextureThumbnailRenderer")]
	public partial class URuntimeVirtualTextureThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VirtualTexturingEditor.RuntimeVirtualTextureThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}