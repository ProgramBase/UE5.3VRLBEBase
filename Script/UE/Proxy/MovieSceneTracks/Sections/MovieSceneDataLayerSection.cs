using Script.CoreUObject;
using Script.MovieScene;
using Script.Engine;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneDataLayerSection")]
	public partial class UMovieSceneDataLayerSection : UMovieSceneSection, IStaticClass, IMovieSceneEntityProvider
	{
		public TArray<FActorDataLayer> DataLayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayers, __ReturnBuffer);

					return *(TArray<FActorDataLayer>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayers, __InBuffer);
				}
			}
		}

		public TArray<UDataLayerAsset> DataLayerAssets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerAssets, __ReturnBuffer);

					return *(TArray<UDataLayerAsset>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerAssets, __InBuffer);
				}
			}
		}

		public EDataLayerRuntimeState DesiredState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DesiredState, __ReturnBuffer);

					return *(EDataLayerRuntimeState*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DesiredState, __InBuffer);
				}
			}
		}

		public EDataLayerRuntimeState PrerollState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PrerollState, __ReturnBuffer);

					return *(EDataLayerRuntimeState*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PrerollState, __InBuffer);
				}
			}
		}

		public bool bFlushOnUnload
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bFlushOnUnload, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bFlushOnUnload, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneDataLayerSection");
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

		public virtual void SetPrerollState(EDataLayerRuntimeState InPrerollState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InPrerollState;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPrerollState, __InBuffer);
			}
		}

		public virtual void SetFlushOnUnload(bool bFlushOnUnload)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bFlushOnUnload;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFlushOnUnload, __InBuffer);
			}
		}

		public virtual void SetDesiredState(EDataLayerRuntimeState InDesiredState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InDesiredState;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDesiredState, __InBuffer);
			}
		}

		public virtual void SetDataLayers(TArray<FActorDataLayer> InDataLayers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayers?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDataLayers, __InBuffer);
			}
		}

		public virtual void SetDataLayerAssets(TArray<UDataLayerAsset> InDataLayerAssets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDataLayerAssets?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDataLayerAssets, __InBuffer);
			}
		}

		public virtual EDataLayerRuntimeState GetPrerollState()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPrerollState, __ReturnBuffer);

				return *(EDataLayerRuntimeState*)__ReturnBuffer;
			}
		}

		public virtual bool GetFlushOnUnload()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetFlushOnUnload, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual EDataLayerRuntimeState GetDesiredState()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDesiredState, __ReturnBuffer);

				return *(EDataLayerRuntimeState*)__ReturnBuffer;
			}
		}

		public virtual TArray<FActorDataLayer> GetDataLayers()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDataLayers, __ReturnBuffer);

				return *(TArray<FActorDataLayer>*)__ReturnBuffer;
			}
		}

		public virtual TArray<UDataLayerAsset> GetDataLayerAssets()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDataLayerAssets, __ReturnBuffer);

				return *(TArray<UDataLayerAsset>*)__ReturnBuffer;
			}
		}

		private static uint __DataLayers = 0;

		private static uint __DataLayerAssets = 0;

		private static uint __DesiredState = 0;

		private static uint __PrerollState = 0;

		private static uint __bFlushOnUnload = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetPrerollState = 0;

		private static uint __SetFlushOnUnload = 0;

		private static uint __SetDesiredState = 0;

		private static uint __SetDataLayers = 0;

		private static uint __SetDataLayerAssets = 0;

		private static uint __GetPrerollState = 0;

		private static uint __GetFlushOnUnload = 0;

		private static uint __GetDesiredState = 0;

		private static uint __GetDataLayers = 0;

		private static uint __GetDataLayerAssets = 0;
	}
}