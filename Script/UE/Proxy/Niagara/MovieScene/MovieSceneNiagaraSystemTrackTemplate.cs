using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.MovieSceneNiagaraSystemTrackTemplate")]
	public partial class FMovieSceneNiagaraSystemTrackTemplate : FMovieSceneEvalTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.MovieSceneNiagaraSystemTrackTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneNiagaraSystemTrackTemplate()
		{
		}

		public static bool operator ==(FMovieSceneNiagaraSystemTrackTemplate A, FMovieSceneNiagaraSystemTrackTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneNiagaraSystemTrackTemplate A, FMovieSceneNiagaraSystemTrackTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneNiagaraSystemTrackTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}