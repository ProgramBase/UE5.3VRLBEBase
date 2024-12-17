using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.TestMovieSceneSequence")]
	public partial class UTestMovieSceneSequence : UMovieSceneSequence, IStaticClass
	{
		public UMovieScene MovieScene
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MovieScene, __ReturnBuffer);

					return *(UMovieScene*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MovieScene, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.TestMovieSceneSequence");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MovieScene = 0;
	}
}