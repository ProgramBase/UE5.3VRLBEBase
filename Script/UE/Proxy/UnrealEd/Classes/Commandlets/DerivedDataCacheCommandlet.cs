using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.DerivedDataCacheCommandlet")]
	public partial class UDerivedDataCacheCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.DerivedDataCacheCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}