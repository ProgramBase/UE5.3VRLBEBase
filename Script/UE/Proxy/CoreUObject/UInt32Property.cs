using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.UInt32Property")]
	public partial class UUInt32Property : UNumericProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.UInt32Property");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}