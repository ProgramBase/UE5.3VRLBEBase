using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.StrProperty")]
	public partial class UStrProperty : UProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.StrProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}