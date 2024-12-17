using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ExportDialogueScriptCommandlet")]
	public partial class UExportDialogueScriptCommandlet : UGatherTextCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ExportDialogueScriptCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}