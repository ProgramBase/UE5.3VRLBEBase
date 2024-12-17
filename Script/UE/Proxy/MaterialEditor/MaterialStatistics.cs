using Script.CoreUObject;
using Script.Library;

namespace Script.MaterialEditor
{
	[PathName("/Script/MaterialEditor.MaterialStatistics")]
	public partial class FMaterialStatistics : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MaterialEditor.MaterialStatistics");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialStatistics() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMaterialStatistics() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMaterialStatistics A, FMaterialStatistics B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialStatistics A, FMaterialStatistics B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialStatistics;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int NumVertexShaderInstructions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumVertexShaderInstructions, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumVertexShaderInstructions, __InBuffer);
				}
			}
		}

		public int NumPixelShaderInstructions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumPixelShaderInstructions, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumPixelShaderInstructions, __InBuffer);
				}
			}
		}

		public int NumSamplers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumSamplers, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumSamplers, __InBuffer);
				}
			}
		}

		public int NumVertexTextureSamples
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumVertexTextureSamples, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumVertexTextureSamples, __InBuffer);
				}
			}
		}

		public int NumPixelTextureSamples
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumPixelTextureSamples, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumPixelTextureSamples, __InBuffer);
				}
			}
		}

		public int NumVirtualTextureSamples
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumVirtualTextureSamples, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumVirtualTextureSamples, __InBuffer);
				}
			}
		}

		public int NumUVScalars
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumUVScalars, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumUVScalars, __InBuffer);
				}
			}
		}

		public int NumInterpolatorScalars
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumInterpolatorScalars, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumInterpolatorScalars, __InBuffer);
				}
			}
		}

		private static uint __NumVertexShaderInstructions = 0;

		private static uint __NumPixelShaderInstructions = 0;

		private static uint __NumSamplers = 0;

		private static uint __NumVertexTextureSamples = 0;

		private static uint __NumPixelTextureSamples = 0;

		private static uint __NumVirtualTextureSamples = 0;

		private static uint __NumUVScalars = 0;

		private static uint __NumInterpolatorScalars = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}