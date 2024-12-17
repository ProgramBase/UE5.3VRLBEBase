using Script.CoreUObject;
using Script.Library;

namespace Script.AlembicLibrary
{
	[PathName("/Script/AlembicLibrary.AbcCompressionSettings")]
	public partial class FAbcCompressionSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AlembicLibrary.AbcCompressionSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAbcCompressionSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAbcCompressionSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAbcCompressionSettings A, FAbcCompressionSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAbcCompressionSettings A, FAbcCompressionSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAbcCompressionSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bMergeMeshes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bMergeMeshes, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bMergeMeshes, __InBuffer);
				}
			}
		}

		public bool bBakeMatrixAnimation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bBakeMatrixAnimation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bBakeMatrixAnimation, __InBuffer);
				}
			}
		}

		public EBaseCalculationType BaseCalculationType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BaseCalculationType, __ReturnBuffer);

					return *(EBaseCalculationType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BaseCalculationType, __InBuffer);
				}
			}
		}

		public float PercentageOfTotalBases
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PercentageOfTotalBases, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PercentageOfTotalBases, __InBuffer);
				}
			}
		}

		public int MaxNumberOfBases
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxNumberOfBases, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxNumberOfBases, __InBuffer);
				}
			}
		}

		public float MinimumNumberOfVertexInfluencePercentage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinimumNumberOfVertexInfluencePercentage, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinimumNumberOfVertexInfluencePercentage, __InBuffer);
				}
			}
		}

		private static uint __bMergeMeshes = 0;

		private static uint __bBakeMatrixAnimation = 0;

		private static uint __BaseCalculationType = 0;

		private static uint __PercentageOfTotalBases = 0;

		private static uint __MaxNumberOfBases = 0;

		private static uint __MinimumNumberOfVertexInfluencePercentage = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}