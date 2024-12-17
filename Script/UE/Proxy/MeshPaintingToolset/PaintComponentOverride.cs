using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.MeshPaintingToolset
{
	[PathName("/Script/MeshPaintingToolset.PaintComponentOverride")]
	public partial class FPaintComponentOverride : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshPaintingToolset.PaintComponentOverride");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPaintComponentOverride() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPaintComponentOverride() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPaintComponentOverride A, FPaintComponentOverride B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPaintComponentOverride A, FPaintComponentOverride B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPaintComponentOverride;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UMeshComponent> PaintedComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PaintedComponents, __ReturnBuffer);

					return *(TArray<UMeshComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PaintedComponents, __InBuffer);
				}
			}
		}

		private static uint __PaintedComponents = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}