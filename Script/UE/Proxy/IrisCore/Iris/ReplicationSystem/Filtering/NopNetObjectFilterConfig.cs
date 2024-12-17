using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NopNetObjectFilterConfig")]
	public partial class UNopNetObjectFilterConfig : UNetObjectFilterConfig, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.NopNetObjectFilterConfig");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}