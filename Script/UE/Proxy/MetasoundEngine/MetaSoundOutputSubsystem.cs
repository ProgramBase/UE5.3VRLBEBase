using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.MetaSoundOutputSubsystem")]
	public partial class UMetaSoundOutputSubsystem : UTickableWorldSubsystem, IStaticClass
	{
		public TArray<UMetasoundGeneratorHandle> TrackedGenerators
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TrackedGenerators, __ReturnBuffer);

					return *(TArray<UMetasoundGeneratorHandle>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TrackedGenerators, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEngine.MetaSoundOutputSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="AudioComponent">
		/// - The audio component
		/// </param>
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
		public virtual bool WatchOutput(UAudioComponent AudioComponent, FName OutputName, FOnMetasoundOutputValueChanged OnOutputValueChanged, FName AnalyzerName = null, FName AnalyzerOutputName = null)
		{
			unsafe
			{
				AnalyzerName ??= new FName("None");

				AnalyzerOutputName ??= new FName("None");

				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = AudioComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OnOutputValueChanged?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = AnalyzerName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = AnalyzerOutputName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WatchOutput, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __TrackedGenerators = 0;

		private static uint __WatchOutput = 0;
	}
}