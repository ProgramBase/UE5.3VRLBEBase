using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ObjectElementEditorSelectionInterface")]
	public partial class UObjectElementEditorSelectionInterface : UObjectElementSelectionInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ObjectElementEditorSelectionInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}