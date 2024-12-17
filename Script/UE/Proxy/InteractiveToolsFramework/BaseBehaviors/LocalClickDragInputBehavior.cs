using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.LocalClickDragInputBehavior")]
	public partial class ULocalClickDragInputBehavior : UClickDragInputBehavior, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.LocalClickDragInputBehavior");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}