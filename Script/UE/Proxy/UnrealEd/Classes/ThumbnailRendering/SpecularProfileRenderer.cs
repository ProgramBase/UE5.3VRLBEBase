using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SpecularProfileRenderer")]
	public partial class USpecularProfileRenderer : UTextureThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SpecularProfileRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}