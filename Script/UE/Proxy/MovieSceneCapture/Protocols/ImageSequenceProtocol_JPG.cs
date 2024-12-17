using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.ImageSequenceProtocol_JPG")]
	public partial class UImageSequenceProtocol_JPG : UCompressedImageSequenceProtocol, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneCapture.ImageSequenceProtocol_JPG");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}