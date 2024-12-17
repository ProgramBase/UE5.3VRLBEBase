using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.OnlineEngineInterface")]
	public partial class UOnlineEngineInterface : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.OnlineEngineInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}