using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NetObjectGridWorldLocFilter")]
	public partial class UNetObjectGridWorldLocFilter : UNetObjectGridFilter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.NetObjectGridWorldLocFilter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}