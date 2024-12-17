using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.PaperSpriteSheetImporter
{
	[PathName("/Script/PaperSpriteSheetImporter.PaperSpriteSheetImportFactory")]
	public partial class UPaperSpriteSheetImportFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PaperSpriteSheetImporter.PaperSpriteSheetImportFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}