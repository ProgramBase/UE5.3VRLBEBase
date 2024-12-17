using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneHierarchicalEasingInstantiatorSystem")]
	public partial class UMovieSceneHierarchicalEasingInstantiatorSystem : UMovieSceneEntityInstantiatorSystem, IStaticClass
	{
		public UWeightAndEasingEvaluatorSystem EvaluatorSystem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EvaluatorSystem, __ReturnBuffer);

					return *(UWeightAndEasingEvaluatorSystem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EvaluatorSystem, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneHierarchicalEasingInstantiatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EvaluatorSystem = 0;
	}
}