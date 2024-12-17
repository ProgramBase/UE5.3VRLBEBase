using Script.CoreUObject;
using Script.Library;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.PaperFlipbookKeyFrame")]
	public partial class FPaperFlipbookKeyFrame : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Paper2D.PaperFlipbookKeyFrame");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPaperFlipbookKeyFrame() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPaperFlipbookKeyFrame() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPaperFlipbookKeyFrame A, FPaperFlipbookKeyFrame B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPaperFlipbookKeyFrame A, FPaperFlipbookKeyFrame B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPaperFlipbookKeyFrame;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UPaperSprite Sprite
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Sprite, __ReturnBuffer);

					return *(UPaperSprite*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Sprite, __InBuffer);
				}
			}
		}

		public int FrameRun
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FrameRun, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FrameRun, __InBuffer);
				}
			}
		}

		private static uint __Sprite = 0;

		private static uint __FrameRun = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}