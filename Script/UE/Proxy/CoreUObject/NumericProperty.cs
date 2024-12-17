using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.NumericProperty")]
	public partial class UNumericProperty : UProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.NumericProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}