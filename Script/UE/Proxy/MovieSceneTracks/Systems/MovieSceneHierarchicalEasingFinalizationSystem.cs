using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneHierarchicalEasingFinalizationSystem")]
	public partial class UMovieSceneHierarchicalEasingFinalizationSystem : UMovieSceneEntityInstantiatorSystem, IStaticClass
	{
		public UMovieSceneHierarchicalEasingInstantiatorSystem InstantiatorSystem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InstantiatorSystem, __ReturnBuffer);

					return *(UMovieSceneHierarchicalEasingInstantiatorSystem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InstantiatorSystem, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneHierarchicalEasingFinalizationSystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InstantiatorSystem = 0;
	}
}