using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.SphereWithOwnerBoostNetObjectPrioritizer")]
	public partial class USphereWithOwnerBoostNetObjectPrioritizer : USphereNetObjectPrioritizer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.SphereWithOwnerBoostNetObjectPrioritizer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}