using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionAutoInstanceMesh")]
	public partial class FGeometryCollectionAutoInstanceMesh : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionEngine.GeometryCollectionAutoInstanceMesh");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGeometryCollectionAutoInstanceMesh() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGeometryCollectionAutoInstanceMesh() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGeometryCollectionAutoInstanceMesh A, FGeometryCollectionAutoInstanceMesh B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGeometryCollectionAutoInstanceMesh A, FGeometryCollectionAutoInstanceMesh B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGeometryCollectionAutoInstanceMesh;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UStaticMesh Mesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Mesh, __ReturnBuffer);

					return *(UStaticMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Mesh, __InBuffer);
				}
			}
		}

		public TArray<UMaterialInterface> Materials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Materials, __ReturnBuffer);

					return *(TArray<UMaterialInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Materials, __InBuffer);
				}
			}
		}

		public int NumInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumInstances, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumInstances, __InBuffer);
				}
			}
		}

		public TArray<float> CustomData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CustomData, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CustomData, __InBuffer);
				}
			}
		}

		private static uint __Mesh = 0;

		private static uint __Materials = 0;

		private static uint __NumInstances = 0;

		private static uint __CustomData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}