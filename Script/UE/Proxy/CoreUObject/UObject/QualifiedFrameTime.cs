using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.QualifiedFrameTime")]
	public partial class FQualifiedFrameTime : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.QualifiedFrameTime");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FQualifiedFrameTime() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FQualifiedFrameTime() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FQualifiedFrameTime A, FQualifiedFrameTime B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FQualifiedFrameTime A, FQualifiedFrameTime B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FQualifiedFrameTime;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFrameTime Time
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Time, __ReturnBuffer);

					return *(FFrameTime*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Time, __InBuffer);
				}
			}
		}

		public FFrameRate Rate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Rate, __ReturnBuffer);

					return *(FFrameRate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Rate, __InBuffer);
				}
			}
		}

		private static uint __Time = 0;

		private static uint __Rate = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}