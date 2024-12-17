using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.MulticastInlineDelegateProperty")]
	public partial class UMulticastInlineDelegateProperty : UMulticastDelegateProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.MulticastInlineDelegateProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}