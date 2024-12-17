using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.WorldPartitionLandscapeSplineMeshesBuilder")]
	public partial class UWorldPartitionLandscapeSplineMeshesBuilder : UWorldPartitionBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.WorldPartitionLandscapeSplineMeshesBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}