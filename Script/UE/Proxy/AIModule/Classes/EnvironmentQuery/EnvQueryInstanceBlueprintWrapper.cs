using Script.CoreUObject;
using Script.AIModule.EnvQueryInstanceBlueprintWrapper;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryInstanceBlueprintWrapper")]
	public partial class UEnvQueryInstanceBlueprintWrapper : UObject, IStaticClass, IEQSQueryResultSourceInterface
	{
		public int QueryID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __QueryID, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __QueryID, __InBuffer);
				}
			}
		}

		public TSubclassOf<UEnvQueryItemType> ItemType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ItemType, __ReturnBuffer);

					return *(TSubclassOf<UEnvQueryItemType>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ItemType, __InBuffer);
				}
			}
		}

		public int OptionIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OptionIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OptionIndex, __InBuffer);
				}
			}
		}

		public FEQSQueryDoneSignature OnQueryFinishedEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnQueryFinishedEvent, __ReturnBuffer);

					return *(FEQSQueryDoneSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnQueryFinishedEvent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryInstanceBlueprintWrapper");
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

		public virtual void SetNamedParam(FName ParamName, float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ParamName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNamedParam, __InBuffer);
			}
		}

		public virtual TArray<FVector> GetResultsAsLocations()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetResultsAsLocations, __ReturnBuffer);

				return *(TArray<FVector>*)__ReturnBuffer;
			}
		}

		public virtual TArray<AActor> GetResultsAsActors()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetResultsAsActors, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		public virtual bool GetQueryResultsAsLocations(ref TArray<FVector> ResultLocations)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ResultLocations?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetQueryResultsAsLocations, __InBuffer, __OutBuffer, __ReturnBuffer);

				ResultLocations = *(TArray<FVector>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetQueryResultsAsActors(ref TArray<AActor> ResultActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ResultActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetQueryResultsAsActors, __InBuffer, __OutBuffer, __ReturnBuffer);

				ResultActors = *(TArray<AActor>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetItemScore(int ItemIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ItemIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetItemScore, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __QueryID = 0;

		private static uint __ItemType = 0;

		private static uint __OptionIndex = 0;

		private static uint __OnQueryFinishedEvent = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetNamedParam = 0;

		private static uint __GetResultsAsLocations = 0;

		private static uint __GetResultsAsActors = 0;

		private static uint __GetQueryResultsAsLocations = 0;

		private static uint __GetQueryResultsAsActors = 0;

		private static uint __GetItemScore = 0;
	}
}