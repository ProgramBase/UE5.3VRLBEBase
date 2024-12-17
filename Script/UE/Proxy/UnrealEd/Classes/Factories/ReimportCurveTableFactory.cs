using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ReimportCurveTableFactory")]
	public partial class UReimportCurveTableFactory : UCSVImportFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ReimportCurveTableFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}