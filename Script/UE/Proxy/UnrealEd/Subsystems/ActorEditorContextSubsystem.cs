using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorEditorContextSubsystem")]
	public partial class UActorEditorContextSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorEditorContextSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}