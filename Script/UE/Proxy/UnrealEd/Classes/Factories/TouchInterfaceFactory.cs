using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TouchInterfaceFactory")]
	public partial class UTouchInterfaceFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TouchInterfaceFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}