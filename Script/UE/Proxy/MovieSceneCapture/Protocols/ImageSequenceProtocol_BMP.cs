using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.ImageSequenceProtocol_BMP")]
	public partial class UImageSequenceProtocol_BMP : UImageSequenceProtocol, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneCapture.ImageSequenceProtocol_BMP");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}