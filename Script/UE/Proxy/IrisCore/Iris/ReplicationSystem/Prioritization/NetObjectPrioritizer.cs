using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NetObjectPrioritizer")]
	public partial class UNetObjectPrioritizer : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.NetObjectPrioritizer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}