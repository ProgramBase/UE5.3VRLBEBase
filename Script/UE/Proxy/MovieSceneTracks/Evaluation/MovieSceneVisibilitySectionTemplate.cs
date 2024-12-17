using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneVisibilitySectionTemplate")]
	public partial class FMovieSceneVisibilitySectionTemplate : FMovieSceneBoolPropertySectionTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneVisibilitySectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneVisibilitySectionTemplate()
		{
		}

		public static bool operator ==(FMovieSceneVisibilitySectionTemplate A, FMovieSceneVisibilitySectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneVisibilitySectionTemplate A, FMovieSceneVisibilitySectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneVisibilitySectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}