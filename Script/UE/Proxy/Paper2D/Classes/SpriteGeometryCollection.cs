using Script.CoreUObject;
using Script.Library;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.SpriteGeometryCollection")]
	public partial class FSpriteGeometryCollection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Paper2D.SpriteGeometryCollection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSpriteGeometryCollection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSpriteGeometryCollection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSpriteGeometryCollection A, FSpriteGeometryCollection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSpriteGeometryCollection A, FSpriteGeometryCollection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSpriteGeometryCollection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FSpriteGeometryShape> Shapes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Shapes, __ReturnBuffer);

					return *(TArray<FSpriteGeometryShape>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Shapes, __InBuffer);
				}
			}
		}

		public ESpritePolygonMode GeometryType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GeometryType, __ReturnBuffer);

					return *(ESpritePolygonMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GeometryType, __InBuffer);
				}
			}
		}

		public int PixelsPerSubdivisionX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PixelsPerSubdivisionX, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PixelsPerSubdivisionX, __InBuffer);
				}
			}
		}

		public int PixelsPerSubdivisionY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PixelsPerSubdivisionY, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PixelsPerSubdivisionY, __InBuffer);
				}
			}
		}

		public bool bAvoidVertexMerging
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAvoidVertexMerging, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAvoidVertexMerging, __InBuffer);
				}
			}
		}

		public float AlphaThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AlphaThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AlphaThreshold, __InBuffer);
				}
			}
		}

		public float DetailAmount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DetailAmount, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DetailAmount, __InBuffer);
				}
			}
		}

		public float SimplifyEpsilon
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SimplifyEpsilon, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SimplifyEpsilon, __InBuffer);
				}
			}
		}

		private static uint __Shapes = 0;

		private static uint __GeometryType = 0;

		private static uint __PixelsPerSubdivisionX = 0;

		private static uint __PixelsPerSubdivisionY = 0;

		private static uint __bAvoidVertexMerging = 0;

		private static uint __AlphaThreshold = 0;

		private static uint __DetailAmount = 0;

		private static uint __SimplifyEpsilon = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}