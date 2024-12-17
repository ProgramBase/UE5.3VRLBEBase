using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Int64Property")]
	public partial class UInt64Property : UNumericProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.Int64Property");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}