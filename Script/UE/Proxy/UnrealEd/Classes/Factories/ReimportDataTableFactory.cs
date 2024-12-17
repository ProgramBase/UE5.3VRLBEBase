using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ReimportDataTableFactory")]
	public partial class UReimportDataTableFactory : UCSVImportFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ReimportDataTableFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}