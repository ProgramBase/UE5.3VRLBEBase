using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.ObjectPropertyBase")]
	public partial class UObjectPropertyBase : UProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.ObjectPropertyBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}