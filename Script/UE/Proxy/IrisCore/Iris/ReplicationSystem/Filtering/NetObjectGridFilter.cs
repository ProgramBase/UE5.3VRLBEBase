using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NetObjectGridFilter")]
	public partial class UNetObjectGridFilter : UNetObjectFilter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.NetObjectGridFilter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}