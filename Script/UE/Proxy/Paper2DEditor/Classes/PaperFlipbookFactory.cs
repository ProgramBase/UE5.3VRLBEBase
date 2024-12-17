using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.Paper2DEditor
{
	[PathName("/Script/Paper2DEditor.PaperFlipbookFactory")]
	public partial class UPaperFlipbookFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2DEditor.PaperFlipbookFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}