using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.RenderableTriangle")]
	public partial class FRenderableTriangle : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ModelingComponents.RenderableTriangle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRenderableTriangle() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRenderableTriangle() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRenderableTriangle A, FRenderableTriangle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRenderableTriangle A, FRenderableTriangle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRenderableTriangle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMaterialInterface Material
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Material, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Material, __InBuffer);
				}
			}
		}

		public FRenderableTriangleVertex Vertex0
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Vertex0, __ReturnBuffer);

					return *(FRenderableTriangleVertex*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Vertex0, __InBuffer);
				}
			}
		}

		public FRenderableTriangleVertex Vertex1
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Vertex1, __ReturnBuffer);

					return *(FRenderableTriangleVertex*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Vertex1, __InBuffer);
				}
			}
		}

		public FRenderableTriangleVertex Vertex2
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Vertex2, __ReturnBuffer);

					return *(FRenderableTriangleVertex*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Vertex2, __InBuffer);
				}
			}
		}

		private static uint __Material = 0;

		private static uint __Vertex0 = 0;

		private static uint __Vertex1 = 0;

		private static uint __Vertex2 = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}