using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StaticMeshVertexColorLODData")]
	public partial class FStaticMeshVertexColorLODData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StaticMeshVertexColorLODData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStaticMeshVertexColorLODData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStaticMeshVertexColorLODData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStaticMeshVertexColorLODData A, FStaticMeshVertexColorLODData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStaticMeshVertexColorLODData A, FStaticMeshVertexColorLODData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStaticMeshVertexColorLODData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FPaintedVertex> PaintedVertices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PaintedVertices, __ReturnBuffer);

					return *(TArray<FPaintedVertex>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PaintedVertices, __InBuffer);
				}
			}
		}

		public TArray<FColor> VertexBufferColors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VertexBufferColors, __ReturnBuffer);

					return *(TArray<FColor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VertexBufferColors, __InBuffer);
				}
			}
		}

		public uint LODIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LODIndex, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LODIndex, __InBuffer);
				}
			}
		}

		private static uint __PaintedVertices = 0;

		private static uint __VertexBufferColors = 0;

		private static uint __LODIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}