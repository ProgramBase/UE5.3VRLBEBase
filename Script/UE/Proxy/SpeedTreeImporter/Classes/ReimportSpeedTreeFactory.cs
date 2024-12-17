using Script.CoreUObject;
using Script.Library;

namespace Script.SpeedTreeImporter
{
	[PathName("/Script/SpeedTreeImporter.ReimportSpeedTreeFactory")]
	public partial class UReimportSpeedTreeFactory : USpeedTreeImportFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SpeedTreeImporter.ReimportSpeedTreeFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}