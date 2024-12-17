using Script.CoreUObject;
using Script.Engine;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTools
{
	[PathName("/Script/MovieSceneTools.MovieSceneDynamicBindingBlueprintExtension")]
	public partial class UMovieSceneDynamicBindingBlueprintExtension : UBlueprintExtension, IStaticClass
	{
		public TArray<TWeakObjectPtr<UMovieSceneSequence>> WeakMovieSceneSequences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WeakMovieSceneSequences, __ReturnBuffer);

					return *(TArray<TWeakObjectPtr<UMovieSceneSequence>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WeakMovieSceneSequences, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTools.MovieSceneDynamicBindingBlueprintExtension");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __WeakMovieSceneSequences = 0;
	}
}