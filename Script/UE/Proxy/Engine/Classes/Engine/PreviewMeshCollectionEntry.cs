using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PreviewMeshCollectionEntry")]
	public partial class FPreviewMeshCollectionEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PreviewMeshCollectionEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPreviewMeshCollectionEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPreviewMeshCollectionEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPreviewMeshCollectionEntry A, FPreviewMeshCollectionEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPreviewMeshCollectionEntry A, FPreviewMeshCollectionEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPreviewMeshCollectionEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSoftObjectPtr<USkeletalMesh> SkeletalMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SkeletalMesh, __ReturnBuffer);

					return *(TSoftObjectPtr<USkeletalMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SkeletalMesh, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UAnimBlueprint> AnimBlueprint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AnimBlueprint, __ReturnBuffer);

					return *(TSoftObjectPtr<UAnimBlueprint>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AnimBlueprint, __InBuffer);
				}
			}
		}

		private static uint __SkeletalMesh = 0;

		private static uint __AnimBlueprint = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}