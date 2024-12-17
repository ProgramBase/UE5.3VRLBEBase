using Script.CoreUObject;
using Script.Library;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.SequencerTrackFilterExtension")]
	public partial class USequencerTrackFilterExtension : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Sequencer.SequencerTrackFilterExtension");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}