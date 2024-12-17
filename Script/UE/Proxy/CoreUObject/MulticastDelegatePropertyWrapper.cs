using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.MulticastDelegatePropertyWrapper")]
	public partial class UMulticastDelegatePropertyWrapper : UPropertyWrapper, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.MulticastDelegatePropertyWrapper");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}