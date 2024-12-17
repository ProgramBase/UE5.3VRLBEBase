using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.LevelSequenceEditor
{
	[PathName("/Script/LevelSequenceEditor.AssetDefinition_LevelSequence")]
	public partial class UAssetDefinition_LevelSequence : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequenceEditor.AssetDefinition_LevelSequence");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}