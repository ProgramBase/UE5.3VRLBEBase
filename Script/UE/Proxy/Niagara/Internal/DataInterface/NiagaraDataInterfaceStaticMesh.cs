using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceStaticMesh")]
	public partial class UNiagaraDataInterfaceStaticMesh : UNiagaraDataInterface, IStaticClass
	{
		public ENDIStaticMesh_SourceMode SourceMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceMode, __ReturnBuffer);

					return *(ENDIStaticMesh_SourceMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceMode, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UStaticMesh> PreviewMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewMesh, __ReturnBuffer);

					return *(TSoftObjectPtr<UStaticMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewMesh, __InBuffer);
				}
			}
		}

		public UStaticMesh DefaultMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMesh, __ReturnBuffer);

					return *(UStaticMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMesh, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<AActor> SoftSourceActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SoftSourceActor, __ReturnBuffer);

					return *(TSoftObjectPtr<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SoftSourceActor, __InBuffer);
				}
			}
		}

		public UStaticMeshComponent SourceComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceComponent, __ReturnBuffer);

					return *(UStaticMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceComponent, __InBuffer);
				}
			}
		}

		public FNDIStaticMeshSectionFilter SectionFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SectionFilter, __ReturnBuffer);

					return *(FNDIStaticMeshSectionFilter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SectionFilter, __InBuffer);
				}
			}
		}

		public bool bCaptureTransformsPerFrame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCaptureTransformsPerFrame, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCaptureTransformsPerFrame, __InBuffer);
				}
			}
		}

		public bool bUsePhysicsBodyVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUsePhysicsBodyVelocity, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUsePhysicsBodyVelocity, __InBuffer);
				}
			}
		}

		public bool bAllowSamplingFromStreamingLODs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowSamplingFromStreamingLODs, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowSamplingFromStreamingLODs, __InBuffer);
				}
			}
		}

		public int LODIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODIndex, __InBuffer);
				}
			}
		}

		public FNiagaraUserParameterBinding LODIndexUserParameter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODIndexUserParameter, __ReturnBuffer);

					return *(FNiagaraUserParameterBinding*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODIndexUserParameter, __InBuffer);
				}
			}
		}

		public int InstanceIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceIndex, __InBuffer);
				}
			}
		}

		public TArray<FName> FilteredSockets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FilteredSockets, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FilteredSockets, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterfaceStaticMesh");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetNiagaraStaticMeshDIInstanceIndex(UNiagaraComponent NiagaraSystem, FName UserParameterName, int NewInstanceIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UserParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = NewInstanceIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraStaticMeshDIInstanceIndex, __InBuffer);
			}
		}

		public virtual void OnSourceEndPlay(AActor InSource, EEndPlayReason Reason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InSource?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Reason;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnSourceEndPlay, __InBuffer);
			}
		}

		private static uint __SourceMode = 0;

		private static uint __PreviewMesh = 0;

		private static uint __DefaultMesh = 0;

		private static uint __SoftSourceActor = 0;

		private static uint __SourceComponent = 0;

		private static uint __SectionFilter = 0;

		private static uint __bCaptureTransformsPerFrame = 0;

		private static uint __bUsePhysicsBodyVelocity = 0;

		private static uint __bAllowSamplingFromStreamingLODs = 0;

		private static uint __LODIndex = 0;

		private static uint __LODIndexUserParameter = 0;

		private static uint __InstanceIndex = 0;

		private static uint __FilteredSockets = 0;

		private static uint __SetNiagaraStaticMeshDIInstanceIndex = 0;

		private static uint __OnSourceEndPlay = 0;
	}
}