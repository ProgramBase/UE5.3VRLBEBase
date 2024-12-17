using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ImportLocalizedDialogueCommandlet")]
	public partial class UImportLocalizedDialogueCommandlet : UGatherTextCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ImportLocalizedDialogueCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}