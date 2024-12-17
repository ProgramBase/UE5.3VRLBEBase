using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NetObjectGridFragmentLocFilter")]
	public partial class UNetObjectGridFragmentLocFilter : UNetObjectGridFilter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.NetObjectGridFragmentLocFilter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}