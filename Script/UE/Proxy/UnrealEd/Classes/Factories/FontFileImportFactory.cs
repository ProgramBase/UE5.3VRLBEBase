using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.FontFileImportFactory")]
	public partial class UFontFileImportFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.FontFileImportFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}