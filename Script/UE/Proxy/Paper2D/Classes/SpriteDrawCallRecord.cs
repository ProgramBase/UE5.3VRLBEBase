using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.SpriteDrawCallRecord")]
	public partial class FSpriteDrawCallRecord : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Paper2D.SpriteDrawCallRecord");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSpriteDrawCallRecord() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSpriteDrawCallRecord() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSpriteDrawCallRecord A, FSpriteDrawCallRecord B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSpriteDrawCallRecord A, FSpriteDrawCallRecord B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSpriteDrawCallRecord;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector Destination
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Destination, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Destination, __InBuffer);
				}
			}
		}

		public UTexture BaseTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BaseTexture, __ReturnBuffer);

					return *(UTexture*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BaseTexture, __InBuffer);
				}
			}
		}

		public FColor Color
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Color, __ReturnBuffer);

					return *(FColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Color, __InBuffer);
				}
			}
		}

		private static uint __Destination = 0;

		private static uint __BaseTexture = 0;

		private static uint __Color = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}