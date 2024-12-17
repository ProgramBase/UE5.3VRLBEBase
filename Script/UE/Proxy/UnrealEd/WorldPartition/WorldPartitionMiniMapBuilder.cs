using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.WorldPartitionMiniMapBuilder")]
	public partial class UWorldPartitionMiniMapBuilder : UWorldPartitionBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.WorldPartitionMiniMapBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}