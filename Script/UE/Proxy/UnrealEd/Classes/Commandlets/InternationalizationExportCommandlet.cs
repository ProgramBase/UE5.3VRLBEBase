using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.InternationalizationExportCommandlet")]
	public partial class UInternationalizationExportCommandlet : UGatherTextCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.InternationalizationExportCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}