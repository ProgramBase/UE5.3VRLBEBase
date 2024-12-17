using Script.CoreUObject;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.PersonaPreviewSceneDefaultController")]
	public partial class UPersonaPreviewSceneDefaultController : UPersonaPreviewSceneController, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.PersonaPreviewSceneDefaultController");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}