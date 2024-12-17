using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MeshInstancingSettings")]
	public partial class FMeshInstancingSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MeshInstancingSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMeshInstancingSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMeshInstancingSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMeshInstancingSettings A, FMeshInstancingSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMeshInstancingSettings A, FMeshInstancingSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMeshInstancingSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<AActor> ActorClassToUse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActorClassToUse, __ReturnBuffer);

					return *(TSubclassOf<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActorClassToUse, __InBuffer);
				}
			}
		}

		public int InstanceReplacementThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InstanceReplacementThreshold, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InstanceReplacementThreshold, __InBuffer);
				}
			}
		}

		public bool bSkipMeshesWithVertexColors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSkipMeshesWithVertexColors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSkipMeshesWithVertexColors, __InBuffer);
				}
			}
		}

		public bool bUseHLODVolumes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bUseHLODVolumes, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bUseHLODVolumes, __InBuffer);
				}
			}
		}

		public TSubclassOf<UInstancedStaticMeshComponent> ISMComponentToUse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ISMComponentToUse, __ReturnBuffer);

					return *(TSubclassOf<UInstancedStaticMeshComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ISMComponentToUse, __InBuffer);
				}
			}
		}

		private static uint __ActorClassToUse = 0;

		private static uint __InstanceReplacementThreshold = 0;

		private static uint __bSkipMeshesWithVertexColors = 0;

		private static uint __bUseHLODVolumes = 0;

		private static uint __ISMComponentToUse = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}