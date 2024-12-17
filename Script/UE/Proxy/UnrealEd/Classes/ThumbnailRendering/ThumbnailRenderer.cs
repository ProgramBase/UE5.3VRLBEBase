using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ThumbnailRenderer")]
	public partial class UThumbnailRenderer : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}