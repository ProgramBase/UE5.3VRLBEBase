using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.MovieSceneNiagaraEmitterSectionBase")]
	public partial class UMovieSceneNiagaraEmitterSectionBase : UMovieSceneSection, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.MovieSceneNiagaraEmitterSectionBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}