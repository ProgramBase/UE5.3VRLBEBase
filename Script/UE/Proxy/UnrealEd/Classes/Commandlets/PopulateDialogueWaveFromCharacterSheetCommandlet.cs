using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PopulateDialogueWaveFromCharacterSheetCommandlet")]
	public partial class UPopulateDialogueWaveFromCharacterSheetCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.PopulateDialogueWaveFromCharacterSheetCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}