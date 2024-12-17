using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.PreviewPlayerCameraManager")]
	public partial class APreviewPlayerCameraManager : APlayerCameraManager, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.PreviewPlayerCameraManager");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}