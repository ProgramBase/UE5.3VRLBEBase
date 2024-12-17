using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.FilterOutNetObjectFilter")]
	public partial class UFilterOutNetObjectFilter : UNetObjectFilter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.FilterOutNetObjectFilter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}