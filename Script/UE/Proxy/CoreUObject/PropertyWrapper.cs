using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.PropertyWrapper")]
	public partial class UPropertyWrapper : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.PropertyWrapper");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}