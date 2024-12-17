using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;
using Script.Slate;

namespace Script.UMG
{
	[PathName("/Script/UMG.AnchorData")]
	public partial class FAnchorData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMG.AnchorData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnchorData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnchorData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnchorData A, FAnchorData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnchorData A, FAnchorData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnchorData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMargin Offsets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Offsets, __ReturnBuffer);

					return *(FMargin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Offsets, __InBuffer);
				}
			}
		}

		public FAnchors Anchors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Anchors, __ReturnBuffer);

					return *(FAnchors*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Anchors, __InBuffer);
				}
			}
		}

		public FVector2D Alignment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Alignment, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Alignment, __InBuffer);
				}
			}
		}

		private static uint __Offsets = 0;

		private static uint __Anchors = 0;

		private static uint __Alignment = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}