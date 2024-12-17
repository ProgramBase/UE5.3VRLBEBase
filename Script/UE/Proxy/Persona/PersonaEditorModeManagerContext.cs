using Script.CoreUObject;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.PersonaEditorModeManagerContext")]
	public partial class UPersonaEditorModeManagerContext : UObject, IStaticClass, IPersonaManagerContext
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.PersonaEditorModeManagerContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __ExecuteUbergraph = 0;
	}
}