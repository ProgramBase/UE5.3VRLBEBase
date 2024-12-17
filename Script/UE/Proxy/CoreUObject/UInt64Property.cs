using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.UInt64Property")]
	public partial class UUInt64Property : UNumericProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.UInt64Property");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}