using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CameraCacheEntry")]
	public partial class FCameraCacheEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CameraCacheEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCameraCacheEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCameraCacheEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCameraCacheEntry A, FCameraCacheEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCameraCacheEntry A, FCameraCacheEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCameraCacheEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float TimeStamp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TimeStamp, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TimeStamp, __InBuffer);
				}
			}
		}

		public FMinimalViewInfo POV
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __POV, __ReturnBuffer);

					return *(FMinimalViewInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __POV, __InBuffer);
				}
			}
		}

		private static uint __TimeStamp = 0;

		private static uint __POV = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}