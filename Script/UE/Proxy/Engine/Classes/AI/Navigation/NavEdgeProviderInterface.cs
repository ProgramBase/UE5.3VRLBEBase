using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NavEdgeProviderInterface")]
	public partial class UNavEdgeProviderInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.NavEdgeProviderInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.NavEdgeProviderInterface")]
	public interface INavEdgeProviderInterface : IInterface
	{
	}
}