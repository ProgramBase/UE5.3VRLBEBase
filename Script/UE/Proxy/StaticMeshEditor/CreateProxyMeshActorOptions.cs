using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.StaticMeshEditor
{
	[PathName("/Script/StaticMeshEditor.CreateProxyMeshActorOptions")]
	public partial class FCreateProxyMeshActorOptions : FJoinStaticMeshActorsOptions, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/StaticMeshEditor.CreateProxyMeshActorOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCreateProxyMeshActorOptions()
		{
		}

		public static bool operator ==(FCreateProxyMeshActorOptions A, FCreateProxyMeshActorOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCreateProxyMeshActorOptions A, FCreateProxyMeshActorOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCreateProxyMeshActorOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bSpawnMergedActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSpawnMergedActor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSpawnMergedActor, __InBuffer);
				}
			}
		}

		public FString BasePackageName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BasePackageName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BasePackageName, __InBuffer);
				}
			}
		}

		public FMeshProxySettings MeshProxySettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MeshProxySettings, __ReturnBuffer);

					return *(FMeshProxySettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MeshProxySettings, __InBuffer);
				}
			}
		}

		private static uint __bSpawnMergedActor = 0;

		private static uint __BasePackageName = 0;

		private static uint __MeshProxySettings = 0;

	}
}