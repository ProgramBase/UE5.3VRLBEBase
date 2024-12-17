using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.DelegateFunction")]
	public partial class UDelegateFunction : UFunction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.DelegateFunction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}