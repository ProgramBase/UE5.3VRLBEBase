using Script.CoreUObject;
using Script.Library;

namespace Script.Localization
{
	[PathName("/Script/Localization.GatherTextSearchDirectory")]
	public partial class FGatherTextSearchDirectory : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Localization.GatherTextSearchDirectory");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGatherTextSearchDirectory() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGatherTextSearchDirectory() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGatherTextSearchDirectory A, FGatherTextSearchDirectory B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGatherTextSearchDirectory A, FGatherTextSearchDirectory B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGatherTextSearchDirectory;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ELocalizationGatherPathRoot PathRoot
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PathRoot, __ReturnBuffer);

					return *(ELocalizationGatherPathRoot*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PathRoot, __InBuffer);
				}
			}
		}

		public FString Path
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Path, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Path, __InBuffer);
				}
			}
		}

		private static uint __PathRoot = 0;

		private static uint __Path = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}