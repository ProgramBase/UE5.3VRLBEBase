using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneParticleParameterSectionTemplate")]
	public partial class FMovieSceneParticleParameterSectionTemplate : FMovieSceneParameterSectionTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneParticleParameterSectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneParticleParameterSectionTemplate()
		{
		}

		public static bool operator ==(FMovieSceneParticleParameterSectionTemplate A, FMovieSceneParticleParameterSectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneParticleParameterSectionTemplate A, FMovieSceneParticleParameterSectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneParticleParameterSectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}