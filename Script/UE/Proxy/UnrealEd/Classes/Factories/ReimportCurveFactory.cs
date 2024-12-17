using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ReimportCurveFactory")]
	public partial class UReimportCurveFactory : UCSVImportFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ReimportCurveFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}