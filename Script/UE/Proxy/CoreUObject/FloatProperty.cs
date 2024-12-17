using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.FloatProperty")]
	public partial class UFloatProperty : UNumericProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.FloatProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}