using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Int16Property")]
	public partial class UInt16Property : UNumericProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.Int16Property");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}