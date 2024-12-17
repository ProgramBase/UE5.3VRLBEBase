using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneBindingOverrides")]
	public partial class UMovieSceneBindingOverrides : UObject, IStaticClass
	{
		public TArray<FMovieSceneBindingOverrideData> BindingData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BindingData, __ReturnBuffer);

					return *(TArray<FMovieSceneBindingOverrideData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BindingData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneBindingOverrides");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __BindingData = 0;
	}
}