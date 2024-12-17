using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.InternationalizationConditioningCommandlet")]
	public partial class UInternationalizationConditioningCommandlet : UGatherTextCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.InternationalizationConditioningCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}