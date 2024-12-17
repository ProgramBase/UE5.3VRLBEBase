using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.CurveVector3ThumbnailRenderer")]
	public partial class UCurveVector3ThumbnailRenderer : UThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.CurveVector3ThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}