using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.UInt16Property")]
	public partial class UUInt16Property : UNumericProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.UInt16Property");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}