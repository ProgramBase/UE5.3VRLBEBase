using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.SoftClassProperty")]
	public partial class USoftClassProperty : USoftObjectProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.SoftClassProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}