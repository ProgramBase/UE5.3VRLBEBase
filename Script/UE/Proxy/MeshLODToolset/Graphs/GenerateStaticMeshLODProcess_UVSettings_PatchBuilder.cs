using Script.CoreUObject;
using Script.Library;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.GenerateStaticMeshLODProcess_UVSettings_PatchBuilder")]
	public partial class FGenerateStaticMeshLODProcess_UVSettings_PatchBuilder : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshLODToolset.GenerateStaticMeshLODProcess_UVSettings_PatchBuilder");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGenerateStaticMeshLODProcess_UVSettings_PatchBuilder() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGenerateStaticMeshLODProcess_UVSettings_PatchBuilder() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGenerateStaticMeshLODProcess_UVSettings_PatchBuilder A, FGenerateStaticMeshLODProcess_UVSettings_PatchBuilder B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGenerateStaticMeshLODProcess_UVSettings_PatchBuilder A, FGenerateStaticMeshLODProcess_UVSettings_PatchBuilder B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGenerateStaticMeshLODProcess_UVSettings_PatchBuilder;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float CurvatureAlignment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurvatureAlignment, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurvatureAlignment, __InBuffer);
				}
			}
		}

		public int SmoothingSteps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SmoothingSteps, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SmoothingSteps, __InBuffer);
				}
			}
		}

		public float SmoothingAlpha
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SmoothingAlpha, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SmoothingAlpha, __InBuffer);
				}
			}
		}

		private static uint __CurvatureAlignment = 0;

		private static uint __SmoothingSteps = 0;

		private static uint __SmoothingAlpha = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}