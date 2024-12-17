using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DataLayerManager")]
	public partial class UDataLayerManager : UObject, IStaticClass
	{
		public FOnDataLayerInstanceRuntimeStateChanged OnDataLayerInstanceRuntimeStateChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnDataLayerInstanceRuntimeStateChanged, __ReturnBuffer);

					return *(FOnDataLayerInstanceRuntimeStateChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnDataLayerInstanceRuntimeStateChanged, __InBuffer);
				}
			}
		}

		public TSet<UObject> ReferencedObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReferencedObjects, __ReturnBuffer);

					return *(TSet<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReferencedObjects, __InBuffer);
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

		public TSoftClassPtr<UDataLayerInstanceWithAsset> DataLayerInstanceWithAssetClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerInstanceWithAssetClass, __ReturnBuffer);

					return *(TSoftClassPtr<UDataLayerInstanceWithAsset>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerInstanceWithAssetClass, __InBuffer);
				}
			}
		}

		public UDataLayerLoadingPolicy DataLayerLoadingPolicy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerLoadingPolicy, __ReturnBuffer);

					return *(UDataLayerLoadingPolicy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerLoadingPolicy, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DataLayerManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetDataLayerRuntimeState(UDataLayerAsset InDataLayerAsset, EDataLayerRuntimeState InState, bool bInIsRecursive = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InDataLayerAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InState;

				*(bool*)(__InBuffer + 9) = bInIsRecursive;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetDataLayerRuntimeState, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetDataLayerInstanceRuntimeState(UDataLayerInstance InDataLayerInstance, EDataLayerRuntimeState InState, bool bInIsRecursive = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InDataLayerInstance?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InState;

				*(bool*)(__InBuffer + 9) = bInIsRecursive;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetDataLayerInstanceRuntimeState, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual EDataLayerRuntimeState GetDataLayerInstanceRuntimeState(UDataLayerInstance InDataLayerInstance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayerInstance?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDataLayerInstanceRuntimeState, __InBuffer, __ReturnBuffer);

				return *(EDataLayerRuntimeState*)__ReturnBuffer;
			}
		}

		public virtual UDataLayerInstance GetDataLayerInstanceFromName(FName InDataLayerInstanceName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayerInstanceName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDataLayerInstanceFromName, __InBuffer, __ReturnBuffer);

				return *(UDataLayerInstance*)__ReturnBuffer;
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

		public virtual EDataLayerRuntimeState GetDataLayerInstanceEffectiveRuntimeState(UDataLayerInstance InDataLayerInstance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayerInstance?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDataLayerInstanceEffectiveRuntimeState, __InBuffer, __ReturnBuffer);

				return *(EDataLayerRuntimeState*)__ReturnBuffer;
			}
		}

		private static uint __OnDataLayerInstanceRuntimeStateChanged = 0;

		private static uint __ReferencedObjects = 0;

		private static uint __DataLayerLoadingPolicyClass = 0;

		private static uint __DataLayerInstanceWithAssetClass = 0;

		private static uint __DataLayerLoadingPolicy = 0;

		private static uint __SetDataLayerRuntimeState = 0;

		private static uint __SetDataLayerInstanceRuntimeState = 0;

		private static uint __GetDataLayerInstanceRuntimeState = 0;

		private static uint __GetDataLayerInstanceFromName = 0;

		private static uint __GetDataLayerInstanceFromAsset = 0;

		private static uint __GetDataLayerInstanceEffectiveRuntimeState = 0;
	}
}