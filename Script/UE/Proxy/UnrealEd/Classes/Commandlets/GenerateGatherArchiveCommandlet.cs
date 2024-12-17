using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.GenerateGatherArchiveCommandlet")]
	public partial class UGenerateGatherArchiveCommandlet : UGatherTextCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.GenerateGatherArchiveCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}