using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NetObjectPrioritizerConfig")]
	public partial class UNetObjectPrioritizerConfig : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.NetObjectPrioritizerConfig");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}