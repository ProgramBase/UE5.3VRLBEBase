using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.CompressedImageSequenceProtocol")]
	public partial class UCompressedImageSequenceProtocol : UImageSequenceProtocol, IStaticClass
	{
		public int CompressionQuality
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CompressionQuality, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CompressionQuality, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneCapture.CompressedImageSequenceProtocol");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CompressionQuality = 0;
	}
}