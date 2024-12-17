using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NodeMappingProviderInterface")]
	public partial class UNodeMappingProviderInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.NodeMappingProviderInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.NodeMappingProviderInterface")]
	public interface INodeMappingProviderInterface : IInterface
	{
	}
}