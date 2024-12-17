using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.CurveImportFactory")]
	public partial class UCurveImportFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.CurveImportFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}