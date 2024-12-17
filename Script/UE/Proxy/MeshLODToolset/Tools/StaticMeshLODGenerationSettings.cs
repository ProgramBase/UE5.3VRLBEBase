using Script.CoreUObject;
using Script.Library;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.StaticMeshLODGenerationSettings")]
	public partial class UStaticMeshLODGenerationSettings : UObject, IStaticClass
	{
		public FGenerateStaticMeshLODProcess_PreprocessSettings Preprocessing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Preprocessing, __ReturnBuffer);

					return *(FGenerateStaticMeshLODProcess_PreprocessSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Preprocessing, __InBuffer);
				}
			}
		}

		public FGenerateStaticMeshLODProcessSettings MeshGeneration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshGeneration, __ReturnBuffer);

					return *(FGenerateStaticMeshLODProcessSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshGeneration, __InBuffer);
				}
			}
		}

		public FGenerateStaticMeshLODProcess_SimplifySettings Simplification
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Simplification, __ReturnBuffer);

					return *(FGenerateStaticMeshLODProcess_SimplifySettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Simplification, __InBuffer);
				}
			}
		}

		public FGenerateStaticMeshLODProcess_NormalsSettings Normals
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Normals, __ReturnBuffer);

					return *(FGenerateStaticMeshLODProcess_NormalsSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Normals, __InBuffer);
				}
			}
		}

		public FGenerateStaticMeshLODProcess_TextureSettings TextureBaking
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextureBaking, __ReturnBuffer);

					return *(FGenerateStaticMeshLODProcess_TextureSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextureBaking, __InBuffer);
				}
			}
		}

		public FGenerateStaticMeshLODProcess_UVSettings UVGeneration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UVGeneration, __ReturnBuffer);

					return *(FGenerateStaticMeshLODProcess_UVSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UVGeneration, __InBuffer);
				}
			}
		}

		public FGenerateStaticMeshLODProcess_CollisionSettings SimpleCollision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SimpleCollision, __ReturnBuffer);

					return *(FGenerateStaticMeshLODProcess_CollisionSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SimpleCollision, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshLODToolset.StaticMeshLODGenerationSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Preprocessing = 0;

		private static uint __MeshGeneration = 0;

		private static uint __Simplification = 0;

		private static uint __Normals = 0;

		private static uint __TextureBaking = 0;

		private static uint __UVGeneration = 0;

		private static uint __SimpleCollision = 0;
	}
}