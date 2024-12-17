using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneParticleChannel")]
	public partial class FMovieSceneParticleChannel : FMovieSceneByteChannel, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneParticleChannel");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneParticleChannel()
		{
		}

		public static bool operator ==(FMovieSceneParticleChannel A, FMovieSceneParticleChannel B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneParticleChannel A, FMovieSceneParticleChannel B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneParticleChannel;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}