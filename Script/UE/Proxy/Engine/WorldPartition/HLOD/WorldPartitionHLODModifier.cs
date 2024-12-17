using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionHLODModifier")]
	public partial class UWorldPartitionHLODModifier : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionHLODModifier");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}