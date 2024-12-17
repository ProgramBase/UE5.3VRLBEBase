using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.ByteProperty")]
	public partial class UByteProperty : UNumericProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.ByteProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}