using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.MaterialExpressionMaterialXTextureSampleParameterBlur")]
	public partial class UMaterialExpressionMaterialXTextureSampleParameterBlur : UMaterialExpressionTextureSampleParameter2D, IStaticClass
	{
		public EMAterialXTextureSampleBlurKernel KernelSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __KernelSize, __ReturnBuffer);

					return *(EMAterialXTextureSampleBlurKernel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __KernelSize, __InBuffer);
				}
			}
		}

		public float FilterSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FilterSize, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FilterSize, __InBuffer);
				}
			}
		}

		public float FilterOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FilterOffset, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FilterOffset, __InBuffer);
				}
			}
		}

		public EMaterialXTextureSampleBlurFilter Filter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Filter, __ReturnBuffer);

					return *(EMaterialXTextureSampleBlurFilter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Filter, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.MaterialExpressionMaterialXTextureSampleParameterBlur");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __KernelSize = 0;

		private static uint __FilterSize = 0;

		private static uint __FilterOffset = 0;

		private static uint __Filter = 0;
	}
}