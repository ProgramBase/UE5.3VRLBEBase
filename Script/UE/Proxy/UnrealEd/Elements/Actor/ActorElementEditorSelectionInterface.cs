using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorElementEditorSelectionInterface")]
	public partial class UActorElementEditorSelectionInterface : UActorElementSelectionInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorElementEditorSelectionInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}