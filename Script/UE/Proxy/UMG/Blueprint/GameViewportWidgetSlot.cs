using Script.CoreUObject;
using Script.Library;
using Script.Slate;
using Script.SlateCore;

namespace Script.UMG
{
	[PathName("/Script/UMG.GameViewportWidgetSlot")]
	public partial class FGameViewportWidgetSlot : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMG.GameViewportWidgetSlot");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameViewportWidgetSlot() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGameViewportWidgetSlot() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGameViewportWidgetSlot A, FGameViewportWidgetSlot B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameViewportWidgetSlot A, FGameViewportWidgetSlot B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameViewportWidgetSlot;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

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

		public int ZOrder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ZOrder, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ZOrder, __InBuffer);
				}
			}
		}

		private static uint __Anchors = 0;

		private static uint __Offsets = 0;

		private static uint __Alignment = 0;

		private static uint __ZOrder = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}