using Script.CoreUObject;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.PersonaManagerContext")]
	public partial class UPersonaManagerContext : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.PersonaManagerContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Persona.PersonaManagerContext")]
	public interface IPersonaManagerContext : IInterface
	{
	}
}