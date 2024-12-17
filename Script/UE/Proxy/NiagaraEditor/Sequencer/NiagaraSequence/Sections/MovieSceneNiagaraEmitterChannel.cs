using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.MovieSceneNiagaraEmitterChannel")]
	public partial class FMovieSceneNiagaraEmitterChannel : FMovieSceneChannel, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.MovieSceneNiagaraEmitterChannel");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneNiagaraEmitterChannel()
		{
		}

		public static bool operator ==(FMovieSceneNiagaraEmitterChannel A, FMovieSceneNiagaraEmitterChannel B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneNiagaraEmitterChannel A, FMovieSceneNiagaraEmitterChannel B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneNiagaraEmitterChannel;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}