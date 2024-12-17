using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.MovieSceneTools
{
	[PathName("/Script/MovieSceneTools.MovieSceneDynamicBindingEndpointUtil")]
	public partial class UMovieSceneDynamicBindingEndpointUtil : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTools.MovieSceneDynamicBindingEndpointUtil");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual FMovieSceneDynamicBindingResolveResult SampleResolveBinding()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __SampleResolveBinding, __ReturnBuffer);

				return *(FMovieSceneDynamicBindingResolveResult*)__ReturnBuffer;
			}
		}

		private static uint __SampleResolveBinding = 0;
	}
}