using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RawAnimSequenceTrack")]
	public partial class FRawAnimSequenceTrack : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RawAnimSequenceTrack");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRawAnimSequenceTrack() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRawAnimSequenceTrack() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRawAnimSequenceTrack A, FRawAnimSequenceTrack B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRawAnimSequenceTrack A, FRawAnimSequenceTrack B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRawAnimSequenceTrack;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FVector3f> PosKeys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PosKeys, __ReturnBuffer);

					return *(TArray<FVector3f>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PosKeys, __InBuffer);
				}
			}
		}

		public TArray<FQuat4f> RotKeys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RotKeys, __ReturnBuffer);

					return *(TArray<FQuat4f>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RotKeys, __InBuffer);
				}
			}
		}

		public TArray<FVector3f> ScaleKeys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScaleKeys, __ReturnBuffer);

					return *(TArray<FVector3f>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScaleKeys, __InBuffer);
				}
			}
		}

		private static uint __PosKeys = 0;

		private static uint __RotKeys = 0;

		private static uint __ScaleKeys = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}