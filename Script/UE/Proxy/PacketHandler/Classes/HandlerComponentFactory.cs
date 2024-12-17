using Script.CoreUObject;
using Script.Library;

namespace Script.PacketHandler
{
	[PathName("/Script/PacketHandler.HandlerComponentFactory")]
	public partial class UHandlerComponentFactory : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PacketHandler.HandlerComponentFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}