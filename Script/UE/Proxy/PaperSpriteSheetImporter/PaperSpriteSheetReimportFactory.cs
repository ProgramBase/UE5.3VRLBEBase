using Script.CoreUObject;
using Script.Library;

namespace Script.PaperSpriteSheetImporter
{
	[PathName("/Script/PaperSpriteSheetImporter.PaperSpriteSheetReimportFactory")]
	public partial class UPaperSpriteSheetReimportFactory : UPaperSpriteSheetImportFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PaperSpriteSheetImporter.PaperSpriteSheetReimportFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}