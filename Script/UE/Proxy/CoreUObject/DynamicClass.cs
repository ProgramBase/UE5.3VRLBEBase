using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.DynamicClass")]
	public partial class UDynamicClass : UClass, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.DynamicClass");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}