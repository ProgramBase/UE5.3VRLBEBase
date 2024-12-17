using Script.CoreUObject;
using Script.Library;
using Script.Engine;
using Script.MetasoundFrontend;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.MetaSoundSourceBuilder")]
	public partial class UMetaSoundSourceBuilder : UMetaSoundBuilderBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEngine.MetaSoundSourceBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetFormat(EMetaSoundOutputAudioFormat OutputFormat, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = (byte)OutputFormat;

				*(byte*)(__InBuffer + 1) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SetFormat, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual bool GetLiveUpdatesEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetLiveUpdatesEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TScriptInterface<IMetaSoundDocumentInterface> Build(UObject Parent, FMetaSoundBuilderOptions Options)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Parent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Options?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __Build, __InBuffer, __ReturnBuffer);

				return *(TScriptInterface<IMetaSoundDocumentInterface>*)__ReturnBuffer;
			}
		}

		public virtual void Audition(UObject Parent, UAudioComponent AudioComponent, FOnCreateAuditionGeneratorHandleDelegate OnCreateGenerator, bool bLiveUpdatesEnabled = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Parent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AudioComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OnCreateGenerator?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bLiveUpdatesEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Audition, __InBuffer);
			}
		}

		private static uint __SetFormat = 0;

		private static uint __GetLiveUpdatesEnabled = 0;

		private static uint __Build = 0;

		private static uint __Audition = 0;
	}
}