using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.WorldPartitionHLODsBuilder")]
	public partial class UWorldPartitionHLODsBuilder : UWorldPartitionBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.WorldPartitionHLODsBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}