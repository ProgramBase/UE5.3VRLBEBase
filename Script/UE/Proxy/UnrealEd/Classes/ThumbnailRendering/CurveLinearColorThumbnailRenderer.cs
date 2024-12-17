using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.CurveLinearColorThumbnailRenderer")]
	public partial class UCurveLinearColorThumbnailRenderer : UThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.CurveLinearColorThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}