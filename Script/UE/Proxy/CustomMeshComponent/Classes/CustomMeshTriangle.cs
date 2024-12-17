using Script.CoreUObject;
using Script.Library;

namespace Script.CustomMeshComponent
{
	[PathName("/Script/CustomMeshComponent.CustomMeshTriangle")]
	public partial class FCustomMeshTriangle : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CustomMeshComponent.CustomMeshTriangle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCustomMeshTriangle() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCustomMeshTriangle() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCustomMeshTriangle A, FCustomMeshTriangle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCustomMeshTriangle A, FCustomMeshTriangle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCustomMeshTriangle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector Vertex0
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Vertex0, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
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

		public FVector Vertex1
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Vertex1, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
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

		public FVector Vertex2
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Vertex2, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
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

		private static uint __Vertex0 = 0;

		private static uint __Vertex1 = 0;

		private static uint __Vertex2 = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}