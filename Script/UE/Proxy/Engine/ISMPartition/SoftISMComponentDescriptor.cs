using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoftISMComponentDescriptor")]
	public partial class FSoftISMComponentDescriptor : FISMComponentDescriptorBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SoftISMComponentDescriptor");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoftISMComponentDescriptor()
		{
		}

		public static bool operator ==(FSoftISMComponentDescriptor A, FSoftISMComponentDescriptor B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoftISMComponentDescriptor A, FSoftISMComponentDescriptor B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoftISMComponentDescriptor;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSoftObjectPtr<UStaticMesh> StaticMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StaticMesh, __ReturnBuffer);

					return *(TSoftObjectPtr<UStaticMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StaticMesh, __InBuffer);
				}
			}
		}

		public TArray<TSoftObjectPtr<UMaterialInterface>> OverrideMaterials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OverrideMaterials, __ReturnBuffer);

					return *(TArray<TSoftObjectPtr<UMaterialInterface>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OverrideMaterials, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UMaterialInterface> OverlayMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OverlayMaterial, __ReturnBuffer);

					return *(TSoftObjectPtr<UMaterialInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OverlayMaterial, __InBuffer);
				}
			}
		}

		public TArray<TSoftObjectPtr<URuntimeVirtualTexture>> RuntimeVirtualTextures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RuntimeVirtualTextures, __ReturnBuffer);

					return *(TArray<TSoftObjectPtr<URuntimeVirtualTexture>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RuntimeVirtualTextures, __InBuffer);
				}
			}
		}

		private static uint __StaticMesh = 0;

		private static uint __OverrideMaterials = 0;

		private static uint __OverlayMaterial = 0;

		private static uint __RuntimeVirtualTextures = 0;

	}
}