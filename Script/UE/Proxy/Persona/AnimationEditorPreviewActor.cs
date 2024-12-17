using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.AnimationEditorPreviewActor")]
	public partial class AAnimationEditorPreviewActor : AActor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.AnimationEditorPreviewActor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}