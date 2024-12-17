using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ISMPartitionInstanceManagerProvider")]
	public partial class UISMPartitionInstanceManagerProvider : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ISMPartitionInstanceManagerProvider");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.ISMPartitionInstanceManagerProvider")]
	public interface IISMPartitionInstanceManagerProvider : IInterface
	{
	}
}