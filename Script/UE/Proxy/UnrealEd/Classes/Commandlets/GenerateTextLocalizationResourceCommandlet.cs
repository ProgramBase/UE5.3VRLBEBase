using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.GenerateTextLocalizationResourceCommandlet")]
	public partial class UGenerateTextLocalizationResourceCommandlet : UGatherTextCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.GenerateTextLocalizationResourceCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}