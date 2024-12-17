using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.SphereNetObjectPrioritizer")]
	public partial class USphereNetObjectPrioritizer : ULocationBasedNetObjectPrioritizer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.SphereNetObjectPrioritizer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}