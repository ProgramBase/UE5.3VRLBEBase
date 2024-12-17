using Script.CoreUObject;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.AnimViewportToolBarToolMenuContext")]
	public partial class UAnimViewportToolBarToolMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.AnimViewportToolBarToolMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}