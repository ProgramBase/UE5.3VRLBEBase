using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldDataLayers")]
	public partial class AWorldDataLayers : AInfo, IStaticClass
	{
		public bool bAllowRuntimeDataLayerEditing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowRuntimeDataLayerEditing, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowRuntimeDataLayerEditing, __InBuffer);
				}
			}
		}

		public FActorPlacementDataLayers CurrentDataLayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentDataLayers, __ReturnBuffer);

					return *(FActorPlacementDataLayers*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentDataLayers, __InBuffer);
				}
			}
		}

		public TSet<UDataLayerInstance> DataLayerInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerInstances, __ReturnBuffer);

					return *(TSet<UDataLayerInstance>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerInstances, __InBuffer);
				}
			}
		}

		public TMap<FName, TWeakObjectPtr<UDataLayerInstance>> DeprecatedDataLayerNameToDataLayerInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DeprecatedDataLayerNameToDataLayerInstance, __ReturnBuffer);

					return *(TMap<FName, TWeakObjectPtr<UDataLayerInstance>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DeprecatedDataLayerNameToDataLayerInstance, __InBuffer);
				}
			}
		}

		public TArray<FName> RepActiveDataLayerNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RepActiveDataLayerNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RepActiveDataLayerNames, __InBuffer);
				}
			}
		}

		public TArray<FName> RepLoadedDataLayerNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RepLoadedDataLayerNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RepLoadedDataLayerNames, __InBuffer);
				}
			}
		}

		public TArray<FName> RepEffectiveActiveDataLayerNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RepEffectiveActiveDataLayerNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RepEffectiveActiveDataLayerNames, __InBuffer);
				}
			}
		}

		public TArray<FName> RepEffectiveLoadedDataLayerNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RepEffectiveLoadedDataLayerNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RepEffectiveLoadedDataLayerNames, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldDataLayers");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void OnRep_LoadedDataLayerNames()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_LoadedDataLayerNames);
			}
		}

		public virtual void OnRep_EffectiveLoadedDataLayerNames()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_EffectiveLoadedDataLayerNames);
			}
		}

		public virtual void OnRep_EffectiveActiveDataLayerNames()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_EffectiveActiveDataLayerNames);
			}
		}

		public virtual void OnRep_ActiveDataLayerNames()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_ActiveDataLayerNames);
			}
		}

		public virtual void OnDataLayerRuntimeStateChanged(UDataLayerInstance InDataLayer, EDataLayerRuntimeState InState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InDataLayer?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InState;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __OnDataLayerRuntimeStateChanged, __InBuffer);
			}
		}

		private static uint __bAllowRuntimeDataLayerEditing = 0;

		private static uint __CurrentDataLayers = 0;

		private static uint __DataLayerInstances = 0;

		private static uint __DeprecatedDataLayerNameToDataLayerInstance = 0;

		private static uint __RepActiveDataLayerNames = 0;

		private static uint __RepLoadedDataLayerNames = 0;

		private static uint __RepEffectiveActiveDataLayerNames = 0;

		private static uint __RepEffectiveLoadedDataLayerNames = 0;

		private static uint __OnRep_LoadedDataLayerNames = 0;

		private static uint __OnRep_EffectiveLoadedDataLayerNames = 0;

		private static uint __OnRep_EffectiveActiveDataLayerNames = 0;

		private static uint __OnRep_ActiveDataLayerNames = 0;

		private static uint __OnDataLayerRuntimeStateChanged = 0;
	}
}