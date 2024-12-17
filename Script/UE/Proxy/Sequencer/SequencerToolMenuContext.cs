using Script.CoreUObject;
using Script.Library;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.SequencerToolMenuContext")]
	public partial class USequencerToolMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Sequencer.SequencerToolMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}