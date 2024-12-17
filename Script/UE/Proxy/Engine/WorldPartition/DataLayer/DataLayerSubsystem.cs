using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DataLayerSubsystem")]
	public partial class UDataLayerSubsystem : UWorldSubsystem, IStaticClass
	{
		public FOnDataLayerRuntimeStateChanged OnDataLayerRuntimeStateChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnDataLayerRuntimeStateChanged, __ReturnBuffer);

					return *(FOnDataLayerRuntimeStateChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnDataLayerRuntimeStateChanged, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<UDataLayerLoadingPolicy> DataLayerLoadingPolicyClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerLoadingPolicyClass, __ReturnBuffer);

					return *(TSoftClassPtr<UDataLayerLoadingPolicy>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerLoadingPolicyClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DataLayerSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetDataLayerStateByLabel(FName InDataLayerLabel, EDataLayerState InState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InDataLayerLabel?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InState;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDataLayerStateByLabel, __InBuffer);
			}
		}

		public virtual void SetDataLayerState(FActorDataLayer InDataLayer, EDataLayerState InState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InDataLayer?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InState;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDataLayerState, __InBuffer);
			}
		}

		public virtual void SetDataLayerRuntimeStateByLabel(FName InDataLayerLabel, EDataLayerRuntimeState InState, bool bInIsRecursive = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InDataLayerLabel?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InState;

				*(bool*)(__InBuffer + 9) = bInIsRecursive;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDataLayerRuntimeStateByLabel, __InBuffer);
			}
		}

		public virtual void SetDataLayerRuntimeState(FActorDataLayer InDataLayer, EDataLayerRuntimeState InState, bool bInIsRecursive = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InDataLayer?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InState;

				*(bool*)(__InBuffer + 9) = bInIsRecursive;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDataLayerRuntimeState, __InBuffer);
			}
		}

		public virtual void SetDataLayerInstanceRuntimeState(UDataLayerAsset InDataLayerAsset, EDataLayerRuntimeState InState, bool bInIsRecursive = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InDataLayerAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InState;

				*(bool*)(__InBuffer + 9) = bInIsRecursive;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDataLayerInstanceRuntimeState, __InBuffer);
			}
		}

		public virtual TSet<FName> GetLoadedDataLayerNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLoadedDataLayerNames, __ReturnBuffer);

				return *(TSet<FName>*)__ReturnBuffer;
			}
		}

		public virtual EDataLayerState GetDataLayerStateByLabel(FName InDataLayerLabel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayerLabel?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDataLayerStateByLabel, __InBuffer, __ReturnBuffer);

				return *(EDataLayerState*)__ReturnBuffer;
			}
		}

		public virtual EDataLayerState GetDataLayerState(FActorDataLayer InDataLayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDataLayerState, __InBuffer, __ReturnBuffer);

				return *(EDataLayerState*)__ReturnBuffer;
			}
		}

		public virtual EDataLayerRuntimeState GetDataLayerRuntimeStateByLabel(FName InDataLayerLabel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayerLabel?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDataLayerRuntimeStateByLabel, __InBuffer, __ReturnBuffer);

				return *(EDataLayerRuntimeState*)__ReturnBuffer;
			}
		}

		public virtual EDataLayerRuntimeState GetDataLayerRuntimeState(FActorDataLayer InDataLayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDataLayerRuntimeState, __InBuffer, __ReturnBuffer);

				return *(EDataLayerRuntimeState*)__ReturnBuffer;
			}
		}

		public virtual EDataLayerRuntimeState GetDataLayerInstanceRuntimeState(UDataLayerAsset InDataLayerAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayerAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDataLayerInstanceRuntimeState, __InBuffer, __ReturnBuffer);

				return *(EDataLayerRuntimeState*)__ReturnBuffer;
			}
		}

		public virtual UDataLayerInstance GetDataLayerInstanceFromAsset(UDataLayerAsset InDataLayerAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayerAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDataLayerInstanceFromAsset, __InBuffer, __ReturnBuffer);

				return *(UDataLayerInstance*)__ReturnBuffer;
			}
		}

		public virtual EDataLayerRuntimeState GetDataLayerInstanceEffectiveRuntimeState(UDataLayerAsset InDataLayerAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayerAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDataLayerInstanceEffectiveRuntimeState, __InBuffer, __ReturnBuffer);

				return *(EDataLayerRuntimeState*)__ReturnBuffer;
			}
		}

		public virtual UDataLayerInstance GetDataLayerFromName(FName InDataLayerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayerName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDataLayerFromName, __InBuffer, __ReturnBuffer);

				return *(UDataLayerInstance*)__ReturnBuffer;
			}
		}

		public virtual UDataLayerInstance GetDataLayerFromLabel(FName InDataLayerLabel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayerLabel?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDataLayerFromLabel, __InBuffer, __ReturnBuffer);

				return *(UDataLayerInstance*)__ReturnBuffer;
			}
		}

		public virtual EDataLayerRuntimeState GetDataLayerEffectiveRuntimeStateByLabel(FName InDataLayerLabel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayerLabel?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDataLayerEffectiveRuntimeStateByLabel, __InBuffer, __ReturnBuffer);

				return *(EDataLayerRuntimeState*)__ReturnBuffer;
			}
		}

		public virtual EDataLayerRuntimeState GetDataLayerEffectiveRuntimeState(FActorDataLayer InDataLayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDataLayerEffectiveRuntimeState, __InBuffer, __ReturnBuffer);

				return *(EDataLayerRuntimeState*)__ReturnBuffer;
			}
		}

		public virtual UDataLayerInstance GetDataLayer(FActorDataLayer InDataLayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDataLayer, __InBuffer, __ReturnBuffer);

				return *(UDataLayerInstance*)__ReturnBuffer;
			}
		}

		public virtual TSet<FName> GetActiveDataLayerNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetActiveDataLayerNames, __ReturnBuffer);

				return *(TSet<FName>*)__ReturnBuffer;
			}
		}

		private static uint __OnDataLayerRuntimeStateChanged = 0;

		private static uint __DataLayerLoadingPolicyClass = 0;

		private static uint __SetDataLayerStateByLabel = 0;

		private static uint __SetDataLayerState = 0;

		private static uint __SetDataLayerRuntimeStateByLabel = 0;

		private static uint __SetDataLayerRuntimeState = 0;

		private static uint __SetDataLayerInstanceRuntimeState = 0;

		private static uint __GetLoadedDataLayerNames = 0;

		private static uint __GetDataLayerStateByLabel = 0;

		private static uint __GetDataLayerState = 0;

		private static uint __GetDataLayerRuntimeStateByLabel = 0;

		private static uint __GetDataLayerRuntimeState = 0;

		private static uint __GetDataLayerInstanceRuntimeState = 0;

		private static uint __GetDataLayerInstanceFromAsset = 0;

		private static uint __GetDataLayerInstanceEffectiveRuntimeState = 0;

		private static uint __GetDataLayerFromName = 0;

		private static uint __GetDataLayerFromLabel = 0;

		private static uint __GetDataLayerEffectiveRuntimeStateByLabel = 0;

		private static uint __GetDataLayerEffectiveRuntimeState = 0;

		private static uint __GetDataLayer = 0;

		private static uint __GetActiveDataLayerNames = 0;
	}
}