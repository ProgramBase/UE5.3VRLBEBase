using Script.CoreUObject;
using Script.Library;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.ReplicatedLevelSequenceActor")]
	public partial class AReplicatedLevelSequenceActor : ALevelSequenceActor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequence.ReplicatedLevelSequenceActor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}