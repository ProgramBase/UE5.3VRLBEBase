using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.InterfaceProperty")]
	public partial class UInterfaceProperty : UProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.InterfaceProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}