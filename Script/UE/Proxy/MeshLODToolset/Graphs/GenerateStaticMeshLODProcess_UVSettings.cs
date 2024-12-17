using Script.CoreUObject;
using Script.Library;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.GenerateStaticMeshLODProcess_UVSettings")]
	public partial class FGenerateStaticMeshLODProcess_UVSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshLODToolset.GenerateStaticMeshLODProcess_UVSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGenerateStaticMeshLODProcess_UVSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGenerateStaticMeshLODProcess_UVSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGenerateStaticMeshLODProcess_UVSettings A, FGenerateStaticMeshLODProcess_UVSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGenerateStaticMeshLODProcess_UVSettings A, FGenerateStaticMeshLODProcess_UVSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGenerateStaticMeshLODProcess_UVSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EGenerateStaticMeshLODProcess_AutoUVMethod UVMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UVMethod, __ReturnBuffer);

					return *(EGenerateStaticMeshLODProcess_AutoUVMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UVMethod, __InBuffer);
				}
			}
		}

		public int NumUVAtlasCharts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumUVAtlasCharts, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumUVAtlasCharts, __InBuffer);
				}
			}
		}

		public int NumInitialPatches
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumInitialPatches, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumInitialPatches, __InBuffer);
				}
			}
		}

		public float MergingThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MergingThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MergingThreshold, __InBuffer);
				}
			}
		}

		public float MaxAngleDeviation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxAngleDeviation, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxAngleDeviation, __InBuffer);
				}
			}
		}

		public FGenerateStaticMeshLODProcess_UVSettings_PatchBuilder PatchBuilder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PatchBuilder, __ReturnBuffer);

					return *(FGenerateStaticMeshLODProcess_UVSettings_PatchBuilder*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PatchBuilder, __InBuffer);
				}
			}
		}

		private static uint __UVMethod = 0;

		private static uint __NumUVAtlasCharts = 0;

		private static uint __NumInitialPatches = 0;

		private static uint __MergingThreshold = 0;

		private static uint __MaxAngleDeviation = 0;

		private static uint __PatchBuilder = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}