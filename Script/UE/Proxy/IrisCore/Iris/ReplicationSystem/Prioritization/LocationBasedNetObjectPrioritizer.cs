using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.LocationBasedNetObjectPrioritizer")]
	public partial class ULocationBasedNetObjectPrioritizer : UNetObjectPrioritizer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.LocationBasedNetObjectPrioritizer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}