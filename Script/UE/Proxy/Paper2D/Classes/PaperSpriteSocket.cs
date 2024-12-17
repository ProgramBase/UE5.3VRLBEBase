using Script.CoreUObject;
using Script.Library;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.PaperSpriteSocket")]
	public partial class FPaperSpriteSocket : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Paper2D.PaperSpriteSocket");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPaperSpriteSocket() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPaperSpriteSocket() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPaperSpriteSocket A, FPaperSpriteSocket B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPaperSpriteSocket A, FPaperSpriteSocket B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPaperSpriteSocket;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTransform LocalTransform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LocalTransform, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LocalTransform, __InBuffer);
				}
			}
		}

		public FName SocketName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SocketName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SocketName, __InBuffer);
				}
			}
		}

		private static uint __LocalTransform = 0;

		private static uint __SocketName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}