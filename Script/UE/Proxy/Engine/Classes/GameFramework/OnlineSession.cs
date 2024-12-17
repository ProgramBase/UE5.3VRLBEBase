using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.OnlineSession")]
	public partial class UOnlineSession : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.OnlineSession");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}