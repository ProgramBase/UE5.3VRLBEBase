using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionRuntimeHash")]
	public partial class UWorldPartitionRuntimeHash : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionRuntimeHash");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}