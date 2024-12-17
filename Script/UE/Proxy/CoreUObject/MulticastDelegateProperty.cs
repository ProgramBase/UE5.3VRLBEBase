using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.MulticastDelegateProperty")]
	public partial class UMulticastDelegateProperty : UProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.MulticastDelegateProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}