using Script.CoreUObject;
using Script.Library;

namespace Script.AlembicLibrary
{
	[PathName("/Script/AlembicLibrary.AbcGeometryCacheSettings")]
	public partial class FAbcGeometryCacheSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AlembicLibrary.AbcGeometryCacheSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAbcGeometryCacheSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAbcGeometryCacheSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAbcGeometryCacheSettings A, FAbcGeometryCacheSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAbcGeometryCacheSettings A, FAbcGeometryCacheSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAbcGeometryCacheSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bFlattenTracks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bFlattenTracks, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bFlattenTracks, __InBuffer);
				}
			}
		}

		public bool bStoreImportedVertexNumbers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bStoreImportedVertexNumbers, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bStoreImportedVertexNumbers, __InBuffer);
				}
			}
		}

		public bool bApplyConstantTopologyOptimizations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bApplyConstantTopologyOptimizations, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bApplyConstantTopologyOptimizations, __InBuffer);
				}
			}
		}

		public EAbcGeometryCacheMotionVectorsImport MotionVectors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MotionVectors, __ReturnBuffer);

					return *(EAbcGeometryCacheMotionVectorsImport*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MotionVectors, __InBuffer);
				}
			}
		}

		public bool bOptimizeIndexBuffers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOptimizeIndexBuffers, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOptimizeIndexBuffers, __InBuffer);
				}
			}
		}

		public float CompressedPositionPrecision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CompressedPositionPrecision, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CompressedPositionPrecision, __InBuffer);
				}
			}
		}

		public int CompressedTextureCoordinatesNumberOfBits
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CompressedTextureCoordinatesNumberOfBits, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CompressedTextureCoordinatesNumberOfBits, __InBuffer);
				}
			}
		}

		private static uint __bFlattenTracks = 0;

		private static uint __bStoreImportedVertexNumbers = 0;

		private static uint __bApplyConstantTopologyOptimizations = 0;

		private static uint __MotionVectors = 0;

		private static uint __bOptimizeIndexBuffers = 0;

		private static uint __CompressedPositionPrecision = 0;

		private static uint __CompressedTextureCoordinatesNumberOfBits = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}