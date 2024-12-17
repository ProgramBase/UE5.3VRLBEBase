using Script.CoreUObject;
using Script.Landscape;
using Script.Library;

namespace Script.LandscapeEditorUtilities
{
	[PathName("/Script/LandscapeEditorUtilities.LandscapeBlueprintBrush")]
	public partial class ALandscapeBlueprintBrush : ALandscapeBlueprintBrushBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LandscapeEditorUtilities.LandscapeBlueprintBrush");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}