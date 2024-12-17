using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PerQualityLevelInt")]
	public partial class FPerQualityLevelInt : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PerQualityLevelInt");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPerQualityLevelInt() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPerQualityLevelInt() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPerQualityLevelInt A, FPerQualityLevelInt B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPerQualityLevelInt A, FPerQualityLevelInt B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPerQualityLevelInt;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Default
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Default, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Default, __InBuffer);
				}
			}
		}

		public TMap<int, int> PerQuality
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PerQuality, __ReturnBuffer);

					return *(TMap<int, int>*)__ReturnBuffer;
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