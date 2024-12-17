using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SMInstanceElementEditorSelectionInterface")]
	public partial class USMInstanceElementEditorSelectionInterface : USMInstanceElementSelectionInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SMInstanceElementEditorSelectionInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}