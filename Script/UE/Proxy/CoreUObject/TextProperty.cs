using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.TextProperty")]
	public partial class UTextProperty : UProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.TextProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}