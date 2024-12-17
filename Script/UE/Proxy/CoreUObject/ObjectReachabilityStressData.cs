using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.ObjectReachabilityStressData")]
	public partial class UObjectReachabilityStressData : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.ObjectReachabilityStressData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}