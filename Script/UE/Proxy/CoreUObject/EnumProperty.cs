using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.EnumProperty")]
	public partial class UEnumProperty : UProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.EnumProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}