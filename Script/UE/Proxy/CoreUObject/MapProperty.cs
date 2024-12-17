using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.MapProperty")]
	public partial class UMapProperty : UProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.MapProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}