using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.DelegateProperty")]
	public partial class UDelegateProperty : UProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.DelegateProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}