using Script.CoreUObject;
using Script.Library;

namespace Script.AlembicLibrary
{
	[PathName("/Script/AlembicLibrary.AbcNormalGenerationSettings")]
	public partial class FAbcNormalGenerationSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AlembicLibrary.AbcNormalGenerationSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAbcNormalGenerationSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAbcNormalGenerationSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAbcNormalGenerationSettings A, FAbcNormalGenerationSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAbcNormalGenerationSettings A, FAbcNormalGenerationSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAbcNormalGenerationSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bForceOneSmoothingGroupPerObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bForceOneSmoothingGroupPerObject, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bForceOneSmoothingGroupPerObject, __InBuffer);
				}
			}
		}

		public float HardEdgeAngleThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HardEdgeAngleThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HardEdgeAngleThreshold, __InBuffer);
				}
			}
		}

		public bool bRecomputeNormals
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRecomputeNormals, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRecomputeNormals, __InBuffer);
				}
			}
		}

		public bool bIgnoreDegenerateTriangles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIgnoreDegenerateTriangles, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIgnoreDegenerateTriangles, __InBuffer);
				}
			}
		}

		public bool bSkipComputingTangents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSkipComputingTangents, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSkipComputingTangents, __InBuffer);
				}
			}
		}

		private static uint __bForceOneSmoothingGroupPerObject = 0;

		private static uint __HardEdgeAngleThreshold = 0;

		private static uint __bRecomputeNormals = 0;

		private static uint __bIgnoreDegenerateTriangles = 0;

		private static uint __bSkipComputingTangents = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}