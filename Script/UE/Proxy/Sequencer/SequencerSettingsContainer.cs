using Script.CoreUObject;
using Script.Library;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.SequencerSettingsContainer")]
	public partial class USequencerSettingsContainer : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Sequencer.SequencerSettingsContainer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}