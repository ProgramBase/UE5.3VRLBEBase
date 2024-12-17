using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.LandscapePlaceholder")]
	public partial class ALandscapePlaceholder : AActor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LandscapeEditor.LandscapePlaceholder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}