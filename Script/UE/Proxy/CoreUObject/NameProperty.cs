using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.NameProperty")]
	public partial class UNameProperty : UProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.NameProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}