using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.GLTFExporter
{
	[PathName("/Script/GLTFExporter.GLTFOverrideMaterialBakeSettings")]
	public partial class FGLTFOverrideMaterialBakeSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GLTFExporter.GLTFOverrideMaterialBakeSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGLTFOverrideMaterialBakeSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGLTFOverrideMaterialBakeSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGLTFOverrideMaterialBakeSettings A, FGLTFOverrideMaterialBakeSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGLTFOverrideMaterialBakeSettings A, FGLTFOverrideMaterialBakeSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGLTFOverrideMaterialBakeSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bOverrideSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideSize, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideSize, __InBuffer);
				}
			}
		}

		public EGLTFMaterialBakeSizePOT Size
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Size, __ReturnBuffer);

					return *(EGLTFMaterialBakeSizePOT*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Size, __InBuffer);
				}
			}
		}

		public bool bOverrideFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideFilter, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideFilter, __InBuffer);
				}
			}
		}

		public TextureFilter Filter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Filter, __ReturnBuffer);

					return *(TextureFilter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Filter, __InBuffer);
				}
			}
		}

		public bool bOverrideTiling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideTiling, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideTiling, __InBuffer);
				}
			}
		}

		public TextureAddress Tiling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Tiling, __ReturnBuffer);

					return *(TextureAddress*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Tiling, __InBuffer);
				}
			}
		}

		private static uint __bOverrideSize = 0;

		private static uint __Size = 0;

		private static uint __bOverrideFilter = 0;

		private static uint __Filter = 0;

		private static uint __bOverrideTiling = 0;

		private static uint __Tiling = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}