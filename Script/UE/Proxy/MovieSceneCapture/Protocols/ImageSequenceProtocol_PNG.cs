using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.ImageSequenceProtocol_PNG")]
	public partial class UImageSequenceProtocol_PNG : UCompressedImageSequenceProtocol, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneCapture.ImageSequenceProtocol_PNG");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}