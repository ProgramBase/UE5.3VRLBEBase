using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.GatherTextFromMetaDataCommandlet")]
	public partial class UGatherTextFromMetaDataCommandlet : UGatherTextCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.GatherTextFromMetaDataCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}