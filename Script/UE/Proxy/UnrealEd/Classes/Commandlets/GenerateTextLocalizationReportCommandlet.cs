using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.GenerateTextLocalizationReportCommandlet")]
	public partial class UGenerateTextLocalizationReportCommandlet : UGatherTextCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.GenerateTextLocalizationReportCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}