using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ImportDialogueScriptCommandlet")]
	public partial class UImportDialogueScriptCommandlet : UGatherTextCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ImportDialogueScriptCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}