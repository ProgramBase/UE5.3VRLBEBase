using Script.CoreUObject;
using Script.Library;

namespace Script.ProceduralMeshComponent
{
	[PathName("/Script/ProceduralMeshComponent.ProcMeshSection")]
	public partial class FProcMeshSection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ProceduralMeshComponent.ProcMeshSection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FProcMeshSection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FProcMeshSection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FProcMeshSection A, FProcMeshSection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FProcMeshSection A, FProcMeshSection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FProcMeshSection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FProcMeshVertex> ProcVertexBuffer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProcVertexBuffer, __ReturnBuffer);

					return *(TArray<FProcMeshVertex>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProcVertexBuffer, __InBuffer);
				}
			}
		}

		public TArray<uint> ProcIndexBuffer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProcIndexBuffer, __ReturnBuffer);

					return *(TArray<uint>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProcIndexBuffer, __InBuffer);
				}
			}
		}

		public FBox SectionLocalBox
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SectionLocalBox, __ReturnBuffer);

					return *(FBox*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SectionLocalBox, __InBuffer);
				}
			}
		}

		public bool bEnableCollision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEnableCollision, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEnableCollision, __InBuffer);
				}
			}
		}

		public bool bSectionVisible
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSectionVisible, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSectionVisible, __InBuffer);
				}
			}
		}

		private static uint __ProcVertexBuffer = 0;

		private static uint __ProcIndexBuffer = 0;

		private static uint __SectionLocalBox = 0;

		private static uint __bEnableCollision = 0;

		private static uint __bSectionVisible = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}