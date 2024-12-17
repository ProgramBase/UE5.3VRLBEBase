using Script.CoreUObject;
using Script.Library;
using Script.InputCore;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EnhancedInputSubsystemInterface")]
	public partial class UEnhancedInputSubsystemInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.EnhancedInputSubsystemInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/EnhancedInput.EnhancedInputSubsystemInterface")]
	public interface IEnhancedInputSubsystemInterface : IInterface
	{
		 void StopContinuousInputInjectionForPlayerMapping(FName MappingName);

		 void StopContinuousInputInjectionForAction(UInputAction Action);

		 void StartContinuousInputInjectionForPlayerMapping(FName MappingName, FInputActionValue RawValue, TArray<UInputModifier> Modifiers, TArray<UInputTrigger> Triggers);

		 void StartContinuousInputInjectionForAction(UInputAction Action, FInputActionValue RawValue, TArray<UInputModifier> Modifiers, TArray<UInputTrigger> Triggers);

		 void RequestRebuildControlMappings(FModifyContextOptions Options = null, EInputMappingRebuildType RebuildType = EInputMappingRebuildType.Rebuild);

		 void RemovePlayerMappableConfig(UPlayerMappableInputConfig Config, FModifyContextOptions Options = null);

		 void RemoveMappingContext(UInputMappingContext MappingContext, FModifyContextOptions Options = null);

		 int RemoveAllPlayerMappedKeysForMapping(FName MappingName, FModifyContextOptions Options = null);

		 void RemoveAllPlayerMappedKeys(FModifyContextOptions Options = null);

		 EMappingQueryResult QueryMapKeyInContextSet(TArray<UInputMappingContext> PrioritizedActiveContexts, UInputMappingContext InputContext, UInputAction Action, FKey Key, ref TArray<FMappingQueryIssue> OutIssues, EMappingQueryIssue BlockingIssues);

		 EMappingQueryResult QueryMapKeyInActiveContextSet(UInputMappingContext InputContext, UInputAction Action, FKey Key, ref TArray<FMappingQueryIssue> OutIssues, EMappingQueryIssue BlockingIssues);

		 TArray<FKey> QueryKeysMappedToAction(UInputAction Action);

		 void OnUserSettingsChanged(UEnhancedInputUserSettings Settings);

		 void OnUserKeyProfileChanged(UEnhancedPlayerMappableKeyProfile InNewProfile);

		 int K2_RemovePlayerMappedKeyInSlot(FName MappingName, FPlayerMappableKeySlot KeySlot = null, FModifyContextOptions Options = null);

		 FKey K2_GetPlayerMappedKeyInSlot(FName MappingName, FPlayerMappableKeySlot KeySlot = null);

		 int K2_AddPlayerMappedKeyInSlot(FName MappingName, FKey NewKey, FPlayerMappableKeySlot KeySlot = null, FModifyContextOptions Options = null);

		 void InjectInputVectorForPlayerMapping(FName MappingName, FVector Value, TArray<UInputModifier> Modifiers, TArray<UInputTrigger> Triggers);

		 void InjectInputVectorForAction(UInputAction Action, FVector Value, TArray<UInputModifier> Modifiers, TArray<UInputTrigger> Triggers);

		 void InjectInputForPlayerMapping(FName MappingName, FInputActionValue RawValue, TArray<UInputModifier> Modifiers, TArray<UInputTrigger> Triggers);

		 void InjectInputForAction(UInputAction Action, FInputActionValue RawValue, TArray<UInputModifier> Modifiers, TArray<UInputTrigger> Triggers);

		 bool HasMappingContext(UInputMappingContext MappingContext, ref int OutFoundPriority);

		 UEnhancedInputUserSettings GetUserSettings();

		 TArray<FKey> GetAllPlayerMappedKeys(FName MappingName);

		 TArray<FEnhancedActionKeyMapping> GetAllPlayerMappableActionKeyMappings();

		 void ClearAllMappings();

		 void AddPlayerMappableConfig(UPlayerMappableInputConfig Config, FModifyContextOptions Options = null);

		 void AddMappingContext(UInputMappingContext MappingContext, int Priority, FModifyContextOptions Options = null);
	}
}