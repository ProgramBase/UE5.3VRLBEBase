using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RuntimePartitionPersistent")]
	public partial class URuntimePartitionPersistent : URuntimePartition, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.RuntimePartitionPersistent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}