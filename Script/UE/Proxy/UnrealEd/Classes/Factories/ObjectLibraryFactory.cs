using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ObjectLibraryFactory")]
	public partial class UObjectLibraryFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ObjectLibraryFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}