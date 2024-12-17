using Script.CoreUObject;
using Script.Sequencer;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraSequencerTrackFilter")]
	public partial class UNiagaraSequencerTrackFilter : USequencerTrackFilterExtension, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraSequencerTrackFilter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}