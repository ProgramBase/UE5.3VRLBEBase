using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.GameplayTasksEditor
{
	[PathName("/Script/GameplayTasksEditor.K2Node_LatentGameplayTaskCall")]
	public partial class UK2Node_LatentGameplayTaskCall : UK2Node_BaseAsyncTask, IStaticClass
	{
		public TArray<FName> SpawnParamPins
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpawnParamPins, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpawnParamPins, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTasksEditor.K2Node_LatentGameplayTaskCall");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SpawnParamPins = 0;
	}
}