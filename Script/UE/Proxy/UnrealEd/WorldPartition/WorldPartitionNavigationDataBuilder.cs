using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.WorldPartitionNavigationDataBuilder")]
	public partial class UWorldPartitionNavigationDataBuilder : UWorldPartitionBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.WorldPartitionNavigationDataBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}