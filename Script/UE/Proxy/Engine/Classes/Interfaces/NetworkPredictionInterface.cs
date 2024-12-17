using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NetworkPredictionInterface")]
	public partial class UNetworkPredictionInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.NetworkPredictionInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.NetworkPredictionInterface")]
	public interface INetworkPredictionInterface : IInterface
	{
	}
}