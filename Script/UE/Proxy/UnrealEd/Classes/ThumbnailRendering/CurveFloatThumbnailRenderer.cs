using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.CurveFloatThumbnailRenderer")]
	public partial class UCurveFloatThumbnailRenderer : UThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.CurveFloatThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}