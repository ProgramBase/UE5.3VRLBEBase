using Script.CoreUObject;
using Script.Library;

namespace Script.LevelSequenceEditor
{
	[PathName("/Script/LevelSequenceEditor.FilmOverlayToolkit")]
	public partial class UFilmOverlayToolkit : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequenceEditor.FilmOverlayToolkit");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}