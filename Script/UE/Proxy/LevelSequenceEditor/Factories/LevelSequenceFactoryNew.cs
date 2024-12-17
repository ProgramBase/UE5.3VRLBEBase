using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.LevelSequenceEditor
{
	[PathName("/Script/LevelSequenceEditor.LevelSequenceFactoryNew")]
	public partial class ULevelSequenceFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequenceEditor.LevelSequenceFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}