using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.EnhancedInput;
using Script.Library;
using Script.Engine;
using Script.InputCore;

namespace Script.InputEditor
{
	[PathName("/Script/InputEditor.EnhancedInputEditorSubsystem")]
	public partial class UEnhancedInputEditorSubsystem : UEditorSubsystem, IStaticClass, IEnhancedInputSubsystemInterface
	{
		public UEnhancedPlayerInput PlayerInput
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerInput, __ReturnBuffer);

					return *(UEnhancedPlayerInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerInput, __InBuffer);
				}
			}
		}

		public TArray<TWeakObjectPtr<UInputComponent>> CurrentInputStack
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentInputStack, __ReturnBuffer);

					return *(TArray<TWeakObjectPtr<UInputComponent>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentInputStack, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InputEditor.EnhancedInputEditorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="MappingName">
		/// The name of the player mapping that can be used for look up an associated UInputAction object.
		/// </param>
		public virtual void StopContinuousInputInjectionForPlayerMapping(FName MappingName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MappingName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopContinuousInputInjectionForPlayerMapping, __InBuffer);
			}
		}

		/// <param name="Action">
		/// The action to stop injecting input for
		/// </param>
		public virtual void StopContinuousInputInjectionForAction(UInputAction Action)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Action?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopContinuousInputInjectionForAction, __InBuffer);
			}
		}

		/// <param name="MappingName">
		/// The name of the player mapping that can be used for look up an associated UInputAction object.
		/// </param>
		/// <param name="RawValue">
		/// The value to set the action to (the type will be controlled by the Action)
		/// </param>
		/// <param name="Modifiers">
		/// The modifiers to apply to the injected input.
		/// </param>
		/// <param name="Triggers">
		/// The triggers to apply to the injected input.
		/// </param>
		public virtual void StartContinuousInputInjectionForPlayerMapping(FName MappingName, FInputActionValue RawValue, TArray<UInputModifier> Modifiers, TArray<UInputTrigger> Triggers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = MappingName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RawValue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Modifiers?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Triggers?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StartContinuousInputInjectionForPlayerMapping, __InBuffer);
			}
		}

		/// <param name="Action">
		/// The Input Action to set inject input for
		/// </param>
		/// <param name="RawValue">
		/// The value to set the action to (the type will be controlled by the Action)
		/// </param>
		/// <param name="Modifiers">
		/// The modifiers to apply to the injected input.
		/// </param>
		/// <param name="Triggers">
		/// The triggers to apply to the injected input.
		/// </param>
		public virtual void StartContinuousInputInjectionForAction(UInputAction Action, FInputActionValue RawValue, TArray<UInputModifier> Modifiers, TArray<UInputTrigger> Triggers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Action?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RawValue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Modifiers?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Triggers?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StartContinuousInputInjectionForAction, __InBuffer);
			}
		}

		/// <param name="Options">
		/// Options to consider when removing this input mapping context
		/// </param>
		public virtual void RequestRebuildControlMappings(FModifyContextOptions Options = null, EInputMappingRebuildType RebuildType = EInputMappingRebuildType.Rebuild)
		{
			unsafe
			{
				Options ??= new FModifyContextOptions();

				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Options?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)RebuildType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RequestRebuildControlMappings, __InBuffer);
			}
		}

		public virtual void RemovePlayerMappableConfig(UPlayerMappableInputConfig Config, FModifyContextOptions Options = null)
		{
			unsafe
			{
				Options ??= new FModifyContextOptions();

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Config?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Options?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemovePlayerMappableConfig, __InBuffer);
			}
		}

		/// <param name="MappingContext">
		/// Context to remove from the player
		/// </param>
		/// <param name="Options">
		/// Options to consider when removing this input mapping context
		/// </param>
		public virtual void RemoveMappingContext(UInputMappingContext MappingContext, FModifyContextOptions Options = null)
		{
			unsafe
			{
				Options ??= new FModifyContextOptions();

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MappingContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Options?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveMappingContext, __InBuffer);
			}
		}

		public virtual int RemoveAllPlayerMappedKeysForMapping(FName MappingName, FModifyContextOptions Options = null)
		{
			unsafe
			{
				Options ??= new FModifyContextOptions();

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MappingName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Options?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAllPlayerMappedKeysForMapping, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void RemoveAllPlayerMappedKeys(FModifyContextOptions Options = null)
		{
			unsafe
			{
				Options ??= new FModifyContextOptions();

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Options?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveAllPlayerMappedKeys, __InBuffer);
			}
		}

		public virtual EMappingQueryResult QueryMapKeyInContextSet(TArray<UInputMappingContext> PrioritizedActiveContexts, UInputMappingContext InputContext, UInputAction Action, FKey Key, ref TArray<FMappingQueryIssue> OutIssues, EMappingQueryIssue BlockingIssues)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = PrioritizedActiveContexts?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InputContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Action?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = OutIssues?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)BlockingIssues;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __QueryMapKeyInContextSet, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutIssues = *(TArray<FMappingQueryIssue>*)(__OutBuffer);

				return *(EMappingQueryResult*)__ReturnBuffer;
			}
		}

		public virtual EMappingQueryResult QueryMapKeyInActiveContextSet(UInputMappingContext InputContext, UInputAction Action, FKey Key, ref TArray<FMappingQueryIssue> OutIssues, EMappingQueryIssue BlockingIssues)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = InputContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Action?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutIssues?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)BlockingIssues;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __QueryMapKeyInActiveContextSet, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutIssues = *(TArray<FMappingQueryIssue>*)(__OutBuffer);

				return *(EMappingQueryResult*)__ReturnBuffer;
			}
		}

		public virtual TArray<FKey> QueryKeysMappedToAction(UInputAction Action)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Action?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __QueryKeysMappedToAction, __InBuffer, __ReturnBuffer);

				return *(TArray<FKey>*)__ReturnBuffer;
			}
		}

		public virtual void OnUserSettingsChanged(UEnhancedInputUserSettings Settings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Settings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnUserSettingsChanged, __InBuffer);
			}
		}

		public virtual void OnUserKeyProfileChanged(UEnhancedPlayerMappableKeyProfile InNewProfile)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InNewProfile?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnUserKeyProfileChanged, __InBuffer);
			}
		}

		/// <returns>
		/// The number of mappings that have been removed
		/// </returns>
		public virtual int K2_RemovePlayerMappedKeyInSlot(FName MappingName, FPlayerMappableKeySlot KeySlot = null, FModifyContextOptions Options = null)
		{
			unsafe
			{
				KeySlot ??= new FPlayerMappableKeySlot();

				Options ??= new FModifyContextOptions();

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = MappingName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = KeySlot?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Options?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_RemovePlayerMappedKeyInSlot, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FKey K2_GetPlayerMappedKeyInSlot(FName MappingName, FPlayerMappableKeySlot KeySlot = null)
		{
			unsafe
			{
				KeySlot ??= new FPlayerMappableKeySlot();

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MappingName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = KeySlot?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __K2_GetPlayerMappedKeyInSlot, __InBuffer, __ReturnBuffer);

				return *(FKey*)__ReturnBuffer;
			}
		}

		public virtual int K2_AddPlayerMappedKeyInSlot(FName MappingName, FKey NewKey, FPlayerMappableKeySlot KeySlot = null, FModifyContextOptions Options = null)
		{
			unsafe
			{
				KeySlot ??= new FPlayerMappableKeySlot();

				Options ??= new FModifyContextOptions();

				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = MappingName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = KeySlot?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Options?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_AddPlayerMappedKeyInSlot, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="MappingName">
		/// The name of the player mapping that can be used for look up an associated UInputAction object.
		/// </param>
		/// <param name="Value">
		/// The value to set the action to (the type will be controlled by the Action)
		/// </param>
		/// <param name="Modifiers">
		/// The modifiers to apply to the injected input.
		/// </param>
		/// <param name="Triggers">
		/// The triggers to apply to the injected input.
		/// </param>
		public virtual void InjectInputVectorForPlayerMapping(FName MappingName, FVector Value, TArray<UInputModifier> Modifiers, TArray<UInputTrigger> Triggers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = MappingName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Modifiers?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Triggers?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __InjectInputVectorForPlayerMapping, __InBuffer);
			}
		}

		/// <param name="Action">
		/// The Input Action to set inject input for
		/// </param>
		/// <param name="Value">
		/// The value to set the action to (the type will be controlled by the Action)
		/// </param>
		/// <param name="Modifiers">
		/// The modifiers to apply to the injected input.
		/// </param>
		/// <param name="Triggers">
		/// The triggers to apply to the injected input.
		/// </param>
		public virtual void InjectInputVectorForAction(UInputAction Action, FVector Value, TArray<UInputModifier> Modifiers, TArray<UInputTrigger> Triggers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Action?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Modifiers?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Triggers?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __InjectInputVectorForAction, __InBuffer);
			}
		}

		/// <param name="MappingName">
		/// The name of the player mapping that can be used for look up an associated UInputAction object.
		/// </param>
		/// <param name="RawValue">
		/// The value to set the action to
		/// </param>
		/// <param name="Modifiers">
		/// The modifiers to apply to the injected input.
		/// </param>
		/// <param name="Triggers">
		/// The triggers to apply to the injected input.
		/// </param>
		public virtual void InjectInputForPlayerMapping(FName MappingName, FInputActionValue RawValue, TArray<UInputModifier> Modifiers, TArray<UInputTrigger> Triggers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = MappingName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RawValue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Modifiers?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Triggers?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __InjectInputForPlayerMapping, __InBuffer);
			}
		}

		/// <param name="Action">
		/// The Input Action to set inject input for
		/// </param>
		/// <param name="RawValue">
		/// The value to set the action to
		/// </param>
		/// <param name="Modifiers">
		/// The modifiers to apply to the injected input.
		/// </param>
		/// <param name="Triggers">
		/// The triggers to apply to the injected input.
		/// </param>
		public virtual void InjectInputForAction(UInputAction Action, FInputActionValue RawValue, TArray<UInputModifier> Modifiers, TArray<UInputTrigger> Triggers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Action?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RawValue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Modifiers?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Triggers?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __InjectInputForAction, __InBuffer);
			}
		}

		/// <param name="MappingContext">
		/// The mapping context to search for on the subsystem's owner.
		/// </param>
		/// <param name="OutFoundPriority">
		/// The priority of the mapping context if it is applied. -1 if the context is not applied	
		/// </param>
		/// <returns>
		/// True if the mapping context is applied
		/// </returns>
		public virtual bool HasMappingContext(UInputMappingContext MappingContext, ref int OutFoundPriority)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = MappingContext?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = OutFoundPriority;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __HasMappingContext, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutFoundPriority = *(int*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UEnhancedInputUserSettings GetUserSettings()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetUserSettings, __ReturnBuffer);

				return *(UEnhancedInputUserSettings*)__ReturnBuffer;
			}
		}

		public virtual TArray<FKey> GetAllPlayerMappedKeys(FName MappingName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MappingName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetAllPlayerMappedKeys, __InBuffer, __ReturnBuffer);

				return *(TArray<FKey>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FEnhancedActionKeyMapping> GetAllPlayerMappableActionKeyMappings()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAllPlayerMappableActionKeyMappings, __ReturnBuffer);

				return *(TArray<FEnhancedActionKeyMapping>*)__ReturnBuffer;
			}
		}

		public virtual void ClearAllMappings()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearAllMappings);
			}
		}

		public virtual void AddPlayerMappableConfig(UPlayerMappableInputConfig Config, FModifyContextOptions Options = null)
		{
			unsafe
			{
				Options ??= new FModifyContextOptions();

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Config?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Options?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddPlayerMappableConfig, __InBuffer);
			}
		}

		/// <param name="MappingContext">
		/// A set of key to action mappings to apply to this player
		/// </param>
		/// <param name="Priority">
		/// Higher priority mappings will be applied first and, if they consume input, will block lower priority mappings.
		/// </param>
		/// <param name="Options">
		/// Options to consider when adding this mapping context.
		/// </param>
		public virtual void AddMappingContext(UInputMappingContext MappingContext, int Priority, FModifyContextOptions Options = null)
		{
			unsafe
			{
				Options ??= new FModifyContextOptions();

				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = MappingContext?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Priority;

				*(nint*)(__InBuffer + 12) = Options?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddMappingContext, __InBuffer);
			}
		}

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

		public virtual void StopConsumingInput()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StopConsumingInput);
			}
		}

		public virtual void StartConsumingInput()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StartConsumingInput);
			}
		}

		public virtual void PushInputComponent(UInputComponent InInputComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InInputComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PushInputComponent, __InBuffer);
			}
		}

		public virtual bool PopInputComponent(UInputComponent InInputComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InInputComponent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __PopInputComponent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsConsumingInput()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsConsumingInput, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __PlayerInput = 0;

		private static uint __CurrentInputStack = 0;

		private static uint __StopContinuousInputInjectionForPlayerMapping = 0;

		private static uint __StopContinuousInputInjectionForAction = 0;

		private static uint __StartContinuousInputInjectionForPlayerMapping = 0;

		private static uint __StartContinuousInputInjectionForAction = 0;

		private static uint __RequestRebuildControlMappings = 0;

		private static uint __RemovePlayerMappableConfig = 0;

		private static uint __RemoveMappingContext = 0;

		private static uint __RemoveAllPlayerMappedKeysForMapping = 0;

		private static uint __RemoveAllPlayerMappedKeys = 0;

		private static uint __QueryMapKeyInContextSet = 0;

		private static uint __QueryMapKeyInActiveContextSet = 0;

		private static uint __QueryKeysMappedToAction = 0;

		private static uint __OnUserSettingsChanged = 0;

		private static uint __OnUserKeyProfileChanged = 0;

		private static uint __K2_RemovePlayerMappedKeyInSlot = 0;

		private static uint __K2_GetPlayerMappedKeyInSlot = 0;

		private static uint __K2_AddPlayerMappedKeyInSlot = 0;

		private static uint __InjectInputVectorForPlayerMapping = 0;

		private static uint __InjectInputVectorForAction = 0;

		private static uint __InjectInputForPlayerMapping = 0;

		private static uint __InjectInputForAction = 0;

		private static uint __HasMappingContext = 0;

		private static uint __GetUserSettings = 0;

		private static uint __GetAllPlayerMappedKeys = 0;

		private static uint __GetAllPlayerMappableActionKeyMappings = 0;

		private static uint __ClearAllMappings = 0;

		private static uint __AddPlayerMappableConfig = 0;

		private static uint __AddMappingContext = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __StopConsumingInput = 0;

		private static uint __StartConsumingInput = 0;

		private static uint __PushInputComponent = 0;

		private static uint __PopInputComponent = 0;

		private static uint __IsConsumingInput = 0;
	}
}