using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.GatherTextFromSourceCommandlet")]
	public partial class UGatherTextFromSourceCommandlet : UGatherTextCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.GatherTextFromSourceCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}