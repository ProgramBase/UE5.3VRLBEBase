using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.MulticastSparseDelegateProperty")]
	public partial class UMulticastSparseDelegateProperty : UMulticastDelegateProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.MulticastSparseDelegateProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}