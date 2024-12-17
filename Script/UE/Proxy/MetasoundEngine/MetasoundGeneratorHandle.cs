using Script.CoreUObject;
using Script.Library;
using Script.Engine;
using Script.MetasoundFrontend;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.MetasoundGeneratorHandle")]
	public partial class UMetasoundGeneratorHandle : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEngine.MetasoundGeneratorHandle");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="OutputName">
		/// - The user-specified name of the output in the Metasound
		/// </param>
		/// <param name="OnOutputValueChanged">
		/// - The event to fire when the output's value changes
		/// </param>
		/// <param name="AnalyzerName">
		/// - (optional) The name of the analyzer to use on the output, defaults to a passthrough
		/// </param>
		/// <param name="AnalyzerOutputName">
		/// - (optional) The name of the output on the analyzer to watch, defaults to the passthrough output
		/// </param>
		/// <returns>
		/// true if the watch setup succeeded, false otherwise
		/// </returns>
		public virtual bool WatchOutput(FName OutputName, FOnMetasoundOutputValueChanged OnOutputValueChanged, FName AnalyzerName = null, FName AnalyzerOutputName = null)
		{
			unsafe
			{
				AnalyzerName ??= new FName("None");

				AnalyzerOutputName ??= new FName("None");

				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = OutputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OnOutputValueChanged?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AnalyzerName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = AnalyzerOutputName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WatchOutput, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static UMetasoundGeneratorHandle CreateMetaSoundGeneratorHandle(UAudioComponent OnComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OnComponent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateMetaSoundGeneratorHandle, __InBuffer, __ReturnBuffer);

				return *(UMetasoundGeneratorHandle*)__ReturnBuffer;
			}
		}

		public virtual bool ApplyParameterPack(UMetasoundParameterPack Pack)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Pack?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ApplyParameterPack, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __WatchOutput = 0;

		private static uint __CreateMetaSoundGeneratorHandle = 0;

		private static uint __ApplyParameterPack = 0;
	}
}