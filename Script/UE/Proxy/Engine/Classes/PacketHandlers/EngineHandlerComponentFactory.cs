using Script.CoreUObject;
using Script.PacketHandler;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.EngineHandlerComponentFactory")]
	public partial class UEngineHandlerComponentFactory : UHandlerComponentFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.EngineHandlerComponentFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}