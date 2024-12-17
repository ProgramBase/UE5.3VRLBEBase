using Script.CoreUObject;
using Script.Library;

namespace Script.ProceduralMeshComponent
{
	[PathName("/Script/ProceduralMeshComponent.ProcMeshTangent")]
	public partial class FProcMeshTangent : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ProceduralMeshComponent.ProcMeshTangent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FProcMeshTangent() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FProcMeshTangent() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FProcMeshTangent A, FProcMeshTangent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FProcMeshTangent A, FProcMeshTangent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FProcMeshTangent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector TangentX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TangentX, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TangentX, __InBuffer);
				}
			}
		}

		public bool bFlipTangentY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bFlipTangentY, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bFlipTangentY, __InBuffer);
				}
			}
		}

		private static uint __TangentX = 0;

		private static uint __bFlipTangentY = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}