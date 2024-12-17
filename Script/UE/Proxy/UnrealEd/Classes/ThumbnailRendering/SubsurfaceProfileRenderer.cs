using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SubsurfaceProfileRenderer")]
	public partial class USubsurfaceProfileRenderer : UTextureThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SubsurfaceProfileRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}