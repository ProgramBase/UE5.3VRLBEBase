using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PerQualityLevelFloat")]
	public partial class FPerQualityLevelFloat : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PerQualityLevelFloat");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPerQualityLevelFloat() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPerQualityLevelFloat() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPerQualityLevelFloat A, FPerQualityLevelFloat B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPerQualityLevelFloat A, FPerQualityLevelFloat B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPerQualityLevelFloat;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Default
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Default, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Default, __InBuffer);
				}
			}
		}

		public TMap<int, float> PerQuality
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PerQuality, __ReturnBuffer);

					return *(TMap<int, float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PerQuality, __InBuffer);
				}
			}
		}

		private static uint __Default = 0;

		private static uint __PerQuality = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}