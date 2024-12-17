using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.WorldPartitionFoliageBuilder")]
	public partial class UWorldPartitionFoliageBuilder : UWorldPartitionBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.WorldPartitionFoliageBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}