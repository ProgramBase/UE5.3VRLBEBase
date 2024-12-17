using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.DoubleProperty")]
	public partial class UDoubleProperty : UNumericProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.DoubleProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}