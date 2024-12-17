using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.SpeedTreeImporter
{
	[PathName("/Script/SpeedTreeImporter.SpeedTreeImportFactory")]
	public partial class USpeedTreeImportFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SpeedTreeImporter.SpeedTreeImportFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}