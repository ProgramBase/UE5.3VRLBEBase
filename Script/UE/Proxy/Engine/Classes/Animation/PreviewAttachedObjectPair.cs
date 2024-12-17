using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PreviewAttachedObjectPair")]
	public partial class FPreviewAttachedObjectPair : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PreviewAttachedObjectPair");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPreviewAttachedObjectPair() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPreviewAttachedObjectPair() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPreviewAttachedObjectPair A, FPreviewAttachedObjectPair B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPreviewAttachedObjectPair A, FPreviewAttachedObjectPair B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPreviewAttachedObjectPair;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSoftObjectPtr<UObject> AttachedObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AttachedObject, __ReturnBuffer);

					return *(TSoftObjectPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AttachedObject, __InBuffer);
				}
			}
		}

		public FName AttachedTo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AttachedTo, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AttachedTo, __InBuffer);
				}
			}
		}

		private static uint __AttachedObject = 0;

		private static uint __AttachedTo = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}