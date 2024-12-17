using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PreviewMaterial")]
	public partial class UPreviewMaterial : UMaterial, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.PreviewMaterial");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}