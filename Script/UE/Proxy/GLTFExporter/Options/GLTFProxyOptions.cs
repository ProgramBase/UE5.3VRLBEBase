using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GLTFExporter
{
	[PathName("/Script/GLTFExporter.GLTFProxyOptions")]
	public partial class UGLTFProxyOptions : UObject, IStaticClass
	{
		public bool bBakeMaterialInputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bBakeMaterialInputs, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bBakeMaterialInputs, __InBuffer);
				}
			}
		}

		public EGLTFMaterialBakeSizePOT DefaultMaterialBakeSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMaterialBakeSize, __ReturnBuffer);

					return *(EGLTFMaterialBakeSizePOT*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMaterialBakeSize, __InBuffer);
				}
			}
		}

		public TextureFilter DefaultMaterialBakeFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMaterialBakeFilter, __ReturnBuffer);

					return *(TextureFilter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMaterialBakeFilter, __InBuffer);
				}
			}
		}

		public TextureAddress DefaultMaterialBakeTiling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMaterialBakeTiling, __ReturnBuffer);

					return *(TextureAddress*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMaterialBakeTiling, __InBuffer);
				}
			}
		}

		public TMap<EGLTFMaterialPropertyGroup, FGLTFOverrideMaterialBakeSettings> DefaultInputBakeSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultInputBakeSettings, __ReturnBuffer);

					return *(TMap<EGLTFMaterialPropertyGroup, FGLTFOverrideMaterialBakeSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultInputBakeSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GLTFExporter.GLTFProxyOptions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ResetToDefault()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetToDefault);
			}
		}

		private static uint __bBakeMaterialInputs = 0;

		private static uint __DefaultMaterialBakeSize = 0;

		private static uint __DefaultMaterialBakeFilter = 0;

		private static uint __DefaultMaterialBakeTiling = 0;

		private static uint __DefaultInputBakeSettings = 0;

		private static uint __ResetToDefault = 0;
	}
}