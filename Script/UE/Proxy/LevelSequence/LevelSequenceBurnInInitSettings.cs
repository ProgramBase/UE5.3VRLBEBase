using Script.CoreUObject;
using Script.Library;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.LevelSequenceBurnInInitSettings")]
	public partial class ULevelSequenceBurnInInitSettings : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequence.LevelSequenceBurnInInitSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}