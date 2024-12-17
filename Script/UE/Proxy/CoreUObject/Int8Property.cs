using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Int8Property")]
	public partial class UInt8Property : UNumericProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.Int8Property");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}