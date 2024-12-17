using Script.CoreUObject;
using Script.Sequencer;
using Script.Library;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigTrackFilter")]
	public partial class UControlRigTrackFilter : USequencerTrackFilterExtension, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.ControlRigTrackFilter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}