using Script.CoreUObject;
using Script.Engine;
using Script.MetasoundFrontend;
using Script.Library;
using Script.AudioExtensions;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.MetaSoundBuilderSubsystem")]
	public partial class UMetaSoundBuilderSubsystem : UEngineSubsystem, IStaticClass
	{
		public TMap<FName, UMetaSoundBuilderBase> NamedBuilders
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NamedBuilders, __ReturnBuffer);

					return *(TMap<FName, UMetaSoundBuilderBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NamedBuilders, __InBuffer);
				}
			}
		}

		public TMap<FName, TWeakObjectPtr<UMetaSoundBuilderBase>> AssetBuilders
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetBuilders, __ReturnBuffer);

					return *(TMap<FName, TWeakObjectPtr<UMetaSoundBuilderBase>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetBuilders, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEngine.MetaSoundBuilderSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool UnregisterSourceBuilder(FName BuilderName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BuilderName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __UnregisterSourceBuilder, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool UnregisterPatchBuilder(FName BuilderName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BuilderName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __UnregisterPatchBuilder, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool UnregisterBuilder(FName BuilderName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BuilderName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __UnregisterBuilder, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void RegisterSourceBuilder(FName BuilderName, UMetaSoundSourceBuilder Builder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BuilderName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Builder?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RegisterSourceBuilder, __InBuffer);
			}
		}

		public virtual void RegisterPatchBuilder(FName BuilderName, UMetaSoundPatchBuilder Builder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BuilderName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Builder?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RegisterPatchBuilder, __InBuffer);
			}
		}

		public virtual void RegisterBuilder(FName BuilderName, UMetaSoundBuilderBase Builder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BuilderName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Builder?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RegisterBuilder, __InBuffer);
			}
		}

		public virtual bool IsInterfaceRegistered(FName InInterfaceName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InInterfaceName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsInterfaceRegistered, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UMetaSoundSourceBuilder FindSourceBuilder(FName BuilderName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BuilderName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindSourceBuilder, __InBuffer, __ReturnBuffer);

				return *(UMetaSoundSourceBuilder*)__ReturnBuffer;
			}
		}

		public virtual UMetaSoundPatchBuilder FindPatchBuilder(FName BuilderName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BuilderName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindPatchBuilder, __InBuffer, __ReturnBuffer);

				return *(UMetaSoundPatchBuilder*)__ReturnBuffer;
			}
		}

		public virtual UMetaSoundBuilderBase FindBuilder(FName BuilderName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BuilderName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindBuilder, __InBuffer, __ReturnBuffer);

				return *(UMetaSoundBuilderBase*)__ReturnBuffer;
			}
		}

		public virtual FMetasoundFrontendLiteral CreateStringMetaSoundLiteral(FString Value, ref FName DataType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DataType?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __CreateStringMetaSoundLiteral, __InBuffer, __OutBuffer, __ReturnBuffer);

				DataType = *(FName*)(__OutBuffer);

				return *(FMetasoundFrontendLiteral*)__ReturnBuffer;
			}
		}

		public virtual FMetasoundFrontendLiteral CreateStringArrayMetaSoundLiteral(TArray<FString> Value, ref FName DataType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DataType?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __CreateStringArrayMetaSoundLiteral, __InBuffer, __OutBuffer, __ReturnBuffer);

				DataType = *(FName*)(__OutBuffer);

				return *(FMetasoundFrontendLiteral*)__ReturnBuffer;
			}
		}

		public virtual UMetaSoundSourceBuilder CreateSourcePresetBuilder(FName BuilderName, TScriptInterface<IMetaSoundDocumentInterface> ReferencedSourceClass, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = BuilderName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ReferencedSourceClass?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __CreateSourcePresetBuilder, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(UMetaSoundSourceBuilder*)__ReturnBuffer;
			}
		}

		public virtual UMetaSoundSourceBuilder CreateSourceBuilder(FName BuilderName, ref FMetaSoundBuilderNodeOutputHandle OnPlayNodeOutput, ref FMetaSoundBuilderNodeInputHandle OnFinishedNodeInput, ref TArray<FMetaSoundBuilderNodeInputHandle> AudioOutNodeInputs, ref EMetaSoundBuilderResult OutResult, EMetaSoundOutputAudioFormat OutputFormat, bool bIsOneShot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[35];

				*(nint*)(__InBuffer) = BuilderName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OnPlayNodeOutput?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OnFinishedNodeInput?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = AudioOutNodeInputs?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)OutResult;

				*(byte*)(__InBuffer + 33) = (byte)OutputFormat;

				*(bool*)(__InBuffer + 34) = bIsOneShot;

				var __OutBuffer = stackalloc byte[25];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __CreateSourceBuilder, __InBuffer, __OutBuffer, __ReturnBuffer);

				OnPlayNodeOutput = *(FMetaSoundBuilderNodeOutputHandle*)(__OutBuffer);

				OnFinishedNodeInput = *(FMetaSoundBuilderNodeInputHandle*)(__OutBuffer + 8);

				AudioOutNodeInputs = *(TArray<FMetaSoundBuilderNodeInputHandle>*)(__OutBuffer + 16);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer + 24);

				return *(UMetaSoundSourceBuilder*)__ReturnBuffer;
			}
		}

		public virtual UMetaSoundPatchBuilder CreatePatchPresetBuilder(FName BuilderName, TScriptInterface<IMetaSoundDocumentInterface> ReferencedPatchClass, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = BuilderName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ReferencedPatchClass?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __CreatePatchPresetBuilder, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(UMetaSoundPatchBuilder*)__ReturnBuffer;
			}
		}

		public virtual UMetaSoundPatchBuilder CreatePatchBuilder(FName BuilderName, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BuilderName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __CreatePatchBuilder, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(UMetaSoundPatchBuilder*)__ReturnBuffer;
			}
		}

		public virtual FMetasoundFrontendLiteral CreateObjectMetaSoundLiteral(UObject Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateObjectMetaSoundLiteral, __InBuffer, __ReturnBuffer);

				return *(FMetasoundFrontendLiteral*)__ReturnBuffer;
			}
		}

		public virtual FMetasoundFrontendLiteral CreateObjectArrayMetaSoundLiteral(TArray<UObject> Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateObjectArrayMetaSoundLiteral, __InBuffer, __ReturnBuffer);

				return *(FMetasoundFrontendLiteral*)__ReturnBuffer;
			}
		}

		public virtual FMetasoundFrontendLiteral CreateMetaSoundLiteralFromParam(FAudioParameter Param)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Param?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateMetaSoundLiteralFromParam, __InBuffer, __ReturnBuffer);

				return *(FMetasoundFrontendLiteral*)__ReturnBuffer;
			}
		}

		public virtual FMetasoundFrontendLiteral CreateIntMetaSoundLiteral(int Value, ref FName DataType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Value;

				*(nint*)(__InBuffer + 4) = DataType?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __CreateIntMetaSoundLiteral, __InBuffer, __OutBuffer, __ReturnBuffer);

				DataType = *(FName*)(__OutBuffer);

				return *(FMetasoundFrontendLiteral*)__ReturnBuffer;
			}
		}

		public virtual FMetasoundFrontendLiteral CreateIntArrayMetaSoundLiteral(TArray<int> Value, ref FName DataType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DataType?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __CreateIntArrayMetaSoundLiteral, __InBuffer, __OutBuffer, __ReturnBuffer);

				DataType = *(FName*)(__OutBuffer);

				return *(FMetasoundFrontendLiteral*)__ReturnBuffer;
			}
		}

		public virtual FMetasoundFrontendLiteral CreateFloatMetaSoundLiteral(float Value, ref FName DataType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = Value;

				*(nint*)(__InBuffer + 4) = DataType?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __CreateFloatMetaSoundLiteral, __InBuffer, __OutBuffer, __ReturnBuffer);

				DataType = *(FName*)(__OutBuffer);

				return *(FMetasoundFrontendLiteral*)__ReturnBuffer;
			}
		}

		public virtual FMetasoundFrontendLiteral CreateFloatArrayMetaSoundLiteral(TArray<float> Value, ref FName DataType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DataType?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __CreateFloatArrayMetaSoundLiteral, __InBuffer, __OutBuffer, __ReturnBuffer);

				DataType = *(FName*)(__OutBuffer);

				return *(FMetasoundFrontendLiteral*)__ReturnBuffer;
			}
		}

		public virtual FMetasoundFrontendLiteral CreateBoolMetaSoundLiteral(bool Value, ref FName DataType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(bool*)(__InBuffer) = Value;

				*(nint*)(__InBuffer + 1) = DataType?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __CreateBoolMetaSoundLiteral, __InBuffer, __OutBuffer, __ReturnBuffer);

				DataType = *(FName*)(__OutBuffer);

				return *(FMetasoundFrontendLiteral*)__ReturnBuffer;
			}
		}

		public virtual FMetasoundFrontendLiteral CreateBoolArrayMetaSoundLiteral(TArray<bool> Value, ref FName DataType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DataType?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __CreateBoolArrayMetaSoundLiteral, __InBuffer, __OutBuffer, __ReturnBuffer);

				DataType = *(FName*)(__OutBuffer);

				return *(FMetasoundFrontendLiteral*)__ReturnBuffer;
			}
		}

		private static uint __NamedBuilders = 0;

		private static uint __AssetBuilders = 0;

		private static uint __UnregisterSourceBuilder = 0;

		private static uint __UnregisterPatchBuilder = 0;

		private static uint __UnregisterBuilder = 0;

		private static uint __RegisterSourceBuilder = 0;

		private static uint __RegisterPatchBuilder = 0;

		private static uint __RegisterBuilder = 0;

		private static uint __IsInterfaceRegistered = 0;

		private static uint __FindSourceBuilder = 0;

		private static uint __FindPatchBuilder = 0;

		private static uint __FindBuilder = 0;

		private static uint __CreateStringMetaSoundLiteral = 0;

		private static uint __CreateStringArrayMetaSoundLiteral = 0;

		private static uint __CreateSourcePresetBuilder = 0;

		private static uint __CreateSourceBuilder = 0;

		private static uint __CreatePatchPresetBuilder = 0;

		private static uint __CreatePatchBuilder = 0;

		private static uint __CreateObjectMetaSoundLiteral = 0;

		private static uint __CreateObjectArrayMetaSoundLiteral = 0;

		private static uint __CreateMetaSoundLiteralFromParam = 0;

		private static uint __CreateIntMetaSoundLiteral = 0;

		private static uint __CreateIntArrayMetaSoundLiteral = 0;

		private static uint __CreateFloatMetaSoundLiteral = 0;

		private static uint __CreateFloatArrayMetaSoundLiteral = 0;

		private static uint __CreateBoolMetaSoundLiteral = 0;

		private static uint __CreateBoolArrayMetaSoundLiteral = 0;
	}
}