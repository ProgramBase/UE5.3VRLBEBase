using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.PythonScriptLibrary")]
	public partial class UPythonScriptLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PythonScriptPlugin.PythonScriptLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool IsPythonAvailable()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsPythonAvailable, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PythonScript">
		/// This literal Python code to run.
		/// </param>
		/// <param name="PythonInputs">
		/// The variadic input argument names (internal; set by UK2Node_ExecutePythonScript).
		/// </param>
		/// <param name="PythonInputs">
		/// The variadic output argument names (internal; set by UK2Node_ExecutePythonScript).
		/// </param>
		/// <returns>
		/// true if the script ran successfully, false if there were errors.
		/// </returns>
		public static bool ExecutePythonScript(FString PythonScript, TArray<FString> PythonInputs, TArray<FString> PythonOutputs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = PythonScript?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PythonInputs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PythonOutputs?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ExecutePythonScript, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PythonCommand">
		/// The command to run. This may be literal Python code, or a file (with optional arguments) that you want to run.
		/// </param>
		/// <param name="ExecutionMode">
		/// Controls the mode used to execute the command.
		/// </param>
		/// <param name="FileExecutionScope">
		/// Controls the scope used when executing Python files.
		/// </param>
		/// <param name="CommandResult">
		/// The result of running the command. On success, for EvaluateStatement mode this will be the actual result of running the command, and will be None in all other cases. On failure, this will be the error information (typically a Python exception trace).
		/// </param>
		/// <param name="LogOutput">
		/// The log output captured while running the command.
		/// </param>
		/// <returns>
		/// true if the command ran successfully, false if there were errors.
		/// </returns>
		public static bool ExecutePythonCommandEx(FString PythonCommand, ref FString CommandResult, ref TArray<FPythonLogOutputEntry> LogOutput, EPythonCommandExecutionMode ExecutionMode, EPythonFileExecutionScope FileExecutionScope)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = PythonCommand?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CommandResult?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LogOutput?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)ExecutionMode;

				*(byte*)(__InBuffer + 25) = (byte)FileExecutionScope;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __ExecutePythonCommandEx, __InBuffer, __OutBuffer, __ReturnBuffer);

				CommandResult = *(FString*)(__OutBuffer);

				LogOutput = *(TArray<FPythonLogOutputEntry>*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PythonCommand">
		/// The command to run. This may be literal Python code, or a file (with optional arguments) that you want to run.
		/// </param>
		/// <returns>
		/// true if the command ran successfully, false if there were errors (the output log will show the errors).
		/// </returns>
		public static bool ExecutePythonCommand(FString PythonCommand)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PythonCommand?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ExecutePythonCommand, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __IsPythonAvailable = 0;

		private static uint __ExecutePythonScript = 0;

		private static uint __ExecutePythonCommandEx = 0;

		private static uint __ExecutePythonCommand = 0;
	}
}