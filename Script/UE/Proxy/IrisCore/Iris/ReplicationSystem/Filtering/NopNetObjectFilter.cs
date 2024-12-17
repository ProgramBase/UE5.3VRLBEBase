using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NopNetObjectFilter")]
	public partial class UNopNetObjectFilter : UNetObjectFilter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.NopNetObjectFilter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}