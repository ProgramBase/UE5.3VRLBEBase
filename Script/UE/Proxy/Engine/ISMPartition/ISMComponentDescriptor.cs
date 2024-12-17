using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ISMComponentDescriptor")]
	public partial class FISMComponentDescriptor : FISMComponentDescriptorBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ISMComponentDescriptor");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FISMComponentDescriptor()
		{
		}

		public static bool operator ==(FISMComponentDescriptor A, FISMComponentDescriptor B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FISMComponentDescriptor A, FISMComponentDescriptor B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FISMComponentDescriptor;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UStaticMesh StaticMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StaticMesh, __ReturnBuffer);

					return *(UStaticMesh*)__ReturnBuffer;
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

		public TArray<UMaterialInterface> OverrideMaterials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OverrideMaterials, __ReturnBuffer);

					return *(TArray<UMaterialInterface>*)__ReturnBuffer;
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

		public UMaterialInterface OverlayMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OverlayMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
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

		public TArray<URuntimeVirtualTexture> RuntimeVirtualTextures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RuntimeVirtualTextures, __ReturnBuffer);

					return *(TArray<URuntimeVirtualTexture>*)__ReturnBuffer;
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