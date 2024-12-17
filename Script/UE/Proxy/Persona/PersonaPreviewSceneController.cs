using Script.CoreUObject;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.PersonaPreviewSceneController")]
	public partial class UPersonaPreviewSceneController : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.PersonaPreviewSceneController");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}