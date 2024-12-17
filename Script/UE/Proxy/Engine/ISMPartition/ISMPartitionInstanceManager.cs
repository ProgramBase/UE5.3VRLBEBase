using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ISMPartitionInstanceManager")]
	public partial class UISMPartitionInstanceManager : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ISMPartitionInstanceManager");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.ISMPartitionInstanceManager")]
	public interface IISMPartitionInstanceManager : IInterface
	{
	}
}