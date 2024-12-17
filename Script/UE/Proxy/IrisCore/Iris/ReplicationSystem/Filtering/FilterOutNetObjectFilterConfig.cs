using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.FilterOutNetObjectFilterConfig")]
	public partial class UFilterOutNetObjectFilterConfig : UNetObjectFilterConfig, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.FilterOutNetObjectFilterConfig");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}