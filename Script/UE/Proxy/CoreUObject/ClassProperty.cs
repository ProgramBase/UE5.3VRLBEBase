using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.ClassProperty")]
	public partial class UClassProperty : UObjectProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.ClassProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}