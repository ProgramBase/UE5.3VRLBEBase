using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.IntProperty")]
	public partial class UIntProperty : UNumericProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.IntProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}