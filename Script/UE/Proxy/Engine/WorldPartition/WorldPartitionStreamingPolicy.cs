using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionStreamingPolicy")]
	public partial class UWorldPartitionStreamingPolicy : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionStreamingPolicy");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}