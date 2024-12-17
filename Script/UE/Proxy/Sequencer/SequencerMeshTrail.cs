using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.SequencerMeshTrail")]
	public partial class ASequencerMeshTrail : AActor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Sequencer.SequencerMeshTrail");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}