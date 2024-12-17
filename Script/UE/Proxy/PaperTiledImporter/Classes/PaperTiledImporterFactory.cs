using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.PaperTiledImporter
{
	[PathName("/Script/PaperTiledImporter.PaperTiledImporterFactory")]
	public partial class UPaperTiledImporterFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PaperTiledImporter.PaperTiledImporterFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}