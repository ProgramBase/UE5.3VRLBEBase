using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PreviewAssetAttachContainer")]
	public partial class FPreviewAssetAttachContainer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PreviewAssetAttachContainer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPreviewAssetAttachContainer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPreviewAssetAttachContainer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPreviewAssetAttachContainer A, FPreviewAssetAttachContainer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPreviewAssetAttachContainer A, FPreviewAssetAttachContainer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPreviewAssetAttachContainer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FPreviewAttachedObjectPair> AttachedObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AttachedObjects, __ReturnBuffer);

					return *(TArray<FPreviewAttachedObjectPair>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AttachedObjects, __InBuffer);
				}
			}
		}

		private static uint __AttachedObjects = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}