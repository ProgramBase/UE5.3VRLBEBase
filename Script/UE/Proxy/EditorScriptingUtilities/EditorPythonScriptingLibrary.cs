using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.EditorScriptingUtilities
{
	[PathName("/Script/EditorScriptingUtilities.EditorPythonScriptingLibrary")]
	public partial class UEditorPythonScriptingLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorScriptingUtilities.EditorPythonScriptingLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="bNewKeepAlive">
		/// The new value of the bKeepPythonScriptAlive flag.
		/// </param>
		/// <returns>
		/// The result of the users decision, true=Ok, false=Cancel, or false if running in unattended mode.
		/// </returns>
		public static void SetKeepPythonScriptAlive(bool bNewKeepAlive)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewKeepAlive;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetKeepPythonScriptAlive, __InBuffer);
			}
		}

		/// <returns>
		/// The current value of the bKeepPythonScriptAlive flag.
		/// </returns>
		public static bool GetKeepPythonScriptAlive()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetKeepPythonScriptAlive, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetKeepPythonScriptAlive = 0;

		private static uint __GetKeepPythonScriptAlive = 0;
	}
}