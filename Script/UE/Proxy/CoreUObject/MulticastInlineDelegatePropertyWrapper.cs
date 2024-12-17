using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.MulticastInlineDelegatePropertyWrapper")]
	public partial class UMulticastInlineDelegatePropertyWrapper : UMulticastDelegatePropertyWrapper, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.MulticastInlineDelegatePropertyWrapper");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}