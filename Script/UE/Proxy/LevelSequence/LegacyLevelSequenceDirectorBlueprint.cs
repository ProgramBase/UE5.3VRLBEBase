using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.LegacyLevelSequenceDirectorBlueprint")]
	public partial class ULegacyLevelSequenceDirectorBlueprint : UBlueprint, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequence.LegacyLevelSequenceDirectorBlueprint");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}